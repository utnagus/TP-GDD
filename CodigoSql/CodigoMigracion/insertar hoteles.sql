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
