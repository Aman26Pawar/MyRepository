CREATE TABLE [dbo].[EmployeeData] (
    [EmpID]      INT          IDENTITY (1, 1) NOT NULL,
    [EmpName]    VARCHAR (50) NULL,
    [Department] VARCHAR (50) NULL,
    [EmpType]    INT          NULL,
    [HourlySal]  INT          NULL,
    [Bonusrate]  INT          NULL,
    PRIMARY KEY CLUSTERED ([EmpID] ASC),
    FOREIGN KEY ([EmpType]) REFERENCES [dbo].[EmployeeType] ([TypeID])
);

