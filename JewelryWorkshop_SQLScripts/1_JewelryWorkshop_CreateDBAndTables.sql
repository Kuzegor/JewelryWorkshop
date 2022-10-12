begin
create database JewelryWorkshop;
end
go

begin
use JewelryWorkshop;

create table ProductTypes(
id int identity primary key,
TypeName nvarchar(60));

create table Products(
id int identity primary key,
ProductName nvarchar(60),
ProductTypeId int references ProductTypes(id) on delete set null on update cascade,
ProductPrice money);

create table JewelryTechniques(
id int identity primary key,
TechniqueName nvarchar(60),
Price money,
Unit nvarchar(20));

create table ProductProcessing(
id int identity primary key,
ProductId int references Products(id) on delete cascade on update cascade,
TechniqueId int references JewelryTechniques(id) on delete set null on update cascade,
Amount float);

create table Materials(
id int identity primary key,
MaterialName nvarchar(60),
Price money,
Unit nvarchar(20));

create table ProductComposition(
id int identity primary key,
ProductId int references Products(id) on delete cascade on update cascade,
MaterialId int references Materials(id) on delete set null on update cascade,
Amount float);

create table Clients(
id int identity primary key,
LastName nvarchar(60),
FirstName nvarchar(60),
MiddleName nvarchar(60),
Phone nvarchar(20));

create table Orders(
id int identity primary key,
ClientId int references Clients(id) on delete set null on update cascade,
StartDate date,
OrderIsComplete bit,
TotalPrice money);

create table OrderProducts(
id int identity primary key,
OrderId int references Orders(id) on delete cascade on update cascade,
ProductId int references Products(id) on delete set null on update cascade,
Quantity int);
end


