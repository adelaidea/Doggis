CREATE TABLE [dbo].[Funcionario] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [Nome]       VARCHAR (100)    NOT NULL,
    [IdTipo]     INT              NOT NULL,
    [RG] VARCHAR (10)     NOT NULL,
    [CPF]        CHAR (11)        NOT NULL,
    [Registro]   VARCHAR (20)     NULL,
    CONSTRAINT [PK_FUNCINARIO] PRIMARY KEY CLUSTERED ([Id] ASC)
);

