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

        public DataTable ObtenerDatosVentas(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosVentas(Datos);
        }
        public DataTable ObtenerCortes()
        {
            return IbaseDatos.ObtenerCortes();
        }
        public DataTable BuscarPorFecha(string[] Datos)
        {
            return IbaseDatos.BuscarPorFecha(Datos);
        }
        public DataTable ObtenerBalanceGeneral(string[] Datos)
        {
            return IbaseDatos.ObtenerBalanceGeneral(Datos);
        }
        public DataTable BuscarCorteCaja(string[] Datos)
        {
            return IbaseDatos.BuscarPorNombreFolio(Datos);
        }
        public DataTable BuscarCortePorFecha(string[] Datos)
        {
            return IbaseDatos.BuscarCortePorFecha(Datos);
        }
        public DataTable BuscarPorNombreE(string Datos)
        {
            return IbaseDatos.BuscarPorNombreE(Datos);
        }
        public DataTable BuscarPorNombreProveedor(string Datos)
        {
            return IbaseDatos.BuscarPorNombreProveedor(Datos);
        }
        public DataTable NominaMes(int Mes)
        {
            return IbaseDatos.NominaMes(Mes);
        }
        public DataTable ObtenerNominaGeneral()
        {
            return IbaseDatos.ObtenerNominaGeneral();
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
        public DataTable ObtenerDatosRequisicion(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosRequisicion(Datos);
        }
        public DataTable ObtenerDatosSalidas()
        {
            return IbaseDatos.ObtenerDatosSalidas();
        }
        public DataTable ObtenerNotas(string[] Datos)
        {
            return IbaseDatos.ObtenerNotas(Datos);
        }
        public DataTable ObtenerOficios(string[] Datos)
        {
            return IbaseDatos.ObtenerOficios(Datos);
        }
        public DataTable ObtenerFormas(string[] Datos)
        {
            return IbaseDatos.ObtenerFormas(Datos);
        }
        public DataTable ObtenerProductosPedido(string[] Datos)
        {
            return IbaseDatos.ObtenerProductosPedido(Datos);
        }
        public int RegistrarDatosNota(string[] Datos)
        {
            return IbaseDatos.RegistrarDatosNota(Datos);
        }



    }
}
