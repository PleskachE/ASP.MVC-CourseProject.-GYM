CREATE TABLE [dbo].[Training]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[HallId] INT,
	[UserId] INT,
	[SpecializationId] INT,
	[StartTime] DATETIME,
	[EndTime] DATETIME,
	[CountTrainees] INT,
	CONSTRAINT PK_Training PRIMARY KEY ([Id])
)
