CREATE TABLE [dbo].[TypeGymTraining]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[TrainingGymId] INT,
	[TrainingSpecializationId] INT,
	CONSTRAINT PK_TypeGymTraining PRIMARY KEY ([Id])
)
