select * from ProductosPedido
select * from MaterialesProducto
select * from CorteCaja
select * from Ventas
select * from Compras
create proc EntradasYSalidas @Fecha varchar(20) as
select sum(Abono) as 'Entradas', sum(Total) as 'Salidas' from Ventas, Compras where Convert(varchar(20),FechaPago,126) like @Fecha+'%'
create proc CorteDeCaja @Fecha date, @Loginn char(40), @LoginnSupervisor char(40), @Entrada int, @Salida int as
insert into CorteCaja values (@Fecha, @Loginn,@LoginnSupervisor, 1500,@Entrada, @Salida )

create proc VentasPorCorte @Fecha date as
select Ventas.* from Ventas, CorteCaja, CorteVentas where CorteCaja.Fecha = @Fecha and Ventas.FolioVenta = CorteVentas.FolioVenta