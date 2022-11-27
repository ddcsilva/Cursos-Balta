USE [Curso]

ALTER TABLE [Aluno]
    ADD [Documento] NVARCHAR(11)

ALTER TABLE [Aluno]
    DROP COLUMN [Documento]

ALTER TABLE [Aluno]
    ALTER COLUMN [Documento] CHAR(11)