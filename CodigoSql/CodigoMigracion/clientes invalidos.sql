select * from QWERTY.Clientes C
join
(SELECT TOP 52 C.Mail as mail, count(*) as cantidad from QWERTY.Clientes C
group by Nro_Doc
order by cantidad desc)  clientesInvalidos
on clientesInvalidos.mail = C.Mail 