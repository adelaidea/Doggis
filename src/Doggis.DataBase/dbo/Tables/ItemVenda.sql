CREATE TABLE [dbo].[ItemVenda]
(
    [VendaId] UNIQUEIDENTIFIER NOT NULL, 
    [CodigoProduto] BIGINT NOT NULL, 
    [ValorItem] DECIMAL(6, 2) NOT NULL, 
    [Quantidade] INT NOT NULL,
    CONSTRAINT [FK_VENDA_ITEM_PRODUTO] FOREIGN KEY ([CodigoProduto]) REFERENCES [dbo].[Produto] ([Codigo]),
    CONSTRAINT [FK_VENDA_ITEM] FOREIGN KEY ([VendaId]) REFERENCES [dbo].[Venda] ([Id]), 
    CONSTRAINT [PK_ItemVenda] PRIMARY KEY ([VendaId], [CodigoProduto])
)
