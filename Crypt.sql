USE Crypt;
CREATE TABLE Client (
    [ID] int,
    [LastName] varchar(255),
    [FirstName] varchar(255)
    
);
CREATE TABLE Crypt_History (
    [CryptName] varchar(255),
	[History] datetime
    
);
CREATE TABLE CryptCurrency (
    [Name] varchar(255),
	[Price] int,
	[Abv] varchar(255) 
);