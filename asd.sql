﻿create table Retiros(
IDRetiro int primary key identity(1,1),
IDCaja int,
Fecha date,
Hora time,
Monto money,
Mil int,
Quinientos int,
Doscientos int,
Cien int,
Cincuenta int,
Veinte int,
Diez int,
Cinco int,
Dos int,
Uno int,
CincuentaCentavos int,
VeinteCentavos int,
DiezCentavos int,
CincoCentavos int,
Restante money,
Empleado char(40),
Supervisor char(40),
Comentarios char(100)
)