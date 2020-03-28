CREATE TABLE [dbo].[Servico] (
    [Id]                   UNIQUEIDENTIFIER NOT NULL,
    [Nome]                 VARCHAR (50)     NOT NULL,
    [MinDuracao]           INT              NOT NULL,
    [Preco]                DECIMAL (6, 2)     NOT NULL,
    [DataAlteracao]        DATETIME         NOT NULL,
    [Ativo]                BIT              NOT NULL,
    [PontosRealizacao]     INT              NOT NULL DEFAULT 0,
    CONSTRAINT [PK_SERVICO] PRIMARY KEY CLUSTERED ([Id] ASC),
);

