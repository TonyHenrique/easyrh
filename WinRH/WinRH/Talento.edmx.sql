
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/09/2017 20:11:43
-- Generated from EDMX file: C:\temp\RH\WinRH\WinRH\Talento.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [rheasy];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TalentoConhecimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Conhecimento] DROP CONSTRAINT [FK_TalentoConhecimento];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Talento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Talento];
GO
IF OBJECT_ID(N'[dbo].[Conhecimento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Conhecimento];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Talento'
CREATE TABLE [dbo].[Talento] (
    [id_Talento] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(250)  NULL,
    [CPF] nvarchar(50)  NULL,
    [Banco] nvarchar(100)  NULL,
    [Agencia] nvarchar(100)  NULL,
    [TipoDeConta] nvarchar(100)  NULL,
    [NumeroDaConta] nvarchar(100)  NULL,
    [OBS_Conhecimentos] nvarchar(250)  NULL,
    [LinkCRUD] nvarchar(max)  NULL
);
GO

-- Creating table 'Conhecimento'
CREATE TABLE [dbo].[Conhecimento] (
    [id_Conhecimento] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Nota] int  NOT NULL,
    [Talento_id_Talento] int  NOT NULL,
    [IsImportante] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_Talento] in table 'Talento'
ALTER TABLE [dbo].[Talento]
ADD CONSTRAINT [PK_Talento]
    PRIMARY KEY CLUSTERED ([id_Talento] ASC);
GO

-- Creating primary key on [id_Conhecimento] in table 'Conhecimento'
ALTER TABLE [dbo].[Conhecimento]
ADD CONSTRAINT [PK_Conhecimento]
    PRIMARY KEY CLUSTERED ([id_Conhecimento] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Talento_id_Talento] in table 'Conhecimento'
ALTER TABLE [dbo].[Conhecimento]
ADD CONSTRAINT [FK_TalentoConhecimento]
    FOREIGN KEY ([Talento_id_Talento])
    REFERENCES [dbo].[Talento]
        ([id_Talento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TalentoConhecimento'
CREATE INDEX [IX_FK_TalentoConhecimento]
ON [dbo].[Conhecimento]
    ([Talento_id_Talento]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------