using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_mvc.Models
{
    public class CamNangLamDepViewModel
    {
        public CamNangLamDep BaiViet { get; set; }

        public List<CamNangLamDep> DanhSach { get; set; }
       
    }
}