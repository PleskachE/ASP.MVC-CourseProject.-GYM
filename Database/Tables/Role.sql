﻿CREATE TABLE [dbo].[Role]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Role PRIMARY KEY ([Id])
)