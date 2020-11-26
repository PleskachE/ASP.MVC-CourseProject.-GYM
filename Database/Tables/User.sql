CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[FirstName] NVARCHAR(50),
	[LastName] NVARCHAR(50),
	[Birthdate] DATETIME,
	[ContactPhoneNumber] NVARCHAR(50),
	[Emeil] NVARCHAR(50),
	[Login] NVARCHAR(50),
	[Password] NVARCHAR(50),
	[RolesId] INT,
	CONSTRAINT PK_User PRIMARY KEY ([Id])
)
