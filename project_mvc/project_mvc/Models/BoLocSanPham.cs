using System.Collections.Generic;

namespace project_mvc.Models
{
    public class BoLocSanPham
    {
        public string TuKhoa { get; set; }              // search
        public decimal? GiaMin { get; set; }            // minPrice
        public decimal? GiaMax { get; set; }            // maxPrice
        public List<string> ThuongHieus { get; set; }   // brands
        public List<string> DanhMucs { get; set; }      // categories
        public bool? CoKhuyenMai { get; set; }          // hasPromotion
        public string TrangThaiKho { get; set; }        // available | out | null
        public string SapXep { get; set; }              // sortBy
    }
}
