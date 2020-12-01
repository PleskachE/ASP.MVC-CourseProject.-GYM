CREATE TABLE [dbo].[WorkSpecialization]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[UserId] INT,
	[SpecializationId] INT,
	CONSTRAINT PK_WorkSpecialization PRIMARY KEY ([Id])
)
