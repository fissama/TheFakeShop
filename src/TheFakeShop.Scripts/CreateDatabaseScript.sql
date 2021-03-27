﻿CREATE DATABASE TheFakeShop;

USE TheFakeShop;

CREATE TABLE Categories (
	CategoryID INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName NVARCHAR(100),
	ParentID INT,
	Modified_at TIMESTAMP,
	FOREIGN KEY(ParentID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Products (
	ProductID INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(200),
	Price MONEY,
	InStock INT,
	Description VARCHAR(1000),
	CategoryID INT,
	Modified_at TIMESTAMP,
	FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE ProductImages (
	PImageID INT IDENTITY(1,1) PRIMARY KEY,
	ImageLink VARCHAR(100),
	ProductID INT,
	Modified_at TIMESTAMP,
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE ProductRatings (
	PRatingID INT IDENTITY(1,1) PRIMARY KEY,
	CustomerName NVARCHAR(20), --3~20 character
	CustomerEmail VARCHAR(50),
	Rating TINYINT,
	Title NVARCHAR(50),
	Content NVARCHAR(500),
	ProductID INT,
	Modified_at TIMESTAMP,
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Provinces (
	ProvinceID INT IDENTITY(1,1) PRIMARY KEY,
	ProvinceName NVARCHAR(30),
);

CREATE TABLE Districts (
	DistrictID INT IDENTITY(1,1) PRIMARY KEY,
	DistrictName NVARCHAR(30),
	ProvinceID INT,
	FOREIGN KEY(ProvinceID) REFERENCES Provinces(ProvinceID)
);

CREATE TABLE Account (
	AccountID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(40),
	LastName NVARCHAR(25),
	Email VARCHAR(50),
	Password VARCHAR(50),
	Phone CHAR(10),
	Gender BIT,
	Address NVARCHAR(60),
	Remember_token VARCHAR(100),
	DistrictID INT,
	Modified_at TIMESTAMP,
	FOREIGN KEY(DistrictID) REFERENCES Districts(DistrictID)
);

CREATE TABLE Admin (
	AdminID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(40),
	LastName NVARCHAR(25),
	Email VARCHAR(50),
	Password VARCHAR(50),
	Remember_token VARCHAR(100),
	Modified_at TIMESTAMP,
);

--INSERT Provinces
BEGIN TRANSACTION
INSERT INTO Provinces VALUES (N'An Giang');
INSERT INTO Provinces VALUES (N'Bà Rịa–Vũng Tàu');
INSERT INTO Provinces VALUES (N'Bắc Giang');
INSERT INTO Provinces VALUES (N'Bắc Kạn');
INSERT INTO Provinces VALUES (N'Bạc Liêu');
INSERT INTO Provinces VALUES (N'Bắc Ninh');
INSERT INTO Provinces VALUES (N'Bến Tre');
INSERT INTO Provinces VALUES (N'Bình Định');
INSERT INTO Provinces VALUES (N'Bình Dương');
INSERT INTO Provinces VALUES (N'Bình Phước');
INSERT INTO Provinces VALUES (N'Bình Thuận');
INSERT INTO Provinces VALUES (N'Cà Mau');
INSERT INTO Provinces VALUES (N'Cần Thơ');
INSERT INTO Provinces VALUES (N'Cao Bằng');
INSERT INTO Provinces VALUES (N'Đà Nẵng');
INSERT INTO Provinces VALUES (N'Đắk Lắk');
INSERT INTO Provinces VALUES (N'Đắk Nông');
INSERT INTO Provinces VALUES (N'Điện Biên');
INSERT INTO Provinces VALUES (N'Đồng Nai');
INSERT INTO Provinces VALUES (N'Đồng Tháp');
INSERT INTO Provinces VALUES (N'Gia Lai');
INSERT INTO Provinces VALUES (N'Hà Giang');
INSERT INTO Provinces VALUES (N'Hà Nam');
INSERT INTO Provinces VALUES (N'Hà Nội');
INSERT INTO Provinces VALUES (N'Hà Tĩnh');
INSERT INTO Provinces VALUES (N'Hải Dương');
INSERT INTO Provinces VALUES (N'Hải Phòng');
INSERT INTO Provinces VALUES (N'Hậu Giang');
INSERT INTO Provinces VALUES (N'Hồ Chí Minh City');
INSERT INTO Provinces VALUES (N'Hòa Bình');
INSERT INTO Provinces VALUES (N'Hưng Yên');
INSERT INTO Provinces VALUES (N'Khánh Hòa');
INSERT INTO Provinces VALUES (N'Kiên Giang');
INSERT INTO Provinces VALUES (N'Kon Tum');
INSERT INTO Provinces VALUES (N'Lai Châu');
INSERT INTO Provinces VALUES (N'Lâm Đồng');
INSERT INTO Provinces VALUES (N'Lạng Sơn');
INSERT INTO Provinces VALUES (N'Lào Cai');
INSERT INTO Provinces VALUES (N'Long An');
INSERT INTO Provinces VALUES (N'Nam Định');
INSERT INTO Provinces VALUES (N'Nghệ An');
INSERT INTO Provinces VALUES (N'Ninh Bình');
INSERT INTO Provinces VALUES (N'Ninh Thuận');
INSERT INTO Provinces VALUES (N'Phú Thọ');
INSERT INTO Provinces VALUES (N'Phú Yên');
INSERT INTO Provinces VALUES (N'Quảng Bình');
INSERT INTO Provinces VALUES (N'Quảng Nam');
INSERT INTO Provinces VALUES (N'Quảng Ngãi');
INSERT INTO Provinces VALUES (N'Quảng Ninh');
INSERT INTO Provinces VALUES (N'Quảng Trị');
INSERT INTO Provinces VALUES (N'Sóc Trăng');
INSERT INTO Provinces VALUES (N'Sơn La');
INSERT INTO Provinces VALUES (N'Tây Ninh');
INSERT INTO Provinces VALUES (N'Thái Bình');
INSERT INTO Provinces VALUES (N'Thái Nguyên');
INSERT INTO Provinces VALUES (N'Thanh Hóa');
INSERT INTO Provinces VALUES (N'Thừa Thiên–Huế');
INSERT INTO Provinces VALUES (N'Tiền Giang');
INSERT INTO Provinces VALUES (N'Trà Vinh');
INSERT INTO Provinces VALUES (N'Tuyên Quang');
INSERT INTO Provinces VALUES (N'Vĩnh Long');
INSERT INTO Provinces VALUES (N'Vĩnh Phúc');
INSERT INTO Provinces VALUES (N'Yên Bái');

INSERT INTO Districts VALUES (N'An Phú',1 );
INSERT INTO Districts VALUES (N'Châu Đốc',1 );
INSERT INTO Districts VALUES (N'Châu Phú',1 );
INSERT INTO Districts VALUES (N'Châu Thành',1 );
INSERT INTO Districts VALUES (N'Chợ Mới',1 );
INSERT INTO Districts VALUES (N'Long Xuyên',1 );
INSERT INTO Districts VALUES (N'Phú Tân',1 );
INSERT INTO Districts VALUES (N'Tân Châu',1 );
INSERT INTO Districts VALUES (N'Thoại Sơn',1 );
INSERT INTO Districts VALUES (N'Tịnh Biên',1 );
INSERT INTO Districts VALUES (N'Tri Tôn',1 );
INSERT INTO Districts VALUES (N'Bà Rịa',2 );
INSERT INTO Districts VALUES (N'Châu Đức',2 );
INSERT INTO Districts VALUES (N'Côn Đảo',2 );
INSERT INTO Districts VALUES (N'Đất Đỏ',2 );
INSERT INTO Districts VALUES (N'Long Điền',2 );
INSERT INTO Districts VALUES (N'Tân Thành',2 );
INSERT INTO Districts VALUES (N'Vũng Tàu',2 );
INSERT INTO Districts VALUES (N'Xuyên Mộc',2 );
INSERT INTO Districts VALUES (N'Bắc Giang',3 );
INSERT INTO Districts VALUES (N'Hiệp Hòa',3 );
INSERT INTO Districts VALUES (N'Lạng Giang',3 );
INSERT INTO Districts VALUES (N'Lục Nam',3 );
INSERT INTO Districts VALUES (N'Lục Ngạn',3 );
INSERT INTO Districts VALUES (N'Sơn Động',3 );
INSERT INTO Districts VALUES (N'Tân Yên',3 );
INSERT INTO Districts VALUES (N'Việt Yên',3 );
INSERT INTO Districts VALUES (N'Yên Dũng',3 );
INSERT INTO Districts VALUES (N'Yên Thế',3 );
INSERT INTO Districts VALUES (N'Ba Bể',4 );
INSERT INTO Districts VALUES (N'Bắc Kạn',4 );
INSERT INTO Districts VALUES (N'Bạch Thông',4 );
INSERT INTO Districts VALUES (N'Chợ Đồn',4 );
INSERT INTO Districts VALUES (N'Chợ Mới',4 );
INSERT INTO Districts VALUES (N'Na Rì',4 );
INSERT INTO Districts VALUES (N'Ngân Sơn',4 );
INSERT INTO Districts VALUES (N'Pác Nặm',4 );
INSERT INTO Districts VALUES (N'Bạc Liêu',5 );
INSERT INTO Districts VALUES (N'Đông Hải',5 );
INSERT INTO Districts VALUES (N'Giá Rai',5 );
INSERT INTO Districts VALUES (N'Hòa Bình',5 );
INSERT INTO Districts VALUES (N'Hồng Dân',5 );
INSERT INTO Districts VALUES (N'Phước Long',5 );
INSERT INTO Districts VALUES (N'Vĩnh Lợi',5 );
INSERT INTO Districts VALUES (N'Bắc Ninh',6 );
INSERT INTO Districts VALUES (N'Gia Bình',6 );
INSERT INTO Districts VALUES (N'Lương Tài',6 );
INSERT INTO Districts VALUES (N'Quế Võ',6 );
INSERT INTO Districts VALUES (N'Thuận Thành',6 );
INSERT INTO Districts VALUES (N'Tiên Du',6 );
INSERT INTO Districts VALUES (N'Từ Sơn',6 );
INSERT INTO Districts VALUES (N'Yên Phong',6 );
INSERT INTO Districts VALUES (N'Ba Tri',7 );
INSERT INTO Districts VALUES (N'Bến Tre',7 );
INSERT INTO Districts VALUES (N'Bình Đại',7 );
INSERT INTO Districts VALUES (N'Châu Thành',7 );
INSERT INTO Districts VALUES (N'Chợ Lách',7 );
INSERT INTO Districts VALUES (N'Giồng Trôm',7 );
INSERT INTO Districts VALUES (N'Mỏ Cày',7 );
INSERT INTO Districts VALUES (N'Thạnh Phú',7 );
INSERT INTO Districts VALUES (N'An Lão',8 );
INSERT INTO Districts VALUES (N'An Nhơn',8 );
INSERT INTO Districts VALUES (N'Hoài Ân',8 );
INSERT INTO Districts VALUES (N'Hoài Nhơn',8 );
INSERT INTO Districts VALUES (N'Phù Cát',8 );
INSERT INTO Districts VALUES (N'Phù Mỹ',8 );
INSERT INTO Districts VALUES (N'Qui Nhơn',8 );
INSERT INTO Districts VALUES (N'Tây Sơn',8 );
INSERT INTO Districts VALUES (N'Tuy Phước',8 );
INSERT INTO Districts VALUES (N'Vân Canh',8 );
INSERT INTO Districts VALUES (N'Vĩnh Thạnh',8 );
INSERT INTO Districts VALUES (N'Bến Cát',9 );
INSERT INTO Districts VALUES (N'Dầu Tiếng',9 );
INSERT INTO Districts VALUES (N'Dĩ An',9 );
INSERT INTO Districts VALUES (N'Phú Giáo',9 );
INSERT INTO Districts VALUES (N'Tân Uyên',9 );
INSERT INTO Districts VALUES (N'Thủ Dầu Một',9 );
INSERT INTO Districts VALUES (N'Thuận An',9 );
INSERT INTO Districts VALUES (N'Bình Long',10 );
INSERT INTO Districts VALUES (N'Bù Đăng',10 );
INSERT INTO Districts VALUES (N'Bù Đốp',10 );
INSERT INTO Districts VALUES (N'Chơn Thành',10 );
INSERT INTO Districts VALUES (N'Đồng Phú',10 );
INSERT INTO Districts VALUES (N'Đồng Xoài',10 );
INSERT INTO Districts VALUES (N'Lộc Ninh',10 );
INSERT INTO Districts VALUES (N'Phước Long',10 );
INSERT INTO Districts VALUES (N'Hớn Quản',10 );
INSERT INTO Districts VALUES (N'Bù Gia Mập',10 );
INSERT INTO Districts VALUES (N'Bắc Bình',11 );
INSERT INTO Districts VALUES (N'Đức Linh',11 );
INSERT INTO Districts VALUES (N'Hàm Tân',11 );
INSERT INTO Districts VALUES (N'Hàm Thuận Bắc',11 );
INSERT INTO Districts VALUES (N'Hàm Thuận Nam',11 );
INSERT INTO Districts VALUES (N'La Gi',11 );
INSERT INTO Districts VALUES (N'Phan Thiết',11 );
INSERT INTO Districts VALUES (N'Phú Quý',11 );
INSERT INTO Districts VALUES (N'Tánh Linh',11 );
INSERT INTO Districts VALUES (N'Tuy Phong',11 );
INSERT INTO Districts VALUES (N'Cà Mau',12 );
INSERT INTO Districts VALUES (N'Đầm Dơi',12 );
INSERT INTO Districts VALUES (N'Cái Nước',12 );
INSERT INTO Districts VALUES (N'Năm Căn',12 );
INSERT INTO Districts VALUES (N'Ngọc Hiển',12 );
INSERT INTO Districts VALUES (N'Phú Tân',12 );
INSERT INTO Districts VALUES (N'Thới Bình',12 );
INSERT INTO Districts VALUES (N'Trần Văn Thời',12 );
INSERT INTO Districts VALUES (N'U Minh',12 );
INSERT INTO Districts VALUES (N'Bình Thủy',13 );
INSERT INTO Districts VALUES (N'Cái Răng',13 );
INSERT INTO Districts VALUES (N'Cờ Đỏ',13 );
INSERT INTO Districts VALUES (N'Cần Thơ',13 );
INSERT INTO Districts VALUES (N'Ninh Kiều',13 );
INSERT INTO Districts VALUES (N'Ô Môn',13 );
INSERT INTO Districts VALUES (N'Phong Điền',13 );
INSERT INTO Districts VALUES (N'Thốt Nốt',13 );
INSERT INTO Districts VALUES (N'Vĩnh Thạnh',13 );
INSERT INTO Districts VALUES (N'Thới Lai',13 );
INSERT INTO Districts VALUES (N'Bảo Lạc',14 );
INSERT INTO Districts VALUES (N'Bảo Lâm',14 );
INSERT INTO Districts VALUES (N'Cao Bằng',14 );
INSERT INTO Districts VALUES (N'Hạ Lang',14 );
INSERT INTO Districts VALUES (N'Hà Quảng',14 );
INSERT INTO Districts VALUES (N'Hòa An',14 );
INSERT INTO Districts VALUES (N'Nguyên Bình',14 );
INSERT INTO Districts VALUES (N'Phục Hòa',14 );
INSERT INTO Districts VALUES (N'Quảng Uyên',14 );
INSERT INTO Districts VALUES (N'Thạch An',14 );
INSERT INTO Districts VALUES (N'Thông Nông',14 );
INSERT INTO Districts VALUES (N'Trà Lĩnh',14 );
INSERT INTO Districts VALUES (N'Trùng Khánh',14 );
INSERT INTO Districts VALUES (N'Cẩm Lệ',15 );
INSERT INTO Districts VALUES (N'Hải Châu',15 );
INSERT INTO Districts VALUES (N'Hòa Vang',15 );
INSERT INTO Districts VALUES (N'Hoàng Sa',15 );
INSERT INTO Districts VALUES (N'Liên Chiểu',15 );
INSERT INTO Districts VALUES (N'Ngũ Hành Sơn',15 );
INSERT INTO Districts VALUES (N'Sơn Trà',15 );
INSERT INTO Districts VALUES (N'Thanh Khê',15 );
INSERT INTO Districts VALUES (N'Buôn Đôn',16 );
INSERT INTO Districts VALUES (N'Buôn Ma Thuột',16 );
INSERT INTO Districts VALUES (N'Cư M''gar',16 );
INSERT INTO Districts VALUES (N'Cư Kuin',16 );
INSERT INTO Districts VALUES (N'Ea H''leo',16 );
INSERT INTO Districts VALUES (N'Ea Kar',16 );
INSERT INTO Districts VALUES (N'Ea Súp',16 );
INSERT INTO Districts VALUES (N'Krông Ana',16 );
INSERT INTO Districts VALUES (N'Krông Bông',16 );
INSERT INTO Districts VALUES (N'Krông Buk',16 );
INSERT INTO Districts VALUES (N'Krông Năng',16 );
INSERT INTO Districts VALUES (N'Krông Pắk',16 );
INSERT INTO Districts VALUES (N'Lắk',16 );
INSERT INTO Districts VALUES (N'M''Đrăk',16 );
INSERT INTO Districts VALUES (N'Buôn Hồ',16 );
INSERT INTO Districts VALUES (N'Cư Jút',17 );
INSERT INTO Districts VALUES (N'Đắk Glong',17 );
INSERT INTO Districts VALUES (N'Đắk Mil',17 );
INSERT INTO Districts VALUES (N'Đắk R''Lấp',17 );
INSERT INTO Districts VALUES (N'Đắk Song',17 );
INSERT INTO Districts VALUES (N'Gia Nghĩa',17 );
INSERT INTO Districts VALUES (N'Krông Nô',17 );
INSERT INTO Districts VALUES (N'Tuy Đức',17 );
INSERT INTO Districts VALUES (N'Điện Biên',18 );
INSERT INTO Districts VALUES (N'Điện Biên Đông',18 );
INSERT INTO Districts VALUES (N'Điện Biên Phủ',18 );
INSERT INTO Districts VALUES (N'Mường Chà',18 );
INSERT INTO Districts VALUES (N'Mường Nhé',18 );
INSERT INTO Districts VALUES (N'Tủa Chùa',18 );
INSERT INTO Districts VALUES (N'Tuần Giáo',18 );
INSERT INTO Districts VALUES (N'Biên Hòa',19 );
INSERT INTO Districts VALUES (N'Cẩm Mỹ',19 );
INSERT INTO Districts VALUES (N'Định Quán',19 );
INSERT INTO Districts VALUES (N'Long Khánh',19 );
INSERT INTO Districts VALUES (N'Long Thành',19 );
INSERT INTO Districts VALUES (N'Nhơn Trạch',19 );
INSERT INTO Districts VALUES (N'Tân Phú',19 );
INSERT INTO Districts VALUES (N'Thống Nhất',19 );
INSERT INTO Districts VALUES (N'Trảng Bom',19 );
INSERT INTO Districts VALUES (N'Vĩnh Cữu',19 );
INSERT INTO Districts VALUES (N'Xuân Lộc',19 );
INSERT INTO Districts VALUES (N'Cao Lãnh',20 );
INSERT INTO Districts VALUES (N'Châu Thành',20 );
INSERT INTO Districts VALUES (N'Hồng Ngự',20 );
INSERT INTO Districts VALUES (N'Lai Vung',20 );
INSERT INTO Districts VALUES (N'Lấp Vò',20 );
INSERT INTO Districts VALUES (N'Sa Đéc',20 );
INSERT INTO Districts VALUES (N'Tam Nông',20 );
INSERT INTO Districts VALUES (N'Tân Hồng',20 );
INSERT INTO Districts VALUES (N'Thanh Bình',20 );
INSERT INTO Districts VALUES (N'Tháp Mười',20 );
INSERT INTO Districts VALUES (N'Ayun Pa',21 );
INSERT INTO Districts VALUES (N'An Khê',21 );
INSERT INTO Districts VALUES (N'Chư Păh',21 );
INSERT INTO Districts VALUES (N'Chư Prông',21 );
INSERT INTO Districts VALUES (N'Chư Sê',21 );
INSERT INTO Districts VALUES (N'Đắk Đoa',21 );
INSERT INTO Districts VALUES (N'Đắk Pơ',21 );
INSERT INTO Districts VALUES (N'Đức Cơ',21 );
INSERT INTO Districts VALUES (N'Ia Grai',21 );
INSERT INTO Districts VALUES (N'Ia Pa',21 );
INSERT INTO Districts VALUES (N'K''Bang',21 );
INSERT INTO Districts VALUES (N'Kông Chro',21 );
INSERT INTO Districts VALUES (N'Krông Pa',21 );
INSERT INTO Districts VALUES (N'Mang Yang',21 );
INSERT INTO Districts VALUES (N'Phú Thiện',21 );
INSERT INTO Districts VALUES (N'Pleiku',21 );
INSERT INTO Districts VALUES (N'Chư Pưh',21 );
INSERT INTO Districts VALUES (N'Bắc Mê',22 );
INSERT INTO Districts VALUES (N'Bắc Quang',22 );
INSERT INTO Districts VALUES (N'Đồng Văn',22 );
INSERT INTO Districts VALUES (N'Hà Giang',22 );
INSERT INTO Districts VALUES (N'Hoàng Su Phì',22 );
INSERT INTO Districts VALUES (N'Mèo Vạc',22 );
INSERT INTO Districts VALUES (N'Quản Bạ',22 );
INSERT INTO Districts VALUES (N'Quảng Bình',22 );
INSERT INTO Districts VALUES (N'Vị Xuyên',22 );
INSERT INTO Districts VALUES (N'Xín Mần',22 );
INSERT INTO Districts VALUES (N'Yên Minh',22 );
INSERT INTO Districts VALUES (N'Bình Lục',23 );
INSERT INTO Districts VALUES (N'Duy Tiên',23 );
INSERT INTO Districts VALUES (N'Kim Bảng',23 );
INSERT INTO Districts VALUES (N'Lý Nhân',23 );
INSERT INTO Districts VALUES (N'Phủ Lý',23 );
INSERT INTO Districts VALUES (N'Thanh Liêm',23 );
INSERT INTO Districts VALUES (N'Ba Đình',24 );
INSERT INTO Districts VALUES (N'Cầu Giấy',24 );
INSERT INTO Districts VALUES (N'Đông Anh',24 );
INSERT INTO Districts VALUES (N'Đống Đa',24 );
INSERT INTO Districts VALUES (N'Gia Lâm',24 );
INSERT INTO Districts VALUES (N'Hai Bà Trưng',24 );
INSERT INTO Districts VALUES (N'Hoàn Kiếm',24 );
INSERT INTO Districts VALUES (N'Hoàng Mai',24 );
INSERT INTO Districts VALUES (N'Long Biên',24 );
INSERT INTO Districts VALUES (N'Sóc Sơn',24 );
INSERT INTO Districts VALUES (N'Tây Hồ',24 );
INSERT INTO Districts VALUES (N'Thanh Trì',24 );
INSERT INTO Districts VALUES (N'Thanh Xuân',24 );
INSERT INTO Districts VALUES (N'Từ Liêm',24 );
INSERT INTO Districts VALUES (N'Ba Vì',24 );
INSERT INTO Districts VALUES (N'Chương Mỹ',24 );
INSERT INTO Districts VALUES (N'Đan Phượng',24 );
INSERT INTO Districts VALUES (N'Hà Đông',24 );
INSERT INTO Districts VALUES (N'Hoài Đức',24 );
INSERT INTO Districts VALUES (N'Mỹ Đức',24 );
INSERT INTO Districts VALUES (N'Phú Xuyên',24 );
INSERT INTO Districts VALUES (N'Phúc Thọ',24 );
INSERT INTO Districts VALUES (N'Quốc Oai',24 );
INSERT INTO Districts VALUES (N'Sơn Tây',24 );
INSERT INTO Districts VALUES (N'Thạch Thất',24 );
INSERT INTO Districts VALUES (N'Thanh Oai',24 );
INSERT INTO Districts VALUES (N'Thường Tín',24 );
INSERT INTO Districts VALUES (N'Ứng Hòa',24 );
INSERT INTO Districts VALUES (N'Cẩm Xuyên',25 );
INSERT INTO Districts VALUES (N'Can Lộc',25 );
INSERT INTO Districts VALUES (N'Đức Thọ',25 );
INSERT INTO Districts VALUES (N'Hà Tĩnh',25 );
INSERT INTO Districts VALUES (N'Hồng Lĩnh',25 );
INSERT INTO Districts VALUES (N'Hương Khê',25 );
INSERT INTO Districts VALUES (N'Hương Sơn',25 );
INSERT INTO Districts VALUES (N'Kỳ Anh',25 );
INSERT INTO Districts VALUES (N'Nghi Xuân',25 );
INSERT INTO Districts VALUES (N'Thạch Hà',25 );
INSERT INTO Districts VALUES (N'Vũ Quang',25 );
INSERT INTO Districts VALUES (N'Bình Giang',26 );
INSERT INTO Districts VALUES (N'Cẩm Giàng',26 );
INSERT INTO Districts VALUES (N'Chí Linh',26 );
INSERT INTO Districts VALUES (N'Gia Lộc',26 );
INSERT INTO Districts VALUES (N'Hải Dương',26 );
INSERT INTO Districts VALUES (N'Kim Thành',26 );
INSERT INTO Districts VALUES (N'Kinh Môn',26 );
INSERT INTO Districts VALUES (N'Nam Sách',26 );
INSERT INTO Districts VALUES (N'Ninh Giang',26 );
INSERT INTO Districts VALUES (N'Thanh Hà',26 );
INSERT INTO Districts VALUES (N'Thanh Miện',26 );
INSERT INTO Districts VALUES (N'Tứ Kỳ',26 );
INSERT INTO Districts VALUES (N'An Dương',27 );
INSERT INTO Districts VALUES (N'An Lão',27 );
INSERT INTO Districts VALUES (N'Bạch Long Vĩ',27 );
INSERT INTO Districts VALUES (N'Cát Hải',27 );
INSERT INTO Districts VALUES (N'Đồ Sơn',27 );
INSERT INTO Districts VALUES (N'Hải An',27 );
INSERT INTO Districts VALUES (N'Hồng Bàng',27 );
INSERT INTO Districts VALUES (N'Kiến An',27 );
INSERT INTO Districts VALUES (N'Kiến Thuỵ',27 );
INSERT INTO Districts VALUES (N'Lê Chân',27 );
INSERT INTO Districts VALUES (N'Ngô Quyền',27 );
INSERT INTO Districts VALUES (N'Thủy Nguyên',27 );
INSERT INTO Districts VALUES (N'Tiên Lãng',27 );
INSERT INTO Districts VALUES (N'Vĩnh Bảo',27 );
INSERT INTO Districts VALUES (N'Dương Kinh',27 );
INSERT INTO Districts VALUES (N'Châu Thành',28 );
INSERT INTO Districts VALUES (N'Châu Thành A',28 );
INSERT INTO Districts VALUES (N'Long Mỹ',28 );
INSERT INTO Districts VALUES (N'Phụng Hiệp',28 );
INSERT INTO Districts VALUES (N'Vị Thanh',28 );
INSERT INTO Districts VALUES (N'Vị Thủy',28 );
INSERT INTO Districts VALUES (N'Ngã Bảy',28 );
INSERT INTO Districts VALUES (N'Bình Chánh',29 );
INSERT INTO Districts VALUES (N'Bình Tân',29 );
INSERT INTO Districts VALUES (N'Bình Thạnh',29 );
INSERT INTO Districts VALUES (N'Cần Giờ',29 );
INSERT INTO Districts VALUES (N'Củ Chi',29 );
INSERT INTO Districts VALUES (N'District 1',29 );
INSERT INTO Districts VALUES (N'District 2',29 );
INSERT INTO Districts VALUES (N'District 3',29 );
INSERT INTO Districts VALUES (N'District 4',29 );
INSERT INTO Districts VALUES (N'District 5',29 );
INSERT INTO Districts VALUES (N'District 6',29 );
INSERT INTO Districts VALUES (N'District 7',29 );
INSERT INTO Districts VALUES (N'District 8',29 );
INSERT INTO Districts VALUES (N'District 9',29 );
INSERT INTO Districts VALUES (N'District 10',29 );
INSERT INTO Districts VALUES (N'District 11',29 );
INSERT INTO Districts VALUES (N'District 12',29 );
INSERT INTO Districts VALUES (N'Gò Vấp',29 );
INSERT INTO Districts VALUES (N'Hóc Môn',29 );
INSERT INTO Districts VALUES (N'Nhà Bè',29 );
INSERT INTO Districts VALUES (N'Phú Nhuận',29 );
INSERT INTO Districts VALUES (N'Tân Bình',29 );
INSERT INTO Districts VALUES (N'Tân Phú',29 );
INSERT INTO Districts VALUES (N'Thủ Đức',29 );
INSERT INTO Districts VALUES (N'Cao Phong',30 );
INSERT INTO Districts VALUES (N'Đà Bắc',30 );
INSERT INTO Districts VALUES (N'Hòa Bình',30 );
INSERT INTO Districts VALUES (N'Kim Bôi',30 );
INSERT INTO Districts VALUES (N'Kỳ Sơn',30 );
INSERT INTO Districts VALUES (N'Lạc Sơn',30 );
INSERT INTO Districts VALUES (N'Lạc Thủy',30 );
INSERT INTO Districts VALUES (N'Lương Sơn',30 );
INSERT INTO Districts VALUES (N'Mai Châu',30 );
INSERT INTO Districts VALUES (N'Tân Lạc',30 );
INSERT INTO Districts VALUES (N'Yên Thủy',30 );
INSERT INTO Districts VALUES (N'Ân Thi',31 );
INSERT INTO Districts VALUES (N'Hưng Yên',31 );
INSERT INTO Districts VALUES (N'Khoái Châu',31 );
INSERT INTO Districts VALUES (N'Kim Động',31 );
INSERT INTO Districts VALUES (N'Mỹ Hào',31 );
INSERT INTO Districts VALUES (N'Phù Cừ',31 );
INSERT INTO Districts VALUES (N'Tiên Lữ',31 );
INSERT INTO Districts VALUES (N'Văn Giang',31 );
INSERT INTO Districts VALUES (N'Văn Lâm',31 );
INSERT INTO Districts VALUES (N'Yên Mỹ',31 );
INSERT INTO Districts VALUES (N'Cam Lâm',32 );
INSERT INTO Districts VALUES (N'Cam Ranh',32 );
INSERT INTO Districts VALUES (N'Diên Khánh',32 );
INSERT INTO Districts VALUES (N'Khánh Sơn',32 );
INSERT INTO Districts VALUES (N'Khánh Vĩnh',32 );
INSERT INTO Districts VALUES (N'Nha Trang',32 );
INSERT INTO Districts VALUES (N'Ninh Hòa',32 );
INSERT INTO Districts VALUES (N'Trường Sa',32 );
INSERT INTO Districts VALUES (N'Vạn Ninh',32 );
INSERT INTO Districts VALUES (N'An Biên',33 );
INSERT INTO Districts VALUES (N'An Minh',33 );
INSERT INTO Districts VALUES (N'Châu Thành',33 );
INSERT INTO Districts VALUES (N'Giồng Riềng',33 );
INSERT INTO Districts VALUES (N'Gò Quao',33 );
INSERT INTO Districts VALUES (N'Giang Thành',33 );
INSERT INTO Districts VALUES (N'Hà Tiên',33 );
INSERT INTO Districts VALUES (N'Hòn Đất',33 );
INSERT INTO Districts VALUES (N'Kiên Hải',33 );
INSERT INTO Districts VALUES (N'Kiên Lương',33 );
INSERT INTO Districts VALUES (N'Phú Quốc',33 );
INSERT INTO Districts VALUES (N'Rạch Giá',33 );
INSERT INTO Districts VALUES (N'Tân Hiệp',33 );
INSERT INTO Districts VALUES (N'Vĩnh Thuận',33 );
INSERT INTO Districts VALUES (N'U Minh Thượng',33 );
INSERT INTO Districts VALUES (N'Đắk Glei',34 );
INSERT INTO Districts VALUES (N'Đắk Hà',34 );
INSERT INTO Districts VALUES (N'Đắk Tô',34 );
INSERT INTO Districts VALUES (N'Kon Plông',34 );
INSERT INTO Districts VALUES (N'Kon Rẫy',34 );
INSERT INTO Districts VALUES (N'Kon Tum',34 );
INSERT INTO Districts VALUES (N'Ngọc Hồi',34 );
INSERT INTO Districts VALUES (N'Sa Thầy',34 );
INSERT INTO Districts VALUES (N'Tu Mơ Rông',34 );
INSERT INTO Districts VALUES (N'Lai Châu',35 );
INSERT INTO Districts VALUES (N'Mường Tè',35 );
INSERT INTO Districts VALUES (N'Phong Thổ',35 );
INSERT INTO Districts VALUES (N'Sìn Hồ',35 );
INSERT INTO Districts VALUES (N'Tam Đường',35 );
INSERT INTO Districts VALUES (N'Than Uyên',35 );
INSERT INTO Districts VALUES (N'Tân Uyên',35 );
INSERT INTO Districts VALUES (N'Bảo Lâm',36 );
INSERT INTO Districts VALUES (N'Bảo Lộc',36 );
INSERT INTO Districts VALUES (N'Cát Tiên',36 );
INSERT INTO Districts VALUES (N'Đạ Huoai',36 );
INSERT INTO Districts VALUES (N'Đà Lạt',36 );
INSERT INTO Districts VALUES (N'Đạ Tẻh',36 );
INSERT INTO Districts VALUES (N'Đam Rông',36 );
INSERT INTO Districts VALUES (N'Di Linh',36 );
INSERT INTO Districts VALUES (N'Đơn Dương',36 );
INSERT INTO Districts VALUES (N'Đức Trọng',36 );
INSERT INTO Districts VALUES (N'Lạc Dương',36 );
INSERT INTO Districts VALUES (N'Lâm Hà',36 );
INSERT INTO Districts VALUES (N'Bắc Sơn',37 );
INSERT INTO Districts VALUES (N'Bình Gia',37 );
INSERT INTO Districts VALUES (N'Cao Lộc',37 );
INSERT INTO Districts VALUES (N'Chi Lăng',37 );
INSERT INTO Districts VALUES (N'Đình Lập',37 );
INSERT INTO Districts VALUES (N'Hữu Lũng',37 );
INSERT INTO Districts VALUES (N'Lạng Sơn',37 );
INSERT INTO Districts VALUES (N'Lộc Bình',37 );
INSERT INTO Districts VALUES (N'Tràng Định',37 );
INSERT INTO Districts VALUES (N'Văn Lãng',37 );
INSERT INTO Districts VALUES (N'Văn Quân',37 );
INSERT INTO Districts VALUES (N'Bắc Hà',38 );
INSERT INTO Districts VALUES (N'Bảo Thắng',38 );
INSERT INTO Districts VALUES (N'Bảo Yên',38 );
INSERT INTO Districts VALUES (N'Bát Xát',38 );
INSERT INTO Districts VALUES (N'Lào Cai',38 );
INSERT INTO Districts VALUES (N'Mường Khương',38 );
INSERT INTO Districts VALUES (N'Sa Pa',38 );
INSERT INTO Districts VALUES (N'Si Ma Cai',38 );
INSERT INTO Districts VALUES (N'Văn Bàn',38 );
INSERT INTO Districts VALUES (N'Bến Lức',39 );
INSERT INTO Districts VALUES (N'Cần Đước',39 );
INSERT INTO Districts VALUES (N'Cần Giuộc',39 );
INSERT INTO Districts VALUES (N'Châu Thành',39 );
INSERT INTO Districts VALUES (N'Đức Hòa',39 );
INSERT INTO Districts VALUES (N'Đức Huệ',39 );
INSERT INTO Districts VALUES (N'Mộc Hóa',39 );
INSERT INTO Districts VALUES (N'Tân An',39 );
INSERT INTO Districts VALUES (N'Tân Hưng',39 );
INSERT INTO Districts VALUES (N'Tân Thạnh',39 );
INSERT INTO Districts VALUES (N'Tân Trụ',39 );
INSERT INTO Districts VALUES (N'Thạnh Hóa',39 );
INSERT INTO Districts VALUES (N'Thủ Thừa',39 );
INSERT INTO Districts VALUES (N'Vĩnh Hưng',39 );
INSERT INTO Districts VALUES (N'Giao Thủy',40 );
INSERT INTO Districts VALUES (N'Hải Hậu',40 );
INSERT INTO Districts VALUES (N'Mỹ Lộc',40 );
INSERT INTO Districts VALUES (N'Nam Định',40 );
INSERT INTO Districts VALUES (N'Nam Trực',40 );
INSERT INTO Districts VALUES (N'Nghĩa Hưng',40 );
INSERT INTO Districts VALUES (N'Trực Ninh',40 );
INSERT INTO Districts VALUES (N'Vụ Bản',40 );
INSERT INTO Districts VALUES (N'Xuân Trường',40 );
INSERT INTO Districts VALUES (N'Ý Yên',40 );
INSERT INTO Districts VALUES (N'Anh Sơn',41 );
INSERT INTO Districts VALUES (N'Con Cuông',41 );
INSERT INTO Districts VALUES (N'Cửa Lò',41 );
INSERT INTO Districts VALUES (N'Diễn Châu',41 );
INSERT INTO Districts VALUES (N'Đô Lương',41 );
INSERT INTO Districts VALUES (N'Hưng Nguyên',41 );
INSERT INTO Districts VALUES (N'Kỳ Sơn',41 );
INSERT INTO Districts VALUES (N'Nam Đàn',41 );
INSERT INTO Districts VALUES (N'Nghi Lộc',41 );
INSERT INTO Districts VALUES (N'Nghĩa Đàn',41 );
INSERT INTO Districts VALUES (N'Quế Phong',41 );
INSERT INTO Districts VALUES (N'Quỳnh Lưu',41 );
INSERT INTO Districts VALUES (N'Quỳ Châu',41 );
INSERT INTO Districts VALUES (N'Quỳ Hợp',41 );
INSERT INTO Districts VALUES (N'Tân Kỳ',41 );
INSERT INTO Districts VALUES (N'Thanh Chương',41 );
INSERT INTO Districts VALUES (N'Tương Dương',41 );
INSERT INTO Districts VALUES (N'Vinh',41 );
INSERT INTO Districts VALUES (N'Yên Thành',41 );
INSERT INTO Districts VALUES (N'Thái Hòa',41 );
INSERT INTO Districts VALUES (N'Gia Viễn',42 );
INSERT INTO Districts VALUES (N'Hoa Lư',42 );
INSERT INTO Districts VALUES (N'Kim Sơn',42 );
INSERT INTO Districts VALUES (N'Nho Quan',42 );
INSERT INTO Districts VALUES (N'Ninh Bình',42 );
INSERT INTO Districts VALUES (N'Tam Diệp',42 );
INSERT INTO Districts VALUES (N'Yên Khánh',42 );
INSERT INTO Districts VALUES (N'Yên Mô',42 );
INSERT INTO Districts VALUES (N'Ninh Hải',43 );
INSERT INTO Districts VALUES (N'Ninh Phước',43 );
INSERT INTO Districts VALUES (N'Ninh Sơn',43 );
INSERT INTO Districts VALUES (N'Phan Rang–Tháp Chàm',43 );
INSERT INTO Districts VALUES (N'Thuận Bắc',43 );
INSERT INTO Districts VALUES (N'Thuận Nam',43 );
INSERT INTO Districts VALUES (N'Cẩm Khê',44 );
INSERT INTO Districts VALUES (N'Đoan Hùng',44 );
INSERT INTO Districts VALUES (N'Hạ Hòa',44 );
INSERT INTO Districts VALUES (N'Lâm Thao',44 );
INSERT INTO Districts VALUES (N'Phù Ninh',44 );
INSERT INTO Districts VALUES (N'Phú Thọ',44 );
INSERT INTO Districts VALUES (N'Tam Nông',44 );
INSERT INTO Districts VALUES (N'Tân Sơn',44 );
INSERT INTO Districts VALUES (N'Thanh Ba',44 );
INSERT INTO Districts VALUES (N'Thanh Sơn',44 );
INSERT INTO Districts VALUES (N'Thanh Thủy',44 );
INSERT INTO Districts VALUES (N'Việt Trì',44 );
INSERT INTO Districts VALUES (N'Yên Lập',44 );
INSERT INTO Districts VALUES (N'Đông Hòa',45 );
INSERT INTO Districts VALUES (N'Đồng Xuân',45 );
INSERT INTO Districts VALUES (N'Phú Hòa',45 );
INSERT INTO Districts VALUES (N'Sơn Hòa',45 );
INSERT INTO Districts VALUES (N'Sông Cầu',45 );
INSERT INTO Districts VALUES (N'Sông Hinh',45 );
INSERT INTO Districts VALUES (N'Tây Hòa',45 );
INSERT INTO Districts VALUES (N'Tuy An',45 );
INSERT INTO Districts VALUES (N'Tuy Hòa',45 );
INSERT INTO Districts VALUES (N'Bố Trạch',46 );
INSERT INTO Districts VALUES (N'Đồng Hới',46 );
INSERT INTO Districts VALUES (N'Lệ Thủy',46 );
INSERT INTO Districts VALUES (N'Minh Hóa',46 );
INSERT INTO Districts VALUES (N'Quảng Ninh',46 );
INSERT INTO Districts VALUES (N'Quảng Trạch',46 );
INSERT INTO Districts VALUES (N'Tuyên Hóa',46 );
INSERT INTO Districts VALUES (N'Bắc Trà My',47 );
INSERT INTO Districts VALUES (N'Đại Lộc',47 );
INSERT INTO Districts VALUES (N'Điện Bàn',47 );
INSERT INTO Districts VALUES (N'Đông Giang',47 );
INSERT INTO Districts VALUES (N'Duy Xuyên',47 );
INSERT INTO Districts VALUES (N'Hiệp Đức',47 );
INSERT INTO Districts VALUES (N'Hội An',47 );
INSERT INTO Districts VALUES (N'Nam Giang',47 );
INSERT INTO Districts VALUES (N'Nam Trà My',47 );
INSERT INTO Districts VALUES (N'Núi Thành',47 );
INSERT INTO Districts VALUES (N'Phước Sơn',47 );
INSERT INTO Districts VALUES (N'Quế Sơn',47 );
INSERT INTO Districts VALUES (N'Tam Kỳ',47 );
INSERT INTO Districts VALUES (N'Tây Giang',47 );
INSERT INTO Districts VALUES (N'Thăng Bình',47 );
INSERT INTO Districts VALUES (N'Tiên Phước',47 );
INSERT INTO Districts VALUES (N'Nông Sơn',47 );
INSERT INTO Districts VALUES (N'Ba Tơ',48 );
INSERT INTO Districts VALUES (N'Bình Sơn',48 );
INSERT INTO Districts VALUES (N'Đức Phổ',48 );
INSERT INTO Districts VALUES (N'Lý Sơn',48 );
INSERT INTO Districts VALUES (N'Minh Long',48 );
INSERT INTO Districts VALUES (N'Nghĩa Hành',48 );
INSERT INTO Districts VALUES (N'Quảng Ngãi',48 );
INSERT INTO Districts VALUES (N'Sơn Hà',48 );
INSERT INTO Districts VALUES (N'Sơn Tây',48 );
INSERT INTO Districts VALUES (N'Sơn Tịnh',48 );
INSERT INTO Districts VALUES (N'Tây Trà',48 );
INSERT INTO Districts VALUES (N'Trà Bồng',48 );
INSERT INTO Districts VALUES (N'Tư Nghĩa',48 );
INSERT INTO Districts VALUES (N'Ba Chẽ',49 );
INSERT INTO Districts VALUES (N'Bình Liêu',49 );
INSERT INTO Districts VALUES (N'Cẩm Phả',49 );
INSERT INTO Districts VALUES (N'Cô Tô',49 );
INSERT INTO Districts VALUES (N'Đầm Hà',49 );
INSERT INTO Districts VALUES (N'Đông Triều',49 );
INSERT INTO Districts VALUES (N'Hạ Long',49 );
INSERT INTO Districts VALUES (N'Hải Hà',49 );
INSERT INTO Districts VALUES (N'Hoành Bồ',49 );
INSERT INTO Districts VALUES (N'Móng Cái',49 );
INSERT INTO Districts VALUES (N'Tiên Yên',49 );
INSERT INTO Districts VALUES (N'Uông Bí',49 );
INSERT INTO Districts VALUES (N'Vân Đồn',49 );
INSERT INTO Districts VALUES (N'Yên Hưng',49 );
INSERT INTO Districts VALUES (N'Cam Lộ',50 );
INSERT INTO Districts VALUES (N'Cồn Cỏ',50 );
INSERT INTO Districts VALUES (N'Đa Krông',50 );
INSERT INTO Districts VALUES (N'Đông Hà',50 );
INSERT INTO Districts VALUES (N'Gio Linh',50 );
INSERT INTO Districts VALUES (N'Hải Lăng',50 );
INSERT INTO Districts VALUES (N'Hướng Hóa',50 );
INSERT INTO Districts VALUES (N'Quảng Trị',50 );
INSERT INTO Districts VALUES (N'Triệu Phong',50 );
INSERT INTO Districts VALUES (N'Vĩnh Linh',50 );
INSERT INTO Districts VALUES (N'Châu Thành',51 );
INSERT INTO Districts VALUES (N'Cù Lao Dung',51 );
INSERT INTO Districts VALUES (N'Kế Sách',51 );
INSERT INTO Districts VALUES (N'Long Phú',51 );
INSERT INTO Districts VALUES (N'Mỹ Tú',51 );
INSERT INTO Districts VALUES (N'Mỹ Xuyên',51 );
INSERT INTO Districts VALUES (N'Sóc Trăng',51 );
INSERT INTO Districts VALUES (N'Thạnh Trị',51 );
INSERT INTO Districts VALUES (N'Vĩnh Châu',51 );
INSERT INTO Districts VALUES (N'Bắc Yên',52 );
INSERT INTO Districts VALUES (N'Mai Sơn',52 );
INSERT INTO Districts VALUES (N'Mộc Châu',52 );
INSERT INTO Districts VALUES (N'Mường La',52 );
INSERT INTO Districts VALUES (N'Phù Yên',52 );
INSERT INTO Districts VALUES (N'Quỳnh Nhai',52 );
INSERT INTO Districts VALUES (N'Sơn La',52 );
INSERT INTO Districts VALUES (N'Sông Mã',52 );
INSERT INTO Districts VALUES (N'Sốp Cộp',52 );
INSERT INTO Districts VALUES (N'Thuận Châu',52 );
INSERT INTO Districts VALUES (N'Yên Châu',52 );
INSERT INTO Districts VALUES (N'Bến Cầu',53 );
INSERT INTO Districts VALUES (N'Châu Thành',53 );
INSERT INTO Districts VALUES (N'Dương Minh Châu',53 );
INSERT INTO Districts VALUES (N'Gò Dầu',53 );
INSERT INTO Districts VALUES (N'Hòa Thành',53 );
INSERT INTO Districts VALUES (N'Tân Biên',53 );
INSERT INTO Districts VALUES (N'Tân Châu',53 );
INSERT INTO Districts VALUES (N'Tây Ninh',53 );
INSERT INTO Districts VALUES (N'Trảng Bàng',53 );
INSERT INTO Districts VALUES (N'Đông Hưng',54 );
INSERT INTO Districts VALUES (N'Hưng Hà',54 );
INSERT INTO Districts VALUES (N'Kiến Xương',54 );
INSERT INTO Districts VALUES (N'Quỳnh Phụ',54 );
INSERT INTO Districts VALUES (N'Thái Bình',54 );
INSERT INTO Districts VALUES (N'Thái Thụy',54 );
INSERT INTO Districts VALUES (N'Tiền Hải',54 );
INSERT INTO Districts VALUES (N'Vũ Thư',54 );
INSERT INTO Districts VALUES (N'Đại Từ',55 );
INSERT INTO Districts VALUES (N'Định Hóa',55 );
INSERT INTO Districts VALUES (N'Đồng Hỷ',55 );
INSERT INTO Districts VALUES (N'Phổ Yên',55 );
INSERT INTO Districts VALUES (N'Phú Bình',55 );
INSERT INTO Districts VALUES (N'Phú Lương',55 );
INSERT INTO Districts VALUES (N'Sông Công',55 );
INSERT INTO Districts VALUES (N'Thái Nguyên',55 );
INSERT INTO Districts VALUES (N'Võ Nhai',55 );
INSERT INTO Districts VALUES (N'Bá Thước',56 );
INSERT INTO Districts VALUES (N'Bỉm Sơn',56 );
INSERT INTO Districts VALUES (N'Cẩm Thủy',56 );
INSERT INTO Districts VALUES (N'Đông Sơn',56 );
INSERT INTO Districts VALUES (N'Hà Trung',56 );
INSERT INTO Districts VALUES (N'Hậu Lộc',56 );
INSERT INTO Districts VALUES (N'Hoằng Hóa',56 );
INSERT INTO Districts VALUES (N'Lang Chánh',56 );
INSERT INTO Districts VALUES (N'Mường Lát',56 );
INSERT INTO Districts VALUES (N'Ngọc Lặc',56 );
INSERT INTO Districts VALUES (N'Như Thanh',56 );
INSERT INTO Districts VALUES (N'Như Xuân',56 );
INSERT INTO Districts VALUES (N'Nông Cống',56 );
INSERT INTO Districts VALUES (N'Quan Hóa',56 );
INSERT INTO Districts VALUES (N'Quan Sơn',56 );
INSERT INTO Districts VALUES (N'Quảng Xương',56 );
INSERT INTO Districts VALUES (N'Sầm Sơn',56 );
INSERT INTO Districts VALUES (N'Thạch Thành',56 );
INSERT INTO Districts VALUES (N'Thanh Hóa',56 );
INSERT INTO Districts VALUES (N'Thiệu Hóa',56 );
INSERT INTO Districts VALUES (N'Thọ Xuân',56 );
INSERT INTO Districts VALUES (N'Thường Xuân',56 );
INSERT INTO Districts VALUES (N'Tĩnh Gia',56 );
INSERT INTO Districts VALUES (N'Triệu Sơn',56 );
INSERT INTO Districts VALUES (N'Vĩnh Lộc',56 );
INSERT INTO Districts VALUES (N'Yên Định',56 );
INSERT INTO Districts VALUES (N'A Lưới',57 );
INSERT INTO Districts VALUES (N'Huế',57 );
INSERT INTO Districts VALUES (N'Hương Thủy',57 );
INSERT INTO Districts VALUES (N'Hương Trà',57 );
INSERT INTO Districts VALUES (N'Nam Đông',57 );
INSERT INTO Districts VALUES (N'Phong Điền',57 );
INSERT INTO Districts VALUES (N'Phú Lộc',57 );
INSERT INTO Districts VALUES (N'Phú Vang',57 );
INSERT INTO Districts VALUES (N'Quảng Điền',57 );
INSERT INTO Districts VALUES (N'Cái Bè',58 );
INSERT INTO Districts VALUES (N'Cai Lậy',58 );
INSERT INTO Districts VALUES (N'Châu Thành',58 );
INSERT INTO Districts VALUES (N'Chợ Gạo',58 );
INSERT INTO Districts VALUES (N'Gò Công',58 );
INSERT INTO Districts VALUES (N'Gò Công Dông',58 );
INSERT INTO Districts VALUES (N'Gò Công Tây',58 );
INSERT INTO Districts VALUES (N'Mỹ Tho',58 );
INSERT INTO Districts VALUES (N'Tân Phước',58 );
INSERT INTO Districts VALUES (N'Càng Long',59 );
INSERT INTO Districts VALUES (N'Cầu Kè',59 );
INSERT INTO Districts VALUES (N'Cầu Ngang',59 );
INSERT INTO Districts VALUES (N'Châu Thành',59 );
INSERT INTO Districts VALUES (N'Duyên Hải',59 );
INSERT INTO Districts VALUES (N'Tiểu Cần',59 );
INSERT INTO Districts VALUES (N'Trà Cú',59 );
INSERT INTO Districts VALUES (N'Trà Vinh',59 );
INSERT INTO Districts VALUES (N'Chiêm Hóa',60 );
INSERT INTO Districts VALUES (N'Hàm Yên',60 );
INSERT INTO Districts VALUES (N'Nà Hang',60 );
INSERT INTO Districts VALUES (N'Sơn Dương',60 );
INSERT INTO Districts VALUES (N'Tuyên Quang',60 );
INSERT INTO Districts VALUES (N'Yên Sơn',60 );
INSERT INTO Districts VALUES (N'Bình Minh',61 );
INSERT INTO Districts VALUES (N'Bình Tân',61 );
INSERT INTO Districts VALUES (N'Long Hồ',61 );
INSERT INTO Districts VALUES (N'Mang Thít',61 );
INSERT INTO Districts VALUES (N'Tâm Bình',61 );
INSERT INTO Districts VALUES (N'Trà Ôn',61 );
INSERT INTO Districts VALUES (N'Vĩnh Long',61 );
INSERT INTO Districts VALUES (N'Vũng Liêm',61 );
INSERT INTO Districts VALUES (N'Bình Xuyên',62 );
INSERT INTO Districts VALUES (N'Lập Thạch',62 );
INSERT INTO Districts VALUES (N'Phúc Yên',62 );
INSERT INTO Districts VALUES (N'Tam Đảo',62 );
INSERT INTO Districts VALUES (N'Tam Dương',62 );
INSERT INTO Districts VALUES (N'Vĩnh Tường',62 );
INSERT INTO Districts VALUES (N'Vĩnh Yên',62 );
INSERT INTO Districts VALUES (N'Yên Lạc',62 );
INSERT INTO Districts VALUES (N'Lục Yên',63 );
INSERT INTO Districts VALUES (N'Mù Cang Chải',63 );
INSERT INTO Districts VALUES (N'Nghĩa Lộ',63 );
INSERT INTO Districts VALUES (N'Trạm Tấu',63 );
INSERT INTO Districts VALUES (N'Trấn Yên',63 );
INSERT INTO Districts VALUES (N'Văn Chấn',63 );
INSERT INTO Districts VALUES (N'Văn Yên',63 );
INSERT INTO Districts VALUES (N'Yên Bái',63 );
INSERT INTO Districts VALUES (N'Yên Bình',63 );
COMMIT TRANSACTION;