
CREATE PROCEDURE dbo.spClient_GetByOrderId
@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.Clients.id, dbo.Clients.LastName, 
	dbo.Clients.FirstName, dbo.Clients.MiddleName, dbo.Clients.Phone
	from dbo.Clients inner join dbo.Orders
	on dbo.Clients.id = dbo.Orders.ClientId
	where dbo.Orders.id = @OrderId;
END
GO
