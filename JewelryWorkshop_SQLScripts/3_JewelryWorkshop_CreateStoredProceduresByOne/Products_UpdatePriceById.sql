
CREATE PROCEDURE dbo.spProducts_UpdatePriceById
@ProductPrice money,
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.Products
	set ProductPrice = @ProductPrice
	where id = @id;
END
GO
