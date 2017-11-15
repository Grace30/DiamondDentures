using System;
using System.Data.SqlClient;
using System.Data;
using Datos;
namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public DataTable ObtenerDatosInsumos(string[] Datos)
        {
            string[] Parametros = { "@Name" };
            return getDatosTabla("InventarioIns", Parametros, Datos[0]);
        }

        public DataTable ObtenerInventarioMateriales(string[] Datos)
        {
            string[] Parametros = { "@Name" };
            return getDatosTabla("InventarioMat", Parametros, Datos[0]);
        }

        public DataTable ComprasAProveedor(string[] Datos)
        {
            string[] Parametros = { "@NombreProv" };
            return getDatosTabla("ComprasAProveedor", Parametros, Datos[0]);
        }

        public DataTable ObtenerRequisiciones(string[] Datos)
        {
            string[] Parametros = { "@IDRequi" };
            return getDatosTabla("procRequisicion", Parametros, Datos[0]);
        }
        public DataTable TodasRequisiciones(string[] Datos)
        {
            string[] Parametros = new string[0];
            return getDatosTabla("RequisicionMat", Parametros, new string[0]);
        }
        public DataTable ObtenerProveedores(string[] Datos)
        {
            string[] Parametros = { "@Name" };
            return getDatosTabla("ListaProv", Parametros, Datos[0]);
        }

        public DataTable ObtenerCatalogo(string[] Datos)
        {
            string[] Parametros = { "@NombrePro" };
            return getDatosTabla("Catalogo", Parametros, Datos[0]);
        }

        public DataTable ObtenerEntradas(string[] Datos)
        {
            string[] Parametros = { "@NombreMat" };
            return getDatosTabla("MaterialIngresado", Parametros, Datos[0]);
        }

        public DataTable ObtenerSalidas(string[] Datos)
        {
            string[] Parametros = { "@NombreMat" };
            return getDatosTabla("MaterialVendido", Parametros, Datos[0]);
        }
        public DataTable RequisicionesAcep(string[] Datos)
        {
            string[] Parametros = { "@IDRequi" };
            return getDatosTabla("RequisicionesAcep", Parametros, Datos[0]);
        }

        public DataTable ObtenerHistorial(string[] Datos)
        {
            string[] Parametros = { "@Empleado", "@Fecha" };
            return getDatosTabla("ObtenerHistorial", Parametros, Datos[0], Datos[1]);
        }

        public DataTable ObtenerFaltantes(string[] Datos)
        {
            string[] Parametros = { "@NombreMat" };
            return getDatosTabla("FaltantesMat", Parametros, Datos[0]);
        }
        public int AgregarProveedor(string[] Datos)
        {
            string Email = "";
            if (Datos[5] == "")
            {
                Email = Datos[3];
                Email += '@' + Datos[4];
            }
            else
            {
                Email = Datos[3];
                Email += '@' + Datos[5];
            }
            string[] Parametros = { "@ClaveProv", "@Nombre", "@Telefono", "@Correo", "@Descrip", "@RFC", "@Contacto", "@Estatus", "@NCuenta"};
            return Ejecutar("AgregarProv", Parametros, Datos[0], Datos[1], Datos[2], Email, Datos[6], Datos[7], Datos[8], Datos[9], Datos[10]);
        }

        public int ActualizarProveedor(string[] Datos)
        {
            string Email = "";
            if (Datos[5] == "")
            {
                Email = Datos[3];
                Email += '@' + Datos[4];
            }
            else
            {
                Email = Datos[3];
                Email += '@' + Datos[5];
            }
            string[] Parametros = { "@ClaveProv", "@Nombre", "@Telefono", "@Correo", "@Descrip", "@RFC", "@Contacto", "@Estatus", "@NCuenta"};
            return Ejecutar("ActualizarProv", Parametros, Datos[0], Datos[1], Datos[2], Email, Datos[6], Datos[7], Datos[8], Datos[9],Datos[10]);
        }

        public int InsertarRequisicion(string[] Datos)
        {
            string[] Parametros = { "@Empleado", "@Fecha", "@CantidadTotal", "@Proveedor" };
            return Ejecutar("InsertRequi", Parametros, Datos[0], Datos[1], Datos[2], Datos[3]);
        }
        public int InsertarDetalleRequisicion(string[] Datos)
        {
            string[] Parametros = { "@IDRequi", "@IDMaterial", "@Cantidad" };
            return Ejecutar("InsertDetalleRequi", Parametros, Datos[0], Datos[1], Datos[2]);
        }

        public int SumarMat(string[] Datos)
        {
            string[] Parametros = { "@IDMat", "@Cantidad" };
            return Ejecutar("SumarMaterial", Parametros, Datos[0], Datos[1]);
        }

        public int EstadoRequi(string[] Datos)
        {
            string[] Parametros = { "@IDRequi" };
            return Ejecutar("EstadoRequi", Parametros, Datos[0]);
        }

        public int HistorialInv(string[] Datos)
        {
            string[] Parametros = { "@Fecha", "@Empleado", "@IDMat", "@NombreMat", "@Cantidad", "@CantidadReal", "@Diferencia" };
            return Ejecutar("HistorialInv", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6]);
        }

        public int ActualizarExistencia(string[] Datos)
        {
            string[] Parametros = { "@IDMat", "@CantidadReal" };
            return Ejecutar("ActualizarExistencia", Parametros, Datos[0], Convert.ToInt32(Datos[1]));
        }

        public int ActualizarCantidades(string[] Datos)
        {
            string[] Parametros = { "@Cantidad", "@Diferencia", "@IDRequi", "@IDMat" };
            return Ejecutar("ActualizarCantidades", Parametros, Convert.ToInt32(Datos[0]), Convert.ToInt32(Datos[1]), Convert.ToInt32(Datos[2]), Datos[3]);
        }

        public int BorrardeRequi(string[] Datos)
        {
            string[] Parametros = { "@Cantidad", "@IDRequi", "@IDMat" };
            return Ejecutar("BorrarMatReq", Parametros, Convert.ToInt32(Datos[0]), Convert.ToInt32(Datos[1]), Datos[2]);
        }
    }
}