# Tóm tắt ChatBot Web API

## Tổng quan
- Cung cấp API tư vấn tự động cho website mỹ phẩm, sử dụng dữ liệu huấn luyện có sẵn trong `App_Data/chatbot-data.json`.
- Mục tiêu: trả lời nhanh các câu hỏi phổ biến, đồng thời chuyển hướng người dùng đến hỗ trợ chi tiết khi cần.

## Endpoint chính
- **POST `/api/chatbot/ask`**
  - Payload: `{ "message": "<câu hỏi người dùng>" }`.
  - Phản hồi JSON: `{ success: bool, answer: string, matched: bool }`.
  - Kiểm tra đầu vào rỗng và trả về thông báo lỗi thân thiện khi thiếu nội dung.

## Luồng xử lý
1. Nhận và chuẩn hóa câu hỏi (lowercase, cắt khoảng trắng dư thừa).
2. Dò tìm từ khóa trong thư viện huấn luyện (`ChatBotLibrary`) bằng so khớp chuỗi đơn giản.
3. Nếu tìm thấy, trả về câu trả lời tương ứng kèm cờ `matched = true`.
4. Nếu không khớp, phản hồi bằng câu trả lời mặc định định hướng người dùng cung cấp thêm thông tin.
5. Toàn bộ thao tác trả về JSON, thuận tiện cho AJAX/fetch trên giao diện.

## Dữ liệu & độ tin cậy
- Thư viện được tải lười (lazy load) từ `App_Data/chatbot-data.json` và sao chép sang thư mục output khi build.
- Bổ sung cơ chế fallback đường dẫn (dùng `HostingEnvironment.MapPath` hoặc `AppDomain.CurrentDomain.BaseDirectory`) để luôn tìm thấy tập dữ liệu trong cả môi trường runtime và test.
- Khi tập tin không tồn tại hoặc lỗi đọc/deserialize, API vẫn chạy ổn định và phản hồi câu trả lời mặc định.

## Tích hợp giao diện
- Widget chatbot trên trang `View.cshtml` gửi fetch POST tới `/api/chatbot/ask` với payload `message`.
- Giao diện hiển thị trạng thái gửi/đang trả lời và tự động fallback sang thư viện cục bộ nếu API gặp sự cố.
- Hỗ trợ gợi ý nhanh và tin nhắn chào giúp người dùng bắt đầu tương tác.

## Điểm nhấn cho slide
- API nhẹ, không phụ thuộc framework nặng; chỉ dùng MVC chuẩn.
- Bảo vệ đầu vào (trim, kiểm tra rỗng) và trả về thông báo rõ ràng.
- Khả năng mở rộng: chỉ cần thêm từ khóa/câu trả lời vào file JSON để cải thiện độ phủ.
