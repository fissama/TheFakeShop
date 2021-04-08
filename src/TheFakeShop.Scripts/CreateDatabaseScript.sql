CREATE DATABASE TheFakeShop;

USE TheFakeShop;

CREATE TABLE Categories (
	CategoryID INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName NVARCHAR(100),
	ParentID INT,
	Created_at DATETIME NOT NULL DEFAULT (CURRENT_TIMESTAMP),
	FOREIGN KEY(ParentID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Products (
	ProductID INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(200),
	Price MONEY,
	InStock INT,
	Description NVARCHAR(2000),
	CategoryID INT,
	Created_at DATETIME NOT NULL DEFAULT (CURRENT_TIMESTAMP),
	FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE ProductImages (
	PImageID INT IDENTITY(1,1) PRIMARY KEY,
	ImageLink VARCHAR(500),
	ProductID INT,
	Created_at DATETIME NOT NULL DEFAULT (CURRENT_TIMESTAMP),
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
	Created_at DATETIME NOT NULL DEFAULT (CURRENT_TIMESTAMP),
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

--INSERT CATEGORIES
BEGIN TRANSACTION
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dưỡng Da',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Làm Sạch',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm Nền',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chăm Sóc Cơ Thể',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phụ Kiện',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Mặt Nạ',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Nước Cân Bằng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Xịt Khoáng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tinh Chất Dưỡng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Dưỡng Da Mặt',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Chống Nắng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sữa Rửa Mặt',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Tẩy Trang',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tẩy Trang Mắt Và Môi',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Làm Sạch Tế Bào Chết',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phấn Nước Cushion',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Nền Foundation',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Lót',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tạo Khối/ Tạo Sáng',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Che Khuyết Điểm',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Nền Đa Năng BB/ CC Cream',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Son',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm Mắt',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Má Hồng',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Màu Mắt',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chân Mày',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Mascara',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sữa Tắm',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Dưỡng Thể',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Làm Sạch Tế Bào Chết Cơ Thể',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chăm Sóc Tóc',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Dưỡng Tay/ Chân',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Nước Hoa',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Cọ Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Bông Mút Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dụng Cụ Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phụ Kiện Làm Sạch',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dụng Cụ Massage',6);
COMMIT TRANSACTION
