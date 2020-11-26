CREATE TABLE [dbo].[Training]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[TrainingGymId] INT,
	[UserId] INT,
	[TrainingSpecializationId] INT,
	[StartTime] DATETIME,
	[EndTime] DATETIME,
	CONSTRAINT PK_Training PRIMARY KEY ([Id])
)
