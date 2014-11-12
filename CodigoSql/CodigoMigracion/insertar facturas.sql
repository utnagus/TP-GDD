INSERT INTO [GD2C2014].[QWERTY].[Facturacion]
           ([Nro_Factura]
           ,[Reserva_ID]
           ,[Fecha]
           ,[Total])
  
Select distinct 
M.Factura_Nro,
M.Reserva_Codigo,
Factura_Fecha, 
Factura_Total 
from gd_esquema.Maestra M

where M.Factura_Nro is not null;

UPDATE F
   SET F.Reserva_ID = R.Reserva_ID
	from [GD2C2014].[QWERTY].Facturacion F
	
	inner join [GD2C2014].[QWERTY].[Reservas] R
	on R.Codigo = F.Reserva_ID
 
GO


CREATE INDEX indexReserva
    ON Qwerty.Reservas(Codigo);