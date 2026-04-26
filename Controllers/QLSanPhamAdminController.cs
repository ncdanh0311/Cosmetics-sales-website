using project_mvc.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class QLSanPhamAdminController : AdminBaseController
    {
        // KHÔNG khai báo lại db ở đây, dùng db từ AdminBaseController

        private void SetDropDowns(QuanLySanPhamViewModel vm)
        {
            vm.DanhMucList = db.DANHMUC
                .OrderBy(d => d.TENDANHMUC)
                .ToList()
                .Select(d => new SelectListItem
                {
                    Value = d.MADANHMUC,
                    Text = d.TENDANHMUC
                })
                .ToList();

            vm.ThuongHieuList = db.THUONGHIEU
                .OrderBy(t => t.TENTH)
                .ToList()
                .Select(t => new SelectListItem
                {
                    Value = t.MATH.ToString(),
                    Text = t.TENTH
                })
                .ToList();
        }

        public ActionResult Index()
        {
            return RedirectToAction("QuanLySanPham");
        }

        // GET: /QLSanPhamAdmin/QuanLySanPham   (id = MASP cần sửa, null = thêm mới)
        // Tìm kiếm sản phẩm
        public ActionResult QuanLySanPham(int? id, string search)
        {
            var vm = new QuanLySanPhamViewModel();

            vm.DanhSach = db.SANPHAM
                            .Include(s => s.DANHMUC)
                            .Include(s => s.THUONGHIEU)
                            .OrderByDescending(s => s.NGAYTAO)
                            .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                string keyword = search.ToLower().Trim();
                vm.DanhSach = vm.DanhSach
                    .Where(s => (s.TENSP ?? "").ToLower().Contains(keyword)
                             || s.MASP.ToString().ToLower().Contains(keyword))
                    .ToList();
            }

            if (id.HasValue)
            {
                vm.SanPham = db.SANPHAM.Find(id.Value);
                if (vm.SanPham == null)
                {
                    TempData["Error"] = "Không tìm thấy sản phẩm cần sửa.";
                    vm.SanPham = new SANPHAM { SOLUONG = 0, KHUYENMAI = 0 };
                    ViewBag.IsEdit = false;
                }
                else
                {
                    ViewBag.IsEdit = true;
                }
            }
            else
            {
                vm.SanPham = new SANPHAM
                {
                    SOLUONG = 0,
                    KHUYENMAI = 0
                };
                ViewBag.IsEdit = false;
            }

            SetDropDowns(vm);

            // KHÔNG cần set ViewBag.TongSanPham ở đây nữa vì AdminBaseController đã lo

            return View(vm);
        }

        // POST: /QLSanPhamAdmin/LuuSanPham   (thêm + sửa dùng chung)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LuuSanPham(QuanLySanPhamViewModel vm, HttpPostedFileBase HinhAnhFile)
        {
            try
            {
                var model = vm.SanPham;

                // ==== VALIDATE CƠ BẢN ====
                if (string.IsNullOrWhiteSpace(model.TENSP))
                    ModelState.AddModelError("SanPham.TENSP", "Tên sản phẩm không được để trống.");

                if (string.IsNullOrWhiteSpace(model.MADM))
                    ModelState.AddModelError("SanPham.MADM", "Vui lòng chọn danh mục.");

                if (model.MATH <= 0)
                    ModelState.AddModelError("SanPham.MATH", "Vui lòng chọn thương hiệu.");

                if (model.GIABAN <= 0)
                    ModelState.AddModelError("SanPham.GIABAN", "Giá bán phải lớn hơn 0.");

                if (model.SOLUONG < 0)
                    ModelState.AddModelError("SanPham.SOLUONG", "Số lượng không hợp lệ.");

                if (model.KHUYENMAI < 0)
                    ModelState.AddModelError("SanPham.KHUYENMAI", "Khuyến mãi không hợp lệ.");

                // ==== XỬ LÝ FILE ẢNH ====
                string imagesFolder = Server.MapPath("~/Images");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                if (HinhAnhFile != null && HinhAnhFile.ContentLength > 0)
                {
                    string ext = Path.GetExtension(HinhAnhFile.FileName).ToLower();
                    string[] allowed = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };

                    if (!allowed.Contains(ext))
                    {
                        ModelState.AddModelError("HinhAnhFile", "Chỉ chấp nhận file ảnh JPG, PNG, GIF, WEBP.");
                    }
                    else
                    {
                        string newFileName = Guid.NewGuid().ToString("N") + ext;
                        string fullPath = Path.Combine(imagesFolder, newFileName);

                        HinhAnhFile.SaveAs(fullPath);

                        // Lưu tên file vào DB
                        model.HINHANH = newFileName;
                    }
                }
                else
                {
                    // Nếu thêm mới mà không chọn ảnh -> báo lỗi
                    if (model.MASP == 0 && string.IsNullOrEmpty(model.HINHANH))
                    {
                        ModelState.AddModelError("HinhAnhFile", "Vui lòng chọn hình ảnh sản phẩm.");
                    }
                }

                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Vui lòng kiểm tra lại thông tin!";

                    vm.DanhSach = db.SANPHAM
                                    .Include(s => s.DANHMUC)
                                    .Include(s => s.THUONGHIEU)
                                    .OrderByDescending(s => s.NGAYTAO)
                                    .ToList();

                    ViewBag.IsEdit = vm.SanPham.MASP != 0;
                    SetDropDowns(vm);

                    return View("QuanLySanPham", vm);
                }

                // ==== THÊM / SỬA ====
                if (model.MASP == 0)
                {
                    model.NGAYTAO = DateTime.Now;
                    db.SANPHAM.Add(model);
                    db.SaveChanges();
                    TempData["Success"] = "Thêm sản phẩm thành công!";
                }
                else
                {
                    var sp = db.SANPHAM.Find(model.MASP);
                    if (sp == null)
                    {
                        TempData["Error"] = "Không tìm thấy sản phẩm cần sửa.";
                        return RedirectToAction("QuanLySanPham");
                    }

                    sp.TENSP = model.TENSP;
                    sp.GIABAN = model.GIABAN;
                    sp.MADM = model.MADM;
                    sp.MATH = model.MATH;
                    sp.SOLUONG = model.SOLUONG;
                    sp.KHUYENMAI = model.KHUYENMAI;
                    sp.MoTa = model.MoTa;

                    if (!string.IsNullOrEmpty(model.HINHANH))
                    {
                        sp.HINHANH = model.HINHANH;
                    }

                    db.Entry(sp).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Success"] = "Cập nhật sản phẩm thành công!";
                }

                return RedirectToAction("QuanLySanPham");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;

                vm.DanhSach = db.SANPHAM
                                .Include(s => s.DANHMUC)
                                .Include(s => s.THUONGHIEU)
                                .OrderByDescending(s => s.NGAYTAO)
                                .ToList();

                ViewBag.IsEdit = vm.SanPham.MASP != 0;
                SetDropDowns(vm);

                return View("QuanLySanPham", vm);
            }
        }

        // POST: /QLSanPhamAdmin/XoaSanPham
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaSanPham(int id)
        {
            try
            {
                var sp = db.SANPHAM.Find(id);
                if (sp == null)
                {
                    TempData["Error"] = "Không tìm thấy sản phẩm!";
                    return RedirectToAction("QuanLySanPham");
                }

                db.SANPHAM.Remove(sp);
                db.SaveChanges();

                TempData["Success"] = "Xóa sản phẩm thành công!";
                return RedirectToAction("QuanLySanPham");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLySanPham");
            }
        }
    }
}
