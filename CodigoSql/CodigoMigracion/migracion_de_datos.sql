	
/*CREACION USUARIOS*/
select * from QWERTY.Usuarios;
insert into QWERTY.Usuarios 
values
('user','user','Hernan','Gonzales','user@gmail.com','Rivadavia 243','1988-09-01',21324213,42314423,'A'),
('admin','w23','Pedro','Gonzales','administrator@gmail.com','Rivadavia 2132','1983-10-12',259321231,42214123,'A'),
('recep','recep','Angie','Guma','recepcionista@gmail.com','Inclan 555','1990-03-04',32908434,43312132,'A');

/*CREACION ROLES DE USUARIOS*/
select * from QWERTY.Usuarios_Roles;
insert into QWERTY.Usuarios_Roles
values
('admin',1),
('admin',2),
('admin',3),
('recep',2),
('maru',3),
('agus',2);

/*CREACION USUARIOS DE HOTEL*/
select * from qwerty.Personal_hoteles;
insert into qwerty.Personal_hoteles
values
('admin',2),
('admin',4),
('admin',5),
('admin',6),
('admin',8),
('admin',10),
('admin',11),
('agus',1),
('admin',3),
('recep',1),
('recep',2),
('recep',3),
('recep',4),
('recep',5),
('recep',6),
('recep',7);

/*CREACION CLIENTES INVALIDOS*/
--select * from QWERTY.Clientes C
--join
--(SELECT TOP 52 Nro_Doc as nro, count(*) as cantidad from QWERTY.Clientes 
--group by Nro_Doc
--order by cantidad desc)  clientesInvalidos
--on clientesInvalidos.nro = C.Nro_Doc ;

/*CREACION DE FACTURACION*/

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
    
/* CREACION HABITACIONES */    
insert into QWERTY.Habitaciones (Numero, Piso, Ubicacion, Tipo, Descripcion, Tipo_porcentual_ExtraData, Tipo_codigo_ExtraData)
select distinct 
CONVERT(nvarchar,Habitacion_Numero),
CONVERT(nvarchar,Habitacion_Piso),
Habitacion_Frente,
Habitacion_Tipo_Descripcion,
'No cargada',
Habitacion_Tipo_Porcentual,
Habitacion_Tipo_Codigo
from gd_esquema.Maestra;

    
    
    
    