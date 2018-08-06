CREATE PROCEDURE sp_showEmpTypes
AS
BEGIN
 SELECT [TypeID],[EmpType]  FROM [dbo].[EmployeeType]
END
