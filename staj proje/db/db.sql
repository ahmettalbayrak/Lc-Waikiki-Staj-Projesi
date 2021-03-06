USE [StajyerTestDB]
GO
/****** Object:  User [LCWAIKIKI\AHMET.ALBAYRAK]    Script Date: 7/25/2014 5:26:26 PM ******/
CREATE USER [LCWAIKIKI\AHMET.ALBAYRAK] FOR LOGIN [LCWAIKIKI\AHMET.ALBAYRAK] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [LCWAIKIKI\AHMET.ALBAYRAK]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [LCWAIKIKI\AHMET.ALBAYRAK]
GO
ALTER ROLE [db_datareader] ADD MEMBER [LCWAIKIKI\AHMET.ALBAYRAK]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [LCWAIKIKI\AHMET.ALBAYRAK]
GO
/****** Object:  Table [dbo].[Ahmet_Bolum]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Bolum](
	[BolumId] [int] IDENTITY(1,1) NOT NULL,
	[Bolum] [nvarchar](50) NOT NULL,
	[FakulteId] [int] NOT NULL,
 CONSTRAINT [PK_Ahmet_Bolum] PRIMARY KEY CLUSTERED 
(
	[BolumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Cinsiyet]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Cinsiyet](
	[CinsiyetId] [int] IDENTITY(1,1) NOT NULL,
	[Cinsiyet] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ahmet_Cinsiyet] PRIMARY KEY CLUSTERED 
(
	[CinsiyetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Dersler]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Dersler](
	[DerslerId] [int] IDENTITY(1,1) NOT NULL,
	[DersKodu] [nvarchar](10) NOT NULL,
	[DersAdi] [nvarchar](30) NOT NULL,
	[KiminVerdigi] [nvarchar](30) NOT NULL,
	[Donem] [int] NOT NULL,
	[OgrenciId] [int] NULL,
	[OgretmenId] [int] NULL,
 CONSTRAINT [PK_Ahmet_Dersler] PRIMARY KEY CLUSTERED 
(
	[DerslerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Fakulte]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Fakulte](
	[FakulteId] [int] IDENTITY(1,1) NOT NULL,
	[Fakulte] [nvarchar](50) NOT NULL,
	[OgrenciId] [int] NULL,
 CONSTRAINT [PK_Ahmet_Fakulte] PRIMARY KEY CLUSTERED 
(
	[FakulteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_GecmisEgitim]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_GecmisEgitim](
	[GecmisId] [int] IDENTITY(1,1) NOT NULL,
	[MezuniyetYil] [int] NOT NULL,
	[MezuniyetDerecesi] [float] NOT NULL,
	[MezunOkul] [nvarchar](50) NOT NULL,
	[OgrenciId] [int] NULL,
	[OgretmenId] [int] NULL,
	[MemurId] [int] NULL,
 CONSTRAINT [PK_Ahmet_Gecmis_Egitim] PRIMARY KEY CLUSTERED 
(
	[GecmisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Kisisel]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ahmet_Kisisel](
	[KisiselId] [int] IDENTITY(1,1) NOT NULL,
	[TC] [char](11) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[DogumTarih] [datetime] NOT NULL,
	[CinsiyetId] [int] NOT NULL,
	[MedeniDurumId] [int] NOT NULL,
	[Mail] [nvarchar](30) NOT NULL,
	[EvTel] [nchar](15) NOT NULL,
	[CepTel] [nchar](15) NOT NULL,
	[Unvan] [nvarchar](30) NOT NULL,
	[OgrenciId] [int] NULL,
	[OgretmenId] [int] NULL,
	[VeliId] [int] NULL,
	[MemurId] [int] NULL,
	[KullaniciTipiId] [int] NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ahmet_Kisisel] PRIMARY KEY CLUSTERED 
(
	[KisiselId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ahmet_KullaniciTipi]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_KullaniciTipi](
	[KullaniciTipiId] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Ahmet_KullaniciTipi] PRIMARY KEY CLUSTERED 
(
	[KullaniciTipiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_MedeniDurum]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_MedeniDurum](
	[MedeniDurumId] [int] IDENTITY(1,1) NOT NULL,
	[MedeniDurum] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ahmet_MedeniDurum] PRIMARY KEY CLUSTERED 
(
	[MedeniDurumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Memur]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Memur](
	[MemurId] [int] IDENTITY(1,1) NOT NULL,
	[IseBaslama] [datetime] NOT NULL,
	[GecmisDeneyimler] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Ahmet_Memur] PRIMARY KEY CLUSTERED 
(
	[MemurId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Notlar]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Notlar](
	[NotlarId] [int] IDENTITY(1,1) NOT NULL,
	[Vize] [int] NOT NULL,
	[Final] [int] NOT NULL,
	[Ortalama] [int] NOT NULL,
	[DerslerId] [int] NULL,
	[OgrenciId] [int] NULL,
 CONSTRAINT [PK_Ahmet_Notlar] PRIMARY KEY CLUSTERED 
(
	[NotlarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Ogrenci]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ahmet_Ogrenci](
	[OgrenciId] [int] IDENTITY(1,1) NOT NULL,
	[OkulaGirisDonemi] [char](10) NULL,
	[OgrenciNo] [char](50) NULL,
	[OgrenciSinifi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ahmet_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrenciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ahmet_Ogretmen]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ahmet_Ogretmen](
	[OgretmenId] [int] IDENTITY(1,1) NOT NULL,
	[IseBaslama] [datetime] NOT NULL,
	[GecmisDeneyimler] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Ahmet_Ogretmen] PRIMARY KEY CLUSTERED 
(
	[OgretmenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ahmet_Veli]    Script Date: 7/25/2014 5:26:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ahmet_Veli](
	[VeliId] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciId] [int] NULL,
	[OgrenciNo] [char](50) NULL,
 CONSTRAINT [PK_Ahmet_Veli] PRIMARY KEY CLUSTERED 
(
	[VeliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ahmet_Bolum] ON 

INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (1, N'BTBS', 1)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (2, N'BSB', 1)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (3, N'Gi', 1)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (4, N'İBY', 1)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (5, N'UT', 1)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (6, N'İNŞAAT', 2)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (7, N'ENDÜSTRİ', 2)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (8, N'CERRAHİ', 3)
INSERT [dbo].[Ahmet_Bolum] ([BolumId], [Bolum], [FakulteId]) VALUES (9, N'KALP', 3)
SET IDENTITY_INSERT [dbo].[Ahmet_Bolum] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Cinsiyet] ON 

INSERT [dbo].[Ahmet_Cinsiyet] ([CinsiyetId], [Cinsiyet]) VALUES (1, N'ERKEK')
INSERT [dbo].[Ahmet_Cinsiyet] ([CinsiyetId], [Cinsiyet]) VALUES (2, N'KADIN')
SET IDENTITY_INSERT [dbo].[Ahmet_Cinsiyet] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Dersler] ON 

INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (1, N'bst123', N'programlama dilleri', N'ahmet', 1, NULL, NULL)
INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (2, N'bst124', N'veri tabanı', N'mehmet', 1, NULL, NULL)
INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (3, N'bst211', N'görsel programlama', N'ali', 2, NULL, NULL)
INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (4, N'bst213', N'ağ temelleri', N'ayşe', 2, NULL, NULL)
INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (5, N'bst321', N'sanallaştırm ve bulut', N'can', 3, NULL, NULL)
INSERT [dbo].[Ahmet_Dersler] ([DerslerId], [DersKodu], [DersAdi], [KiminVerdigi], [Donem], [OgrenciId], [OgretmenId]) VALUES (6, N'bst354', N'veri yapıları', N'akın', 3, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Ahmet_Dersler] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Fakulte] ON 

INSERT [dbo].[Ahmet_Fakulte] ([FakulteId], [Fakulte], [OgrenciId]) VALUES (1, N'UYGULAMALI BİLİMLER', NULL)
INSERT [dbo].[Ahmet_Fakulte] ([FakulteId], [Fakulte], [OgrenciId]) VALUES (2, N'MÜHENDİSLİK', NULL)
INSERT [dbo].[Ahmet_Fakulte] ([FakulteId], [Fakulte], [OgrenciId]) VALUES (3, N'TIP', NULL)
SET IDENTITY_INSERT [dbo].[Ahmet_Fakulte] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_GecmisEgitim] ON 

INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (16, 2010, 3.7, N'Beyoğlu Teknik', NULL, NULL, NULL)
INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (17, 2008, 4, N'dsfdfd', NULL, NULL, NULL)
INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (18, 1980, 3, N'adasdsa', NULL, NULL, NULL)
INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (19, 2009, 3.2, N'cxcvvxc', 19, NULL, NULL)
INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (20, 2000, 4, N'dasdsad', NULL, 27, NULL)
INSERT [dbo].[Ahmet_GecmisEgitim] ([GecmisId], [MezuniyetYil], [MezuniyetDerecesi], [MezunOkul], [OgrenciId], [OgretmenId], [MemurId]) VALUES (21, 1981, 5, N'dsadsa', NULL, 28, NULL)
SET IDENTITY_INSERT [dbo].[Ahmet_GecmisEgitim] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Kisisel] ON 

INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (52, N'24982166738', N'Ahmet', N'Albayrak', CAST(0x0000843700A969EC AS DateTime), 1, 1, N'ahmet@albayrak.net', N'(212) 256-7833 ', N'(553) 312-3782 ', N'Öğrenci', 16, NULL, NULL, NULL, 1, N'1122602039', N'24982166738')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (62, N'5345345    ', N'gfdgfdg', N'gsfdssdafd', CAST(0x0000A37300C64EAB AS DateTime), 1, 1, N'fdfsf', N'(532) 532-434  ', N'(432) 424-3324 ', N'dfdsfesfds', NULL, 25, NULL, NULL, 2, N'5345345', N'5345345')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (63, N'3242       ', N'dfsf', N'dsfdsfd', CAST(0x0000A37300C782F5 AS DateTime), 2, 1, N'dsfdsfds', N'(545) 665-4654 ', N'(342) 423-4243 ', N'fdsfsdf', 17, NULL, NULL, NULL, 1, N'21312321', N'3242')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (64, N'34242      ', N'rewrewrew', N'dfsfsdfdsf', CAST(0x0000A37300C7F05B AS DateTime), 2, 1, N'dsfsf', N'(4  )    -     ', N'(2  )    -     ', N'dfsdsf', NULL, 26, NULL, NULL, 2, N'34242', N'34242')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (65, N'132323     ', N'wdasd', N'dsadad', CAST(0x0000A37300E3818E AS DateTime), 1, 1, N'sadasd', N'(321) 313-1313 ', N'(211) 321-3213 ', N'dasdasdsa', 18, NULL, NULL, NULL, 1, N'1421343', N'132323')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (66, N'2314324    ', N'asdasdsa', N'sadsd', CAST(0x0000A37300E45062 AS DateTime), 1, 1, N'dasdasd', N'(321)    -     ', N'( 21)    -     ', N'dasdas', 19, NULL, NULL, NULL, 1, N'31231', N'2314324')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (67, N'231123     ', N'asdsdsa', N'dsadsada', CAST(0x0000A37300E5D4F9 AS DateTime), 2, 2, N'sadsa', N'(213) 21 -     ', N'(321) 321-312  ', N'ddasdasd', NULL, 27, NULL, NULL, 2, N'231123', N'231123')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (68, N'2132132    ', N'dsadsad', N'dsadasdas', CAST(0x0000A37300E791FB AS DateTime), 1, 1, N'dasdas', N'(321) 3  -     ', N'(231)    -     ', N'dsadas', NULL, 28, NULL, NULL, 2, N'2132132', N'2132132')
INSERT [dbo].[Ahmet_Kisisel] ([KisiselId], [TC], [Ad], [Soyad], [DogumTarih], [CinsiyetId], [MedeniDurumId], [Mail], [EvTel], [CepTel], [Unvan], [OgrenciId], [OgretmenId], [VeliId], [MemurId], [KullaniciTipiId], [KullaniciAdi], [Sifre]) VALUES (69, N'23132      ', N'mert', N'özkenar', CAST(0x0000A37300F45329 AS DateTime), 1, 1, N'wqqe', N'(132) 132-1321 ', N'(213) 132-1321 ', N'profesyonel memur', NULL, NULL, NULL, 3, 4, N'23132', N'23132')
SET IDENTITY_INSERT [dbo].[Ahmet_Kisisel] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_KullaniciTipi] ON 

INSERT [dbo].[Ahmet_KullaniciTipi] ([KullaniciTipiId], [Aciklama]) VALUES (1, N'ÖĞRENCİ')
INSERT [dbo].[Ahmet_KullaniciTipi] ([KullaniciTipiId], [Aciklama]) VALUES (2, N'ÖĞRETMEN')
INSERT [dbo].[Ahmet_KullaniciTipi] ([KullaniciTipiId], [Aciklama]) VALUES (3, N'VELİ')
INSERT [dbo].[Ahmet_KullaniciTipi] ([KullaniciTipiId], [Aciklama]) VALUES (4, N'MEMUR')
SET IDENTITY_INSERT [dbo].[Ahmet_KullaniciTipi] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_MedeniDurum] ON 

INSERT [dbo].[Ahmet_MedeniDurum] ([MedeniDurumId], [MedeniDurum]) VALUES (1, N'BEKAR')
INSERT [dbo].[Ahmet_MedeniDurum] ([MedeniDurumId], [MedeniDurum]) VALUES (2, N'EVLİ')
SET IDENTITY_INSERT [dbo].[Ahmet_MedeniDurum] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Memur] ON 

INSERT [dbo].[Ahmet_Memur] ([MemurId], [IseBaslama], [GecmisDeneyimler]) VALUES (1, CAST(0x000007DA00000000 AS DateTime), N'yok')
INSERT [dbo].[Ahmet_Memur] ([MemurId], [IseBaslama], [GecmisDeneyimler]) VALUES (2, CAST(0x0000A36800F0BBBC AS DateTime), N'sdadsad')
INSERT [dbo].[Ahmet_Memur] ([MemurId], [IseBaslama], [GecmisDeneyimler]) VALUES (3, CAST(0x0000A37200F45BDC AS DateTime), N'nasa')
SET IDENTITY_INSERT [dbo].[Ahmet_Memur] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Notlar] ON 

INSERT [dbo].[Ahmet_Notlar] ([NotlarId], [Vize], [Final], [Ortalama], [DerslerId], [OgrenciId]) VALUES (1, 100, 100, 100, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Ahmet_Notlar] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Ogrenci] ON 

INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (1, N'2012      ', N'1122                                              ', N'1')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (6, N'2009-2010 ', N'3                                                 ', N'2.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (7, N'2011-2012 ', N'4                                                 ', N'3.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (9, N'2009-2010 ', N'2342                                              ', N'4.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (10, N'2009-2010 ', N'324324                                            ', N'2.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (12, N'2009-2010 ', N'231313123                                         ', N'3.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (13, N'1983-1984 ', N'323123123                                         ', N'3.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (16, N'2012-2013 ', N'1122602039                                        ', N'3.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (17, N'1981-1982 ', N'21312321                                          ', N'4.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (18, N'1981-1982 ', N'1421343                                           ', N'3.Sınıf')
INSERT [dbo].[Ahmet_Ogrenci] ([OgrenciId], [OkulaGirisDonemi], [OgrenciNo], [OgrenciSinifi]) VALUES (19, N'2009-2010 ', N'31231                                             ', N'3.Sınıf')
SET IDENTITY_INSERT [dbo].[Ahmet_Ogrenci] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Ogretmen] ON 

INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (1, CAST(0x000007D900000000 AS DateTime), N'bilsar tekstil')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (10, CAST(0x0000A35C00BC43B4 AS DateTime), N'sadaa')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (11, CAST(0x0000A35E00BC5674 AS DateTime), N'sadsadsxzcxz')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (12, CAST(0x0000A35B00BC95BC AS DateTime), N'dddeeneme')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (13, CAST(0x0000A35D00BCE1E8 AS DateTime), N'lkljlmçölkl')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (14, CAST(0x0000A36400BF83BC AS DateTime), N'xczxczxc')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (15, CAST(0x0000A37300C00427 AS DateTime), N'dccccsd')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (16, CAST(0x0000A35C00C09144 AS DateTime), N'rtretertert')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (17, CAST(0x0000A37300C12627 AS DateTime), N'edsdfdfdf')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (18, CAST(0x0000A37300C30F95 AS DateTime), N'asdasdasd')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (23, CAST(0x0000A37300C5A9E2 AS DateTime), N'sdfsdfdsfsf')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (24, CAST(0x0000A37300C6042A AS DateTime), N'dfdfdsfdsf')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (25, CAST(0x0000A37300C651FD AS DateTime), N'fdsfdsfdsfds')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (26, CAST(0x0000A37300C7F3DF AS DateTime), N'sfdsfs')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (27, CAST(0x0000A37300E5D7EA AS DateTime), N'sdasad')
INSERT [dbo].[Ahmet_Ogretmen] ([OgretmenId], [IseBaslama], [GecmisDeneyimler]) VALUES (28, CAST(0x0000A37300E79594 AS DateTime), N'asdsadsa')
SET IDENTITY_INSERT [dbo].[Ahmet_Ogretmen] OFF
SET IDENTITY_INSERT [dbo].[Ahmet_Veli] ON 

INSERT [dbo].[Ahmet_Veli] ([VeliId], [OgrenciId], [OgrenciNo]) VALUES (3, 7, N'4                                                 ')
SET IDENTITY_INSERT [dbo].[Ahmet_Veli] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Ahmet_Kisisel]    Script Date: 7/25/2014 5:26:26 PM ******/
ALTER TABLE [dbo].[Ahmet_Kisisel] ADD  CONSTRAINT [IX_Ahmet_Kisisel] UNIQUE NONCLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Ahmet_Ogrenci]    Script Date: 7/25/2014 5:26:26 PM ******/
ALTER TABLE [dbo].[Ahmet_Ogrenci] ADD  CONSTRAINT [IX_Ahmet_Ogrenci] UNIQUE NONCLUSTERED 
(
	[OgrenciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ahmet_Bolum]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Bolum_Ahmet_Fakulte] FOREIGN KEY([FakulteId])
REFERENCES [dbo].[Ahmet_Fakulte] ([FakulteId])
GO
ALTER TABLE [dbo].[Ahmet_Bolum] CHECK CONSTRAINT [FK_Ahmet_Bolum_Ahmet_Fakulte]
GO
ALTER TABLE [dbo].[Ahmet_Dersler]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Dersler_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_Dersler] CHECK CONSTRAINT [FK_Ahmet_Dersler_Ahmet_Ogrenci]
GO
ALTER TABLE [dbo].[Ahmet_Dersler]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Dersler_Ahmet_Ogretmen] FOREIGN KEY([OgretmenId])
REFERENCES [dbo].[Ahmet_Ogretmen] ([OgretmenId])
GO
ALTER TABLE [dbo].[Ahmet_Dersler] CHECK CONSTRAINT [FK_Ahmet_Dersler_Ahmet_Ogretmen]
GO
ALTER TABLE [dbo].[Ahmet_Fakulte]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Fakulte_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_Fakulte] CHECK CONSTRAINT [FK_Ahmet_Fakulte_Ahmet_Ogrenci]
GO
ALTER TABLE [dbo].[Ahmet_GecmisEgitim]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_GecmisEgitim_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_GecmisEgitim] CHECK CONSTRAINT [FK_Ahmet_GecmisEgitim_Ahmet_Ogrenci]
GO
ALTER TABLE [dbo].[Ahmet_GecmisEgitim]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_GecmisEgitim_Ahmet_Ogretmen] FOREIGN KEY([OgretmenId])
REFERENCES [dbo].[Ahmet_Ogretmen] ([OgretmenId])
GO
ALTER TABLE [dbo].[Ahmet_GecmisEgitim] CHECK CONSTRAINT [FK_Ahmet_GecmisEgitim_Ahmet_Ogretmen]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Cinsiyet] FOREIGN KEY([CinsiyetId])
REFERENCES [dbo].[Ahmet_Cinsiyet] ([CinsiyetId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Cinsiyet]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_KullaniciTipi] FOREIGN KEY([KullaniciTipiId])
REFERENCES [dbo].[Ahmet_KullaniciTipi] ([KullaniciTipiId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_KullaniciTipi]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_MedeniDurum] FOREIGN KEY([MedeniDurumId])
REFERENCES [dbo].[Ahmet_MedeniDurum] ([MedeniDurumId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_MedeniDurum]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Memur] FOREIGN KEY([MemurId])
REFERENCES [dbo].[Ahmet_Memur] ([MemurId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Memur]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Memur1] FOREIGN KEY([MemurId])
REFERENCES [dbo].[Ahmet_Memur] ([MemurId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Memur1]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Ogrenci]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Ogretmen] FOREIGN KEY([OgretmenId])
REFERENCES [dbo].[Ahmet_Ogretmen] ([OgretmenId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Ogretmen]
GO
ALTER TABLE [dbo].[Ahmet_Kisisel]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Veli] FOREIGN KEY([VeliId])
REFERENCES [dbo].[Ahmet_Veli] ([VeliId])
GO
ALTER TABLE [dbo].[Ahmet_Kisisel] CHECK CONSTRAINT [FK_Ahmet_Kisisel_Ahmet_Veli]
GO
ALTER TABLE [dbo].[Ahmet_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Notlar_Ahmet_Dersler] FOREIGN KEY([DerslerId])
REFERENCES [dbo].[Ahmet_Dersler] ([DerslerId])
GO
ALTER TABLE [dbo].[Ahmet_Notlar] CHECK CONSTRAINT [FK_Ahmet_Notlar_Ahmet_Dersler]
GO
ALTER TABLE [dbo].[Ahmet_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Notlar_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_Notlar] CHECK CONSTRAINT [FK_Ahmet_Notlar_Ahmet_Ogrenci]
GO
ALTER TABLE [dbo].[Ahmet_Veli]  WITH CHECK ADD  CONSTRAINT [FK_Ahmet_Veli_Ahmet_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ahmet_Ogrenci] ([OgrenciId])
GO
ALTER TABLE [dbo].[Ahmet_Veli] CHECK CONSTRAINT [FK_Ahmet_Veli_Ahmet_Ogrenci]
GO
