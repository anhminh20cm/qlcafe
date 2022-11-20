create database qlqcafe
go

use qlqcafe
go

-- bảng đồ uống
-- bảng bàn
-- bảng loại
-- bảng đăng nhập
-- bảng hóa đơn
-- bảng hóa đơn chi tiết

create table account
(
	tendangnhap nvarchar(50)primary key not null,
	tenhienthi nvarchar(100) not null,
	mk nvarchar(1000) not null,
	loai int not null
)

go
create table tablefood
(
	id int identity primary key,
	ten nvarchar(100) not null,
	trangthai nvarchar(100) not null,

)
go
create table drinksCategory
(
	id int identity primary key,
	ten nvarchar(100) not null
)
go
create table drinks
(
	id int identity primary key,
	ten nvarchar(100) not null default N'chưa đặt tên',
	idCategory int not null,
	gia float not null default 0,--giá ban đầu là 0
	foreign key (idCategory) references drinksCategory(id)
)
go
create table bill
(
	id int identity primary key,
	idTable int not null,
	trangthai int not null default 0,
	checkin date not null default getdate(),--check in mặc định ngày hiện tại
	checkout date not null,
	foreign key (idTable) references tablefood(id)

)
go
create table billInfore
(
	id int identity primary key,
	idBill int not null,
	idDrinks int not null,
	foreign key (idBill) references bill(id),
	foreign key (idDrinks) references drinks(id)
)
