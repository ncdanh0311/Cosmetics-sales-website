using project_mvc.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class TaiKhoanAdminController : AdminBaseController
    {
        // KHÔNG cần db + SetSidebarStats nữa, đã có trong AdminBaseController

        // GET: TaiKhoanAdmin
        public ActionResult Index()
        {
            return RedirectToAction("QuanLyTaiKhoan");
        }

        // GET: TaiKhoanAdmin/QuanLyTaiKhoan  (id = tài khoản cần sửa, null = thêm mới)
        public ActionResult QuanLyTaiKhoan(int? id, string search)
        {
            var vm = new QuanLyTaiKhoanViewModel();

            // Danh sách tài khoản
            vm.DanhSach = db.NGUOIDUNG
                            .OrderByDescending(t => t.NGAYTAO)
                            .ToList();

            if (!string.IsNullOrEmpty(search))
            {
                string keyword = search.ToLower();

                vm.DanhSach = vm.DanhSach
                                .Where(t =>
                                       (t.HOTEN != null && t.HOTEN.ToLower().Contains(keyword)) ||
                                       (t.EMAIL != null && t.EMAIL.ToLower().Contains(keyword)) ||
                                       (t.SODT != null && t.SODT.Contains(keyword))
                                )
                                .ToList();

                TempData["SearchInfo"] = $"Kết quả cho: \"{search}\"";
            }

            if (id.HasValue)
            {
                vm.TaiKhoan = db.NGUOIDUNG.Find(id.Value);
                if (vm.TaiKhoan == null)
                {
                    TempData["Error"] = "Không tìm thấy tài khoản cần sửa.";
                    vm.TaiKhoan = new NGUOIDUNG { VAITRO = "khachhang" };
                    ViewBag.IsEdit = false;
                }
                else
                {
                    ViewBag.IsEdit = true;
                }
            }
            else
            {
                vm.TaiKhoan = new NGUOIDUNG
                {
                    VAITRO = "khachhang"
                };
                ViewBag.IsEdit = false;
            }

            return View(vm);
        }

        // POST: TaiKhoanAdmin/LuuTaiKhoan  (thêm + sửa dùng chung)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LuuTaiKhoan(QuanLyTaiKhoanViewModel vm)
        {
            try
            {
                var model = vm.TaiKhoan;

                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Vui lòng kiểm tra lại thông tin!";
                    vm.DanhSach = db.NGUOIDUNG
                                    .OrderByDescending(t => t.NGAYTAO)
                                    .ToList();
                    ViewBag.IsEdit = vm.TaiKhoan.MAND != 0;
                    return View("QuanLyTaiKhoan", vm);
                }

                bool emailTrung = db.NGUOIDUNG.Any(t => t.EMAIL == model.EMAIL && t.MAND != model.MAND);
                if (emailTrung)
                {
                    TempData["Error"] = "Email đã tồn tại trong hệ thống!";
                    vm.DanhSach = db.NGUOIDUNG.OrderByDescending(t => t.NGAYTAO).ToList();
                    ViewBag.IsEdit = vm.TaiKhoan.MAND != 0;
                    return View("QuanLyTaiKhoan", vm);
                }

                bool sdtTrung = db.NGUOIDUNG.Any(t => t.SODT == model.SODT && t.MAND != model.MAND);
                if (sdtTrung)
                {
                    TempData["Error"] = "Số điện thoại đã tồn tại trong hệ thống!";
                    vm.DanhSach = db.NGUOIDUNG.OrderByDescending(t => t.NGAYTAO).ToList();
                    ViewBag.IsEdit = vm.TaiKhoan.MAND != 0;
                    return View("QuanLyTaiKhoan", vm);
                }

                // THÊM MỚI
                if (model.MAND == 0)
                {
                    model.NGAYTAO = DateTime.Now;
                    model.VAITRO = string.IsNullOrEmpty(model.VAITRO) ? "khachhang" : model.VAITRO;

                    db.NGUOIDUNG.Add(model);
                    db.SaveChanges();

                    TempData["Success"] = "Thêm tài khoản thành công!";
                }
                else // CẬP NHẬT
                {
                    var account = db.NGUOIDUNG.Find(model.MAND);
                    if (account == null)
                    {
                        TempData["Error"] = "Không tìm thấy tài khoản cần sửa.";
                        return RedirectToAction("QuanLyTaiKhoan");
                    }

                    account.HOTEN = model.HOTEN;
                    account.EMAIL = model.EMAIL;
                    account.SODT = model.SODT;
                    account.DIACHI = model.DIACHI;
                    account.VAITRO = model.VAITRO;

                    if (!string.IsNullOrWhiteSpace(model.MATKHAU))
                    {
                        account.MATKHAU = model.MATKHAU;
                    }

                    db.Entry(account).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Success"] = "Cập nhật tài khoản thành công!";
                }

                return RedirectToAction("QuanLyTaiKhoan");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;

                vm.DanhSach = db.NGUOIDUNG
                                .OrderByDescending(t => t.NGAYTAO)
                                .ToList();
                ViewBag.IsEdit = vm.TaiKhoan.MAND != 0;
                return View("QuanLyTaiKhoan", vm);
            }
        }

        // POST: TaiKhoanAdmin/XoaTaiKhoan
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaTaiKhoan(int id)
        {
            try
            {
                var account = db.NGUOIDUNG.Find(id);
                if (account == null)
                {
                    TempData["Error"] = "Không tìm thấy tài khoản!";
                    return RedirectToAction("QuanLyTaiKhoan");
                }

                db.NGUOIDUNG.Remove(account);
                db.SaveChanges();

                TempData["Success"] = "Xóa tài khoản thành công!";
                return RedirectToAction("QuanLyTaiKhoan");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLyTaiKhoan");
            }
        }
    }
}
