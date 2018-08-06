CREATE PROCEDURE sp_deleteEmployee
(
	@_EmpID int
)
AS
BEGIN
	DELETE 
	FROM [dbo].[EmployeeData]
	WHERE [EmpID] = @_EmpID
END

