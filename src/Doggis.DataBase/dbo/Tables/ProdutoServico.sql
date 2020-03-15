CREATE TABLE [dbo].[ProdutoServico] (
    [IdServico] UNIQUEIDENTIFIER NOT NULL,
    [CodigoProduto] bigint NOT NULL,
    CONSTRAINT [PK_PRODUTOSERVICO] PRIMARY KEY CLUSTERED ([IdServico] ASC, [CodigoProduto] ASC),
    CONSTRAINT [FK_PRODUTOS_ASSOCIATI_PRODUTO] FOREIGN KEY ([CodigoProduto]) REFERENCES [dbo].[Produto] ([Codigo]),
    CONSTRAINT [FK_PRODUTOS_ASSOCIATI_SERVICO] FOREIGN KEY ([IdServico]) REFERENCES [dbo].[Servico] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [ASSOCIATION_1_FK]
    ON [dbo].[ProdutoServico]([IdServico] ASC);

