
using project_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace project_mvc.Controllers
{
    public class HomeController : Controller
    {
        TheFaceShop4Entities db = new TheFaceShop4Entities();
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("About");
        }
        public ActionResult About()
        {
            var vm = new HomeAboutViewModel();

            // Query sản phẩm 1 lần, tránh lặp lại nhiều lần
            var allProducts = db.SANPHAM.AsQueryable();

            // 1. Flash sale: sản phẩm có khuyến mãi > 0
            vm.FlashSale = allProducts
                .Where(s => s.KHUYENMAI > 0)
                .OrderByDescending(s => s.KHUYENMAI)
                .ThenByDescending(s => s.NGAYTAO)
                .Take(12)
                .ToList();

            // 2. Bán chạy - Chăm sóc da (DM001)
            vm.BestSkincare = allProducts
                .Where(s => s.DANHMUC != null && s.DANHMUC.MADANHMUC == "DM001")
                .OrderByDescending(s => s.NGAYTAO)
                .Take(8)
                .ToList();

            // 3. Bán chạy - Trang điểm (DM002)
            vm.BestMakeup = allProducts
                .Where(s => s.DANHMUC != null && s.DANHMUC.MADANHMUC == "DM002")
                .OrderByDescending(s => s.NGAYTAO)
                .Take(8)
                .ToList();

            // 4. Bán chạy - Chăm sóc tóc (DM003)
            vm.BestHair = allProducts
                .Where(s => s.DANHMUC != null && s.DANHMUC.MADANHMUC == "DM003")
                .OrderByDescending(s => s.NGAYTAO)
                .Take(8)
                .ToList();

            // 5. Hàng mới về: theo NGAYTAO
            vm.NewArrivals = allProducts
                .OrderByDescending(s => s.NGAYTAO)
                .Take(12)
                .ToList();

            return View(vm);
        }

        private readonly string connectionString = @"Data Source=KIEU_PHAT;Initial Catalog=TheFaceShop;Integrated Security=True;TrustServerCertificate=True";




        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(string HOTEN, string EMAIL, string MATKHAU, string ConfirmPassword)
        {
            // 1. Kiểm tra mật khẩu trùng
            if (MATKHAU != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Mật khẩu xác nhận không khớp.");
            }

            // 2. Kiểm tra độ dài mật khẩu ≥ 6
            if (string.IsNullOrWhiteSpace(MATKHAU) || MATKHAU.Length < 6)
            {
                ModelState.AddModelError("MATKHAU", "Mật khẩu phải từ 6 ký tự trở lên.");
            }

            // 3. Kiểm tra email trùng
            var existed = db.NGUOIDUNG.Any(u => u.EMAIL == EMAIL);
            if (existed)
            {
                ModelState.AddModelError("EMAIL", "Email này đã được sử dụng.");
            }

            // 4. Nếu có lỗi → quay lại view, kèm ModelState lỗi
            if (!ModelState.IsValid)
            {
                return View();   // View DangKy.cshtml
            }

            // 5. Lưu vào DB
            var user = new NGUOIDUNG
            {
                HOTEN = HOTEN,
                EMAIL = EMAIL,
                MATKHAU = MATKHAU, // thực tế nên mã hóa
                VAITRO = "khachhang",
                NGAYTAO = DateTime.Now
            };

            db.NGUOIDUNG.Add(user);
            db.SaveChanges();

            // 6. Auto đăng nhập
            Session["UserId"] = user.MAND;
            Session["UserName"] = user.HOTEN;
            Session["UserRole"] = user.VAITRO;

            return RedirectToAction("About", "Home");
        }



        // GET: /Home/DangNhap
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        // POST: /Home/DangNhap
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(string account, string password)
        {
            // 1. Kiểm tra nhập thiếu
            if (string.IsNullOrWhiteSpace(account) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Vui lòng nhập đầy đủ tài khoản và mật khẩu.";
                return View();
            }

            // 2. Tìm user theo EMAIL hoặc SODT + MATKHAU
            var user = db.NGUOIDUNG.FirstOrDefault(x =>
                (x.EMAIL == account || x.SODT == account) &&
                x.MATKHAU == password
            );

            if (user == null)
            {
                ViewBag.Error = "Tài khoản hoặc mật khẩu không đúng.";
                return View();
            }

            // 3. LƯU THÔNG TIN ĐĂNG NHẬP VÀO SESSION
            Session["UserId"] = user.MAND;
            Session["UserName"] = user.HOTEN;
            Session["UserRole"] = user.VAITRO;

            // 4. Điều hướng theo vai trò
            if (user.VAITRO == "admin")
            {
                // Đổi "Admin" / "Index" thành controller + action quản trị thật của bạn
                return RedirectToAction("QuanLySanPham", "QLSanPhamAdmin");
            }

            // Khách hàng -> về trang chủ hoặc chỗ bạn muốn
            return RedirectToAction("About", "Home");
        }

        public ActionResult DangXuat()
        {
            Session.Clear();          // Xóa toàn bộ session
                                      // Có thể dùng: Session.Abandon();
            return RedirectToAction("DangNhap", "Home");

        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("DangNhap", "Home");
        }


    }
}
