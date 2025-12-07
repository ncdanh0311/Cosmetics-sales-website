using System.Collections.Generic;
using System.Web.Mvc;

namespace project_mvc.Models
{
    public class QuanLyDonHangViewModel
    {
        public DONHANG DonHang { get; set; }
        public List<DONHANG> DanhSach { get; set; }

        // Dropdown trạng thái
        public List<SelectListItem> TrangThaiList { get; set; }

        public QuanLyDonHangViewModel()
        {
            DanhSach = new List<DONHANG>();
            TrangThaiList = new List<SelectListItem>();
        }
    }
}
