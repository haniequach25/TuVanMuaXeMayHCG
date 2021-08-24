use master
go
create database TuVanXeMay
go
use TuVanXeMay
go
create table GiaTien(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
create table Hang(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
create table LoaiXe(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
--create table DungTich(
--	Code varchar(3) primary key not null,
--	Name nvarchar(50) not null
--)
create table DoiTuong(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
create table KieuDang(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
create table DacDiem(
	Code varchar(3) primary key not null,
	Name nvarchar(50) not null
)
create table Luat(
	Code int primary key not null IDENTITY(1,1),
	RLeft nvarchar(50) not null,
	RRight nvarchar(50) not null
)
create table Xe(
	Code varchar(5) primary key not null,
	Name nvarchar(50) not null,
	Brand nvarchar(50) not null,
	Price int not null,
	Type nvarchar(50) not null,
	Capacity varchar(6) not null
)
go
insert into GiaTien values('A01' , N'Giá <=20tr')
insert into GiaTien values('A02' , N'20tr < Giá <= 30tr')
insert into GiaTien values('A03' , N'30tr < Giá <= 50tr')
insert into GiaTien values('A04' , N'Giá > 50tr')

insert into Hang values('B01' , 'HONDA')
insert into Hang values('B02' , 'SUZUKI')
insert into Hang values('B03' , 'SYM')
insert into Hang values('B04' , 'YAMAHA')

insert into LoaiXe values('C01' , N'Xe tay ga')
insert into LoaiXe values('C02' , N'Xe tay côn')
insert into LoaiXe values('C03' , N'Xe số')

--insert into DungTich values('D01' , '97cc')
--insert into DungTich values('D02' , '108cc')
--insert into DungTich values('D03' , '110cc')
--insert into DungTich values('D04' , '113cc')
--insert into DungTich values('D05' , '114cc')
--insert into DungTich values('D06' , '115cc')
--insert into DungTich values('D07' , '125cc')
--insert into DungTich values('D08' , '135cc')
--insert into DungTich values('D09' , '150cc')

insert into DoiTuong values('E01', N'Sinh viên')
insert into DoiTuong values('E02', N'Nhân viên')
insert into DoiTuong values('E03', N'Doanh nhân')

insert into KieuDang values('F01', N'Đơn giản')
insert into KieuDang values('F02', N'Mạnh mẽ')

insert into DacDiem values('G01', N'Khỏe')
insert into DacDiem values('G02', N'Cân bằng')
insert into DacDiem values('G03', N'Tiết kiệm nhiên liệu')

insert into Xe values('KL01' , N'Wave Alpha' , 'Honda' , 16900000 , N'xe số', '97cc')
insert into Xe values('KL02' , N'REVO 110' , 'Suzuki' , 17690000 , N'xe số', '110cc')
insert into Xe values('KL03' , N'Galaxy 110' , 'SYM' , 15500000  , N'xe số', '108cc')
insert into Xe values('KL04' , N'Sirius 2014' , 'Yamaha' , 18100000 , N'xe số', '110cc')
insert into Xe values('KL05' , N'Furute' , 'Honda' ,  25500000 , N'xe số', '125cc')
insert into Xe values('KL06' , N'Blade' , 'Honda' , 20500000 , N'xe số', '110cc')
insert into Xe values('KL07' , N'Viva' , 'Suzuki' , 23000000 , N'xe số', '115cc')
insert into Xe values('KL08' , N'Jupiter' , 'Yamaha' , 28900000 , N'xe số', '114cc')
insert into Xe values('KL09' , N'Version' , 'Honda' , 29900000 , N'xe tay ga', '108cc')
insert into Xe values('KL10' , N'Hayate' , 'Suzuki' , 26400000 , N'xe tay ga', '125cc')
insert into Xe values('KL11' , N'Victoria' , 'SYM' , 26500000 , N'xe tay ga', '125cc')
insert into Xe values('KL12' , N'Luvias' , 'Yamaha' , 27900000 , N'xe tay ga', '125cc')
insert into Xe values('KL13' , N'Nozza' , 'Yamaha' , 28900000 , N'xe tay ga', '113cc')
insert into Xe values('KL14' , N'AXELO' , 'Suzuki' , 26500000 , N'xe tay côn', '125cc')
insert into Xe values('KL15' , N'Air Blade' , 'Honda' , 38000000 , N'xe tay ga', '125cc')
insert into Xe values('KL16' , N'IMPLUSE' , 'Suzuki' , 30200000 , N'xe tay ga', '125cc')
insert into Xe values('KL17' , N'Elizabeth' , 'SYM' , 31000000 , N'xe tay ga', '125cc')
insert into Xe values('KL18' , N'Shark' , 'SYM' , 46000000 , N'xe tay ga', '135cc')
insert into Xe values('KL19' , N'Nouvo 2015' , 'Yamaha' , 34600000 , N'xe tay ga', '125cc')
insert into Xe values('KL20' , N'Raider' , 'Suzuki' , 47000000 , N'xe tay côn', '150cc')
insert into Xe values('KL21' , N'Exciter 2015' , 'Yamaha' , 45000000 , N'xe tay côn', '150cc')
insert into Xe values('KL22' , N'SH 125' , 'Honda' , 65900000 , N'xe tay ga', '125cc')
insert into Xe values('KL23' , N'SH 150' , 'Honda' , 79900000 , N'xe tay ga', '150cc')
insert into Xe values('KL24' , N'MSX' , 'Honda' , 60000000 , N'xe tay côn', '125cc')


--insert into Luat values('A01^B01^C03^D01',	'KL01')
--insert into Luat values('A01^B02^C03^D03',	'KL02')
--insert into Luat values('A01^B03^C03^D02',	'KL03')
--insert into Luat values('A01^B04^C03^D03',	'KL04')
--insert into Luat values('A02^B01^C03^D07',	'KL05')
--insert into Luat values('A02^B01^C03^D03',	'KL06')
--insert into Luat values('A02^B02^C03^D06',	'KL07')
--insert into Luat values('A02^B04^C03^D05',	'KL08')
--insert into Luat values('A02^B01^C01^D02',	'KL09')
--insert into Luat values('A02^B02^C01^D07',	'KL10')
--insert into Luat values('A02^B03^C01^D07',	'KL11')
--insert into Luat values('A02^B04^C01^D07',	'KL12')
--insert into Luat values('A02^B04^C01^D04',	'KL13')
--insert into Luat values('A02^B02^C02^D07',	'KL14')
--insert into Luat values('A03^B01^C01^D07',	'KL15')
--insert into Luat values('A03^B02^C01^D07',	'KL16')
--insert into Luat values('A03^B03^C01^D07',	'KL17')
--insert into Luat values('A03^B03^C01^D08',	'KL18')
--insert into Luat values('A03^B04^C01^D07',	'KL19')
--insert into Luat values('A03^B02^C02^D09',	'KL20')
--insert into Luat values('A03^B04^C02^D09',	'KL21')
--insert into Luat values('A04^B01^C01^D07',	'KL22')
--insert into Luat values('A04^B01^C01^D09',	'KL23')
--insert into Luat values('A04^B01^C02^D07',	'KL24')
insert into Luat values('A01^B01^C03',	'KL01')
insert into Luat values('A01^B02^C03',	'KL02')
insert into Luat values('A01^B03^C03',	'KL03')
insert into Luat values('A01^B04^C03',	'KL04')
insert into Luat values('A02^B01^C03',	'KL05')
insert into Luat values('A02^B01^C03',	'KL06')
insert into Luat values('A02^B02^C03',	'KL07')
insert into Luat values('A02^B04^C03',	'KL08')
insert into Luat values('A02^B01^C01',	'KL09')
insert into Luat values('A02^B02^C01',	'KL10')
insert into Luat values('A02^B03^C01',	'KL11')
insert into Luat values('A02^B04^C01',	'KL12')
insert into Luat values('A02^B04^C01',	'KL13')
insert into Luat values('A02^B02^C02',	'KL14')
insert into Luat values('A03^B01^C01',	'KL15')
insert into Luat values('A03^B02^C01',	'KL16')
insert into Luat values('A03^B03^C01',	'KL17')
insert into Luat values('A03^B03^C01',	'KL18')
insert into Luat values('A03^B04^C01',	'KL19')
insert into Luat values('A03^B02^C02',	'KL20')
insert into Luat values('A03^B04^C02',	'KL21')
insert into Luat values('A04^B01^C01',	'KL22')
insert into Luat values('A04^B01^C01',	'KL23')
insert into Luat values('A04^B01^C02',	'KL24')
insert into Luat values('G01',	'B04')
insert into Luat values('G02',	'B01')
insert into Luat values('G02',	'B02')
insert into Luat values('G03',	'B03')
insert into Luat values('E01',	'A01')
insert into Luat values('E01',	'A02')
insert into Luat values('E02',	'A02')
insert into Luat values('E02',	'A03')
insert into Luat values('E03',	'A03')
insert into Luat values('E03',	'A04')
insert into Luat values('F01',	'C01')
insert into Luat values('F01',	'C03')
insert into Luat values('F02',	'C03')
insert into Luat values('F02',	'C02')
--insert into Luat values('G01',	'D08')
--insert into Luat values('G01',	'D09')
--insert into Luat values('G01',	'D07')
--insert into Luat values('G02',	'D04')
--insert into Luat values('G02',	'D05')
--insert into Luat values('G02',	'D06')
--insert into Luat values('G02',	'D07')
--insert into Luat values('G02',	'D08')
--insert into Luat values('G03',	'D01')
--insert into Luat values('G03',	'D02')
--insert into Luat values('G03',	'D03')