
CREATE PROCEDURE dbo.spProductTypes_Insert
@TypeName nvarchar(60),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.ProductTypes (TypeName)
	values (@TypeName);

	select @id = SCOPE_IDENTITY();
END
GO
