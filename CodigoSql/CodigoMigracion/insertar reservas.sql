select distinct 
M.Reserva_Codigo, 
M.Reserva_Fecha_Inicio, 
dateadd(day,M.Reserva_Cant_Noches,M.Reserva_Fecha_Inicio) as fin,
M.Cliente_Pasaporte_Nro, /*select Cliente_ID from Qwerty.Clientes where Pasaporte = M.Cliente_Pasaporte_Nro*/
'Cargada por migracion',
M.Regimen_Descripcion, /*select Regimen_ID from qwerty.Regimen where descripcion like M.Regimen_descripcion and Precio = M.Regimen_Precio*/
'2014-01-01' as fecha /* fecha actual*/


from gd_esquema.Maestra M;