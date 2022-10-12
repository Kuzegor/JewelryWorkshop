
CREATE PROCEDURE dbo.spOrderProducts_Insert
@OrderId int,
@ProductId int,
@Quantity int,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.OrderProducts (OrderId, ProductId, Quantity)
	values (@OrderId, @ProductId, @Quantity);

	select @id = SCOPE_IDENTITY();
END
GO
