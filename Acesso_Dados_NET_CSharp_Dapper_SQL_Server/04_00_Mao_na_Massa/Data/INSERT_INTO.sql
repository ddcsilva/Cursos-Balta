USE [Blog]
GO

INSERT INTO 
    [Usuario]
VALUES (
    'Danilo Silva',
    'danilo.silva@msn.com',
    'HASH',
    'Um mero desenvolvedor',
    'https://',
    'danilo-silva')
GO

INSERT INTO 
    [Role]
VALUES (
    'Autor',
    'autor')
GO

INSERT INTO 
    [Tag]
VALUES (
    'ASP.NET',
    'aspnet')
GO

INSERT INTO 
    [UsuarioRole]
VALUES (
    1,
    1)
GO