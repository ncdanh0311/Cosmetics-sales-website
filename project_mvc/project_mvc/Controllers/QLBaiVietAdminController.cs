using project_mvc.Models;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class QLBaiVietAdminController : AdminBaseController
    {
        // GET: /QLBaiVietAdmin
        public ActionResult Index()
        {
            return RedirectToAction("QuanLyBaiViet");
        }

        public ActionResult QuanLyBaiViet(int? id)
        {
            var vm = new CamNangLamDepViewModel();
            var list = BeautyGuideHelper.Load() ?? new System.Collections.Generic.List<CamNangLamDep>();

            vm.DanhSach = list.OrderBy(x => x.Id).ToList();

            if (id != null)
            {
                vm.BaiViet = list.FirstOrDefault(x => x.Id == id);
                if (vm.BaiViet == null)
                {
                    TempData["Error"] = "Không tìm thấy bài viết.";
                    vm.BaiViet = new CamNangLamDep();
                    ViewBag.IsEdit = false;
                }
                else
                {
                    ViewBag.IsEdit = true;
                }
            }
            else
            {
                vm.BaiViet = new CamNangLamDep();
                ViewBag.IsEdit = false;
            }

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult LuuBaiViet(CamNangLamDepViewModel vm, HttpPostedFileBase ImageFile)
        {
            var list = BeautyGuideHelper.Load() ?? new System.Collections.Generic.List<CamNangLamDep>();
            var model = vm.BaiViet;

            if (string.IsNullOrWhiteSpace(model.Title))
            {
                TempData["Error"] = "Tiêu đề không được để trống!";
                vm.DanhSach = list.OrderBy(x => x.Id).ToList();
                return View("QuanLyBaiViet", vm);
            }

            // LẤY BÀI VIẾT CŨ (NẾU SỬA)
            CamNangLamDep ex = null;
            if (model.Id != 0)
            {
                ex = list.FirstOrDefault(x => x.Id == model.Id);
                if (ex == null)
                {
                    TempData["Error"] = "Không tìm thấy bài viết cần sửa.";
                    return RedirectToAction("QuanLyBaiViet");
                }
            }

            // Xử lý file ảnh (nếu có upload mới)
            if (ImageFile != null && ImageFile.ContentLength > 0)
            {
                try
                {
                    string folder = Server.MapPath("~/Images/camnang");
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    string ext = Path.GetExtension(ImageFile.FileName);
                    string fileName = "bv_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ext;
                    string path = Path.Combine(folder, fileName);

                    ImageFile.SaveAs(path);

                    // đường dẫn lưu trong JSON
                    model.ImageUrl = "/Images/camnang/" + fileName;
                }
                catch (Exception exUpload)
                {
                    TempData["Error"] = "Lỗi upload ảnh: " + exUpload.Message;
                }
            }
            else
            {
                // KHÔNG chọn ảnh mới:
                // - Nếu đang SỬA: giữ lại ảnh cũ
                // - Nếu đang THÊM: giữ nguyên (có thể null, sẽ hiện no-image)
                if (ex != null)
                {
                    model.ImageUrl = ex.ImageUrl;
                }
            }

            // Thêm / sửa bài viết
            if (model.Id == 0)
            {
                model.Id = list.Count == 0 ? 1 : list.Max(x => x.Id) + 1;
                list.Add(model);
                TempData["Success"] = "Thêm bài viết thành công!";
            }
            else
            {
                // Cập nhật bài viết
                ex.Title = model.Title;
                ex.ShortDescription = model.ShortDescription;
                ex.Content = model.Content;
                ex.ImageUrl = model.ImageUrl;
                ex.Category = model.Category;
                ex.PostDate = model.PostDate;

                TempData["Success"] = "Cập nhật bài viết thành công!";
            }

            BeautyGuideHelper.Save(list);

            // QUAY LẠI MÀN HÌNH VỚI BÀI VỪA SỬA / THÊM
            return RedirectToAction("QuanLyBaiViet", new { id = model.Id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult XoaBaiViet(int id)
        {
            var list = BeautyGuideHelper.Load() ?? new System.Collections.Generic.List<CamNangLamDep>();
            var ex = list.FirstOrDefault(x => x.Id == id);
            if (ex == null)
            {
                TempData["Error"] = "Không tìm thấy bài viết cần xóa.";
                return RedirectToAction("QuanLyBaiViet");
            }

            list.Remove(ex);
            BeautyGuideHelper.Save(list);

            TempData["Success"] = "Xóa bài viết thành công.";
            return RedirectToAction("QuanLyBaiViet");
        }
    }
}
