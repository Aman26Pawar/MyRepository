
CREATE PROCEDURE sp_deleteType
(
	@_TypeID int
)
AS
BEGIN
	DELETE 
	FROM [dbo].[EmployeeType]
	WHERE [TypeID] = @_TypeID
END
