CREATE TABLE [dbo].[Hall]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50),
	[Description] NVARCHAR(500),
	[MaxCountTrainees] INT,
	CONSTRAINT PK_Hall PRIMARY KEY ([Id])
)
