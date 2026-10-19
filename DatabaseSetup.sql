USE master;
GO
IF DB_ID('VehicleRentDB') IS NULL EXEC('CREATE DATABASE VehicleRentDB');
GO
USE VehicleRentDB;
GO

IF OBJECT_ID('dbo.UserInfo','U') IS NULL
CREATE TABLE dbo.UserInfo(
 UserID INT IDENTITY(1,1) PRIMARY KEY, Username VARCHAR(50) NOT NULL UNIQUE,
 Password VARCHAR(100) NOT NULL, Role VARCHAR(20) NOT NULL CHECK(Role IN('Admin','Customer')),
 IsActive BIT NOT NULL CONSTRAINT DF_UserInfo_IsActive DEFAULT(1));
GO
IF OBJECT_ID('dbo.Customers','U') IS NULL
CREATE TABLE dbo.Customers(
 CustomerID INT IDENTITY(1,1) PRIMARY KEY, UserID INT NOT NULL UNIQUE,
 CustomerName VARCHAR(100) NOT NULL, Phone VARCHAR(20) NOT NULL, Email VARCHAR(100) NULL,
 Address VARCHAR(250) NULL, DrivingLicenseNumber VARCHAR(50) NOT NULL UNIQUE,
 LicenseExpiryDate DATE NOT NULL, CustomerStatus VARCHAR(20) NOT NULL DEFAULT('Active') CHECK(CustomerStatus IN('Active','Inactive')),
 CONSTRAINT FK_Customers_UserInfo FOREIGN KEY(UserID) REFERENCES dbo.UserInfo(UserID));
GO
IF OBJECT_ID('dbo.Vehicles','U') IS NULL
CREATE TABLE dbo.Vehicles(
 VehicleID INT IDENTITY(1,1) PRIMARY KEY, RegistrationNumber VARCHAR(30) NOT NULL UNIQUE,
 Brand VARCHAR(60) NOT NULL, Model VARCHAR(60) NOT NULL, VehicleYear INT NOT NULL,
 VehicleType VARCHAR(30) NOT NULL, Color VARCHAR(30) NULL, DailyRentalPrice DECIMAL(12,2) NOT NULL,
 VehicleStatus VARCHAR(30) NOT NULL DEFAULT('Available') CHECK(VehicleStatus IN('Available','Rented','Under Maintenance')),
 CONSTRAINT CK_Vehicles_Price CHECK(DailyRentalPrice>0));
GO
IF OBJECT_ID('dbo.Rentals','U') IS NULL
CREATE TABLE dbo.Rentals(
 RentalID INT IDENTITY(1,1) PRIMARY KEY, CustomerID INT NOT NULL, VehicleID INT NOT NULL,
 RentalDate DATE NOT NULL, ReturnDate DATE NOT NULL, ActualReturnDate DATE NULL,
 RentalDuration INT NOT NULL, PricePerDay DECIMAL(12,2) NOT NULL, LateCharge DECIMAL(12,2) NOT NULL DEFAULT(0),
 TotalCost DECIMAL(12,2) NOT NULL, RentalStatus VARCHAR(20) NOT NULL DEFAULT('Booked'), CreatedAt DATETIME NOT NULL DEFAULT(GETDATE()),
 CONSTRAINT FK_Rentals_Customers FOREIGN KEY(CustomerID) REFERENCES dbo.Customers(CustomerID),
 CONSTRAINT FK_Rentals_Vehicles FOREIGN KEY(VehicleID) REFERENCES dbo.Vehicles(VehicleID),
 CONSTRAINT CK_Rentals_Dates CHECK(ReturnDate>=RentalDate),
 CONSTRAINT CK_Rentals_Status CHECK(RentalStatus IN('Booked','Active','Returned','Cancelled')));
GO
IF OBJECT_ID('dbo.Payments','U') IS NULL
CREATE TABLE dbo.Payments(
 PaymentID INT IDENTITY(1,1) PRIMARY KEY, RentalID INT NOT NULL UNIQUE,
 PaymentDate DATETIME NULL, Amount DECIMAL(12,2) NOT NULL, PaymentMethod VARCHAR(30) NULL,
 PaymentStatus VARCHAR(20) NOT NULL DEFAULT('Pending'),
 CONSTRAINT FK_Payments_Rentals FOREIGN KEY(RentalID) REFERENCES dbo.Rentals(RentalID),
 CONSTRAINT CK_Payments_Method CHECK(PaymentMethod IS NULL OR PaymentMethod IN('Cash','Credit Card','Debit Card','Online Payment')),
 CONSTRAINT CK_Payments_Status CHECK(PaymentStatus IN('Pending','Paid')));
GO

IF NOT EXISTS(SELECT 1 FROM dbo.UserInfo WHERE Username='admin')
 INSERT dbo.UserInfo(Username,Password,Role,IsActive) VALUES('admin','admin123','Admin',1);
GO
IF NOT EXISTS(SELECT 1 FROM dbo.Vehicles)
BEGIN
 INSERT dbo.Vehicles(RegistrationNumber,Brand,Model,VehicleYear,VehicleType,Color,DailyRentalPrice,VehicleStatus) VALUES
 ('DHAKA-METRO-GA-11-1001','Toyota','Axio',2020,'Car','White',1500,'Available'),
 ('DHAKA-METRO-GA-11-1002','Honda','Civic',2021,'Car','Black',2000,'Available'),
 ('DHAKA-METRO-CHA-12-2001','Toyota','Hiace',2019,'Van','Silver',3000,'Available'),
 ('DHAKA-METRO-LA-13-3001','Yamaha','FZ-S',2022,'Motorcycle','Blue',800,'Available');
END
GO
PRINT 'VehicleRentDB setup completed. Admin login: admin / admin123';
