select distinct 
M.Reserva_Fecha_Inicio, 
dateadd(day,M.Reserva_Cant_Noches,M.Reserva_Fecha_Inicio) as fin,
1 as estado,
(select Cliente_ID from Qwerty.Clientes where Pasaporte = M.Cliente_Pasaporte_Nro AND Nombre like M.Cliente_Nombre AND Apellido like M.Cliente_Apellido and Mail like Mail.Cliente_Mail),
1 as descripcion,
(select Regimen_ID from QWERTY.Regimen R where R.Codigo = M.Codigo_regimen and R.Descripcion like M.Regimen_descripcion) as regimen,
(SELECT CONVERT(DATE,GETDATE())) as fecha,
M.Reserva_Codigo

from gd_esquema.Maestra M;
/*
select distinct 
(select Reserva_ID from QWERTY.Reservas R where R.codigo (hay que guardarlo) = M.Reserva_codigo)
(select Habitacion_ID from QWERTY.Habitaciones where ............... ) as habitacion
from gd_esquema.Maestra M;*/