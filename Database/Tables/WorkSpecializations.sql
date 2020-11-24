CREATE TABLE [dbo].[WorkSpecializations]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[WorkerId] INT NOT NULL,
	[TrainingSpecializationId] INT,
	CONSTRAINT PK_WorkSpecializations PRIMARY KEY ([Id])
)
