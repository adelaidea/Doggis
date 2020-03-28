CREATE TABLE [dbo].[AgendaServico] (
    [ServicoId]      UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]      UNIQUEIDENTIFIER NOT NULL,
    [PetId]          UNIQUEIDENTIFIER NOT NULL,
    [FuncionarioId]  UNIQUEIDENTIFIER NOT NULL,
    [CodigoPromocao] VARCHAR (10)     NULL,
    [DataRealizacao] DATETIME         NOT NULL,
    [ValorPago]          DECIMAL (6, 2)     NOT NULL,
    [Pontos]         INT              NOT NULL,
    [Cancelado]      BIT              NOT NULL,
    CONSTRAINT [FK_AGENDASE_REFERENCE_CLIENTE] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Cliente] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_FUNCINAR] FOREIGN KEY ([FuncionarioId]) REFERENCES [dbo].[Funcionario] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_PET] FOREIGN KEY ([PetId]) REFERENCES [dbo].[Pet] ([Id]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_PROMOCAO] FOREIGN KEY ([CodigoPromocao]) REFERENCES [dbo].[Promocao] ([Codigo]),
    CONSTRAINT [FK_AGENDASE_REFERENCE_SERVICO] FOREIGN KEY ([ServicoId]) REFERENCES [dbo].[Servico] ([Id]), 
    CONSTRAINT [PK_AgendaServico] PRIMARY KEY ([ServicoId], [ClienteId], [PetId], [FuncionarioId], [DataRealizacao])
);

