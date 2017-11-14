declare @Fecha varchar(10);
set @Fecha = '2017-09-22';

(select Sum(Retiros.Monto) from Retiros where convert(varchar(10), Retiros.Fecha, 126) like @Fecha+'%')

select * from Retiros

select * from CorteCaja