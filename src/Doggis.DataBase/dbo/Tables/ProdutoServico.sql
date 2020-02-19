﻿CREATE TABLE [dbo].[ProdutoServico] (
    [IdServico] UNIQUEIDENTIFIER NOT NULL,
    [IdProduto] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PRODUTOSERVICO] PRIMARY KEY CLUSTERED ([IdServico] ASC, [IdProduto] ASC),
    CONSTRAINT [FK_PRODUTOS_ASSOCIATI_PRODUTO] FOREIGN KEY ([IdProduto]) REFERENCES [dbo].[Produto] ([Id]),
    CONSTRAINT [FK_PRODUTOS_ASSOCIATI_SERVICO] FOREIGN KEY ([IdServico]) REFERENCES [dbo].[Servico] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [ASSOCIATION_1_FK]
    ON [dbo].[ProdutoServico]([IdServico] ASC);
