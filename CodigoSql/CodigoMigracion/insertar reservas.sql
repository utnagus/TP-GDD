alter table Qwerty.Reservas add mail varchar(50);
alter table Qwerty.Reservas add pasaporte varchar(50);

insert into QWERTY.Reservas (Fecha_inicio, 
Fecha_fin, estado, Cliente_ID , pasaporte, mail,Descripcion_ID,  CodRegimen, Fecha_Reserva, Codigo)
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
M.Reserva_Codigo

from gd_esquema.Maestra M;

UPDATE R
   SET [Cliente_ID] = C.Cliente_ID
	from [GD2C2014].[QWERTY].[Reservas] R
	
	inner join [GD2C2014].[QWERTY].[Clientes] C 
	on C.Mail = R.mail 
	and C.Nro_Doc = R.pasaporte
 where 
	C.Mail = R.Mail and C.Nro_Doc = R.pasaporte
GO

alter table Qwerty.Reservas drop mail;
alter table Qwerty.Reservas drop pasaporte;