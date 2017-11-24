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
            string[] Parametros = { "@Loginn", "@Fecha"};
            return Ejecutar("RegistrarAsistencia", Parametros,loginn, DateTime.Now);
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
                items.Add(new Material(cmdReader["IDMaterial"].ToString(), cmdReader["Nombre"].ToString(),cmdReader["Descripcion"].ToString(), cmdReader["Proveedor"].ToString(), cmdReader["Unidad"].ToString(),Convert.ToInt32(cmdReader["Cantidad"]), Convert.ToDouble(cmdReader["CostoBase"]),Convert.ToDouble(cmdReader["Importe"])));
                int id = Convert.ToInt32(cmdReader["IDRequisicion"]);
                string proveedor = cmdReader["Proveedor"].ToString();
                DateTime fechaSurtido = cmdReader.IsDBNull(14) ? new DateTime(): (DateTime)(cmdReader["FechaSurtido"]) ;
                string Departamento= cmdReader["Departamento"].ToString(); 
                string Solicitante = cmdReader["Solicitante"].ToString();
                DateTime Fecha = (DateTime)cmdReader["Fecha"];
                string surtido= cmdReader["Surtido"].ToString();
                string Estado = cmdReader["Estado"].ToString();
                double Importe = Convert.ToDouble(cmdReader["Importe"]);
                requi = new Requisicion(id, proveedor, fechaSurtido, Departamento, Solicitante, Fecha, surtido, Estado,items.ToArray(), Importe);
            }
            cmdReader.Close();
            conexion.Close();
            return requi;
        }

        public double GetSaldoEnBanco()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new Conexion().getAzureConexion();
            SqlDataReader cmdReader;
            double saldo = 0;
            try
            {
                conexion = new Conexion().getAzureConexion();
                if (conexion.State != ConnectionState.Open) conexion.Open();
                cmd = new SqlCommand("execute getSaldoBanco", conexion);

                cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                    saldo = Convert.ToDouble(cmdReader[0]);
                cmdReader.Close();
                conexion.Close();
            }
            catch (Exception ms)
            { return 0; }
            return saldo;
        }

        public DataTable getRequisicionesConFiltros(string idRequisicion, string estado, string surtido, string solicitante, string autorizante, string proveedor, DateTime fechaSoliIni, DateTime fechaSoliFin, DateTime fechaAutoIni, DateTime fechaAutoFin, DateTime fechaEntregaIni, DateTime fechaEntregaFin)
        {
            string[] Parametros = { "@IdRequisicion", "@Estado", "@Surtido","@Solicitante", "@Autorizante", "@Proveedor",
                        "@FechaSoliIni", "@FechaSoliFin",
                        "@FechaAutoIni", "@FechaAutoFin",
                        "@FechaEntregaIni", "@FechaEntregaFin"};
            return getDatosTabla("getRequisiscionesConFiltro", Parametros, idRequisicion, estado, surtido, solicitante, autorizante, proveedor,
                string.Format("{0}{1:00}{2:00}", fechaSoliIni.Date.Year, fechaSoliIni.Date.Month, fechaSoliIni.Date.Day),
                string.Format("{0}{1:00}{2:00}", fechaSoliFin.Date.Year, fechaSoliFin.Date.Month, fechaSoliFin.Date.Day),
                string.Format("{0}{1:00}{2:00}", fechaAutoIni.Date.Year, fechaAutoIni.Date.Month, fechaAutoIni.Date.Day),
                string.Format("{0}{1:00}{2:00}", fechaAutoFin.Date.Year, fechaAutoFin.Date.Month, fechaAutoFin.Date.Day),
                string.Format("{0}{1:00}{2:00}", fechaEntregaIni.Date.Year, fechaEntregaIni.Date.Month, fechaEntregaIni.Date.Day),
                string.Format("{0}{1:00}{2:00}", fechaEntregaFin.Date.Year, fechaEntregaFin.Date.Month, fechaEntregaFin.Date.Day));
        }

        public double getSaldoCajaConta(double saldAnt)
        {
            double saldo = 0;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new Conexion().getAzureConexion();
            SqlDataReader cmdReader;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                cmd = new SqlCommand("execute getSaldoCajaConta", conexion);
                cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                {
                    saldo = Convert.ToDouble(cmdReader[0].ToString());
                }
            }
            catch (Exception ms)
            { return saldAnt; }
            return saldo;
        }

        public string NombreEmpleados(string loginn)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader cmdReader;
            cmd = new SqlCommand(string.Format("execute getNombreEmpleado '{0}'", loginn), new Conexion().getAzureConexion());
            cmdReader = cmd.ExecuteReader();
            string nombre = "";
            while (cmdReader.Read())
                nombre = cmdReader[0].ToString();

            return nombre;
        }

        public int IngresarCompra(string loginn, string tipo, Requisicion r)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion;
            int f = 0;
            if (tipo != "Corrección")
            {
                cmd = new SqlCommand(string.Format("execute RegistrarCompra '{0}',{1},'{2}',{3},'{4}','{5}'", loginn, r.IdRequisicion, r.Proveedor, r.Total, tipo, "PAGADO"), new Conexion().getAzureConexion());
                f = cmd.ExecuteNonQuery();
                if (tipo == "Material")
                {
                    foreach (var item in r.Items)
                        cmd = new SqlCommand(string.Format("execute RegistrarDetalleComprasMaterial {0}, '{1}',{2}, {3}", r.IdRequisicion, item.IDMaterial, item.Cantidad, item.Importe), new Conexion().getAzureConexion());
                    cmd.ExecuteNonQuery();
                }

                else if (tipo == "Insumo")
                {
                    foreach (var item in r.Items)
                        cmd = new SqlCommand(string.Format("execute RegistrarDetalleCompraInsumo {0}, '{1}',{2}, {3}", r.IdRequisicion, item.IDMaterial, item.Cantidad, item.Importe), new Conexion().getAzureConexion());
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                cmd = new SqlCommand(string.Format("execute RegistrarCompraC '{0}','{1}',{2},'{3}','{4}'", loginn,  "", Math.Abs(r.Total), tipo, "PAGADO"), new Conexion().getAzureConexion());
                f = cmd.ExecuteNonQuery();
            }
            return f;
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

        public int CountRequisicionesPendientes(int countAnt)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new Conexion().getAzureConexion();
            SqlDataReader cmdReader;
            int count = 0;
            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();
                cmd = new SqlCommand("execute countRequisicionesEnEspera", conexion);
                cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                    count = Convert.ToInt32(cmdReader[0]);
            }
            catch (Exception) { return countAnt; }
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

        public int InsertIngreso(string loginn, double cantidad)
        {
            string[] Parametros = { "@Loginn", "@Importe" };
            return Ejecutar("insertarVentaC", Parametros, loginn.TrimEnd(), cantidad);
        }

        public void InsertRetiro(double cantidad)
        {

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

        public double GetSaldoEnBanco(double saldoAnt)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new Conexion().getAzureConexion();
            SqlDataReader cmdReader;
            double saldo = 0;
            try
            {
                conexion = new Conexion().getAzureConexion();
                if (conexion.State != ConnectionState.Open) conexion.Open();
                cmd = new SqlCommand("execute getSaldoBanco", conexion);

                cmdReader = cmd.ExecuteReader();
                while (cmdReader.Read())
                    saldo = Convert.ToDouble(cmdReader[0]);
                cmdReader.Close();
                conexion.Close();
            }
            catch (Exception ms)
            { return saldoAnt; }
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