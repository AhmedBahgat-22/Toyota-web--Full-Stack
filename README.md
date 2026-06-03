# 🚗 Toyota Full-Stack Web Application

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_MVC-10.0-0089D6?style=for-the-badge&logo=dotnet)
![SQLite](https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite)
![Bootstrap](https://img.shields.io/badge/Bootstrap_5-563D7C?style=for-the-badge&logo=bootstrap)
![Docker](https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&logo=docker)

## 📖 Project Overview
This project is a comprehensive, fully functional, database-driven web application for Toyota Motor Corporation. Originally starting as a static HTML/CSS layout, it has been architected into a robust full-stack solution using **ASP.NET Core MVC**. 

The application demonstrates practical and advanced implementations of modern backend architecture, RESTful API design, database relationship management using Entity Framework Core, and session-based authentication. 

🔗 **[View Live Demo Here](https://toyota-demo-app.onrender.com)**

---

## 🏗️ Architecture & Core Concepts
The application strictly adheres to the **MVC (Model-View-Controller)** design pattern, ensuring a clean separation of concerns and highly maintainable code:
*   **Controllers:** 14 dedicated controllers handling diverse business logic, routing, and HTTP request management.
*   **Models & Data:** 7 primary database models utilizing data annotations (`[Required]`, `[MaxLength]`) for robust backend validation.
*   **Views:** Over 25 dynamic Razor pages (`.cshtml`) offering a highly interactive and data-driven user experience.
*   **Dependency Injection:** Extensively used for DbContext and service management across the entire application lifecycle.

---

## ✨ Deep Dive into Features

### 👤 User Interface (Client-Side)
*   **Dynamic Showroom & Filtering:** Browse vehicles with real-time JavaScript (Fetch API) filtering based on categories (e.g., Sedans, SUVs, Trucks) asynchronously, without page reloads.
*   **Build & Price Tool:** Interactive configurator allowing users to select vehicle trims, toggle color swatches, and see live price updates dynamically.
*   **Service & Support Portal:** Includes appointment scheduling forms, viewing service history, and an active recall checker utilizing the vehicle's VIN.
*   **Shopping Cart & Checkout:** Complete e-commerce flow for vehicle reservation, integrating special offers and user data collection.
*   **Saved Vehicles:** Session-based storage allowing users to save and toggle their favorite vehicles across different browsing sessions.

### 🛡️ Admin Control Panel (Backend)
*   **Session-Based Authentication:** Secure login system explicitly built with custom Action Filters (`[AdminAuthFilter]`) to protect administrative routes and prevent unauthorized access.
*   **Content Management System (CMS):** Full CRUD (Create, Read, Update, Delete) capabilities to manage the website's dynamic data.
*   **Entity Management:** Control panel to seamlessly add, edit, or remove Vehicles, Engineers, and Managers directly from the database.

---

## 💻 Technology Stack

**Backend:**
*   C# 13.0
*   ASP.NET Core MVC (.NET 10.0)
*   RESTful API (5 dedicated API controllers returning standard HTTP status codes and JSON payloads)

**Database & ORM:**
*   SQLite (Lightweight, file-based relational database)
*   Entity Framework Core (Code-First approach with automated Migrations)
*   LINQ (Complex data querying and manipulation)

**Frontend:**
*   HTML5 & CSS3 (Custom responsive styling and layout algorithms)
*   JavaScript (Vanilla ES6+ for dynamic DOM manipulation)
*   Font Awesome 6 (Vector iconography)

**Deployment:**
*   Docker (Containerization via custom Dockerfile)
*   Render (Cloud hosting environment)

---

## 🗄️ Database Schema
The relational database is carefully normalized and consists of 9 tables:
*   **Vehicles:** The core entity, containing StartingMSRP, specs, and relationships.
*   **Categories:** One-to-Many relationship with Vehicles.
*   **VehicleTrims & VehicleColors:** Foreign keys linked directly to specific Vehicles.
*   **Engineers, Managers, Offers:** Independent entities populated on the frontend for dynamic content rendering.
*   **AdminUsers:** Secured credential storage for dashboard access.

---

## 🚀 How to Run Locally

If you wish to run this project on your local machine, run the following commands sequentially in your terminal:

```bash
git clone [https://github.com/AhmedBahgat-22/Toyota-web--Full-Stack.git](https://github.com/AhmedBahgat-22/Toyota-web--Full-Stack.git)
cd Toyota-web--Full-Stack
dotnet restore
dotnet ef database update
dotnet run
