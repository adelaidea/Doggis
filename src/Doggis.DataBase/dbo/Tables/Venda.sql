CREATE TABLE [dbo].[Venda]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Quantidade] INT NOT NULL, 
    [CodigoProduto] BIGINT NOT NULL, 
    [DataVenda] DATETIME NOT NULL, 
    [UsuarioVenda] UNIQUEIDENTIFIER NOT NULL, 
    [ValorProduto] DECIMAL(6, 2) NOT NULL,
    CONSTRAINT [FK_VENDA_PRODUTO] FOREIGN KEY ([CodigoProduto]) REFERENCES [dbo].[Produto] ([Codigo]),
    CONSTRAINT [FK_USUARIO_VENDA] FOREIGN KEY ([UsuarioVenda]) REFERENCES  [dbo].[Funcionario]  ([Id])
)
