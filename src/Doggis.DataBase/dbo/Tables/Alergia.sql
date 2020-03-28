CREATE TABLE [dbo].[Alergia] (
    [Id]        INT IDENTITY(1,1) NOT NULL,
    [Nome]      VARCHAR (50)     NOT NULL,
    [Descricao] VARCHAR (MAX)    NULL,
    CONSTRAINT [PK_ALERGIAS] PRIMARY KEY CLUSTERED ([Id] ASC)
);

