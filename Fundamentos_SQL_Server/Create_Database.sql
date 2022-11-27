USE [Curso]

DROP TABLE [Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] VARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Ativo] BIT NOT NULL DEFAULT(0),
    
    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email])
)
GO

CREATE TABLE [Curso](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    
    CONSTRAINT [PK_Curso] PRIMARY KEY([Id])
)

GO

CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE())
)