CREATE TABLE [dbo].[Promocao] (
    [Codigo]     VARCHAR (10)  NOT NULL,
    [Nome]       VARCHAR (50)  NOT NULL,
    [Descricao]  VARCHAR (MAX) NOT NULL,
    [DataInicio] DATETIME      NOT NULL,
    [DataFim]    DATETIME      NOT NULL,
    CONSTRAINT [PK_PROMOCAO] PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

