
/*INSERTO USUARIOS*/
select * from QWERTY.Usuarios;
insert into QWERTY.Usuarios 
values
('user','user','Hernan','Gonzales',21324213,'user@gmail.com',42314423,123,'1988-09-01'),
('admin','w23','Pedro','Gonzales',259321231,'administrator@gmail.com',42214123,456,'1983-10-12'),
('agus','aaa','Agustin','Pace',36990517,'apace@gmail.com',43218745,444,'1992-09-09'),
('maru','bbb','Marina','Pross',25895764,'mpross@gmail.com',49025434,302,'1900-04-04'),
('recep','recep','Angie','Guma',32908434,'recepcionista@gmail.com',43312132,5,'1990-03-04');

/*INSERTO ROLES DE USUARIOS*/
select * from QWERTY.Usuarios_Roles;
insert into QWERTY.Usuarios_Roles
values
('admin',1),
('admin',2),
('admin',3),
('recep',2),
('maru',3),
('agus',2);

/*INSERTO USUARIOS DE HOTEL*/
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


/*INSERTO DOMICILIOS */
insert into QWERTY.domicilio
select distinct
	cliente_dom_calle,
	cliente_nro_calle,
	cliente_piso,
	cliente_depto
from 
	gd_esquema.Maestra
;

/*select * from gd_esquema.Maestra
insert into QWERTY.Clientes
select
cliente_nombre,
cliente_apellido,
cliente_fecha_nac,
cliente_mail,
cliente_dom_calle
;*/
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

    
    
    
    