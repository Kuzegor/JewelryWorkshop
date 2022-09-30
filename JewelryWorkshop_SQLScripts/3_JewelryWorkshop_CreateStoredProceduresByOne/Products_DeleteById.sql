
CREATE PROCEDURE dbo.spProducts_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.Products
	where id = @id;
END
GO
