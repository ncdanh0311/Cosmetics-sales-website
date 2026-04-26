using System.Collections.Generic;

namespace project_mvc.Models
{
    public class HomeAboutViewModel
    {
        // Flash sale
        public List<SANPHAM> FlashSale { get; set; }

        // Bán chạy - chăm sóc da
        public List<SANPHAM> BestSkincare { get; set; }

        // Bán chạy - trang điểm
        public List<SANPHAM> BestMakeup { get; set; }

        // Bán chạy - chăm sóc tóc
        public List<SANPHAM> BestHair { get; set; }

        // Hàng mới về
        public List<SANPHAM> NewArrivals { get; set; }
    }
}
