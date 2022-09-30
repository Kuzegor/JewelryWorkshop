
CREATE PROCEDURE dbo.spProductComposition_Insert
@ProductId int,
@MaterialId int,
@Amount float,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.ProductComposition (ProductId, MaterialId, Amount)
	values (@ProductId, @MaterialId, @Amount);

	select @id = SCOPE_IDENTITY();
END
GO
