CREATE PROCEDURE sp_showEmployees
AS
BEGIN
 SELECT [EmpID],[EmpName],[Department],[EmpType],[HourlySal],[Bonusrate] FROM [dbo].[EmployeeData]
END
