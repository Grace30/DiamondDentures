using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    class Conexion
    {
        public string[] Instanciaas = { "(local)\\DIAMONDDENTURES", "(local)\\sqlexpress", "(local)\\", "(local)", "." };
        public string strConexionAzure = "Server=tcp:rebeater.database.windows.net,1433;Initial Catalog=DiamondDentures;Persist Security Info=False;User ID=Rebeater;Password=Eber123123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private SqlConnection conexion { get; set; }

        public SqlConnection getAzureConexion()
        {
            conexion = new SqlConnection(strConexionAzure);
            conexion.Open();
            return this.conexion;
        }

        //Método para obtener la conexión
        public SqlConnection getConexion(int INSTANCIA)
        {
            while (INSTANCIA < Instanciaas.Length)
            {
                try
                {
                    conexion = new SqlConnection("Data Source = " + Instanciaas[INSTANCIA] + "; Initial Catalog = DiamondDentures; Integrated Security = True");
                    this.conexion.Open();
                    return this.conexion;
                }
                catch (Exception ms)
                {
                    INSTANCIA++; ;
                }
            } return null;

        }

        //Método para cerrar la conexion
        public void CerrarConexio()
        {
            if (this.conexion != null)
            {

            } this.conexion.Close();
        }
    }
}
