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

-- Khach Hang
CREATE TABLE Customer
(
	ID VARCHAR(10) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	phoneNumber VARCHAR(10),
	CCCD VARCHAR(12) NOT NULL,
	point INT NOT NULL DEFAULT '0'
)


-- them khach hang
INSERT INTO Customer (ID, name, phoneNumber, CCCD, point)
VALUES ('001','Long', '0987654321', '0272', '0'),
		('002','Chau','0123456789','0324','1');


	
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

USE [QL_KhachSan]
GO

INSERT INTO [dbo].[NhanVien] ([ID], [ho], [ten], [gioiTinh], [ngaySinh], [CCCD], [email], [maSoThue], [soDienThoai], [luong1h], [role])
VALUES 
    ('NV001', N'Nguyễn', N'Văn A', N'Nam', '1990-01-01', '123456789012', 'nv_a@example.com', '1234567890', '0123456789', 35000, N'Nhân viên'),
    ('NV002', N'Nguyễn', N'Thị B', N'Nữ', '1995-06-03', '234567890123', 'nv_b@example.com', '2345678901', '1234567890', 35000, N'Nhân viên'),
    ('BV001', N'Phạm', N'Bảo Vệ',N'Nam', '1991-05-01', '345678901234', 'bao_ve@example.com', '3456789012', '2345678901', 30000, N'Bảo vệ'),
    ('KT001', N'Lý', N'Kế Toán', N'Nữ','1995-09-05', '456789012345', 'ke_toan@example.com', '4567890123', '3456789012', 45000, N'Kế toán'),
    ('GD001', N'Phùng', N'Giám Đốc',N'Nam','1999-05-05', '567890123456', 'giam_doc@example.com', '5678901234', '4567890123', 80000, N'Giám đốc');
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
  status varchar(10) not null default 'NO',
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
    	date_check_in DATETIME2 DEFAULT CURRENT_TIMESTAMP not null,
    	date_check_out DATETIME2,
    	status BIT DEFAULT '0' NOT NULL,
    	FOREIGN KEY (room_ID) REFERENCES Rooms(id),
    	FOREIGN KEY (customer_id) REFERENCES Customer(ID)
)
Go

INSERT INTO BillRoom (room_ID, customer_id, status)
VALUES (
    	(SELECT id FROM Rooms WHERE roomNo = '101'),'001','0');
GO


INSERT INTO Rooms (roomNo, roomType, bedType, price, booked)
VALUES 
    (101, N'Phòng thường', N'Giường đơn', 5000, 'YES'),
    (102, N'Phòng thường', N'Giường đôi', 7000, 'YES'),
    (103, N'Phòng thường', N'Giường đơn', 10000, 'NO'),
    (104, N'Phòng VIP', N'Giường đôi', 15000, 'YES');
GO



INSERT INTO BillRoom ((SELECT  RoomNo from Rooms where id = room_ID), customer_id, status)
VALUES (101, '001', 1),
		( 103, '002', 0);

-- Bang phong


