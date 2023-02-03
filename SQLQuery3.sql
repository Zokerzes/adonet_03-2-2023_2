--create table Supliers(
--	id int identity (1,1) not null primary key,
--	[Name] nvarchar(100) not null,
--	GoodsType nvarchar(100) not null,
--	Cost money not null default 0
--)

--create table Supliers(
--	id int identity (1,1) not null primary key,
--	[Name] nvarchar(100) not null,

--)


create table Deliveries(
	id int identity (1,1) not null primary key,
	Amount int not null,
	DeliveryDate Datetime2 not null,
	GoodsID int not null foreign key  references Goods(Id),
	SupliersID int not null foreign key references Supliers(Id)
	)