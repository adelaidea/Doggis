﻿CREATE TABLE [dbo].[FunacionarioServico] (
    [IdServico]     UNIQUEIDENTIFIER NOT NULL,
    [IdFuncionario] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_FUNACIONARIOSERVICO] PRIMARY KEY CLUSTERED ([IdServico] ASC, [IdFuncionario] ASC),
    CONSTRAINT [FK_FUNACION_ASSOCIATI_FUNCINAR] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcinario] ([Id]),
    CONSTRAINT [FK_FUNACION_REFERENCE_SERVICO] FOREIGN KEY ([IdServico]) REFERENCES [dbo].[Servico] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [ASSOCIATION_2_FK]
    ON [dbo].[FunacionarioServico]([IdFuncionario] ASC);
