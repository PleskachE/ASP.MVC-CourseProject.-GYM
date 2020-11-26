CREATE TABLE [dbo].[TrainingGym]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50),
	[Description] NVARCHAR(500),
	CONSTRAINT PK_TrainingGym PRIMARY KEY ([Id])
)
