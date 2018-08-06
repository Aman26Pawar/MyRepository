CREATE TABLE [dbo].[EmployeeType] (
    [TypeID]  INT          IDENTITY (1, 1) NOT NULL,
    [EmpType] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([TypeID] ASC)
);

