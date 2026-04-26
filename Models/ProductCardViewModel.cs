namespace project_mvc.Models
{
    public class ProductCardViewModel
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string ThuongHieu { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? GiaGoc { get; set; }
        public int? GiamPhanTram { get; set; }   // % giảm giá (nếu có)
        public string HinhAnh { get; set; }      // tên file ảnh: vd "sp1.jpg"
        public double? DiemDanhGia { get; set; } // vd 4.8
        public int? LuotDanhGia { get; set; }    // vd 2100
    }
}
