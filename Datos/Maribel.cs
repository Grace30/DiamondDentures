using System;
using System.Data;

namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public DataTable ObtenerDatosVentas(string[] Datos )
        {
            string[] Parametros = { "@Name", "@Folio" };
            return getDatosTabla("ProcTodasVentas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerNominaGeneral()
        {
            return getDatosTabla("NominaGeneral", new string[0], new string[0]);
        }
        public DataTable ObtenerCortes()
        {
            return getDatosTabla("CortesCajaTodos", new string[0], new string[0]);
        }
        public DataTable BuscarCortePorFecha(string[] Datos)
        {
            string[] Parametros = { "@FechaDesde", "@FechaHasta" };
            return getDatosTabla("CorteCajaPorFechas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerBalanceGeneral(string[] Datos)
        {
            string[] Parametros = { "@Desde", "@Hasta" };
            return getDatosTabla("getBalance", Parametros, Datos[0], Datos[1]);
        }
        public DataTable BuscarPorNombreFolio(string[] Datos)
        {
            string[] Parametros = { "@FolioCorte", "@Empleado" };
            return getDatosTabla("BuscarCorteCaja", Parametros, Datos[0], Datos[1] + (Datos[0] == "" ? "%" : ""));
        }

        public DataTable BuscarPorFecha(string[] Datos)
        {
            string[] Parametros = { "@FechaDesde", "@FechaHasta" };
            return getDatosTabla("procVentasPorFechas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable NominaMes(int Mes)
        {
            string[] Parametros = { "@Mes" };
            return getDatosTabla("getNomina", Parametros, Mes);
        }
        public DataTable BuscarPorNombreE(string nombre)
        {
            string[] Parametros = { "@Empleado" };
            return getDatosTabla("procVentasPorNombre", Parametros, nombre);
        }
        public DataTable BuscarPorNombreProveedor(string nombre)
        {
            string[] Parametros = { "@NombreProv" };
            return getDatosTabla("procComprasAProveedor", Parametros, nombre);
        }
        public DataTable ObtenerDatosCatalago()
        {
            return getDatosTabla("procCatalogo", new string[0], new string[0]);
        }
        public DataTable ObtenerDatosInventarioMat()
        {
            return getDatosTabla("procInventarioMat", new string[0], new string[0]);
        }
        public DataTable ObtenerDatosListaProveedores()
        {
            return getDatosTabla("procListaProv", new string[0], new string[0]);
        }
        public DataTable ObtenerDatosComprasProveedores()
        {
            return getDatosTabla("procComprasProv", new string[0], new string[0]);
        }
        public DataTable ObtenerDatosRequisicion(string[] Datos)
        {
            string[] Parametros = { "@Name", "@Folio" };
            return getDatosTabla("procRequisionTodas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerDatosSalidas()
        {
            return getDatosTabla("procListaSalidas", new string[0], new string[0]);
        }
        public DataTable ObtenerNotas(string [] Datos)
        {
            string[] Parametros = { "@Name", "@Folio" };
            return getDatosTabla("procMostrarNotas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerOficios(string[] Datos)
        {
            string[] Parametros = { "@Name", "@Folio" };
            return getDatosTabla("procMostrarOficios", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerFormas(string[] Datos)
        {
            string[] Parametros = { "@Name", "@Folio"};
            return getDatosTabla("procMostrarFormas", Parametros, Datos[0], Datos[1]);
        }
        public DataTable ObtenerProductosPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("procProductosPedido", Parametros, Datos[0]);
        }
        public int RegistrarDatosNota (string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Loginn", "@FechaEmision", "@FechaTerminacion", "@Observaciones", "@FechaEntrega" };
            return Ejecutar("Nota", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5]);
        }

    }
}