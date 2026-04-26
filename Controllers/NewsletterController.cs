using project_mvc.Models;
using project_mvc.Models;
using System;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class NewsletterController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                TempData["NewsletterError"] = "Vui lòng nhập địa chỉ email.";
                return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
            }

            try
            {
                // Nội dung HTML của email
                string subject = "Chào mừng bạn đến với THE FACE SHOP";
                string body = GetNewsletterHtml(email);

                EmailService.SendNewsletter(email, subject, body);

                TempData["NewsletterSuccess"] = "Đã gửi bản tin vào email của bạn. Vui lòng kiểm tra hộp thư!";
            }
            catch (Exception ex)
            {
                // TODO: log lỗi ex
                TempData["NewsletterError"] = "Có lỗi khi gửi email. Vui lòng thử lại sau.";
            }

            return Redirect(Request.UrlReferrer?.ToString() ?? Url.Action("Index", "Home"));
        }

        private string GetNewsletterHtml(string email)
        {
            // HTML inline CSS cho email (nên dùng inline style để Gmail hiển thị chuẩn)
            return @"<!DOCTYPE html>
<html lang=""vi"">
<head>
    <meta charset=""utf-8"" />
    <title>THE FACE SHOP • Thiệp chào hàng & Ưu đãi siêu phẩm</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
    <!-- Một ít CSS cơ bản, phần quan trọng vẫn là inline style -->
    <style type=""text/css"">
        /* Reset nhẹ cho email */
        body, table, td, p, a {
            margin: 0;
            padding: 0;
            text-decoration: none;
        }

        img {
            border: 0;
            display: block;
            line-height: 0;
        }

        .hover-zoom img {
            transition: transform 0.3s ease;
        }

        .hover-zoom:hover img {
            transform: scale(1.03);
        }

        @media only screen and (max-width: 640px) {
            .container {
                width: 100% !important;
            }

            .stack-column,
            .stack-column td {
                display: block !important;
                width: 100% !important;
            }

            .center-text {
                text-align: center !important;
            }

            .hide-mobile {
                display: none !important;
            }
        }
    </style>
</head>
<body style=""margin:0; padding:0; background-color:#f3f4f6; font-family: Arial, Helvetica, sans-serif;"">

    <!-- Wrapper toàn bộ email -->
    <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""background-color:#f3f4f6; padding:24px 0;"">
        <tr>
            <td align=""center"">

                <!-- Container chính -->
                <table class=""container"" width=""640"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:640px; max-width:100%; background-color:#ffffff; border-radius:24px; overflow:hidden; box-shadow:0 20px 60px rgba(15,23,42,0.18);"">
                    <!-- HEADER -->
                    <tr>
                        <td style=""background: linear-gradient(135deg, #f9a8d4, #fbcfe8); padding: 20px 24px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                <tr>
                                    <td align=""left"" style=""color:#ffffff; font-size:18px; font-weight:bold; letter-spacing:0.08em; text-transform:uppercase;"">
                                        THE FACE SHOP VIETNAM
                                    </td>
                                    <td align=""right"" class=""hide-mobile"" style=""color:#fefce8; font-size:12px;"">
                                        Bản tin ưu đãi dành riêng cho bạn
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"" style=""padding-top:12px;"">
                                        <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                            <tr>
                                                <td width=""58"" valign=""top"">
                                                    <table width=""48"" height=""48"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; background-color:rgba(255,255,255,0.18);"">
                                                        <tr>
                                                            <td align=""center"" valign=""middle"" style=""font-size:22px;"">🛍️</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td valign=""middle"">
                                                    <div style=""color:#fff7ed; font-size:14px; line-height:1.6;"">
                                                        <strong>Chào mừng bạn đến với thế giới làm đẹp của THE FACE SHOP!</strong><br />
                                                        Bộ sưu tập mới, ưu đãi đặc biệt và bí quyết chăm sóc da được thiết kế riêng cho bạn.
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- HERO POSTER LỚN -->
                    <tr>
                        <td style=""padding:0;"">
                            <a href=""https://www.thefaceshop.com.vn"" target=""_blank"" style=""display:block;"">
                                <img src=""https://images.unsplash.com/photo-1522335789203-aabd1fc54bc9?auto=format&fit=crop&w=1600&q=80""
                                     alt=""Bộ sưu tập skincare cao cấp""
                                     width=""640""
                                     style=""width:100%; max-width:640px; height:auto; display:block;"">
                            </a>
                        </td>
                    </tr>

                    <!-- TIÊU ĐỀ CHÍNH -->
                    <tr>
                        <td style=""padding:24px 28px 12px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                <tr>
                                    <td align=""left"">
                                        <div style=""font-size:22px; color:#0f172a; font-weight:700; line-height:1.4;"">
                                            Thiệp chào hàng • BST dưỡng da & trang điểm mới
                                        </div>
                                        <div style=""margin-top:6px; font-size:14px; color:#6b7280; line-height:1.6;"">
                                            Dành riêng cho các khách hàng thân thiết của THE FACE SHOP – nơi vẻ đẹp tự nhiên được nâng niu bằng khoa học và sự tinh tế.
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- DẢI ƯU ĐÃI NỔI BẬT -->
                    <tr>
                        <td style=""padding:0 28px 18px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; background: linear-gradient(135deg,#fdebf7,#feeef8); border:1px solid #fbcfe8;"">
                                <tr>
                                    <td style=""padding:14px 16px;"">
                                        <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                            <tr>
                                                <td valign=""top"" width=""40"">
                                                    <span style=""font-size:24px;"">✨</span>
                                                </td>
                                                <td valign=""middle"">
                                                    <div style=""font-size:13px; color:#92400e; text-transform:uppercase; letter-spacing:0.12em; font-weight:bold;"">
                                                        ƯU ĐÃI MỞ MÀN
                                                    </div>
                                                    <div style=""font-size:14px; color:#7c2d12; margin-top:4px; line-height:1.6;"">
                                                        <strong>Giảm đến 30%</strong> cho dòng sản phẩm làm sạch – dưỡng ẩm, tặng kèm mini size khi hóa đơn từ <strong>499.000đ</strong>.  
                                                        Nhập mã <strong>HELLOSKIN</strong> tại bước thanh toán.
                                                    </div>
                                                </td>
                                                <td valign=""middle"" align=""right"" class=""hide-mobile"">
                                                    <a href=""https://www.thefaceshop.com.vn"" target=""_blank""
                                                       style=""display:inline-block; padding:8px 14px; border-radius:999px; background:#f472b6; color:#ffffff; font-size:12px; font-weight:bold; text-transform:uppercase; letter-spacing:0.08em;"">
                                                        Mua ngay
                                                    </a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- POSTER NHỎ 2 CỘT -->
                    <tr>
                        <td style=""padding:4px 28px 20px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                <tr>
                                    <!-- Poster 1 -->
                                    <td class=""stack-column"" width=""50%"" valign=""top"" style=""padding-right:6px;"">
                                        <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; overflow:hidden; background-color:#f9fafb;"">
                                            <tr>
                                                <td class=""hover-zoom"">
                                                    <a href=""https://www.thefaceshop.com.vn"" target=""_blank"">
                                                        <img src=""https://images.unsplash.com/photo-1598440947619-2c35fc9aa908?auto=format&fit=crop&w=900&q=80""
                                                             alt=""Poster mặt nạ dưỡng da""
                                                             width=""100%""
                                                             style=""width:100%; height:auto; display:block;"">
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style=""padding:10px 12px 12px 12px;"">
                                                    <div style=""font-size:13px; font-weight:bold; color:#111827; margin-bottom:3px;"">
                                                        RITUAL MASK NIGHT
                                                    </div>
                                                    <div style=""font-size:12px; color:#6b7280; line-height:1.5;"">
                                                        Bộ đôi dưỡng da giúp làn da mềm mịn, căng bóng sau một ngày dài. Kết cấu mỏng nhẹ – thấm nhanh, mang lại cảm giác dễ chịu tức thì. Hương thơm thư giãn giúp bạn thư giãn sâu, đồng thời hỗ trợ tái tạo, phục hồi và cấp ẩm suốt đêm, để sáng dậy da luôn tươi tắn và tràn đầy sức sống.
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>

                                    <!-- Poster 2 -->
                                    <td class=""stack-column"" width=""50%"" valign=""top"" style=""padding-left:6px;"">
                                        <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; overflow:hidden; background-color:#f9fafb;"">
                                            <tr>
                                                <td class=""hover-zoom"">
                                                    <a href=""https://www.thefaceshop.com.vn"" target=""_blank"">
                                                        <img src=""https://images.unsplash.com/photo-1613255348289-1407e4f2f980?q=80&w=715&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D""
                                                             alt=""Poster set chăm sóc da hằng ngày""
                                                             width=""100%""
                                                             style=""width:100%; height:auto; display:block;"">
                                                    </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style=""padding:10px 12px 12px 12px;"">
                                                    <div style=""font-size:13px; font-weight:bold; color:#111827; margin-bottom:3px;"">
                                                        DAILY GLOW SET
                                                    </div>
                                                    <div style=""font-size:12px; color:#6b7280; line-height:1.5;"">
                                                        Thỏi son mang chất son mềm nhẹ, mịn mượt, lên màu rõ ngay từ lần chạm đầu. Kết cấu mỏng, không khô môi, giữ cảm giác thoải mái suốt nhiều giờ.
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    

                    <!-- POSTER TOÀN DÒNG (SKINCARE ROUTINE) -->
                    <tr>
                        <td style=""padding:14px 28px 6px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:18px; overflow:hidden; background-color:#0f172a;"">
                                <tr>
                                    <td>
                                        <img src=""https://images.unsplash.com/photo-1591570915688-e1b5292de457?q=80&w=749&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D""
                                             width=""100%""
                                             alt=""Routine chăm sóc da buổi tối""
                                             style=""width:100%; height:auto; display:block; opacity:0.85;"">
                                    </td>
                                </tr>
                                <tr>
                                    <td style=""padding:14px 18px 16px 18px;"">
                                        <div style=""font-size:15px; color:#f9fafb; font-weight:bold; margin-bottom:4px;"">
                                            GỢI Ý ROUTINE CHĂM SÓC DA BUỔI TỐI
                                        </div>
                                        <div style=""font-size:13px; color:#e5e7eb; line-height:1.6; margin-bottom:8px;"">
                                            Làm sạch sâu – Cân bằng – Điều trị – Dưỡng ẩm – Khóa ẩm.  
                                            THE FACE SHOP gợi ý combo phù hợp cho làn da châu Á, khí hậu nóng ẩm nhưng vẫn hay mất nước.
                                        </div>
                                        <div style=""font-size:12px; color:#9ca3af;"">
                                            ✅ Dành cho da thường – hỗn hợp – khô nhẹ  
                                            ✅ Ưu tiên thành phần lành tính, hạn chế hương liệu nặng mùi  
                                            ✅ Có thể linh hoạt thêm tẩy tế bào chết 1–2 lần/tuần
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- CẢM NHẬN KHÁCH HÀNG -->
                    <tr>
                        <td style=""padding:14px 28px 18px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; border:1px solid #e5e7eb; background-color:#f9fafb;"">
                                <tr>
                                    <td style=""padding:14px 18px;"">
                                        <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                            <tr>
                                                <td valign=""top"" width=""36"">
                                                    <span style=""font-size:24px;"">💬</span>
                                                </td>
                                                <td valign=""middle"">
                                                    <div style=""font-size:13px; color:#0f172a; font-weight:600; margin-bottom:4px;"">
                                                        Cảm nhận từ khách hàng thân thiết
                                                    </div>
                                                    <div style=""font-size:12px; color:#6b7280; line-height:1.6;"">
                                                        “Mình bắt đầu dùng skincare của THE FACE SHOP từ 2019. Điều mình thích nhất là sản phẩm dịu nhẹ, mùi thơm dễ chịu, tư vấn viên siêu nhiệt tình.  
                                                        Da mình trước hay bong tróc vì ngồi điều hòa nhiều, giờ thì mềm hơn hẳn và ít bị kích ứng.”
                                                        <br />
                                                        <span style=""color:#4b5563; font-weight:bold;"">– Minh Anh, 27 tuổi, Văn phòng</span>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- LỜI MỜI HỢP TÁC / ĐẶT HÀNG SỈ -->
                    <tr>
                        <td style=""padding:0 28px 20px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""border-radius:16px; background:linear-gradient(135deg,#fdf2ff,#eff6ff); border:1px solid #e5e7eb;"">
                                <tr>
                                    <td style=""padding:16px 18px;"">
                                        <div style=""font-size:14px; font-weight:bold; color:#111827; margin-bottom:4px;"">
                                            Ưu đãi dành cho đối tác & đại lý
                                        </div>
                                        <div style=""font-size:13px; color:#4b5563; line-height:1.6; margin-bottom:8px;"">
                                            Nếu bạn là chủ cửa hàng mỹ phẩm, spa hoặc salon làm đẹp, THE FACE SHOP sẵn sàng đồng hành cùng bạn với chính sách chiết khấu hấp dẫn, hỗ trợ đào tạo và tài liệu trưng bày chuyên nghiệp.
                                        </div>
                                        <div style=""font-size:12px; color:#6b7280; line-height:1.6;"">
                                            📩 Liên hệ: <strong>business@thefaceshop.vn</strong><br />
                                            ☎ Hotline đối tác: <strong>1900 1234</strong> (giờ hành chính)
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- KÊU GỌI HÀNH ĐỘNG CHÍNH -->
                    <tr>
                        <td style=""padding:0 28px 24px 28px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                <tr>
                                    <td align=""center"">
                                        <table cellpadding=""0"" cellspacing=""0"" style=""border-radius:999px; overflow:hidden; background:linear-gradient(135deg,#ec4899,#f97316);"">
                                            <tr>
                                                <td align=""center"" style=""padding:10px 26px;"">
                                                    <a href=""https://www.thefaceshop.com.vn""
                                                       target=""_blank""
                                                       style=""color:#ffffff; font-size:13px; font-weight:bold; text-transform:uppercase; letter-spacing:0.16em; text-decoration:none;"">
                                                        KHÁM PHÁ TOÀN BỘ ƯU ĐÃI &rsaquo;
                                                    </a>
                                                </td>
                                            </tr>
                                        </table>
                                        <div style=""margin-top:8px; font-size:11px; color:#9ca3af;"">
                                            * Chương trình có thể thay đổi tùy theo thời điểm, vui lòng kiểm tra thông tin chi tiết tại website.
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- FOOTER -->
                    <tr>
                        <td style=""background-color:#0f172a; padding:16px 24px 14px 24px;"">
                            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                <tr>
                                    <td align=""left"" class=""center-text"" style=""font-size:12px; color:#e5e7eb; line-height:1.6;"">
                                        <strong>THE FACE SHOP VIETNAM</strong><br />
                                        Hệ thống cửa hàng & mua sắm trực tuyến chính hãng.
                                    </td>
                                    <td align=""right"" class=""center-text"" style=""font-size:11px; color:#9ca3af; line-height:1.6;"">
                                        Email này được gửi tới bạn vì bạn đã đăng ký nhận bản tin làm đẹp.<br />
                                        Nếu bạn không muốn nhận thêm, vui lòng cập nhật trong phần cài đặt tài khoản.
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"" style=""padding-top:8px; font-size:11px; color:#6b7280; text-align:center;"">
                                        © @DateTime.Now.Year THE FACE SHOP Vietnam. All rights reserved.
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                </table>
                <!-- HẾT CONTAINER CHÍNH -->

            </td>
        </tr>
    </table>

</body>
</html>
";
        }
    }
}
