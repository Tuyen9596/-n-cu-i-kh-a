﻿CREATE DATABASE QLNS
GO
USE QLNS

DROP TABLE NHANVIEN
DROP TABLE LUONG
DROP TABLE CHUCVU

CREATE TABLE NHANVIEN (
	MANV NCHAR(30) PRIMARY KEY,
	HOTEN NVARCHAR(70),
	NGAYSINH SMALLDATETIME,
	GIOITINH NCHAR (4),
	QUEQUAN NVARCHAR (200),
	SDT NCHAR (15),	
	MAPB NCHAR(30),
	MACV NCHAR(30),
	MALUONG NCHAR(30),
	 -- KHÓA NGOẠI ---
	 FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
	 FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV),
	 FOREIGN KEY(MALUONG) REFERENCES LUONG(MALUONG)

)
GO

CREATE TABLE CHUCVU(
 MACV NCHAR(30) PRIMARY KEY,
 TENCV NVARCHAR(100)
)
GO

CREATE TABLE PHONGBAN(
	MAPB NCHAR(30) PRIMARY KEY,
	TENPB NVARCHAR(100),
	SDTPB NCHAR(15)
)
GO

CREATE TABLE LUONG(
	MALUONG NCHAR(30) PRIMARY KEY,
	TENLUONG NCHAR(100),
	LUONGCB FLOAT,
	HSLUONG FLOAT
)
GO

create table TAIKHOAN(
	MATK nchar(30) primary key,
	TK nchar(30),
	MK nchar(30),
	MAQUYEN nchar(30)	,
	FOREIGN KEY(MAQUYEN) REFERENCES QUYEN(MAQUYEN)
)
go

create table QUYEN(
	MAQUYEN nchar(30) primary key,
	TENQUYEN nchar(100)
)
go

insert into PHONGBAN values ('NS',N'Nhân sự','000001')
insert into PHONGBAN values ('KD',N'Kinh doanh','000002')
insert into PHONGBAN values ('KTH',N'Kĩ thuật','000003')
insert into PHONGBAN values ('KT',N'Kế toán','000004')

insert into CHUCVU values ('TT',N'Thực tập')
insert into CHUCVU values ('NV',N'Nhân viên')
insert into CHUCVU values ('QL',N'Quản lí')

insert into LUONG values ('TT',N'Thực tập',1000000,1)
insert into LUONG values ('NV',N'Nhân viên',3000000,1.2)
insert into LUONG values ('QL',N'Quản lí',5000000,1.5)

select * from NHANVIEN
select * from CHUCVU
select * from LUONG
select * from PHONGBAN