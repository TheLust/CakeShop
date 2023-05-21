USE MASTER;

GO

DROP DATABASE IF EXISTS CakeShopDB;

GO

CREATE DATABASE CakeShopDB;

GO

USE CakeShopDB;

GO

-- TABLES 

CREATE TABLE ProductType(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

CREATE TABLE Color(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

CREATE TABLE Ingredient(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

CREATE TABLE Product(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	ProductType INT FOREIGN KEY REFERENCES ProductType(Id) NOT NULL,
	"Name" VARCHAR(255) UNIQUE NOT NULL,
	Mass INT NOT NULL,
	Color INT FOREIGN KEY REFERENCES Color(Id) NOT NULL,
	Price FLOAT NOT NULL,
	Stock INT NOT NULL,
);

GO

CREATE TABLE ProductIngredient(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Product INT FOREIGN KEY REFERENCES Product(Id) NOT NULL,
	Ingredient INT FOREIGN KEY REFERENCES Ingredient(Id) NOT NULL,
	Quantity INT NOT NULL
);

-- /TABLES

GO

-- INSERTS

INSERT INTO ProductType (Name)
VALUES ('Cake'),
	   ('Cupcake'),
       ('Cookie'),
       ('Pastry'),
       ('Muffin'),
       ('Brownie'),
       ('Caramel'),
       ('Zephyr'),
       ('Donuts');

GO

INSERT INTO Ingredient (Name)
VALUES ('Flour'),
       ('Sugar'),
       ('Honey'),
       ('Butter'),
       ('Eggs'),
       ('Milk'),
       ('Baking Powder'),
       ('Vanilla Extract'),
       ('Salt'),
       ('Chocolate Chips'),
       ('Baking Soda'),
       ('Cocoa Powder'),
       ('Nuts (optional)'),
       ('Filling (e.g., Fruit, Custard)'),
       ('Additional Flavorings or Fillings'),
       ('Oil for frying'),
       ('Powdered Sugar (for coating)');

GO

INSERT INTO Color (Name)
VALUES ('Red'),
       ('Orange'),
       ('Yellow'),
       ('Green'),
       ('Blue'),
       ('Purple'),
       ('Pink'),
       ('Brown'),
       ('Black'),
       ('White');

GO

-- /INSERTS

-- TASKS

-- 1. done
-- 2. done
-- 3.

CREATE VIEW task3 AS
SELECT TOP 1 p.Name AS Product, pt.Name AS ProductType, p.Price FROM Product p
INNER JOIN ProductType pt ON p.ProductType = pt.Id
WHERE pt.Name = 'Caramel'
ORDER BY p.Price ASC;

GO

-- 4.

CREATE VIEW task4 AS
SELECT TOP 999 p.Name as Product, i.Name as Ingredient, p.Price FROM Product p
INNER JOIN ProductIngredient p2 ON p.Id = p2.Product
INNER JOIN Ingredient i ON p2.Ingredient = i.Id
WHERE i.Name = 'Sugar' OR i.Name = 'Honey' OR i.Name = 'Powdered Sugar (for coating)'
ORDER BY p.Price DESC;

GO

-- 5.

CREATE VIEW task5 AS
SELECT p.Name as Product, i.Name as Ingredient, p2.Quantity FROM Product p
INNER JOIN ProductIngredient p2 ON p.Id = p2.Product
INNER JOIN Ingredient i ON p2.Ingredient = i.Id
WHERE i.Name = 'Chocolate Chips';

GO

-- 6.

CREATE VIEW task6 AS
SELECT p.Name AS Product, i.Name AS Ingredient, p2.Quantity FROM Product p
INNER JOIN ProductIngredient p2 ON p.Id = p2.Product
INNER JOIN Ingredient i ON p2.Ingredient = i.Id;

GO

--7.

CREATE VIEW task7 AS
SELECT p.Name AS Product, pt.Name AS ProductType, c.Name AS Color FROM Product p
INNER JOIN ProductType pt ON p.ProductType = pt.Id
INNER JOIN Color c ON c.Id = p.Color
WHERE pt.Name = 'Zephyr' AND c.Name = 'Pink';

GO

-- 8.

CREATE VIEW task8 AS 
SELECT AVG(Price) AS AvgPrice FROM Product;

GO

-- 9.

CREATE VIEW task9 AS
SELECT p.Name as Product, p.Mass, p.Price, p.Stock FROM Product p
WHERE p.Name NOT IN (
        SELECT p.Name as Product FROM Product p
        INNER JOIN ProductIngredient p2 ON p.Id = p2.Product
        INNER JOIN Ingredient i ON p2.Ingredient = i.Id
        WHERE i.Name = 'Sugar' OR i.Name = 'Honey' OR i.Name = 'Powdered Sugar (for coating)'
        );

GO

-- 10.

CREATE VIEW task10 AS
SELECT TOP 10 p.Name as Product, p.Mass, p.Price, p.Stock, CONVERT(FLOAT, (p.Stock * p.Mass / 1000)) AS Kg 
FROM Product p 
ORDER BY p.Stock ASC

-- /TASKS