using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Entidad; 

namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public int RegistrarAsistencia(string loginn)
        {
            string[] Parametros = { "@Loginn"};
            return Ejecutar("RegistrarAsistencia", Parametros,loginn);
        }

        public DataTable ObtenerRegistroAsistencia(string loginnn, DateTime date)
        {
            string[] Parametros = { "@Loginn", "@Fecha" };
            return getDatosTabla("ValidarAsistencia", Parametros, loginnn, date);
        }
        

        public DataTable ObtenerProveedores(object id, object nombre, object correo, object rFC, object contacto, object estatus)
        {
            string[] Parametros = { "@Clave", "@Nombre", "@Correo", "@RFC", "@Contacto", "@Estatus" };
            return getDatosTabla("ObtenerProvedores", Parametros, id, nombre, correo, rFC, contacto, estatus);
        }

        public DataTable getBalance(DateTime desde, DateTime hasta)
        {
            string[] Parametros = { "@Desde", "@Hasta" };
            return getDatosTabla("getBalance", Parametros, desde,hasta);
        }

        public double GetSaldoEnBanco()
        { 
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            double saldo = 0;
            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("execute getSaldoBanco", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                saldo = Convert.ToDouble(cmdReader[0]);
            cmdReader.Close();
            conexion.Close();

            return saldo;


        }

        public string[] ListaUsuarios()
        {
            List<string> usuario = new List<string>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            string Vver = string.Empty;

            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("ListarEmpleados", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                 usuario.Add(Convert.ToString((cmdReader[0])));
            cmdReader.Close();
            conexion.Close();
           
            return usuario.ToArray();
        }

        public void calcularPagoAempleados(int Mes)
        {/*
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            //cmd.Connection = conexion.getConexion(0);
            cmd.Connection = conexion.getAzureConexion();
            cmd.CommandText = "getPagoMensual";
            cmd.CommandType = CommandType.StoredProcedure;
            Ejecutar("ContarEmpleados",null);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {

            }

            if (Proc.Length != 0 && Parametros.Length == DatosParametro.Length)
            {
                int i = 0;
                foreach (string parametro in Parametros)
                    cmd.Parameters.AddWithValue(parametro, DatosParametro[i++]);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ms)
                {

                    return 0;
                }
            }
            return 0;*/
        }

        public DataTable obtenerAsistenciaPorFecha(DateTime fecha)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("ObtenerAsistenciaPorFecha", Parametros, fecha);
        }

        public Salario calcularPagoMes(string  loginn, int mes)
        {
            Salario salario = new Salario();

            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            string Vver = string.Empty;

            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand(string.Format(" getPagoMensual {0}, {1}",loginn, mes), conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                salario  = new Salario(cmdReader[0].ToString(), cmdReader[1].ToString(), cmdReader[2].ToString(), cmdReader[3].ToString());
            cmdReader.Close();
            conexion.Close();

            return salario;
        }

        public DataTable obtenerAsistenciaPorNombre(string nombres, string apellidos)
        {
            string[] Parametros = { "@Nombres", "@Apellidos" };
            return getDatosTabla("ObtenerAsistenciaPorNombre", Parametros, nombres, apellidos);
        }

        public DataTable obtenerAsistenciaPorUsuario(string loginn)
        {
            string[] Parametros = { "@Loginn"};
            return getDatosTabla("ObtenerAsistenciaPorUsuario", Parametros, loginn);
        }
    }
}