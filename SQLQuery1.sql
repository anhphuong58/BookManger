create database QL_Ban_Sach
go
use QL_Ban_Sach
go
create table NXB(
	Ma_NXB nvarchar(20) not null constraint key_nxb primary key,
	Ten_NXB nvarchar(50) not null,
	DiaChi_NXB nvarchar(50) ,
	SDT_NXB varchar(11)
)


create table THELOAI(
	Ma_TL nvarchar(20) not null constraint key_tl primary key,
	Ten_TL nvarchar(50) not null,
	ViTri nvarchar(50) 
)

create table SACH(
	Ma_S nvarchar(20) not null constraint key_s primary key,
	Ten_S nvarchar(50) not null,
	Ma_NXB nvarchar(20) not null,
	Ma_TL nvarchar(20) not null,
	Gia float,
	TinhTrang BIT,
	SoLuong int constraint dk_tong check (SoLuong >= 0 ),
	imgPath nvarchar(200),
	constraint fk_s
				foreign key(Ma_NXB)
				references NXB(Ma_NXB)
				on update cascade,
	constraint fk_s1
				foreign key(Ma_TL)
				references THELOAI(Ma_TL)
				on update cascade
)
	

create table PHIEUNHAP(
	So_PN int not null constraint  key_PN primary key,
	Ma_NXB nvarchar(20) not null,
	NgayNhap datetime not null,
	TongTien float not null,
	constraint fkPN1_S
			foreign key(Ma_NXB)
			references NXB(Ma_NXB)
			
	)


create table CHITIETPHIEUNHAP(
	Ma_S nvarchar(20) not null,
	So_PN int not null , 
	SoLuongNhap int not null,
	GiaNhap float not null,
	constraint key_CTPN primary key(Ma_S, So_PN),
	constraint fk_CTPN1 
				foreign key(Ma_S)
				references SACH(Ma_S),
	constraint fk_CTPN2
				foreign key(So_PN)
				references PHIEUNHAP(So_PN)

)

create table QUANLINHANVIEN(
	Ma_NV nvarchar(20) not null constraint key_QLNV primary key,
	Ten_NV nvarchar(50) not null,
	SoCMND nvarchar(20) not null,
	DiaChi nvarchar(50) not null,
	Email nvarchar(50), 
	SDT varchar(11),
	MatKhau nvarchar(6),
	NgayBatDau datetime,
	ChucVu nvarchar(50),
	Luong float,
	QuyenTaoPhieuNhap BIT default 0,
	QuyenQuanTriNhanVien BIT default 0
)

create table KHACHHANG(
	Ma_KH nvarchar(20) not null constraint key_kh primary key,
	Ten_KH nvarchar(50) not null,
	Email nvarchar(50), 
	DiaChi nvarchar(50),
	SDT_KH varchar(11)
)

create table HOADON(
	Ma_HD nvarchar(20) not  null constraint key_cthd primary key,
	Ma_KH nvarchar(20) not null,
	Ma_S nvarchar(20) ,
	NgayBan datetime,
	TongTien float ,
	Ma_NV nvarchar(20) not null,
	constraint fkhd_HD
			foreign key(Ma_HD)
			references HOADON(Ma_HD),
	constraint fkhd_S
			foreign key(Ma_S)
			references SACH(Ma_S),
	constraint fkhd_kh
		foreign key(Ma_KH)
		references KHACHHANG(Ma_KH)	,
	constraint fkhd_nv
			foreign key(Ma_NV)
			references QUANLINHANVIEN(Ma_NV)
)

create table CHITIETHOADON(
	Ma_HD nvarchar(20) not null,
	Ma_S nvarchar(20) not null,
	Ten_S nvarchar(50) not null,
	DonGia float,
	SoLuong int,
	primary key(Ma_HD, Ma_S),
	foreign key(Ma_S) references SACH(Ma_S),
	foreign key(Ma_HD) references HOADON(Ma_HD),
)
INSERT INTO QUANLINHANVIEN(Ma_NV , Ten_NV , SoCMND, DiaChi, Email, SDT, MatKhau, NgayBatDau, ChucVu, Luong, QuyenTaoPhieuNhap, QuyenQuanTriNhanVien)
VALUES ('Admin', 'Admin', 000000000, 'Đà Nẵng','','',123456,01-01-2015,'',0, 1, 1);
INSERT INTO KHACHHANG(Ma_KH , Ten_KH , Email, DiaChi, SDT_KH)
VALUES ('NoName', 'Khách hàng không tên', NULL, NULL, NULL);
