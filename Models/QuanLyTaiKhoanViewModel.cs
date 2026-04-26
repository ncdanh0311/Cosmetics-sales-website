using System.Collections.Generic;

namespace project_mvc.Models
{
    public class QuanLyTaiKhoanViewModel
    {
        public NGUOIDUNG TaiKhoan { get; set; }
        public List<NGUOIDUNG> DanhSach { get; set; }
    }
}
