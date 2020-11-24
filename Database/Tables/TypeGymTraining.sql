CREATE TABLE [dbo].[TypeGymTraining]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[TrainingGymId] INT NOT NULL,
	[TrainingSpecializationId] INT NOT NULL,
	CONSTRAINT PK_TypeGymTraining PRIMARY KEY ([Id])
)
