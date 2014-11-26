USE [GD2C2014]
GO
/****** Object:  Schema [QWERTY]    Script Date: 10/11/2014 18:49:09 ******/
CREATE SCHEMA [QWERTY] AUTHORIZATION [dbo]
GO
/****** Object:  Table [QWERTY].[Roles]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*ALTER TABLE qwerty.roles DROP CONSTRAINT FK__cities__state__6442E2C9;*/
IF OBJECT_ID(N'qwerty.roles', N'U') IS NOT NULL
	DROP TABLE qwerty.roles;
CREATE TABLE [QWERTY].[Roles](
	[Rol_ID] [int] NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Rol_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [QWERTY].[Usuarios]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID(N'qwerty.usuarios', N'U') IS NOT NULL
	DROP TABLE qwerty.usuarios;
CREATE TABLE [QWERTY].[Usuarios](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[DNI] [bigint] NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefono] [bigint] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
	[status][char] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO


IF OBJECT_ID(N'qwerty.historia_usuarios', N'U') IS NOT NULL
	DROP TABLE qwerty.historia_usuarios;
CREATE TABLE [QWERTY].[historia_Usuarios](
	[Username] [varchar](50) UNIQUE NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[DNI] [bigint] NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefono] [bigint] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
	[status][char] NOT NULL,
 CONSTRAINT [PK_hist_usuarios] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
/****** Object:  Table [QWERTY].[Consumibles]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID(N'qwerty.consumibles', N'U') IS NOT NULL
	DROP TABLE qwerty.consumibles;
CREATE TABLE [QWERTY].[Consumibles](
	[Consumible_ID] [int] NOT NULL,
	[Producto] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
 CONSTRAINT [PK_Consumibles] PRIMARY KEY CLUSTERED 
(
	[Consumible_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Clientes]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.clientes', N'U') IS NOT NULL
	DROP TABLE qwerty.clientes;
CREATE TABLE [QWERTY].[Clientes](
	[Cliente_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[Telefono] [bigint] NULL,
	[Calle] [varchar](50) NOT NULL,
	[Nro] [int] NOT NULL,
	[Piso] [int] NOT NULL,
	[Depto] [varchar](20) NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
	[Tipo_Doc_ID] [int],
	[Nro_Doc] [varchar](100)
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Cliente_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [QWERTY].[Funcionalidades]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID(N'qwerty.funcionalidades', N'U') IS NOT NULL
	DROP TABLE qwerty.funcionalidades;
CREATE TABLE [QWERTY].[Funcionalidades](
	[Funcionalidad_ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Funcionalidades] PRIMARY KEY CLUSTERED 
(
	[Funcionalidad_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [QWERTY].[Hotel]    Script: Modificado por Fede ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.hotel', N'U') IS NOT NULL
	DROP TABLE qwerty.hotel;
CREATE TABLE [QWERTY].[Hotel](
	[Hotel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) ,
	[Mail] [nvarchar](50) ,
	[Telefono] [nvarchar](20),
	[Direccion] [varchar](255),
	[Estrellas] [int],
	[Ciudad] [nvarchar](255),
	[Pais] [nvarchar](255),
	[Fecha_creacion] [date],
	Estado int default 1,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[Hotel_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Regimen]    Script Date: 10/11/2014 18:49:09 MODIFICADO POR FEDE******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.regimen', N'U') IS NOT NULL
	DROP TABLE qwerty.regimen;
CREATE TABLE [QWERTY].[Regimen](
	[Regimen_ID][int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Regimen] PRIMARY KEY CLUSTERED 
(
	[Regimen_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
IF OBJECT_ID(N'qwerty.personal_hoteles', N'U') IS NOT NULL
	DROP TABLE qwerty.personal_hoteles;
CREATE TABLE [QWERTY].[Personal_hoteles](
	[Username] [varchar](50) NOT NULL,
	[Hotel_ID] [int] NOT NULL,
 CONSTRAINT [PK_Personal_hoteles] PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Hotel_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Hotel_Regimenes]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID(N'qwerty.hotel_regimenes', N'U') IS NOT NULL
	DROP TABLE qwerty.hotel_regimenes;
CREATE TABLE [QWERTY].[Hotel_Regimenes](
	[Hotel_ID] [int] NOT NULL,
	[Regimen_ID] [int] NOT NULL,
 CONSTRAINT [PK_Hotel_Regimenes] PRIMARY KEY CLUSTERED 
(
	[Hotel_ID] ASC,
	[Regimen_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [QWERTY].[Usuarios_Roles]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.usuarios_roles', N'U') IS NOT NULL
	DROP TABLE qwerty.usuarios_roles;
CREATE TABLE [QWERTY].[Usuarios_Roles](
	[Username] [varchar](50) NOT NULL,
	[Rol_ID] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios_Roles] PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Rol_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Roles_Funcionalidades]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID(N'qwerty.Roles_Funcionalidades', N'U') IS NOT NULL
	DROP TABLE qwerty.Roles_Funcionalidades;
CREATE TABLE [QWERTY].[Roles_Funcionalidades](
	[Rol_ID] [int] NOT NULL,
	[Funcionalidad_ID] [int] NOT NULL,
 CONSTRAINT [PK_Roles_Funcionalidades] PRIMARY KEY CLUSTERED 
(
	[Rol_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [QWERTY].[Reservas]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID(N'qwerty.reservas', N'U') IS NOT NULL
	DROP TABLE qwerty.reservas;
CREATE TABLE [QWERTY].[Reservas](
	[Reserva_ID] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_inicio] [date] NOT NULL,
	[Fecha_fin] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Cliente_ID] [int] NOT NULL,
	[Descripcion_ID] [int] NOT NULL,
	[CodRegimen] [varchar](50),
	[Codigo] [varchar](50),
	[Fecha_Reserva] [date],
	mail varchar(50),
	pasaporte varchar(50),
	habitacion int,
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[Reserva_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [QWERTY].[Reservas_canceladas]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.reservas_canceladas', N'U') IS NOT NULL
	DROP TABLE qwerty.reservas_canceladas;
CREATE TABLE [QWERTY].[Reservas_canceladas](
	[Reserva_ID] [int] NOT NULL,
	[Cliente_ID] [int] NOT NULL,
	[Motivo] [nchar](10) NOT NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reservas_canceladas] PRIMARY KEY CLUSTERED 
(
	[Reserva_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Facturacion]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.facturacion', N'U') IS NOT NULL
	DROP TABLE qwerty.facturacion;
CREATE TABLE [QWERTY].[Facturacion](
	[Nro_Factura] [int] NOT NULL,
	[Estadia_ID] [int] NOT NULL,
	Fecha date,
	Total int
 CONSTRAINT [PK_Facturacion2] PRIMARY KEY CLUSTERED 
(
	[Nro_Factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Descripcion_reservas]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF OBJECT_ID(N'qwerty.descripcion_reservas', N'U') IS NOT NULL
	DROP TABLE qwerty.descripcion_reservas;
CREATE TABLE [QWERTY].[Descripcion_reservas](
	[Descripcion_ID] [int] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Descripcion_reservas] PRIMARY KEY CLUSTERED 
(
	[Descripcion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[ConsumicionesPorReserva]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID(N'qwerty.consumicionesPorReserva', N'U') IS NOT NULL
	DROP TABLE qwerty.consumicionesPorReserva;
CREATE TABLE [QWERTY].[ConsumicionesPorReserva](
	[Consumicion_ID] [int] NOT NULL,
	[Consumible_ID] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Reserva_ID] [int] NOT NULL,
 CONSTRAINT [PK_ConsumicionesPorReserva] PRIMARY KEY CLUSTERED 
(
	[Consumicion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/*tipo habitacion*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [QWERTY].[Tipo_Habitacion](
	[Tipo_Habitacion_ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255),
	 [Codigo] [numeric](18),
	 [Porcentual] [numeric](18,2),
 CONSTRAINT [PK_Tipo_Habitacion] PRIMARY KEY CLUSTERED 
(
	[Tipo_Habitacion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [QWERTY].[Estadia](
	[Estadia_ID] [int] IDENTITY(1,1) NOT NULL,
	[Reserva_ID] [int] not null,
	[Fecha_Inicio] [datetime],
	[Fecha_Fin] [datetime],
	 [Usuario_Registra_Entrada] int,
	 [Usuario_Registra_Salida] int,
	 [CodReserva] numeric(18),
 CONSTRAINT [PK_Estadia] PRIMARY KEY CLUSTERED 
(
	[Estadia_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO


/****** Object:  Table [QWERTY].[Habitaciones]    Script: Modificado por Fede******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID(N'qwerty.habitaciones', N'U') IS NOT NULL
	DROP TABLE qwerty.habitaciones;
CREATE TABLE [QWERTY].[Habitaciones](
	[Habitacion_ID] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nvarchar](10) ,
	[Piso] [nvarchar](10) ,
	[Ubicacion] [varchar](250) ,
	[Tipo_ID] int ,
	[Descripcion] [varchar](255) ,
	 [Hotel_ID] int,
 CONSTRAINT [PK_Habitaciones] PRIMARY KEY CLUSTERED 
(
	[Habitacion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

/****** Object:  Table [QWERTY].[Hotel_Habitaciones]    Script Date: 10/11/2014 18:49:09 ******/
/*SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID(N'qwerty.hotel_habitaciones', N'U') IS NOT NULL
	DROP TABLE qwerty.hotel_habitaciones;
CREATE TABLE [QWERTY].[Hotel_Habitaciones](
	[Hotel_ID] [int] NOT NULL,
	[Habitacion_ID] [int] NOT NULL,
 CONSTRAINT [PK_Hotel_Habitaciones] PRIMARY KEY CLUSTERED 
(
	[Hotel_ID] ASC,
	[Habitacion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
*/
/*creo y cargo tabla Tipo_Doc*/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create table [QWERTY].[Tipo_Doc](
Tipo_Doc_ID int NOT NULL IDENTITY(1,1),
Descripcion nvarchar(50) NOT NULL,
Primary key (Tipo_Doc_ID)
);
insert into QWERTY.Tipo_Doc(Descripcion) values ('Pasaporte')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LE')
insert into QWERTY.Tipo_Doc(Descripcion) values ('DNI')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LC')
insert into QWERTY.Tipo_Doc(Descripcion) values ('CI')


IF OBJECT_ID(N'qwerty.reservas_habitaciones', N'U') IS NOT NULL
	DROP TABLE qwerty.reservas_habitaciones;
CREATE TABLE [QWERTY].[Reservas_Habitaciones](
	[Reserva_ID] [int] NOT NULL,
	[Habitacion_ID] [int] NOT NULL,
 CONSTRAINT [PK_Reservas_Habitaciones] PRIMARY KEY CLUSTERED 
(
	[Reserva_ID] ASC,
	[Habitacion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  ForeignKey [FK_ConsumicionesPorReserva_Consumibles]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[ConsumicionesPorReserva]  WITH CHECK ADD  CONSTRAINT [FK_ConsumicionesPorReserva_Consumibles] FOREIGN KEY([Consumible_ID])
REFERENCES [QWERTY].[Consumibles] ([Consumible_ID])
GO
ALTER TABLE [QWERTY].[ConsumicionesPorReserva] CHECK CONSTRAINT [FK_ConsumicionesPorReserva_Consumibles]
GO
/****** Object:  ForeignKey [FK_ConsumicionesPorReserva_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[ConsumicionesPorReserva]  WITH CHECK ADD  CONSTRAINT [FK_ConsumicionesPorReserva_Reservas] FOREIGN KEY([Reserva_ID])
REFERENCES [QWERTY].[Reservas] ([Reserva_ID])
GO
ALTER TABLE [QWERTY].[ConsumicionesPorReserva] CHECK CONSTRAINT [FK_ConsumicionesPorReserva_Reservas]
GO

/************************************************************************/

/****** Object:  ForeignKey [FK_Habitaciones_Hotel]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Habitaciones_Hotel] FOREIGN KEY([Hotel_ID])
REFERENCES [QWERTY].[Hotel] ([Hotel_ID])
GO
ALTER TABLE [QWERTY].[Habitaciones] CHECK CONSTRAINT [FK_Habitaciones_Hotel]
GO

/****** Object:  ForeignKey [FK_Habitaciones_Tipo]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Habitacion] FOREIGN KEY([Tipo_ID])
REFERENCES [QWERTY].[Tipo_Habitacion] ([Tipo_Habitacion_ID])
GO
ALTER TABLE [QWERTY].[Habitaciones] CHECK CONSTRAINT [FK_Tipo_Habitacion]
GO

/****** Object:  ForeignKey [FK_Descripcion_reservas_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Descripcion_reservas]  WITH CHECK ADD  CONSTRAINT [FK_Descripcion_reservas_Reservas] FOREIGN KEY([Descripcion_ID])
REFERENCES [QWERTY].[Reservas] ([Reserva_ID])
GO
ALTER TABLE [QWERTY].[Descripcion_reservas] CHECK CONSTRAINT [FK_Descripcion_reservas_Reservas]
GO
/* constraint tipo doc*/
ALTER TABLE [QWERTY].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_Doc_ID])
REFERENCES [QWERTY].[Tipo_Doc] ([Tipo_Doc_ID])
GO
ALTER TABLE [QWERTY].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO


/****** Object:  ForeignKey [FK_Hotel_Regimenes_Hotel]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Hotel_Regimenes]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Regimenes_Hotel] FOREIGN KEY([Hotel_ID])
REFERENCES [QWERTY].[Hotel] ([Hotel_ID])
GO
ALTER TABLE [QWERTY].[Hotel_Regimenes] CHECK CONSTRAINT [FK_Hotel_Regimenes_Hotel]
GO
/****** Object:  ForeignKey [FK_Hotel_Regimenes_Regimen]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Hotel_Regimenes]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Regimenes_Regimen] FOREIGN KEY([Regimen_ID])
REFERENCES [QWERTY].[Regimen] ([Regimen_ID])
GO
ALTER TABLE [QWERTY].[Hotel_Regimenes] CHECK CONSTRAINT [FK_Hotel_Regimenes_Regimen]
GO
/****** Object:  ForeignKey [FK_Personal_hoteles_Hotel]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Personal_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_Personal_hoteles_Hotel] FOREIGN KEY([Hotel_ID])
REFERENCES [QWERTY].[Hotel] ([Hotel_ID])
GO
ALTER TABLE [QWERTY].[Personal_hoteles] CHECK CONSTRAINT [FK_Personal_hoteles_Hotel]
GO
/****** Object:  ForeignKey [FK_Personal_hoteles_Usuarios]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Personal_hoteles]  WITH CHECK ADD  CONSTRAINT [FK_Personal_hoteles_Usuarios] FOREIGN KEY([Username])
REFERENCES [QWERTY].[Usuarios] ([Username])
GO
ALTER TABLE [QWERTY].[Personal_hoteles] CHECK CONSTRAINT [FK_Personal_hoteles_Usuarios]
GO
/****** Object:  ForeignKey [FK_Reservas_Clientes]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Reservas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_Clientes] FOREIGN KEY([Cliente_ID])
REFERENCES [QWERTY].[Clientes] ([Cliente_ID])
GO
ALTER TABLE [QWERTY].[Reservas] CHECK CONSTRAINT [FK_Reservas_Clientes]
GO



/****** Object:  ForeignKey [FK_Reservas_canceladas_Clientes]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Reservas_canceladas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_canceladas_Clientes] FOREIGN KEY([Cliente_ID])
REFERENCES [QWERTY].[Clientes] ([Cliente_ID])
GO
ALTER TABLE [QWERTY].[Reservas_canceladas] CHECK CONSTRAINT [FK_Reservas_canceladas_Clientes]
GO
/****** Object:  ForeignKey [FK_Reservas_canceladas_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Reservas_canceladas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_canceladas_Reservas] FOREIGN KEY([Reserva_ID])
REFERENCES [QWERTY].[Reservas] ([Reserva_ID])
GO
ALTER TABLE [QWERTY].[Reservas_canceladas] CHECK CONSTRAINT [FK_Reservas_canceladas_Reservas]
GO
/****** Object:  ForeignKey [FK_Reservas_canceladas_Usuarios]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Reservas_canceladas]  WITH CHECK ADD  CONSTRAINT [FK_Reservas_canceladas_Usuarios] FOREIGN KEY([Username])
REFERENCES [QWERTY].[Usuarios] ([Username])
GO
ALTER TABLE [QWERTY].[Reservas_canceladas] CHECK CONSTRAINT [FK_Reservas_canceladas_Usuarios]
GO
/****** Object:  ForeignKey [FK_Roles_Funcionalidades_Funcionalidades]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Roles_Funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_Roles_Funcionalidades_Funcionalidades] FOREIGN KEY([Funcionalidad_ID])
REFERENCES [QWERTY].[Funcionalidades] ([Funcionalidad_ID])
GO
ALTER TABLE [QWERTY].[Roles_Funcionalidades] CHECK CONSTRAINT [FK_Roles_Funcionalidades_Funcionalidades]
GO
/****** Object:  ForeignKey [FK_Roles_Funcionalidades_Roles]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Roles_Funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_Roles_Funcionalidades_Roles] FOREIGN KEY([Rol_ID])
REFERENCES [QWERTY].[Roles] ([Rol_ID])
GO
ALTER TABLE [QWERTY].[Roles_Funcionalidades] CHECK CONSTRAINT [FK_Roles_Funcionalidades_Roles]
GO
/****** Object:  ForeignKey [FK_Usuarios_Roles_Roles]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Usuarios_Roles]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Roles_Roles] FOREIGN KEY([Rol_ID])
REFERENCES [QWERTY].[Roles] ([Rol_ID])
GO
ALTER TABLE [QWERTY].[Usuarios_Roles] CHECK CONSTRAINT [FK_Usuarios_Roles_Roles]
GO
/****** Object:  ForeignKey [FK_Usuarios_Roles_Usuarios]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Usuarios_Roles]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Roles_Usuarios] FOREIGN KEY([Username])
REFERENCES [QWERTY].[Usuarios] ([Username])
GO
ALTER TABLE [QWERTY].[Usuarios_Roles] CHECK CONSTRAINT [FK_Usuarios_Roles_Usuarios]
GO

/****** Object:  ForeignKey [FK_Facturacion_Estadia]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Estadia] FOREIGN KEY([Estadia_ID])
REFERENCES [QWERTY].[Estadia] ([Estadia_ID])
GO
ALTER TABLE [QWERTY].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Estadia]
GO


/* INDICES */
CREATE INDEX indexMaestra
    ON gd_esquema.Maestra(Cliente_Pasaporte_Nro);
    
CREATE INDEX indexHabitaciones
    ON gd_esquema.Maestra(Habitacion_Numero);


CREATE INDEX indexDocCliente
    ON QWERTY.Clientes(Nro_Doc);

CREATE INDEX indexReserva
    ON Qwerty.Reservas(Codigo);
    
    
/*inserto hoteles*/
insert into QWERTY.Hotel (Nombre,Mail,Telefono,Direccion,Estrellas,Ciudad,Pais,Fecha_creacion)
select distinct
rtrim(Hotel_Ciudad) + ', ' + Hotel_Calle + ' ' + CONVERT(nvarchar,Hotel_Nro_Calle) as nombre,
'desconocido' as mail,
'desconocido' as telefono,
Hotel_Calle+ ' ' + CONVERT(nvarchar,Hotel_Nro_Calle) as direccion,
Hotel_CantEstrella,
Hotel_Ciudad,   
'Argentina',
CURRENT_TIMESTAMP
     
from gd_esquema.Maestra 
where Hotel_Ciudad is not null
order by Hotel_Ciudad;


/*inserto tipo habitaciones*/
insert into QWERTY.Tipo_Habitacion (Codigo,Descripcion,Porcentual)
select distinct M.Habitacion_Tipo_Codigo, M.Habitacion_Tipo_Descripcion, M.Habitacion_Tipo_Porcentual from gd_esquema.Maestra M;


/*inserto habitaciones*/
insert into QWERTY.Habitaciones (Numero, Piso, Ubicacion, Descripcion, Hotel_ID, Tipo_ID )
select distinct 
CONVERT(nvarchar,Habitacion_Numero),
CONVERT(nvarchar,Habitacion_Piso),
Habitacion_Frente,
'No cargada',
(select top 1 H.Hotel_ID from QWERTY.Hotel H 
where H.Ciudad = Hotel_Ciudad and
Hotel_Calle+ ' ' + CONVERT(nvarchar,Hotel_Nro_Calle) = H.Direccion and
H.Estrellas = Hotel_CantEstrella ) as hotel,
(select top 1 T.Tipo_Habitacion_ID from QWERTY.Tipo_Habitacion T
where T.Descripcion = Habitacion_Tipo_Descripcion
and T.Codigo = Habitacion_Tipo_Codigo
and T.Porcentual = Habitacion_Tipo_Porcentual)


from gd_esquema.Maestra;

/* inserto regimenes*/
insert into QWERTY.Regimen (Codigo,Descripcion,Precio,Estado)
select distinct 
'',Regimen_Descripcion, Regimen_Precio,1 
from gd_esquema.Maestra;

update QWERTY.Regimen 
set Codigo = Regimen_ID;


/*Cargo tabla Clientes*/
insert into QWERTY.Clientes (Nombre,Apellido,Mail,Calle,
Nro,Piso,Depto,Nacionalidad,Fecha_nacimiento,Tipo_Doc_ID,Nro_Doc) 
select distinct m.Cliente_Nombre,m.Cliente_Apellido,m.Cliente_Mail,
m.Cliente_Dom_Calle,m.Cliente_Nro_Calle,m.Cliente_Piso,m.Cliente_Depto,
m.Cliente_Nacionalidad,m.Cliente_Fecha_Nac,1,m.Cliente_Pasaporte_Nro from gd_esquema.Maestra m


/*Cargo tabla Consumibles*/
insert into QWERTY.Consumibles (Consumible_ID,Producto,Precio)
select distinct m.Consumible_Codigo, m.Consumible_Descripcion,m.Consumible_Precio 
from gd_esquema.Maestra m where m.Consumible_Codigo is not null




/*creo y cargo tabla Tipo_Doc*/
/*create table qwerty.Tipo_Doc(
Tipo_Doc_ID int NOT NULL IDENTITY(1,1),
Descripcion nvarchar(50) NOT NULL,
Primary key (Tipo_Doc_ID)
);
insert into QWERTY.Tipo_Doc(Descripcion) values ('Pasaporte')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LE')
insert into QWERTY.Tipo_Doc(Descripcion) values ('DNI')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LC')
insert into QWERTY.Tipo_Doc(Descripcion) values ('CI')
*/


/*cargo reservas*/

insert into QWERTY.Reservas (Fecha_inicio, 
Fecha_fin, estado, Cliente_ID , pasaporte, mail,Descripcion_ID,  CodRegimen, Fecha_Reserva, Codigo, habitacion)
select distinct 
M.Reserva_Fecha_Inicio, 
dateadd(day,M.Reserva_Cant_Noches,M.Reserva_Fecha_Inicio) as fin,
1 as estado,
1 as cliente_id,
M.Cliente_Pasaporte_Nro,
M.Cliente_Mail,
1 as descripcion,
(select Regimen_ID from QWERTY.Regimen R where R.Precio = M.Regimen_Precio and R.Descripcion like M.Regimen_descripcion) as regimen,
(SELECT CONVERT(DATE,GETDATE())) as fecha,
M.Reserva_Codigo,
(select TOP 1 Habitacion_ID from QWERTY.Habitaciones H 
join QWERTY.Hotel HO
on HO.Hotel_ID = H.Hotel_ID

where H.Numero = CONVERT(nvarchar,Habitacion_Numero) 
and HO.Ciudad = Hotel_Ciudad )

from gd_esquema.Maestra M;

UPDATE R
   SET [Cliente_ID] = C.Cliente_ID
	from [GD2C2014].[QWERTY].[Reservas] R
	
	inner join [GD2C2014].[QWERTY].[Clientes] C 
	on C.Mail = R.mail 
	and C.Nro_Doc = R.pasaporte
 where 
	C.Mail = R.mail and C.Nro_Doc = R.pasaporte
GO

alter table Qwerty.Reservas drop column mail;
alter table Qwerty.Reservas drop column pasaporte;

/*inserto relacion reserva y habitaciones*/
insert into QWERTY.Reservas_Habitaciones (Reserva_ID, Habitacion_ID, Tipo_Cod)
select R.Reserva_ID, R.habitacion, 0 from QWERTY.Reservas R;
alter table Qwerty.Reservas drop column habitacion;


/*inserto estadia */
insert into QWERTY.Estadia (Reserva_ID, Fecha_Inicio, Fecha_Fin,Usuario_Registra_Entrada,Usuario_Registra_Salida, CodReserva)
select distinct
M.Reserva_Codigo,
M.Estadia_Fecha_Inicio,
dateadd(day,M.Estadia_Cant_Noches,M.Estadia_Fecha_Inicio) as fin,
0,
0, 
M.Reserva_Codigo
 from gd_esquema.Maestra M
 
 where M.Estadia_Fecha_Inicio is not null;
 

/*inserto facturas*/

INSERT INTO [GD2C2014].[QWERTY].[Facturacion]
           ([Nro_Factura]
           ,[Estadia_ID]
           ,[Fecha]
           ,[Total])
  
Select distinct 
M.Factura_Nro,
(select top 1 Estadia_ID from QWERTY.Estadia E where E.Reserva_ID = M.Reserva_Codigo),
Factura_Fecha, 
Factura_Total 
from gd_esquema.Maestra M

where M.Factura_Nro is not null

;

UPDATE E
   SET E.Reserva_ID = R.Reserva_ID
	from [GD2C2014].[QWERTY].Estadia E
	
	inner join [GD2C2014].[QWERTY].[Reservas] R
	on R.Codigo = E.CodReserva;
	

/****** Object:  ForeignKey [FK_Estadia_Reserva]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE QWERTY.Estadia  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Reservas] FOREIGN KEY([Reserva_ID])
REFERENCES [QWERTY].[Reservas] ([Reserva_ID])
GO
ALTER TABLE [QWERTY].[Estadia] CHECK CONSTRAINT [FK_Estadia_Reservas]
GO