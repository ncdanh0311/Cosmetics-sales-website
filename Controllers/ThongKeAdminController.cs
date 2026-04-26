using project_mvc.Models;
using project_mvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class ThongKeAdminController : AdminBaseController
    {
        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            DateTime today = now.Date;

            // === 1. Lấy dữ liệu cơ bản từ DONHANG ===

            // Đơn dùng để tính DOANH THU: tất cả trạng thái TRỪ "Đã hủy"
            var donDoanhThu = db.DONHANG
                .Include("NGUOIDUNG")
                .Where(d => d.TRANGTHAI != "Đã hủy")
                .ToList();

            // Tất cả đơn (kể cả bị hủy) cho biểu đồ trạng thái
            var donTatCa = db.DONHANG.ToList();

            // === 2. KPI Tổng quan ===

            // Hôm nay
            var donHomNay = donDoanhThu
                .Where(d => d.NGAYDAT.Date == today)
                .ToList();

            // Tháng này
            var donThangNay = donDoanhThu
                .Where(d => d.NGAYDAT.Year == today.Year &&
                            d.NGAYDAT.Month == today.Month)
                .ToList();

            // Năm nay
            var donNamNay = donDoanhThu
                .Where(d => d.NGAYDAT.Year == today.Year)
                .ToList();

            decimal doanhThuHomNay = donHomNay.Sum(d => d.TONGTIEN);
            decimal doanhThuThangNay = donThangNay.Sum(d => d.TONGTIEN);
            decimal doanhThuNamNay = donNamNay.Sum(d => d.TONGTIEN);
            decimal tongDoanhThu = donDoanhThu.Sum(d => d.TONGTIEN);

            int tongSoDon = donDoanhThu.Count;                         // trừ Đã hủy
            int soDonHuy = donTatCa.Count(d => d.TRANGTHAI == "Đã hủy");
            double tiLeDonHuy = (tongSoDon + soDonHuy) > 0
                ? Math.Round(soDonHuy * 100.0 / (tongSoDon + soDonHuy), 2)
                : 0;

            // === 3. Biểu đồ Doanh thu 7 ngày gần nhất ===

            DateTime from7 = today.AddDays(-6); // 7 ngày: from7 -> today
            var don7Ngay = donDoanhThu
                .Where(d => d.NGAYDAT.Date >= from7)
                .ToList();

            var group7Ngay = don7Ngay
                .GroupBy(d => d.NGAYDAT.Date)
                .Select(g => new
                {
                    Ngay = g.Key,
                    Tong = g.Sum(x => x.TONGTIEN)
                })
                .OrderBy(x => x.Ngay)
                .ToList();

            var dt7Ngay = new ChartDataDecimal();
            // Fill full 7 ngày, kể cả ngày không có đơn
            for (int i = 0; i < 7; i++)
            {
                DateTime d = from7.AddDays(i);
                var item = group7Ngay.FirstOrDefault(x => x.Ngay == d);
                dt7Ngay.Labels.Add(d.ToString("dd/MM"));
                dt7Ngay.Values.Add(item != null ? item.Tong : 0);
            }

            // === 4. Biểu đồ Doanh thu 12 tháng gần nhất ===

            // Lấy từ tháng hiện tại lùi lại 11 tháng
            DateTime startMonth = new DateTime(today.Year, today.Month, 1).AddMonths(-11);

            var don12Thang = donDoanhThu
                .Where(d => d.NGAYDAT.Date >= startMonth)
                .ToList();

            var group12Thang = don12Thang
                .GroupBy(d => new { d.NGAYDAT.Year, d.NGAYDAT.Month })
                .Select(g => new
                {
                    Nam = g.Key.Year,
                    Thang = g.Key.Month,
                    Tong = g.Sum(x => x.TONGTIEN)
                })
                .OrderBy(x => x.Nam).ThenBy(x => x.Thang)
                .ToList();

            var dt12Thang = new ChartDataDecimal();
            for (int i = 0; i < 12; i++)
            {
                DateTime m = startMonth.AddMonths(i);
                var item = group12Thang.FirstOrDefault(x => x.Nam == m.Year && x.Thang == m.Month);
                dt12Thang.Labels.Add(m.ToString("MM/yyyy"));
                dt12Thang.Values.Add(item != null ? item.Tong : 0);
            }

            // === 5. Biểu đồ số đơn theo trạng thái ===

            var dtTrangThai = new ChartDataInt();
            var groupTrangThai = donTatCa
                .GroupBy(d => d.TRANGTHAI ?? "Không rõ")
                .Select(g => new
                {
                    TrangThai = g.Key,
                    SoLuong = g.Count()
                })
                .OrderByDescending(x => x.SoLuong)
                .ToList();

            foreach (var item in groupTrangThai)
            {
                dtTrangThai.Labels.Add(item.TrangThai);
                dtTrangThai.Values.Add(item.SoLuong);
            }

            // === 6. Top 5 khách hàng chi tiêu nhiều nhất (trừ đã hủy) ===

            var topKhachHang = donDoanhThu
                .GroupBy(d => d.MAND)
                .Select(g => new TopKhachHangItem
                {
                    MaND = g.Key,
                    HoTen = g.FirstOrDefault().NGUOIDUNG != null
                        ? g.FirstOrDefault().NGUOIDUNG.HOTEN
                        : ("Khách #" + g.Key),
                    TongTien = g.Sum(x => x.TONGTIEN),
                    SoDonHang = g.Count()
                })
                .OrderByDescending(x => x.TongTien)
                .Take(5)
                .ToList();

            // === 7. Gán vào ViewModel ===

            var model = new ThongKeTongQuanDonHangViewModel
            {
                DoanhThuHomNay = doanhThuHomNay,
                DoanhThuThangNay = doanhThuThangNay,
                DoanhThuNamNay = doanhThuNamNay,
                TongDoanhThu = tongDoanhThu,
                TongSoDon = tongSoDon,
                SoDonHuy = soDonHuy,
                TiLeDonHuy = tiLeDonHuy,
                DoanhThu7Ngay = dt7Ngay,
                DoanhThu12Thang = dt12Thang,
                DonHangTheoTrangThai = dtTrangThai,
                TopKhachHang = topKhachHang
            };

            return View(model);
        }
    }
}
