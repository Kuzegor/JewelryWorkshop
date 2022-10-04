
CREATE PROCEDURE dbo.spProducts_UpdateById
@ProductName nvarchar(60),
@ProductTypeId int,
@ProductPrice money,
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.Products
	set ProductName = @ProductName,
	ProductTypeId = @ProductTypeId,
	ProductPrice = @ProductPrice
	where id = @id;

	delete from dbo.ProductComposition
	where dbo.ProductComposition.ProductId = @id;

	delete from dbo.ProductProcessing 
	where dbo.ProductProcessing.ProductId = @id;
END
GO
