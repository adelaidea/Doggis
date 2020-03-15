CREATE TABLE [dbo].[AgendaServico] (
    [IdServico]      UNIQUEIDENTIFIER NOT NULL,
    [IdCliente]      UNIQUEIDENTIFIER NOT NULL,
    [IdPet]          UNIQUEIDENTIFIER NOT NULL,
    [IdFuncionario]  UNIQUEIDENTIFIER NOT NULL,
    [CodigoPromocao] VARCHAR (10)     NULL,
    [DataRealizacao] DATETIME         NOT NULL,
    [Valor]          DECIMAL (6, 2)     NOT NULL,
    [Pontos]         INT              NOT NULL,
    [Cancelado]      BIT              NOT NULL,
    CONSTRAINT [FK_AGENDASE_REFERENCE_CLIENTE] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Cliente] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_FUNCINAR] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcionario] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_PET] FOREIGN KEY ([IdPet]) REFERENCES [dbo].[Pet] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_PROMOCAO] FOREIGN KEY ([CodigoPromocao]) REFERENCES [dbo].[Promocao] ([Codigo]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_SERVICO] FOREIGN KEY ([IdServico]) REFERENCES [dbo].[Servico] ([Id])
);

