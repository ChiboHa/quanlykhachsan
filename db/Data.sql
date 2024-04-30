CREATE DATABASE QL_KhachSan;
GO

USE QL_KhachSan
GO

-- Account
CREATE TABLE Account
(
	ID VARCHAR(10) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'User',
	UserName NVARCHAR(100),
	PassWord NVARCHAR(128) NOT NULL,
	Role VARCHAR(10) NOT NULL DEFAULT 'USER',
	email VARCHAR(100) NOT NULL
)

GO

CREATE TABLE Customer
(
	ID VARCHAR(10) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	CCCD VARCHAR(12) NOT NULL,
)
	
-- Nhan vien
CREATE TABLE NhanVien
(
    ID VARCHAR(10) PRIMARY KEY,
    ho NVARCHAR(50) NOT NULL,
    ten NVARCHAR(50) NOT NULL,
    gioiTinh NVARCHAR(10),
    ngaySinh DATE,
    CCCD VARCHAR(12) NOT NULL,
    email VARCHAR(100),
    maSoThue VARCHAR(20),
    soDienThoai VARCHAR(15),
    luong1h DECIMAL(18, 2), -- Luong 1 gio, su dung kieu DECIMAL cho chinh xac den sau dau , 2 so
    image VARBINARY(MAX),
    role NVARCHAR(100) NOT NULL DEFAULT 'Nhân viên'
)

GO

-- Bang luong thang nhan vien
CREATE TABLE Luong
(
    ID INT PRIMARY KEY IDENTITY,
    ID_nv VARCHAR(10), -- khoa ngoai tham chieu den bang NhanVien
    CONSTRAINT FK_NhanVien FOREIGN KEY (ID_nv) REFERENCES NhanVien(ID),
    time DATE,
    soGioLam DECIMAL(18, 2), -- So gio lam trong thang
    thanhTien DECIMAL(18, 2) -- Tong luong thang
)

GO

-- Bang luong tong
use QL_KhachSan;
GO

CREATE TABLE TongLuong (
    ID INT PRIMARY KEY IDENTITY,
    Thang INT,
    Nam INT,
    Ten NVARCHAR(100), -- Tên c?a b?ng TongLuong
    TongLuong DECIMAL(18, 2)
);


USE QL_KhachSan;
GO

CREATE TABLE Food
(
	ID int identity PRIMARY KEY,
	Ten NVARCHAR(100) NOT NULL,
	Muc VARCHAR(20) NOT NULL DEFAULT 'Food',
	Gia INT NOT NULL
)

GO
use QL_KhachSan
go


CREATE TABLE BillFood (
  ID INT identity PRIMARY KEY,
  idkh [varchar](10) NOT NULL,
  transdate DATE NOT NULL,
  transmonth VARCHAR(100) NOT NULL,
  GrandToTal int not null,
  trangthai varchar(10) not null default 'NO',
  CONSTRAINT FK_Bill_Customer FOREIGN KEY (IDKH) REFERENCES Customer (ID)
);
Go


CREATE TABLE Pos (
  ID INT identity PRIMARY KEY,
  BillID int not null,
  foodcode INT NOT NULL,
  foodname NVARCHAR(100) NOT NULL,
  cost int NOT NULL,
  qty INT NOT NULL,
  totalprice int NOT NULL,
  CONSTRAINT FK_Pos_Food Foreign key (foodcode) references Food(ID),
  CONSTRAINT FK_Pos_BillFood Foreign key (BillID) references BillFood(ID)

);
Go 

create table Rooms
(
	id int primary key identity (1,1),
	roomNo nvarchar(250) not null unique,
	roomType nvarchar(250) not null,
	bedType nvarchar(250) not null,
	price int not null,
	booked varchar(10) default 'NO'
)
GO

-- Bang hoa don phong
Create table BillRoom
(
	ID int identity (1,1) primary key,
	room_ID int not null,
    	customer_id varchar(10) not null,
    	date_check_in DATE,
    	date_check_out DATE,
    	status int not null,
        GrandTotal INT DEFAULT 0,
    	FOREIGN KEY (room_ID) REFERENCES Rooms(id),
    	FOREIGN KEY (customer_id) REFERENCES Customer(ID)
)
Go

