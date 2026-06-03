# 🚗 Toyota Full-Stack Web Application

A professional full-stack web application inspired by the official Toyota website, developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**.

This project started as a static HTML/CSS website and evolved into a complete database-driven web application featuring dynamic content management, RESTful APIs, authentication, session management, administrative dashboards, and modern MVC architecture.

---

# 📖 Project Overview

The Toyota Full-Stack Web Application was built to demonstrate the practical implementation of modern web development concepts using Microsoft's ASP.NET Core ecosystem.

The application simulates a real-world automotive platform where users can:

* Browse Toyota vehicles
* View detailed vehicle information
* Build and customize vehicles
* Explore special offers
* Schedule vehicle service appointments
* Save favorite vehicles
* Manage personal accounts
* Complete vehicle purchases through a checkout process

In addition, the system includes a fully functional administration panel allowing administrators to manage all website content through CRUD operations.

---

# ✨ Key Features

## 🚘 Vehicle Management

* Dynamic vehicle catalog
* Vehicle categories and filtering
* Vehicle detail pages
* Trim selection
* Color customization
* Live pricing updates
* Vehicle specifications and descriptions

## 🛒 Shopping Experience

* Vehicle shopping page
* Checkout workflow
* Order placement system
* Order confirmation page
* Promotional offers integration

## 🔧 Service & Support

* Service center page
* Service appointment scheduling
* Vehicle service history
* Recall information checker
* Customer support contact forms

## 👤 User Features

* User registration
* User login/logout
* Session-based authentication
* User dashboard
* Saved vehicles system

## 🛡️ Administration Panel

* Secure admin login
* Session-protected dashboard
* Vehicle management (Create, Read, Update, Delete)
* Engineer management
* Manager management
* Content administration

## 🔌 REST API

A complete RESTful API layer powers the application and provides JSON data for frontend interactions.

Available endpoints include:

```http
GET    /api/vehicles
GET    /api/categories
GET    /api/engineers
GET    /api/managers
GET    /api/offers

POST   /api/vehicles
PUT    /api/vehicles/{id}
DELETE /api/vehicles/{id}
```

---

# 🏗️ Architecture

The application follows the ASP.NET Core MVC architecture pattern.

## Models

Database entities include:

* Vehicle
* Category
* Engineer
* Manager
* Offer
* VehicleTrim
* VehicleColor
* AdminUser

## Views

More than 25 Razor Views were developed to provide a complete user experience.

## Controllers

The project contains 14 controllers responsible for:

* Page rendering
* Business logic
* API responses
* Authentication
* Data management

---

# 🗄️ Database Design

The application uses SQLite as its relational database.

Tables include:

* Categories
* Vehicles
* Engineers
* Managers
* Offers
* VehicleTrims
* VehicleColors
* AdminUsers
* EF Migration History

Entity Framework Core handles:

* Database creation
* Schema migrations
* Relationships
* CRUD operations
* LINQ queries

The database is automatically initialized and seeded with sample data during application startup.

---

# ⚙️ Technologies Used

| Technology            | Purpose                           |
| --------------------- | --------------------------------- |
| ASP.NET Core MVC      | Web Application Framework         |
| C#                    | Backend Development               |
| Entity Framework Core | ORM & Database Access             |
| SQLite                | Relational Database               |
| Razor Views           | Server-Side Rendering             |
| HTML5                 | Markup Structure                  |
| CSS3                  | Styling & Layout                  |
| JavaScript (ES6+)     | Client-Side Interactivity         |
| Fetch API             | AJAX Data Requests                |
| Font Awesome          | Icons                             |
| Session Storage       | Authentication & State Management |

---

# 🧠 Software Engineering Concepts Applied

This project demonstrates practical implementation of:

* Object-Oriented Programming (OOP)
* MVC Design Pattern
* Dependency Injection (DI)
* Repository-style Data Access through EF Core
* RESTful API Design
* Authentication & Authorization
* Session Management
* Database Relationships
* LINQ Querying
* CRUD Operations
* Middleware Configuration
* Routing & Model Binding
* Data Validation
* Async/Await Programming

---

# 🔐 Authentication System

The project includes a custom session-based authentication system.

### Admin Authentication

Protected routes are secured using:

* Custom AdminAuthFilter
* Session Validation
* Login Redirection
* Secure Dashboard Access

Admin users can manage:

* Vehicles
* Engineers
* Managers
* Website Content

---

# 📂 Project Structure

```text
ToyotaProject
│
├── Controllers
├── Models
├── Views
├── Data
├── Filters
├── wwwroot
│   ├── css
│   ├── js
│   └── images
│
├── Program.cs
├── appsettings.json
└── toyota.db
```

---

# 🚀 Getting Started

## Clone Repository

```bash
git clone https://github.com/your-username/ToyotaProject.git
```

## Navigate to Project

```bash
cd ToyotaProject
```

## Restore Packages

```bash
dotnet restore
```

## Apply Migrations

```bash
dotnet ef database update
```

## Run Application

```bash
dotnet run
```

Open your browser:

```text
http://localhost:5113
```

---

# 📊 Project Statistics

* 14 Controllers
* 8 Database Models
* 25+ Razor Views
* 5 REST API Controllers
* 9 Database Tables
* Full CRUD Administration Panel
* Session-Based Authentication
* Dynamic Frontend Interactions
* Entity Framework Core Integration
* SQLite Database Support

---

# 🎯 Learning Outcomes

Through this project, the following skills were practiced and strengthened:

* Full-Stack Web Development
* ASP.NET Core MVC
* C# Programming
* Entity Framework Core
* Database Design
* REST API Development
* Authentication Systems
* Software Architecture
* Frontend & Backend Integration
* Professional Project Organization

---

# 🏁 Conclusion

This project successfully transforms a static Toyota website into a complete enterprise-style web application.

By combining modern ASP.NET Core development practices with database integration, REST APIs, authentication, administrative tools, and dynamic frontend functionality, the application demonstrates a comprehensive understanding of full-stack software development principles.

The result is a scalable, maintainable, and professional web application that reflects real-world industry practices and showcases advanced web development capabilities.
