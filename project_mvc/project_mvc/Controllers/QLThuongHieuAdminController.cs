using project_mvc.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class QLThuongHieuAdminController : AdminBaseController
    {
        // KHÔNG khai báo lại db, dùng db từ AdminBaseController

        // GET: /QLThuongHieuAdmin
        public ActionResult Index()
        {
            return RedirectToAction("QuanLyThuongHieu");
        }

        // GET: /QLThuongHieuAdmin/QuanLyThuongHieu (id = thương hiệu cần sửa, null = thêm mới)
        public ActionResult QuanLyThuongHieu(int? id)
        {
            var vm = new QuanLyThuongHieuViewModel();

            // Danh sách thương hiệu
            vm.DanhSach = db.THUONGHIEU
                            .OrderBy(t => t.MATH)
                            .ToList();

            if (id.HasValue)
            {
                vm.ThuongHieu = db.THUONGHIEU.Find(id.Value);
                if (vm.ThuongHieu == null)
                {
                    TempData["Error"] = "Không tìm thấy thương hiệu cần sửa.";
                    vm.ThuongHieu = new THUONGHIEU();
                    ViewBag.IsEdit = false;
                }
                else
                {
                    ViewBag.IsEdit = true;
                }
            }
            else
            {
                vm.ThuongHieu = new THUONGHIEU();
                ViewBag.IsEdit = false;
            }

            return View(vm);
        }

        // POST: /QLThuongHieuAdmin/LuuThuongHieu (thêm + sửa dùng chung)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LuuThuongHieu(QuanLyThuongHieuViewModel vm)
        {
            try
            {
                var model = vm.ThuongHieu;

                if (string.IsNullOrWhiteSpace(model.TENTH))
                {
                    ModelState.AddModelError("ThuongHieu.TENTH", "Tên thương hiệu không được để trống.");
                }

                // Nếu validate lỗi -> trả lại view + danh sách
                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Vui lòng kiểm tra lại thông tin!";
                    vm.DanhSach = db.THUONGHIEU
                                    .OrderBy(t => t.MATH)
                                    .ToList();

                    ViewBag.IsEdit = vm.ThuongHieu.MATH != 0;
                    return View("QuanLyThuongHieu", vm);
                }

                // Kiểm tra tên thương hiệu trùng (trừ chính nó nếu sửa)
                bool tenTrung = db.THUONGHIEU.Any(t => t.TENTH == model.TENTH && t.MATH != model.MATH);
                if (tenTrung)
                {
                    TempData["Error"] = "Tên thương hiệu đã tồn tại!";
                    vm.DanhSach = db.THUONGHIEU
                                    .OrderBy(t => t.MATH)
                                    .ToList();

                    ViewBag.IsEdit = vm.ThuongHieu.MATH != 0;
                    return View("QuanLyThuongHieu", vm);
                }

                // THÊM MỚI (MATH là identity nên để 0, DB tự tăng)
                if (model.MATH == 0)
                {
                    db.THUONGHIEU.Add(model);
                    db.SaveChanges();

                    TempData["Success"] = "Thêm thương hiệu thành công!";
                }
                else // CẬP NHẬT
                {
                    var th = db.THUONGHIEU.Find(model.MATH);
                    if (th == null)
                    {
                        TempData["Error"] = "Không tìm thấy thương hiệu cần sửa.";
                        return RedirectToAction("QuanLyThuongHieu");
                    }

                    th.TENTH = model.TENTH;
                    th.MOTA = model.MOTA;

                    db.Entry(th).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Success"] = "Cập nhật thương hiệu thành công!";
                }

                return RedirectToAction("QuanLyThuongHieu");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;

                vm.DanhSach = db.THUONGHIEU
                                .OrderBy(t => t.TENTH)
                                .ToList();
                ViewBag.IsEdit = vm.ThuongHieu.MATH != 0;
                return View("QuanLyThuongHieu", vm);
            }
        }

        // POST: /QLThuongHieuAdmin/XoaThuongHieu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaThuongHieu(int id)
        {
            try
            {
                var th = db.THUONGHIEU.Find(id);
                if (th == null)
                {
                    TempData["Error"] = "Không tìm thấy thương hiệu!";
                    return RedirectToAction("QuanLyThuongHieu");
                }

                bool coSanPham = db.SANPHAM.Any(sp => sp.MATH == id);
                if (coSanPham)
                {
                    TempData["Error"] = "Không thể xóa thương hiệu vì đang có sản phẩm sử dụng!";
                    return RedirectToAction("QuanLyThuongHieu");
                }

                db.THUONGHIEU.Remove(th);
                db.SaveChanges();

                TempData["Success"] = "Xóa thương hiệu thành công!";
                return RedirectToAction("QuanLyThuongHieu");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLyThuongHieu");
            }
        }
    }
}
