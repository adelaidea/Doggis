CREATE TABLE [dbo].[Pet] (
    [IdTipoPet]            INT NOT NULL,
    [IdRaca]            INT              NOT NULL,
    [Nome]              VARCHAR (100)    NOT NULL,
    [Porte]             CHAR (1)         NOT NULL,
    [Observacoes]       VARCHAR (MAX)    NULL,
    [PermiteDivulgacao] BIT              NOT NULL,
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [IdCliente]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PET] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PET_ASSOCIATI_TIPOPET] FOREIGN KEY ([IdTipoPet]) REFERENCES [dbo].[TipoPet] ([Id]),
    CONSTRAINT [FK_PET_REFERENCE_CLIENTE] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id]),
    CONSTRAINT [FK_PET_REFERENCE_RACA] FOREIGN KEY ([IdRaca]) REFERENCES [dbo].[Raca] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [ASSOCIATION_5_FK]
    ON [dbo].[Pet]([IdTipoPet] ASC);

