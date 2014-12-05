/* hoteles con mas reservas canceladas*/
select top 5 ho.Nombre, count(*) as cantidad from QWERTY.Reservas_canceladas rc

join QWERTY.Reservas_Habitaciones rh
on rc.Reserva_ID = rh.Reserva_ID

join QWERTY.Habitaciones h
on h.Habitacion_ID = rh.Habitacion_ID

join QWERTY.Hotel ho
on ho.Hotel_ID =  h.Hotel_ID

where rc.fecha between '2010-01-01' and '2014-01-01'

group by h.Hotel_ID, ho.Nombre
order by cantidad desc;


/* hoteles con mas items de facturacion*/
select top 5 ho.Nombre, sum(it.cantidad) as cantidadTotal from QWERTY.Items_Facturacion it

join QWERTY.Facturacion f
on f.Nro_Factura = it.Nro_Factura

join QWERTY.Estadia e
on f.Estadia_ID = e.Estadia_ID

join QWERTY.Reservas_Habitaciones rh
on e.Reserva_ID = rh.Reserva_ID

join QWERTY.Habitaciones h
on h.Habitacion_ID = rh.Habitacion_ID

join QWERTY.Hotel ho
on ho.Hotel_ID =  h.Hotel_ID

where f.Fecha between '2010-01-01' and '2014-01-01'

group by h.Hotel_ID, ho.Nombre
order by cantidadTotal desc;

/* Hoteles con mayor cantidad de días fuera de servicio */

select top 5 h.Nombre ,  sum(DATEDIFF(day,hb.desde,hb.hasta)) as cantidad from QWERTY.hotel_bajas hb 
join QWERTY.Hotel h
on h.Hotel_ID = hb.Hotel_ID

where hb.desde between '2010-01-01' and '2014-01-01'
or hb.hasta between '2010-01-01' and '2014-01-01'
or (hb.hasta > '2014-01-01' and hb.desde < '2010-01-01')

group by h.Hotel_ID , h.Nombre
order by cantidad desc;


/* Habitaciones con mayor cantidad de días y veces que fueron ocupadas,
informando a demás a que hotel perteneces. */
select top 5 
ho.Nombre, h.Numero, SUM(DATEDIFF(day,e.Fecha_Inicio,e.Fecha_Fin)) as cantidadDeDias, COUNT(*) as cantidadDeVeces from QWERTY.Estadia e

join QWERTY.Reservas_Habitaciones rh
on rh.Reserva_ID = e.Reserva_ID

join QWERTY.Habitaciones h
on h.Habitacion_ID = rh.Habitacion_ID

join QWERTY.Hotel ho
on ho.Hotel_ID = h.Hotel_ID

where e.Fecha_Inicio between '2010-01-01' and '2014-01-01'
or e.Fecha_Fin between '2010-01-01' and '2014-01-01'
or (e.Fecha_Fin > '2014-01-01' and e.Fecha_Inicio < '2010-01-01')


group by h.Habitacion_ID, ho.Nombre, h.Numero 
order by cantidadDeDias desc , cantidadDeVeces desc;


/* Cliente con mayor cantidad de puntos, donde cada $10 en estadías vale 1
puntos y cada $5 de consumibles es 1 punto, de la sumatoria de todas las
facturaciones que haya tenido dentro de un periodo independientemente
del Hotel */
select top 5 cl.Apellido, 
cl.Nombre,
convert(int,sum(it1.valor)/10) as estadias,
convert(int,SUM(it2.valor)/5) as items
  
 from QWERTY.Clientes cl

join QWERTY.Reservas r
on cl.Cliente_ID = r.Cliente_ID

join QWERTY.Estadia e
on r.Reserva_ID = e.Reserva_ID

join QWERTY.Facturacion f
on f.Estadia_ID = e.Estadia_ID

join QWERTY.Items_Facturacion it1
on f.Nro_Factura = it1.Nro_Factura
and it1.Consumible_ID = 1

join QWERTY.Items_Facturacion it2
on f.Nro_Factura = it2.Nro_Factura
and it2.Consumible_ID != 1

where f.Fecha between '2010-01-01' and '2014-01-01'

group by cl.Cliente_ID, cl.Apellido, cl.Nombre
order by estadias, items;