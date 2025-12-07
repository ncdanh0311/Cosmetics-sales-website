using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_mvc.Models
{
    public class ProductDetailsVM
    {
        public SANPHAM Product { get; set; }
        public IEnumerable<SANPHAM> RelatedByCategory { get; set; }
        public IEnumerable<SANPHAM> RelatedByBrand { get; set; }
    }
}