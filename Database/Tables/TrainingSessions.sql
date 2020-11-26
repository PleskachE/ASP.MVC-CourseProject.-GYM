CREATE TABLE [dbo].[TrainingSessions]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[UserId] INT,
	[TrainingId] INT,
	CONSTRAINT PK_TrainingSessions PRIMARY KEY ([Id])
)
