using project_mvc.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class GioHangController : Controller
    {
        private readonly TheFaceShop4Entities _db = new TheFaceShop4Entities();

        private int? CurrentUserId
        {
            get
            {
                if (Session["UserId"] == null)
                {
                    return null;
                }

                int userId;
                if (int.TryParse(Session["UserId"].ToString(), out userId))
                {
                    return userId;
                }

                return null;
            }
        }

        public ActionResult Index()
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                ViewBag.RequiresLogin = true;
                return View(new CartViewModel());
            }

            var vm = BuildViewModel(userId.Value);
            return View(vm);
        }

        [HttpGet]
        public ActionResult ThemGioHang(int ms, string strURL, int qty = 1)
        {
            return HandleAddToCart(ms, qty, strURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemGioHang(int ms, int qty, string strURL)
        {
            return HandleAddToCart(ms, qty, strURL);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CapNhatSoLuong(int productId, int qty)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            UpdateItemQuantity(userId.Value, productId, qty);
            TempData["CartMessage"] = "Đã cập nhật số lượng sản phẩm.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaKhoiGio(int productId)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return RedirectToAction("DangNhap", "Home");
            }

            RemoveItemInternal(userId.Value, productId);
            TempData["CartMessage"] = "Đã xóa sản phẩm khỏi giỏ hàng.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult CartData()
        {
            var userId = CurrentUserId;
            var vm = userId.HasValue ? BuildViewModel(userId.Value) : new CartViewModel();

            return Json(new
            {
                success = true,
                items = vm.Items,
                total = vm.Total,
                totalQuantity = vm.TotalQuantity,
                requiresLogin = !userId.HasValue
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult AddItem(int productId, int qty = 1)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return Json(new { success = false, requiresLogin = true });
            }

            SANPHAM product;
            var result = AddOrUpdateItem(userId.Value, productId, qty, out product);
            if (!result)
            {
                return Json(new { success = false, message = "Không tìm thấy sản phẩm." });
            }

            var vm = BuildViewModel(userId.Value);
            return Json(new
            {
                success = true,
                items = vm.Items,
                total = vm.Total,
                totalQuantity = vm.TotalQuantity
            });
        }

        [HttpPost]
        public JsonResult UpdateItem(int productId, int qty)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return Json(new { success = false, requiresLogin = true });
            }

            UpdateItemQuantity(userId.Value, productId, qty);
            var vm = BuildViewModel(userId.Value);
            return Json(new
            {
                success = true,
                items = vm.Items,
                total = vm.Total,
                totalQuantity = vm.TotalQuantity
            });
        }

        [HttpPost]
        public JsonResult RemoveItem(int productId)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                return Json(new { success = false, requiresLogin = true });
            }

            RemoveItemInternal(userId.Value, productId);
            var vm = BuildViewModel(userId.Value);
            return Json(new
            {
                success = true,
                items = vm.Items,
                total = vm.Total,
                totalQuantity = vm.TotalQuantity
            });
        }

        private ActionResult HandleAddToCart(int productId, int qty, string strURL)
        {
            var userId = CurrentUserId;
            if (!userId.HasValue)
            {
                TempData["CartError"] = "Vui lòng đăng nhập để sử dụng giỏ hàng.";
                return RedirectToAction("DangNhap", "Home");
            }

            var redirectUrl = string.IsNullOrWhiteSpace(strURL)
                ? Url.Action("Details", "SanPham", new { id = productId })
                : strURL;

            if (qty < 1)
            {
                qty = 1;
            }

            SANPHAM product;
            var added = AddOrUpdateItem(userId.Value, productId, qty, out product);
            if (!added)
            {
                TempData["CartError"] = "Sản phẩm không tồn tại hoặc đã bị ẩn.";
                return Redirect(redirectUrl);
            }

            if (product != null)
            {
                TempData["CartMessage"] = $"Đã thêm \"{product.TENSP}\" vào giỏ hàng.";
            }

            return Redirect(redirectUrl);
        }

        private bool AddOrUpdateItem(int userId, int productId, int qty, out SANPHAM product)
        {
            product = _db.SANPHAM.Include("THUONGHIEU").FirstOrDefault(x => x.MASP == productId);
            if (product == null)
            {
                return false;
            }

            if (qty < 1)
            {
                qty = 1;
            }

            var cart = GetOrCreateCart(userId);
            _db.Entry(cart).Collection(c => c.CT_GIOHANG).Load();

            var item = cart.CT_GIOHANG.FirstOrDefault(x => x.MASP == productId);
            if (item == null)
            {
                item = new CT_GIOHANG
                {
                    MAGH = cart.MAGH,
                    MASP = productId,
                    SOLUONG = qty
                };
                _db.CT_GIOHANG.Add(item);
            }
            else
            {
                item.SOLUONG += qty;
            }

            cart.NGAYCAPNHAT = DateTime.Now;
            _db.SaveChanges();
            return true;
        }

        private void UpdateItemQuantity(int userId, int productId, int qty)
        {
            var cart = GetCart(userId);
            if (cart == null)
            {
                return;
            }

            var item = cart.CT_GIOHANG.FirstOrDefault(x => x.MASP == productId);
            if (item == null)
            {
                return;
            }

            if (qty <= 0)
            {
                _db.CT_GIOHANG.Remove(item);
            }
            else
            {
                item.SOLUONG = qty;
            }

            cart.NGAYCAPNHAT = DateTime.Now;
            _db.SaveChanges();
        }

        private void RemoveItemInternal(int userId, int productId)
        {
            UpdateItemQuantity(userId, productId, 0);
        }

        private GIOHANG GetOrCreateCart(int userId)
        {
            var cart = _db.GIOHANG.FirstOrDefault(x => x.MAND == userId);
            if (cart == null)
            {
                cart = new GIOHANG
                {
                    MAND = userId,
                    NGAYCAPNHAT = DateTime.Now
                };
                _db.GIOHANG.Add(cart);
                _db.SaveChanges();
            }

            return cart;
        }

        private GIOHANG GetCart(int userId)
        {
            var cart = _db.GIOHANG
                .Include("CT_GIOHANG.SANPHAM.THUONGHIEU")
                .FirstOrDefault(x => x.MAND == userId);

            if (cart != null)
            {
                _db.Entry(cart).Collection(c => c.CT_GIOHANG).Load();
            }

            return cart;
        }

        private CartViewModel BuildViewModel(int userId)
        {
            var cart = GetCart(userId);
            var vm = new CartViewModel();

            if (cart == null)
            {
                // GIỎ HÀNG RỖNG → vẫn lưu session cho chắc
                Session["Cart"] = vm;
                return vm;
            }

            vm.Items = cart.CT_GIOHANG
                .Where(x => x.SANPHAM != null)
                .Select(x => new CartItemViewModel
                {
                    CartId = cart.MAGH,
                    ProductId = x.MASP,
                    ProductName = x.SANPHAM.TENSP,
                    Image = x.SANPHAM.HINHANH,
                    Price = x.SANPHAM.GIABAN,
                    Quantity = x.SOLUONG,
                    Brand = x.SANPHAM.THUONGHIEU != null ? x.SANPHAM.THUONGHIEU.TENTH : string.Empty
                })
                .ToList();

            vm.LastUpdated = cart.NGAYCAPNHAT;

            // 🔥 QUAN TRỌNG: LƯU CART LÊN SESSION
            Session["Cart"] = vm;

            return vm;
        }

        public ActionResult CheckCartAccess()
        {
            if (Session["UserId"] == null)
            {
                // Chưa đăng nhập → chuyển tới trang Đăng Nhập
                return RedirectToAction("DangNhap", "Home");
            }

            // Đã đăng nhập → vào giỏ hàng bình thường
            return RedirectToAction("Index", "GioHang");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
