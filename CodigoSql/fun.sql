CREATE procedure facturar
@estadiaId int,
@numero_factura int

as
 
declare @total int;
declare @totalItems int;
declare @totalEstadia int;
declare @numeroItem int;
declare @recupero int;
declare @regimen int;

select @regimen = r.CodRegimen from QWERTY.estadia e join QWERTY.Reservas r on r.Reserva_ID = e.Estadia_ID where e.Estadia_ID = @estadiaId;
select @numeroItem = max(nro_item) from qwerty.items_facturacion;
select @totalItems = sum(valor) from qwerty.items_facturacion where estadia_id = @estadiaId;
select @totalEstadia = datediff(day,e.fecha_inicio,e.fecha_fin) *  r.precio from qwerty.estadia e join qwerty.reservas res on res.reserva_id = e.reserva_id join qwerty.regimen r on res.codregimen = r.codigo  where e.estadia_id = @estadiaId;

select @recupero = case @regimen  when 3 then @totalItems * -1 else 0 end ;

select @total = @totalItems + @totalEstadia + @recupero;

insert into QWERTY.Facturacion (Nro_Factura, Estadia_ID, Fecha, Total)
values (@numero_factura, @estadiaId, GETDATE(), @total);

insert into qwerty.items_facturacion ( nro_factura,estadia_id,consumible_id,cantidad,valor)
values ( @numero_factura, @estadiaId, 1, (select datediff(day,e.fecha_inicio,e.fecha_fin) from qwerty.estadia e join qwerty.reservas res on res.reserva_id = e.reserva_id join qwerty.regimen r on res.codregimen = r.codigo  where e.estadia_id = @estadiaId), @totalEstadia)

insert into qwerty.items_facturacion ( nro_factura,estadia_id,consumible_id,cantidad,valor)
values ( @numero_factura, @estadiaId, 2, 1 , @recupero);


go