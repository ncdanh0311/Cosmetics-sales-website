Cosmetics Sales Website 
This project is a comprehensive e-commerce platform specialized in cosmetics, built on the ASP.NET MVC 5 framework. It provides a full-featured experience for both customers and administrators, integrated with an automated ChatBot for customer support.

🚀 Key Features
🛡️ For Customers
Product Catalog: Browse and search for beauty products by category or brand.

Shopping Cart: Add, update, and manage products before checkout.

Order System: Seamless ordering process with detailed order tracking.

User Accounts: Secure registration, login, and profile management.

Beauty Guide: Educational blog posts for skincare and beauty tips.

Automated ChatBot: A Web API-based assistant that provides quick answers to common FAQs using chatbot-data.json.

⚙️ For Administrators
Dashboard & Analytics: View revenue statistics and order overviews.

Inventory Management: Full CRUD operations for products, categories, and brands.

Order Fulfillment: Manage and update the status of customer orders.

Content Management: Manage blog posts and beauty guides.

Account Management: Administer user lists and system permissions.

📂 Project Structure
/App_Data: Stores the database files and ChatBot training data (chatbot-data.json).

/Controllers: Handles the business logic for both the storefront and admin panel.

/Models: Contains Entity Framework models, ViewModels, and services like EmailService.

/Views: Contains the Razor views for the user interface.

/Content & /Scripts: CSS and JavaScript files for styling and interactivity.

🛠️ Installation & Setup
Database Configuration:

Attach the SQL Server database using the provided .bacpac file or run the SQL script.

Update the connection strings in Web.config to match your local SQL Server instance.

Email Service Setup:

Configure your SMTP settings in the <system.net> section of Web.config (pre-configured for Gmail).

Running the Project:

Open project_mvc.sln in Visual Studio (2019 or 2022 recommended).

Restore NuGet packages to install dependencies like Newtonsoft.Json and EntityFramework.

Press F5 to run the application on IIS Express.
