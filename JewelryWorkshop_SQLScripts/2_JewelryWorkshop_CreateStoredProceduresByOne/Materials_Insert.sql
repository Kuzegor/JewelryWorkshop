
CREATE PROCEDURE dbo.spMaterials_Insert
@MaterialName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Materials(MaterialName, Price, Unit)
	values (@MaterialName, @Price, @Unit);

	select @id = SCOPE_IDENTITY();
END
GO
