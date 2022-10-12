
CREATE PROCEDURE dbo.spProducts_Insert
@ProductName nvarchar(60),
@ProductTypeId int,
@ProductPrice money,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.Products (ProductName, ProductTypeId, ProductPrice)
	values (@ProductName, @ProductTypeId, @ProductPrice);

	select @id = SCOPE_IDENTITY();
END
GO
