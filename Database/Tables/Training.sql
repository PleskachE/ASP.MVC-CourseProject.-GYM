CREATE TABLE [dbo].[Training]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[TrainingGymId] INT NOT NULL,
	[WorkerId] INT NOT NULL,
	[TrainingSpecializationId] INT NOT NULL,
	[StartTime] DATETIME NOT NULL,
	[EndTime] DATETIME NOT NULL,
	CONSTRAINT PK_Training PRIMARY KEY ([Id])
)
