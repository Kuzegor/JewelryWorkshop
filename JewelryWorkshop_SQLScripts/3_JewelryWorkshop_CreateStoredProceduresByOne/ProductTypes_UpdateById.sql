
CREATE PROCEDURE dbo.spProductTypes_UpdateById
@TypeName nvarchar(60),
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.ProductTypes
	set TypeName = @TypeName
	where id = @id;
END
GO
