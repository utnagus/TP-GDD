select * from QWERTY.Clientes C
join
(SELECT TOP 52 Nro_Doc as nro, count(*) as cantidad from QWERTY.Clientes 
group by Nro_Doc
order by cantidad desc)  clientesInvalidos
on clientesInvalidos.nro = C.Nro_Doc 