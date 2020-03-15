CREATE TABLE [dbo].[Servico] (
    [Id]                   UNIQUEIDENTIFIER NOT NULL,
    [Nome]                 VARCHAR (50)     NOT NULL,
    [MinDuracao]           INT              NOT NULL,
    [Preco]                DECIMAL (6, 2)     NOT NULL,
    [DataAlteracao]        DATETIME         NOT NULL,
    [Ativo]                BIT              NOT NULL,
    [FuncionarioAlteracao] UNIQUEIDENTIFIER NOT NULL,
    [PontosRealizacao]     INT              NULL,
    CONSTRAINT [PK_SERVICO] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SERVICO_REFERENCE_FUNCINAR] FOREIGN KEY ([FuncionarioAlteracao]) REFERENCES [dbo].[Funcionario] ([Id])
);

