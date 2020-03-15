CREATE TABLE [dbo].[PromocaoAplicabilidade] (
    [IdServico] UNIQUEIDENTIFIER NULL,
    [CodigoProduto] bigint NULL,
    [Codigo]    VARCHAR (10)     NOT NULL,
    CONSTRAINT [FK_PROMOCAO_ASSOCIATI_PRODUTO] FOREIGN KEY ([CodigoProduto]) REFERENCES [dbo].[Produto] ([Codigo]),
    CONSTRAINT [FK_PROMOCAO_ASSOCIATI_PROMOCAO] FOREIGN KEY ([Codigo]) REFERENCES [dbo].[Promocao] ([Codigo]),
    CONSTRAINT [FK_PROMOCAO_REFERENCE_SERVICO] FOREIGN KEY ([IdServico]) REFERENCES [dbo].[Servico] ([Id]),
    CONSTRAINT UniquePromocaoAplicabilidade UNIQUE (IdServico, CodigoProduto, Codigo)
);

