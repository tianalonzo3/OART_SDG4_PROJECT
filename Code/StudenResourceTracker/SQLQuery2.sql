CREATE DATABASE StudentResourceTrackerDB

USE StudentResourceTrackerDB

CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(20) NOT NULL
)

INSERT INTO Users (Username, Password, Role)
VALUES
('admin', 'admin123', 'Admin'),
('student', 'student123', 'User')

CREATE TABLE Resources (
    ResourceID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(100) NOT NULL,
    Description VARCHAR(255),
    Subject VARCHAR(50),
    FilePath VARCHAR(255),
    DateAdded DATETIME DEFAULT GETDATE()
)

INSERT INTO Resources (Title, Description, Subject, FilePath)
VALUES
('VB.NET Notes', 'Programming Notes', 'Programming', 'C:\Files\vbnotes.pdf')