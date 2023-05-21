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
       ('Donuts');

GO

INSERT INTO Ingredient (Name)
VALUES ('Flour'),
       ('Sugar'),
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