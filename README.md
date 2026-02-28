# Student Management System (Multi-Architecture Project)

Welcome to the **Student Management System** repository. This project showcases my journey and growth in backend and desktop development using the .NET ecosystem. 

This repository contains **two different architectural implementations** of the same underlying system. It demonstrates a clear progression from classical, tightly-coupled desktop development to a modern, decoupled backend API.

---

## 🏗️ Phase 1: The Classical Desktop App (V1)
**Stack:** `C#` | `Windows Forms (.NET Framework 4.7.2)` | `ADO.NET` (Raw SQL)

The initial version is a monolithic Windows Forms application. It handles UI, business logic, and database operations in a single app. I refactored this codebase to adhere to professional naming conventions, mitigate SQL injection risks, and establish a solid Object-Oriented foundation.

- **Details & Setup:** The code is located in the `Student Management System` folder.
- **Database Script:** `database.sql` handles physical table creation for this architecture.

---

## 🚀 Phase 2: The Modern Backend API (V2)
**Stack:** `C#` | `ASP.NET Core 10 Web API` | `Entity Framework Core 10` (Code-First)

To modernize the system and simulate a true enterprise environment, I rebuilt the backend entirely from scratch as a RESTful Web API. This version throws away manual ADO.NET SQL queries in favor of EF Core and replaces the Windows Forms UI with standalone HTTP endpoints (Swagger).

- **Location:** `StudentManagement.API` folder.
- **Highlights:** N-Tier Architecture, Dependency Injection, EF Core Migrations, Swagger Documentation.
- **Details & Setup:** 👉 [Click here to view the API Documentation (README)](./StudentManagement.API/README.md)

---

## 🛠️ General Prerequisites
- **IDE:** Visual Studio 2022, Visual Studio Code, or Rider.
- **Database:** MS SQL Server (Express or Developer Edition).
- **SDKs:** 
  - .NET Framework 4.7.2 (for V1 WinForms)
  - .NET 10 SDK (for V2 API)

Feel free to explore both versions to see the coding progression!
