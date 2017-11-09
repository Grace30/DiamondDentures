using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorPrincipal
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();

        public DataTable Paises()
        {        
            return IbaseDatos.Paises();
        }

        public DataTable Estados(string[] Datos)
        {
            return IbaseDatos.Estados(Datos);
        }
        public DataTable Municipios(string[] Datos)
        {
            return IbaseDatos.Municipios(Datos);
        }
        public DataTable Ciudades(string[] Datos)
        {
            return IbaseDatos.Ciudades(Datos);
        }

        public void CrearBase()
        {
            //IbaseDatos.CrearBase();
        }

        public bool setClaveRegistro(string[] Datos)
        {
            if (IbaseDatos.setClave(Datos)>0)
            {
                return true;                
            }
            else
                return false;
        }

        public DataTable getClave()
        {
            return IbaseDatos.getClave();
        }

        public int checClave(string[] Datos)
        {
            return IbaseDatos.checClave(Datos);
        }

        public DataTable ProductosPedido(string[] Datos)
        {
            return IbaseDatos.getProductos(Datos);
        }

        public DataTable Productos()
        {
            return IbaseDatos.Productos();
        }

        public DataTable getCodigo(string[] Datos)
        {
            return IbaseDatos.procgetCodigo(Datos);
        }

        public DataTable DatosDentista(string[] Datos)
        {
            return IbaseDatos.getDatosDentista(Datos);
        }

        public DataTable Materiales()
        {
            return IbaseDatos.getMateriales();
        }

        public DataTable getUltimoPedido()
        {
            return IbaseDatos.getUltimoPedido();
        }

        public DataTable PrecioProducto(string[] Datos)
        {
            return IbaseDatos.getPrecioProducto(Datos);
        }

        public DataTable PrecioMaterial(string[] Datos)
        {
            return IbaseDatos.getPrecioMaterial(Datos);
        }
        public int CrearPedido(string[] Datos)
        {
            return IbaseDatos.CrearPedido(Datos);
        }

        public int InsertarProducto(string[] Datos)
        {
            return IbaseDatos.InsertarProducto(Datos);
        }

        public DataTable getProductosPedido(string[] Datos)
        {
            return IbaseDatos.getProductosPedido(Datos);
        }

        public int SacarProducto(string[] Datos)
        {
            return IbaseDatos.SacarProducto(Datos);
        }

        public int GenerarPedido(string[] Datos)
        {
            return IbaseDatos.GenerarPedido(Datos);
        }

        public DataTable getPedidos() {
            return IbaseDatos.getPedidos();
        }

        public DataTable getIDProducto(string[] Datos)
        {
            return IbaseDatos.getIDProducto(Datos);
        }

        public DataTable getCodigoMaterial(string[] Datos)
        {
            return IbaseDatos.getCodigoMaterial(Datos);
        }

        public DataTable selectPedido(string[] Datos)
        {
            return IbaseDatos.selectPedido(Datos);
        }

        public int BorrarPedido(string[] Datos)
        {
            return IbaseDatos.EliminarPedido(Datos);
        }

        public DataTable getTiempos(string[] Datos)
        {
            return IbaseDatos.getTiempos(Datos);
        }
    }
}
