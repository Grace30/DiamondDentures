using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorRegistroProveedor
    {
        ManejadorPrincipal Mprincipal = new ManejadorPrincipal();
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();

        public ManejadorRegistroProveedor()
        {

        }
        
        public DataTable ObtenerProvedores(string id, string Nombre, string Correo, string RFC, string Contacto, string Estatus)
        {
            return IbaseDatos.ObtenerProveedores(id, Nombre,Correo ,RFC , Contacto , Estatus);
        }
    }
}
