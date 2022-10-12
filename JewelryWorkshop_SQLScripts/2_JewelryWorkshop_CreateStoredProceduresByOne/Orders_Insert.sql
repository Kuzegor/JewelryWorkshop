
CREATE PROCEDURE dbo.spOrders_Insert
@ClientId int,
@TotalPrice money,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Orders (ClientId, StartDate, OrderIsComplete, TotalPrice)
	values (@ClientId, GETDATE(), 0, @TotalPrice);

	select @id = SCOPE_IDENTITY();
END
GO
