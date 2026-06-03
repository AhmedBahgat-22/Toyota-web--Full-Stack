# 🚗 Toyota Full-Stack Web Application

A professional full-stack web application inspired by the official Toyota website, developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**.

The project began as a static HTML/CSS website and was transformed into a complete database-driven web application featuring dynamic content management, RESTful APIs, session-based authentication, administrative dashboards, and modern MVC architecture.

---

## 📖 Project Overview

The Toyota Full-Stack Web Application was developed to demonstrate the practical implementation of modern web development concepts using the ASP.NET Core ecosystem.

The application demonstrates practical and advanced implementations of modern backend architecture, RESTful API design, database relationship management using Entity Framework Core, and session-based authentication.

Users can browse vehicles, view detailed specifications, customize vehicle trims and colors, explore special offers, schedule service appointments, save favorite vehicles, manage accounts, and complete purchase workflows through an intuitive user experience.

The system also includes a fully functional administration panel that enables administrators to manage vehicles, engineers, managers, and website content through complete CRUD operations.

🔗 **[View Live Demo Here](https://toyota-demo-app.onrender.com)**

---

## ✨ Key Features

### 🚘 Vehicle Management

* Dynamic vehicle catalog
* Vehicle category filtering
* Detailed vehicle information pages
* Trim selection system
* Color customization
* Live price updates
* Vehicle specifications and descriptions

### 🛒 Shopping System

* Vehicle shopping experience
* Checkout process
* Order placement workflow
* Order confirmation system
* Promotional offers integration

### 🔧 Service & Support

* Service center page
* Service scheduling system
* Vehicle service history
* Recall information checker
* Customer support forms

### 👤 User Features

* User registration
* User login/logout
* Session-based user authentication
* Personal dashboard
* Saved vehicles functionality

### 🛡️ Administration Panel

* Secure admin authentication
* Session-protected dashboard
* Vehicle management (CRUD)
* Engineer management (CRUD)
* Manager management (CRUD)
* Content administration tools

### 🔌 REST API

A complete RESTful API layer powers the application and provides JSON responses for frontend integration.

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

## 🏗️ System Architecture

The project follows the ASP.NET Core MVC (Model-View-Controller) architectural pattern.

### Models

Database entities include:

* Vehicle
* Category
* Engineer
* Manager
* Offer
* VehicleTrim
* VehicleColor
* AdminUser

### Views

More than 25 Razor Views provide a complete and responsive user interface.

### Controllers

The application contains 14 controllers responsible for:

* Request handling
* Business logic
* Data processing
* Authentication
* API responses
* Content management

---

## 🗄️ Database Design

The application uses SQLite as a lightweight relational database.

### Database Tables

* Categories
* Vehicles
* Engineers
* Managers
* Offers
* VehicleTrims
* VehicleColors
* AdminUsers
* EF Migration History

### Entity Framework Core Features

* Code First Approach
* DbContext Configuration
* Database Migrations
* Seed Data Initialization
* LINQ Queries
* Relationship Management
* CRUD Operations

The database is automatically created and updated during application startup using Entity Framework Core migrations.

---

## 🔐 Authentication & Security

The project implements a custom session-based authentication system.

### Admin Authentication

Protected routes are secured using:

* Custom AdminAuthFilter
* Session validation
* Login redirection
* Dashboard protection
* Secure logout functionality

### User Authentication

* User login
* User registration
* Session management
* Personalized dashboard

---

## ⚙️ Technologies Used

| Technology            | Purpose                     |
| --------------------- | --------------------------- |
| ASP.NET Core MVC      | Web Application Framework   |
| C#                    | Backend Development         |
| Entity Framework Core | ORM & Data Access           |
| SQLite                | Database Engine             |
| Razor Views           | Server-Side Rendering       |
| HTML5                 | Frontend Structure          |
| CSS3                  | Styling & Layout            |
| JavaScript (ES6+)     | Dynamic Functionality       |
| Fetch API             | Client-Server Communication |
| Font Awesome          | Icons & UI Components       |
| Session Storage       | Authentication & User State |

---

## 🧠 Software Engineering Concepts Applied

This project demonstrates the practical implementation of:

* Object-Oriented Programming (OOP)
* MVC Architecture
* Dependency Injection (DI)
* Entity Framework Core
* RESTful API Design
* Session-Based Authentication
* Routing & Model Binding
* Middleware Configuration
* Data Validation
* Database Relationships
* LINQ Querying
* CRUD Operations
* Async/Await Programming
* Frontend & Backend Integration

---

## 📂 Project Structure

```text
ToyotaProject
│
├── Controllers
├── Models
├── Data
├── Views
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

## 🚀 Getting Started

### Clone Repository

```bash
git clone https://github.com/your-username/ToyotaProject.git
```

### Navigate to Project

```bash
cd ToyotaProject
```

### Restore Dependencies

```bash
dotnet restore
```

### Apply Database Migrations

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

Open your browser:

```text
http://localhost:5113
```

---

## 📊 Project Statistics

* ✅ 14 Controllers
* ✅ 8 Database Models
* ✅ 25+ Razor Views
* ✅ 5 REST API Controllers
* ✅ 9 Database Tables
* ✅ Full CRUD Administration Panel
* ✅ Session-Based Authentication
* ✅ Dynamic JavaScript Functionality
* ✅ Entity Framework Core Integration
* ✅ SQLite Database Support

---

## 🎯 Learning Outcomes

Through the development of this project, the following skills were strengthened:

* Full-Stack Web Development
* ASP.NET Core MVC
* Database Design
* REST API Development
* Software Architecture
* Authentication Systems
* Backend Engineering
* Frontend Integration
* Entity Framework Core
* Professional Project Organization

---

## 🏁 Conclusion

The Toyota Full-Stack Web Application successfully transforms a static website into a complete enterprise-style web platform.

By combining ASP.NET Core MVC, Entity Framework Core, SQLite, RESTful APIs, authentication systems, administrative dashboards, and dynamic frontend functionality, the project demonstrates a comprehensive understanding of modern full-stack development principles and real-world software engineering practices.

The final result is a scalable, maintainable, and professional web application that reflects industry standards and showcases advanced backend and frontend integration.
