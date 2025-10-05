-- Создаем базу данных в SSMS (SQL Server Management Studio)
CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

-- Таблица сотрудников
CREATE TABLE Employees (
    EmployeeId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(200) NOT NULL,
    DateOfBirth DATE NOT NULL,
    ContactInfo NVARCHAR(200) NULL,
    JobPosition NVARCHAR(100) NOT NULL,
    Photo VARBINARY(MAX)
);

-- Таблица пользователей
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(200) NOT NULL,
    IsAdmin BIT NOT NULL,
    EmployeeId INT NOT NULL,
    FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId) ON DELETE CASCADE
);

-- Таблица логов авторизации
CREATE TABLE AuthLogs (
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NULL,
    LoginTimestamp DATETIME NOT NULL,
    Success BIT NOT NULL,
    FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE
);
