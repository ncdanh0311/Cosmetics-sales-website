using project_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class QLDonHangAdminController : AdminBaseController
    {
        // ====== HỖ TRỢ: danh sách trạng thái cho dropdown (chỉ cho phép đi tới) ======
        private List<SelectListItem> GetTrangThaiList(string currentStatus)
        {
            var all = new List<SelectListItem>
            {
                new SelectListItem { Text = "Chờ xác nhận",    Value = "Chờ xác nhận"    },
                new SelectListItem { Text = "Đang vận chuyển",Value = "Đang vận chuyển" },
                new SelectListItem { Text = "Giao thành công",Value = "Giao thành công" },
                new SelectListItem { Text = "Đã hủy",          Value = "Đã hủy"         }
            };

            if (string.IsNullOrEmpty(currentStatus))
                return all;

            IEnumerable<string> allowed;
            switch (currentStatus)
            {
                case "Chờ xác nhận":
                    allowed = new[] { "Chờ xác nhận", "Đang vận chuyển", "Đã hủy" };
                    break;

                case "Đang vận chuyển":
                    allowed = new[] { "Đang vận chuyển", "Giao thành công", "Đã hủy" };
                    break;

                case "Giao thành công":
                    allowed = new[] { "Giao thành công" };
                    break;

                case "Đã hủy":
                    allowed = new[] { "Đã hủy" };
                    break;

                default:
                    allowed = new[] { currentStatus };
                    break;
            }

            var list = all
                .Where(x => allowed.Contains(x.Value))
                .ToList();

            foreach (var item in list)
            {
                item.Selected = item.Value == currentStatus;
            }

            return list;
        }

        // Kiểm tra có phải chuyển tiến (forward) không
        private bool IsForwardTransition(string current, string next)
        {
            if (string.IsNullOrEmpty(current) || string.IsNullOrEmpty(next))
                return false;

            if (current == next)
                return true;

            switch (current)
            {
                case "Chờ xác nhận":
                    return next == "Đang vận chuyển" || next == "Đã hủy";

                case "Đang vận chuyển":
                    return next == "Giao thành công" || next == "Đã hủy";

                case "Giao thành công":
                case "Đã hủy":
                    return false; // trạng thái cuối

                default:
                    return false;
            }
        }

        // ====== ACTIONS ======

        public ActionResult Index()
        {
            return RedirectToAction("QuanLyDonHang");
        }

        // GET: /QLDonHangAdmin/QuanLyDonHang
        public ActionResult QuanLyDonHang(int? id, string keyword, string statusFilter)
        {
            var vm = new QuanLyDonHangViewModel();

            var query = db.DONHANG
                          .Include(d => d.NGUOIDUNG)
                          .OrderByDescending(d => d.NGAYDAT)
                          .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                var keywordLower = keyword.ToLower();

                // Thử parse keyword thành mã đơn (int)
                int maDonSearch;
                bool isMaDon = int.TryParse(keyword, out maDonSearch);

                if (isMaDon)
                {
                    // Nếu là số → tìm theo MADH hoặc tên / địa chỉ chứa keyword
                    query = query.Where(d =>
                           d.MADH == maDonSearch
                        || ((d.NGUOIDUNG.HOTEN ?? "").ToLower().Contains(keywordLower))
                        || ((d.DIACHI_GIAO ?? "").ToLower().Contains(keywordLower)));
                }
                else
                {
                    // Không phải số → chỉ tìm theo tên / địa chỉ
                    query = query.Where(d =>
                           ((d.NGUOIDUNG.HOTEN ?? "").ToLower().Contains(keywordLower))
                        || ((d.DIACHI_GIAO ?? "").ToLower().Contains(keywordLower)));
                }
            }

            if (!string.IsNullOrWhiteSpace(statusFilter))
            {
                query = query.Where(d => d.TRANGTHAI == statusFilter);
            }

            vm.DanhSach = query.ToList();

            if (id.HasValue)
            {
                vm.DonHang = db.DONHANG
                               .Include(d => d.NGUOIDUNG)
                               .Include(d => d.CT_DONHANG.Select(c => c.SANPHAM))
                               .FirstOrDefault(d => d.MADH == id.Value);

                if (vm.DonHang == null)
                {
                    TempData["Error"] = "Không tìm thấy đơn hàng cần xem.";
                }
            }

            vm.TrangThaiList = GetTrangThaiList(vm.DonHang != null ? vm.DonHang.TRANGTHAI : null);

            ViewBag.Keyword = keyword;
            ViewBag.StatusFilter = statusFilter;
            ViewBag.CurrentOrderId = id;

            return View(vm);
        }


        // POST: /QLDonHangAdmin/CapNhatTrangThai
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CapNhatTrangThai(int id, string trangThai, string keyword, string statusFilter)
        {
            try
            {
                var don = db.DONHANG.Find(id);
                if (don == null)
                {
                    TempData["Error"] = "Không tìm thấy đơn hàng.";
                    return RedirectToAction("QuanLyDonHang", new { keyword, statusFilter });
                }

                if (string.IsNullOrWhiteSpace(trangThai))
                {
                    TempData["Error"] = "Vui lòng chọn trạng thái hợp lệ.";
                    return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
                }

                var current = don.TRANGTHAI ?? "";
                var next = trangThai.Trim();

                // Khóa đơn đã ở trạng thái cuối
                if (current == "Đã hủy" || current == "Giao thành công")
                {
                    TempData["Error"] = $"Đơn hàng đang ở trạng thái '{current}', không thể thay đổi.";
                    return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
                }

                if (!IsForwardTransition(current, next))
                {
                    TempData["Error"] = $"Không thể chuyển từ '{current}' sang '{next}'. Chỉ được phép tiến trạng thái.";
                    return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
                }

                if (current == next)
                {
                    TempData["Success"] = "Trạng thái đơn hàng không thay đổi.";
                }
                else
                {
                    don.TRANGTHAI = next;
                    db.Entry(don).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Success"] = $"Cập nhật trạng thái từ '{current}' sang '{next}' thành công.";
                }

                return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
            }
        }

        // POST: /QLDonHangAdmin/HuyDonHang
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HuyDonHang(int id, string keyword, string statusFilter)
        {
            try
            {
                var don = db.DONHANG.Find(id);
                if (don == null)
                {
                    TempData["Error"] = "Không tìm thấy đơn hàng.";
                    return RedirectToAction("QuanLyDonHang", new { keyword, statusFilter });
                }

                var current = don.TRANGTHAI ?? "";

                if (current == "Đã hủy" || current == "Giao thành công")
                {
                    TempData["Error"] = $"Đơn hàng đang ở trạng thái '{current}', không thể hủy.";
                    return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
                }

                don.TRANGTHAI = "Đã hủy";
                db.Entry(don).State = EntityState.Modified;
                db.SaveChanges();

                TempData["Success"] = "Đơn hàng đã được chuyển sang trạng thái 'Đã hủy'.";
                return RedirectToAction("QuanLyDonHang", new { id, keyword, statusFilter });
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Có lỗi xảy ra: " + ex.Message;
                return RedirectToAction("QuanLyDonHang", new { keyword, statusFilter });
            }
        }
    }
}
