CREATE TABLE [dbo].[Cliente] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Nome]             VARCHAR (100)    NOT NULL,
    [RG]       VARCHAR (10)     NOT NULL,
    [CPF]              CHAR (11)        NOT NULL,
    [Email]            VARCHAR (100)    NOT NULL,
    [Endereco]         VARCHAR (MAX)    NOT NULL,
    [PontosAcumulados] INT              NULL,
    CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED ([Id] ASC)
);

