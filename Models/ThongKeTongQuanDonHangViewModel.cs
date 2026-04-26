using System;
using System.Collections.Generic;

namespace project_mvc.Models.ViewModels
{
    public class ChartDataDecimal
    {
        public List<string> Labels { get; set; }
        public List<decimal> Values { get; set; }

        public ChartDataDecimal()
        {
            Labels = new List<string>();
            Values = new List<decimal>();
        }
    }

    public class ChartDataInt
    {
        public List<string> Labels { get; set; }
        public List<int> Values { get; set; }

        public ChartDataInt()
        {
            Labels = new List<string>();
            Values = new List<int>();
        }
    }

    public class TopKhachHangItem
    {
        public int MaND { get; set; }
        public string HoTen { get; set; }
        public decimal TongTien { get; set; }
        public int SoDonHang { get; set; }
    }

    public class ThongKeTongQuanDonHangViewModel
    {
        // KPI tổng quan
        public decimal DoanhThuHomNay { get; set; }
        public decimal DoanhThuThangNay { get; set; }
        public decimal DoanhThuNamNay { get; set; }
        public decimal TongDoanhThu { get; set; }

        public int TongSoDon { get; set; }      // tất cả đơn trừ Đã hủy
        public int SoDonHuy { get; set; }       // đơn Đã hủy
        public double TiLeDonHuy { get; set; }  // %

        // Biểu đồ doanh thu 7 ngày
        public ChartDataDecimal DoanhThu7Ngay { get; set; }

        // Biểu đồ doanh thu 12 tháng
        public ChartDataDecimal DoanhThu12Thang { get; set; }

        // Biểu đồ trạng thái đơn
        public ChartDataInt DonHangTheoTrangThai { get; set; }

        // Top khách hàng
        public List<TopKhachHangItem> TopKhachHang { get; set; }

        public ThongKeTongQuanDonHangViewModel()
        {
            DoanhThu7Ngay = new ChartDataDecimal();
            DoanhThu12Thang = new ChartDataDecimal();
            DonHangTheoTrangThai = new ChartDataInt();
            TopKhachHang = new List<TopKhachHangItem>();
        }
    }
}
