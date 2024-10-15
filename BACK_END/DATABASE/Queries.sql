CREATE DATABASE MotorBikeRentalManagement
GO

USE MotorBikeRentalManagement;
GO

CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserName NVARCHAR(100),
	Password_hash NVARCHAR(100),
	Email NVARCHAR(100),
	User_Type NVARCHAR(100),
	Created_Data DATETIME,
	Last_Login DATETIME,
	Is_Active NVARCHAR(50)
);
GO

SELECT * FROM Users;
GO

CREATE TABLE Admins(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Users_Id INT,
	First_Name NVARCHAR(50),
	Last_Name NVARCHAR(50),
	Phone_Number NVARCHAR(50),
	Emergency_Contact NVARCHAR(50),
	Hire_Date DATE ,
	Position NVARCHAR(50),
	Salary DECIMAL(10,2),
	FOREIGN KEY (Users_Id) REFERENCES Users(Id)
);
GO

SELECT * FROM Admins;
GO

CREATE TABLE Category(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Category_Name NVARCHAR(40),
	Description NVARCHAR(50),
	Base_Price DECIMAL (10,2),
	License_Type_Required NVARCHAR(50)
);
GO

SELECT * FROM Category;
GO

CREATE TABLE MotorBikes(
	Registration_Number NVARCHAR(50) PRIMARY KEY,
	Category_Id INT,
	Brand NVARCHAR(100),
	Model NVARCHAR(100),
	Manufactured_Year INT,
	Engine_Capacity INT,
	Fuel_Type NVARCHAR(50),
	Daily_Rate DECIMAL(10,2),
	Status NVARCHAR(40),
	Mile_Age INT,
	Last_Serviced DATE,
	Insurance_Policy_Number NVARCHAR(50),
	Insurance_Expiry DATE
	FOREIGN KEY (Category_Id) REFERENCES Category(Id)
);
GO

SELECT * FROM MotorBikes;
GO

CREATE TABLE Customers(
	Nic_Number NVARCHAR(40)  PRIMARY KEY,
	Users_Id INT,
	First_Name NVARCHAR(50),
	Last_Name NVARCHAR(50),
	Phone_Number NVARCHAR(40),
	Address NVARCHAR(100),
	City NVARCHAR(50),
	Country NVARCHAR(50),
	Postal_Code NVARCHAR(50),
	Date_Of_Birth NVARCHAR(50),
	Driving_License_Number NVARCHAR(50),
	Driving_License_Expiry NVARCHAR(50),
	Registration_Date DATE,
	Is_BlackListed BIT,
	Blacklist_Reason NVARCHAR(50)
	FOREIGN KEY (Users_Id) REFERENCES Users(Id)
)
GO

SELECT * FROM Customers;
GO

DROP TABLE Customers;

CREATE TABLE Rentals(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nic_Number NVARCHAR(40),
	Registration_Number NVARCHAR(50),
	Rent_Date DATETIME,
	Due_Date DATETIME,
	Status NVARCHAR(50),
	Total_Cost DECIMAL(10,2),
	Deposit_Amount DECIMAL (10, 2),
	Pickup_Location NVARCHAR(50),
	Return_Location NVARCHAR(50),
	Initial_Milage INT,
	Return_Milage INT,
	Damage_Notes NVARCHAR(50),
	Additional_Charges DECIMAL(10,2),
	Payment_Method NVARCHAR(50),
	Payment_Status NVARCHAR(50),
	FOREIGN KEY (Nic_Number) REFERENCES Customers(Nic_Number),
	FOREIGN KEY (Registration_Number) REFERENCES MotorBikes(Registration_Number)
)
GO

SELECT * FROM Rentals;
GO

CREATE TABLE Review(
	Review_Id INT IDENTITY(1,1) PRIMARY KEY,
	Rental_Id INT,
	FOREIGN KEY (Rental_Id) REFERENCES Rentals(Id),
	Nic_Number NVARCHAR(40),
	FOREIGN KEY (Nic_Number) REFERENCES Customers(Nic_Number),
	Rating INT,
	Comment NVARCHAR(MAX),
	Review_Date DATE,
	Is_Approved BIT,
	Admin_Reponse NVARCHAR(MAX)
)
GO

CREATE TABLE WaitLists(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nic_Number NVARCHAR(40),
	FOREIGN KEY (Nic_Number) REFERENCES Customers(Nic_Number),
	Registration_Number NVARCHAR(50),
	FOREIGN KEY (Registration_Number) REFERENCES MotorBikes(Registration_Number),
	Request_Date DATETIME,
	Expiry_Date DATETIME,
	Status NVARCHAR(100),
	Position_In_Queue INT
);
GO
