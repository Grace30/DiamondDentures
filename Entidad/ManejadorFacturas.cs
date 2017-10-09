using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Entidad
{
   public class ManejadorFacturas
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();

        public DataTable ObtenerDatosPedido()
        {
            return IbaseDatos.ObtenerDatosPedido();
        }
        public DataTable ObtenerFacturas()
        {
            return IbaseDatos.ObtenerFacturas();
        }
        public DataTable ElaborarFactura(string[] Datos)
        {
            return IbaseDatos.ElaborarFactura(Datos);
        }
        public DataTable ProductosFacturar(string[] Datos)
        {
            return IbaseDatos.ProductosFacturar(Datos);
        }

        public DataTable BuscarFactura(string[] Datos)
        {
            return IbaseDatos.BuscarFactura(Datos);
        }
        public DataTable CrearFactura(string[] Datos)
        {
            return IbaseDatos.CrearFactura(Datos);
        }
         public DataTable BuscarPorPedido(string[]Datos)
        {
            return IbaseDatos.BuscarPorPedido(Datos);
        }
         public DataTable BuscarPorFactura(string[] Datos)
         {
             return IbaseDatos.BuscarPorFactura(Datos);
         }
         public int RegistrarDatosFactura(string[] Datos)
         {
             return IbaseDatos.RegistrarDatosFactura(Datos);
         }
         public int ModificarDatosFactura(string[] Datos)
         {
             return IbaseDatos.ModificarDatosFactura(Datos);
         }
         public int RegistrarComentario(string[] Datos)
         {
             return IbaseDatos.RegistrarComentario(Datos);

         }
         public DataTable MostrarDatosNota(string[] Datos)
         {
             return IbaseDatos.MostrarDatosNota(Datos);
         }


    }
}
