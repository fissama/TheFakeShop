CREATE DATABASE TheFakeShop;

USE TheFakeShop;

CREATE TABLE Categories (
	CategoryID INT NOT NULL,
	CategoryName NVARCHAR(100),
	ParentID INT,
	Modified_at TIMESTAMP,
	PRIMARY KEY(CategoryID),
	FOREIGN KEY(ParentID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Products (
	ProductID INT NOT NULL,
	ProductName NVARCHAR(200),
	Price MONEY,
	InStock INT,
	Description VARCHAR(1000),
	CategoryID INT,
	Modified_at TIMESTAMP,
	PRIMARY KEY(ProductID),
	FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE ProductImages (
	PImageID INT NOT NULL,
	ImageLink VARCHAR(100),
	ProductID INT,
	Modified_at TIMESTAMP,
	PRIMARY KEY(PImageID),
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE ProductRatings (
	PRatingID INT NOT NULL,
	CustomerName NVARCHAR(20), --3~20 character
	CustomerEmail VARCHAR(50),
	Rating TINYINT,
	Title NVARCHAR(50),
	Content NVARCHAR(500),
	ProductID INT,
	Modified_at TIMESTAMP,
	PRIMARY KEY(PRatingID),
	FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Cities (
	CityID INT NOT NULL,
	CityName NVARCHAR(30),
	PRIMARY KEY(CityID)
);

CREATE TABLE Districts (
	DistrictID INT NOT NULL,
	DistrictName NVARCHAR(30),
	CityID INT,
	PRIMARY KEY(DistrictID)
);

CREATE TABLE Account (
	AccountID INT NOT NULL,
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
	PRIMARY KEY(AccountID),
	FOREIGN KEY(DistrictID) REFERENCES Districts(DistrictID)
);

CREATE TABLE Admin (
	AdminID INT NOT NULL,
	FirstName NVARCHAR(40),
	LastName NVARCHAR(25),
	Email VARCHAR(50),
	Password VARCHAR(50),
	Remember_token VARCHAR(100),
	Modified_at TIMESTAMP,
	PRIMARY KEY(AdminID)
);