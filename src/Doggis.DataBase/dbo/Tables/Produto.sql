CREATE TABLE [dbo].[Produto] (
    [Codigo]             BIGINT NOT NULL,
    [Nome]           VARCHAR (100)    NOT NULL,
    [Especificacoes] VARCHAR (MAX)    NOT NULL,
    [Preco]          DECIMAL (6, 2)     NOT NULL,
    [ParaVenda]      BIT              NOT NULL,
    [Quantidade] INT NOT NULL DEFAULT 0, 
    [FabricanteId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_PRODUTO] PRIMARY KEY CLUSTERED ([Codigo] ASC),    
    CONSTRAINT [FK_PRODUTO_FABRICANTE] FOREIGN KEY ([FabricanteId]) REFERENCES [dbo].[Fabricante] ([Id])
);

