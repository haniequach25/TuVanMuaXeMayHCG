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
create table DungTich(
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

insert into DungTich values('D01' , '97cc')
insert into DungTich values('D02' , '100cc')
insert into DungTich values('D03' , '108cc')
insert into DungTich values('D04' , '110cc')
insert into DungTich values('D05' , '113cc')
insert into DungTich values('D06' , '114cc')
insert into DungTich values('D07' , '115cc')
insert into DungTich values('D08' , '125cc')
insert into DungTich values('D09' , '135cc')
insert into DungTich values('D10' , '150cc')

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

insert into Luat values('A01', 'C01')
insert into Luat values('C01', 'B01')
insert into Luat values('B01^D01', 'KL01')
insert into Luat values('C01', 'B02')
insert into Luat values('B02^D04', 'KL02')
insert into Luat values('C01', 'B03')
insert into Luat values('B03^D03', 'KL03')
insert into Luat values('C01', 'B04')
insert into Luat values('B04^D04', 'KL04')
insert into Luat values('A02', 'C01')
insert into Luat values('C01', 'B01')
insert into Luat values('B01^D08', 'KL05')
insert into Luat values('B01^D04', 'KL06')
insert into Luat values('C01', 'B02')
insert into Luat values('B02^D07', 'KL07')
insert into Luat values('C01', 'B04')
insert into Luat values('B04^D06', 'KL08')
insert into Luat values('A02', 'C02')
insert into Luat values('C02', 'B01')
insert into Luat values('B01^D03', 'KL09')
insert into Luat values('C02', 'B02')
insert into Luat values('B02^D08', 'KL10')
insert into Luat values('C02', 'B03')
insert into Luat values('B03^D08', 'KL11')
insert into Luat values('C02', 'B04')
insert into Luat values('B04^D08', 'KL12')
insert into Luat values('B04^D05', 'KL13')
insert into Luat values('A02', 'C03')
insert into Luat values('C03', 'B02')
insert into Luat values('B02^D08', 'KL14')
insert into Luat values('A03', 'C02')
insert into Luat values('C02', 'B01')
insert into Luat values('B01^D08', 'KL15')
insert into Luat values('C02', 'B02')
insert into Luat values('B02^D08', 'KL16')
insert into Luat values('C02', 'B03')
insert into Luat values('B03^D08', 'KL17')
insert into Luat values('B03^D09', 'KL18')
insert into Luat values('C02', 'B04')
insert into Luat values('B04^D08', 'KL19')
insert into Luat values('A03', 'C03')
insert into Luat values('C03', 'B02')
insert into Luat values('B02^D10', 'KL20')
insert into Luat values('C03', 'B4')
insert into Luat values('B04^D10', 'KL21')
insert into Luat values('A04', 'C02')
insert into Luat values('C02', 'B01')
insert into Luat values('B01^D08', 'KL22')
insert into Luat values('B01^D10', 'KL23')
insert into Luat values('A04', 'C03')
insert into Luat values('C03', 'B01')
insert into Luat values('B01^D08', 'KL24')
