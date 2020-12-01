CREATE TABLE [dbo].[Session]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[UserId] INT,
	[TrainingId] INT,
	CONSTRAINT PK_Session PRIMARY KEY ([Id])
)
