/*Tabela Personagens*/
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

/*Tabela Armas*/
BEGIN TRANSACTION;
CREATE TABLE [TB_ARMAS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Dano] int NOT NULL,
    [Tipo] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TB_ARMAS] PRIMARY KEY ([Id])
);

/*Tabela Personagens*/
CREATE TABLE [TB_PERSONAGENS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [PontosVida] int NOT NULL,
    [Forca] int NOT NULL,
    [Defesa] int NOT NULL,
    [Inteligencia] int NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_TB_PERSONAGENS] PRIMARY KEY ([Id])
);

/*Tabela Armas*/
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome', N'Tipo') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] ON;
INSERT INTO [TB_ARMAS] ([Id], [Dano], [Nome], [Tipo])
VALUES (1, 38, N'Treisoitão', N'Meido Alcance'),
(2, 30, N'M4', N''),
(3, 40, N'AK47', N''),
(4, 35, N'Coquetel Molotov', N''),
(5, 130, N'Lança Chamas', N''),
(6, 70, N'Espada de Grama', N''),
(7, 100, N'Ominitrix', N'');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome', N'Tipo') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] OFF;

/*Tabela Personagens*/
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Forca', N'Inteligencia', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] ON;
INSERT INTO [TB_PERSONAGENS] ([Id], [Classe], [Defesa], [Forca], [Inteligencia], [Nome], [PontosVida])
VALUES (1, 1, 23, 17, 33, N'Frodo', 100),
(2, 1, 25, 15, 30, N'Sam', 100),
(3, 3, 21, 18, 35, N'Galadriel', 100),
(4, 2, 18, 18, 37, N'Gandalf', 100),
(5, 1, 17, 20, 31, N'Hobbit', 100),
(6, 3, 13, 21, 34, N'Celeborn', 100),
(7, 2, 11, 25, 35, N'Radagas7t', 100);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Defesa', N'Forca', N'Inteligencia', N'Nome', N'PontosVida') AND [object_id] = OBJECT_ID(N'[TB_PERSONAGENS]'))
    SET IDENTITY_INSERT [TB_PERSONAGENS] OFF;

/*Tabela Personagens e Armas*/
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250924012345_MigracaoArma', N'9.0.9');

COMMIT;
GO

