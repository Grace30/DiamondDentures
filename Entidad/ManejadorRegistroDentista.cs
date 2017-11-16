using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorRegistroDentista
    {
        ManejadorPrincipal Mprincipal = new ManejadorPrincipal();
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        public ManejadorRegistroDentista()
        {

        }
        //public DataTable ObtenerRegistroDentista(string[] Datos)
        //{
        //    return IbaseDatos.ObtenerInformacionDentistas(Datos);
        //}

        public DataTable Cedulas()
        {
            return IbaseDatos.getCedulas();
        }

        public int RegistrarUsuario(string[] Datos)
        {
            return IbaseDatos.RegistrarDentista(Datos);
        }

        public DataTable nombrecedula(string[] Datos)
        {
            return IbaseDatos.nombrecedula(Datos);
        }

        public int ActualizarDentista(string[] Datos)
        {
            return IbaseDatos.ActualizarDentista(Datos);
        }

        public DataTable getUltimoDentista()
        {
            return IbaseDatos.getUltimoDentista();
        }

        public DataTable selectIDDentista(string[] Datos)
        {
            return IbaseDatos.selectIDDentista(Datos);
        }

        public DataTable getDatosDentista(string[] Datos)
        {
            return IbaseDatos.getDatosDentista(Datos);
        }

        public DataTable selectCedulaNombre(string[] Datos)
        {
            return IbaseDatos.selectCedulaNombre(Datos);
        }
        public int RegistrarDatosForma(string[] Datos)
        {
            return IbaseDatos.RegistrarDatosForma(Datos);
        }
        public int RegistrarDatosOficio(string[] Datos)
        {
            return IbaseDatos.RegistrarDatosOficio(Datos);
        }

    }
}
