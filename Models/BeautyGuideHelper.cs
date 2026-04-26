using Newtonsoft.Json;
using project_mvc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
namespace project_mvc.Models
{
    public static class BeautyGuideHelper
    {
        private static string FilePath =
        HttpContext.Current.Server.MapPath("~/App_Data/CamNangLamDep.json");

        public static List<CamNangLamDep> Load()
        {
            if (!File.Exists(FilePath))
                return new List<CamNangLamDep>();

            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<CamNangLamDep>>(json);
        }

        public static void Save(List<CamNangLamDep> data)
        {
            var json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented
);
            File.WriteAllText(FilePath, json);
        }
    }
}