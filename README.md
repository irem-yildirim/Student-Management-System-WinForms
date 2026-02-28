# Student Management System

A desktop application designed to manage student records, courses, and grades. The system connects to an MS SQL Server database to provide real-time updates and persistence.

## Features
- **Student Management:** Add, Update, Delete, and List students. Contains input validation and age verification.
- **Course Management:** Create courses, update details, and list available courses.
- **Grade Management:** Assign grades to students for respective courses. 
- **Dashboard:** Offers an overview of total, male, and female student statistics.
- **Printing capability:** Ability to print student lists properly using DGVPrinter.

## Tech Stack
- **Frontend:** Windows Forms (WinForms)
- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **Database:** MS SQL Server

## Prerequisites
- Windows OS
- Visual Studio 2019 or later (or Rider)
- .NET Framework 4.7.2 Developer Pack
- MS SQL Server (e.g., SQL Server Express) or Azure Data Studio

## Installation & Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/StudentManagementSystem.git
   ```

2. **Database Setup**
   - Open SQL Server Management Studio (SSMS) or Azure Data Studio (or VS Code with MSSQL extension).
   - Run the provided `database.sql` script to create the `StudentManagementDB` database and necessary tables.

3. **Configure the Connection String**
   - Open `App.config` inside the `Student Management System` folder.
   - If your SQL instance doesn't use standard Windows Authentication or uses a different host (e.g., `.\SQLEXPRESS`), update the `connectionString` attribute.
   ```xml
   <connectionStrings>
     <add name="DefaultConnection" 
          connectionString="Server=.;Database=StudentManagementDB;Trusted_Connection=True;" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Run the Project**
   - Rebuild the solution inside Visual Studio to restore NuGet packages.
   - Press **Start** to run the application.

## Best Practices Implemented
- **Configuration Management**: Database configuration decoupled from code and stored in configuration files.
- **Security Check**: Mitigation against common SQL Injection attacks using parameterized generic SQL queries.
- **Consistent Naming**: Adherence to official C# variable standard (camelCase / PascalCase).
