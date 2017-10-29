using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
   public class ManejadorReportes
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();

        public DataTable ObtenerDatosVentas()
        {
            return IbaseDatos.ObtenerDatosVentas();
        }
        public DataTable BuscarPorFecha(string[] Datos)
        {
            return IbaseDatos.BuscarPorFecha(Datos);
        }
        public DataTable BuscarPorNombreE(string Datos)
        {
            return IbaseDatos.BuscarPorNombreE(Datos);
        }
        public DataTable BuscarPorNombreProveedor(string Datos)
        {
            return IbaseDatos.BuscarPorNombreProveedor(Datos);
        }
        public DataTable ObtenerDatosCatalago()
        {
            return IbaseDatos.ObtenerDatosCatalago();
        }
        public DataTable ObtenerDatosInventarioMat()
        {
            return IbaseDatos.ObtenerDatosInventarioMat();
        }
        public DataTable ObtenerDatosListaProveedores()
        {
            return IbaseDatos.ObtenerDatosListaProveedores();
        }
        public DataTable ObtenerDatosComprasProveedores()
        {
            return IbaseDatos.ObtenerDatosComprasProveedores();
        }
        public DataTable ObtenerDatosRequisicion()
        {
            return IbaseDatos.ObtenerDatosRequisicion();
        }
        public DataTable ObtenerDatosSalidas()
        {
            return IbaseDatos.ObtenerDatosSalidas();
        }
        public DataTable ObtenerNotas()
        {
            return IbaseDatos.ObtenerNotas();
        }
        public DataTable ObtenerOficios()
        {
            return IbaseDatos.ObtenerOficios();
        }
        public DataTable ObtenerFormas()
        {
            return IbaseDatos.ObtenerFormas();
        }



    }
}
