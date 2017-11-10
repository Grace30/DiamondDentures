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
        //public string strConexionAzure = "Data Source=DESKTOP-K4HLM96;Initial Catalog=DiamondDentures;Integrated Security=True";
        private SqlConnection conexionAzure;

        public SqlConnection getAzureConexion()
        {
            conexionAzure = new SqlConnection(strConexionAzure);
            try
            {
                conexionAzure.Open();
            }
            catch (Exception ms)
            {
               
            }
            return conexionAzure;
        }

        //Método para obtener la conexión
        public SqlConnection getConexion(int INSTANCIA)
        {
            while (INSTANCIA < Instanciaas.Length)
            {
                try
                {
                    conexionAzure = new SqlConnection("Data Source = " + Instanciaas[INSTANCIA] + "; Initial Catalog = DiamondDentures; Integrated Security = True");
                    this.conexionAzure.Open();
                    return this.conexionAzure;
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
            if (this.conexionAzure != null)
            {

            } this.conexionAzure.Close();
        }
    }
}
