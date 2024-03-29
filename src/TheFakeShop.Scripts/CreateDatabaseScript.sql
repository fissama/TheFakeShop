﻿CREATE DATABASE TheFakeShop;

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

CREATE TABLE OrderHeader (
	OrderID INT IDENTITY(1,1) PRIMARY KEY,
	Phone VARCHAR(10),
	CustomerEmail VARCHAR(50),
	Cost MONEY,
	FullAddress NVARCHAR(200),
	Created_at DATETIME NOT NULL DEFAULT (CURRENT_TIMESTAMP)
);

CREATE TABLE OrderDetail (
	OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
	Qty INT,
	ProductID INT,
	OrderID INT,
	FOREIGN KEY(OrderID) REFERENCES OrderHeader(OrderID),
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
); 

ALTER TABLE OrderHeader
ADD OrderStatus VARCHAR(2);