CREATE TABLE [dbo].[TrainingSessions]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[ClientId] INT NOT NULL,
	[TrainingId] INT NOT NULL,
	CONSTRAINT PK_TrainingSessions PRIMARY KEY ([Id])
)
