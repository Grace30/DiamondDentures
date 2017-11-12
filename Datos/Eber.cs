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

        public Requisicion getRequisicion(int idRequisicion)
        {
            Requisicion requi = new Requisicion();
            List<Material> items = new List<Material>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            double saldo = 0;
            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("execute getDetallesRequisicion " + idRequisicion, conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
            {
                items.Add(new Material(cmdReader["IDMaterial"].ToString(), cmdReader["Nombre"].ToString(),cmdReader["Descripcion"].ToString(), cmdReader["Proveedor"].ToString(), cmdReader["Unidad"].ToString(),Convert.ToInt32(cmdReader["Cantidad"]), Convert.ToDouble(cmdReader["CostoBase"])));
                requi = new Requisicion(Convert.ToInt32(cmdReader["IDRequisicion"]), cmdReader["Departamento"].ToString(), cmdReader["Solicitante"].ToString(),(DateTime)cmdReader["Fecha"], cmdReader["Surtido"].ToString(), cmdReader["Estado"].ToString(), items.ToArray());
            }
            cmdReader.Close();
            conexion.Close();
            return requi;
        }

        public int AutorizarRequisicion(int IDRequisicion, string Loginn)
        {
            string[] Parametros = { "@IDRequisicion", "@Loginn"};
            return Ejecutar("AutorizarRequisicion", Parametros, IDRequisicion, Loginn);
        }

        public object[] NombreProveedores()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            List<string> empleados = new List<string>();
            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("execute NombreProvedores", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                empleados.Add(cmdReader[0].ToString());
            return empleados.ToArray();
        }

        public object[] NombreEmpleados()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            List<string> empleados = new List<string>();
            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("execute NombreEmpleados", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                empleados.Add(cmdReader[0].ToString());
            return empleados.ToArray();
        }

        public int CountRequisicionesPendientes()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            int count = 0;
            conexion = new Conexion().getAzureConexion();

            cmd = new SqlCommand("execute countRequisicionesEnEspera", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                count = Convert.ToInt32(cmdReader[0]);
            return count;
        }


        public string[] NombreEmpleadosContabilidad()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            SqlDataReader cmdReader;
            List<string> empleados = new List<string>();
            conexion = new Conexion().getAzureConexion();
            cmd = new SqlCommand("execute NombreEmpleadosContabilidad", conexion);
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                empleados.Add(cmdReader[0].ToString());
            return empleados.ToArray();
        }

        public void InsertIngreso(double cantidad)
        {//Venta

        }

        public void InsertRetiro(double cantidad)
        {//Compra

        }
        public object[] getAñoBalance()
        {
            List<string> periodos = new List<string>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader cmdReader;
            cmd = new SqlCommand("getAñoDeBalance", new Conexion().getAzureConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                periodos.Add(cmdReader[0].ToString());


            return periodos.ToArray();
        }

        public string[] getPeriodosBalance(int año)
        {
            List<string> periodos = new List<string>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader cmdReader;
            
            cmd = new SqlCommand("getPeriodosDeBalance", new Conexion().getAzureConexion());
            cmd.Parameters.AddWithValue("@Año", año);
            cmd.CommandType = CommandType.StoredProcedure;
            cmdReader = cmd.ExecuteReader();
            while (cmdReader.Read())
                periodos.Add(cmdReader[0].ToString());


            return periodos.ToArray();
        }

        public double[] GetTotalesBalance(DateTime desde, DateTime hasta)
        {
            double[] totales = new double[3];
            SqlCommand cmd = new SqlCommand();
            SqlDataReader cmdReader;
            string[] Parametros = { "@Desde", "@Hasta" };
            
            cmd = new SqlCommand(string.Format("getTotalesBalance", desde.Date, hasta.Date), new Conexion().getAzureConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Desde", desde);
            cmd.Parameters.AddWithValue("@Hasta", hasta);
            cmdReader = cmd.ExecuteReader();

            while (cmdReader.Read())
                totales = new double[] { Convert.ToDouble(cmdReader[0]), Convert.ToDouble(cmdReader[1]), Convert.ToDouble(cmdReader[2]) };
            return totales;
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

        public DataTable getRequisicionesPorAprobar()
        {
            return getDatosTabla("getRequisiscionesPorAprobar", new string[0], new string[0]);
        }

        public int PagarAEmpleado(string loginn, double sueldo, int mes , string TasaISR, string CuotaISR, string APagar)
        {
            string[] Parametros = { "@Loginn", "@Sueldo", "@Mes", "@TasaISR", "@CuotaISR", "@APagar"};
            return Ejecutar("PagarAEmpleado", Parametros, loginn.TrimEnd(), sueldo,mes, TasaISR, CuotaISR, APagar);
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
                salario = new Salario(cmdReader[0].ToString(), cmdReader[1].ToString(), cmdReader[2].ToString(), cmdReader[3].ToString(), cmdReader[4].ToString(), cmdReader[5].ToString(), cmdReader[6].ToString(), cmdReader[7].ToString(), cmdReader[8].ToString());
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