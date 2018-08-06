
CREATE PROCEDURE sp_AddEmployeeType
(
	@_TypeName varchar(MAX)
)AS
BEGIN
	INSERT INTO [dbo].[sp_showEmpTypes]
				(
					[EmpType]
				)
		VALUES 
				(
					@_TypeName
				)
END
