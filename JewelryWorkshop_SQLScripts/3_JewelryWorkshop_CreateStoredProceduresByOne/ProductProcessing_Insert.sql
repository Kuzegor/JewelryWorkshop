
CREATE PROCEDURE dbo.spProductProcessing_Insert
@ProductId int,
@TechniqueId int,
@Amount float,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.ProductProcessing (ProductId, TechniqueId, Amount)
	values (@ProductId, @TechniqueId, @Amount);

	select @id = SCOPE_IDENTITY();
END
GO
