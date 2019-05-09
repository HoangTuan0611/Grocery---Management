create database DataQLTH
use DataQLTH

create table tblDangNhap
(
	TenDangNhap nchar(20) primary key not null,
	MatKhau nchar(50) not null,
)

create table tblHang
(
	MaHang varchar(10) primary key not null,
	TenHang nvarchar(50),
	DonGiaHang bigint,
	NhaSX nvarchar(50),
	MoTa nvarchar(50),
)

create table tblKhachHang
(
	MaKH varchar(10) primary key not null,
	TenKH nvarchar(40),
	DiaChi nvarchar(80),
	DienThoai nvarchar(15),
)

create table tblNhanVien
(
	MaNV varchar(10) primary key not null,
	TenNV nvarchar(40),
	DiaChi nvarchar(80),
	DienThoai nvarchar(15),
)

create table tblHoaDon
(
	MaHD varchar(10) primary key not null,
	MaKH varchar(10) Foreign key references tblKhachHang,
	MaNV varchar(10) Foreign key references tblNhanVien,
	Ngaylap varchar(80),
)


create table tbl_RPCTHD
(
	MaHD varchar(10)  not null Foreign key references tblHoaDon,
	MaHang varchar(10) not null Foreign key references tblHang,
	SoLuongMua int,
	DonGiaBan bigint,
	ThanhTien bigint,
	constraint khoachinh primary key (MaHD, MaHang),
)

create table tblCTHD
(
	MaHD varchar(10) not null Foreign key references tblHoaDon,
	MaHang varchar(10) not null Foreign key references tblHang,
	SoLuongMua int,
	DonGiaBan bigint,
	ThanhTien bigint,
	constraint khoachinh1 primary key (MaHD, MaHang),
)

insert into tblDangNhap values('hoangtuan','hoangtuan')

create procedure  tblDangNhap_Login as 
 insert into tblDangNhap values('hoangtuan','hoangtuan')

 exec tblDangNhap_Login

drop procedure tblDangNhap_Login

create proc tblDangNhap_Login
@TenDangNhap nchar(20),
@MatKhau nchar(50)
as
SELECT *
  FROM tblDangNhap
	where @TenDangNhap = TenDangNhap
			and @MatKhau = MatKhau