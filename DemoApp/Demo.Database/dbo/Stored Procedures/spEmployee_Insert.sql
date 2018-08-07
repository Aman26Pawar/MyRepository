Create Procedure spEmployee_Insert
	@EmployeeName		Varchar(50),
	@Designation		Varchar(25),
	@EmployeeTypeId		Int,
	@HourlyPay			Int, 
	@BonusRate			Int
As
Begin
	Set NoCount On

	Insert Into Employees 
	(
		EmployeeName,
		Designation,	
		EmployeeTypeId,
		HourlyPay,	
		BonusRate	
	) 
	Values 
	(
		@EmployeeName,
		@Designation,	
		@EmployeeTypeId,
		@HourlyPay,	
		@BonusRate
	);

	Select @@Identity as EmployeeId
End