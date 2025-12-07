using System.Collections.Generic;
using System.Web.Mvc;

namespace project_mvc.Models
{
    public class QuanLySanPhamViewModel
    {
        public SANPHAM SanPham { get; set; }
        public List<SANPHAM> DanhSach { get; set; }

        public IEnumerable<SelectListItem> DanhMucList { get; set; }
        public IEnumerable<SelectListItem> ThuongHieuList { get; set; }
    }
}
