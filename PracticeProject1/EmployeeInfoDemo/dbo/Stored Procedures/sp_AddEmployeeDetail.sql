
CREATE PROCEDURE sp_AddEmployeeDetail
(
	@_EmpName varchar(MAX),
	@_DepartmentName varchar(MAX),
	@_TypeID int ,
	@_HourlySal int,
	@_BonusRate int
)AS
BEGIN
	INSERT INTO [dbo].[EmployeeData]
				(
					[EmpName],[Department],[EmpType],[HourlySal],[Bonusrate]
				)
		VALUES 
				(
					@_EmpName, @_DepartmentName, @_TypeID, @_HourlySal, @_BonusRate
				)
END
