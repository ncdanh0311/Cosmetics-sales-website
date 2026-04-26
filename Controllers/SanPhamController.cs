using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_mvc.Models;
using System.Data.Entity;

namespace project_mvc.Controllers
{
    public class SanPhamController : Controller
    {
        TheFaceShop4Entities db = new TheFaceShop4Entities();

        public ActionResult Index()
        {
            return RedirectToAction("ShowSP");
        }

        public ActionResult ShowSP(
            string search = "",
            string minPrice = "",
            string maxPrice = "",
            string brands = "",
            string categories = "",
            string hasPromotion = "",
            string stock = "all",
            string sortBy = "",
            int page = 1,
            int pageSize = 16
        )
        {
            // ===== Base query =====
            var query = db.SANPHAM
                          .Include(s => s.DANHMUC)
                          .Include(s => s.THUONGHIEU)
                          .AsQueryable();

            // ===== Search =====
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(s =>
                    s.TENSP.Contains(search) ||
                    (s.THUONGHIEU != null && s.THUONGHIEU.TENTH.Contains(search))
                );
            }

            // ===== Price =====
            if (decimal.TryParse(minPrice, out var pMin))
                query = query.Where(s => s.GIABAN >= pMin);

            if (decimal.TryParse(maxPrice, out var pMax))
                query = query.Where(s => s.GIABAN <= pMax);

            // ===== Brands =====  (lọc theo tên thương hiệu)
            var brandArray = string.IsNullOrWhiteSpace(brands) ? new string[] { } : brands.Split(',');
            if (brandArray.Length > 0)
            {
                query = query.Where(s =>
                    s.THUONGHIEU != null &&
                    brandArray.Contains(s.THUONGHIEU.TENTH)
                );
            }

            // ===== Categories ===== (categories là mã DM001,...)
            var categoryArray = string.IsNullOrWhiteSpace(categories) ? new string[] { } : categories.Split(',');
            if (categoryArray.Length > 0)
            {
                // nếu MADM trong EF là int thì ToString(), nếu là string thì bỏ ToString() đi
                query = query.Where(s => categoryArray.Contains(s.MADM));
            }

            // ===== Promotion ===== (KHUYENMAI > 0)
            if (hasPromotion == "true")
                query = query.Where(s => s.KHUYENMAI > 0);

            // ===== Stock =====
            if (stock == "available")
                query = query.Where(s => s.SOLUONG > 0);
            else if (stock == "out")
                query = query.Where(s => s.SOLUONG == 0);

            // ===== Sort =====
            switch (sortBy)
            {
                case "price_asc": query = query.OrderBy(s => s.GIABAN); break;
                case "price_desc": query = query.OrderByDescending(s => s.GIABAN); break;
                case "name_asc": query = query.OrderBy(s => s.TENSP); break;
                case "name_desc": query = query.OrderByDescending(s => s.TENSP); break;
                case "newest": query = query.OrderByDescending(s => s.NGAYTAO); break;
                default: query = query.OrderBy(s => s.TENSP); break;
            }

            // ===== Facets: All Brands =====
            ViewBag.AllBrands = query
                .Where(s => s.THUONGHIEU != null && s.THUONGHIEU.TENTH != "")
                .Select(s => s.THUONGHIEU.TENTH)
                .Distinct()
                .OrderBy(s => s)
                .ToList();

            // ===== Facets: All Categories =====
            ViewBag.AllCategories = query
                .GroupBy(s => new { s.MADM, TenDM = s.DANHMUC.TENDANHMUC })
                .Select(g => new CategoryFacetVM
                {
                    MADM = g.Key.MADM,
                    TenDM = g.Key.TenDM,
                    Count = g.Count()
                })
                .OrderBy(x => x.TenDM)
                .ToList();

            // ===== Paging =====
            int totalItems = query.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (page > totalPages) page = totalPages;

            var paged = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalItems = totalItems;

            // giữ lại trạng thái filter
            ViewBag.Search = search;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;
            ViewBag.Brands = brands;
            ViewBag.Categories = categories;
            ViewBag.HasPromotion = hasPromotion;
            ViewBag.Stock = stock;
            ViewBag.SortBy = sortBy;

            return View(paged);
        }

        // MASP bây giờ là int -> cho Action nhận int
        public ActionResult Details(int id)
        {
            // Lấy sản phẩm + nav
            var sp = db.SANPHAM
                       .Include(s => s.DANHMUC)
                       .Include(s => s.THUONGHIEU)
                       .FirstOrDefault(x => x.MASP == id);

            if (sp == null)
                return HttpNotFound();

            // Sản phẩm liên quan theo DANHMUC
            var relatedCat = db.SANPHAM
                .Where(x => x.MADM == sp.MADM && x.MASP != sp.MASP)
                .OrderByDescending(x => x.NGAYTAO)
                .Take(8)
                .ToList();

            // Sản phẩm liên quan theo THUONGHIEU (dùng khóa ngoại MATH)
            var relatedBrand = db.SANPHAM
                .Where(x => x.MATH == sp.MATH && x.MASP != sp.MASP)
                .OrderByDescending(x => x.NGAYTAO)
                .Take(8)
                .ToList();

            ViewBag.Title = sp.TENSP + " | TheFaceShop.vn";
            ViewBag.CategoryName = sp.DANHMUC != null ? sp.DANHMUC.TENDANHMUC : sp.MADM;

            var vm = new ProductDetailsVM
            {
                Product = sp,
                RelatedByCategory = relatedCat,
                RelatedByBrand = relatedBrand
            };

            return View(vm);
        }
    }
}
