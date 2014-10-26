/*AGREGO USUARIOS*/
select * fro qwerty.usuarios;
insert into qwerty.usuarios
values
('agus','aaa','Agustin','Pace',36990517,'apace@engenus.net',49142134,'emilio mitre','2014-10-12');


/*AGREGO ROLES */
select * from qwerty.roles;
insert into qwerty.roles
values
(1,'Administrador',1),
(2,'Recepcionista',1),
(3,'Invitado',1);

/*AGREGO ROLES POR USUARIOS*/
select * from qwerty.usuarios_roles;
insert into qwerty.usuarios_roles values ('agus',1);

/*AGREGO HOTELES*/
select * from qwerty.hotel;
insert into qwerty.hotel values ('FrbaHotel','frbahotel@gmail.com',44131123,'Lugano 123',3,'Buenos Aires','Argentina','2014-02-13');

/*AGREGO HOTELES POR USUARIOS*/
insert into qwerty.personal_hoteles  values ('Agus',1);
select * from qwerty.personal_hoteles where username = 'Agus'

select h.nombre from qwerty.usuarios u, qwerty.personal_hoteles ph, qwerty.hotel h where u.username =ph.username and ph.hotel_id = h.hotel_id and u.username = 'Agus' ;
	

INSERT INTO qwerty.usuarios_inhabilitados values('maru','es hacker');

select r.rol as rol from qwerty.usuarios_roles ur,qwerty.roles r where ur.rol_id = r.rol_id and ur.username = 'Agus';