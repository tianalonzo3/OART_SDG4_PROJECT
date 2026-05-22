-- =============================================
-- OART - Open Access Resources Tracker
-- Database Script (Schema + Seed Data)
-- Group: 2.7 BSIT
-- =============================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'StudentResourceTrackerDB')
BEGIN
    CREATE DATABASE StudentResourceTrackerDB;
END
GO

USE StudentResourceTrackerDB;
GO

-- =============================================
-- DROP TABLES (if they exist)
-- =============================================
IF OBJECT_ID('dbo.Resources', 'U') IS NOT NULL DROP TABLE dbo.Resources;
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL DROP TABLE dbo.Users;
GO

-- =============================================
-- TABLE: Users
-- =============================================
CREATE TABLE [dbo].[Users] (
    [UserID]   INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Role]     VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);
GO

-- =============================================
-- TABLE: Resources
-- =============================================
CREATE TABLE [dbo].[Resources] (
    [ResourceID]  INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (100) NOT NULL,
    [Description] VARCHAR (255) NULL,
    [Subject]     VARCHAR (50)  NULL,
    [FilePath]    VARCHAR (255) NULL,
    [DateAdded]   DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([ResourceID] ASC)
);
GO

-- =============================================
-- SEED DATA: Users
-- =============================================
INSERT INTO Users (Username, Password, Role) VALUES
('admin',     'admin123',    'Admin'),
('student',   'student123',  'User'),
('christian', 'chris123',    'User'),
('jerome',    'jerome123',   'User'),
('ben',       'ben123',      'User'),
('ralph',     'ralph123',    'User'),
('adrianne',  'adri123',     'User');
GO

-- =============================================
-- SEED DATA: Resources
-- =============================================
INSERT INTO Resources (Title, Description, Subject, FilePath) VALUES
('VB.NET Notes',                    'Programming Notes',                      'Programming',      'C:\Files\vbnotes.pdf'),
('Introduction to Programming',     'Beginner guide to programming concepts', 'Programming',      'C:\Files\intro_prog.pdf'),
('Database Management Systems',     'Covers relational databases and SQL',     'Database',         'C:\Files\dbms.pdf'),
('Data Structures and Algorithms',  'Fundamentals of DSA',                    'Computer Science', 'C:\Files\dsa.pdf'),
('System Analysis and Design',      'Covers SDLC, DFD, ERD, and modeling',   'Information Tech', 'C:\Files\sad.pdf'),
('Mathematics for IT Students',     'Algebra, statistics, discrete math',     'Mathematics',      'C:\Files\math_it.pdf'),
('Networking Fundamentals',         'OSI model, TCP/IP, and protocols',       'Networking',       'C:\Files\networking.pdf'),
('Human Computer Interaction',      'UI/UX principles and user-centered design', 'Information Tech', 'C:\Files\hci.pdf');
GO

-- =============================================
-- VERIFY
-- =============================================
SELECT 'Users'     AS TableName, COUNT(*) AS RecordCount FROM Users
UNION ALL
SELECT 'Resources' AS TableName, COUNT(*) AS RecordCount FROM Resources;
GO
