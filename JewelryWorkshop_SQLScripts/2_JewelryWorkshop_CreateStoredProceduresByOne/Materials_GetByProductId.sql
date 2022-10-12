
CREATE PROCEDURE dbo.spMaterials_GetByProductId
@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.Materials.id, dbo.Materials.MaterialName, dbo.Materials.Price, dbo.Materials.Unit, dbo.ProductComposition.Amount
	from dbo.Materials inner join dbo.ProductComposition
	on dbo.Materials.id = dbo.ProductComposition.MaterialId
	where dbo.ProductComposition.ProductId = @ProductId;
END
GO
