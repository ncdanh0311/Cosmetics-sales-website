using project_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class CamNangLamDepController : Controller
    {
        // GET: CamNangLamDep
        public ActionResult CamNangLamDep(int page = 1)
        {
            int pageSize = 4; // mỗi trang 4 bài
            var all = BeautyGuideHelper.Load();

            var skip = (page - 1) * pageSize;

            var paged = all.OrderBy(x => x.Id)
                           .Skip(skip)
                           .Take(pageSize)
                           .ToList();

            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)all.Count / pageSize);

            return View(paged);
        }
        public ActionResult ChiTiet(int id)
        {
            var articles = BeautyGuideHelper.Load();
            var article = articles.FirstOrDefault(x => x.Id == id);
            if (article == null) return HttpNotFound();

            return View(article);
        }
        public ActionResult DanhMuc(string name)
        {
            var articles = BeautyGuideHelper.Load();

            // nếu không có category → trả về tất cả
            if (string.IsNullOrEmpty(name))
                return View("CamNangLamDep", articles);

            // lọc theo category
            var filtered = articles
                .Where(x => x.Category.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // trả về view index kèm dữ liệu lọc
            return View("CamNangLamDep", filtered);
        }


    }
}