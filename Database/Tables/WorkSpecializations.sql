CREATE TABLE [dbo].[WorkSpecializations]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[UserId] INT,
	[TrainingSpecializationId] INT,
	CONSTRAINT PK_WorkSpecializations PRIMARY KEY ([Id])
)
