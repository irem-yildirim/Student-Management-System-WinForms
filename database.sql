-- Create Database
CREATE DATABASE StudentManagementDB;
GO USE StudentManagementDB;
GO -- Create Students Table
    CREATE TABLE Students (
        StudentId INT IDENTITY(1, 1) PRIMARY KEY,
        FirstName NVARCHAR(50) NOT NULL,
        LastName NVARCHAR(50) NOT NULL,
        StudentNumber NVARCHAR(20) NOT NULL,
        BirthDate DATE,
        Email NVARCHAR(100),
        Gender NVARCHAR(10)
    );
GO -- Create Courses Table
    CREATE TABLE Courses (
        CourseId INT IDENTITY(1, 1) PRIMARY KEY,
        CourseName NVARCHAR(100) NOT NULL,
        CourseCode NVARCHAR(50) NOT NULL
    );
GO -- Create Grades Table
    CREATE TABLE Grades (
        GradeId INT IDENTITY(1, 1) PRIMARY KEY,
        StudentId INT NOT NULL,
        CourseId INT NOT NULL,
        Score INT NOT NULL,
        Description NVARCHAR(255),
        CONSTRAINT FK_Grades_Students FOREIGN KEY (StudentId) REFERENCES Students(StudentId) ON DELETE CASCADE,
        CONSTRAINT FK_Grades_Courses FOREIGN KEY (CourseId) REFERENCES Courses(CourseId) ON DELETE CASCADE
    );
GO