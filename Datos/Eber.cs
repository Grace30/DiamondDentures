using System;
using System.Data;

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

        public DataTable obtenerAsistenciaPorFecha(DateTime fecha)
        {
            string[] Parametros = { "@Fecha" };
            return getDatosTabla("ObtenerAsistenciaPorFecha", Parametros, fecha);
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