using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Entidad
{
    public class ManejadorRegistroUsuario
    {
        ManejadorPrincipal Mprincipal = new ManejadorPrincipal();
        InterfaceBaseDeDatos IbaseDatos = new InterfaceBaseDeDatos();
        public ManejadorRegistroUsuario()
        {

        }
        public DataTable Laboratoristas(string[] Datos)
        {
            return IbaseDatos.Laboratoristas(Datos);
        }

        public DataTable Departamento(string [] Datos)
        {
            return IbaseDatos.Departamento(Datos);
        }

        public DataTable ObtenerRegistroUsuario(string[] Datos)
        {
            return IbaseDatos.ObtenerInformacionUsuario(Datos);
        }

        public DataTable UsuariosRegistrados()
        {
            return IbaseDatos.UsuariosRegistrados();
        }

        public int RegistrarUsuario(string[] Datos)
        {
            return IbaseDatos.CrearRegistroUsuario(Datos);
        }

        public int ValidarUsuario(string[] Datos)
        {
            return IbaseDatos.ValidarUsuario(Datos);
        }

        public string[] RecuperarContraseña(string[] Datos)
        {
            var datosRegistro = new DataTable();
            datosRegistro = IbaseDatos.RecuperarContraseña(Datos);
            string[] datosusuario = new string[2];
            foreach (DataRow fila in datosRegistro.Rows)
            {
                datosusuario[0] = fila["Loginn"].ToString();
                datosusuario[1] = fila["Passwordd"].ToString();
            }
            return datosusuario;
        }

        public int ActualizaDatosRegistro(string[] Datos)
        {
            return IbaseDatos.ActualizarRegistroUsuario(Datos);
        }

        public int EliminarRegistro(string[] Datos)
        {
            return IbaseDatos.EliminarUsuario(Datos);
        }


    }
}