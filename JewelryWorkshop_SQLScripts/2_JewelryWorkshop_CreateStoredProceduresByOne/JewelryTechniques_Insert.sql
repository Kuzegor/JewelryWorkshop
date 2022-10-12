
CREATE PROCEDURE dbo.spJewelryTechniques_Insert
@TechniqueName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.JewelryTechniques(TechniqueName, Price, Unit)
	values (@TechniqueName, @Price, @Unit);

	select @id = SCOPE_IDENTITY();
END
GO
