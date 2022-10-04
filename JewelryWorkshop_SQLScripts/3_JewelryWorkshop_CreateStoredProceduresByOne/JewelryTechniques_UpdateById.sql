
CREATE PROCEDURE dbo.spJewelryTechniques_UpdateById
@TechniqueName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.JewelryTechniques
	set TechniqueName = @TechniqueName,
	Price = @Price,
	Unit = @Unit
	where id = @id;
END
GO
