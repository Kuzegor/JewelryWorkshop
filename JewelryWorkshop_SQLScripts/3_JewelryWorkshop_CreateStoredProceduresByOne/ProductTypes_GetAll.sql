
CREATE PROCEDURE dbo.spProductTypes_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from dbo.ProductTypes;
END
GO
