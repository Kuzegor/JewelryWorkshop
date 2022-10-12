
CREATE PROCEDURE dbo.spJewelryTechniques_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.JewelryTechniques;
END
GO
