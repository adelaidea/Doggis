CREATE TABLE [dbo].[Produto] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Nome]           VARCHAR (100)    NOT NULL,
    [Especificacoes] VARCHAR (MAX)    NOT NULL,
    [Preco]          DECIMAL (6, 2)     NOT NULL,
    [ParaVenda]      BIT              NOT NULL,
    CONSTRAINT [PK_PRODUTO] PRIMARY KEY CLUSTERED ([Id] ASC)
);

