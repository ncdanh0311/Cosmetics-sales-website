using project_mvc.Models;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class AdminBaseController : Controller
    {
        protected TheFaceShop4Entities db = new TheFaceShop4Entities();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            try
            {
                // Tổng sản phẩm
                ViewBag.TongSanPham = db.SANPHAM.Count();

                // Tổng danh mục
                ViewBag.TongDanhMuc = db.DANHMUC.Count();

                // Tổng thương hiệu
                ViewBag.TongThuongHieu = db.THUONGHIEU.Count();

                // Tổng tài khoản
                ViewBag.TongTaiKhoan = db.NGUOIDUNG.Count();

                // ====== TỔNG ĐƠN HÀNG (QUẢN LÝ ĐƠN HÀNG) ======
                ViewBag.TongDonHang = db.DONHANG.Count();

                // Nếu muốn show thêm số đơn theo trạng thái:
                ViewBag.TongDonChoXacNhan = db.DONHANG.Count(d => d.TRANGTHAI == "Chờ xác nhận");
                ViewBag.TongDonDangVanChuyen = db.DONHANG.Count(d => d.TRANGTHAI == "Đang vận chuyển");
                ViewBag.TongDonGiaoThanhCong = db.DONHANG.Count(d => d.TRANGTHAI == "Giao thành công");
                ViewBag.TongDonDaHuy = db.DONHANG.Count(d => d.TRANGTHAI == "Đã hủy");

                // Tổng bài viết (dùng BeautyGuideHelper)
                try
                {
                    var listBaiViet = BeautyGuideHelper.Load();
                    ViewBag.TongBaiViet = (listBaiViet != null) ? listBaiViet.Count : 0;
                }
                catch
                {
                    ViewBag.TongBaiViet = 0;
                }
            }
            catch
            {
                ViewBag.TongSanPham = 0;
                ViewBag.TongDanhMuc = 0;
                ViewBag.TongThuongHieu = 0;
                ViewBag.TongTaiKhoan = 0;
                ViewBag.TongBaiViet = 0;

                // fallback cho đơn hàng
                ViewBag.TongDonHang = 0;
                ViewBag.TongDonChoXacNhan = 0;
                ViewBag.TongDonDangVanChuyen = 0;
                ViewBag.TongDonGiaoThanhCong = 0;
                ViewBag.TongDonDaHuy = 0;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
