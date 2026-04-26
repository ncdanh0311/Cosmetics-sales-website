# Cosmetics Sales Website

ASP.NET MVC 5 cosmetics e-commerce website with customer shopping flow and admin management.

## Features
- Product browsing, filtering, and detail pages
- Register/login, cart, checkout, and order tracking
- Admin CRUD: products, categories, brands, users, orders
- Dashboard analytics (revenue, order status, top customers)
- Beauty guide articles (JSON-based)
- Chatbot API (`POST /api/chatbot/ask`)
- Newsletter email via SMTP

## Tech Stack
- ASP.NET MVC 5
- .NET Framework 4.8
- Entity Framework 5 (Database First)
- SQL Server
- Newtonsoft.Json

## Quick Setup
1. Open `project_mvc.sln` in Visual Studio.
2. Restore NuGet packages.
3. Import `The_Face_Shop.bacpac` into SQL Server.
4. Update `TheFaceShop4Entities` connection string in `Web.config`.
5. Configure SMTP in `Web.config` (`system.net/mailSettings`).
6. Run with IIS Express (`F5`).

## Usage
- Customer pages: `Home/DangKy`, `Home/DangNhap`, `SanPham/ShowSP`, `GioHang`, `DonHang/Index`
- Admin pages: `QLSanPhamAdmin/QuanLySanPham`, `QLDonHangAdmin/QuanLyDonHang`, `ThongKeAdmin/Index`

## Notes
- Current implementation stores passwords in plain text.
- Move secrets (DB/SMTP) out of source before production.
