﻿
USE QL_KhachSan
GO

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

-- Ban ghi mau
/*
USE [QL_KhachSan]
GO

INSERT INTO [dbo].[NhanVien] ([ID], [ho], [ten], [gioiTinh], [ngaySinh], [CCCD], [email], [maSoThue], [soDienThoai], [luong1h], [role])
VALUES 
    ('NV001', N'Nguyễn', N'Văn A', 'Nam', '1990-01-01', '123456789012', 'nv_a@example.com', '1234567890', '0123456789', 35000, N'Nhân viên'),
    ('NV002', N'Nguyễn', N'Thị B', 'Nữ', '1995-06-03', '234567890123', 'nv_b@example.com', '2345678901', '1234567890', 35000, N'Nhân viên'),
    ('BV001', N'Phạm', N'Bảo Vệ','Nam', '1991-05-01', '345678901234', 'bao_ve@example.com', '3456789012', '2345678901', 30000, N'Bảo vệ'),
    ('KT001', N'Lý', N'Kế Toán', 'Nữ','1995-09-05', '456789012345', 'ke_toan@example.com', '4567890123', '3456789012', 45000, N'Kế toán'),
    ('GD001', N'Phùng', N'Giám Đốc','Nam','1999-05-05', '567890123456', 'giam_doc@example.com', '5678901234', '4567890123', 80000, N'Giám đốc');
GO
*/

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
CREATE TABLE TongLuong
(
    ID INT PRIMARY KEY IDENTITY,
    ten NVARCHAR(100) NOT NULL,
    ID_LuongThangNhanVien INT, -- Khoa ngoai tham chieu den bang Luong
    CONSTRAINT FK_Luong FOREIGN KEY (ID_LuongThangNhanVien) REFERENCES Luong(ID),
    time DATE,
    tongLuong DECIMAL(18, 2)
)
GO

