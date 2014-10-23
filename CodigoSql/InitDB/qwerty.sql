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
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Consumibles]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
CREATE TABLE [QWERTY].[Clientes](
	[Cliente_ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Pasaporte] [bigint] NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[Telefono] [bigint] NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[Nro] [int] NOT NULL,
	[Piso] [int] NOT NULL,
	[Depto] [int] NOT NULL,
	[Nacionalidad] [varchar](50) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
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
CREATE TABLE [QWERTY].[Hotel](
	[Hotel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) ,
	[Mail] [nvarchar](50) ,
	[Telefono] [nvarchar](20),
	[Direccion] [varchar](50),
	[Estrellas] [int],
	[Ciudad] [nvarchar](50),
	[Pais] [nvarchar](50),
	[Fecha_creacion] [date],
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[Hotel_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Regimen]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [QWERTY].[Regimen](
	[Regimen_ID] [int] NOT NULL,
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
/****** Object:  Table [QWERTY].[Personal_hoteles]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
CREATE TABLE [QWERTY].[Reservas](
	[Reserva_ID] [int] NOT NULL,
	[Fecha_inicio] [date] NOT NULL,
	[Fecha_fin] [date] NOT NULL,
	[Habitacion_ID] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Cliente_ID] [int] NOT NULL,
	[Descripcion_ID] [int] NOT NULL,
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
CREATE TABLE [QWERTY].[Facturacion](
	[Nro_Factura] [int] NOT NULL,
	[Reserva_ID] [int] NOT NULL,
	[Forma_de_pago] [varchar](50) NOT NULL,
	[Detalle_factura] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
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
/****** Object:  Table [QWERTY].[Habitaciones]    Script: Modificado por Fede******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [QWERTY].[Habitaciones](
	[Habitacion_ID] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nvarchar](10) ,
	[Piso] [nvarchar](10) ,
	[Ubicacion] [varchar](250) ,
	[Tipo] [varchar](20) ,
	[Descripcion] [varchar](255) ,
	Tipo_porcentual_ExtraData [varchar](255),
	 Tipo_codigo_ExtraData [varchar](255),
 CONSTRAINT [PK_Habitaciones] PRIMARY KEY CLUSTERED 
(
	[Habitacion_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QWERTY].[Hotel_Habitaciones]    Script Date: 10/11/2014 18:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  ForeignKey [FK_Descripcion_reservas_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Descripcion_reservas]  WITH CHECK ADD  CONSTRAINT [FK_Descripcion_reservas_Reservas] FOREIGN KEY([Descripcion_ID])
REFERENCES [QWERTY].[Reservas] ([Descripcion_ID])
GO
ALTER TABLE [QWERTY].[Descripcion_reservas] CHECK CONSTRAINT [FK_Descripcion_reservas_Reservas]
GO
/****** Object:  ForeignKey [FK_Facturacion_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Reservas] FOREIGN KEY([Reserva_ID])
REFERENCES [QWERTY].[Reservas] ([Reserva_ID])
GO
ALTER TABLE [QWERTY].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Reservas]
GO
/****** Object:  ForeignKey [FK_Habitaciones_Reservas]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Habitaciones_Reservas] FOREIGN KEY([Habitacion_ID])
REFERENCES [QWERTY].[Reservas] ([Habitacion_ID])
GO
ALTER TABLE [QWERTY].[Habitaciones] CHECK CONSTRAINT [FK_Habitaciones_Reservas]
GO
/****** Object:  ForeignKey [FK_Hotel_Habitaciones_Hotel]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Hotel_Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Habitaciones_Hotel] FOREIGN KEY([Hotel_ID])
REFERENCES [QWERTY].[Hotel] ([Hotel_ID])
GO
ALTER TABLE [QWERTY].[Hotel_Habitaciones] CHECK CONSTRAINT [FK_Hotel_Habitaciones_Hotel]
GO
/****** Object:  ForeignKey [FK_Hotel_Habitaciones_Hotel_Habitaciones]    Script Date: 10/11/2014 18:49:09 ******/
ALTER TABLE [QWERTY].[Hotel_Habitaciones]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Habitaciones_Hotel_Habitaciones] FOREIGN KEY([Habitacion_ID])
REFERENCES [QWERTY].[Habitaciones] ([Habitacion_ID])
GO
ALTER TABLE [QWERTY].[Hotel_Habitaciones] CHECK CONSTRAINT [FK_Hotel_Habitaciones_Hotel_Habitaciones]
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
