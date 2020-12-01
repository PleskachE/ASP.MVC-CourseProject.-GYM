CREATE TABLE [dbo].[HallSpecialization]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[HallId] INT,
	[SpecializationId] INT,
	CONSTRAINT PK_HallSpecialization PRIMARY KEY ([Id])
)
