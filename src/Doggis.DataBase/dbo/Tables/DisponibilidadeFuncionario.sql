CREATE TABLE [dbo].[DisponibilidadeFuncionario]
(
	[FuncionarioId] UNIQUEIDENTIFIER NOT NULL , 
    [DiaSemana] SMALLINT NOT NULL, 
    [HorarioInicio] TIME NOT NULL, 
    [HorarioFim] TIME NOT NULL, 
    PRIMARY KEY ([FuncionarioId], [DiaSemana], [HorarioInicio], [HorarioFim]),
    CONSTRAINT [FK_DISPONIBILIDADE_FUNCIONARIO] FOREIGN KEY ([FuncionarioId]) REFERENCES [dbo].[Funcionario] ([Id])
)
