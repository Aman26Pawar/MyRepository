
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/25/2018 13:29:21
-- Generated from EDMX file: c:\users\aman.pawar\documents\visual studio 2013\Projects\ModelBasedDemo1\ModelBasedDemo1\ModelBasedModel1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StudentDeptCor];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DepartmentsCourses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_DepartmentsCourses];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentsStudentInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentInfoes] DROP CONSTRAINT [FK_DepartmentsStudentInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursesStudentInfo_Courses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursesStudentInfo] DROP CONSTRAINT [FK_CoursesStudentInfo_Courses];
GO
IF OBJECT_ID(N'[dbo].[FK_CoursesStudentInfo_StudentInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CoursesStudentInfo] DROP CONSTRAINT [FK_CoursesStudentInfo_StudentInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[StudentInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentInfoes];
GO
IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[CoursesStudentInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CoursesStudentInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StudentInfoes'
CREATE TABLE [dbo].[StudentInfoes] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [DepartmentsDepartmentId] int  NOT NULL,
    [DepartmentsDepartmentId1] int  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [DepartmentId] int IDENTITY(1,1) NOT NULL,
    [DepartmentName] nvarchar(max)  NOT NULL,
    [StudentInfoStudentID] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseId] int IDENTITY(1,1) NOT NULL,
    [CourseName] nvarchar(max)  NOT NULL,
    [DepartmentsDepartmentId] int  NOT NULL,
    [DepartmentsDepartmentId1] int  NOT NULL,
    [DepartmentsDepartmentId2] int  NOT NULL
);
GO

-- Creating table 'CoursesStudentInfo'
CREATE TABLE [dbo].[CoursesStudentInfo] (
    [Courses_CourseId] int  NOT NULL,
    [StudentInfoes_StudentID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentID] in table 'StudentInfoes'
ALTER TABLE [dbo].[StudentInfoes]
ADD CONSTRAINT [PK_StudentInfoes]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- Creating primary key on [DepartmentId] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC);
GO

-- Creating primary key on [CourseId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseId] ASC);
GO

-- Creating primary key on [Courses_CourseId], [StudentInfoes_StudentID] in table 'CoursesStudentInfo'
ALTER TABLE [dbo].[CoursesStudentInfo]
ADD CONSTRAINT [PK_CoursesStudentInfo]
    PRIMARY KEY CLUSTERED ([Courses_CourseId], [StudentInfoes_StudentID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmentsDepartmentId2] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_DepartmentsCourses]
    FOREIGN KEY ([DepartmentsDepartmentId2])
    REFERENCES [dbo].[Departments]
        ([DepartmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentsCourses'
CREATE INDEX [IX_FK_DepartmentsCourses]
ON [dbo].[Courses]
    ([DepartmentsDepartmentId2]);
GO

-- Creating foreign key on [DepartmentsDepartmentId1] in table 'StudentInfoes'
ALTER TABLE [dbo].[StudentInfoes]
ADD CONSTRAINT [FK_DepartmentsStudentInfo]
    FOREIGN KEY ([DepartmentsDepartmentId1])
    REFERENCES [dbo].[Departments]
        ([DepartmentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentsStudentInfo'
CREATE INDEX [IX_FK_DepartmentsStudentInfo]
ON [dbo].[StudentInfoes]
    ([DepartmentsDepartmentId1]);
GO

-- Creating foreign key on [Courses_CourseId] in table 'CoursesStudentInfo'
ALTER TABLE [dbo].[CoursesStudentInfo]
ADD CONSTRAINT [FK_CoursesStudentInfo_Courses]
    FOREIGN KEY ([Courses_CourseId])
    REFERENCES [dbo].[Courses]
        ([CourseId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [StudentInfoes_StudentID] in table 'CoursesStudentInfo'
ALTER TABLE [dbo].[CoursesStudentInfo]
ADD CONSTRAINT [FK_CoursesStudentInfo_StudentInfo]
    FOREIGN KEY ([StudentInfoes_StudentID])
    REFERENCES [dbo].[StudentInfoes]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoursesStudentInfo_StudentInfo'
CREATE INDEX [IX_FK_CoursesStudentInfo_StudentInfo]
ON [dbo].[CoursesStudentInfo]
    ([StudentInfoes_StudentID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------