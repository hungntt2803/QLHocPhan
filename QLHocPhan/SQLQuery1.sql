create database QLHocphan
use QLHocPhan

create table ADMIN(
	Id int primary key,
	Username varchar(50),
	Password varchar(50),
	Name nvarchar(50),
	NgaySinh date,
	GioiTinh varchar(5),
	DiaChi nvarchar(500),
	SoDienThoai varchar(12),
	ChucVu varchar(10)
)
create table HOCVIEN(
	Id int primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh varchar(5),
	DiaChi nvarchar(500),
	SoDienThoai varchar(12)
)
create table HOCPHAN(
	Id int primary key,
	TenHocPhan nvarchar(100),
	MoTa nvarchar(500),
	NgayHocTrongTuan varchar(10),
	GioHoc varchar(10),
	NgayBatDau date,
	NgayKetThuc date,
	GioiHanHocVien int
)
create table HOCVIENHOCPHAN(
	Id int primary key,
	IdHocVien int,
	IdHocPhan int,
	TinhTrangHocPhi varchar(20)
)