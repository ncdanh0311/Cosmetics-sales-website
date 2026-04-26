using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
namespace project_mvc.Models
{

    public class CamNangLamDep
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        [AllowHtml]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string PostDate { get; set; }
    }


}

