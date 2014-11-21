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




