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


/*inserto habitaciones*/

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

/* inserto regimenes*/
insert into QWERTY.Regimen (Codigo,Descripcion,Precio,Estado)
select distinct 
'',Regimen_Descripcion, Regimen_Precio,1 
from gd_esquema.Maestra;

update QWERTY.Regimen 
set Codigo = Regimen_ID;


/*Cargo tabla Clientes*/
insert into QWERTY.Clientes (Nombre,Apellido,Mail,Calle,
Nro,Piso,Depto,Nacionalidad,Fecha_nacimiento,Tipo_Doc,Nro_Doc) 
select distinct m.Cliente_Nombre,m.Cliente_Apellido,m.Cliente_Mail,
m.Cliente_Dom_Calle,m.Cliente_Nro_Calle,m.Cliente_Piso,m.Cliente_Depto,
m.Cliente_Nacionalidad,m.Cliente_Fecha_Nac,'1',m.Cliente_Pasaporte_Nro from gd_esquema.Maestra m


/*Cargo tabla Consumibles*/
insert into QWERTY.Consumibles (Consumible_ID,Producto,Precio)
select distinct m.Consumible_Codigo, m.Consumible_Descripcion,m.Consumible_Precio 
from gd_esquema.Maestra m where m.Consumible_Codigo is not null


/*creo y cargo tabla Tipo_Doc*/
create table Tipo_Doc(
Tipo_Doc_ID int NOT NULL IDENTITY(1,1),
Descripcion nvarchar(50) NOT NULL,
Primary key (Tipo_Doc_ID)
);
insert into QWERTY.Tipo_Doc(Descripcion) values ('Pasaporte')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LE')
insert into QWERTY.Tipo_Doc(Descripcion) values ('DNI')
insert into QWERTY.Tipo_Doc(Descripcion) values ('LC')
insert into QWERTY.Tipo_Doc(Descripcion) values ('CI')

