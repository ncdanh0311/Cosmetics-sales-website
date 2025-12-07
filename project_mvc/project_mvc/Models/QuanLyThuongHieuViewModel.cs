using System.Collections.Generic;

namespace project_mvc.Models
{
    public class QuanLyThuongHieuViewModel
    {
        public THUONGHIEU ThuongHieu { get; set; }
        public List<THUONGHIEU> DanhSach { get; set; }
    }
}
