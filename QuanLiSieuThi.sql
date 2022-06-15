create database QuanLySieuThi
go
use QuanLySieuThi

go

create table KhachHang
(
	maKH varchar(10) not null primary key,
	tenKH nvarchar(30) null,
	diaChiKH nvarchar(50) null,
	SDT nvarchar(10) null,
	Email nvarchar(30) null
)

go
create table NhanVien
(
	maNV varchar(10) not null primary key,
	tenNV nvarchar(30) null,
	SDT nvarchar(10) null,
	email nvarchar(30) null,
	chucVu nvarchar(50),
	luong money null
)

go
-- Bảng Sản phẩm
create table SanPham
(
	maSP varchar(10) not null primary key,
	tenSP nvarchar(15) null,
	donGiaBan money null,
	soLuongCon int null
)

go
create table HoaDon
(
	maHD int identity(1,1) not null primary key,
	ngayTaoHD Date null,
	maNV varchar(10),
	maKH varchar(10) not null,
	foreign key (maKH) references  KhachHang(maKH)
		on delete 
			cascade
		on update
			cascade,
	foreign key (maNV) references  NhanVien(maNV)
		on delete 
			cascade
		on update
			cascade
)

go
create table ChiTietHoaDon
(
	maHD int not null
	foreign key (maHD) references  HoaDon(maHD)
		on delete 
			cascade
		on update
			cascade,
	maSP varchar(10) not null
	foreign key (maSP) references  SanPham(maSP)
		on delete 
			cascade
		on update
			cascade,
	soLuongDat int null,
	primary key (maHD, maSP)
)

go
create table PhieuNhap
(
	maPN varchar(10) not null primary key,
	ngayNhapHang date null
)
go
-- Bảng Chi tiết phiếu nhâp --
create table ChiTietPhieuNhap
(
	maPN varchar(10) not null
	foreign key (maPN) references  PhieuNhap(maPN)
		on delete 
			cascade
		on update
			cascade,
	maSP varchar(10) not null
	foreign key (maSP) references  SanPham(maSP)
		on delete 
			cascade
		on update
			cascade,
	soLuongNhap int null,
	donGiaNhap money null,
	primary key (maPN, maSP)
)


--
go
alter table ChiTietPhieuNhap
	add constraint CK_ChiTietPhieuNhap_soLuongNhap check (
			soLuongNhap >= 0),
		constraint CK_ChiTietPhieuNhap_donGiaNhap check (
			donGiaNhap >= 0)
alter table ChiTietHoaDon
	add constraint CK_ChiTietDonHang_soLuongDat check (
			soLuongDat >= 0)

alter table SanPham
	add constraint CK_SanPham_donGiaBan check (
			donGiaBan >= 0)

--
go
insert into KhachHang
values  
	('KH0001',N'Trần Kim Vũ',N'Quảng Nam','0905374625','vudeptrai@gmail.com'),
	('KH0002',N'Nguyễn Trần Tiến',N'Quảng Nam','0332052897','tienGay@gmail.com'),
	('KH0003',N'Hà Phước Kỳ',N'Đà Nẵng','0904677123','Kydb@gmail.com'),
	('KH0004',N'Bùi Viết Trường',N'Đà Nẵng','0946436123','truongNgu@gmail.com')

go
insert into NhanVien
values 
	('NV0001',N'Bùi Huyền Trang','0964265321','trangbui@gmail.com',N'Thu ngân','6470000'),
	('NV0002',N'Nguyễn Quang Minh','0126478821','minhnguy@gmail.com',N'Bán hàng','870000'),
	('NV0003',N'Nguyễn Minh Anh','0247586963','anhcute@gmail.com',N'Bán hàng','779000'),
	('NV0004',N'Nguyễn Thị Kiều Diễm','0265865883','kdiem90@gmail.com',N'Thu ngân','163000'),
	('NV0005',N'Nguyễn Thanh Hằng','0913646321','hangnguy@gmail.com',N'Bán hàng','933000'),
	('NV0006',N'Phạm Thảo Anh','0896235321','ptanh@gmail.com',N'Thu ngân','215300')

go
insert into SanPham
values
	('SP0001',N'Sữa','7000','1000'),
	('SP0002',N'Đường','5000','1500'),
	('SP0003',N'Giày','1000000','50'),
	('SP0004',N'Kẹo','1500','10000'),
	('SP0005',N'Osi','6000','15000'),
	('SP0006',N'Dầu Ăn','30000','1000'),
	('SP0007',N'Thuốc lá','15000','1500'),
	('SP0008',N'Mỳ Tôm','3500','35000'),
	('SP0009',N'Túi Nhựa','1000','100000'),
	('SP0010',N'Cafe','11000','1000'),
	('SP0011',N'Sách','50000','200')

go
insert into PhieuNhap
values
	('PN0001','2021-7-12'),
	('PN0002','2021-5-12'),
	('PN0003','2021-10-13'),
	('PN0004','2021-3-14'),
	('PN0005','2021-1-15')

go
insert into ChiTietPhieuNhap
values
	('PN0001','SP0001','100','3000'),
	('PN0001','SP0002','100','2000'),
	('PN0002','SP0003','20','1200000'),
	('PN0003','SP0011','50','20000'),
	('PN0004','SP0001','150','3000'),
	('PN0005','SP0005','150','2500'),
	('PN0005','SP0004','300','500')

insert into HoaDon
values
	('1-8-2021','NV0001','KH0001'),
	('2-5-2021','NV0001','KH0002'),
	('3-1-2021','NV0003','KH0004')

go
insert into ChiTietHoaDon
values	
	(1,'2',1000),
	(1,'3',100),
	(1,'1',100),
	(2,'5',1000),
	(2,'7',100),
	(2,'8',100),
	(3,'9',1000),
	(3,'4',100),
	(3,'5',100)

SELECT dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
where dbo.HoaDon.maHD = '1'
GROUP BY dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan

	select HoaDon.maHD, HoaDon.ngayTaoHD ,KhachHang.tenKH, SanPham.tenSP, ChiTietHoaDon.soLuongDat,1 from ChiTietHoaDon
	INNER JOIN HoaDon ON ChiTietHoaDon.maHD = HoaDon.maHD
	INNER JOIN SanPham ON SanPham.maSP = ChiTietHoaDon.maSP
	INNER JOIN KhachHang ON KhachHang.maKH = HoaDon.maKH
	where HoaDon.maHD = 1;

SELECT dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, sum(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan)
FROM     dbo.HoaDon INNER JOIN
				dbo.ChiTietHoaDon ON dbo.HoaDon.maHD = dbo.ChiTietHoaDon.maHD INNER JOIN
				dbo.SanPham ON dbo.SanPham.maSP = dbo.ChiTietHoaDon.maSP INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV

SELECT dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, SUM(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan) AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, 

/*
SELECT dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
where dbo.HoaDon.maHD = '2'
GROUP BY dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan
*/

SELECT * 
From SanPham 
WHERE tenSP like '%sua%'

SELECT * 
From SanPham 
WHERE contains(tenSP,'sua')

SELECT * From SanPham WHERE CONCAT(maSP, tenSP) like '%sua%'

SELECT SERVERPROPERTY('IsFullTextInstalled')

