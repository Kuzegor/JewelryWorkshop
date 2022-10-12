
CREATE PROCEDURE dbo.spOrders_UpdateCompletionStatus
@OrderId int,
@OrderIsComplete bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.Orders 
	set OrderIsComplete = @OrderIsComplete
	where id = @OrderId;
END
GO
