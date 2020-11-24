CREATE TABLE [dbo].[TrainingSpecialization]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(500) NOT NULL,
	[IsSingle] BIT NOT NULL,
	Isgroup BIT NOT NULL,
	CONSTRAINT PK_TrainingSpecialization PRIMARY KEY ([Id])
)
