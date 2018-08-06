CREATE PROCEDURE spUpdateEmployeeDetail
(
	@_EmpID int,
	@_EmpNm VARCHAR(MAX),
	@_DepartmentName  VARCHAR(MAX),
	@_TypeID int,
	@_HourlySal int,
	@_BonusRate int
)
AS
SELECT [EmpID],[EmpName],[Department],[EmpType],[HourlySal],[Bonusrate] FROM [dbo].[EmployeeData]
BEGIN
	UPDATE [dbo].[EmployeeData] SET [Department] = @_DepartmentName, [EmpType] = @_TypeID,
	 [HourlySal] = @_HourlySal, [Bonusrate] = @_BonusRate WHERE [EmpID] = @_EmpID 
END
