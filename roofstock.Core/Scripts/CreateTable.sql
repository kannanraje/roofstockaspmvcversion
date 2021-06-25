/*
CREATE DATABASE TEST;
GO

USE TEST
CREATE TABLE Properties (
    PropertyId BIGINT NOT NULL PRIMARY KEY,
	AccountId BIGINT NOT NULL,
    MainImageUrl NVARCHAR(500) ,
    Yearbuilt INT,
    ListPrice DECIMAL(12,4),
	MonthlyRent DECIMAL(12,4),
	GrossYield  DECIMAL(12,4)	
)

CREATE TABLE Address (
    Idx INT IDENTITY(1,1) PRIMARY KEY, 
	Address1 VARCHAR(255),
    Address2 VARCHAR(255),
    City VARCHAR(25),
    Country VARCHAR(25),
    County VARCHAR(25),
    District VARCHAR(50),
    [State] VARCHAR(25),
    Zip VARCHAR(10),
    ZipPlus4 VARCHAR(25),
	PropertyId BIGINT NOT NULL references Properties(PropertyId),
)

CREATE TABLE Photos
(
PhotoId INT IDENTITY(1,1) PRIMARY KEY,
ResourceType VARCHAR(50),
[FileName] VARCHAR(50),
ContentType VARCHAR(50),
[Url] NVARCHAR(500),
UrlMedium NVARCHAR(500),
UrlSmall NVARCHAR(500),
Description VARCHAR(250),
PropertyId BIGINT NOT NULL references Properties(PropertyId),
)
