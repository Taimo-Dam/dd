create database QLSV
use QLSV

create table Sinhvien (
	MaSo int,
	HoTen nvarchar(100),
	NgaySinh date,
	GioiTinh nvarchar(50),
	MaKhoa int,
	MaMH int,
	Diachi nvarchar(100),
	Dienthoai varchar(20)
)

create table Monhoc(
	MaMH int,
	TenMH nvarchar(50),
	SoTiet int,
)

create table Khoa(
	MaKhoa int,
	TenKhoa nvarchar(50),
)

create table Taikhoan(
	Tendangnhap char(50),
	Matkhau char(50)
)

insert into Taikhoan (Tendangnhap, Matkhau)
values 
	('admin1', 'admin1'),
	('test', 'test'),
	('admin2', 'admin2')

insert into Sinhvien (MaSo, HoTen, NgaySinh, GioiTinh, MaKhoa, MaMH, Diachi, Dienthoai)
values
	(110, 'Phong', '1/1/2005', 'Nam', '1', '001', N'Quy Nhơn', '123456789'),
	(111, 'Lai', '1/2/2005', 'Nam', '1', '001', N'Phú Yên', '123456788'),
	(112, 'Huy', '1/3/2005', 'Nam', '2', '002', N'Gia Lai', '123456787'),
	(113, N'Tâm', '1/4/2005', 'Nam', '2', '002', N'Quy Nhơn', '123456786'),
	(114, 'Vinh', '1/5/2005', 'Nam', '3', '003', N'Quy Nhơn', '123456785')
drop table Sinhvien; 
insert into Khoa (MaKhoa, TenKhoa)
values
	(1, 'CNTT'),
	(2, 'TTNT'),
	(3, N'Sư Phạm')

insert into Monhoc (MaMH, TenMH, SoTiet)
values
	('001', N'Toán', 3),
	('002', N'Triết', 3),
	('003', N'Giáo dục thể chất' , 2)