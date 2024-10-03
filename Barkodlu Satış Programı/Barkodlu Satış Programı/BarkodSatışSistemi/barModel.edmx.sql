
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/15/2022 22:05:08
-- Generated from EDMX file: C:\Users\kemal\Downloads\Telegram Desktop\BARKOD\BARKOD\Barkodlu Satış Programı\Barkodlu Satış Programı\BarkodSatışSistemi\barModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BarkodDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Barkod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Barkod];
GO
IF OBJECT_ID(N'[dbo].[HizliUrun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HizliUrun];
GO
IF OBJECT_ID(N'[dbo].[islem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[islem];
GO
IF OBJECT_ID(N'[dbo].[islemozet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[islemozet];
GO
IF OBJECT_ID(N'[dbo].[kgorevler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[kgorevler];
GO
IF OBJECT_ID(N'[dbo].[Kullanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanici];
GO
IF OBJECT_ID(N'[dbo].[Sabit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sabit];
GO
IF OBJECT_ID(N'[dbo].[Satis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Satis];
GO
IF OBJECT_ID(N'[dbo].[StokHareket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StokHareket];
GO
IF OBJECT_ID(N'[dbo].[Terazi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Terazi];
GO
IF OBJECT_ID(N'[dbo].[Urun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Urun];
GO
IF OBJECT_ID(N'[dbo].[UrunGrup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UrunGrup];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HizliUrun'
CREATE TABLE [dbo].[HizliUrun] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunAd] nvarchar(50)  NULL,
    [Fiyat] float  NULL
);
GO

-- Creating table 'islem'
CREATE TABLE [dbo].[islem] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [islemNo] int  NULL
);
GO

-- Creating table 'islemozet'
CREATE TABLE [dbo].[islemozet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [islemNo] int  NULL,
    [iade] bit  NULL,
    [odemeSekli] nvarchar(50)  NULL,
    [Nakit] float  NULL,
    [Kart] float  NULL,
    [Gelir] bit  NULL,
    [Gider] bit  NULL,
    [AlisFiyatToplam] float  NULL,
    [Aciklama] nvarchar(max)  NULL,
    [Tarih] datetime  NULL,
    [Kullanici] nvarchar(50)  NULL
);
GO

-- Creating table 'Kullanici'
CREATE TABLE [dbo].[Kullanici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [adSoyad] nvarchar(50)  NULL,
    [Telefon] nvarchar(50)  NULL,
    [Eposta] nvarchar(50)  NULL,
    [KullaniciAd] nvarchar(50)  NULL,
    [Sifre] nvarchar(50)  NULL,
    [Satis] bit  NULL,
    [Rapor] bit  NULL,
    [Stok] bit  NULL,
    [UrunGiris] bit  NULL,
    [ayarlar] bit  NULL,
    [Fiyatguncelleme] bit  NULL,
    [Yedekleme] bit  NULL
);
GO

-- Creating table 'Sabit'
CREATE TABLE [dbo].[Sabit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KartKomisyom] int  NULL,
    [Yazici] bit  NULL,
    [AdSoyad] nvarchar(50)  NULL,
    [Unvan] nvarchar(50)  NULL,
    [Adres] nvarchar(50)  NULL,
    [Telefon] nvarchar(50)  NULL,
    [Eposta] nvarchar(50)  NULL
);
GO

-- Creating table 'Satis'
CREATE TABLE [dbo].[Satis] (
    [SatisId] int IDENTITY(1,1) NOT NULL,
    [IslemNo] int  NULL,
    [UrunAd] nvarchar(50)  NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunGrup] nvarchar(50)  NULL,
    [Birim] nvarchar(50)  NULL,
    [AlisFiyat] float  NULL,
    [SatisFiyat] float  NULL,
    [Miktar] float  NULL,
    [Toplam] float  NULL,
    [KdvTutari] float  NULL,
    [OdemeSekli] nvarchar(50)  NULL,
    [Iade] bit  NULL,
    [Tarih] datetime  NULL,
    [Kullanici] nvarchar(50)  NULL
);
GO

-- Creating table 'StokHareket'
CREATE TABLE [dbo].[StokHareket] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunAd] nvarchar(50)  NULL,
    [Birim] nvarchar(50)  NULL,
    [Miktar] float  NULL,
    [UrunGrup] nvarchar(50)  NULL,
    [Kullanici] nvarchar(50)  NULL,
    [Tarih] datetime  NULL
);
GO

-- Creating table 'Terazi'
CREATE TABLE [dbo].[Terazi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeraziOnEk] int  NULL
);
GO

-- Creating table 'Urun'
CREATE TABLE [dbo].[Urun] (
    [UrunId] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunAdi] nvarchar(50)  NULL,
    [Acıklama] nvarchar(100)  NULL,
    [UrunGroup] nvarchar(50)  NULL,
    [AlisFiyat] float  NULL,
    [SatisFiyat] float  NULL,
    [Kdvorani] int  NULL,
    [Kdvtutari] float  NULL,
    [Birim] nvarchar(50)  NULL,
    [Miktar] float  NULL,
    [Tarih] datetime  NULL,
    [Kullanici] nvarchar(50)  NULL,
    [Onay] bit  NULL
);
GO

-- Creating table 'UrunGrup'
CREATE TABLE [dbo].[UrunGrup] (
    [UrubId] int IDENTITY(1,1) NOT NULL,
    [UrunGAd] nvarchar(50)  NULL
);
GO

-- Creating table 'Barkod'
CREATE TABLE [dbo].[Barkod] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BarkodNo] int  NULL
);
GO

-- Creating table 'kgorevler'
CREATE TABLE [dbo].[kgorevler] (
    [Id] int  NOT NULL,
    [SatisEkran] bit  NULL,
    [RaporEkrani] bit  NULL,
    [Stok] bit  NULL,
    [UrunGiris] bit  NULL,
    [Ayarlar] bit  NULL,
    [FiyatGuncelleme] bit  NULL,
    [Yedekleme] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'HizliUrun'
ALTER TABLE [dbo].[HizliUrun]
ADD CONSTRAINT [PK_HizliUrun]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'islem'
ALTER TABLE [dbo].[islem]
ADD CONSTRAINT [PK_islem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'islemozet'
ALTER TABLE [dbo].[islemozet]
ADD CONSTRAINT [PK_islemozet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Kullanici'
ALTER TABLE [dbo].[Kullanici]
ADD CONSTRAINT [PK_Kullanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sabit'
ALTER TABLE [dbo].[Sabit]
ADD CONSTRAINT [PK_Sabit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SatisId] in table 'Satis'
ALTER TABLE [dbo].[Satis]
ADD CONSTRAINT [PK_Satis]
    PRIMARY KEY CLUSTERED ([SatisId] ASC);
GO

-- Creating primary key on [Id] in table 'StokHareket'
ALTER TABLE [dbo].[StokHareket]
ADD CONSTRAINT [PK_StokHareket]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Terazi'
ALTER TABLE [dbo].[Terazi]
ADD CONSTRAINT [PK_Terazi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UrunId] in table 'Urun'
ALTER TABLE [dbo].[Urun]
ADD CONSTRAINT [PK_Urun]
    PRIMARY KEY CLUSTERED ([UrunId] ASC);
GO

-- Creating primary key on [UrubId] in table 'UrunGrup'
ALTER TABLE [dbo].[UrunGrup]
ADD CONSTRAINT [PK_UrunGrup]
    PRIMARY KEY CLUSTERED ([UrubId] ASC);
GO

-- Creating primary key on [Id] in table 'Barkod'
ALTER TABLE [dbo].[Barkod]
ADD CONSTRAINT [PK_Barkod]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'kgorevler'
ALTER TABLE [dbo].[kgorevler]
ADD CONSTRAINT [PK_kgorevler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------