USE [JJOO]
GO
/****** Object:  Table [dbo].[Deportes]    Script Date: 22/8/2024 16:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportes](
	[IDdeporte] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Foto] [text] NOT NULL,
 CONSTRAINT [PK_Deportes] PRIMARY KEY CLUSTERED 
(
	[IDdeporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 22/8/2024 16:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportistas](
	[Apellido] [varchar](200) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[FechaDeNacimiento] [date] NOT NULL,
	[Foto] [text] NOT NULL,
	[IDdeportista] [int] IDENTITY(1,1) NOT NULL,
	[IDpais] [int] NOT NULL,
	[IDdeporte] [int] NOT NULL,
 CONSTRAINT [PK_Deportista] PRIMARY KEY CLUSTERED 
(
	[IDdeportista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 22/8/2024 16:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[IDpais] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[Bandera] [text] NOT NULL,
	[FechaFundacion] [date] NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[IDpais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Deportes] ([IDdeporte], [Nombre], [Foto]) VALUES (1, N'Futbol', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXHDmO8yu5IdpQhIq3M6PLE_lN9CY-sOKaNQ&s')
INSERT [dbo].[Deportes] ([IDdeporte], [Nombre], [Foto]) VALUES (2, N'Baloncesto', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrhsMg4d_NXc25cJ-doqIE9d7JBQJo57sErw&s')
INSERT [dbo].[Deportes] ([IDdeporte], [Nombre], [Foto]) VALUES (3, N'Hockey', N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQmcuV9iS8AlLbViBpO60cuWENDMDL9EyXMg&s')
INSERT [dbo].[Deportes] ([IDdeporte], [Nombre], [Foto]) VALUES (4, N'Tenis', N'https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Tennis_pictogram.svg/800px-Tennis_pictogram.svg.png')
GO
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Cerundolo', N'Francisco', CAST(N'1998-08-13' AS Date), N'https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSjMftwjLN2BQ0gVdBhch-CpTuD3gmjNgFhCQNfNWgtlkYa7oZ6FfHnRKK0V-AspDwf', 1, 4);
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Lebron', N'James', CAST(N'1984-12-30' AS Date), N'https://img.olympics.com/images/image/private/t_social_share_thumb/f_auto/v1672757509/primary/n8oqmhtvrf9lc6hkszlj', 3, 2);
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Cuevas', N'Pablo', CAST(N'1986-01-01' AS Date), N'https://www.atptour.com//-/media/images/news/2023/06/26/19/46/cuevas-wimbledon-2023.jpg', 2, 4);
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Louzada', N'Didi', CAST(N'1998-03-22' AS Date), N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTFDXsEo8_fOIjtcT9J3_0N0PS840Uq8rx-IdUUV4GIA_DfEBPT8yv7lJY9ApjmzY5f_8E&usqp=CAU', 4, 2);
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Rey', N'Matias', CAST(N'1984-12-01' AS Date), N'https://argentinadorada.com.ar/img/perfiles/TNGoEXjA41SIbGOOjwCb80dZNqIQfOobbJn.jpg', 1, 3);
INSERT [dbo].[Deportistas] ([Apellido], [Nombre], [FechaDeNacimiento], [Foto], [IDpais], [IDdeporte])
VALUES (N'Almada', N'Thiago', CAST(N'2002-01-26' AS Date), N'https://media.lmneuquen.com/p/808a41daf4eac51b61015f380fe2d8af/adjuntos/195/imagenes/007/735/0007735096/770x0/smart/thiago-almadajpg.jpg', 1, 1);
GO
INSERT [dbo].[Pais] ([IDpais], [nombre], [Bandera], [FechaFundacion]) VALUES (1, N'argentina', N'https://c.files.bbci.co.uk/D348/production/_95588045_178392703.jpg', CAST(N'2022-10-10' AS Date))
INSERT [dbo].[Pais] ([IDpais], [nombre], [Bandera], [FechaFundacion]) VALUES (2, N'Uruguay', N'https://img.freepik.com/vector-premium/bandera-uruguay-bandera-uruguay-ilustracion-bandera-uruguay-fondo-uruguayo_847658-25.jpg', CAST(N'1900-10-21' AS Date))
INSERT [dbo].[Pais] ([IDpais], [nombre], [Bandera], [FechaFundacion]) VALUES (3, N'Estados Unidos', N'https://img.freepik.com/vector-premium/ondeando-bandera-estados-unidos_263779-93.jpg', CAST(N'1780-07-04' AS Date))
INSERT [dbo].[Pais] ([IDpais], [nombre], [Bandera], [FechaFundacion]) VALUES (4, N'Brasil', N'https://st3.depositphotos.com/1400713/33139/v/450/depositphotos_331392400-stock-illustration-waving-flag-of-brazil-vector.jpg', CAST(N'1929-03-17' AS Date))
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Deportes] FOREIGN KEY([IDdeporte])
REFERENCES [dbo].[Deportes] ([IDdeporte])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportista_Deportes]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Pais] FOREIGN KEY([IDpais])
REFERENCES [dbo].[Pais] ([IDpais])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportista_Pais]
GO
