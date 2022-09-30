
CREATE PROCEDURE dbo.spProductTypes_GetByProductId
@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select dbo.ProductTypes.id, dbo.ProductTypes.TypeName from dbo.ProductTypes inner join dbo.Products
	on dbo.ProductTypes.id = dbo.Products.ProductTypeId
	where dbo.Products.id = @ProductId;
END
GO
