﻿CREATE TABLE [dbo].[Alergias] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Nome]      VARCHAR (50)     NOT NULL,
    [Descricao] VARCHAR (MAX)    NOT NULL,
    CONSTRAINT [PK_ALERGIAS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

