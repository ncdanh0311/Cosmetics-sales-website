using project_mvc.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class DonHangController : Controller
    {
        TheFaceShop4Entities db = new TheFaceShop4Entities();

        // ==== HÀM PHỤ LẤY USER ID TỪ SESSION ====
        private int? CurrentUserId
        {
            get
            {
                if (Session["UserId"] == null) return null;
                int id;
                if (int.TryParse(Session["UserId"].ToString(), out id))
                    return id;
                return null;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Huy(int id)
        {
            if (Session["UserId"] == null)
                return RedirectToAction("DangNhap", "Home");

            int userId = (int)Session["UserId"];

            var don = db.DONHANG.FirstOrDefault(d => d.MADH == id && d.MAND == userId);
            if (don == null)
                return HttpNotFound();

            // Không cho hủy nếu đã giao hoặc đã hủy
            if (don.TRANGTHAI == "Giao thành công" || don.TRANGTHAI == "Đã hủy")
            {
                TempData["Error"] = "Đơn hàng này không thể hủy.";
                return RedirectToAction("ChiTiet", new { id = id });
            }

            don.TRANGTHAI = "Đã hủy";
            db.SaveChanges();

            TempData["Success"] = "Đơn hàng đã được hủy.";
            return RedirectToAction("ChiTiet", new { id = id });
        }
        // GET: /DonHang
        // Danh sách đơn hàng của khách hiện tại
        public ActionResult Index()
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var dsDonHang = db.DONHANG
                              .Where(d => d.MAND == userId.Value)
                              .OrderByDescending(d => d.NGAYDAT)
                              .ToList();

            return View(dsDonHang); // dùng view bạn đã viết
        }

        // GET: /DonHang/ChiTiet/5
        public ActionResult ChiTiet(int id)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            var don = db.DONHANG
                        .Include("CT_DONHANG.SANPHAM")
                        .FirstOrDefault(d => d.MADH == id && d.MAND == userId.Value);

            if (don == null)
                return HttpNotFound();

            return View(don);
        }

        // ==== HÀM TÍNH GIẢM GIÁ GIỐNG BÊN VIEW ====
        private decimal TinhGiamGia(string code, decimal subtotal)
        {
            if (string.IsNullOrWhiteSpace(code) || subtotal <= 0) return 0m;

            decimal discount = 0m;
            code = code.Trim().ToUpper();

            switch (code)
            {
                case "TF5":
                    if (subtotal >= 500000)
                        discount = Math.Floor(subtotal * 0.05m);
                    break;

                case "TF10":
                    if (subtotal >= 1000000)
                    {
                        discount = Math.Floor(subtotal * 0.10m);
                        if (discount > 100000) discount = 100000;
                    }
                    break;

                case "TF30K":
                    if (subtotal >= 400000)
                        discount = 30000;
                    break;

                case "MEMBER50":
                    if (subtotal >= 100000)
                        discount = 50000;
                    break;

                // FREESHIP: hiện phí ship = 0 nên không trừ
                default:
                    break;
            }

            return discount;
        }

        // ==== THANH TOÁN CHỈ NHỮNG SẢN PHẨM ĐƯỢC CHỌN ====
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThanhToan(string diaChiGiao, int[] selectedProductIds, string voucherCode)
        {
            // 1. Bắt buộc đăng nhập
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                TempData["Error"] = "Vui lòng đăng nhập trước khi đặt hàng.";
                return RedirectToAction("DangNhap", "Home");
            }

            // 2. Kiểm tra có chọn sản phẩm nào không
            if (selectedProductIds == null || selectedProductIds.Length == 0)
            {
                TempData["Error"] = "Bạn chưa chọn sản phẩm nào để thanh toán.";
                return RedirectToAction("Index", "GioHang");
            }

            if (string.IsNullOrWhiteSpace(diaChiGiao))
            {
                TempData["Error"] = "Vui lòng nhập địa chỉ giao hàng.";
                return RedirectToAction("Index", "GioHang");
            }

            try
            {
                // 3. Lấy giỏ hàng từ DATABASE (KHÔNG xài Session["Cart"])
                var cart = db.GIOHANG
                             .Include("CT_GIOHANG.SANPHAM")
                             .FirstOrDefault(x => x.MAND == userId.Value);

                if (cart == null || cart.CT_GIOHANG == null || !cart.CT_GIOHANG.Any())
                {
                    TempData["Error"] = "Giỏ hàng đang trống.";
                    return RedirectToAction("Index", "GioHang");
                }

                // 4. Lọc ra những CT_GIOHANG được tick
                var selectedItems = cart.CT_GIOHANG
                    .Where(ct => selectedProductIds.Contains(ct.MASP) && ct.SANPHAM != null)
                    .ToList();

                if (selectedItems.Count == 0)
                {
                    TempData["Error"] = "Không tìm thấy sản phẩm hợp lệ để thanh toán.";
                    return RedirectToAction("Index", "GioHang");
                }

                // 5. Tính subtotal = sum(SOLUONG * GIABAN)
                decimal subtotal = selectedItems.Sum(i => i.SOLUONG * i.SANPHAM.GIABAN);
                decimal discount = TinhGiamGia(voucherCode, subtotal);
                decimal total = Math.Max(subtotal - discount, 0);

                // 6. Tạo DONHANG (MADH tự tăng trong DB)
                var don = new DONHANG
                {
                    MAND = userId.Value,
                    NGAYDAT = DateTime.Now,
                    DIACHI_GIAO = diaChiGiao,
                    TONGTIEN = total,
                    TRANGTHAI = "Chờ xác nhận"
                };

                db.DONHANG.Add(don);
                db.SaveChanges(); // sinh MADH

                // 7. Tạo CT_DONHANG tương ứng
                foreach (var item in selectedItems)
                {
                    var ct = new CT_DONHANG
                    {
                        MADH = don.MADH,
                        MASP = item.MASP,
                        SOLUONG = item.SOLUONG,
                        DONGIA = item.SANPHAM.GIABAN  // đơn giá tại thời điểm đặt
                    };
                    db.CT_DONHANG.Add(ct);
                }

                // 8. XÓA các dòng CT_GIOHANG đã thanh toán khỏi giỏ
                foreach (var item in selectedItems)
                {
                    db.CT_GIOHANG.Remove(item);
                }

                cart.NGAYCAPNHAT = DateTime.Now;

                db.SaveChanges();

                TempData["Success"] = "Đặt hàng thành công! Đơn của bạn đang ở trạng thái 'Chờ xác nhận'.";
                return RedirectToAction("Index"); // /DonHang/Index
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi khi đặt hàng: " + ex.Message;
                return RedirectToAction("Index", "GioHang");
            }
        }
    }
}
