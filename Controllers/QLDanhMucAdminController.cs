using project_mvc.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    // KẾ THỪA ADMINBASECONTROLLER ĐỂ LUÔN CÓ ViewBag.TongSanPham
    public class QLDanhMucAdminController : AdminBaseController
    {
        // KHÔNG khai báo lại db ở đây, đã có trong AdminBaseController
        // TheFaceShop4Entities db = new TheFaceShop4Entities();

        // GET: /QLDanhMucAdmin
        public ActionResult Index()
        {
            return RedirectToAction("QuanLyDanhMuc");
        }

        // GET: /QLDanhMucAdmin/QuanLyDanhMuc  (id = mã danh mục cần sửa, null = thêm mới)
        public ActionResult QuanLyDanhMuc(string id)
        {
            var vm = new QuanLyDanhMucViewModel();

            // Danh sách danh mục (sắp xếp mã tăng dần)
            vm.DanhSach = db.DANHMUC
                            .OrderBy(d => d.MADANHMUC)
                            .ToList();

            if (!string.IsNullOrEmpty(id))
            {
                vm.DanhMuc = db.DANHMUC.Find(id);
                if (vm.DanhMuc == null)
                {
                    TempData["Error"] = "Không tìm thấy danh mục cần sửa.";
                    vm.DanhMuc = new DANHMUC();
                    ViewBag.IsEdit = false;
                }
                else
                {
                    ViewBag.IsEdit = true;
                }
            }
            else
            {
                vm.DanhMuc = new DANHMUC();
                ViewBag.IsEdit = false;
            }

            return View(vm);
        }

        // POST: /QLDanhMucAdmin/LuuDanhMuc  (thêm + sửa dùng chung)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LuuDanhMuc(QuanLyDanhMucViewModel vm)
        {
            try
            {
                var model = vm.DanhMuc;

                // Validate thủ công vì MADANHMUC, TENDANHMUC đều bắt buộc
                if (string.IsNullOrWhiteSpace(model.MADANHMUC))
                {
                    ModelState.AddModelError("DanhMuc.MADANHMUC", "Mã danh mục không được để trống.");
                }
                if (string.IsNullOrWhiteSpace(model.TENDANHMUC))
                {
                    ModelState.AddModelError("DanhMuc.TENDANHMUC", "Tên danh mục không được để trống.");
                }

                // Nếu validate lỗi -> trả lại view + danh sách
                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Vui lòng kiểm tra lại thông tin!";
                    vm.DanhSach = db.DANHMUC
                                    .OrderBy(d => d.MADANHMUC)
                                    .ToList();
                    ViewBag.IsEdit = !string.IsNullOrEmpty(vm.DanhMuc.MADANHMUC);
                    return View("QuanLyDanhMuc", vm);
                }

                // Kiểm tra tên danh mục trùng (trừ chính nó nếu sửa)
                bool tenTrung = db.DANHMUC.Any(d => d.TENDANHMUC == model.TENDANHMUC
                                                 && d.MADANHMUC != model.MADANHMUC);
                if (tenTrung)
                {
                    TempData["Error"] = "Tên danh mục đã tồn tại!";
                    vm.DanhSach = db.DANHMUC.OrderBy(d => d.MADANHMUC).ToList();
                    ViewBag.IsEdit = !string.IsNullOrEmpty(vm.DanhMuc.MADANHMUC);
                    return View("QuanLyDanhMuc", vm);
                }

                // Xác định thêm mới hay cập nhật dựa vào MÃ
                var existing = db.DANHMUC.Find(model.MADANHMUC);

                if (existing == null)
                {
                    // THÊM MỚI (mã do người dùng nhập, không auto tăng)
                    db.DANHMUC.Add(model);
                    db.SaveChanges();

                    TempData["Success"] = "Thêm danh mục thành công!";
                }
                else
                {
                    // CẬP NHẬT (không cho đổi mã, chỉ đổi tên)
                    existing.TENDANHMUC = model.TENDANHMUC;

                    db.Entry(existing).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Success"] = "Cập nhật danh mục thành công!";
                }

                return RedirectToAction("QuanLyDanhMuc");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;

                // Khi lỗi, load lại danh sách + trả về view
                vm.DanhSach = db.DANHMUC
                                .OrderBy(d => d.MADANHMUC)
                                .ToList();
                ViewBag.IsEdit = !string.IsNullOrEmpty(vm.DanhMuc.MADANHMUC);
                return View("QuanLyDanhMuc", vm);
            }
        }

        // POST: /QLDanhMucAdmin/XoaDanhMuc
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaDanhMuc(string id)
        {
            try
            {
                var dm = db.DANHMUC.Find(id);
                if (dm == null)
                {
                    TempData["Error"] = "Không tìm thấy danh mục!";
                    return RedirectToAction("QuanLyDanhMuc");
                }

                // Nếu có sản phẩm thuộc danh mục này thì chặn xóa (tuỳ bạn)
                bool coSanPham = db.SANPHAM.Any(sp => sp.MADM == id);
                if (coSanPham)
                {
                    TempData["Error"] = "Không thể xóa danh mục vì đang có sản phẩm sử dụng!";
                    return RedirectToAction("QuanLyDanhMuc");
                }

                db.DANHMUC.Remove(dm);
                db.SaveChanges();

                TempData["Success"] = "Xóa danh mục thành công!";
                return RedirectToAction("QuanLyDanhMuc");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLyDanhMuc");
            }
        }
    }
}
