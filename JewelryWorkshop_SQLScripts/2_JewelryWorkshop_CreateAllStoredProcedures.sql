use JewelryWorkshop;
go

CREATE PROCEDURE dbo.spClients_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.Clients
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spClients_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.Clients;
END
GO

CREATE PROCEDURE dbo.spClient_GetByOrderId
@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.Clients.id, dbo.Clients.LastName, 
	dbo.Clients.FirstName, dbo.Clients.MiddleName, dbo.Clients.Phone
	from dbo.Clients inner join dbo.Orders
	on dbo.Clients.id = dbo.Orders.ClientId
	where dbo.Orders.id = @OrderId;
END
GO

CREATE PROCEDURE dbo.spClients_Insert
@LastName nvarchar(60),
@FirstName nvarchar(60),
@MiddleName nvarchar(60),
@Phone nvarchar(60),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Clients (LastName, FirstName, MiddleName, Phone)
	values (@LastName, @FirstName, @MiddleName, @Phone);

	select @id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE dbo.spJewelryTechniques_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.JewelryTechniques
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spJewelryTechniques_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.JewelryTechniques;
END
GO

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

CREATE PROCEDURE dbo.spMaterials_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.Materials 
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spMaterials_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.Materials;
END
GO

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

CREATE PROCEDURE dbo.spMaterials_Insert
@MaterialName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Materials(MaterialName, Price, Unit)
	values (@MaterialName, @Price, @Unit);

	select @id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE dbo.spOrderProducts_Insert
@OrderId int,
@ProductId int,
@Quantity int,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.OrderProducts (OrderId, ProductId, Quantity)
	values (@OrderId, @ProductId, @Quantity);

	select @id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE dbo.spOrders_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.Orders
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spOrders_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.Orders;
END
GO

CREATE PROCEDURE dbo.spOrders_Insert
@ClientId int,
@TotalPrice money,
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.Orders (ClientId, StartDate, OrderIsComplete, TotalPrice)
	values (@ClientId, GETDATE(), 0, @TotalPrice);

	select @id = SCOPE_IDENTITY();
END
GO

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

CREATE PROCEDURE dbo.spProducts_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    delete from dbo.Products
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spProducts_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from dbo.Products;
END
GO

CREATE PROCEDURE dbo.spProducts_GetByOrderId
@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select dbo.Products.id, dbo.Products.ProductName, dbo.Products.ProductPrice, dbo.OrderProducts.Quantity 
	from dbo.Products inner join dbo.OrderProducts
	on dbo.Products.id = dbo.OrderProducts.ProductId
	where dbo.OrderProducts.OrderId = @OrderId;
END
GO

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

CREATE PROCEDURE dbo.spProductTypes_DeleteById
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	delete from dbo.ProductTypes
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spProductTypes_GetAll
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from dbo.ProductTypes;
END
GO

CREATE PROCEDURE dbo.spProductTypes_GetByProductId
@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select dbo.ProductTypes.id, dbo.ProductTypes.TypeName from dbo.ProductTypes inner join dbo.Products
	on dbo.ProductTypes.id = dbo.Products.ProductTypeId
	where dbo.Products.id = @ProductId;
END
GO

CREATE PROCEDURE dbo.spProductTypes_Insert
@TypeName nvarchar(60),
@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.ProductTypes (TypeName)
	values (@TypeName);

	select @id = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE dbo.spClients_UpdateById
@LastName nvarchar(60),
@FirstName nvarchar(60),
@MiddleName nvarchar(60),
@Phone nvarchar(60),
@id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Update dbo.Clients
	set LastName = @LastName,
	FirstName = @FirstName,
	MiddleName = @MiddleName,
	Phone = @Phone
	where dbo.Clients.id = @id;
END
GO

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

CREATE PROCEDURE dbo.spMaterials_UpdateById
@MaterialName nvarchar(60),
@Price money,
@Unit nvarchar(20),
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.Materials
	set MaterialName = @MaterialName,
	Price = @Price,
	Unit = @Unit
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spProducts_UpdateById
@ProductName nvarchar(60),
@ProductTypeId int,
@ProductPrice money,
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update dbo.Products
	set ProductName = @ProductName,
	ProductTypeId = @ProductTypeId,
	ProductPrice = @ProductPrice
	where id = @id;

	delete from dbo.ProductComposition
	where dbo.ProductComposition.ProductId = @id;

	delete from dbo.ProductProcessing 
	where dbo.ProductProcessing.ProductId = @id;
END
GO

CREATE PROCEDURE dbo.spProducts_UpdatePriceById
@ProductPrice money,
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.Products
	set ProductPrice = @ProductPrice
	where id = @id;
END
GO

CREATE PROCEDURE dbo.spProductTypes_UpdateById
@TypeName nvarchar(60),
@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    update dbo.ProductTypes
	set TypeName = @TypeName
	where id = @id;
END
GO



