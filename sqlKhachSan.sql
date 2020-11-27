use master
go
create database QuanLyKhachSan
go

use QuanLyKhachSan
go

create table ChucVu
(
maCV varchar(10) primary key,
tenCV nvarchar(100)
)
go

create table KhachHang
(
CMND varchar(13) primary key,
tenKH nvarchar(100),
diaChi nvarchar(100),
gioiTinh nvarchar(100),
SDT nvarchar(10),
quocTich nvarchar(20),
loai nvarchar(50)
)
go

create table NhanVien
(
maNV varchar(10) primary key,
tenNV nvarchar(100),
maCV varchar(10),
gioiTinh nvarchar(20),
ngSinh date,
ngVaoLam date,
diaChi nvarchar(100),
SDT nvarchar(10),
tenDN varchar(50),
pass varchar(50),
constraint ChucVu_NhanVien foreign key (maCV) references ChucVu(maCV)
)
go

create table LoaiPhong
(
maLoai varchar(10) primary key,
tenLP nvarchar(100),
gia money
)
go

create table Phong
(
soPhong varchar(10) primary key,
tinhTrang nvarchar(50),
maLoai varchar(10),
constraint phong_maLP foreign key (maLoai) references LoaiPhong(maLoai)
)
go

create table HoaDon
(
maHD varchar(10) primary key,
CMND varchar(13),
maNV varchar(10),
soPhong varchar(10),
ngayDat date,
ngayTra date,
tienThanhToan money,
constraint Hoadon_maNV foreign key (maNV) references NhanVien(maNV),
constraint Hoadon_maPhong foreign key (soPhong) references Phong(soPhong),
constraint Hoadon_CMND foreign key (CMND) references KhachHang(CMND)
)
go

create table PhieuDichVu
(
maDV varchar(10) primary key,
tenDV nvarchar(100),
giaDV money,
)
Go


create table PhieuDangKy
(
maDK varchar(10) primary key,
maDV varchar(10),
CMND varchar(13),
soPhong varchar(10),
soTienDatCoc money,
constraint Phieudangky_maPhong foreign key (soPhong) references Phong(soPhong),
constraint Phieudangky_maDV foreign key (maDV) references Phieudichvu(maDV),
constraint Phieudangky_maKH foreign key (CMND) references KhachHang(CMND)
)
Go

insert into ChucVu values
('CV01',N'Quản Lý'),
('CV02',N'Nhân Viên Lễ Tân'),
('CV03',N'Nhân Viên Phục Vụ'),
('CV04',N'Nhân Viên Phụ Bếp'),
('CV05',N'Nhân Viên Vệ Sinh')
Go


insert into KhachHang values
('031100004776',N'Vũ Thị Hải My',N'Hải Phòng',N'Nữ',N'0327567169',N'Việt Nam','VIP'),
('031300001766',N'Đoàn Hùng Mạnh',N'Hải Phòng',N'Nam',N'0523897581',N'Việt Nam','VIP'),
('001071000030',N'Trần Xuân Trường',N'Hà Nội',N'Nam',N'0865892941',N'Việt Nam','VIP'),
('001301250721',N'Võ Hạ Anh',N'Hà Nội',N'Nữ',N'0987123757',N'Việt Nam','VIP'),
('038108675763',N'Phạm Thị Thanh Lam',N'Thanh Hoá',N'Nữ',N'0962739160',N'Việt Nam','VIP'),
('030861008133',N'Vũ Thu Bích',N'Hải Dương',N'Nữ',N'0377798312',N'Việt Nam','VIP'),
('079090000555',N'Trần Minh Hùng',N'Hồ Chí Minh',N'Nam',N'0972532747',N'Việt Nam','VIP'),
('079976578122',N'Nguyễn Thế Anh',N'Hồ Chí Minh',N'Nam',N'0328890344',N'Việt Nam','VIP'),
('001987778913',N'Lương Quốc Anh',N'Hà Nội',N'Nam',N'0987114348',N'Việt Nam','VIP'),
('031300012468',N'Vũ Thu Hạnh',N'Hải Phòng',N'Nữ',N'0972403477',N'Việt Nam','VIP'),
('001100118903',N'Đoàn Châu Giang',N'Hà Nội',N'Nữ',N'0987139767',N'Việt Nam','VIP'),
('001009991234',N'Đoàn Mai Hương',N'Hà Nội',N'Nữ',N'0346218888',N'Việt Nam','VIP'),
('001019762789',N'Trần Hoàng Long',N'Hà Nội',N'Nam',N'0585288266',N'Việt Nam','VIP'),
('035978981117',N'Tạ Thị Hằng',N'Hà Nam',N'Nữ',N'0585909765',N'Việt Nam','VIP'),
('001000118903',N'Phạm Hồng Lam',N'Hà Nội',N'Nữ',N'0987139767',N'Việt Nam','VIP'),
('027800006789',N'Nguyễn Hương Giang',N'Bắc Ninh',N'Nữ',N'0987118867',N'Việt Nam','VIP'),
('054700027890',N'Phạm Nguyệt Minh',N'Phú Yên',N'Nữ',N'0972906651',N'Việt Nam','VIP'),
('079189760086',N'Hoàng Đàm Hoài Lâm',N'Hồ Chí Minh',N'Nam',N'0523678457',N'Việt Nam','VIP'),
('048987660986',N'Đặng Khắc Bình',N'Đà Nẵng',N'Nam',N'0346879670',N'Việt Nam','VIP'),
('072098980989',N'Vũ Thúy Nga',N'Tây Ninh',N'Nữ',N'0972980671',N'Việt Nam','VIP'),
('079098700789',N'Lưu Văn Hiếu',N'Hồ Chí Minh',N'Nam',N'0865087899',N'Việt Nam','VIP'),
('079300001898',N'Lưu Việt Anh',N'Hồ Chí Minh',N'Nam',N'0987906541',N'Việt Nam','VIP'),
('079389097812',N'Triệu Linh Hương',N'Hồ Chí Minh',N'Nữ',N'0328906781',N'Việt Nam','VIP'),
('026200789871',N'Phạm Tuấn Trang',N'Vĩnh Phúc',N'Nam',N'0377907568',N'Việt Nam','VIP'),
('056078907811',N'Đàm Thị Hạ',N'Khánh Hoà',N'Nữ',N'0332907335',N'Việt Nam','VIP')


set dateformat DMY
insert into NhanVien values
('NV001',N'Vũ Văn Quỳnh','CV01',N'Nam','30/1/1999','23/8/2018',N'TPHCM',N'0998566480','NV01','123'),
('NV002',N'Tạ Thị Ánh Linh','CV02',N'Nữ','23/12/1999','21/10/2018',N'NGHỆ AN',N'0942306493','NV02','123'),
('NV003',N'Đặng Nguyễn Việt','CV02',N'Nam','4/7/1998','21/10/2018',N'HÀ TĨNH',N'0961244769','NV03','123'),
('NV004',N'Hà Nguyễn Anh Tuấn','CV03',N'Nam','23/7/2000','17/12/2018',N'TPHCM',N'0933411089','NV04','123'),
('NV005',N'Trần Thị Tuyết Mai','CV04',N'Nữ','13/9/2000','3/1/2019',N'KIÊN GIANG',N'0934362290','NV05','123'),
('NV006',N'Hồ Văn Hoàng','CV03','Nam',N'29/8/2001','8/4/2019',N'CÀ MAU',N'0352118894','NV06','123'),
('NV007',N'Nguyễn Ngọc Đại','CV03',N'Nam','21/3/2002','23/7/2019',N'HẢI PHÒNG',N'0934556192','NV07','123'),
('NV008',N'Nguyễn Thị Mai Linh','CV02',N'Nữ','19/10/2002','25/3/2020',N'CẦN THƠ',N'0523167228','NV08','123'),
('NV009',N'Đỗ Đức Mạnh','CV04',N'Nam','19/9/2001','13/4/2020',N'ĐÀ NẴNG',N'0645596770','NV09','123'),
('NV010',N'Nguyễn Việt Tuấn','CV04',N'Nam','19/9/2001','8/4/2019',N'HÀ NỘI',N'0636119090','NV10','123'),
('NV011',N'Mai Chánh An','CV05',N'Nữ','21/6/2002','22/4/2020',N'HUẾ',N'0966371559','NV11','123'),
('NV012',N'Nguyễn Mai Anh Tú','CV05',N'Nam','21/4/2002','22/4/2020',N'TRÀ VINH',N'0936331450','NV12','123')
gO


insert into LoaiPhong  values
('LP01',N'PHÒNG 1 NGƯỜI','500000'),
('LP02',N'PHÒNG 1 NGƯỜI','700000'),
('LP03',N'PHÒNG 2 NGƯỜI','900000'),
('LP04',N'PHÒNG 2 NGƯỜI','1200000'),
('LP05',N'PHÒNG 4 NGƯỜI','1500000')

INSERT INTO Phong values
('MP01',N'Trống','LP01'),
('MP02',N'Trống','LP01'),
('MP03',N'Trống','LP02'),
('MP04',N'Trống','LP02'),
('MP05',N'Trống','LP03'),
('MP06',N'Trống','LP03'),
('MP07',N'Trống','LP03'),
('MP08',N'Trống','LP04'),
('MP09',N'Trống','LP04'),
('MP10',N'Trống','LP05'),
('MP11',N'Trống','LP05')
go

insert into PhieuDichVu values
('DV01',N'Trọn gói ăn uống trong tuần tự phục vụ','300000'),
('DV02',N'Trọn gói ăn uống trong tuần được phục vụ','350000'),
('DV03',N'Trọn gói ăn uống,Gói phục vụ và gửi xe miễn phí','400000'),
('DV04',N'Trọn gói ăn uống tự chọn ,Gói phục vụ và miễn phí giữ xe','600000')
Go

INSERT INTO PhieuDangKy values
('PDK01','DV01','031100004776','MP01','200000'),
('PDK02','DV02','001000118903','MP02','200000'),
('PDK03','DV01','030861008133','MP03','300000'),
('PDK04','DV02','072098980989','MP04','300000'),
('PDK05','DV02','031300001766','MP05','400000'),
('PDK06','DV03','056078907811','MP06','400000'),
('PDK07','DV04','072098980989','MP07','500000'),
('PDK08','DV03','001071000030','MP08','500000'),
('PDK09','DV04','001000118903','MP09','700000'),
('PDK10','DV04','079098700789','MP10','700000')
Go

INSERT INTO HoaDon values
('HD01','031100004776','NV001','MP01','10/10/2020','13/10/2020','700000'),
('HD02','001000118903','NV002','MP02','10/10/2020','14/10/2020','700000'),
('HD03','030861008133','NV003','MP03','10/10/2020','15/10/2020','1000000'),
('HD04','072098980989','NV004','MP04','10/10/2020','20/10/2020','1050000'),
('HD05','031300001766','NV005','MP05','10/10/2020','21/10/2020','1250000'),
('HD06','056078907811','NV006','MP06','10/10/2020','22/10/2020','1300000'),
('HD07','072098980989','NV007','MP07','10/10/2020','23/10/2020','1500000'),
('HD08','001071000030','NV008','MP08','10/10/2020','7/11/2020','1600000'),
('HD09','001000118903','NV009','MP09','10/10/2020','15/11/2020','1800000'),
('HD10','079098700789','NV010','MP10','10/10/2020','20/11/2020','2100000')
Go