﻿using System;
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

        public object[] getAñoBalance()
        {
            return IbaseDatos.getAñoBalance(); 
        }

        public object[] getPeriodosBalance(int año)
        {
            return IbaseDatos.getPeriodosBalance(año);
        }

        public object[] NombreEmpleados()
        {
            return IbaseDatos.NombreEmpleados();
        }

        public object[] NombreProveedores()
        {
            return IbaseDatos.NombreProveedores();
        }

        public DataTable getBalance(DateTime Desde, DateTime Hasta)
        {
            return IbaseDatos.getBalance(Desde, Hasta);
        }

       

        public string[] listaDeUsuarios()
        {
                return IbaseDatos.ListaUsuarios();
        }

        public void calcularpagoAEmpleados()
        {
            IbaseDatos.calcularPagoAempleados(9);
        }

        public string NombreEmpleados(string loginn)
        {
            return IbaseDatos.NombreEmpleados(loginn);
        }

        public DataTable ObtenerAsistenciaPorFecha(DateTime fecha)
        {
            return IbaseDatos.obtenerAsistenciaPorFecha(fecha);
        }

        public Salario calcularPagoPorMes(string Loginn, int Mes)
        {
            return IbaseDatos.calcularPagoMes(Loginn, Mes);
        }

     

        public object[] NombreEmpleadosContabilidad()
        {
            return IbaseDatos.NombreEmpleadosContabilidad();
        }

        public DataTable ObtenerRegistroAsistencia(string Nombres, string Apellidos)
        {
            return IbaseDatos.obtenerAsistenciaPorNombre(Nombres, Apellidos);
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

        public DataTable ObtenerRegistroAsistencia(string Loginn , DateTime Date)
        {
            return IbaseDatos.ObtenerRegistroAsistencia(Loginn, Date);
        }

        public DataTable ObtenerAsistenciaPorUsuario(string loginn)
        {
            return IbaseDatos.obtenerAsistenciaPorUsuario(loginn);
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

        public int RegistrarAsistencia(string Loginn)
        {
            return IbaseDatos.RegistrarAsistencia(Loginn);
        }

        public int PagarAEmpleado(string Loginn, double Sueldo, int Mes, string TasaISR,  string CuotaISR , string APagar)
        {
            return IbaseDatos.PagarAEmpleado(Loginn,Sueldo, Mes, TasaISR, CuotaISR, APagar);
        }
    }
}