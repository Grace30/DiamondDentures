using System;
using System.Data;

namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public DataTable ObtenerDatosVentas()
        {
            return getDatosTabla("procTodasVentas", new string[0], new string[0]);
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
        public DataTable ObtenerDatosRequisicion()
        {
            return getDatosTabla("procRequisionTodas", new string[0], new string[0]);
        }
        public DataTable ObtenerDatosSalidas()
        {
            return getDatosTabla("procListaSalidas", new string[0], new string[0]);
        }
        public DataTable ObtenerNotas()
        {
            return getDatosTabla("procMostrarNotas", new string[0], new string[0]);
        }
        public DataTable ObtenerOficios()
        {
            return getDatosTabla("procMostrarOficios", new string[0], new string[0]);
        }
        public DataTable ObtenerFormas()
        {
            return getDatosTabla("procMostrarFormas", new string[0], new string[0]);
        }
    }
}