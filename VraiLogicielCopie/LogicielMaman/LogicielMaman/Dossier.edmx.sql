
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/21/2017 21:19:50
-- Generated from EDMX file: C:\Users\Client\Google Drive\Maman\Logiciel\LogicielMaman\LogicielMaman\Dossier.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DossierPatients];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(150)  NOT NULL,
    [Prenom] nvarchar(150)  NOT NULL,
    [Adresse] nvarchar(250)  NOT NULL,
    [CodePostal] nvarchar(15)  NOT NULL,
    [Courriel] nvarchar(250)  NOT NULL,
    [DateInscription] datetime  NOT NULL,
    [Active] bit  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(250)  NOT NULL,
    [Pays] nvarchar(250)  NOT NULL,
    [Pathologie] nvarchar(max)  NOT NULL,
    [Sexe_Id] int  NOT NULL
);
GO

-- Creating table 'TelephoneClients'
CREATE TABLE [dbo].[TelephoneClients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Telephone] nvarchar(50)  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Client_Id] int  NOT NULL,
    [TypeTelephones_Id] int  NOT NULL
);
GO

-- Creating table 'TypeTelephones'
CREATE TABLE [dbo].[TypeTelephones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Lieu] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'Produits'
CREATE TABLE [dbo].[Produits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(150)  NOT NULL,
    [PrixCoutant] float  NOT NULL,
    [PrixVendant] float  NOT NULL,
    [QuantiteEnStock] int  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Fournisseur_Id] int  NOT NULL
);
GO

-- Creating table 'Fournisseurs'
CREATE TABLE [dbo].[Fournisseurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(150)  NOT NULL,
    [Adresse] nvarchar(250)  NOT NULL,
    [Actif] bit  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(250)  NOT NULL,
    [Pays] nvarchar(250)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TelephoneFournisseurs'
CREATE TABLE [dbo].[TelephoneFournisseurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Telephone] nvarchar(50)  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Fournisseur_Id] int  NOT NULL
);
GO

-- Creating table 'Sexes'
CREATE TABLE [dbo].[Sexes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Categorie] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Achats'
CREATE TABLE [dbo].[Achats] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [DateAchat] datetime  NOT NULL,
    [Quantite] float  NOT NULL,
    [Client_Id] int  NOT NULL,
    [Produits_Id] int  NOT NULL
);
GO

-- Creating table 'Rencontres'
CREATE TABLE [dbo].[Rencontres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateRencontre] datetime  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'Administrateurs'
CREATE TABLE [dbo].[Administrateurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(150)  NOT NULL,
    [Prenom] nvarchar(150)  NOT NULL,
    [DateInscription] datetime  NOT NULL,
    [Connecte] bit  NOT NULL,
    [MotDePasse] nvarchar(150)  NOT NULL,
    [NomUtilisateur] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SourceImage] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TelephoneClients'
ALTER TABLE [dbo].[TelephoneClients]
ADD CONSTRAINT [PK_TelephoneClients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeTelephones'
ALTER TABLE [dbo].[TypeTelephones]
ADD CONSTRAINT [PK_TypeTelephones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produits'
ALTER TABLE [dbo].[Produits]
ADD CONSTRAINT [PK_Produits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fournisseurs'
ALTER TABLE [dbo].[Fournisseurs]
ADD CONSTRAINT [PK_Fournisseurs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TelephoneFournisseurs'
ALTER TABLE [dbo].[TelephoneFournisseurs]
ADD CONSTRAINT [PK_TelephoneFournisseurs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sexes'
ALTER TABLE [dbo].[Sexes]
ADD CONSTRAINT [PK_Sexes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Achats'
ALTER TABLE [dbo].[Achats]
ADD CONSTRAINT [PK_Achats]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rencontres'
ALTER TABLE [dbo].[Rencontres]
ADD CONSTRAINT [PK_Rencontres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Administrateurs'
ALTER TABLE [dbo].[Administrateurs]
ADD CONSTRAINT [PK_Administrateurs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sexe_Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_SexeClient]
    FOREIGN KEY ([Sexe_Id])
    REFERENCES [dbo].[Sexes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SexeClient'
CREATE INDEX [IX_FK_SexeClient]
ON [dbo].[Clients]
    ([Sexe_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'TelephoneClients'
ALTER TABLE [dbo].[TelephoneClients]
ADD CONSTRAINT [FK_ClientTelephoneClient]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientTelephoneClient'
CREATE INDEX [IX_FK_ClientTelephoneClient]
ON [dbo].[TelephoneClients]
    ([Client_Id]);
GO

-- Creating foreign key on [TypeTelephones_Id] in table 'TelephoneClients'
ALTER TABLE [dbo].[TelephoneClients]
ADD CONSTRAINT [FK_TelephoneClientTypeTelephone]
    FOREIGN KEY ([TypeTelephones_Id])
    REFERENCES [dbo].[TypeTelephones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TelephoneClientTypeTelephone'
CREATE INDEX [IX_FK_TelephoneClientTypeTelephone]
ON [dbo].[TelephoneClients]
    ([TypeTelephones_Id]);
GO

-- Creating foreign key on [Fournisseur_Id] in table 'TelephoneFournisseurs'
ALTER TABLE [dbo].[TelephoneFournisseurs]
ADD CONSTRAINT [FK_FournisseurTelephoneFournisseur]
    FOREIGN KEY ([Fournisseur_Id])
    REFERENCES [dbo].[Fournisseurs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FournisseurTelephoneFournisseur'
CREATE INDEX [IX_FK_FournisseurTelephoneFournisseur]
ON [dbo].[TelephoneFournisseurs]
    ([Fournisseur_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Rencontres'
ALTER TABLE [dbo].[Rencontres]
ADD CONSTRAINT [FK_ClientRencontre]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientRencontre'
CREATE INDEX [IX_FK_ClientRencontre]
ON [dbo].[Rencontres]
    ([Client_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Achats'
ALTER TABLE [dbo].[Achats]
ADD CONSTRAINT [FK_ClientAchat]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAchat'
CREATE INDEX [IX_FK_ClientAchat]
ON [dbo].[Achats]
    ([Client_Id]);
GO

-- Creating foreign key on [Produits_Id] in table 'Achats'
ALTER TABLE [dbo].[Achats]
ADD CONSTRAINT [FK_AchatProduit]
    FOREIGN KEY ([Produits_Id])
    REFERENCES [dbo].[Produits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AchatProduit'
CREATE INDEX [IX_FK_AchatProduit]
ON [dbo].[Achats]
    ([Produits_Id]);
GO

-- Creating foreign key on [Fournisseur_Id] in table 'Produits'
ALTER TABLE [dbo].[Produits]
ADD CONSTRAINT [FK_FournisseurProduit]
    FOREIGN KEY ([Fournisseur_Id])
    REFERENCES [dbo].[Fournisseurs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FournisseurProduit'
CREATE INDEX [IX_FK_FournisseurProduit]
ON [dbo].[Produits]
    ([Fournisseur_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [FK_ClientImage]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientImage'
CREATE INDEX [IX_FK_ClientImage]
ON [dbo].[Images]
    ([Client_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------