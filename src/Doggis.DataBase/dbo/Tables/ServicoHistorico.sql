CREATE TABLE [dbo].[ServicoHistorico]
(
	[ServicoId] UNIQUEIDENTIFIER NOT NULL , 
    [DataAlteracao] DATETIME NOT NULL, 
    [FuncionarioAlteracaoId] UNIQUEIDENTIFIER NOT NULL, 
    [Preco] DECIMAL(6, 2) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    [PontosRealizacao] INT NOT NULL, 
    [MinDuracao] INT NOT NULL, 
    [Nome] VARCHAR(50) NOT NULL, 
    PRIMARY KEY ([ServicoId], [DataAlteracao]),    
    CONSTRAINT [FK_SERVICO_REFERENCE_FUNCINAR] FOREIGN KEY ([FuncionarioAlteracaoId]) REFERENCES [dbo].[Funcionario] ([Id])
)
