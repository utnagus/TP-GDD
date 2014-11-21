/****** Object:  Table [QWERTY].[Reservas_Habitaciones]    */
GO
SET QUOTED_IDENTIFIER ON
GO
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
