Create Procedure spEmployee_GetById
	@EmployeeId Int
As
Begin
	Set NoCount On
	Set Transaction Isolation Level Read Uncommitted

	Select 
		E.EmployeeId, 
		E.EmployeeName,
		E.Designation,	
		E.EmployeeTypeId,
		ET.EmployeeTypeName,
		E.HourlyPay,	
		E.BonusRate	 
	From Employees E Inner Join EmployeeTypes ET 
	On E.EmployeeTypeId = ET.EmployeeTypeId
	Where E.EmployeeId = @EmployeeId
End
