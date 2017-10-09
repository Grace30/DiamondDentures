using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorControlPedido
    {
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();

        public DataTable ObtenerPedido (string [] Datos)
        {
            return IbaseDatos.ObtenerPedido(Datos);
        }
        public DataTable ObtenerDatosPedido(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosPedido(Datos);
        }

        public DataTable ObtenerDatosPiezas(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosPiezas(Datos);
        }

        public DataTable ObtenerDatosMateriales(string[] Datos)
        {
            return IbaseDatos.ObtenerDatosMateriales(Datos);
        }

        public DataTable EditarPieza(string[] Datos)
        {
            return IbaseDatos.EditarPieza(Datos);
        }

        public DataTable EditarMaterial(string[] Datos)
        {
            return IbaseDatos.EditarMaterial(Datos);
        }

        public int ActualizarPieza(string[] Datos)
        {
            return IbaseDatos.ActualizarPieza(Datos);
        }
        public int ActualizarMaterial(string[] Datos)
        {
            return IbaseDatos.ActualizarMaterial(Datos);
        }

        public int CambiarLab(string[] Datos)
        {
            return IbaseDatos.CambiarLab(Datos);
        }
        public int AgregarDatosPieza(string[] Datos)
        {
            return IbaseDatos.AgregarDatosPieza(Datos);
        }
        public int AgregarDatosMaterial(string[] Datos)
        {
            return IbaseDatos.AgregarDatosMaterial(Datos);
        }

        public int BorrarPieza(string[] Datos)
        {
            return IbaseDatos.BorrarPieza(Datos);
        }
        public int BorrarMaterial(string[] Datos)
        {
            return IbaseDatos.BorrarMaterial(Datos);
        }

        public int CambiarEstado(string[] Datos)
        {
            return IbaseDatos.CambiarEstado(Datos);
        }

        public int Urgente(string[] Datos)
        {
            return IbaseDatos.Urgente(Datos);
        }
    }
}
