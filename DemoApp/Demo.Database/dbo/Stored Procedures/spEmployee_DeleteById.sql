CREATE PROCEDURE [dbo].[spEmployee_DeleteById]
	@EmployeeId Int
As
Begin
	Set NoCount On

	Delete From
	Employees 
	Where EmployeeId = @EmployeeId;
End
