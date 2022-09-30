
CREATE PROCEDURE dbo.spJewelryTechniques_GetByProductId
@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.JewelryTechniques.id, dbo.JewelryTechniques.TechniqueName, 
	dbo.JewelryTechniques.Price, dbo.JewelryTechniques.Unit, dbo.ProductProcessing.Amount
	from dbo.JewelryTechniques inner join dbo.ProductProcessing
	on dbo.JewelryTechniques.id = dbo.ProductProcessing.TechniqueId
	where dbo.ProductProcessing.ProductId = @ProductId;
END
GO
