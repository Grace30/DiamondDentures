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

        private SqlConnection conexion { get; set; }
       
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
