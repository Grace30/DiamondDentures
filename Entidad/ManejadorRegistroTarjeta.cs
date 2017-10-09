using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorRegistroTarjeta
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        public ManejadorRegistroTarjeta()
        {

        }

        public int EliminarRegistroTarjetas(string[] Datos)
        {
            return IbaseDatos.EliminarTarjeta(Datos);
        }

        public int RegitrarTarjeta(string[] Datos)
        {
            return IbaseDatos.CrearRegistoTarjeta(Datos);
        }
        public int ActualizarTarjeta(string[] Datos)
        {
            return IbaseDatos.ActualizarRegistroTarjeta(Datos);
        }


        public DataTable TarjetasRegistradas(string[] Datos)
        {
            return IbaseDatos.TarjetasRegistradas(Datos);
        }
        public DataTable ObtenerInformacionTarjeta(string[] Datos)
        {
            return IbaseDatos.ObtenerInformacionTarjeta(Datos);
        }

    }
}

