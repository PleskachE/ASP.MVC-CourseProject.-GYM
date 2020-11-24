CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Birthdate] DATETIME NOT NULL,
	[ContactPhoneNumber] NVARCHAR(50) NOT NULL,
	[Emeil] NVARCHAR(50) NOT NULL,
	[Login] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	[SubscriptionNumber] INT NOT NULL,
	[RolesId] INT,
	CONSTRAINT PK_Client PRIMARY KEY ([Id])
)
