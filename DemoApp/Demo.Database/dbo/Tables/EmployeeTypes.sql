CREATE TABLE [dbo].[EmployeeTypes] (
    [EmployeeTypeId]   INT          IDENTITY (1, 1) NOT NULL,
    [EmployeeTypeName] VARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeTypeId] ASC)
);

