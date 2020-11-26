CREATE TABLE [dbo].[TrainingSpecialization]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50),
	[Description] NVARCHAR(500),
	[IsSingle] BIT,
	Isgroup BIT,
	CONSTRAINT PK_TrainingSpecialization PRIMARY KEY ([Id])
)
