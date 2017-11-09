namespace DiseñoFinal.ReportesM
{
    public static class CamposListados
    {
        static string[,] camposEmpleados = new string[,]
        {
            {"Nombre", "" },
            {"Apellidos", "" },
            {"Direccion", "Dirección" },
            {"Colonia", "" },
            {"Ciudad", "" },
            {"Municipio", "" },
            {"Estado", "" },
            {"Pais", "País" },
            {"CodigoPostal", "Código Postal" },
            {"TelCasa", "Teléfono de Casa" },
            {"TelOfi", "Teléfono de Oficina" },
            {"TelCel", "Teléfono Celular" },
            {"Email", "Correo Electrónico" },
            {"Loginn", "Login" },
            {"Passwordd", "Contraseña" },
            {"Pregunta", "" },
            {"Respuesta", "" },
            {"Activo", "" },
            {"Departamento", "" },
            {"FechaIngreso", "Fecha de Ingreso" },
            {"Puesto", "" },
            {"Sueldo", "" },
            {"FechaNacimiento", "Fecha de Nacimiento" },
        };
        static string[,] camposDentista = new string[,]
        {
            {"ID", "" },
            {"Cedula", "" },
            {"RFC", "" },
            {"Nombre", "" },
            {"Apellidos", "" },
            {"Direccion", "" },
            {"NumeroExterior", "Número Exterior" },
            {"Pais", "País" },
            {"Estado", "" },
            {"Municipio", "" },
            {"Ciudad", "" },
            {"Colonia", "" },
            {"CodigoPostal", "Código Postal" },
            {"Telefono", "Teléfono" },
            {"Email", "Correo Electrónico" },
            {"Activo", "" },
            {"Consultorio", "" },
            {"FechaAlta", "Fecha de Alta" },
            {"FechaNacimiento", "Fecha de Nacimiento" },
        };

        static string[,] camposPedido = new string[,]
        {
            {"IDPedido", "ID Pedido" },
            {"IDDentista", "ID Dentista" },
            {"IDEmpleado", "ID Empleado" },
            {"EstatusPedido", "Estado del Pedido" },
            {"FechaIngreso", "Fecha de Ingreso" },
            {"FechaCalculada", "Fecha Calculada" },
            {"FechaEntrega", "Fecha de Entrega" },
            {"Urgencia", "" },
            {"CostoTotal", "Costo Total" },
            {"Laboratorista", "" },
            {"Pagado", "" },
            {"RestantePorPagar", "Restante a Pagar" },
            {"IVA", "" },
            {"Devuelto", "" },
            {"FechaDevolucion", "Fecha de Devolución" },
            {"Modificacion", "Modificación" },
            {"FechaModificacion", "Fecha de Modificación" },
        };

        static string[,] camposMaterial = new string[,]
        {
            {"CodigoMaterial", "Código del Material" },
            {"Nombre", "" },
            {"Descripcion", "Descripción" },
            {"CostoBase", "Costo Base" },
            {"PrecioBase", "Precio Base" },
            {"TiempoBase", "Tiempo Base" },
            {"Proveedor", "" },
            {"Unidad", "" },
            {"Existencia", "" },
            {"Stock", "" },
            {"ConsumidosMes", "Consumidos al Mes" },
            {"CompradosMes", "Comprados al Mes" },
        };

        static string[,] camposProducto = new string[,]
        {
            {"CodigoProducto", "Código del Producto" },
            {"Nombre", "" },
            {"Descripcion", "Descripción" },
            {"TiempoBase", "Tiempo Base" },
            {"PrecioBase", "Precio Base" },
        };

        static string[,] camposMaterialesProducto = new string[,]
        {
            {"CodigoEspecial", "Código Especial" },
            {"CodigoProducto", "Código Producto" },
            {"CodigoMaterial", "Código Material" },
            {"CodigoMaterial2", "Código Material 2" },
            {"PrecioFinal", "Precio Final" },
            {"TiempoFinal", "Tiempo Final" },
            {"Descripcion", "Descripción" },
            {"Medidas", "" },
        };

        static string[,] camposCorteCaja = new string[,]
        {
            {"FolioCorte", "Folio del Corte" },
            {"Fecha", "Fecha del Corte" },
            {"Hora", "" },
            {"Loginn", "Empleado" },
            {"LoginnSupervisor", "Supervisor" },
            {"CajaChica", "Fondo de Caja" },
            {"Estimado", "" },
            {"Real", "Efectivo" },
            {"CajaMaxima", "Caja Máxima" },
            {"Banco", "Tarjeta" },
            {"Comentarios", "Comentarios" },
        };

        static string[,] camposCompras = new string[,]
        {
            {"IDCompra", "ID de Compra" },
            {"Loginn", "Empleado" },
            {"IDProveedor", "ID del Proveedor" },
            {"Total", "" },
            {"Fecha", "Fecha de Pedido" },
            {"Tipo", "" },
            {"FechaSurtido", "Fecha de Surtido" },
            {"Estado", "" },
        };

        static string[,] camposProveedores = new string[,]
        {
            {"ClaveProveedor", "Clave del Proveedor" },
            {"Nombre", "" },
            {"Telefono", "Teléfono" },
            {"Correo", "Correo Electrónico" },
            {"Descripcion", "Descripción" },
            {"RFC", "" },
            {"Contacto", "" },
            {"Estatus", "" },
        };

        static string[,] camposRequisicion = new string[,]
        {
            {"IDRequisicion", "ID de Requisicion" },
            {"Empleado", "" },
            {"Fecha", "" },
            {"CantidadTotal", "Cantidad Total" },
            {"Surtido", "" },
            {"Estado", "" },
        };

        static string[,] camposVentas = new string[,]
        {
            {"FolioVenta", "Folio de Venta" },
            {"IDPedido", "ID del Pedido" },
            {"Importe", "" },
            {"Abono", "" },
            {"Feria", "" },
            {"FechaPago", "Fecha de Pago" },
            {"Empleado", "" },
            {"FormaDePago", "Forma de Pago" },
            {"Descripcion", "Descripción" },
        };

        static string[,] camposPagoEmpleados = new string[,]
        {
            {"IdPago", "ID del Pago" },
            {"FechaPago", "Fecha de Pago" },
            {"Loginn", "Login" },
            {"MesAPagar", "Mes a Pagar" },
            {"AñoAPagar", "Año a Pagar" },
            {"Sueldo", "" },
            {"TasaISR", "Tasa al SR" },
            {"CuotaISR", "Cuota al SR" },
            {"APagar", "Monto a Pagar" },
        };

        public static string[,] CamposDentista
        {
            get
            {
                return camposDentista;
            }

            set
            {
                camposDentista = value;
            }
        }

        public static string[,] CamposEmpleados
        {
            get
            {
                return camposEmpleados;
            }

            set
            {
                camposEmpleados = value;
            }
        }

        public static string[,] CamposPedido
        {
            get
            {
                return camposPedido;
            }

            set
            {
                camposPedido = value;
            }
        }

        public static string[,] CamposMaterial
        {
            get
            {
                return camposMaterial;
            }

            set
            {
                camposMaterial = value;
            }
        }

        public static string[,] CamposProducto
        {
            get
            {
                return camposProducto;
            }

            set
            {
                camposProducto = value;
            }
        }

        public static string[,] CamposMaterialesProducto
        {
            get
            {
                return camposMaterialesProducto;
            }

            set
            {
                camposMaterialesProducto = value;
            }
        }

        public static string[,] CamposCorteCaja
        {
            get
            {
                return camposCorteCaja;
            }

            set
            {
                camposCorteCaja = value;
            }
        }

        public static string[,] CamposCompras
        {
            get
            {
                return camposCompras;
            }

            set
            {
                camposCompras = value;
            }
        }

        public static string[,] CamposProveedores
        {
            get
            {
                return camposProveedores;
            }

            set
            {
                camposProveedores = value;
            }
        }

        public static string[,] CamposRequisicion
        {
            get
            {
                return camposRequisicion;
            }

            set
            {
                camposRequisicion = value;
            }
        }

        public static string[,] CamposVentas
        {
            get
            {
                return camposVentas;
            }

            set
            {
                camposVentas = value;
            }
        }

        public static string[,] CamposPagoEmpleados
        {
            get
            {
                return camposPagoEmpleados;
            }

            set
            {
                camposPagoEmpleados = value;
            }
        }
    }
}