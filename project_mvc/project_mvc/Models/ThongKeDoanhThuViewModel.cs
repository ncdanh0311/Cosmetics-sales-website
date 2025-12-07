using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_mvc.Models.ViewModels
{
    public class ThongKeDoanhThuViewModel
    {
        public string Range { get; set; }             // "1ngay", "7ngay", "30ngay", "1nam"
        public List<string> Labels { get; set; }      // Nhãn theo ngày (dd/MM/yyyy)
        public List<decimal> Values { get; set; }     // Tổng tiền theo ngày
        public decimal TongDoanhThu { get; set; }     // Tổng doanh thu trong khoảng

        public ThongKeDoanhThuViewModel()
        {
            Labels = new List<string>();
            Values = new List<decimal>();
        }
    }
}
