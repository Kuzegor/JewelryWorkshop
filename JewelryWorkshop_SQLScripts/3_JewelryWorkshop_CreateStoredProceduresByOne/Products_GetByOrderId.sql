
CREATE PROCEDURE dbo.spProducts_GetByOrderId
@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.Products.id, dbo.Products.ProductName, dbo.Products.ProductPrice, dbo.OrderProducts.Quantity 
	from dbo.Products inner join dbo.OrderProducts
	on dbo.Products.id = dbo.OrderProducts.ProductId
	where dbo.OrderProducts.OrderId = @OrderId;
END
GO
