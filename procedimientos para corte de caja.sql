--Procedimiento usado para sacar el valor de la caja maxima y a su vez, el estimado de lo que debería haber en caja
create proc CajaActual @Fecha varchar(20), @CajaChica money as
declare @Variable varchar(20)
declare @Fecha varchar(20)
set @Fecha = '2017-10-26'
declare @CajaChica money
set @CajaChica = 1500
set @Variable= (select Sum(Retiros.Monto) from Retiros where convert(varchar(10), Retiros.Fecha, 126) like @Fecha+'%')
if(@Variable != 'NULL')
select (Sum(Ventas.Abono)/2+@CajaChica) as Ventas,(Sum(Retiros.Monto)/2) as Retiros from Ventas, Retiros where convert(varchar(20),FechaPago, 126) like @Fecha+'%' and FormaDePago = 'Efectivo' and convert(varchar(20),Retiros.Fecha, 126) like @Fecha+'%'
else
select Sum(Ventas.Abono)+ @CajaChica as Estimado from Ventas where convert(varchar(20), FechaPago, 126) like @Fecha+'%' and Ventas.FormaDePago = 'Efectivo'
declare @Fecha varchar(20)
set @Fecha = '2017-11-10'
create proc EfectivoDelCorte @Fecha varchar(20) as --Proc Para obtener los ingresos de un corte, se debera realizar un retiro final antes de cada corte
select Sum(Retiros.Monto) as RetirosDelCorte, Sum(Retiros.Mil) as Mil, Sum(Retiros.Quinientos) as Quinientos, Sum(Retiros.Doscientos) as Doscientos, Sum(Retiros.Cien) as Cien, Sum(Retiros.Cincuenta) as Cincuenta, Sum(Retiros.Veinte) as Veinte, Sum(Retiros.Diez) as Diez, Sum(Retiros.Cinco) as Cinco, Sum(Retiros.Dos) as Dos, Sum(Retiros.Uno) as Uno, Sum(Retiros.CincuentaCentavos) as CincuentaCentavos, Sum(Retiros.VeinteCentavos) as VeinteCentavos, Sum(Retiros.DiezCentavos) as DiezCentavos, Sum(Retiros.CincoCentavos) as CincoCentavos, Sum(Retiros.Restante) as Restante from Retiros where convert (varchar(20), Fecha, 126) like @Fecha + '%' and Retiros.IDCaja in (select top(1) CorteCaja.FolioCorte + 1 from CorteCaja order by CorteCaja.FolioCorte desc)

create proc RetirosDelDia @Fecha varchar(20) as
select sum(Retiros.Monto) as Retiros from Retiros where convert(varchar(20), Fecha, 126) like @Fecha + '%'

create proc VentasDelDia @Fecha varchar(20) as
select Sum(Ventas.Abono) as Ventas from Ventas where convert(varchar(20),FechaPago, 126) like @Fecha+'%' and FormaDePago = 'Efectivo'
create proc VentasDelDiaBanco @Fecha varchar(20) as
select Sum(Ventas.Abono) as Ventas from Ventas where convert(varchar(20),FechaPago, 126) like @Fecha+'%' and FormaDePago != 'Efectivo'

create proc DatosCorte @Fecha varchar(20) as
declare @Fecha varchar(20)
set @Fecha = '2017-10-27'
select FolioCorte, Fecha, Hora, Empleados.Nombre + ' ' + Empleados.Apellidos as Empleado, CajaChica,  CajaMaxima, CorteCaja.Real, Banco from CorteCaja, Empleados where convert(varchar(20),Fecha, 126) like @Fecha+'%' and Empleados.Loginn = CorteCaja.Loginn 


 --Sumar el procedimiento de caja actual al estimado y al realizar el corte de caja, efectuar un retiro al mismo tiempo para que funcione el calculo del estimado.


--Procedimiento para obtener el total de ventas cobradas con tarjeta
create proc VentasConTarjeta @Fecha varchar(20) as
select Sum(Abono) as VentasConTarjeta from Ventas where convert(varchar(20), FechaPago, 126) like @Fecha+'%' and FormaDePago != 'Efectivo'

--Procedimiento para insertar o crear un corte de caja con sus parametros
create proc CorteDeCaja @Fecha date, @Hora time, @Loginn char(40), @Supervisor char(40), @CajaChica money, @Mil int, @Quinientos int, @Doscientos int, @Cien int, @Cincuenta int, @Veinte int, @Diez int, @Cinco int, @Dos int, @Uno int, @CincuentaCentavos int, @VeinteCentavos int, @DiezCentavos int, @CincoCentavos int, @Estimado money, @Real money, @CajaMaxima money, @Banco money, @Comentarios char(100) as
insert into CorteCaja values (@Fecha, @Hora, @Loginn, @Supervisor, @CajaChica, @Mil, @Quinientos, @Doscientos, @Cien, @Cincuenta, @Veinte, @Diez, @Cinco, @Dos, @Uno, @CincuentaCentavos, @VeinteCentavos, @DiezCentavos, @CincoCentavos, @Estimado, @Real, @CajaMaxima, @Banco, @Comentarios)

--Procedimiento para ver el corte de caja de una fecha
create proc VerCorteDeCajaFecha @Fecha date as
select * from CorteCaja where @Fecha = CorteCaja.Fecha

--Procedimiento para ver los cortes de caja de un mismo empleado por loginn o nombre
create proc VerCorteDeCajaEmpleado @Empleado char(40) as
select CorteCaja.*, Empleados.Nombre +' ' +Empleados.Apellidos as Empleado from CorteCaja, Empleados where Empleados.Loginn = @Empleado or Empleados.Nombre = @Empleado

--Procedimiento para insertar o crear un retiro
create proc Retiro @IDCaja int, @Fecha date, @Hora time, @Monto money, @Mil int, @Quinientos int, @Doscientos int, @Cien int, @Cincuenta int, @Veinte int, @Diez int, @Cinco int, @Dos int, @Uno int, @CincuentaCentavos int, @VeinteCentavos int, @DiezCentavos int, @CincoCentavos int, @Restante money, @Empleado char(40), @Supervisor char(40), @Motivo int, @Comentarios char(100) as
insert into Retiros values (@IDCaja, @Fecha, @Hora, @Monto, @Mil, @Quinientos, @Doscientos, @Cien, @Cincuenta, @Veinte, @Diez, @Cinco, @Dos, @Uno, @CincuentaCentavos, @VeinteCentavos, @DiezCentavos, @CincoCentavos, @Restante, @Empleado, @Supervisor, @Motivo, @Comentarios)

--Procedimiento para obtener el ultimo corte de caja creado este se puede usar para el insert de los retiros
create proc UltimoCorte as
select top(1) * from CorteCaja order by FolioCorte desc

--Procedimiento para obtener los retiros de una fecha 
create proc RetirosPorFecha @Fecha date as
select * from Retiros where Fecha = @Fecha

--Procedimiento para obtener los retiros de un corte de caja
create proc RetirosPorCorte @FolioCorte int as
select * from Retiros where IDCaja = @FolioCorte
create proc PedidosPorEntregar as
select * from Pedido where Pagado = 'SI' and (EstatusPedido = 'Finalizado' or EstatusPedido = 'Facturado')

create proc EntregaPedido @Pedido int, @Estatus char(20), @Fecha date as
update Pedido set EstatusPedido = @Estatus, FechaEntrega = @Fecha where IDPedido = @Pedido
  select * from Pedido
  select * from Retiros
  select * from Ventas
  select * from CorteCaja
  select * from MaterialesProducto
  select sum(Abono) from Ventas where Ventas.FechaPago like '2017-10-25%'

  select * from Dentista

  create table PedidosEntregados (
  IDPedido int,
  Loginn char(40),
  Dentista char(40)
  )
  create proc getPedidoEntregado @Pedido int as 
  select PedidosEntregados.IDPedido, Nombre +' ' + Apellidos as NombreEmpleado, Dentista,   ProductosPedido.Cantidad, MaterialesProducto.Descripcion, MaterialesProducto.PrecioFinal as PrecioUnitario,
 ProductosPedido.SubTotal, Pedido.CostoTotal, Pedido.FechaEntrega
  from PedidosEntregados, Pedido, Empleados, ProductosPedido, MaterialesProducto where Pedido.IDPedido = PedidosEntregados.IDPedido  and Pedido.IDPedido = @Pedido and ProductosPedido.CodigoEspecial = MaterialesProducto.CodigoEspecial
  SELECT * FROM PRODUCTO
  SELECT * FROM MATERIAL
  create proc getMaterialesProducto @Material1 varchar(6), @Material2 varchar(6), @Producto varchar(6) as
  select MaterialesProducto.* from MaterialesProducto where MaterialesProducto.CodigoMaterial = @Material1 and MaterialesProducto.CodigoMaterial2 = @Material2 and MaterialesProducto.CodigoProducto = @Producto
  select * from ProductosPedido
  select * from MaterialesProducto

  create proc procInsertarProducto @Pedido int, @Especial varchar(6), @Cantidad money, @SubTotal money as
  insert into ProductosPedido values(@Pedido, @Especial, @Cantidad, @SubTotal)
  create proc getDatosProductosPedido @Pedido int as
  select MaterialesProducto.CodigoEspecial as Codigo, MaterialesProducto.Descripcion as Producto, MaterialesProducto.PrecioFinal as Precio_Unitario, TiempoFinal as Tiempo, Cantidad, SubTotal from MaterialesProducto, ProductosPedido where ProductosPedido.Pedido = @Pedido and MaterialesProducto.CodigoEspecial = ProductosPedido.CodigoEspecial

  create proc SacarProducto @IDPedido int, @CodigoEspecial char(6) as
  delete ProductosPedido from ProductosPedido where Pedido = @IDPedido and CodigoEspecial = @CodigoEspecial

  create proc [dbo].[CrearPedido] @Dentista int, @Empleado char(40), @Estatus char(20) as begin insert 
into Pedido
values (@Dentista,@Empleado, @Estatus, null, null, null, null, null, null, null, null, null, null, null, null, null) end

create proc [dbo].[GenerarPedido] @Pedido int, @Dentista int, @Empleado char(40), @Estatus char(20), @FechaIngreso varchar(20), 
@FechaCalculada varchar(20), @FechaEntrega varchar(20), @Urgencia char(2), @Total MONEY, @Fabricante char(40), @Pagado char(2), @Restante money, @IVA char(3), @Devuelto char(2), @Devolucion date, @Modificacion char(2), @FechaModi varchar(20)  as 
begin update Pedido set 
Pedido.EstatusPedido = @Estatus, 
Pedido.FechaIngreso = @FechaIngreso, 
FechaCalculada = @FechaCalculada, 
Urgencia = @Urgencia, 
Laboratorista = @Fabricante, 
CostoTotal = @Total,
Pagado = @Pagado,
RestantePorPagar = @Restante,
IVA = @IVA,
Devuelto = @Devuelto,
FechaDevolucion = @Devolucion,
Modificacion = @Modificacion,
FechaModificacion = @FechaModi
where IDPedido = @Pedido and IDDentista = @Dentista end

create proc [dbo].[ModificarPedido] @Pedido int, @Dentista int,
@Estatus char(20),
@FechaCalculada varchar(20), @Urgencia char(2), 
@Total MONEY, @Pagado char(2), @Restante money, 
@IVA char(3), @Devuelto char(2), @Devolucion date, 
@Modificacion char(2), @FechaModi varchar(20)  as 
begin update Pedido set 
Pedido.EstatusPedido = @Estatus, 
FechaCalculada = @FechaCalculada, 
Urgencia = @Urgencia, 
CostoTotal = @Total,
Pagado = @Pagado,
RestantePorPagar = @Restante,
IVA = @IVA,
Devuelto = @Devuelto,
FechaDevolucion = @Devolucion,
Modificacion = @Modificacion,
FechaModificacion = @FechaModi
where IDPedido = @Pedido and IDDentista = @Dentista end