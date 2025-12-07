using project_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_mvc.Controllers
{
    public class HoTroKhachHangController : Controller
    {
        // GET: HoTroKhachHang
        public ActionResult HoTroKhachHang()
        {
            var hotro = new List<HoTroKhachHang>
        {
            new HoTroKhachHang
            {
                Question = "Làm sao để kiểm tra đơn hàng đã đặt?",
                Answer = "Bạn có thể kiểm tra trạng thái đơn hàng bằng cách truy cập mục 'Tra cứu đơn hàng' trên website, sau đó nhập số điện thoại hoặc mã đơn hàng đã được gửi qua email hoặc SMS. Hệ thống sẽ hiển thị chi tiết các trạng thái: Đã xác nhận, Đang đóng gói, Đang giao hàng, Giao thành công hoặc Hoàn trả. Nếu không tìm thấy thông tin đơn hàng, vui lòng liên hệ bộ phận chăm sóc khách hàng để được hỗ trợ trực tiếp.",
                Category = "Đơn hàng"
            },
            new HoTroKhachHang
            {
                Question = "Bao lâu thì đơn hàng được giao?",
                Answer = "Thời gian giao hàng phụ thuộc vào khu vực của bạn:\n\n- Nội thành TP.HCM và Hà Nội: 1 - 2 ngày làm việc\n- Các tỉnh lân cận: 2 - 4 ngày làm việc\n- Khu vực xa hoặc huyện đảo: 4 - 7 ngày làm việc\n\nLưu ý: Vào dịp lễ, Tết hoặc trong thời gian diễn ra các chương trình khuyến mãi lớn, thời gian xử lý có thể lâu hơn dự kiến.",
                Category = "Vận chuyển"
            },
            new HoTroKhachHang
            {
                Question = "Tôi có thể đổi trả sản phẩm không?",
                Answer = "Chúng tôi hỗ trợ đổi trả sản phẩm trong vòng 7 ngày kể từ ngày nhận hàng khi sản phẩm thuộc các trường hợp sau:\n\n- Sản phẩm giao sai mẫu, sai số lượng hoặc sai dung tích\n- Sản phẩm bị lỗi kỹ thuật từ nhà sản xuất\n- Sản phẩm bị hư hại trong quá trình vận chuyển (có video mở hộp)\n\nĐiều kiện đổi trả: sản phẩm còn nguyên tem, seal, chưa sử dụng và đầy đủ phụ kiện. Không áp dụng đổi trả với sản phẩm đã mở nắp, test trên da hoặc thuộc nhóm mỹ phẩm nhạy cảm.",
                Category = "Đổi trả"
            },
            new HoTroKhachHang
            {
                Question = "Có những hình thức thanh toán nào?",
                Answer = "Chúng tôi hỗ trợ nhiều hình thức thanh toán để bạn lựa chọn:\n\n- Thanh toán khi nhận hàng (COD)\n- Chuyển khoản ngân hàng\n- Ví điện tử: Momo, ZaloPay, ShopeePay, VNPay QR\n- Thẻ thanh toán quốc tế: Visa, MasterCard, JCB\n\nTất cả giao dịch thanh toán online đều được bảo mật theo tiêu chuẩn quốc tế.",
                Category = "Thanh toán"
            },
            new HoTroKhachHang
            {
                Question = "Sản phẩm có phải hàng chính hãng không?",
                Answer = "Toàn bộ sản phẩm đều được nhập khẩu chính hãng hoặc phân phối trực tiếp từ thương hiệu. Mỗi sản phẩm đều có tem chống hàng giả, mã QR xác thực và hóa đơn đầy đủ. Nếu bạn phát hiện dấu hiệu bất thường, chúng tôi sẽ hỗ trợ kiểm tra và giải quyết theo quy định của hãng.",
                Category = "Sản phẩm"
            },
            new HoTroKhachHang
            {
                Question = "Tôi đặt nhầm sản phẩm, có thể hủy đơn không?",
                Answer = "Bạn có thể yêu cầu hủy đơn trong vòng 1 - 2 giờ sau khi đặt hàng nếu đơn chưa chuyển sang trạng thái 'Đã bàn giao cho đơn vị vận chuyển'.\n\nCách hủy đơn:\n1. Vào tài khoản → Đơn hàng → Hủy đơn\n2. Gọi hotline CSKH\n3. Nhắn tin Fanpage hoặc Zalo Official\n\nNếu đơn đã được giao cho shipper, bạn vẫn có thể từ chối nhận hàng.",
                Category = "Đơn hàng"
            },
            new HoTroKhachHang
            {
                Question = "Phí vận chuyển được tính như thế nào?",
                Answer = "Phí vận chuyển phụ thuộc vào địa chỉ nhận hàng và giá trị đơn hàng:\n\n- Miễn phí ship với đơn từ 299.000đ (nội thành) hoặc 499.000đ (toàn quốc)\n- Phí thường từ 18.000đ - 35.000đ tùy khu vực\n- Với đơn hàng trên 2kg, phí sẽ được tính theo quy định của đơn vị vận chuyển\n\nPhí được hiển thị rõ trước khi bạn thanh toán.",
                Category = "Vận chuyển"
            },
            new HoTroKhachHang
            {
                Question = "Làm sao để biết sản phẩm phù hợp với loại da của tôi?",
                Answer = "Chúng tôi có đội ngũ tư vấn viên hỗ trợ phân tích da miễn phí qua online hoặc trực tiếp tại cửa hàng. Bạn chỉ cần mô tả tình trạng da (dầu, khô, mụn, nhạy cảm...) và chúng tôi sẽ đề xuất sản phẩm phù hợp. Nếu cần soi da chuyên sâu, bạn có thể đặt lịch tại showroom gần nhất.",
                Category = "Tư vấn"
            },
            new HoTroKhachHang
            {
                Question = "Có chương trình tích điểm thành viên không?",
                Answer = "Chúng tôi áp dụng chương trình thành viên theo cấp độ:\n\n- Silver: Từ 0 – 2 triệu / năm → Tích 3% điểm thưởng\n- Gold: Từ 2 – 5 triệu / năm → Tích 5% + ưu đãi sinh nhật\n- Diamond: Trên 5 triệu / năm → Tích 7% + Freeship + đặc quyền VIP\n\nĐiểm thưởng có thể quy đổi trực tiếp khi thanh toán.",
                Category = "Khuyến mãi"
            },
            new HoTroKhachHang
            {
                Question = "Tôi bị dị ứng khi dùng sản phẩm, có được hoàn tiền không?",
                Answer = "Nếu da bạn bị kích ứng khi sử dụng sản phẩm, vui lòng chụp ảnh tình trạng da, cung cấp video mở hộp và mô tả chi tiết. Chúng tôi sẽ tiếp nhận thông tin và gửi về hãng để xác minh. Nếu đúng lỗi sản phẩm, bạn có thể chọn đổi sản phẩm khác hoặc hoàn tiền 100%.",
                Category = "Đổi trả"
            },
            new HoTroKhachHang
            {
                Question = "Tôi có thể xuất hóa đơn điện tử không?",
                Answer = "Bạn hoàn toàn có thể yêu cầu xuất hóa đơn. Khi thanh toán, chỉ cần tích chọn mục 'Xuất hóa đơn GTGT' và điền thông tin công ty. Hóa đơn sẽ được gửi đến email của bạn trong vòng 24 – 48 giờ sau khi đơn giao thành công.",
                Category = "Thanh toán"
            },
            new HoTroKhachHang
            {
                Question = "Sản phẩm thiết bị điện tử có bảo hành không?",
                Answer = "Các thiết bị như máy rửa mặt, máy xông hơi, máy massage da… được bảo hành từ 6 – 12 tháng tùy thương hiệu. Bạn chỉ cần giữ mã đơn hàng hoặc hóa đơn điện tử, không yêu cầu phiếu bảo hành giấy. Nếu sản phẩm lỗi trong 7 ngày đầu, chúng tôi hỗ trợ đổi mới 1:1.",
                Category = "Bảo hành"
            },
            new HoTroKhachHang
            {
                Question = "Làm sao để nhận voucher giảm giá?",
                Answer = "Bạn có thể nhận mã giảm giá theo các cách sau:\n\n- Đăng ký email nhận thông tin ưu đãi\n- Theo dõi Fanpage hoặc Zalo OA để lấy mã độc quyền\n- Tích điểm thành viên và đổi voucher\n- Tham gia Flash Sale theo giờ (0h, 12h, 20h)\n\nVoucher được nhập tại bước thanh toán.",
                Category = "Khuyến mãi"
            },
            new HoTroKhachHang
            {
                Question = "Sản phẩm có hạn sử dụng bao lâu?",
                Answer = "Hạn sử dụng trung bình của mỹ phẩm từ 24 – 36 tháng nếu chưa mở nắp và 6 – 12 tháng sau khi mở nắp. Hạn sử dụng được in trên bao bì theo dạng EXP (ngày hết hạn) hoặc MFG (ngày sản xuất) kèm thời hạn sử dụng. Sản phẩm chứa vitamin C hoặc AHA/BHA nên dùng trong 3 – 6 tháng sau khi mở nắp.",
                Category = "Sản phẩm"
            },
            new HoTroKhachHang
            {
                Question = "Tôi muốn thay đổi địa chỉ nhận hàng thì làm sao?",
                Answer = "Nếu đơn hàng chưa được giao cho đơn vị vận chuyển, bạn có thể liên hệ CSKH để cập nhật địa chỉ mới. Nếu đơn đã ở trạng thái đang giao, shipper vẫn có thể hỗ trợ đổi địa chỉ nhưng thời gian giao có thể kéo dài thêm 1 – 2 ngày.",
                Category = "Đơn hàng"
            }
        };
        
          return View(hotro);
        }
        [HttpPost]
        public ActionResult SendQuestion(string body)
        {
            if (string.IsNullOrWhiteSpace(body))
            {
                TempData["ErrorMessage"] = "Vui lòng nhập nội dung câu hỏi trước khi gửi!";
                return RedirectToAction("HoTroKhachHang");
            }

            TempData["SuccessMessage"] = "Cảm ơn bạn! Chúng tôi đã nhận được câu hỏi và sẽ phản hồi trong thời gian sớm nhất.";
            return RedirectToAction("HoTroKhachHang");
        }

    }
}