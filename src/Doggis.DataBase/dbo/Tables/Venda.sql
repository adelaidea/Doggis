﻿CREATE TABLE [dbo].[Venda]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [DataVenda] DATETIME NOT NULL, 
    [FuncionarioVendaId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_USUARIO_VENDA] FOREIGN KEY ([FuncionarioVendaId]) REFERENCES  [dbo].[Funcionario]  ([Id])
)
