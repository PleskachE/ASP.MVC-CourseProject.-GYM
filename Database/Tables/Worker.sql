CREATE TABLE [dbo].[Worker] (
    [Id]                    INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]             NVARCHAR (50) NOT NULL,
    [LastName]              NVARCHAR (50) NOT NULL,
    [Birthdate]             DATETIME      NOT NULL,
    [ContactPhoneNumber]    NVARCHAR (50) NOT NULL,
    [Emeil]                 NVARCHAR (50) NOT NULL,
    [Login]                 NVARCHAR (50) NOT NULL,
    [Password]              NVARCHAR (50) NOT NULL,
    [RolesId]               INT           NOT NULL,
    [ListSpecializationsId] INT           NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([Id] ASC)
);


