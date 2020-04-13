CREATE TABLE [dbo].[Pet] (
    [RacaId]            INT              NOT NULL,
    [Nome]              VARCHAR (100)    NOT NULL,
    [Porte]             CHAR (1)         NOT NULL,
    [Observacoes]       VARCHAR (MAX)    NULL,
    [PermiteDivulgacao] BIT              NOT NULL,
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PET] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PET_REFERENCE_CLIENTE] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Cliente] ([Id]),
    CONSTRAINT [FK_PET_REFERENCE_RACA] FOREIGN KEY ([RacaId]) REFERENCES [dbo].[Raca] ([Id])
);

