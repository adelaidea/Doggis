﻿CREATE TABLE [dbo].[AlergiaPet] (
    [IdAlergia] INT NOT NULL,
    [PetId]     UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_ALERGIAPET] PRIMARY KEY CLUSTERED ([IdAlergia] ASC, [PetId] ASC),
    CONSTRAINT [FK_ALERGIAP_REFERENCE_ALERGIAS] FOREIGN KEY ([IdAlergia]) REFERENCES [dbo].[Alergia] ([Id]),
    CONSTRAINT [FK_ALERGIAP_REFERENCE_PET] FOREIGN KEY ([PetId]) REFERENCES [dbo].[Pet] ([Id])
);

