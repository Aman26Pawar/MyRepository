CREATE TABLE [dbo].[Employees] (
    [EmployeeId]     INT          IDENTITY (1, 1) NOT NULL,
    [EmployeeName]   VARCHAR (50) NOT NULL,
    [Designation]    VARCHAR (25) NOT NULL,
    [EmployeeTypeId] INT          NULL,
    [HourlyPay]      INT          NULL,
    [BonusRate]      INT          NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    FOREIGN KEY ([EmployeeTypeId]) REFERENCES [dbo].[EmployeeTypes] ([EmployeeTypeId])
);

