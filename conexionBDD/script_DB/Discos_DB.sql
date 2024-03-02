use master
go
create database DISCOS_DB
go
USE DISCOS_DB
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTILOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_ESTILOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
USE DISCOS_DB
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOSEDICION](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOSEDICION] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
USE DISCOS_DB
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DISCOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](100) NULL,
	[FechaLanzamiento] [smalldatetime] NULL,
	[CantidadCanciones] [int] NULL,
	[UrlImagenTapa] [varchar](200) NULL,
	[IdEstilo] [int] NULL,
	[IdTipoEdicion] [int] NULL,
 CONSTRAINT [PK_DISCOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
)
GO
USE DISCOS_DB
GO
insert into estilos values ('Pop Punk')
insert into estilos values ('Pop')
insert into estilos values ('Rock')
insert into estilos values ('Trap')
insert into estilos values ('Rap')
insert into estilos values ('Grunge')
insert into TIPOSEDICION values ('Vinilo')
insert into TIPOSEDICION values ('Álbum')
insert into TIPOSEDICION values ('EP')
insert into TIPOSEDICION values ('Mix Tape')
insert into TIPOSEDICION values ('CD')
insert into TIPOSEDICION values ('Tape')
insert into DISCOS values ('Trapicheo', '15-05-2022', 10, 'https://images.genius.com/0e445bb9b81a5e696dfddd1ebf86c32d.1000x1000x1.png', 5, 4)
insert into DISCOS values ('Antezana 247', '11-11-2018', 9, 'https://images.genius.com/2cb6b4c8f2642d1ac6264b26aafb12f8.600x600x1.jpg', 5, 7)
insert into DISCOS values ('The Eminem Show', '26-05-2002', 19, 'https://contentv2.tap-commerce.com/cover/large/606949329020_1.jpg?id_com=1156', 6, 7)
insert into DISCOS values ('Nada Personal', '21-11-1985', 10, 'https://mylongplay.com/cdn/shop/products/soda_stereo_nada_personal_1200x.jpg?v=1546487423', 3, 2)