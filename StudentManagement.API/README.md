# Student Management System API (V2)

This is the modernized, backend-only version of the Student Management System. Built with **ASP.NET Core 10 Web API** and **Entity Framework Core**, this project serves as a robust RESTful API for managing students, courses, and grades.

## 🚀 Features (V2 Upgrade)
- **Modern Architecture**: Migrated from a monolithic Windows Forms Desktop application to a decoupled, scalable REST API.
- **Entity Framework Core (Code-First)**: Eliminated all manual SQL/ADO.NET queries. The database schema is generated automatically via C# data models (Migrations).
- **Dependency Injection**: Utilizes standard .NET Core DI for database contexts and services.
- **Swagger UI**: Built-in API documentation and testing interface.

## 🛠️ Tech Stack
- **Framework**: .NET 10.0
- **Language**: C#
- **ORM**: Entity Framework Core (EF Core) 10
- **Database**: Microsoft SQL Server
- **Documentation**: Swagger / OpenAPI

## ⚙️ Setup & Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/StudentManagementSystem.git
   cd "Student Management System/StudentManagement.API"
   ```

2. **Update Database Connection**
   Open `appsettings.json` and ensure the `DefaultConnection` string matches your local MS SQL Server instance.
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=StudentManagementDB_V2;Trusted_Connection=True;Encrypt=False"
   }
   ```

3. **Run EF Core Migrations**
   This project uses Code-First migrations. You do **not** need to manually run SQL scripts anymore!
   Ensure you have the EF Core CLI tools installed:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
   Then apply the migrations to build the database:
   ```bash
   dotnet ef database update
   ```

4. **Run the API**
   ```bash
   dotnet run
   ```
   *Navigate to `http://localhost:<port>/swagger` in your browser to interact with the API endpoints.*

## 📌 Endpoints Overview
The API provides standard CRUD operations. See Swagger UI for detailed request/response schemas.
- `GET /api/Students` - Retrieve all students
- `POST /api/Students` - Add a new student
- `PUT /api/Students/{id}` - Update a student
- `DELETE /api/Students/{id}` - Delete a student
- Similar endpoints exist for `/api/Courses` and `/api/Grades`.
