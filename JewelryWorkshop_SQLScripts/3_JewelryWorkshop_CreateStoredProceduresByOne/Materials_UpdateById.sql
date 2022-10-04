
CREATE PROCEDURE dbo.spMaterials_UpdateById
@MaterialName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.Materials
	set MaterialName = @MaterialName,
	Price = @Price,
	Unit = @Unit
	where id = @id;
END
GO
