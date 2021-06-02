
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 23:13:54
-- Generated from EDMX file: D:\GRAFIKA\BazeProjekatPokusaj2\BazeProjekatPokusaj2\CompanyDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CompanyDbModel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ZaposleniUgovor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Zaposleni] DROP CONSTRAINT [FK_ZaposleniUgovor];
GO
IF OBJECT_ID(N'[dbo].[FK_KompanijaLokacija]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kompanije] DROP CONSTRAINT [FK_KompanijaLokacija];
GO
IF OBJECT_ID(N'[dbo].[FK_UgovoreniProizvodKlijent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UgovoreniProizvodi] DROP CONSTRAINT [FK_UgovoreniProizvodKlijent];
GO
IF OBJECT_ID(N'[dbo].[FK_UgovoreniProizvodKonsultant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UgovoreniProizvodi] DROP CONSTRAINT [FK_UgovoreniProizvodKonsultant];
GO
IF OBJECT_ID(N'[dbo].[FK_UgovoreniProizvodDeveloper]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UgovoreniProizvodi] DROP CONSTRAINT [FK_UgovoreniProizvodDeveloper];
GO
IF OBJECT_ID(N'[dbo].[FK_DirektorKompanija]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kompanije] DROP CONSTRAINT [FK_DirektorKompanija];
GO
IF OBJECT_ID(N'[dbo].[FK_Zaposleni_inherits_Osoba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Zaposleni] DROP CONSTRAINT [FK_Zaposleni_inherits_Osoba];
GO
IF OBJECT_ID(N'[dbo].[FK_Klijent_inherits_Osoba]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Klijent] DROP CONSTRAINT [FK_Klijent_inherits_Osoba];
GO
IF OBJECT_ID(N'[dbo].[FK_Konsultant_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Konsultant] DROP CONSTRAINT [FK_Konsultant_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Developer_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Developer] DROP CONSTRAINT [FK_Developer_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Direktor_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Osobas_Direktor] DROP CONSTRAINT [FK_Direktor_inherits_Zaposleni];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Osobas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas];
GO
IF OBJECT_ID(N'[dbo].[Kompanije]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kompanije];
GO
IF OBJECT_ID(N'[dbo].[Lokacije]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lokacije];
GO
IF OBJECT_ID(N'[dbo].[Ugovori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ugovori];
GO
IF OBJECT_ID(N'[dbo].[UgovoreniProizvodi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UgovoreniProizvodi];
GO
IF OBJECT_ID(N'[dbo].[Osobas_Zaposleni]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[Osobas_Klijent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas_Klijent];
GO
IF OBJECT_ID(N'[dbo].[Osobas_Konsultant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas_Konsultant];
GO
IF OBJECT_ID(N'[dbo].[Osobas_Developer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas_Developer];
GO
IF OBJECT_ID(N'[dbo].[Osobas_Direktor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Osobas_Direktor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Osobas'
CREATE TABLE [dbo].[Osobas] (
    [OID] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [OsobaType] nvarchar(max)  NOT NULL,
    [JMBG] int  NOT NULL
);
GO

-- Creating table 'Kompanije'
CREATE TABLE [dbo].[Kompanije] (
    [KID] int IDENTITY(1,1) NOT NULL,
    [NazivKompanije] nvarchar(max)  NOT NULL,
    [GodinaOsnivanja] nvarchar(max)  NOT NULL,
    [Lokacija_LokID] int  NOT NULL,
    [Direktor_OID] int  NOT NULL
);
GO

-- Creating table 'Lokacije'
CREATE TABLE [dbo].[Lokacije] (
    [LokID] int IDENTITY(1,1) NOT NULL,
    [KompanijaKID] int  NOT NULL,
    [Grad] nvarchar(max)  NOT NULL,
    [Ulica] nvarchar(max)  NOT NULL,
    [PostanskiBroj] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Ugovori'
CREATE TABLE [dbo].[Ugovori] (
    [UID] int IDENTITY(1,1) NOT NULL,
    [TrajanjeUgovora] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UgovoreniProizvodi'
CREATE TABLE [dbo].[UgovoreniProizvodi] (
    [OpisProizvoda] nvarchar(max)  NOT NULL,
    [VrednostProizvoda] nvarchar(max)  NOT NULL,
    [PRID] int  NOT NULL,
    [Klijent_OID] int  NOT NULL,
    [Konsultant_OID] int  NOT NULL,
    [Developer_OID] int  NOT NULL
);
GO

-- Creating table 'Osobas_Zaposleni'
CREATE TABLE [dbo].[Osobas_Zaposleni] (
    [RadniStaz] nvarchar(max)  NOT NULL,
    [UgovorUID] int  NOT NULL,
    [OID] int  NOT NULL
);
GO

-- Creating table 'Osobas_Klijent'
CREATE TABLE [dbo].[Osobas_Klijent] (
    [NazivKlijenta] nvarchar(max)  NOT NULL,
    [OID] int  NOT NULL
);
GO

-- Creating table 'Osobas_Konsultant'
CREATE TABLE [dbo].[Osobas_Konsultant] (
    [OID] int  NOT NULL
);
GO

-- Creating table 'Osobas_Developer'
CREATE TABLE [dbo].[Osobas_Developer] (
    [PreferiranaTehnologija] nvarchar(max)  NOT NULL,
    [OID] int  NOT NULL
);
GO

-- Creating table 'Osobas_Direktor'
CREATE TABLE [dbo].[Osobas_Direktor] (
    [OID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [OID] in table 'Osobas'
ALTER TABLE [dbo].[Osobas]
ADD CONSTRAINT [PK_Osobas]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- Creating primary key on [KID] in table 'Kompanije'
ALTER TABLE [dbo].[Kompanije]
ADD CONSTRAINT [PK_Kompanije]
    PRIMARY KEY CLUSTERED ([KID] ASC);
GO

-- Creating primary key on [LokID] in table 'Lokacije'
ALTER TABLE [dbo].[Lokacije]
ADD CONSTRAINT [PK_Lokacije]
    PRIMARY KEY CLUSTERED ([LokID] ASC);
GO

-- Creating primary key on [UID] in table 'Ugovori'
ALTER TABLE [dbo].[Ugovori]
ADD CONSTRAINT [PK_Ugovori]
    PRIMARY KEY CLUSTERED ([UID] ASC);
GO

-- Creating primary key on [PRID] in table 'UgovoreniProizvodi'
ALTER TABLE [dbo].[UgovoreniProizvodi]
ADD CONSTRAINT [PK_UgovoreniProizvodi]
    PRIMARY KEY CLUSTERED ([PRID] ASC);
GO

-- Creating primary key on [OID] in table 'Osobas_Zaposleni'
ALTER TABLE [dbo].[Osobas_Zaposleni]
ADD CONSTRAINT [PK_Osobas_Zaposleni]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- Creating primary key on [OID] in table 'Osobas_Klijent'
ALTER TABLE [dbo].[Osobas_Klijent]
ADD CONSTRAINT [PK_Osobas_Klijent]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- Creating primary key on [OID] in table 'Osobas_Konsultant'
ALTER TABLE [dbo].[Osobas_Konsultant]
ADD CONSTRAINT [PK_Osobas_Konsultant]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- Creating primary key on [OID] in table 'Osobas_Developer'
ALTER TABLE [dbo].[Osobas_Developer]
ADD CONSTRAINT [PK_Osobas_Developer]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- Creating primary key on [OID] in table 'Osobas_Direktor'
ALTER TABLE [dbo].[Osobas_Direktor]
ADD CONSTRAINT [PK_Osobas_Direktor]
    PRIMARY KEY CLUSTERED ([OID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UgovorUID] in table 'Osobas_Zaposleni'
ALTER TABLE [dbo].[Osobas_Zaposleni]
ADD CONSTRAINT [FK_ZaposleniUgovor]
    FOREIGN KEY ([UgovorUID])
    REFERENCES [dbo].[Ugovori]
        ([UID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZaposleniUgovor'
CREATE INDEX [IX_FK_ZaposleniUgovor]
ON [dbo].[Osobas_Zaposleni]
    ([UgovorUID]);
GO

-- Creating foreign key on [Lokacija_LokID] in table 'Kompanije'
ALTER TABLE [dbo].[Kompanije]
ADD CONSTRAINT [FK_KompanijaLokacija]
    FOREIGN KEY ([Lokacija_LokID])
    REFERENCES [dbo].[Lokacije]
        ([LokID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KompanijaLokacija'
CREATE INDEX [IX_FK_KompanijaLokacija]
ON [dbo].[Kompanije]
    ([Lokacija_LokID]);
GO

-- Creating foreign key on [Klijent_OID] in table 'UgovoreniProizvodi'
ALTER TABLE [dbo].[UgovoreniProizvodi]
ADD CONSTRAINT [FK_UgovoreniProizvodKlijent]
    FOREIGN KEY ([Klijent_OID])
    REFERENCES [dbo].[Osobas_Klijent]
        ([OID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UgovoreniProizvodKlijent'
CREATE INDEX [IX_FK_UgovoreniProizvodKlijent]
ON [dbo].[UgovoreniProizvodi]
    ([Klijent_OID]);
GO

-- Creating foreign key on [Konsultant_OID] in table 'UgovoreniProizvodi'
ALTER TABLE [dbo].[UgovoreniProizvodi]
ADD CONSTRAINT [FK_UgovoreniProizvodKonsultant]
    FOREIGN KEY ([Konsultant_OID])
    REFERENCES [dbo].[Osobas_Konsultant]
        ([OID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UgovoreniProizvodKonsultant'
CREATE INDEX [IX_FK_UgovoreniProizvodKonsultant]
ON [dbo].[UgovoreniProizvodi]
    ([Konsultant_OID]);
GO

-- Creating foreign key on [Developer_OID] in table 'UgovoreniProizvodi'
ALTER TABLE [dbo].[UgovoreniProizvodi]
ADD CONSTRAINT [FK_UgovoreniProizvodDeveloper]
    FOREIGN KEY ([Developer_OID])
    REFERENCES [dbo].[Osobas_Developer]
        ([OID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UgovoreniProizvodDeveloper'
CREATE INDEX [IX_FK_UgovoreniProizvodDeveloper]
ON [dbo].[UgovoreniProizvodi]
    ([Developer_OID]);
GO

-- Creating foreign key on [Direktor_OID] in table 'Kompanije'
ALTER TABLE [dbo].[Kompanije]
ADD CONSTRAINT [FK_DirektorKompanija]
    FOREIGN KEY ([Direktor_OID])
    REFERENCES [dbo].[Osobas_Direktor]
        ([OID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DirektorKompanija'
CREATE INDEX [IX_FK_DirektorKompanija]
ON [dbo].[Kompanije]
    ([Direktor_OID]);
GO

-- Creating foreign key on [OID] in table 'Osobas_Zaposleni'
ALTER TABLE [dbo].[Osobas_Zaposleni]
ADD CONSTRAINT [FK_Zaposleni_inherits_Osoba]
    FOREIGN KEY ([OID])
    REFERENCES [dbo].[Osobas]
        ([OID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OID] in table 'Osobas_Klijent'
ALTER TABLE [dbo].[Osobas_Klijent]
ADD CONSTRAINT [FK_Klijent_inherits_Osoba]
    FOREIGN KEY ([OID])
    REFERENCES [dbo].[Osobas]
        ([OID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OID] in table 'Osobas_Konsultant'
ALTER TABLE [dbo].[Osobas_Konsultant]
ADD CONSTRAINT [FK_Konsultant_inherits_Zaposleni]
    FOREIGN KEY ([OID])
    REFERENCES [dbo].[Osobas_Zaposleni]
        ([OID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OID] in table 'Osobas_Developer'
ALTER TABLE [dbo].[Osobas_Developer]
ADD CONSTRAINT [FK_Developer_inherits_Zaposleni]
    FOREIGN KEY ([OID])
    REFERENCES [dbo].[Osobas_Zaposleni]
        ([OID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OID] in table 'Osobas_Direktor'
ALTER TABLE [dbo].[Osobas_Direktor]
ADD CONSTRAINT [FK_Direktor_inherits_Zaposleni]
    FOREIGN KEY ([OID])
    REFERENCES [dbo].[Osobas_Zaposleni]
        ([OID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------