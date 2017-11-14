using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Datos
{
    public partial class InterfaceBaseDeDatos
    {
        public string[] Instanciaas = { "(local)\\DIAMONDDENTURES", "(local)\\SQLEXPRESS", "(local)\\msqlexpress", "(local)\\", ".", "(local)" };
        public int INSTANCIA;
        public string strConexionAzure = "Server=tcp:rebeater.database.windows.net,1433;Initial Catalog=DiamondDentures;Persist Security Info=False;User ID=Rebeater;Password=Eber123123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //Ingresar Datos en la tabla
        public DataTable getDatosTabla(string Proc, string[] Parametros, params Object[] DatosParametro)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            //cmd.Connection = conexion.getConexion(0);
            cmd.Connection = conexion.getAzureConexion();
            cmd.CommandText = Proc;
            cmd.CommandType = CommandType.StoredProcedure;
            
            if (Proc.Length != 0 && Parametros.Length == DatosParametro.Length)
            {
                int i = 0;
                foreach (string parametro in Parametros)
                    cmd.Parameters.AddWithValue(parametro, DatosParametro[i++]);
                try
                {
                    SqlDataReader dr = null;
                    dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
                catch (Exception ms)
                { }
            }
            return dt;
        }

        //Ejecutar Procedimiento
        public int Ejecutar(string Proc, string[] Parametros, params Object[] DatosParametro)
        {
            SqlCommand cmd = new SqlCommand();
            Conexion conexion = new Conexion();
            //cmd.Connection = conexion.getConexion(0);
            cmd.Connection = conexion.getAzureConexion();
            cmd.CommandText = Proc;
            cmd.CommandType = CommandType.StoredProcedure;
            
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
            return 0;

        }

        public int CrearRegistroUsuario(string[] Datos)
        {
            string Email = "";
            if (Datos[14] == "")
            {
                Email = Datos[12];
                Email += '@' + Datos[13];
            }
            else
            {
                Email = Datos[12];
                Email += '@' + Datos[14];
            }
            string[] Parametros = { "@Nombre", "@Direccion", "@Colonia", "@Ciudad", "@Municipio", "@Estado", "@Pais", "@CP", "@TelCasa", "@TelOfi", "@TelCel", "@Email", "@Loginn", "@Passwordd", "@Apellidos", "@Pregunta", "@Respuesta", "@Activo", "@Departamento" };
            return Ejecutar("procRegistrar", Parametros, Datos[0], Datos[2], Datos[3], Datos[7], Datos[6], Datos[5], Datos[4], Datos[8], Datos[9], Datos[10], Datos[11], Email, Datos[15], Datos[16], Datos[1], Datos[17], Datos[18], 0, Datos[19]);
        }

        public int CrearRegistoTarjeta(string[] Datos)
        {
            string FechaV = (Datos[7] + "-" + Datos[6]);
            string Banco = "";
            if (Datos[4] == "")
                Banco = Datos[2];
            else
                Banco = Datos[4];
            string Tipo = "";
            if (Datos[5] == "")
                Tipo = Datos[3];
            else
                Tipo = Datos[5];
            string[] Parametros = { "@Nombre", "@NumTar", "@BancoTar", "@FechaV", "@Tipo", "@Loginn" };
            return Ejecutar("procRegistrarTar", Parametros, Datos[0], Datos[1], Banco, FechaV, Tipo, Datos[8]);
        }
        public DataTable nombrecedula(string[] Datos)
        {
            string[] Parametros = { "@ID" };
            return getDatosTabla("nombrecedula", Parametros, Datos[0]);
        }

        public int ActualizarRegistroUsuario(string[] Datos)
        {
            string Email = "";
            if (Datos[14] == "")
            {
                Email = Datos[12];
                Email += '@' + Datos[13];
            }
            else
            {
                Email = Datos[12];
                Email += '@' + Datos[14];
            }
            string[] Parametros = { "@Nombre", "@Direccion", "@Colonia", "@Ciudad", "@Municipio", "@Estado", "@Pais", "@CP", "@TelCasa", "@TelOfi", "@TelCel", "@Email", "@Loginn", "@Passwordd", "@Apellidos", "@Pregunta", "@Respuesta", "@Activo", "@Departamento" };
            return Ejecutar("procActualizarUsuario", Parametros, Datos[0], Datos[2], Datos[3], Datos[7], Datos[6], Datos[5], Datos[4], Datos[8], Datos[9], Datos[10], Datos[11], Email, Datos[15], Datos[16], Datos[1], Datos[17], Datos[18], 0, Datos[19]);
        }

        public int ActualizarRegistroTarjeta(string[] Datos)
        {
            string FechaV = (Datos[7] + "-" + Datos[6]);
            string Banco = "";
            if (Datos[4] == "")
                Banco = Datos[2];
            else
                Banco = Datos[4];
            string Tipo = "";
            if (Datos[5] == "")
                Tipo = Datos[3];
            else
                Tipo = Datos[5];
            string[] Parametros = { "@Nombre", "@NumTar", "@BancoTar", "@FechaV", "@Tipo" };
            return Ejecutar("procActualizarTarjeta", Parametros, Datos[0], Datos[1], Banco, FechaV, Tipo);
        }

        public DataTable ObtenerInformacionUsuario(string[] Datos)
        {
            string[] Parametros = { "@Loginn" };
            return getDatosTabla("procBuscarUsuario", Parametros, Datos[0]);
        }

        public DataTable ObtenerInformacionTarjeta(string[] Datos)
        {
            string[] Parametros = { "@NumTar" };
            return getDatosTabla("procBuscarTarjeta", Parametros, Datos[0]);
        }

        public int EliminarTarjeta(string[] Datos)
        {
            string[] Parametros = { "@NumTar" };
            return Ejecutar("procEliminarTarjeta", Parametros, Datos[0]);
        }

        public int EliminarUsuario(string[] Datos)
        {
            string[] Parametros = { "@Loginn" };
            return Ejecutar("procEliminarUsuario", Parametros, Datos[0]);
        }

        public int ValidarUsuario(string[] Datos)
        {
            string[] Parametros = { "@Loginn", "@Passwordd" };
            return Ejecutar("procValidarUsuario", Parametros, Datos[0], Datos[1]);
        }

        public DataTable RecuperarContraseña(string[] Datos)
        {
            string[] Parametros = { "@Email", "@Pregunta", "@Respuesta" };
            return getDatosTabla("procRecuperarContraseña", Parametros, Datos[0], Datos[1], Datos[2]);
        }

        public DataTable UsuariosRegistrados()
        {
            string[] Parametros = { "@Loginn" }; ;
            return getDatosTabla("procUsuariosRegistrados", Parametros, "Admin");
        }

        public DataTable TarjetasRegistradas(string[] Datos)
        {
            string[] Parametros = { "@Loginn" }; ;
            return getDatosTabla("procTarjetasRegistradas", Parametros, Datos[0]);
        }

        public DataTable Paises()
        {
            string[] Parametros = { "@ClavePais" }; ;
            return getDatosTabla("Paises", Parametros, 0);
        }

        public DataTable Estados(string[] Datos)
        {
            string[] Parametros = { "@ClavePais" }; ;
            Datos[0] = (Convert.ToInt32(Datos[0]) + 1).ToString();
            return getDatosTabla("Estados", Parametros, Datos[0]);
        }

        public DataTable Municipios(string[] Datos)
        {
            string[] Parametros = { "@ClaveEst" }; ;
            return getDatosTabla("Municipios", Parametros, Datos[0]);
        }

        public DataTable Ciudades(string[] Datos)
        {
            string[] Parametros = { "@NombreEstado", "@NombreMunicipio" };
            return getDatosTabla("Ciudades", Parametros, Datos[1], Datos[0]);
        }

        public DataTable getClave()
        {
            string[] Parametros = { "@Clave" };
            return getDatosTabla("getClave", Parametros, " ");
        }

        public int setClave(string[] Datos)
        {
            string[] Parametros = { "@Clave" };
            return Ejecutar("setClave", Parametros, Datos[0]);
        }

        public int checClave(string[] Datos)
        {
            string[] Parametros = { "@Clave" };
            return Ejecutar("checClave", Parametros, Datos[0]);
        }
        //Procedimientos del dani
        public int RegistrarDentista(string[] Datos)
        {
            string[] Parametros = { "@Cedula", "@RFC", "@Nombre", "@Apellidos", "@Direccion", "@NumeroExterior", "@Pais", "@Estado", "@Municipio", "@Ciudad", "@Colonia", "@CodigoPostal", "@Telefono", "@Email", "@Activo", "@Consultorio", "@FechaAlta", "@FechaNac" };
            return Ejecutar("procRegistrarDentista", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12], Datos[13], Datos[14], Datos[15], Datos[16],Datos[17]);
        }
        public DataTable getCedulas()
        {
            return getDatosTabla("getCedulas", new string[0], new string[0]);
        }
        public int RegistrarProducto(string[] Datos)
        {
            string[] Parametros = { "@ID", "@Dentista" };
            return Ejecutar("procRegistrarProducto", Parametros, Datos[0], Datos[1]);
        }

        public int RegistrarPedido(string[] Datos)
        {
            string[] Parametros = { "" };
            return Ejecutar("procPedido", Parametros, Datos);
        }

        public int setProductos(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Producto, @Precio, @Cantidad" };
            return Ejecutar("procsetProductos", Parametros, Datos[0], Datos[1], Datos[2], Datos[3]);
        }

        public int GenerarPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Dentista","@Empleado", "@Estatus", "@FechaIngreso", "@FechaCalculada", "@FechaEntrega", "@Urgencia", "@Total", "@Fabricante", "@Pagado", "@Restante", "@IVA", "@Devuelto", "@Devolucion", "@Modificacion", "@FechaModi"  };
            return Ejecutar("GenerarPedido", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12], Datos[13], Datos[14], Datos[15], Datos[16]);
        }

        public DataTable getProductos(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("procgetProductos", Parametros, Datos[0]);
        }

        public DataTable Productos()
        {
            string[] Parametros = new string[0];
            string[] Datos = new string[0];
            return getDatosTabla("procProductos", Parametros, Datos);
        }

        public DataTable procgetCodigo(string[] Datos)
        {
            string[] Parametros = { "@Nombre", "@Material" };
            return getDatosTabla("procgetCodigo", Parametros, Datos[0], Datos[1]);
        }

        public DataTable getDatosDentista(string[] Datos)
        {
            string[] Parametros = { "@Cedula" };
            return getDatosTabla("procDatosDentista", Parametros, Datos[0]);
        }

        public int ActualizarDentista(string[] Datos)
        {
            string[] Parametros = { "@Cedula", "@RFC", "@Nombre", "@Direccion", "@NumeroExterior", "@Pais",
                "@Estado", "@Municipio", "@Ciudad", "@Colonia", "@CodigoPostal", "@Telefono", "@CedulaVieja","@Apellidos", "@Email","@Consultorio","@FechaNac" };
            return Ejecutar("procActualizarDentista", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4],
                Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12], Datos[13], Datos[14], Datos[15], Datos[16]);
        }

        public DataTable getUltimoDentista()
        {
            return getDatosTabla("getUltimoDentista", new string[0], new string[0]);
        }

        public DataTable getMateriales()
        {
            return getDatosTabla("getMateriales", new string[0], new string[0]);
        }

        public DataTable getUltimoPedido()
        {
            return getDatosTabla("getUltimoPedido", new string[0], new string[0]);
        }

        public DataTable getPrecioProducto(string[] Datos)
        {
            string[] Parametros = { "@Nombre" };
            return getDatosTabla("getPrecioProducto", Parametros, Datos[0]);
        }
        public DataTable getPrecioMaterial(string[] Datos)
        {
            string[] Parametros = { "@Nombre" };
            return getDatosTabla("getPrecioMaterial", Parametros, Datos[0]);
        }

        public int CrearPedido(string[] Datos)
        {
            string[] Parametros = { "@Dentista", "@Empleado" ,"@Estatus" };
            return Ejecutar("CrearPedido", Parametros, Datos[0], Datos[1], Datos[2]);
        }

        public int InsertarProducto(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Especial", "@Cantidad", "@SubTotal" };
            return Ejecutar("procInsertarProducto", Parametros, Datos[0], Datos[1], Datos[2], Datos[3]);
        }

        public DataTable getProductosPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("getProductosPedido", Parametros, Datos[0]);
        }

        public int SacarProducto(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@CodigoEspecial"};
            return Ejecutar("SacarProducto", Parametros, Datos[0], Datos[1]);
        }

        public DataTable getPedidos()
        {
            return getDatosTabla("getPedidos", new string[0], new string[0]);
        }

        public DataTable getIDProducto(string[] Datos)
        {
            string[] Parametros = { "@Codigo" };
            return getDatosTabla("getIDProducto", Parametros, Datos[0]);
        }

        public DataTable getCodigoMaterial(string[] Datos)
        {
            string[] Parametros = { "@Nombre" };
            return getDatosTabla("getCodigoMaterial", Parametros, Datos[0]);
        }

        public DataTable selectIDDentista(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("selectIDDentista", Parametros, Datos[0]);
        }

        public DataTable selectCedulaNombre(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("selectNombreCedula", Parametros, Datos[0]);
        }
        public DataTable selectPedido(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("selectPedido", Parametros, Datos[0]);
        }
        public int EliminarPedido(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return Ejecutar("EliminarPedido", Parametros, Datos[0]);
        }

        public DataTable getTiempos(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("getTiempos", Parametros, Datos[0]);
        }
        //Procedimientos Maribel
        public DataTable ObtenerDatosPedido()
        {
            return getDatosTabla("procMostrarPedido", new string[0], new string[0]);
        }
        public DataTable ObtenerFacturas()
        {
            return getDatosTabla("procVerFacturas", new string[0], new string[0]);
        }
        public DataTable ElaborarFactura(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("procFacturar", Parametros, Datos[0]);
        }
        public DataTable ProductosFacturar(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("procProductosFacturar", Parametros, Datos[0]);
        }

        public DataTable BuscarFactura(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@NoFactura" };
            return getDatosTabla("procBuscarFactura", Parametros, Datos[0], -1);
        }
        public DataTable CrearFactura(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("procCrearFactura", Parametros, Datos[0]);
        }
        public DataTable BuscarPorPedido(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@NombreDent" };
            return getDatosTabla("procBuscarPorPedido", Parametros, Datos[0], Datos[1] + (Datos[0] == "" ? "%" : ""));
        }
        public DataTable BuscarPorFactura(string[] Datos)
        {
            string[] Parametros = { "@NoFactura", "@NoPedido" };
            return getDatosTabla("procBuscarPorFactura", Parametros, Datos[0], Datos[1]);
        }
        public int RegistrarDatosFactura(string[] Datos)
        {
            string[] Parametros = { "@NoPedido", "@FechaEmision", "@Nombre", "@Cedula", "@RFC", "@Direccion", "@Pais", "@Estado", "@Municipio", "@Ciudad", "@Colonia", "@CodPos", "@Telefono" };
            return Ejecutar("procRegistrarDatosFactura", Parametros, Datos[0], Datos[1], Datos[2], Datos[4], Datos[3], Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12]);
        }
        public int ModificarDatosFactura(string[] Datos)
        {
            string[] Parametros = { "@NoPedido", "@FechaEmision", "@Nombre", "@Cedula", "@RFC", "@Direccion", "@Pais", "@Estado", "@Municipio", "@Ciudad", "@Colonia", "@CodPos", "@Telefono" };
            return Ejecutar("procModificarDatosFactura", Parametros, Datos[0], Datos[1], Datos[2], Datos[3], Datos[4], Datos[5], Datos[6], Datos[7], Datos[8], Datos[9], Datos[10], Datos[11], Datos[12]);
        }
        public int RegistrarComentario(string[] Datos)
        {
            string[] Parametros = { "@IDPedido", "@Comentario" };
            return Ejecutar("procRegistrarComentario", Parametros, Datos[0], Datos[1]);
        }
        public DataTable MostrarDatosNota(string[] Datos)
        {
            string[] Parametros = { "@IDPedido" };
            return getDatosTabla("procMostrarDatosNota", Parametros, Datos[0]);
        }

        //Jesús

        public DataTable Departamento(string[] Datos)
        {
            string[] Parametros = { "@Loginn" };
            return getDatosTabla("procDepartamento", Parametros, Datos[0]);
        }
        public DataTable ObtenerDatosPiezas(string[] Datos)
        {
            string[] Parametros = { "@CodPieza" };
            return getDatosTabla("procPiezas", Parametros, "0");
        }

        public DataTable ObtenerDatosMateriales(string[] Datos)
        {
            string[] Parametros = { "@CodMaterial" };
            return getDatosTabla("procMateriales", Parametros, "0");
        }

        public DataTable EditarPieza(string[] Datos)
        {
            string[] Parametros = { "@CodPieza" };
            return getDatosTabla("procEditarPieza", Parametros, Datos[0]);
        }

        public DataTable EditarMaterial(string[] Datos)
        {
            string[] Parametros = { "@CodMaterial" };
            return getDatosTabla("procEditarMaterial", Parametros, Datos[0]);
        }
        public int AgregarDatosPieza(string[] Datos)
        {
            string[] Parametros = { "@CodPieza", "@NombrePieza", "@TiempoFab", "@Precio" };
            return Ejecutar("procAgregarPieza", Parametros, Datos[0], Datos[1], Datos[2], Datos[3]);
        }

        public int AgregarDatosMaterial(string[] Datos)
        {
            string[] Parametros = { "@Codigo", "@Nombre", "@Precio", "@Tiempo" };
            return Ejecutar("procAgregarMaterial", Parametros, Datos[0], Datos[1], Convert.ToInt32(Datos[2]), Datos[3]);
        }

        public int BorrarPieza(string[] Datos)
        {
            string[] Parametros = { "@CodPieza" };
            return Ejecutar("procEliminarPieza", Parametros, Datos[0]);
        }
        public int BorrarMaterial(string[] Datos)
        {
            string[] Parametros = { "@CodMaterial" };
            return Ejecutar("procEliminarMaterial", Parametros, Datos[0]);
        }

        public int CambiarEstado(string[] Datos)
        {
            string[] Parametros = { "@CodPedido", "@Estado" };
            return Ejecutar("procCambiarEstado", Parametros, Datos[0], Datos[1]);
        }
        public int Urgente(string[] Datos)
        {
            string[] Parametros = { "@Pedido", "@Urgente" };
            return Ejecutar("procPedidoUrgente", Parametros, Datos[0], Datos[1]);
        }

        public int ActualizarPieza(string[] Datos)
        {
            string[] Parametros = { "@CodPieza", "@NombrePieza", "@TiempoFab", "@Precio" };
            return Ejecutar("procActualizarPieza", Parametros, Datos[0], Datos[1], Datos[2], Datos[3]);
        }
        public int ActualizarMaterial(string[] Datos)
        {
            string[] Parametros = { "@CodMaterial", "@NombreMat", "@Precio", "@Tiempo" };
            return Ejecutar("procActualizarMaterial", Parametros, Datos[0], Datos[1], Convert.ToInt32(Datos[2]), Datos[3]);
        }
        public int CambiarLab(string[] Datos)
        {
            string[] Parametros = { "@CodPedido", "@Laboratorista" };
            return Ejecutar("procCambiarLab", Parametros, Datos[0], Datos[1]);
        }

        public DataTable ObtenerDatosPedido(string[] Datos)
        {
            string[] Parametros = { "@Pedido" };
            return getDatosTabla("getTodosProductosPedido", Parametros, "0");
        }

        public DataTable Laboratoristas(string[] Datos)
        {
            string[] Parametros = { "@Departamento" };
            return getDatosTabla("Laboratorista", Parametros, Datos[0]);
        }
        
        public DataTable ObtenerPedido(string[] Datos)
        {
            string [] Parametros = { "@Pedido"};
            return getDatosTabla("ObtenerPedido", Parametros, Datos[0]);
        }
        //

        //acabaaa
        //public void CrearBase()
        //{
        //    bool creado = false;
        //    INSTANCIA = 0;
        //    SqlCommand servidor;
        //    SqlConnection cnn;
        //    while (INSTANCIA < Instanciaas.Length)
        //    {
        //        //Codigo para hacer conexion con el servidor
        //        cnn = new SqlConnection("Server= " + Instanciaas[INSTANCIA] + "; database=master; integrated security=yes");
        //        //Codigo para base de datos DiamondDentures          
        //        string s = "CREATE DATABASE DiamondDentures collate SQL_Latin1_General_CP1_CS_AS";
        //        //Crear Base De Datos
        //        SqlCommand cmd = new SqlCommand(s, cnn);
        //        try
        //        {
        //            // Abrimos la conexión y ejecutamos el comando
        //            cnn.Open();
        //            cmd.ExecuteNonQuery();
        //            creado = false;
        //            break;
        //        }
        //        catch (Exception ms)
        //        {
        //            creado = true;
        //            if (ms.Message.ToString() == "La base de datos 'DiamondDentures' ya existe. Elija un nombre diferente para la base de datos.")
        //            {
        //                break;
        //            }
        //            else if (ms.Message.ToString() == "Database 'DiamondDentures' already exists. Choose a different database name.")
        //            {
        //                break;
        //            }
        //        }
        //        INSTANCIA++;
        //    }
        //    if (!creado)
        //    {
        //        //Conextar con la base de datos DiamondDentures
        //        string conexion = "Data Source = " + Instanciaas[INSTANCIA] + "; Initial Catalog = DiamondDentures; Integrated Security = True";
        //        SqlConnection cnn2 = new SqlConnection(conexion);
        //        try
        //        {
        //            #region Tablas y yisus
        //            SqlCommand tablaEmpleados;
        //            string codigoEmpleados = "create table Empleados(Nombre char(40),Direccion char(40),Colonia char(25),Ciudad char(40),Municipio char(40),Estado char(40),País char(40),CP char(10),TelCasa char(15),TelOfi char(15),TelCel char(15),Email char(50),Loginn char(40) primary key,Passwordd char(20),Apellidos char(40),Pregunta char(40),Respuesta char(40),Activo int, Departamento char(40))";
        //            string insertAdmin = "insert into	Empleados values ('Jesus', 'Gomez Farias 4780','Las Garzas 2','Culiacán Rosales','Culiacán','Sinaloa','México','23098','125-3434','123-4656','(612)-147-2414','jleontapia96@gmail.com','Admin','Admin123','Leon Tapia','Canción preferida','Heathens',0, 'Administrador')";
        //            SqlCommand tablaTarjetas;
        //            string codigoTarjetas = "create table Tarjetas(Nombre char(40),NumTar char(40) primary key,BancoTar char(20),FechaV char(20),Tipo char(20),Loginn char(40))";
        //            SqlCommand Paises;
        //            string codigoPaises = "Create table Pais(Clave_Pais numeric(5) not null,NombrePais varchar(50),Constraint PK_clavePais PRimary Key(Clave_Pais))";
        //            string insertPaises = "Insert into Pais(Clave_Pais, NombrePais) Values ('1','Afganistán'),('2','Albania'),('3','Alemania'),('4','Andorra'),('5','Angola'),('6','Anguila'),('7','Antártida'),('8','Antigua y Barbuda'),('9','Arabia Saudita'),('10','Argelia'),('11','Argentina'),('12','Armenia'),('13','Aruba'),('14','Australia'),('15','Austria'),('16','Azerbaiyán'),('17','Bahamas'),('18','Bangladés'),('19','Barbados'),('20','Baréin'),('21','Bélgica'),('22','Belice'),('23','Benín'),('24','Bermudas'),('25','Bielorrusia'),('26','Bolivia'),('27','Bonaire'),('28','Bosnia y Herzegovina'),('29','Botsuana'),('30','Brasil'),('31','Brunéi Darussalam'),('32','Bulgaria'),('33','Burkina Faso'),('34','Burundi'),('35','Bután'),('36','Cabo Verde'),('37','Camboya'),('38','Camerún'),('39','Canadá'),('40','Chad'),('41','Chile'),('42','China'),('43','Chipre'),('44','Colombia'),('45','Comoras'),('46','Congo'),('47','Congo'),('48','Corea'),('49','Costa de Marfil'),('50','Costa Rica'),('51','Croacia'),('52','Cuba'),('53','Curazao'),('54','Dinamarca'),('55','Dominica'),('56','Ecuador'),('57','Egipto'),('58','El Salvador'),('59','Emiratos Árabes Unidos'),('60','Eritrea'),('61','Eslovaquia'),('62','Eslovenia'),('63','España'),('64','Estados Unidos'),('65','Estonia'),('66','Etiopía'),('67','Federacion Rusa'),('68','Filipinas'),('69','Finlandia'),('70','Fiyi'),('71','Francia'),('72','Gabón'),('73','Gambia'),('74','Georgia'),('75','Ghana'),('76','Gibraltar'),('77','Granada'),('78','Grecia'),('79','Groenlandia'),('80','Guadalupe'),('81','Guam'),('82','Guatemala'),('83','Guayana Francesa'),('84','Guernsey'),('85','Guinea-Bisáu'),('86','Guinea Ecuatorial'),('87','Guinea'),('88','Guyana'),('89','Haití'),('90','Honduras'),('91','Hong Kong'),('92','Hungría'),('93','India'),('94','Indonesia'),('95','Irak'),('96','Irán'),('97','Irlanda'),('98','Isla Bouvet'),('99','Isla de Man'),('100','Isla de Navidad'),('101','Isla Norfolk'),('102','Islandia'),('103','Islas Åland'),('104','Islas Caimán'),('105','Islas Cocos (Keeling)'),('106','Islas Cook'),('107','Islas Falkland (Malvinas)'),('108','Islas Feroe'),('109','Islas Georgias del Sur y Sandwich del Sur'),('110','Islas Heard y Mcdonald'),('111','Islas Marianas del Norte'),('112','Islas Marshall'),('113','Islas Salomón'),('114','Islas Turcas y Caicos'),('115','Islas Ultramarinas Menores de Estados Unidos'),('116','Islas Virgenes Británicas'),('117','Islas Virgenes de Los Estados Unidos'),('118','Israel'),('119','Italia'),('120','Jamaica'),('121','Japón'),('122','Jersey'),('123','Jordania'),('124','Kazajistán'),('125','Kenia'),('126','Kirguistán'),('127','Kiribati'),('128','Kuwait'),('129','Lesoto'),('130','Letonia'),('131','Líbano'),('132','Liberia'),('133','Libia'),('134','Liechtenstein'),('135','Lituania'),('136','Luxemburgo'),('137','Macao'),('138','Macedonia'),('139','Madagascar'),('140','Malasia'),('141','Malaui'),('142','Maldivas'),('143','Malí'),('144','Malta'),('145','Marruecos'),('146','Martinica'),('147','Mauricio'),('148','Mauritania'),('149','Mayotte'),('150','México'),('151','Micronesia'),('152','Moldavia'),('153','Mónaco'),('154','Mongolia'),('155','Montenegro'),('156','Montserrat'),('157','Mozambique'),('158','Myanmar'),('159','Nabimia'),('160','Nauru'),('161','Nepal'),('162','Nicaragua'),('163','Nigeria'),('164','Níger'),('165','Niue'),('166','Noruega'),('167','Nueva Caledonia'),('168','Nueva Zelanda'),('169','Omán'),('170','Países Bajos'),('171','Pakistán'),('172','Palaos'),('173','Palestina'),('174','Panamá'),('175','Papúa Nueva Guinea'),('176','Paraguay'),('177','Perú'),('178','Pitcairn'),('179','Polinesia Francesa'),('180','Polonia'),('181','Portugal'),('182','Puerto Rico'),('183','Qatar'),('184','Reino Unido'),('185','República Centroafricana'),('186','República Checa'),('187','República Democrática Popular Lao'),('188','República Dominicana'),('189','Reunión'),('190','Ruanda'),('191','Rumania'),('192','Sahara Occidental'),('193','Samoa Americana'),('194','Samoa'),('195','San Bartolomé'),('196','San Cristóbal y Nieves'),('197','San Marino'),('198','San Martín (Parte Francesa)'),('199','San Pedro y Miquelón'),('200','San Vicente y Las Granadinas'),('201','Santa Helena, Ascensión y Tristán de Acuña'),('202','Santa Lucía'),('203','Santa Sede (Ciudad Estado Vaticano)'),('204','Santo Tomé y Principe'),('205','Senegal'),('206','Serbia'),('207','Seychelles'),('208','Sierra Leona'),('209','Singapur'),('210','Sint Maarten (Parte Neerlandesa)'),('211','Siria'),('212','Somalia'),('213','Sri Lanka'),('214','Suazilandia'),('215','Sudáfrica'),('216','Sudán del Sur'),('217','Sudán'),('218','Suecia'),('219','Suiza'),('220','Surinam'),('221','Svalbard y Jan Mayen'),('222','Tailandia'),('223','Taiwán'),('224','Tanzania'),('225','Tayikistán'),('226','Territorio Británico del Océano Índico'),('227','Territorios Australes Franceses'),('228','Timor-Leste'),('229','Togo'),('230','Tokelau'),('231','Tonga'),('232','Trinidad y Tobago'),('233','Túnez'),('234','Turkmenistán'),('235','Turquía'),('236','Tuvalu'),('237','Ucrania'),('238','Uganda'),('239','Uruguay'),('240','Uzbekistán'),('241','Vanuatu'),('242','Venezuela'),('243','Viet Nam'),('244','Wallis y Futuna'),('245','Yemen'),('246','Yibuti'),('247','Zambia'),('248','Zimbabue')";
        //            SqlCommand Estado;
        //            string codigoEstado = "Create Table Estado(Clave_Pais numeric(5) not null,Clave_Estado Numeric(2) not null,NombreEstado Varchar(40),Constraint PK_Clve_Estado PRimary Key(Clave_Estado),Constraint FK_Clave_Pais Foreign Key(Clave_Pais) References Pais(Clave_Pais))";
        //            string insertEstado = "Insert Into Estado(Clave_Estado,NombreEstado, Clave_Pais) Values ('1','Aguascalientes','150'), ('2','Baja California','150'), ('3','Baja California Sur','150'), ('4','Campeche','150'), ('5','Coahuila de Zaragoza','150'), ('6','Colima','150'), ('7','Chiapas','150'), ('8','Chihuahua','150'), ('9','Ciudad de México','150'), ('10','Durango','150'), ('11','Guanajuato','150'), ('12','Guerrero','150'), ('13','Hidalgo','150'), ('14','Jalisco','150'), ('15','México','150'), ('16','Michoacán de Ocampo','150'), ('17','Morelos','150'), ('18','Nayarit','150'), ('19','Nuevo León','150'), ('20','Oaxaca','150'), ('21','Puebla','150'), ('22','Querétaro','150'), ('23','Quintana Roo','150'), ('24','San Luis Potosí','150'), ('25','Sinaloa','150'), ('26','Sonora','150'), ('27','Tabasco','150'), ('28','Tamaulipas','150'), ('29','Tlaxcala','150'), ('30','Veracruz de Ignacio de la Llave','150'), ('31','Yucatán','150'), ('32','Zacatecas','150') ";
        //            SqlCommand Municipio;
        //            string codigoMunicipio = "Create Table Municipio(Clave_Estado Numeric(2) not null,Clave_Municipio Numeric(3) not null,NombreMunicipio varchar(50),Constraint PK_Clave_Municipio PRimary Key(Clave_Estado,Clave_Municipio),Constraint FK_Clave_Estado Foreign Key(Clave_Estado) References Estado(Clave_Estado))";
        //            string insertMunicipio = "Insert Into Municipio(Clave_Estado, Clave_Municipio, NombreMunicipio) values ('1','1','Aguascalientes'),('1','3','Calvillo'),('1','5','Jesús María'),('1','6','Pabellón de Arteaga'),('1','7','Rincón de Romos'),('1','10','El Llano'),('1','11','San Francisco de los Romo'),('2','1','Ensenada'),('2','2','Mexicali'),('2','3','Tecate'),('2','4','Tijuana'),('2','5','Playas de Rosarito'),('3','1','Comondú'),('3','2','Mulegé'),('3','3','La Paz'),('3','8','Los Cabos'),('3','9','Loreto'),('4','1','Calkiní'),('4','2','Campeche'),('4','3','Carmen'),('4','4','Champotón'),('4','5','Hecelchakán'),('4','6','Hopelchén'),('4','8','Tenabo'),('4','9','Escárcega'),('4','11','Candelaria'),('5','2','Acuña'),('5','3','Allende'),('5','4','Arteaga'),('5','6','Castaños'),('5','7','Cuatro Ciénegas'),('5','9','Francisco I. Madero'),('5','10','Frontera'),('5','17','Matamoros'),('5','18','Monclova'),('5','19','Morelos'),('5','20','Múzquiz'),('5','22','Nava'),('5','24','Parras'),('5','25','Piedras Negras'),('5','27','Ramos Arizpe'),('5','28','Sabinas'),('5','30','Saltillo'),('5','31','San Buenaventura'),('5','32','San Juan de Sabinas'),('5','33','San Pedro'),('5','35','Torreón'),('5','37','Villa Unión'), ('5','38','Zaragoza'), ('6','1','Armería'), ('6','2','Colima'), ('6','3','Comala'), ('6','4','Coquimatlán'), ('6','5','Cuauhtémoc'), ('6','7','Manzanillo'), ('6','9','Tecomán'), ('6','10','Villa de Álvarez'), ('7','1','Acacoyagua'), ('7','2','Acala'), ('7','3','Acapetahua'), ('7','4','Altamirano'), ('7','8','Angel Albino Corzo'), ('7','9','Arriaga'), ('7','12','Berriozábal'), ('7','13','Bochil'), ('7','14','El Bosque'), ('7','15','Cacahoatán'), ('7','17','Cintalapa'), ('7','19','Comitán de Domínguez'), ('7','20','La Concordia'), ('7','21','Copainalá'), ('7','24','Chanal'), ('7','27','Chiapa de Corzo'), ('7','30','Chicomuselo'), ('7','31','Chilón'), ('7','32','Escuintla'), ('7','34','Frontera Comalapa'), ('7','37','Huehuetán'), ('7','40','Huixtla'), ('7','41','La Independencia'), ('7','44','Ixtapa'), ('7','46','Jiquipilas'), ('7','48','Juárez'), ('7','51','Mapastepec'), ('7','52','Las Margaritas'), ('7','54','Mazatán'), ('7','57','Motozintla'), ('7','59','Ocosingo'), ('7','61','Ocozocoautla de Espinosa'), ('7','64','Oxchuc'), ('7','65','Palenque'), ('7','66','Pantelhó'), ('7','68','Pichucalco'), ('7','69','Pijijiapan'), ('7','71','Villa Comaltitlán'), ('7','72','Pueblo Nuevo Solistahuacán'), ('7','73','Rayón'), ('7','74','Reforma'), ('7','75','Las Rosas'), ('7','77','Salto de Agua'), ('7','78','San Cristóbal de las Casas'), ('7','79','San Fernando'), ('7','81','Simojovel'), ('7','86','Suchiapa'), ('7','87','Suchiate'), ('7','89','Tapachula'), ('7','91','Tapilula'), ('7','92','Tecpatán'), ('7','94','Teopisca'), ('7','96','Tila'), ('7','97','Tonalá'), ('7','99','La Trinitaria'), ('7','101','Tuxtla Gutiérrez'), ('7','102','Tuxtla Chico'), ('7','104','Tzimol'), ('7','106','Venustiano Carranza'), ('7','107','Villa Corzo'), ('7','108','Villaflores'), ('7','109','Yajalón'), ('7','112','San Juan Cancuc'), ('7','114','Benemérito de las Américas'), ('8','1','Ahumada'), ('8','2','Aldama'), ('8','4','Aquiles Serdán'), ('8','5','Ascensión'), ('8','9','Bocoyna'), ('8','10','Buenaventura'), ('8','11','Camargo'), ('8','13','Casas Grandes'), ('8','17','Cuauhtémoc'), ('8','19','Chihuahua'), ('8','21','Delicias'), ('8','25','Gómez Farías'), ('8','27','Guachochi'), ('8','29','Guadalupe y Calvo'), ('8','31','Guerrero'), ('8','32','Hidalgo del Parral'), ('8','36','Jiménez'), ('8','37','Juárez'), ('8','40','Madera'), ('8','45','Meoqui'), ('8','50','Nuevo Casas Grandes'), ('8','52','Ojinaga'), ('8','55','Rosales'), ('8','60','Santa Bárbara'), ('8','62','Saucillo'), ('9','2','Azcapotzalco'), ('9','3','Coyoacán'), ('9','4','Cuajimalpa de Morelos'), ('9','5','Gustavo A. Madero'), ('9','6','Iztacalco'), ('9','7','Iztapalapa'), ('9','8','La Magdalena Contreras'), ('9','9','Milpa Alta'), ('9','10','Álvaro Obregón'), ('9','11','Tláhuac'), ('9','12','Tlalpan'), ('9','13','Xochimilco'), ('9','14','Benito Juárez'), ('9','15','Cuauhtémoc'), ('9','16','Miguel Hidalgo'), ('9','17','Venustiano Carranza'), ('10','1','Canatlán'), ('10','4','Cuencamé'), ('10','5','Durango'), ('10','7','Gómez Palacio'), ('10','8','Guadalupe Victoria'), ('10','12','Lerdo'), ('10','13','Mapimí'), ('10','16','Nombre de Dios'), ('10','18','El Oro'), ('10','21','Peñón Blanco'), ('10','22','Poanas'), ('10','23','Pueblo Nuevo'), ('10','26','San Dimas'), ('10','32','Santiago Papasquiaro'), ('10','36','Tlahualilo'), ('10','38','Vicente Guerrero'), ('10','39','Nuevo Ideal'), ('11','1','Abasolo'), ('11','2','Acámbaro'), ('11','3','San Miguel de Allende'), ('11','4','Apaseo el Alto'), ('11','5','Apaseo el Grande'), ('11','7','Celaya'), ('11','8','Manuel Doblado'), ('11','9','Comonfort'), ('11','11','Cortazar'), ('11','12','Cuerámaro'), ('11','13','Doctor Mora'), ('11','14','Dolores Hidalgo Cuna de la Independencia Nacional'), ('11','15','Guanajuato'), ('11','16','Huanímaro'), ('11','17','Irapuato'), ('11','18','Jaral del Progreso'), ('11','19','Jerécuaro'), ('11','20','León'), ('11','21','Moroleón'), ('11','22','Ocampo'), ('11','23','Pénjamo'), ('11','25','Purísima del Rincón'), ('11','26','Romita'), ('11','27','Salamanca'), ('11','28','Salvatierra'), ('11','29','San Diego de la Unión'), ('11','30','San Felipe'), ('11','31','San Francisco del Rincón'), ('11','32','San José Iturbide'), ('11','33','San Luis de la Paz'), ('11','35','Santa Cruz de Juventino Rosas'), ('11','37','Silao de la Victoria'), ('11','38','Tarandacuao'), ('11','39','Tarimoro'), ('11','41','Uriangato'), ('11','42','Valle de Santiago'), ('11','44','Villagrán'), ('11','46','Yuriria'), ('12','1','Acapulco de Juárez'), ('12','3','Ajuchitlán del Progreso'), ('12','6','Apaxtla'), ('12','7','Arcelia'), ('12','11','Atoyac de Álvarez'), ('12','12','Ayutla de los Libres'), ('12','14','Benito Juárez'), ('12','15','Buenavista de Cuéllar'), ('12','18','Copala'), ('12','19','Copalillo'), ('12','21','Coyuca de Benítez'), ('12','22','Coyuca de Catalán'), ('12','23','Cuajinicuilapa'), ('12','28','Chilapa de Álvarez'), ('12','29','Chilpancingo de los Bravo'), ('12','30','Florencio Villarreal'), ('12','32','General Heliodoro Castillo'), ('12','33','Huamuxtitlán'), ('12','34','Huitzuco de los Figueroa'), ('12','35','Iguala de la Independencia'), ('12','38','Zihuatanejo de Azueta'), ('12','39','Juan R. Escudero'), ('12','40','Leonardo Bravo'), ('12','44','Mochitlán'), ('12','45','Olinalá'), ('12','46','Ometepec'), ('12','48','Petatlán'), ('12','49','Pilcaya'), ('12','50','Pungarabato'), ('12','51','Quechultenango'), ('12','52','San Luis Acatlán'), ('12','53','San Marcos'), ('12','55','Taxco de Alarcón'), ('12','57','Técpan de Galeana'), ('12','58','Teloloapan'), ('12','59','Tepecoacuilco de Trujano'), ('12','61','Tixtla de Guerrero'), ('12','66','Tlapa de Comonfort'), ('12','67','Tlapehuala'), ('12','74','Zitlala'), ('12','75','Eduardo Neri'), ('12','77','Marquelia'), ('13','3','Actopan'), ('13','5','Ajacuba'), ('13','8','Apan'), ('13','10','Atitalaquia'), ('13','12','Atotonilco el Grande'), ('13','13','Atotonilco de Tula'), ('13','16','Cuautepec de Hinojosa'), ('13','21','Emiliano Zapata'), ('13','23','Francisco I. Madero'), ('13','28','Huejutla de Reyes'), ('13','29','Huichapan'), ('13','30','Ixmiquilpan'), ('13','32','Jaltocán'), ('13','39','Mineral del Monte'), ('13','41','Mixquiahuala de Juárez'), ('13','46','San Felipe Orizatlán'), ('13','48','Pachuca de Soto'), ('13','50','Progreso de Obregón'), ('13','51','Mineral de la Reforma'), ('13','52','San Agustín Tlaxiaca'), ('13','56','Santiago Tulantepec de Lugo Guerrero'), ('13','59','Tecozautla'), ('13','61','Tepeapulco'), ('13','63','Tepeji del Río de Ocampo'), ('13','65','Tetepango'), ('13','66','Villa de Tezontepec'), ('13','67','Tezontepec de Aldama'), ('13','69','Tizayuca'), ('13','70','Tlahuelilpan'), ('13','72','Tlanalapa'), ('13','73','Tlanchinol'), ('13','74','Tlaxcoapan'), ('13','75','Tolcayuca'), ('13','76','Tula de Allende'), ('13','77','Tulancingo de Bravo'), ('13','81','Zacualtipán de Ángeles'), ('13','82','Zapotlán de Juárez'), ('13','83','Zempoala'), ('13','84','Zimapán'), ('14','1','Acatic'), ('14','2','Acatlán de Juárez'), ('14','3','Ahualulco de Mercado'), ('14','5','Amatitán'), ('14','6','Ameca'), ('14','7','San Juanito de Escobedo'), ('14','8','Arandas'), ('14','9','El Arenal'), ('14','10','Atemajac de Brizuela'), ('14','13','Atotonilco el Alto'), ('14','14','Atoyac'), ('14','15','Autlán de Navarro'), ('14','16','Ayotlán'), ('14','17','Ayutla'), ('14','18','La Barca'), ('14','21','Casimiro Castillo'), ('14','22','Cihuatlán'), ('14','23','Zapotlán el Grande'), ('14','24','Cocula'), ('14','25','Colotlán'), ('14','30','Chapala'), ('14','33','Degollado'), ('14','35','Encarnación de Díaz'), ('14','36','Etzatlán'), ('14','37','El Grullo'), ('14','39','Guadalajara'), ('14','43','La Huerta'), ('14','44','Ixtlahuacán de los Membrillos'), ('14','45','Ixtlahuacán del Río'), ('14','46','Jalostotitlán'), ('14','47','Jamay'), ('14','48','Jesús María'), ('14','50','Jocotepec'), ('14','51','Juanacatlán'), ('14','53','Lagos de Moreno'), ('14','55','Magdalena'), ('14','58','Mascota'), ('14','59','Mazamitla'), ('14','63','Ocotlán'), ('14','64','Ojuelos de Jalisco'), ('14','65','Pihuamo'), ('14','66','Poncitlán'), ('14','67','Puerto Vallarta'), ('14','68','Villa Purificación'), ('14','70','El Salto'), ('14','72','San Diego de Alejandría'), ('14','73','San Juan de los Lagos'), ('14','74','San Julián'), ('14','77','San Martín Hidalgo'), ('14','78','San Miguel el Alto'), ('14','79','Gómez Farías'), ('14','82','Sayula'), ('14','83','Tala'), ('14','84','Talpa de Allende'), ('14','85','Tamazula de Gordiano'), ('14','86','Tapalpa'), ('14','87','Tecalitlán'), ('14','88','Tecolotlán'), ('14','91','Teocaltiche'), ('14','93','Tepatitlán de Morelos'), ('14','94','Tequila'), ('14','96','Tizapán el Alto'), ('14','97','Tlajomulco de Zúñiga'), ('14','98','San Pedro Tlaquepaque'), ('14','100','Tomatlán'), ('14','101','Tonalá'), ('14','105','Tototlán'), ('14','108','Tuxpan'), ('14','109','Unión de San Antonio'), ('14','110','Unión de Tula'), ('14','114','Villa Corona'), ('14','116','Villa Hidalgo'), ('14','118','Yahualica de González Gallo'), ('14','119','Zacoalco de Torres'), ('14','120','Zapopan'), ('14','121','Zapotiltic'), ('14','124','Zapotlanejo'), ('14','125','San Ignacio Cerro Gordo'), ('15','2','Acolman'), ('15','5','Almoloya de Juárez'), ('15','6','Almoloya del Río'), ('15','9','Amecameca'), ('15','10','Apaxco'), ('15','11','Atenco'), ('15','12','Atizapán'), ('15','13','Atizapán de Zaragoza'), ('15','14','Atlacomulco'), ('15','15','Atlautla'), ('15','16','Axapusco'), ('15','18','Calimaya'), ('15','19','Capulhuac'), ('15','20','Coacalco de Berriozábal'), ('15','21','Coatepec Harinas'), ('15','22','Cocotitlán'), ('15','23','Coyotepec'), ('15','24','Cuautitlán'), ('15','25','Chalco'), ('15','27','Chapultepec'), ('15','28','Chiautla'), ('15','29','Chicoloapan'), ('15','30','Chiconcuac'), ('15','31','Chimalhuacán'), ('15','33','Ecatepec de Morelos'), ('15','34','Ecatzingo'), ('15','35','Huehuetoca'), ('15','36','Hueypoxtla'), ('15','37','Huixquilucan'), ('15','39','Ixtapaluca'), ('15','40','Ixtapan de la Sal'), ('15','42','Ixtlahuaca'), ('15','43','Xalatlaco'), ('15','44','Jaltenco'), ('15','45','Jilotepec'), ('15','47','Jiquipilco'), ('15','48','Jocotitlán'), ('15','50','Juchitepec'), ('15','51','Lerma'), ('15','52','Malinalco'), ('15','53','Melchor Ocampo'), ('15','54','Metepec'), ('15','55','Mexicaltzingo'), ('15','57','Naucalpan de Juárez'), ('15','58','Nezahualcóyotl'), ('15','59','Nextlalpan'), ('15','60','Nicolás Romero'), ('15','62','Ocoyoacac'), ('15','64','El Oro'), ('15','65','Otumba'), ('15','67','Otzolotepec'), ('15','68','Ozumba'), ('15','70','La Paz'), ('15','72','Rayón'), ('15','73','San Antonio la Isla'), ('15','74','San Felipe del Progreso'), ('15','75','San Martín de las Pirámides'), ('15','76','San Mateo Atenco'), ('15','81','Tecámac'), ('15','82','Tejupilco'), ('15','83','Temamatla'), ('15','84','Temascalapa'), ('15','85','Temascalcingo'), ('15','87','Temoaya'), ('15','88','Tenancingo'), ('15','89','Tenango del Aire'), ('15','90','Tenango del Valle'), ('15','91','Teoloyucan'), ('15','92','Teotihuacán'), ('15','93','Tepetlaoxtoc'), ('15','94','Tepetlixpa'), ('15','95','Tepotzotlán'), ('15','96','Tequixquiac'), ('15','99','Texcoco'), ('15','100','Tezoyuca'), ('15','101','Tianguistenco'), ('15','103','Tlalmanalco'), ('15','104','Tlalnepantla de Baz'), ('15','106','Toluca'), ('15','107','Tonatico'), ('15','108','Tultepec'), ('15','109','Tultitlán'), ('15','110','Valle de Bravo'), ('15','112','Villa del Carbón'), ('15','113','Villa Guerrero'), ('15','115','Xonacatlán'), ('15','118','Zinacantepec'), ('15','120','Zumpango'), ('15','121','Cuautitlán Izcalli'), ('15','122','Valle de Chalco Solidaridad'), ('15','123','Luvianos'), ('15','125','Tonanitla'), ('16','1','Acuitzio'), ('16','2','Aguililla'), ('16','3','Álvaro Obregón'), ('16','4','Angamacutiro'), ('16','6','Apatzingán'), ('16','9','Ario'), ('16','10','Arteaga'), ('16','12','Buenavista'), ('16','14','Coahuayana'), ('16','15','Coalcomán de Vázquez Pallares'), ('16','19','Cotija'), ('16','20','Cuitzeo'), ('16','22','Charo'), ('16','23','Chavinda'), ('16','24','Cherán'), ('16','25','Chilchota'), ('16','33','Gabriel Zamora'), ('16','34','Hidalgo'), ('16','35','La Huacana'), ('16','36','Huandacareo'), ('16','38','Huetamo'), ('16','40','Indaparapeo'), ('16','43','Jacona'), ('16','45','Jiquilpan'), ('16','47','Jungapeo'), ('16','49','Madero'), ('16','50','Maravatío'), ('16','51','Marcos Castellanos'), ('16','52','Lázaro Cárdenas'), ('16','53','Morelia'), ('16','55','Múgica'), ('16','56','Nahuatzen'), ('16','58','Nuevo Parangaricutiro'), ('16','62','Pajacuarán'), ('16','63','Panindícuaro'), ('16','64','Parácuaro'), ('16','65','Paracho'), ('16','66','Pátzcuaro'), ('16','68','Peribán'), ('16','69','La Piedad'), ('16','70','Purépero'), ('16','71','Puruándiro'), ('16','72','Queréndaro'), ('16','73','Quiroga'), ('16','74','Cojumatlán de Régules'), ('16','75','Los Reyes'), ('16','76','Sahuayo'), ('16','78','Santa Ana Maya'), ('16','79','Salvador Escalante'), ('16','82','Tacámbaro'), ('16','83','Tancítaro'), ('16','84','Tangamandapio'), ('16','85','Tangancícuaro'), ('16','86','Tanhuato'), ('16','87','Taretan'), ('16','88','Tarímbaro'), ('16','89','Tepalcatepec'), ('16','90','Tingambato'), ('16','91','Tingüindín'), ('16','95','Tocumbo'), ('16','97','Turicato'), ('16','98','Tuxpan'), ('16','102','Uruapan'), ('16','103','Venustiano Carranza'), ('16','105','Vista Hermosa'), ('16','106','Yurécuaro'), ('16','107','Zacapu'), ('16','108','Zamora'), ('16','110','Zinapécuaro'), ('16','112','Zitácuaro'), ('16','113','José Sixto Verduzco'), ('17','1','Amacuzac'), ('17','2','Atlatlahucan'), ('17','3','Axochiapan'), ('17','4','Ayala'), ('17','6','Cuautla'), ('17','7','Cuernavaca'), ('17','8','Emiliano Zapata'), ('17','9','Huitzilac'), ('17','10','Jantetelco'), ('17','11','Jiutepec'), ('17','12','Jojutla'), ('17','13','Jonacatepec de Leandro Valle'), ('17','15','Miacatlán'), ('17','17','Puente de Ixtla'), ('17','18','Temixco'), ('17','19','Tepalcingo'), ('17','20','Tepoztlán'), ('17','22','Tetela del Volcán'), ('17','24','Tlaltizapán de Zapata'), ('17','25','Tlaquiltenango'), ('17','26','Tlayacapan'), ('17','27','Totolapan'), ('17','28','Xochitepec'), ('17','29','Yautepec'), ('17','30','Yecapixtla'), ('17','31','Zacatepec'), ('17','32','Zacualpan de Amilpas'), ('17','33','Temoac'), ('18','1','Acaponeta'), ('18','2','Ahuacatlán'), ('18','4','Compostela'), ('18','6','Ixtlán del Río'), ('18','7','Jala'), ('18','8','Xalisco'), ('18','11','Ruíz'), ('18','12','San Blas'), ('18','15','Santiago Ixcuintla'), ('18','16','Tecuala'), ('18','17','Tepic'), ('18','18','Tuxpan'), ('18','20','Bahía de Banderas'), ('19','4','Allende'), ('19','5','Anáhuac'), ('19','6','Apodaca'), ('19','9','Cadereyta Jiménez'), ('19','10','El Carmen'), ('19','11','Cerralvo'), ('19','12','Ciénega de Flores'), ('19','13','China'), ('19','14','Doctor Arroyo'), ('19','17','Galeana'), ('19','18','García'), ('19','19','San Pedro Garza García'), ('19','21','General Escobedo'), ('19','22','General Terán'), ('19','25','General Zuazua'), ('19','26','Guadalupe'), ('19','29','Hualahuises'), ('19','31','Juárez'), ('19','32','Lampazos de Naranjo'), ('19','33','Linares'), ('19','38','Montemorelos'), ('19','39','Monterrey'), ('19','41','Pesquería'), ('19','44','Sabinas Hidalgo'), ('19','45','Salinas Victoria'), ('19','46','San Nicolás de los Garza'), ('19','47','Hidalgo'), ('19','48','Santa Catarina'), ('19','49','Santiago'), ('20','2','Acatlán de Pérez Figueroa'), ('20','5','Asunción Ixtaltepec'), ('20','6','Asunción Nochixtlán'), ('20','14','Ciudad Ixtepec'), ('20','21','Cosolapa'), ('20','23','Cuilápam de Guerrero'), ('20','25','Chahuites'), ('20','28','Heroica Ciudad de Ejutla de Crespo'), ('20','30','El Espinal'), ('20','39','Heroica Ciudad de Huajuapan de León'), ('20','41','Huautla de Jiménez'), ('20','43','Heroica Ciudad de Juchitán de Zaragoza'), ('20','44','Loma Bonita'), ('20','57','Matías Romero Avendaño'), ('20','59','Miahuatlán de Porfirio Díaz'), ('20','67','Oaxaca de Juárez'), ('20','68','Ocotlán de Morelos'), ('20','70','Pinotepa de Don Luis'), ('20','73','Putla Villa de Guerrero'), ('20','79','Salina Cruz'), ('20','83','San Agustín de las Juntas'), ('20','103','San Antonino Castillo Velasco'), ('20','107','San Antonio de la Cal'), ('20','124','San Blas Atempa'), ('20','131','San Dionisio Ocotepec'), ('20','134','San Felipe Jalapa de Díaz'), ('20','143','San Francisco Ixhuatán'), ('20','150','San Francisco Telixtlahuaca'), ('20','157','San Jacinto Amilpas'), ('20','184','San Juan Bautista Tuxtepec'), ('20','188','San Juan Colorado'), ('20','227','San Lorenzo Cacaotepec'), ('20','232','San Lucas Ojitlán'), ('20','248','San Mateo del Mar'), ('20','272','San Miguel Panixtlahuaca'), ('20','278','San Miguel Soyaltepec'), ('20','293','San Pablo Etla'), ('20','294','San Pablo Huitzo'), ('20','295','San Pablo Huixtepec'), ('20','298','San Pablo Villa de Mitla'), ('20','318','San Pedro Mixtepec'), ('20','324','San Pedro Pochutla'), ('20','327','San Pedro Tapanatepec'), ('20','334','Villa de Tututepec'), ('20','338','Villa de Etla'), ('20','350','San Sebastián Tutla'), ('20','364','Santa Catarina Juquila'), ('20','375','Santa Cruz Amilpas'), ('20','385','Santa Cruz Xoxocotlán'), ('20','390','Santa Lucía del Camino'), ('20','397','Heroica Ciudad de Tlaxiaco'), ('20','399','Santa María Atzompa'), ('20','401','Santa María Colotepec'), ('20','409','Santa María del Tule'), ('20','413','Santa María Huatulco'), ('20','418','Santa María Jalapa del Marqués'), ('20','441','Santa María Xadani'), ('20','467','Santiago Jamiltepec'), ('20','469','Santiago Juxtlahuaca'), ('20','482','Santiago Pinotepa Nacional'), ('20','483','Santiago Suchilquitongo'), ('20','505','Santo Domingo Ingenio'), ('20','513','Santo Domingo Petapa'), ('20','515','Santo Domingo Tehuantepec'), ('20','525','Santo Domingo Zanatepec'), ('20','526','Santos Reyes Nopala'), ('20','540','Villa de Tamazulápam del Progreso'), ('20','545','Teotitlán de Flores Magón'), ('20','551','Tlacolula de Matamoros'), ('20','553','Tlalixtac de Cabrera'), ('20','557','Unión Hidalgo'), ('20','559','San Juan Bautista Valle Nacional'), ('20','565','Villa de Zaachila'), ('20','570','Zimatlán de Álvarez'), ('21','1','Acajete'), ('21','3','Acatlán'), ('21','4','Acatzingo'), ('21','10','Ajalpan'), ('21','13','Altepexi'), ('21','15','Amozoc'), ('21','17','Atempan'), ('21','19','Atlixco'), ('21','20','Atoyatempan'), ('21','26','Calpan'), ('21','34','Coronango'), ('21','35','Coxcatlán'), ('21','38','Cuapiaxtla de Madero'), ('21','41','Cuautlancingo'), ('21','43','Cuetzalan del Progreso'), ('21','45','Chalchicomula de Sesma'), ('21','46','Chapulco'), ('21','47','Chiautla'), ('21','48','Chiautzingo'), ('21','51','Chietla'), ('21','53','Chignahuapan'), ('21','54','Chignautla'), ('21','60','Domingo Arenas'), ('21','63','Esperanza'), ('21','65','General Felipe Ángeles'), ('21','67','Guadalupe Victoria'), ('21','71','Huauchinango'), ('21','74','Huejotzingo'), ('21','75','Hueyapan'), ('21','76','Hueytamalco'), ('21','85','Izúcar de Matamoros'), ('21','87','Jolalpan'), ('21','90','Juan C. Bonilla'), ('21','91','Juan Galindo'), ('21','94','Libres'), ('21','102','Nealtican'), ('21','104','Nopalucan'), ('21','106','Ocoyucan'), ('21','108','Oriental'), ('21','110','Palmar de Bravo'), ('21','114','Puebla'), ('21','115','Quecholac'), ('21','117','Rafael Lara Grajales'), ('21','118','Los Reyes de Juárez'), ('21','119','San Andrés Cholula'), ('21','122','San Felipe Teotlalcingo'), ('21','124','San Gabriel Chilac'), ('21','129','San José Miahuatlán'), ('21','132','San Martín Texmelucan'), ('21','134','San Matías Tlalancaleca'), ('21','136','San Miguel Xoxtla'), ('21','138','San Nicolás de los Ranchos'), ('21','140','San Pedro Cholula'), ('21','142','San Salvador el Seco'), ('21','143','San Salvador el Verde'), ('21','144','San Salvador Huixcolotla'), ('21','149','Santiago Miahuatlán'), ('21','151','Santo Tomás Hueyotlipan'), ('21','152','Soltepec'), ('21','153','Tecali de Herrera'), ('21','154','Tecamachalco'), ('21','156','Tehuacán'), ('21','157','Tehuitzingo'), ('21','161','Tepanco de López'), ('21','163','Tepatlaxco de Hidalgo'), ('21','164','Tepeaca'), ('21','174','Teziutlán'), ('21','175','Tianguismanalco'), ('21','177','Tlacotepec de Benito Juárez'), ('21','179','Tlachichuca'), ('21','180','Tlahuapan'), ('21','181','Tlaltenango'), ('21','186','Tlatlauquitepec'), ('21','189','Tochtepec'), ('21','191','Tulcingo'), ('21','194','Venustiano Carranza'), ('21','197','Xicotepec'), ('21','199','Xiutetelco'), ('21','203','Xochitlán Todos Santos'), ('21','205','Yehualtepec'), ('21','207','Zacapoaxtla'), ('21','208','Zacatlán'), ('21','211','Zaragoza'), ('21','214','Zinacatepec'), ('22','1','Amealco de Bonfil'), ('22','4','Cadereyta de Montes'), ('22','5','Colón'), ('22','6','Corregidora'), ('22','7','Ezequiel Montes'), ('22','9','Jalpan de Serra'), ('22','11','El Marqués'), ('22','12','Pedro Escobedo'), ('22','14','Querétaro'), ('22','16','San Juan del Río'), ('22','17','Tequisquiapan'), ('23','1','Cozumel'), ('23','2','Felipe Carrillo Puerto'), ('23','3','Isla Mujeres'), ('23','4','Othón P. Blanco'), ('23','5','Benito Juárez'), ('23','6','José María Morelos'), ('23','7','Lázaro Cárdenas'), ('23','8','Solidaridad'), ('23','9','Tulum'), ('23','10','Bacalar'), ('23','11','Puerto Morelos'), ('24','5','Cárdenas'), ('24','7','Cedral'), ('24','8','Cerritos'), ('24','10','Ciudad del Maíz'), ('24','11','Ciudad Fernández'), ('24','13','Ciudad Valles'), ('24','15','Charcas'), ('24','16','Ebano'), ('24','20','Matehuala'), ('24','23','Rayón'), ('24','24','Rioverde'), ('24','25','Salinas'), ('24','27','San Ciro de Acosta'), ('24','28','San Luis Potosí'), ('24','32','Santa María del Río'), ('24','34','San Vicente Tancuayalab'), ('24','35','Soledad de Graciano Sánchez'), ('24','37','Tamazunchale'), ('24','40','Tamuín'), ('24','42','Tanquián de Escobedo'), ('24','43','Tierra Nueva'), ('24','45','Venado'), ('24','46','Villa de Arriaga'), ('24','49','Villa de Ramos'), ('24','50','Villa de Reyes'), ('24','53','Axtla de Terrazas'), ('24','54','Xilitla'), ('24','55','Zaragoza'), ('24','56','Villa de Arista'), ('24','58','El Naranjo'), ('25','1','Ahome'), ('25','2','Angostura'), ('25','4','Concordia'), ('25','5','Cosalá'), ('25','6','Culiacán'), ('25','7','Choix'), ('25','8','Elota'), ('25','9','Escuinapa'), ('25','10','El Fuerte'), ('25','11','Guasave'), ('25','12','Mazatlán'), ('25','13','Mocorito'), ('25','14','Rosario'), ('25','15','Salvador Alvarado'), ('25','17','Sinaloa'), ('25','18','Navolato'), ('26','2','Agua Prieta'), ('26','3','Alamos'), ('26','4','Altar'), ('26','12','Bácum'), ('26','16','Benjamín Hill'), ('26','17','Caborca'), ('26','18','Cajeme'), ('26','19','Cananea'), ('26','25','Empalme'), ('26','26','Etchojoa'), ('26','27','Fronteras'), ('26','29','Guaymas'), ('26','30','Hermosillo'), ('26','33','Huatabampo'), ('26','35','Imuris'), ('26','36','Magdalena'), ('26','39','Naco'), ('26','41','Nacozari de García'), ('26','42','Navojoa'), ('26','43','Nogales'), ('26','47','Pitiquito'), ('26','48','Puerto Peñasco'), ('26','55','San Luis Río Colorado'), ('26','56','San Miguel de Horcasitas'), ('26','58','Santa Ana'), ('26','70','General Plutarco Elías Calles'), ('26','71','Benito Juárez'), ('26','72','San Ignacio Río Muerto'), ('27','1','Balancán'), ('27','2','Cárdenas'), ('27','3','Centla'), ('27','4','Centro'), ('27','5','Comalcalco'), ('27','6','Cunduacán'), ('27','7','Emiliano Zapata'), ('27','8','Huimanguillo'), ('27','10','Jalpa de Méndez'), ('27','11','Jonuta'), ('27','12','Macuspana'), ('27','13','Nacajuca'), ('27','14','Paraíso'), ('27','15','Tacotalpa'), ('27','16','Teapa'), ('27','17','Tenosique'), ('28','1','Abasolo'), ('28','2','Aldama'), ('28','3','Altamira'), ('28','7','Camargo'), ('28','9','Ciudad Madero'), ('28','12','González'), ('28','15','Gustavo Díaz Ordaz'), ('28','16','Hidalgo'), ('28','17','Jaumave'), ('28','18','Jiménez'), ('28','21','El Mante'), ('28','22','Matamoros'), ('28','25','Miguel Alemán'), ('28','27','Nuevo Laredo'), ('28','29','Ocampo'), ('28','30','Padilla'), ('28','32','Reynosa'), ('28','33','Río Bravo'), ('28','35','San Fernando'), ('28','37','Soto la Marina'), ('28','38','Tampico'), ('28','39','Tula'), ('28','40','Valle Hermoso'), ('28','41','Victoria'), ('28','43','Xicoténcatl'), ('29','1','Amaxac de Guerrero'), ('29','5','Apizaco')";
        //            string insertMunicipio2 = "Insert Into Municipio(Clave_Estado, Clave_Municipio, NombreMunicipio) values  ('29','6','Calpulalpan'), ('29','7','El Carmen Tequexquitla'), ('29','8','Cuapiaxtla'), ('29','10','Chiautempan'), ('29','13','Huamantla'), ('29','15','Ixtacuixtla de Mariano Matamoros'), ('29','16','Ixtenco'), ('29','17','Mazatecochco de José María Morelos'), ('29','18','Contla de Juan Cuamatzi'), ('29','19','Tepetitla de Lardizábal'), ('29','21','Nanacamilpa de Mariano Arista'), ('29','24','Panotla'), ('29','25','San Pablo del Monte'), ('29','26','Santa Cruz Tlaxcala'), ('29','27','Tenancingo'), ('29','28','Teolocholco'), ('29','31','Tetla de la Solidaridad'), ('29','33','Tlaxcala'), ('29','34','Tlaxco'), ('29','35','Tocatlán'), ('29','36','Totolac'), ('29','37','Ziltlaltépec de Trinidad Sánchez Santos'), ('29','38','Tzompantepec'), ('29','39','Xaloztoc'), ('29','41','Papalotla de Xicohténcatl'), ('29','42','Xicohtzinco'), ('29','43','Yauhquemehcan'), ('29','44','Zacatelco'), ('29','45','Benito Juárez'), ('29','48','La Magdalena Tlaltelulco'), ('29','49','San Damián Texóloc'), ('29','50','San Francisco Tetlanohcan'), ('29','52','San José Teacalco'), ('29','53','San Juan Huactzinco'), ('29','54','San Lorenzo Axocomanitla'), ('29','56','Santa Ana Nopalucan'), ('29','58','Santa Catarina Ayometla'), ('30','3','Acayucan'), ('30','6','Acultzingo'), ('30','10','Altotonga'), ('30','11','Alvarado'), ('30','13','Naranjos Amatlán'), ('30','14','Amatlán de los Reyes'), ('30','15','Angel R. Cabada'), ('30','16','La Antigua'), ('30','21','Atoyac'), ('30','22','Atzacan'), ('30','26','Banderilla'), ('30','28','Boca del Río'), ('30','30','Camerino Z. Mendoza'), ('30','32','Catemaco'), ('30','34','Cerro Azul'), ('30','35','Citlaltépetl'), ('30','36','Coacoatzintla'), ('30','38','Coatepec'), ('30','39','Coatzacoalcos'), ('30','40','Coatzintla'), ('30','44','Córdoba'), ('30','45','Cosamaloapan de Carpio'), ('30','47','Coscomatepec'), ('30','48','Cosoleacaque'), ('30','51','Coyutla'), ('30','53','Cuitláhuac'), ('30','59','Chinameca'), ('30','60','Chinampa de Gorostiza'), ('30','61','Las Choapas'), ('30','62','Chocamán'), ('30','65','Emiliano Zapata'), ('30','67','Filomeno Mata'), ('30','68','Fortín'), ('30','69','Gutiérrez Zamora'), ('30','71','Huatusco'), ('30','72','Huayacocotla'), ('30','73','Hueyapan de Ocampo'), ('30','77','Isla'), ('30','80','Ixhuatlán del Café'), ('30','81','Ixhuatlancillo'), ('30','82','Ixhuatlán del Sureste'), ('30','85','Ixtaczoquitlán'), ('30','86','Jalacingo'), ('30','87','Xalapa'), ('30','89','Jáltipan'), ('30','92','Xico'), ('30','94','Juan Rodríguez Clara'), ('30','97','Lerdo de Tejada'), ('30','99','Maltrata'), ('30','100','Manlio Fabio Altamirano'), ('30','101','Mariano Escobedo'), ('30','102','Martínez de la Torre'), ('30','103','Mecatlán'), ('30','104','Mecayapan'), ('30','105','Medellín de Bravo'), ('30','108','Minatitlán'), ('30','109','Misantla'), ('30','111','Moloacán'), ('30','112','Naolinco'), ('30','115','Nogales'), ('30','116','Oluta'), ('30','118','Orizaba'), ('30','120','Oteapan'), ('30','122','Pajapan'), ('30','123','Pánuco'), ('30','124','Papantla'), ('30','125','Paso del Macho'), ('30','126','Paso de Ovejas'), ('30','128','Perote'), ('30','129','Platón Sánchez'), ('30','130','Playa Vicente'), ('30','131','Poza Rica de Hidalgo'), ('30','132','Las Vigas de Ramírez'), ('30','133','Pueblo Viejo'), ('30','134','Puente Nacional'), ('30','135','Rafael Delgado'), ('30','138','Río Blanco'), ('30','141','San Andrés Tuxtla'), ('30','143','Santiago Tuxtla'), ('30','144','Sayula de Alemán'), ('30','145','Soconusco'), ('30','148','Soledad de Doblado'), ('30','149','Soteapan'), ('30','150','Tamalín'), ('30','151','Tamiahua'), ('30','155','Tantoyuca'), ('30','160','Álamo Temapache'), ('30','161','Tempoal'), ('30','164','Teocelo'), ('30','167','Tepetzintla'), ('30','169','José Azueta'), ('30','172','Texistepec'), ('30','173','Tezonapa'), ('30','174','Tierra Blanca'), ('30','175','Tihuatlán'), ('30','178','Tlacotalpan'), ('30','181','Tlalixcoyan'), ('30','182','Tlalnelhuayocan'), ('30','183','Tlapacoyan'), ('30','189','Tuxpan'), ('30','191','Ursulo Galván'), ('30','192','Vega de Alatorre'), ('30','193','Veracruz'), ('30','196','Yanga'), ('30','199','Zaragoza'), ('30','201','Zongolica'), ('30','204','Agua Dulce'), ('30','205','El Higo'), ('30','206','Nanchital de Lázaro Cárdenas del Río'), ('30','207','Tres Valles'), ('30','208','Carlos A. Carrillo'), ('30','209','Tatahuicapan de Juárez'), ('30','211','San Rafael'), ('31','2','Acanceh'), ('31','3','Akil'), ('31','6','Buctzotz'), ('31','7','Cacalchén'), ('31','11','Celestún'), ('31','13','Conkal'), ('31','19','Chemax'), ('31','21','Chichimilá'), ('31','27','Dzidzantún'), ('31','29','Dzilam González'), ('31','32','Espita'), ('31','33','Halachó'), ('31','36','Homún'), ('31','38','Hunucmá'), ('31','40','Izamal'), ('31','41','Kanasín'), ('31','44','Kinchil'), ('31','48','Maxcanú'), ('31','50','Mérida'), ('31','52','Motul'), ('31','53','Muna'), ('31','56','Oxkutzcab'), ('31','57','Panabá'), ('31','58','Peto'), ('31','59','Progreso'), ('31','67','Seyé'), ('31','69','Sotuta'), ('31','75','Teabo'), ('31','76','Tecoh'), ('31','79','Tekax'), ('31','80','Tekit'), ('31','84','Temax'), ('31','85','Temozón'), ('31','89','Ticul'), ('31','91','Tinum'), ('31','93','Tixkokob'), ('31','96','Tizimín'), ('31','98','Tzucacab'), ('31','101','Umán'), ('31','102','Valladolid'), ('32','5','Calera'), ('32','6','Cañitas de Felipe Pescador'), ('32','7','Concepción del Oro'), ('32','8','Cuauhtémoc'), ('32','10','Fresnillo'), ('32','14','General Francisco R. Murguía'), ('32','17','Guadalupe'), ('32','19','Jalpa'), ('32','20','Jerez'), ('32','22','Juan Aldama'), ('32','23','Juchipila'), ('32','24','Loreto'), ('32','25','Luis Moya'), ('32','29','Miguel Auza'), ('32','32','Morelos'), ('32','34','Nochistlán de Mejía'), ('32','36','Ojocaliente'), ('32','37','Pánuco'), ('32','38','Pinos'), ('32','39','Río Grande'), ('32','40','Sain Alto'), ('32','42','Sombrerete'), ('32','44','Tabasco'), ('32','48','Tlaltenango de Sánchez Román'), ('32','49','Valparaíso'), ('32','51','Villa de Cos'), ('32','52','Villa García'), ('32','53','Villa González Ortega'), ('32','55','Villanueva'), ('32','56','Zacatecas'), ('32','57','Trancoso')";
        //            SqlCommand Ciudad;
        //            string codigoCiudad = "Create Table Ciudad(Clave_Estado Numeric(2) not null,Clave_Municipio Numeric(3) not null,Clave_Ciudad Numeric(5) Not null,NombreCiudad varchar(60),Constraint PK_Clave_Ciudad PRimary Key(Clave_Ciudad,Clave_Municipio, Clave_Estado),Constraint FK_Clave_Municipio Foreign Key(Clave_Estado, Clave_Municipio) References Municipio(Clave_Estado, Clave_Municipio))";
        //            string insertCiudad = "Insert Into Ciudad(Clave_Estado, Clave_Municipio, Clave_Ciudad, NombreCiudad) values  ('1','1','1','Aguascalientes'), ('1','1','1025','Pocitos'), ('1','3','1','Calvillo'), ('1','3','55','Ojocaliente'), ('1','5','1','Jesús María'), ('1','5','41','Jesús Gómez Portugal (Margaritas)'), ('1','6','1','Pabellón de Arteaga'), ('1','7','1','Rincón de Romos'), ('1','10','1','Palo Alto'), ('1','11','1','San Francisco de los Romo'), ('2','1','1','Ensenada'), ('2','1','60','Camalú'), ('2','1','133','Lázaro Cárdenas'), ('2','1','139','Rodolfo Sánchez Taboada (Maneadero)'), ('2','1','247','El Sauzal de Rodríguez'), ('2','1','268','Vicente Guerrero'), ('2','1','1107','Emiliano Zapata'), ('2','1','2183','Rancho Cañón Buena Vista (El Zorrillo)'), ('2','2','1','Mexicali'), ('2','2','110','Colonia Venustiano Carranza (La Carranza)'), ('2','2','111','Vicente Guerrero (Algodones)'), ('2','2','159','Delta (Estación Delta)'), ('2','2','185','Ciudad Guadalupe Victoria (Kilómetro Cuarenta y Tres)'), ('2','2','192','Ejido Hermosillo'), ('2','2','231','Ciudad Morelos (Cuervos)'), ('2','2','260','Progreso'), ('2','2','262','Puebla'), ('2','2','284','San Felipe'), ('2','2','289','Santa Isabel'), ('2','2','461','Ciudad Coahuila (Kilómetro Cincuenta y Siete)'), ('2','3','1','Tecate'), ('2','3','1573','Lomas de Santa Anita'), ('2','4','1','Tijuana'), ('2','4','187','La Joya'), ('2','4','283','San Luis'), ('2','4','381','Las Delicias'), ('2','4','723','Maclovio Rojas'), ('2','4','1053','Terrazas del Valle'), ('2','4','1599','Pórticos de San Antonio'), ('2','4','1615','El Niño'), ('2','4','1624','El Refugio'), ('2','4','1781','Villa del Prado Segunda Sección'), ('2','4','1856','Quinta del Cedro'), ('2','4','1883','Villa del Campo'), ('2','4','1903','Villa del Prado'), ('2','5','1','Playas de Rosarito'), ('2','5','88','Ampliación Ejido Plan Libertador'), ('3','1','1','Ciudad Constitución'), ('3','1','133','Ciudad Insurgentes'), ('3','1','280','Puerto San Carlos'), ('3','2','1','Santa Rosalía'), ('3','2','66','Guerrero Negro'), ('3','2','482','Villa Alberto Andrés Alvarado Arámburo'), ('3','3','1','La Paz'), ('3','3','3','Todos Santos'), ('3','8','1','San José del Cabo'), ('3','8','54','Cabo San Lucas'), ('3','8','247','San José Viejo'), ('3','8','304','Las Veredas'), ('3','8','753','Colonia del Sol'), ('3','8','952','Las Palmas'), ('3','9','1','Loreto'), ('4','1','1','Calkiní'), ('4','1','4','Bécal'), ('4','1','7','Dzitbalché'), ('4','1','8','Nunkiní'), ('4','2','1','San Francisco de Campeche'), ('4','2','77','Chiná'), ('4','2','87','Lerma'), ('4','3','1','Ciudad del Carmen'), ('4','3','199','Isla Aguada'), ('4','3','614','Sabancuy'), ('4','4','1','Champotón'), ('4','4','35','Seybaplaya'), ('4','5','1','Hecelchakán'), ('4','5','7','Pomuch'), ('4','6','1','Hopelchén'), ('4','8','1','Tenabo'), ('4','9','1','Escárcega'), ('4','11','1','Candelaria'), ('5','2','1','Ciudad Acuña'), ('5','3','1','Allende'), ('5','4','1','Arteaga'), ('5','6','1','Castaños'), ('5','7','1','Cuatro Ciénegas de Carranza'), ('5','9','1','Francisco I. Madero (Chávez)'), ('5','10','1','Frontera'), ('5','17','1','Matamoros'), ('5','17','12','San Antonio del Coyote'), ('5','18','1','Monclova'), ('5','19','1','Morelos'), ('5','20','1','Ciudad Melchor Múzquiz'), ('5','20','70','Minas de Barroterán'), ('5','20','93','Palaú'), ('5','22','1','Nava'), ('5','24','1','Parras de la Fuente'), ('5','25','1','Piedras Negras'), ('5','27','1','Ramos Arizpe'), ('5','28','1','Sabinas'), ('5','30','1','Saltillo'), ('5','31','1','San Buenaventura'), ('5','32','14','Nueva Rosita'), ('5','33','1','San Pedro'), ('5','33','22','Concordia (La Rosita)'), ('5','35','1','Torreón'), ('5','37','1','Villa Unión'), ('5','38','1','Zaragoza'), ('6','1','1','Ciudad de Armería'), ('6','1','7','Cofradía de Juárez'), ('6','2','1','Colima'), ('6','3','1','Comala'), ('6','4','1','Coquimatlán'), ('6','5','1','Cuauhtémoc'), ('6','5','18','Quesería'), ('6','7','1','Manzanillo'), ('6','7','21','El Colomo'), ('6','9','1','Tecomán'), ('6','9','11','Colonia Bayardo'), ('6','9','25','Cerro de Ortega'), ('6','10','1','Ciudad de Villa de Álvarez'), ('7','1','1','Acacoyagua'), ('7','2','1','Acala'), ('7','3','1','Acapetahua'), ('7','4','1','Altamirano'), ('7','8','1','Jaltenango de la Paz (Angel Albino Corzo)'), ('7','9','1','Arriaga'), ('7','12','1','Berriozábal'), ('7','13','1','Bochil'), ('7','14','1','El Bosque'), ('7','15','1','Cacahoatán'), ('7','17','1','Cintalapa de Figueroa'), ('7','19','1','Comitán de Domínguez'), ('7','20','1','La Concordia'), ('7','21','1','Copainalá'), ('7','24','1','Chanal'), ('7','27','1','Chiapa de Corzo'), ('7','30','1','Chicomuselo'), ('7','31','1','Chilón'), ('7','31','9','Bachajón'), ('7','32','1','Escuintla'), ('7','34','1','Frontera Comalapa'), ('7','37','1','Huehuetán'), ('7','37','59','Huehuetán Estación FFCC'), ('7','40','1','Huixtla'), ('7','41','81','El Triunfo'), ('7','41','83','Venustiano Carranza'), ('7','44','1','Ixtapa'), ('7','46','1','Jiquipilas'), ('7','48','1','Juárez'), ('7','51','1','Mapastepec'), ('7','52','1','Las Margaritas'), ('7','54','1','Mazatán'), ('7','57','1','Motozintla de Mendoza'), ('7','59','1','Ocosingo'), ('7','59','418','Nueva Palestina'), ('7','59','431','Frontera Corozal'), ('7','61','1','Ocozocoautla de Espinosa'), ('7','64','1','Oxchuc'), ('7','65','1','Palenque'), ('7','66','1','Pantelhó'), ('7','68','1','Pichucalco'), ('7','69','1','Pijijiapan'), ('7','71','1','Villa Comaltitlán'), ('7','72','1','Pueblo Nuevo Solistahuacán'), ('7','72','54','Rincón Chamula'), ('7','73','1','Rayón'), ('7','74','1','Reforma'), ('7','75','1','Las Rosas'), ('7','77','1','Salto de Agua'), ('7','78','1','San Cristóbal de las Casas'), ('7','79','1','San Fernando'), ('7','81','1','Simojovel de Allende'), ('7','86','1','Suchiapa'), ('7','87','1','Ciudad Hidalgo'), ('7','89','1','Tapachula de Córdova y Ordóñez'), ('7','89','46','Álvaro Obregón'), ('7','89','148','Puerto Madero (San Benito)'), ('7','89','991','Vida Mejor I'), ('7','91','1','Tapilula'), ('7','92','31','Raudales Malpaso'), ('7','94','1','Teopisca'), ('7','96','1','Tila'), ('7','96','55','Petalcingo'), ('7','97','1','Tonalá'), ('7','97','40','Paredón'), ('7','99','1','La Trinitaria'), ('7','101','1','Tuxtla Gutiérrez'), ('7','101','37','Copoya'), ('7','102','1','Tuxtla Chico'), ('7','104','1','Tzimol'), ('7','106','1','Venustiano Carranza'), ('7','106','109','San Francisco Pujiltic'), ('7','107','1','Villa Corzo'), ('7','107','34','San Pedro Buenavista'), ('7','107','166','El Parral'), ('7','107','200','Revolución Mexicana'), ('7','108','1','Villaflores'), ('7','108','120','Jesús María Garza'), ('7','109','1','Yajalón'), ('7','112','1','San Juan Cancuc'), ('7','114','1','Benemérito de las Américas'), ('8','1','1','Miguel Ahumada'), ('8','2','1','Juan Aldama'), ('8','4','1','Santa Eulalia'), ('8','5','1','Ascensión'), ('8','9','34','Creel'), ('8','9','169','San Juanito'), ('8','10','1','San Buenaventura'), ('8','10','5','Ejido Benito Juárez'), ('8','11','1','Santa Rosalía de Camargo'), ('8','13','1','Casas Grandes'), ('8','17','1','Cuauhtémoc'), ('8','17','5','Colonia Anáhuac'), ('8','19','1','Chihuahua'), ('8','21','1','Delicias'), ('8','25','1','Valentín Gómez Farías'), ('8','27','1','Guachochi'), ('8','29','1','Guadalupe y Calvo'), ('8','31','1','Vicente Guerrero'), ('8','31','3','La Junta'), ('8','32','1','Hidalgo del Parral'), ('8','36','1','José Mariano Jiménez'), ('8','37','1','Juárez'), ('8','40','1','Madera'), ('8','45','1','Pedro Meoqui'), ('8','45','15','Lázaro Cárdenas'), ('8','50','1','Nuevo Casas Grandes'), ('8','52','1','Manuel Ojinaga'), ('8','55','1','Santa Cruz de Rosales'), ('8','60','1','Santa Bárbara'), ('8','62','1','Saucillo'), ('9','2','1','Azcapotzalco'), ('9','3','1','Coyoacán'), ('9','4','1','Cuajimalpa de Morelos'), ('9','4','20','San Lorenzo Acopilco'), ('9','5','1','Gustavo A. Madero'), ('9','6','1','Iztacalco'), ('9','7','1','Iztapalapa'), ('9','8','1','La Magdalena Contreras'), ('9','9','1','Villa Milpa Alta'), ('9','9','11','San Antonio Tecómitl'), ('9','9','17','San Francisco Tecoxpa'), ('9','9','24','San Pablo Oztotepec'), ('9','9','29','San Pedro Atocpan'), ('9','9','33','San Salvador Cuauhtenco'), ('9','9','36','Santa Ana Tlacotenco'), ('9','10','1','Álvaro Obregón'), ('9','11','1','Tláhuac'), ('9','11','11','San Andrés Mixquic'), ('9','11','21','San Juan Ixtayopan'), ('9','11','26','Santa Catarina Yecahuitzotl'), ('9','12','1','Tlalpan'), ('9','12','26','San Miguel Ajusco'), ('9','12','27','San Miguel Topilejo'), ('9','13','1','Xochimilco'), ('9','14','1','Benito Juárez'), ('9','15','1','Cuauhtémoc'), ('9','16','1','Miguel Hidalgo'), ('9','17','1','Venustiano Carranza'), ('10','1','1','Canatlán'), ('10','4','1','Cuencamé de Ceniceros'), ('10','5','1','Victoria de Durango'), ('10','7','1','Gómez Palacio'), ('10','8','1','Guadalupe Victoria'), ('10','12','1','Lerdo'), ('10','12','28','Nazareno'), ('10','12','57','Ciudad Juárez'), ('10','13','1','Mapimí'), ('10','13','14','Bermejillo'), ('10','16','1','Nombre de Dios'), ('10','18','1','Santa María del Oro'), ('10','21','1','Peñón Blanco'), ('10','22','1','Villa Unión'), ('10','23','1','El Salto'), ('10','26','1','Tayoltita'), ('10','32','1','Santiago Papasquiaro'), ('10','36','1','Tlahualilo de Zaragoza'), ('10','38','1','Vicente Guerrero'), ('10','39','1','Nuevo Ideal'), ('11','1','1','Abasolo'), ('11','2','1','Acámbaro'), ('11','2','27','Irámuco'), ('11','3','1','San Miguel de Allende'), ('11','4','1','Apaseo el Alto'), ('11','5','1','Apaseo el Grande'), ('11','5','45','San José Agua Azul'), ('11','7','1','Celaya'), ('11','7','143','Rincón de Tamayo'), ('11','7','161','San Juan de la Vega'), ('11','7','165','San Miguel Octopan'), ('11','8','1','Ciudad Manuel Doblado'), ('11','9','1','Comonfort'), ('11','9','10','Empalme Escobedo'), ('11','11','1','Cortazar'), ('11','12','1','Cuerámaro'), ('11','13','1','Doctor Mora'), ('11','14','1','Dolores Hidalgo Cuna de la Independencia Nacional'), ('11','15','1','Guanajuato'), ('11','15','67','Marfil'), ('11','15','111','Santa Teresa'), ('11','15','126','Yerbabuena'), ('11','16','1','Huanímaro'), ('11','17','1','Irapuato'), ('11','17','59','Arandas'), ('11','17','161','San Roque'), ('11','17','359','Villas de Irapuato'), ('11','18','1','Jaral del Progreso'), ('11','19','1','Jerécuaro'), ('11','20','1','León de los Aldama'), ('11','20','317','Duarte'), ('11','20','401','Plan de Ayala (Santa Rosa)'), ('11','20','703','Medina'), ('11','20','785','Centro Familiar la Soledad'), ('11','20','975','La Ermita'), ('11','21','1','Moroleón'), ('11','22','1','Ocampo'), ('11','23','1','Pénjamo'), ('11','23','288','Santa Ana Pacueco'), ('11','25','1','Purísima de Bustos'), ('11','26','1','Romita'), ('11','27','1','Salamanca'), ('11','27','46','Cerro Gordo (San Rafael)'), ('11','27','135','San José Temascatío'), ('11','27','161','Valtierrilla'), ('11','28','1','Salvatierra'), ('11','28','58','San Nicolás de los Agustinos'), ('11','28','64','Urireo'), ('11','29','1','San Diego de la Unión'), ('11','30','1','San Felipe'), ('11','30','211','San Bartolo de Berrios'), ('11','31','1','San Francisco del Rincón'), ('11','32','1','San José Iturbide'), ('11','33','1','San Luis de la Paz'), ('11','33','110','Misión de Chichimecas'), ('11','35','1','Juventino Rosas'), ('11','35','75','Santiago de Cuenda'), ('11','37','1','Silao de la Victoria'), ('11','37','4','La Aldea'), ('11','38','1','Tarandacuao'), ('11','39','1','Tarimoro'), ('11','41','1','Uriangato'), ('11','42','1','Valle de Santiago'), ('11','44','1','Villagrán'), ('11','44','23','Mexicanos'), ('11','44','43','Sarabia'), ('11','46','1','Yuriria'), ('11','46','12','Cerano (San Juan Cerano)'), ('12','1','1','Acapulco de Juárez'), ('12','1','110','Kilómetro 30'), ('12','1','166','Tres Palos'), ('12','1','173','Xaltianguis'), ('12','3','1','Ajuchitlán del Progreso'), ('12','6','1','Ciudad Apaxtla de Castrejón'), ('12','7','1','Arcelia'), ('12','11','1','Atoyac de Álvarez'), ('12','12','1','Ayutla de los Libres'), ('12','14','1','San Jerónimo de Juárez'), ('12','15','1','Buenavista de Cuéllar'), ('12','18','1','Copala'), ('12','19','1','Copalillo'), ('12','21','1','Coyuca de Benítez'), ('12','21','8','Bajos del Ejido'), ('12','22','1','Coyuca de Catalán'), ('12','23','1','Cuajinicuilapa'), ('12','28','1','Chilapa de Álvarez'), ('12','29','1','Chilpancingo de los Bravo'), ('12','29','43','Mazatlán'), ('12','29','45','Ocotito'), ('12','29','47','Petaquillas'), ('12','30','1','Cruz Grande'), ('12','32','1','Tlacotepec'), ('12','33','1','Huamuxtitlán'), ('12','34','1','Ciudad de Huitzuco'), ('12','35','1','Iguala de la Independencia'), ('12','38','1','Zihuatanejo'), ('12','38','13','San José Ixtapa (Barrio Viejo)'), ('12','38','23','El Coacoyul'), ('12','38','124','Ixtapa Zihuatanejo'), ('12','39','1','Tierra Colorada'), ('12','40','1','Chichihualco'), ('12','44','1','Mochitlán'), ('12','45','1','Olinalá'), ('12','46','1','Ometepec'), ('12','48','1','Petatlán'), ('12','48','178','San Jeronimito (San Jerónimo)'), ('12','49','1','Pilcaya'), ('12','50','1','Ciudad Altamirano'), ('12','51','1','Quechultenango'), ('12','52','1','San Luis Acatlán'), ('12','53','1','San Marcos'), ('12','55','1','Taxco de Alarcón'), ('12','55','2','Acamixtla'), ('12','55','46','Tlamacazapa'), ('12','57','1','Técpan de Galeana'), ('12','57','79','San Luis de la Loma'), ('12','57','86','El Súchil'), ('12','58','1','Teloloapan'), ('12','59','1','Tepecoacuilco de Trujano'), ('12','61','1','Tixtla de Guerrero'), ('12','61','6','Atliaca'), ('12','66','1','Tlapa de Comonfort'), ('12','67','1','Tlapehuala'), ('12','74','1','Zitlala'), ('12','75','1','Zumpango del Río'), ('12','77','1','Marquelia'), ('13','3','1','Actopan'), ('13','5','1','Ajacuba'), ('13','8','1','Apan'), ('13','10','1','Atitalaquia'), ('13','10','2','Cardonal'), ('13','12','1','Atotonilco el Grande'), ('13','13','1','Atotonilco de Tula'), ('13','16','1','Cuautepec'), ('13','21','1','Emiliano Zapata'), ('13','23','1','Tepatepec'), ('13','23','14','San Juan Tepa'), ('13','28','1','Huejutla de Reyes'), ('13','29','1','Huichapan'), ('13','30','1','Ixmiquilpan'), ('13','32','1','Jaltocán'), ('13','39','1','Mineral del Monte'), ('13','41','1','Mixquiahuala de Juárez'), ('13','46','1','San Felipe Orizatlán'), ('13','48','1','Pachuca de Soto'), ('13','50','1','Progreso de Obregón'), ('13','51','1','Pachuquilla'), ('13','51','27','La Providencia Siglo XXI'), ('13','51','78','Los Tuzos'), ('13','51','93','Campestre Villas del Álamo'), ('13','51','147','Unidad Minera 11 de Julio'), ('13','52','1','San Agustín Tlaxiaca'), ('13','56','1','Santiago Tulantepec'), ('13','59','1','Tecozautla'), ('13','61','1','Tepeapulco'), ('13','61','2','Fray Bernardino de Sahagún (Ciudad Sahagún)'), ('13','63','1','Tepeji del Río de Ocampo'), ('13','65','1','Tetepango'), ('13','66','1','Tezontepec'), ('13','67','5','Huitel'), ('13','67','9','Presas'), ('13','69','1','Tizayuca'), ('13','69','8','Huitzila'), ('13','69','42','Don Antonio'), ('13','69','44','Haciendas de Tizayuca'), ('13','70','1','Tlahuelilpan'), ('13','72','1','Tlanalapa'), ('13','73','1','Tlanchinol'), ('13','74','1','Tlaxcoapan'), ('13','74','2','Doxey'), ('13','75','1','Tolcayuca'), ('13','76','1','Tula de Allende'), ('13','76','8','El Llano'), ('13','76','22','San Marcos'), ('13','76','24','San Miguel Vindho'), ('13','77','1','Tulancingo'), ('13','77','10','Jaltepec'), ('13','77','18','Santa Ana Hueytlalpan'), ('13','77','53','Javier Rojo Gómez'), ('13','77','68','Parque Urbano Napateco'), ('13','81','1','Zacualtipán'), ('13','82','2','Acayuca'), ('13','83','1','Zempoala'), ('13','83','133','Privadas Santa Matilde'), ('13','84','1','Zimapán'), ('14','1','1','Acatic'), ('14','2','1','Acatlán de Juárez'), ('14','2','2','Bellavista'), ('14','3','1','Ahualulco de Mercado'), ('14','5','1','Amatitán'), ('14','6','1','Ameca'), ('14','7','1','San Juanito de Escobedo'), ('14','8','1','Arandas'), ('14','9','1','El Arenal'), ('14','10','1','Atemajac de Brizuela'), ('14','13','1','Atotonilco el Alto'), ('14','13','30','San Francisco de Asís'), ('14','14','1','Atoyac'), ('14','15','1','Autlán de Navarro'), ('14','16','1','Ayotlán'), ('14','16','72','La Ribera'), ('14','17','1','Ayutla'), ('14','18','1','La Barca'), ('14','21','1','La Resolana'), ('14','22','1','Cihuatlán'), ('14','22','33','San Patricio (Melaque)'), ('14','23','1','Ciudad Guzmán'), ('14','24','1','Cocula'), ('14','25','1','Colotlán'), ('14','30','1','Chapala'), ('14','30','2','Ajijic'), ('14','30','3','Atotonilquillo'), ('14','33','1','Degollado'), ('14','35','1','Encarnación de Díaz'), ('14','36','1','Etzatlán'), ('14','37','1','El Grullo'), ('14','39','1','Guadalajara'), ('14','43','1','La Huerta'), ('14','44','1','Ixtlahuacán de los Membrillos'), ('14','44','2','Atequiza'), ('14','44','10','Los Olivos'), ('14','45','1','Ixtlahuacán del Río'), ('14','46','1','Jalostotitlán'), ('14','47','1','Jamay'), ('14','48','1','Jesús María'), ('14','50','1','Jocotepec'), ('14','50','11','San Juan Cosalá'), ('14','51','1','Juanacatlán'), ('14','53','1','Lagos de Moreno'), ('14','55','1','Magdalena'), ('14','58','1','Mascota'), ('14','59','1','Mazamitla'), ('14','63','1','Ocotlán'), ('14','64','1','Ojuelos de Jalisco'), ('14','65','1','Pihuamo'), ('14','66','1','Poncitlán'), ('14','66','11','Cuitzeo (La Estancia)'), ('14','66','19','Mezcala'), ('14','66','31','San Pedro Itzicán'), ('14','67','1','Puerto Vallarta'), ('14','67','28','Ixtapa'), ('14','67','31','Las Juntas'), ('14','68','1','Villa Purificación'), ('14','70','1','El Salto'), ('14','70','13','Las Pintas'), ('14','70','14','Las Pintitas'), ('14','70','20','San José del Castillo'), ('14','70','21','San José el Verde (El Verde)'), ('14','70','43','El Quince (San José el Quince)'), ('14','70','111','Galaxia Bonito Jalisco'), ('14','70','117','Centro de Readaptación Social'), ('14','72','1','San Diego de Alejandría'), ('14','73','1','San Juan de los Lagos'), ('14','74','1','San Julián'), ('14','77','1','San Martín Hidalgo'), ('14','78','1','San Miguel el Alto'), ('14','79','1','San Sebastián del Sur'), ('14','79','30','San Andrés Ixtlán'), ('14','82','1','Sayula'), ('14','82','26','Usmajac'), ('14','83','1','Tala'), ('14','83','13','El Refugio'), ('14','83','220','Los Ruiseñores'), ('14','84','1','Talpa de Allende'), ('14','85','1','Tamazula de Gordiano'), ('14','86','1','Tapalpa'), ('14','87','1','Tecalitlán'), ('14','88','1','Tecolotlán'), ('14','91','1','Teocaltiche'), ('14','93','1','Tepatitlán de Morelos'), ('14','93','58','Capilla de Guadalupe'), ('14','93','291','San José de Gracia'), ('14','94','1','Tequila'), ('14','96','1','Tizapán el Alto'), ('14','97','1','Tlajomulco de Zúñiga'), ('14','97','5','Cajititlán'), ('14','97','9','El Capulín'), ('14','97','15','San Miguel Cuyutlán'), ('14','97','25','San Agustín'), ('14','97','32','San Sebastián el Grande'), ('14','97','34','Santa Cruz de las Flores'), ('14','97','35','Santa Cruz del Valle'), ('14','97','41','Zapote del Valle (Zapote de Santa Cruz)'), ('14','97','115','La Alameda'), ('14','97','424','La Tijera'), ('14','97','777','Rancho Alegre [Fraccionamiento]'), ('14','97','822','Hacienda Santa Fe'), ('14','97','831','Real del Valle (El Paraíso) [Fraccionamiento]'), ('14','97','833','Villas de la Hacienda [Fraccionamiento]'), ('14','97','835','Galaxia la Noria'), ('14','97','843','Lomas del Sur'), ('14','97','844','Lomas de San Agustín'), ('14','97','853','Valle Dorado Inn'), ('14','97','862','Colinas del Roble'), ('14','98','1','Tlaquepaque'), ('14','98','14','Santa Anita'), ('14','100','1','Tomatlán'), ('14','101','1','Tonalá'), ('14','101','9','Coyula'), ('14','101','26','Puente Grande'), ('14','101','74','Centro de Readaptación Social'), ('14','105','1','Tototlán'), ('14','108','1','Tuxpan'), ('14','109','1','Unión de San Antonio'), ('14','110','1','Unión de Tula'), ('14','114','1','Villa Corona'), ('14','116','1','Villa Hidalgo'), ('14','118','1','Yahualica de González Gallo'), ('14','119','1','Zacoalco de Torres'), ('14','120','1','Zapopan'), ('14','120','231','Tesistán (San Francisco Tesistán)'), ('14','120','243','La Venta del Astillero'), ('14','121','1','Zapotiltic'), ('14','124','1','Zapotlanejo'), ('14','125','1','San Ignacio Cerro Gordo'), ('15','2','1','Acolman de Nezahualcóyotl'), ('15','2','5','San Bartolo'), ('15','2','12','Santa Catarina'), ('15','2','15','Tepexpan'), ('15','5','4','La Cabecera'), ('15','5','32','San Francisco Tlalcilalcalpan'), ('15','5','45','Santiaguito Tlalcilalcalli'), ('15','5','165','Fraccionamiento Colinas del Sol'), ('15','6','1','Almoloya del Río'), ('15','9','1','Amecameca de Juárez'), ('15','10','1','Apaxco de Ocampo'), ('15','11','1','San Salvador Atenco'), ('15','11','2','San Cristóbal Nexquipayac'), ('15','11','23','La Pastoría'), ('15','11','29','Granjas Ampliación Santa Rosa'), ('15','12','1','Santa Cruz Atizapán'), ('15','13','1','Ciudad López Mateos'), ('15','14','1','Atlacomulco de Fabela'), ('15','14','48','San Lorenzo Tlacotepec'), ('15','14','54','Santiago Acutzilapan'), ('15','15','1','Atlautla de Victoria'), ('15','15','6','San Juan Tehuixtitlán'), ('15','16','6','Jaltepec'), ('15','18','1','Calimaya de Díaz González'), ('15','18','3','San Andrés Ocotlán'), ('15','18','8','Santa María Nativitas'), ('15','18','10','Zaragoza de Guadalupe'), ('15','19','1','Capulhuac de Mirafuentes'), ('15','20','1','San Francisco Coacalco'), ('15','21','1','Coatepec Harinas'), ('15','22','1','Cocotitlán'), ('15','23','1','Coyotepec'), ('15','24','1','Cuautitlán'), ('15','24','88','San Mateo Ixtacalco'), ('15','24','111','Galaxia Cuautitlán'), ('15','25','1','Chalco de Díaz Covarrubias'), ('15','25','2','La Candelaria Tlapala'), ('15','25','5','San Gregorio Cuautzingo'), ('15','25','10','San Juan Tezompa'), ('15','25','13','San Marcos Huixtoco'), ('15','25','14','San Martín Cuautlalpan'), ('15','25','16','San Mateo Huitzilzingo'), ('15','25','17','San Mateo Tezoquipan Miraflores'), ('15','25','19','San Pablo Atlazalpan'), ('15','25','20','Santa Catarina Ayotzingo'), ('15','25','21','Santa María Huexoculco'), ('15','27','1','Chapultepec'), ('15','28','1','Chiautla'), ('15','29','1','Chicoloapan de Juárez'), ('15','30','1','Chiconcuac de Juárez'), ('15','31','1','Chimalhuacán'), ('15','33','1','Ecatepec de Morelos'), ('15','34','1','Ecatzingo de Hidalgo'), ('15','35','1','Huehuetoca'), ('15','35','8','Salitrillo'), ('15','35','9','San Bartolo'), ('15','35','19','Ex-Hacienda de Xalpa'), ('15','35','27','Santa Teresa'), ('15','36','6','Jilotzingo'), ('15','36','8','San Francisco Zacacalco'), ('15','36','9','Santa María Ajoloapan'), ('15','37','1','Huixquilucan de Degollado'), ('15','37','9','Jesús del Monte'), ('15','37','13','Magdalena Chichicaspa'), ('15','37','18','San Bartolomé Coatepec'), ('15','37','25','Santiago Yancuitlalpan'), ('15','37','26','Zacamulpa'), ('15','37','71','Naucalpan de Juárez'), ('15','39','1','Ixtapaluca'), ('15','39','3','San Buenaventura'), ('15','39','4','Coatepec'), ('15','39','11','Río Frío de Juárez'), ('15','39','12','San Francisco Acuautla'), ('15','39','64','Jorge Jiménez Cantú'), ('15','39','151','San Jerónimo Cuatro Vientos'), ('15','40','1','Ixtapan de la Sal'), ('15','42','1','Ixtlahuaca de Rayón'), ('15','42','2','La Concepción los Baños'), ('15','42','16','San Bartolo del Llano'), ('15','42','30','San Pedro los Baños'), ('15','42','34','Emiliano Zapata (Santo Domingo)'), ('15','42','35','Santo Domingo de Guzmán'), ('15','43','1','Xalatlaco'), ('15','44','1','Jaltenco'), ('15','44','20','Alborada Jaltenco'), ('15','45','1','Jilotepec de Molina Enríquez'), ('15','47','19','San Bartolo Oxtotitlán'), ('15','48','1','Ciudad de Jocotitlán'), ('15','48','12','San Juan Coajomulco'), ('15','48','13','San Miguel Tenochtitlán'), ('15','48','15','Santa María Citendeje'), ('15','50','1','Juchitepec de Mariano Rivapalacio'), ('15','50','2','San Matías Cuijingo'), ('15','51','1','Lerma de Villada'), ('15','51','20','San Mateo Atarasquillo'), ('15','51','21','San Miguel Ameyalco'), ('15','51','24','San Pedro Tultepec'), ('15','51','26','Santa María Atarasquillo'), ('15','52','1','Malinalco'), ('15','53','1','Melchor Ocampo'), ('15','54','1','Metepec'), ('15','54','32','San Bartolomé Tlaltelulco'), ('15','54','34','San Francisco Coaxusco'), ('15','54','35','San Gaspar Tlahuelilpan'), ('15','54','37','San Jerónimo Chicahualco'), ('15','54','38','San Jorge Pueblo Nuevo'), ('15','54','47','San Miguel Totocuitlapilco'), ('15','54','49','San Salvador Tizatlalli'), ('15','54','55','Santa María Magdalena Ocotitlán'), ('15','55','1','San Mateo Mexicaltzingo'), ('15','57','1','Naucalpan de Juárez'), ('15','57','88','San Francisco Chimalpa'), ('15','58','1','Ciudad Nezahualcóyotl'), ('15','59','1','Santa Ana Nextlalpan'), ('15','59','58','Ex-Hacienda Santa Inés'), ('15','60','1','Ciudad Nicolás Romero'), ('15','60','3','Quinto Barrio (Ejido Cahuacán)'), ('15','60','4','Santa María Magdalena Cahuacán'), ('15','60','16','Progreso Industrial'), ('15','60','20','San José el Vidrio'), ('15','60','82','Veintidós de Febrero'), ('15','62','1','Ocoyoacac'), ('15','62','23','San Pedro Cholula'), ('15','64','1','El Oro de Hidalgo'), ('15','65','1','Otumba de Gómez Farías'), ('15','67','1','Villa Cuauhtémoc'), ('15','67','14','Santa Ana Jilotzingo'), ('15','67','50','Ejido de la Y Sección Siete A Revolución'), ('15','68','1','Ozumba de Alzate'), ('15','70','1','Los Reyes Acaquilpan'), ('15','70','5','La Magdalena Atlicpac'), ('15','70','8','San Sebastián Chimalpa'), ('15','70','9','Tecamachalco'), ('15','70','13','Emiliano Zapata'), ('15','70','17','Profesor Carlos Hank González'), ('15','70','19','El Pino'), ('15','70','36','Arenal'), ('15','70','38','Lomas de San Sebastián'), ('15','70','39','Lomas de Altavista'), ('15','70','40','San Isidro'), ('15','70','41','San José las Palmas'), ('15','72','1','Santa María Rayón'), ('15','73','1','San Antonio la Isla'), ('15','73','2','Ex-Rancho San Dimas'), ('15','74','97','San Miguel la Labor'), ('15','74','98','San Nicolás Guadalupe'), ('15','75','1','San Martín de las Pirámides'), ('15','76','1','San Mateo Atenco'), ('15','81','1','Tecámac de Felipe Villanueva'), ('15','81','4','Los Reyes Acozac'), ('15','81','9','San Pablo Tecalco'), ('15','81','12','Santa María Ajoloapan'), ('15','81','19','Ojo de Agua'), ('15','81','25','San Martín Azcatepec'), ('15','81','98','Fraccionamiento Social Progresivo Santo Tomás Chiconautla'), ('15','82','1','Tejupilco de Hidalgo'), ('15','83','1','Temamatla'), ('15','84','1','Temascalapa'), ('15','84','14','San Luis Tecuautitlán'), ('15','84','17','Santa Ana Tlachihualpa'), ('15','85','1','Temascalcingo de José María Velasco'), ('15','85','24','San Francisco Tepeolulco'), ('15','87','27','San Lorenzo Oyamel'), ('15','87','29','San Pedro Abajo'), ('15','87','30','San Pedro Arriba'), ('15','88','1','Tenancingo de Degollado'), ('15','88','24','Santa Ana Ixtlahuatzingo (Santa Ana)'), ('15','89','1','Tenango del Aire'), ('15','90','1','Tenango de Arista'), ('15','90','6','San Bartolomé Atlatlahuca'), ('15','90','36','San Pedro Tlanixco'), ('15','90','37','San Pedro Zictepec'), ('15','90','38','Santa María Jajalpa'), ('15','90','39','Santiaguito Cuaxustenco'), ('15','91','1','Teoloyucan'), ('15','91','10','San Bartolo'), ('15','92','1','Teotihuacán de Arista'), ('15','92','19','San Lorenzo Tlalmimilolpan'), ('15','92','20','San Sebastián Xolalpa'), ('15','93','1','Tepetlaoxtoc de Hidalgo'), ('15','93','3','Concepción Jolalpan'), ('15','94','1','Tepetlixpa'), ('15','95','1','Tepotzotlán'), ('15','95','21','San Mateo Xoloc'), ('15','95','26','Santiago Cuautlalpan'), ('15','95','73','Santa Cruz del Monte'), ('15','95','74','Ejido de Coyotepec'), ('15','96','1','Tequixquiac'), ('15','96','8','Tlapanaloya'), ('15','99','1','Texcoco de Mora'), ('15','99','12','Montecillo'), ('15','99','20','San Bernardino'), ('15','99','22','San Dieguito Xochimanca'), ('15','99','24','San Jerónimo Amanalco'), ('15','99','25','San Joaquín Coapango'), ('15','99','29','San Miguel Coatlinchán'), ('15','99','30','San Miguel Tlaixpan'), ('15','99','35','Santa Catarina del Monte'), ('15','99','42','Villa Santiago Cuautlalpan'), ('15','99','43','Tequexquináhuac'), ('15','99','45','Santa María Tulantongo'), ('15','99','48','Xocotlán'), ('15','100','1','Tezoyuca'), ('15','100','2','Tequisistlán'), ('15','100','7','Ejido de Tequisistlán Primero'), ('15','101','1','Santiago Tianguistenco de Galeana'), ('15','101','6','Guadalupe Yancuictlalpan (Gualupita)'), ('15','101','14','San Pedro Tlaltizapan'), ('15','101','15','Santiago Tilapa'), ('15','103','1','Tlalmanalco de Velázquez'), ('15','103','5','San Rafael'), ('15','104','1','Tlalnepantla'), ('15','104','105','Puerto Escondido (Tepeolulco Puerto Escondido)'), ('15','106','1','Toluca de Lerdo'), ('15','106','43','Cacalomacán'), ('15','106','44','Calixtlahuaca'), ('15','106','50','El Cerrillo Vista Hermosa'), ('15','106','51','La Constitución Toltepec'), ('15','106','62','San Andrés Cuexcontitlán'), ('15','106','63','San Antonio Buenavista'), ('15','106','68','San Diego de los Padres Cuexcontitlán'), ('15','106','70','San Felipe Tlalmimilolpan'), ('15','106','72','San José Guadalupe Otzacatipan'), ('15','106','73','San Juan Tilapa'), ('15','106','77','San Marcos Yachihuacaltepec'), ('15','106','79','San Mateo Otzacatipan'), ('15','106','82','San Nicolás Tolentino'), ('15','106','83','San Pablo Autopan'), ('15','106','84','San Pedro Totoltepec'), ('15','106','88','Santa Cruz Otzacatipan'), ('15','106','97','Santiago Tlacotepec'), ('15','106','99','Tlachaloya Segunda Sección'), ('15','106','112','San Miguel Totoltepec'), ('15','106','127','Jicaltepec Autopan'), ('15','106','188','Ejido de la Y Sección Siete A Revolución'), ('15','107','1','Tonatico'), ('15','108','1','Tultepec'), ('15','108','14','Santiago Teyahualco'), ('15','108','63','Fraccionamiento Paseos de Tultepec II'), ('15','109','1','Tultitlán de Mariano Escobedo'), ('15','109','3','Buenavista'), ('15','109','25','San Pablo de las Salinas'), ('15','109','68','Fuentes del Valle'), ('15','109','69','Ampliación San Mateo (Colonia Solidaridad)'), ('15','110','1','Valle de Bravo'), ('15','110','12','Colorines'), ('15','112','1','Villa del Carbón'), ('15','113','1','Villa Guerrero'), ('15','115','1','Xonacatlán'), ('15','115','6','Santa María Zolotepec'), ('15','118','1','San Miguel Zinacantepec'), ('15','118','14','El Cóporo'), ('15','118','53','San Antonio Acahualco'), ('15','118','58','San Juan de las Huertas'), ('15','118','59','Ejido San Lorenzo Cuauhtenco'), ('15','118','64','Santa Cruz Cuauhtenco'), ('15','118','87','Barrio de México'), ('15','118','134','Conjunto Urbano la Loma I'), ('15','120','1','Zumpango de Ocampo'), ('15','120','14','Arbolada los Sauces'), ('15','120','41','San Bartolo Cuautlalpan'), ('15','120','46','San Juan Zitlaltepec'), ('15','120','54','San Sebastián'), ('15','120','175','La Trinidad [Fraccionamiento]'), ('15','120','198','Paseos de San Juan'), ('15','121','1','Cuautitlán Izcalli'), ('15','121','20','San José Huilango'), ('15','122','1','Xico'), ('15','123','1','Villa Luvianos'), ('15','125','1','Santa María Tonanitla'), ('16','1','1','Acuitzio del Canje'), ('16','2','1','Aguililla'), ('16','3','1','Álvaro Obregón'), ('16','4','1','Angamacutiro de la Unión'), ('16','6','1','Apatzingán de la Constitución'), ('16','9','1','Ario de Rosales'), ('16','10','1','Arteaga'), ('16','12','1','Buenavista Tomatlán'), ('16','12','15','Felipe Carrillo Puerto (La Ruana)'), ('16','14','1','Coahuayana de Hidalgo'), ('16','15','1','Coalcomán de Vázquez Pallares'), ('16','19','1','Cotija de la Paz'), ('16','20','1','Cuitzeo del Porvenir'), ('16','22','1','Charo'), ('16','23','1','Chavinda'), ('16','24','1','Cherán'), ('16','25','1','Chilchota'), ('16','25','3','Carapan'), ('16','33','1','Lombardía'), ('16','34','1','Ciudad Hidalgo'), ('16','35','1','La Huacana'), ('16','36','1','Huandacareo'), ('16','38','1','Huetamo de Núñez'), ('16','40','1','Indaparapeo'), ('16','43','1','Jacona de Plancarte'), ('16','45','1','Jiquilpan de Juárez'), ('16','47','1','Jungapeo de Juárez'), ('16','49','1','Villa Madero'), ('16','50','1','Maravatío de Ocampo'), ('16','51','1','San José de Gracia'), ('16','52','1','Ciudad Lázaro Cárdenas'), ('16','52','28','Buenos Aires'), ('16','52','77','Las Guacamayas'), ('16','52','127','La Mira'), ('16','52','137','La Orilla'), ('16','53','1','Morelia'), ('16','53','27','La Aldea'), ('16','53','40','Capula'), ('16','53','86','Morelos'), ('16','53','443','Fraccionamiento Misión del Valle'), ('16','53','474','Conjunto Habitacional Villas del Pedregal'), ('16','55','1','Nueva Italia de Ruiz'), ('16','56','1','Nahuatzen'), ('16','58','1','Nuevo San Juan Parangaricutiro')";
        //            string insertCiudad2 = "Insert Into Ciudad(Clave_Estado, Clave_Municipio, Clave_Ciudad, NombreCiudad) values  ('16','62','1','Pajacuarán'), ('16','63','1','Panindícuaro'), ('16','64','3','Antúnez (Morelos)'), ('16','65','1','Paracho de Verduzco'), ('16','66','1','Pátzcuaro'), ('16','68','1','Peribán de Ramos'), ('16','69','1','La Piedad de Cabadas'), ('16','70','1','Purépero de Echáiz'), ('16','71','1','Puruándiro'), ('16','72','1','Queréndaro'), ('16','73','1','Quiroga'), ('16','74','1','Cojumatlán de Régules'), ('16','75','1','Los Reyes de Salgado'), ('16','76','1','Sahuayo de Morelos'), ('16','78','1','Santa Ana Maya'), ('16','79','1','Santa Clara del Cobre'), ('16','79','45','Opopeo'), ('16','82','1','Tacámbaro de Codallos'), ('16','82','66','Pedernales'), ('16','83','1','Tancítaro'), ('16','84','1','Santiago Tangamandapio'), ('16','84','20','Tarecuato'), ('16','85','1','Tangancícuaro de Arista'), ('16','86','1','Tanhuato de Guerrero'), ('16','87','1','Taretan'), ('16','88','1','Tarímbaro'), ('16','88','124','Fraccionamiento Galaxia Tarímbaro'), ('16','88','145','Fraccionamiento Metrópolis II'), ('16','89','1','Tepalcatepec'), ('16','90','1','Tingambato'), ('16','91','1','Tingüindín'), ('16','95','40','Santa Clara de Valladares'), ('16','97','158','Puruarán'), ('16','98','1','Tuxpan'), ('16','102','1','Uruapan'), ('16','102','57','Angahuan'), ('16','102','61','Caltzontzin'), ('16','102','63','Capácuaro'), ('16','103','1','San Pedro Cahro'), ('16','105','1','Vista Hermosa de Negrete'), ('16','106','1','Yurécuaro'), ('16','107','1','Zacapu'), ('16','108','1','Zamora de Hidalgo'), ('16','108','3','Ario de Rayón (Ario Santa Mónica)'), ('16','110','1','Zinapécuaro de Figueroa'), ('16','112','1','Heróica Zitácuaro'), ('16','112','82','Rincón de Nicolás Romero (Cedros Tercera Manzana)'), ('16','113','1','Pastor Ortiz'), ('17','1','1','Amacuzac'), ('17','2','1','Atlatlahucan'), ('17','3','1','Axochiapan'), ('17','4','1','Ciudad Ayala'), ('17','4','4','Anenecuilco'), ('17','4','5','San Pedro Apatlaco'), ('17','4','26','Tenextepango'), ('17','6','1','Cuautla'), ('17','7','1','Cuernavaca'), ('17','7','125','Fraccionamiento Lomas de Ahuatlán'), ('17','8','1','Emiliano Zapata'), ('17','8','5','Tres de Mayo'), ('17','9','17','Tres Marías'), ('17','10','2','Amayuca'), ('17','11','1','Jiutepec'), ('17','11','4','Calera Chica'), ('17','11','9','Progreso'), ('17','11','28','Independencia'), ('17','12','1','Jojutla'), ('17','12','8','Pedro Amaro'), ('17','12','11','Tehuixtla'), ('17','12','13','Tlatenchi'), ('17','13','1','Jonacatepec de Leandro Valle'), ('17','15','1','Miacatlán'), ('17','15','4','Coatetelco'), ('17','17','1','Puente de Ixtla'), ('17','17','9','Xoxocotla'), ('17','18','1','Temixco'), ('17','19','1','Tepalcingo'), ('17','20','1','Tepoztlán'), ('17','22','1','Tetela del Volcán'), ('17','22','2','Hueyapan (San Andrés Hueyapan)'), ('17','24','1','Tlaltizapán'), ('17','24','13','Santa Rosa Treinta'), ('17','25','1','Tlaquiltenango'), ('17','26','1','Tlayacapan'), ('17','27','1','Totolapan'), ('17','28','1','Xochitepec'), ('17','28','2','Alpuyeca'), ('17','28','6','Chiconcuac'), ('17','28','30','Unidad Habitacional José María Morelos y Pavón'), ('17','29','1','Yautepec de Zaragoza'), ('17','29','3','Los Arcos'), ('17','29','5','Cocoyoc'), ('17','29','13','Oaxtepec'), ('17','29','24','La Joya'), ('17','30','1','Yecapixtla'), ('17','30','8','Juan Morales'), ('17','31','1','Zacatepec de Hidalgo'), ('17','31','2','San Nicolás Galeana'), ('17','32','6','Tlacotepec'), ('17','33','1','Temoac'), ('18','1','1','Acaponeta'), ('18','2','1','Ahuacatlán'), ('18','4','1','Compostela'), ('18','4','128','La Peñita de Jaltemba'), ('18','4','186','Las Varas'), ('18','6','1','Ixtlán del Río'), ('18','7','1','Jala'), ('18','8','1','Xalisco'), ('18','11','1','Ruíz'), ('18','12','1','San Blas'), ('18','15','1','Santiago Ixcuintla'), ('18','15','80','Villa Hidalgo'), ('18','16','1','Tecuala'), ('18','17','1','Tepic'), ('18','17','122','Francisco I. Madero (Puga)'), ('18','18','1','Tuxpan'), ('18','20','1','Valle de Banderas'), ('18','20','13','Bucerías'), ('18','20','43','Las Jarretaderas'), ('18','20','53','Mezcales'), ('18','20','69','El Porvenir'), ('18','20','83','San José del Valle'), ('18','20','84','San Juan de Abajo'), ('18','20','88','San Vicente'), ('19','4','1','Ciudad de Allende'), ('19','5','1','Anáhuac'), ('19','6','1','Ciudad Apodaca'), ('19','6','78','Loma la Paz'), ('19','6','133','Santa Rosa'), ('19','6','379','Prados de Santa Rosa'), ('19','6','388','Ex-Hacienda Santa Rosa'), ('19','6','392','Misión San Pablo'), ('19','9','1','Cadereyta Jiménez'), ('19','10','1','Carmen'), ('19','11','1','Ciudad Cerralvo'), ('19','12','1','Ciénega de Flores'), ('19','12','211','Real del Sol'), ('19','13','1','China'), ('19','14','1','Doctor Arroyo'), ('19','17','1','Galeana'), ('19','18','1','García'), ('19','18','25','Valle de Lincoln'), ('19','18','105','Parque Industrial Ciudad Mitras'), ('19','18','212','Mitras Poniente'), ('19','19','1','San Pedro Garza García'), ('19','21','1','Ciudad General Escobedo'), ('19','22','1','Ciudad General Terán'), ('19','25','1','General Zuazua'), ('19','25','284','Fraccionamiento Real Palmas'), ('19','25','293','Villas de Alcalá'), ('19','26','1','Guadalupe'), ('19','29','1','Hualahuises'), ('19','31','1','Ciudad Benito Juárez'), ('19','31','45','Jardines de la Silla (Jardines)'), ('19','31','224','Héctor Caballero'), ('19','31','311','Monte Kristal'), ('19','31','313','Arboledas de San Roque'), ('19','32','1','Lampazos de Naranjo'), ('19','33','1','Linares'), ('19','38','1','Montemorelos'), ('19','39','1','Monterrey'), ('19','41','1','Pesquería'), ('19','44','1','Ciudad Sabinas Hidalgo'), ('19','45','1','Salinas Victoria'), ('19','45','385','Emiliano Zapata'), ('19','46','1','San Nicolás de los Garza'), ('19','47','1','Hidalgo'), ('19','48','1','Ciudad Santa Catarina'), ('19','49','1','Santiago'), ('20','2','1','Acatlán de Pérez Figueroa'), ('20','2','39','Vicente Camalote'), ('20','5','1','Asunción Ixtaltepec'), ('20','6','1','Asunción Nochixtlán'), ('20','14','1','Ciudad Ixtepec'), ('20','21','1','Cosolapa'), ('20','23','1','Cuilápam de Guerrero'), ('20','25','1','Chahuites'), ('20','28','1','Heroica Ciudad de Ejutla de Crespo'), ('20','30','1','El Espinal'), ('20','39','1','Heroica Ciudad de Huajuapan de León'), ('20','41','1','Huautla de Jiménez'), ('20','43','1','Heroica Ciudad de Juchitán de Zaragoza'), ('20','44','1','Loma Bonita'), ('20','57','1','Matías Romero Avendaño'), ('20','59','1','Miahuatlán de Porfirio Díaz'), ('20','67','1','Oaxaca de Juárez'), ('20','68','1','Ocotlán de Morelos'), ('20','70','1','Pinotepa de Don Luis'), ('20','73','1','Putla Villa de Guerrero'), ('20','79','1','Salina Cruz'), ('20','83','1','San Agustín de las Juntas'), ('20','103','1','San Antonino Castillo Velasco'), ('20','107','1','San Antonio de la Cal'), ('20','124','1','San Blas Atempa'), ('20','131','1','San Dionisio Ocotepec'), ('20','134','1','San Felipe Jalapa de Díaz'), ('20','143','1','San Francisco Ixhuatán'), ('20','150','1','San Francisco Telixtlahuaca'), ('20','157','1','San Jacinto Amilpas'), ('20','184','1','San Juan Bautista Tuxtepec'), ('20','188','1','San Juan Colorado'), ('20','227','1','San Lorenzo Cacaotepec'), ('20','232','1','San Lucas Ojitlán'), ('20','248','1','San Mateo del Mar'), ('20','272','1','San Miguel Panixtlahuaca'), ('20','278','1','Temascal'), ('20','293','3','Hacienda Blanca'), ('20','294','1','San Pablo Huitzo'), ('20','295','1','San Pablo Huixtepec'), ('20','298','1','San Pablo Villa de Mitla'), ('20','318','2','Bajos de Chila'), ('20','318','9','Puerto Escondido'), ('20','324','1','San Pedro Pochutla'), ('20','327','1','San Pedro Tapanatepec'), ('20','334','34','Río Grande o Piedra Parada'), ('20','338','1','Villa de Etla'), ('20','350','2','El Rosario'), ('20','364','1','Santa Catarina Juquila'), ('20','375','1','Santa Cruz Amilpas'), ('20','385','1','Santa Cruz Xoxocotlán'), ('20','390','1','Santa Lucía del Camino'), ('20','397','1','Heroica Ciudad de Tlaxiaco'), ('20','399','1','Santa María Atzompa'), ('20','401','50','Brisas de Zicatela'), ('20','409','1','Santa María del Tule'), ('20','413','1','Santa María Huatulco'), ('20','413','78','Crucecita'), ('20','418','1','Santa María Jalapa del Marqués'), ('20','441','1','Santa María Xadani'), ('20','467','1','Santiago Jamiltepec'), ('20','469','1','Santiago Juxtlahuaca'), ('20','482','1','Santiago Pinotepa Nacional'), ('20','483','1','Santiago Suchilquitongo'), ('20','505','1','Santo Domingo Ingenio'), ('20','513','1','Santo Domingo Petapa'), ('20','515','1','Santo Domingo Tehuantepec'), ('20','525','1','Santo Domingo Zanatepec'), ('20','526','1','Santos Reyes Nopala'), ('20','540','1','Villa de Tamazulápam del Progreso'), ('20','545','1','Teotitlán de Flores Magón'), ('20','551','1','Tlacolula de Matamoros'), ('20','553','1','Tlalixtac de Cabrera'), ('20','557','1','Unión Hidalgo'), ('20','559','1','San Juan Bautista Valle Nacional'), ('20','565','1','Villa de Zaachila'), ('20','565','6','Vicente Guerrero'), ('20','570','1','Zimatlán de Álvarez'), ('21','1','1','Acajete'), ('21','1','4','La Magdalena Tetela Morelos'), ('21','1','6','San Agustín Tlaxco'), ('21','1','17','San Juan Tepulco'), ('21','3','1','Acatlán de Osorio'), ('21','4','1','Acatzingo de Hidalgo'), ('21','4','2','Actipan de Morelos (Santa María Actipan)'), ('21','4','9','San Sebastián Villanueva'), ('21','10','1','Ciudad de Ajalpan'), ('21','13','1','Altepexi'), ('21','15','1','Amozoc de Mota'), ('21','15','31','Casa Blanca'), ('21','17','1','Atempan'), ('21','19','1','Atlixco'), ('21','19','65','San Jerónimo Coyula'), ('21','20','1','Atoyatempan'), ('21','26','1','San Andrés Calpan'), ('21','34','1','Santa María Coronango'), ('21','34','2','San Antonio Mihuacán'), ('21','34','3','San Francisco Ocotlán (Ocotlán)'), ('21','35','1','Coxcatlán'), ('21','38','1','Cuapiaxtla de Madero'), ('21','41','1','San Juan Cuautlancingo'), ('21','41','8','Sanctorum'), ('21','41','12','San Lorenzo Almecatla'), ('21','43','1','Ciudad de Cuetzalan'), ('21','45','1','Ciudad Serdán'), ('21','46','1','Chapulco'), ('21','47','1','Ciudad de Chiautla de Tapia'), ('21','48','1','San Lorenzo Chiautzingo'), ('21','51','1','Chietla'), ('21','51','3','Atencingo'), ('21','53','1','Ciudad de Chignahuapan'), ('21','54','1','Chignautla'), ('21','60','1','Domingo Arenas'), ('21','63','1','Esperanza'), ('21','65','6','Santa Úrsula Chiconquiac'), ('21','67','1','Guadalupe Victoria'), ('21','71','1','Huauchinango'), ('21','71','27','Tenango de las Flores'), ('21','74','1','Huejotzingo'), ('21','74','29','Santa Ana Xalmimilulco'), ('21','75','1','Hueyapan'), ('21','76','1','Hueytamalco'), ('21','85','1','Izúcar de Matamoros'), ('21','87','1','Jolalpan'), ('21','90','1','Cuanalá'), ('21','90','5','Santa María Zacatepec'), ('21','91','1','Nuevo Necaxa'), ('21','94','1','Ciudad de Libres'), ('21','102','1','San Buenaventura Nealtican'), ('21','104','1','Nopalucan de la Granja'), ('21','104','11','El Rincón Citlaltépetl'), ('21','104','19','Santa María Ixtiyucan'), ('21','106','3','San Bernardino Chalchihuapan'), ('21','108','1','Oriental'), ('21','110','4','Cuacnopalan'), ('21','110','23','San Miguel Xaltepec'), ('21','114','1','Heroica Puebla de Zaragoza'), ('21','114','133','San Andrés Azumiatla'), ('21','114','190','La Resurrección'), ('21','114','194','San Sebastián de Aparicio'), ('21','114','211','San Miguel Canoa'), ('21','114','218','Santa María Xonacatepec'), ('21','114','221','Santo Tomás Chautla'), ('21','115','1','Quecholac'), ('21','115','9','Palmarito Tochapan'), ('21','117','1','Ciudad de Rafael Lara Grajales'), ('21','118','1','Los Reyes de Juárez'), ('21','119','1','San Andrés Cholula'), ('21','119','13','San Bernardino Tlaxcalancingo'), ('21','122','1','San Felipe Teotlalcingo'), ('21','124','1','San Gabriel Chilac'), ('21','129','1','San José Miahuatlán'), ('21','132','1','San Martín Texmelucan de Labastida'), ('21','132','10','San Juan Tuxco'), ('21','132','13','San Rafael Tlanalapan'), ('21','132','15','Santa María Moyotzingo'), ('21','134','1','San Matías Tlalancaleca'), ('21','136','1','San Miguel Xoxtla'), ('21','138','1','San Nicolás de los Ranchos'), ('21','140','1','Cholula de Rivadavia'), ('21','140','14','Santiago Momoxpan'), ('21','140','27','San Gregorio Zacapechpan'), ('21','142','1','San Salvador el Seco'), ('21','142','3','Santa María Coatepec'), ('21','143','11','San Lucas el Grande'), ('21','144','1','San Salvador Huixcolotla'), ('21','149','1','Santiago Miahuatlán'), ('21','151','1','Santo Tomás Hueyotlipan'), ('21','152','1','Soltepec'), ('21','153','1','Tecali de Herrera'), ('21','154','1','Tecamachalco'), ('21','154','21','San Mateo Tlaixpan'), ('21','154','27','Santiago Alseseca'), ('21','156','1','Tehuacán'), ('21','156','9','Magdalena Cuayucatepec'), ('21','157','1','Tehuitzingo'), ('21','161','5','San Bartolo Teontepec'), ('21','163','1','Tepatlaxco de Hidalgo'), ('21','164','1','Tepeaca'), ('21','164','12','San Hipólito Xochiltenango'), ('21','164','24','Santiago Acatlán'), ('21','174','1','Teziutlán'), ('21','174','4','Atoluca'), ('21','175','1','Tianguismanalco'), ('21','177','1','Tlacotepec de Benito Juárez'), ('21','177','16','San Marcos Tlacoyalco'), ('21','177','19','Santa María la Alta'), ('21','179','1','Tlachichuca'), ('21','180','1','Santa Rita Tlahuapan'), ('21','181','1','Tlaltenango'), ('21','186','1','Ciudad de Tlatlauquitepec'), ('21','189','1','Tochtepec'), ('21','189','10','San Martín Caltenco'), ('21','191','1','Tulcingo de Valle'), ('21','194','1','Venustiano Carranza'), ('21','194','16','Ciudad de Lázaro Cárdenas'), ('21','197','1','Xicotepec de Juárez'), ('21','197','29','Villa Ávila Camacho (La Ceiba)'), ('21','199','1','San Juan Xiutetelco'), ('21','203','1','Xochitlán'), ('21','205','1','Yehualtepec'), ('21','205','6','San Gabriel Tetzoyocan'), ('21','207','1','Zacapoaxtla'), ('21','208','1','Zacatlán'), ('21','211','1','Zaragoza'), ('21','214','1','San Sebastián Zinacatepec'), ('22','1','1','Amealco de Bonfil'), ('22','4','1','Cadereyta de Montes'), ('22','5','1','Colón'), ('22','5','2','Ajuchitlán'), ('22','6','1','El Pueblito'), ('22','6','17','La Negreta'), ('22','6','44','San José de los Olvera'), ('22','6','142','Venceremos'), ('22','7','1','Ezequiel Montes'), ('22','7','47','Villa Progreso'), ('22','9','1','Jalpan de Serra'), ('22','11','1','La Cañada'), ('22','11','5','Amazcala'), ('22','11','58','Saldarriaga'), ('22','11','439','La Pradera'), ('22','12','1','Pedro Escobedo'), ('22','12','20','La Lira'), ('22','12','31','El Sauz (Sauz Alto, Sauz Bajo)'), ('22','14','1','Santiago de Querétaro'), ('22','14','58','Juriquilla'), ('22','14','101','San José el Alto'), ('22','14','105','San Pedro Mártir'), ('22','14','107','Santa María Magdalena'), ('22','14','108','Santa Rosa Jáuregui'), ('22','16','1','San Juan del Río'), ('22','16','33','La Llave'), ('22','16','70','La Valla'), ('22','16','94','La Estancia'), ('22','17','1','Tequisquiapan'), ('22','17','16','San Nicolás'), ('23','1','1','Cozumel'), ('23','2','1','Felipe Carrillo Puerto'), ('23','3','1','Isla Mujeres'), ('23','4','1','Chetumal'), ('23','4','11','Bacalar'), ('23','4','16','Calderitas'), ('23','5','1','Cancún'), ('23','5','2','Alfredo V. Bonfil'), ('23','5','3','Leona Vicario'), ('23','5','24','Puerto Morelos'), ('23','6','69','José María Morelos'), ('23','7','1','Kantunilkín'), ('23','8','1','Playa del Carmen'), ('23','8','308','Puerto Aventuras'), ('23','9','1','Tulum'), ('23','10','1','Bacalar'), ('23','11','1','Puerto Morelos'), ('23','11','193','Leona Vicario'), ('24','5','1','Cárdenas'), ('24','7','1','Cedral'), ('24','8','1','Cerritos'), ('24','10','1','Ciudad del Maíz'), ('24','11','1','Ciudad Fernández'), ('24','13','1','Ciudad Valles'), ('24','15','1','Charcas'), ('24','16','1','Ebano'), ('24','16','91','Ponciano Arriaga'), ('24','20','1','Matehuala'), ('24','23','1','Rayón'), ('24','24','1','Rioverde'), ('24','25','1','Salinas de Hidalgo'), ('24','27','1','San Ciro de Acosta'), ('24','28','1','San Luis Potosí'), ('24','28','264','La Pila'), ('24','32','1','Santa María del Río'), ('24','34','1','San Vicente Tancuayalab'), ('24','35','1','Soledad de Graciano Sánchez'), ('24','37','1','Tamazunchale'), ('24','40','1','Tamuín'), ('24','42','1','Tanquián de Escobedo'), ('24','43','1','Tierra Nueva'), ('24','45','1','Venado'), ('24','46','1','Villa de Arriaga'), ('24','49','12','Dulce Grande'), ('24','49','43','El Zacatón'), ('24','50','1','Villa de Reyes'), ('24','53','1','Axtla de Terrazas'), ('24','54','1','Xilitla'), ('24','55','1','Villa de Zaragoza'), ('24','56','2','Villa de Arista'), ('24','58','1','El Naranjo'), ('25','1','1','Los Mochis'), ('25','1','70','Ahome'), ('25','1','160','Higuera de Zaragoza'), ('25','1','227','San Miguel Zapotitlán'), ('25','1','240','Topolobampo'), ('25','2','1','Angostura'), ('25','2','93','La Reforma'), ('25','4','1','Concordia'), ('25','5','1','Cosalá'), ('25','6','1','Culiacán Rosales'), ('25','6','312','Costa Rica'), ('25','6','341','Eldorado'), ('25','6','591','Quilá'), ('25','6','746','Adolfo López Mateos (El Tamarindo)'), ('25','6','1346','El Diez'), ('25','7','1','Choix'), ('25','8','1','La Cruz'), ('25','9','1','Escuinapa de Hidalgo'), ('25','9','34','Isla del Bosque'), ('25','10','1','El Fuerte'), ('25','10','58','Constancia'), ('25','10','102','Adolfo López Mateos (Jahuara Segundo)'), ('25','10','133','Mochicahui'), ('25','10','179','San Blas'), ('25','11','1','Guasave'), ('25','11','35','Adolfo Ruiz Cortines'), ('25','11','51','Estación Bamoa (Campo Wilson)'), ('25','11','132','Gabriel Leyva Solano (Benito Juárez)'), ('25','11','138','Juan José Ríos'), ('25','12','1','Mazatlán'), ('25','12','348','Villa Unión'), ('25','12','1257','Fraccionamiento los Ángeles'), ('25','13','1','Mocorito'), ('25','13','235','Pericos'), ('25','14','1','El Rosario'), ('25','15','1','Guamúchil'), ('25','15','40','Benito Juárez'), ('25','17','1','Sinaloa de Leyva'), ('25','17','495','Estación Naranjo'), ('25','18','1','Navolato'), ('25','18','91','General Ángel Flores (La Palma)'), ('25','18','374','Licenciado Benito Juárez (Campo Gobierno)'), ('26','2','1','Agua Prieta'), ('26','3','1','Alamos'), ('26','4','1','Altar'), ('26','12','82','Francisco Javier Mina (Campo 60)'), ('26','16','1','Benjamín Hill'), ('26','17','1','Heroica Caborca'), ('26','18','1','Ciudad Obregón'), ('26','18','284','Cócorit'), ('26','18','311','Esperanza'), ('26','18','334','Marte R. Gómez (Tobarito)'), ('26','18','403','Pueblo Yaqui'), ('26','19','1','Heroica Ciudad de Cananea'), ('26','25','1','Empalme'), ('26','26','1','Etchojoa'), ('26','26','11','Bacobampo'), ('26','27','45','Esqueda'), ('26','29','1','Heroica Guaymas'), ('26','29','202','Pótam'), ('26','29','325','Vícam (Switch)'), ('26','30','1','Hermosillo'), ('26','30','137','Bahía de Kino'), ('26','30','343','Miguel Alemán (La Doce)'), ('26','33','1','Huatabampo'), ('26','35','1','Imuris'), ('26','36','1','Magdalena de Kino'), ('26','39','1','Naco'), ('26','41','1','Nacozari de García'), ('26','42','1','Navojoa'), ('26','43','1','Heroica Nogales'), ('26','47','1','Pitiquito'), ('26','48','1','Puerto Peñasco'), ('26','55','1','San Luis Río Colorado'), ('26','55','17','Ingeniero Luis B. Sánchez'), ('26','56','27','Pesqueira'), ('26','58','1','Santa Ana'), ('26','70','1','Sonoita'), ('26','71','1','Villa Juárez'), ('26','72','1','San Ignacio Río Muerto'), ('27','1','1','Balancán'), ('27','1','74','El Triunfo'), ('27','2','1','Cárdenas'), ('27','2','22','Coronel Andrés Sánchez Magallanes'), ('27','2','24','Poblado C-28 Coronel Gregorio Méndez Magaña'), ('27','2','82','Santa Rosalía (Miguel Hidalgo 2da. Sección)'), ('27','3','1','Frontera'), ('27','3','61','Vicente Guerrero'), ('27','4','1','Villahermosa'), ('27','4','34','Anacleto Canabal 2da. Sección'), ('27','4','65','Buena Vista Río Nuevo 1ra. Sección'), ('27','4','66','Buena Vista Río Nuevo 2da. Sección'), ('27','4','111','Ixtacomitán 1ra. Sección'), ('27','4','123','Luis Gil Pérez'), ('27','4','129','Medellín y Madero 2da. Sección'), ('27','4','134','Medellín y Pigua 3ra. Sección'), ('27','4','145','Parrilla'), ('27','4','146','Guapinol'), ('27','4','160','Río Viejo 1ra. Sección'), ('27','4','166','Playas del Rosario (Subteniente García)'), ('27','4','176','Macultepec'), ('27','4','183','Tamulté de las Sabanas'), ('27','4','206','La Lima'), ('27','4','214','Ocuiltzapotlán'), ('27','4','264','Parrilla II'), ('27','5','1','Comalcalco'), ('27','5','2','Aldama'), ('27','5','20','Chichicapa'), ('27','5','42','Miguel Hidalgo'), ('27','5','66','Tecolutilla'), ('27','6','1','Cunduacán'), ('27','6','44','Once de Febrero 1ra. Sección'), ('27','7','1','Emiliano Zapata'), ('27','8','1','Huimanguillo'), ('27','8','16','Chontalpa (Estación Chontalpa)'), ('27','8','98','La Venta'), ('27','10','1','Jalpa de Méndez'), ('27','10','3','Ayapa'), ('27','11','1','Jonuta'), ('27','12','1','Macuspana'), ('27','12','16','Belén'), ('27','12','18','Benito Juárez (San Carlos)'), ('27','12','39','La Curva'), ('27','12','91','Pemex (Ciudad Pemex)'), ('27','13','1','Nacajuca'), ('27','13','62','Bosque de Saloya'), ('27','13','69','La Selva'), ('27','13','88','Pomoca'), ('27','14','1','Paraíso'), ('27','14','27','Quintín Arauz'), ('27','15','1','Tacotalpa'), ('27','16','1','Teapa'), ('27','17','1','Tenosique de Pino Suárez'), ('28','1','1','Abasolo'), ('28','2','1','Aldama'), ('28','3','1','Altamira'), ('28','3','43','Cuauhtémoc'), ('28','3','122','Miramar'), ('28','7','1','Ciudad Camargo'), ('28','9','1','Ciudad Madero'), ('28','12','1','González'), ('28','12','170','Estación Manuel (Úrsulo Galván)'), ('28','15','1','Ciudad Gustavo Díaz Ordaz'), ('28','16','145','Estación Santa Engracia'), ('28','17','1','Jaumave'), ('28','18','1','Santander Jiménez'), ('28','21','1','Ciudad Mante'), ('28','22','1','Heroica Matamoros'), ('28','25','1','Ciudad Miguel Alemán'), ('28','27','1','Nuevo Laredo'), ('28','27','162','El Campanario y Oradel'), ('28','29','1','Ocampo'), ('28','30','1','Nueva Villa de Padilla'), ('28','32','1','Reynosa'), ('28','33','1','Ciudad Río Bravo'), ('28','33','291','Nuevo Progreso'), ('28','35','1','San Fernando'), ('28','37','1','Soto la Marina'), ('28','38','1','Tampico'), ('28','39','1','Ciudad Tula'), ('28','40','1','Valle Hermoso'), ('28','41','1','Ciudad Victoria'), ('28','43','1','Xicoténcatl'), ('29','1','1','Amaxac de Guerrero'), ('29','5','1','Ciudad de Apizaco'), ('29','5','7','San Luis Apizaquito'), ('29','5','9','Santa Anita Huiloac'), ('29','5','10','Santa María Texcalac'), ('29','6','1','Heroica Ciudad de Calpulalpan'), ('29','7','1','Villa de El Carmen Tequexquitla'), ('29','8','1','Cuapiaxtla'), ('29','10','1','Santa Ana Chiautempan'), ('29','13','1','Huamantla'), ('29','13','16','Ignacio Zaragoza'), ('29','13','44','San José Xicohténcatl'), ('29','15','1','Villa Mariano Matamoros'), ('29','16','1','Ixtenco'), ('29','17','1','Mazatecochco'), ('29','18','1','Contla'), ('29','19','1','Tepetitla'), ('29','19','9','Villa Alta'), ('29','21','1','Ciudad de Nanacamilpa'), ('29','24','1','Panotla'), ('29','25','1','Villa Vicente Guerrero'), ('29','25','2','San Isidro Buen Suceso'), ('29','26','5','San Miguel Contla'), ('29','27','1','Tenancingo'), ('29','28','1','Teolocholco'), ('29','31','1','Tetla'), ('29','31','11','San Francisco Atexcatzinco'), ('29','33','1','Tlaxcala de Xicohténcatl'), ('29','33','8','Ocotlán'), ('29','33','11','San Esteban Tizatlán'), ('29','33','12','San Gabriel Cuauhtla'), ('29','33','15','San Sebastián Atlahapa'), ('29','33','16','Santa María Acuitlapilco'), ('29','33','17','Santa María Ixtulco'), ('29','34','1','Tlaxco'), ('29','35','1','Tocatlán'), ('29','36','1','San Juan Totolac'), ('29','37','1','Zitlaltépec'), ('29','38','2','San Andrés Ahuashuatepec'), ('29','39','1','Xaloztoc'), ('29','41','1','Papalotla'), ('29','42','1','Xicohtzinco'), ('29','43','3','San Benito Xaltocan'), ('29','43','7','Santa Úrsula Zimatepec'), ('29','43','8','San José Tetel'), ('29','44','1','Zacatelco'), ('29','45','1','Benito Juárez'), ('29','48','1','La Magdalena Tlaltelulco'), ('29','49','1','San Damián Texóloc'), ('29','50','1','San Francisco Tetlanohcan'), ('29','52','1','San José Teacalco'), ('29','53','1','San Juan Huactzinco'), ('29','54','1','San Lorenzo Axocomanitla'), ('29','56','1','Santa Ana Nopalucan'), ('29','58','1','Santa Catarina Ayometla'), ('30','3','1','Acayucan'), ('30','6','1','Acultzingo'), ('30','10','1','Altotonga'), ('30','11','1','Alvarado'), ('30','11','3','Antón Lizardo'), ('30','13','1','Naranjos'), ('30','14','1','Amatlán de los Reyes'), ('30','14','16','Peñuela'), ('30','15','1','Ángel R. Cabada'), ('30','16','1','José Cardel'), ('30','21','17','General Miguel Alemán (Potrero Nuevo)'), ('30','22','1','Atzacan'), ('30','26','1','Banderilla'), ('30','28','1','Boca del Río'), ('30','28','37','Veracruz'), ('30','30','1','Ciudad Mendoza'), ('30','32','1','Catemaco'), ('30','34','1','Cerro Azul'), ('30','35','1','Citlaltépec'), ('30','36','1','Coacoatzintla'), ('30','38','1','Coatepec'), ('30','38','19','Tuzamapan'), ('30','39','1','Coatzacoalcos'), ('30','39','21','Allende'), ('30','39','43','Mundo Nuevo'), ('30','39','142','Lomas de Barrillas'), ('30','39','147','Fraccionamiento Ciudad Olmeca'), ('30','40','1','Coatzintla'), ('30','44','1','Córdoba'), ('30','44','47','La Luz Francisco I. Madero (San Román)'), ('30','44','120','El Pueblito (Crucero Nacional)'), ('30','45','1','Cosamaloapan'), ('30','47','1','Coscomatepec de Bravo'), ('30','47','36','Xocotla'), ('30','48','1','Cosoleacaque'), ('30','48','8','Coacotla'), ('30','48','73','Minatitlán'), ('30','48','138','El Naranjito'), ('30','51','1','Coyutla'), ('30','53','1','Cuitláhuac'), ('30','59','1','Chinameca'), ('30','60','1','Chinampa de Gorostiza'), ('30','61','1','Las Choapas'), ('30','62','1','Chocamán'), ('30','65','46','Rinconada'), ('30','65','169','Jacarandas'), ('30','67','1','Filomeno Mata'), ('30','68','1','Fortín de las Flores'), ('30','68','11','Monte Blanco'), ('30','68','32','Córdoba (Santa Leticia)'), ('30','69','1','Gutiérrez Zamora'), ('30','71','1','Huatusco de Chicuellar'), ('30','72','1','Huayacocotla'), ('30','73','22','Juan Díaz Covarrubias'), ('30','77','1','Isla'), ('30','80','1','Ixhuatlán del Café'), ('30','81','2','Unión y Progreso'), ('30','82','1','Ixhuatlán del Sureste'), ('30','85','1','Ixtaczoquitlán'), ('30','85','10','Cuautlapan'), ('30','86','1','Jalacingo'), ('30','87','1','Xalapa-Enríquez'), ('30','87','18','El Castillo'), ('30','87','86','Colonia Santa Bárbara'), ('30','87','87','Lomas Verdes'), ('30','89','1','Jáltipan de Morelos'), ('30','92','1','Xico'), ('30','92','12','San Marcos de León (San Marcos)'), ('30','94','1','Juan Rodríguez Clara'), ('30','97','1','Lerdo de Tejada'), ('30','99','1','Maltrata'), ('30','100','1','Manlio Fabio Altamirano'), ('30','101','18','Palmira'), ('30','102','1','Martínez de la Torre'), ('30','102','30','Independencia'), ('30','103','1','Mecatlán'), ('30','104','1','Mecayapan'), ('30','105','51','Paso del Toro'), ('30','105','74','El Tejar'), ('30','105','271','Fraccionamiento Arboledas San Ramón'), ('30','105','273','Fraccionamiento Puente Moreno'), ('30','108','1','Minatitlán'), ('30','109','1','Misantla'), ('30','111','8','Cuichapa'), ('30','112','1','Naolinco de Victoria'), ('30','115','1','Nogales'), ('30','116','1','Oluta'), ('30','118','1','Orizaba'), ('30','120','1','Oteapan'), ('30','122','1','Pajapan'), ('30','123','1','Pánuco'), ('30','123','29','Moralillo'), ('30','124','1','Papantla de Olarte'), ('30','124','4','Agua Dulce'), ('30','125','1','Paso del Macho'), ('30','126','1','Paso de Ovejas'), ('30','128','1','Perote'), ('30','129','1','Platón Sánchez'), ('30','130','1','Playa Vicente'), ('30','131','1','Poza Rica de Hidalgo'), ('30','132','1','Las Vigas de Ramírez'), ('30','133','1','Cd. Cuauhtémoc'), ('30','133','2','Anáhuac'), ('30','133','7','Hidalgo'), ('30','133','12','Primero de Mayo (Los Mangos)'), ('30','133','17','Benito Juárez'), ('30','134','3','Cabezas'), ('30','135','1','Rafael Delgado'), ('30','135','2','Jalapilla'), ('30','138','1','Río Blanco'), ('30','141','1','San Andrés Tuxtla'), ('30','141','26','Comoapan'), ('30','143','1','Santiago Tuxtla'), ('30','144','1','Sayula de Alemán'), ('30','145','1','Soconusco'), ('30','148','1','Soledad de Doblado'), ('30','149','1','Soteapan'), ('30','150','1','Tamalín'), ('30','151','1','Tamiahua'), ('30','155','1','Tantoyuca'), ('30','160','1','Álamo'), ('30','161','1','Tempoal de Sánchez'), ('30','164','1','Teocelo'), ('30','167','1','Tepetzintla'), ('30','169','1','Villa Azueta'), ('30','172','1','Texistepec'), ('30','173','1','Tezonapa'), ('30','174','1','Tierra Blanca'), ('30','175','1','Tihuatlán'), ('30','175','52','Plan de Ayala'), ('30','175','75','Totolapa'), ('30','178','1','Tlacotalpan'), ('30','181','71','Piedras Negras'), ('30','182','15','Guadalupe Victoria'), ('30','183','1','Tlapacoyan'), ('30','189','1','Túxpam de Rodríguez Cano'), ('30','189','5','Alto Lucero'), ('30','189','83','Santiago de la Peña'), ('30','191','1','Ursulo Galván'), ('30','191','20','Zempoala'), ('30','192','1','Vega de Alatorre'), ('30','192','16','Emilio Carranza'), ('30','193','1','Veracruz'), ('30','193','60','Las Amapolas'), ('30','193','87','Valente Díaz'), ('30','193','217','Fraccionamiento Geovillas los Pinos'), ('30','193','228','Colinas de Santa Fe'), ('30','196','1','Yanga'), ('30','199','1','Zaragoza'), ('30','201','1','Zongolica'), ('30','204','1','Agua Dulce'), ('30','205','1','El Higo'), ('30','206','1','Nanchital de Lázaro Cárdenas del Río'), ('30','207','1','Tres Valles'), ('30','208','1','Carlos A. Carrillo'), ('30','209','1','Tatahuicapan'), ('30','211','1','San Rafael'), ('31','2','1','Acanceh'), ('31','3','1','Akil'), ('31','6','1','Buctzotz'), ('31','7','1','Cacalchén'), ('31','11','1','Celestún'), ('31','13','1','Conkal'), ('31','19','1','Chemax'), ('31','19','63','X-Can'), ('31','21','1','Chichimilá'), ('31','27','1','Dzidzantún'), ('31','29','1','Dzilam González'), ('31','32','1','Espita'), ('31','33','1','Halachó'), ('31','36','1','Homún'), ('31','38','1','Hunucmá'), ('31','40','1','Izamal'), ('31','41','1','Kanasín'), ('31','44','1','Kinchil'), ('31','48','1','Maxcanú'), ('31','50','1','Mérida'), ('31','50','75','Caucel'), ('31','50','84','Cholul'), ('31','52','1','Motul de Carrillo Puerto'), ('31','53','1','Muna'), ('31','56','1','Oxkutzcab'), ('31','57','1','Panabá'), ('31','58','1','Peto'), ('31','59','1','Progreso'), ('31','59','4','Chicxulub (Chicxulub Puerto)'), ('31','67','1','Seyé'), ('31','69','1','Sotuta'), ('31','75','1','Teabo'), ('31','76','1','Tecoh'), ('31','79','1','Tekax de Álvaro Obregón'), ('31','80','1','Tekit'), ('31','84','1','Temax'), ('31','85','1','Temozón'), ('31','89','1','Ticul'), ('31','91','6','Pisté'), ('31','93','1','Tixkokob'), ('31','96','1','Tizimín'), ('31','98','1','Tzucacab'), ('31','101','1','Umán'), ('31','102','1','Valladolid'), ('32','5','1','Víctor Rosales'), ('32','6','1','Cañitas de Felipe Pescador'), ('32','7','1','Concepción del Oro'), ('32','8','1','San Pedro Piedra Gorda'), ('32','10','1','Fresnillo'), ('32','10','210','San José de Lourdes'), ('32','14','1','Nieves'), ('32','17','1','Guadalupe'), ('32','17','39','Tacoaleche'), ('32','19','1','Jalpa'), ('32','20','1','Jerez de García Salinas'), ('32','22','1','Juan Aldama'), ('32','23','1','Juchipila'), ('32','24','1','Loreto'), ('32','25','1','Luis Moya'), ('32','29','1','Miguel Auza'), ('32','32','1','Morelos'), ('32','34','1','Nochistlán de Mejía'), ('32','36','1','Ojocaliente'), ('32','37','16','Pozo de Gamboa'), ('32','38','1','Pinos'), ('32','39','1','Río Grande'), ('32','40','1','Sain Alto'), ('32','42','1','Sombrerete'), ('32','44','1','Tabasco'), ('32','48','1','Tlaltenango de Sánchez Román'), ('32','49','1','Valparaíso'), ('32','51','1','Villa de Cos'), ('32','51','8','González Ortega (Bañón)'), ('32','52','1','Villa García'), ('32','53','1','Villa González Ortega'), ('32','55','1','Villanueva'), ('32','56','1','Zacatecas'), ('32','57','1','Trancoso')";
        //            SqlCommand TablaDentista;
        //            string codigoTablaDentista = "Create table Dentista(ID int identity(1,1) primary key, Cedula char(7) not null unique, RFC char(13) not null unique, Nombre char(40),Direccion char(50),	NumeroExterior char(5),	Pais char(50),	Estado char(40),	Municipio char(50),	Ciudad char(60),	Colonia char(30),	CodigoPostal char(6),	Telefono char(15)); ";
        //            SqlCommand TablaProducto;
        //            string codigoTablaProducto = "Create table Producto(ID int identity(1,1) primary key, Codigo char(5) not null unique, Nombre char(20), Tiempo char(2), Precio int); ";
        //            string codigoInsertProductos = "insert into Producto values('00001','Dentadura','4','10000'),('00002','Puente','7','240000'),('00003','Casquete','5','800')";
        //            SqlCommand TablaMaterial;
        //            string codigoTablaMaterial = "create table Material(Codigo char(5) primary key, Nombre char(20), Precio int, Tiempo char(2)); ";
        //            string codigoInsertMateriales = "insert into Material values('00001','Porcelana','500', '1'), ('00002','Resina','300','1'), ('00003','Oro pulido','15000','2'), ('00004','Porcelana y Resina', '1200', '2'), ('00005','Oro y Porcelana','20000','5'), ('00006', 'Oro Resina Porcelana','25000','7');";
        //            SqlCommand TablaPedido;
        //            string codigoTablaPedido = "Create table Pedido(IDPedido int identity(1,1)primary key, IDDentista int foreign key references Dentista(ID), Estatus char(20) not null, FechaIngreso char(10), FechaCalculada char(10), FechaEntrega char(10), Urgencia char(2),	Fabricante char(40), Total int); ";
        //            SqlCommand TablaProductosPedido;
        //            string codigoTablaProductosPedido = "Create table ProductosPedido( Pedido int foreign key references Pedido(IDPedido), Producto int foreign key references Producto(ID), Material char(5) foreign key references Material(Codigo), Precio int, Cantidad int, SubTotal int); ";
        //            //SqlCommand TablaPedidos;
        //            //string codigoTablaPedidos = "create table Pedidos(Pedido int foreign key references Pedido(IDPedido), FechaIngreso char(10) not null, FechaCalculada char(10) not null, FechaEntrega char(10), Total char(15), Urgente char(2) not null, Estatus char(20),Ubicacion char(30), primary key(Pedido)); ";
        //            SqlCommand procRegistrar;
        //            string codigoprocRegistrar = "create proc procRegistrar @Nombre char(40), @Direccion char(40), @Colonia char(25), @Ciudad char(40), @Municipio char(40), @Estado char(40), @Pais char(40), @CP char(10), @TelCasa char(15), @TelOfi char(15), @TelCel char(15), @Email char(50), @Loginn char(40), @Passwordd char(20), @Apellidos char(40), @Pregunta char(40), @Respuesta char(40), @Activo int, @Departamento char(40) AS \n BEGIN \n" +
        //                "" +
        //                "insert into dbo.Empleados values (@Nombre,@Direccion, @Colonia, @Ciudad, @Municipio, @Estado, @Pais, @CP, @TelCasa, @TelOfi, @TelCel, @Email, @Loginn, @Passwordd, @Apellidos, @Pregunta, @Respuesta, @Activo, @Departamento) \n END";
        //            SqlCommand procRegistrarTarjeta;
        //            string codigoprocRegistrarTarjeta = "create proc procRegistrarTar @Nombre char(40), @NumTar char(40), @BancoTar char(50), @FechaV char(20), @Tipo char(20), @Loginn char(40) as \n Begin \n	insert into Tarjetas values (@Nombre,@NumTar, @BancoTar, @FechaV, @Tipo, @Loginn) \n end";
        //            SqlCommand procActualizarUsuario;
        //            string codigoprocActualizarUsuario = "create proc procActualizarUsuario @Nombre char(40), @Direccion char(40), @Colonia char(25), @Ciudad char(40), @Municipio char(40), @Estado char(40), @Pais char(40), @CP char(10), @TelCasa char(15), @TelOfi char(15), @TelCel char(15), @Email char(50), @Loginn char(40), @Passwordd char(20), @Apellidos char(40), @Pregunta char(40), @Respuesta char(40), @Activo int, @Departamento char(40) as \n begin \n update dbo.Empleados set Empleados.Nombre = @Nombre,Empleados.Direccion = @Direccion, Empleados.Colonia = @Colonia, Empleados.Ciudad = @Ciudad, Empleados.Municipio = @Municipio, Empleados.Estado = @Estado, Empleados.País = @Pais, Empleados.CP = @CP, Empleados.TelCasa = @TelCasa, Empleados.TelOfi = @TelOfi, Empleados.TelCel = @TelCel, Empleados.Email = @Email, Empleados.Loginn = @Loginn,Empleados.Passwordd =@Passwordd, Empleados.Apellidos = @Apellidos, Empleados.Pregunta = @Pregunta, Empleados.Respuesta = @Respuesta, Empleados.Activo = @Activo,  Empleados.Departamento = @Departamento where Empleados.Loginn = @Loginn \n end";
        //            SqlCommand procActualizarTarjeta;
        //            string codigoprocActualizarTarjeta = "create proc procActualizarTarjeta @Nombre char(40), @NumTar char(40), @BancoTar char(50), @FechaV char(20), @Tipo char(20) as \n begin \n update dbo.Tarjetas set Tarjetas.Nombre = @Nombre, Tarjetas.NumTar = @NumTar, Tarjetas.BancoTar = @BancoTar, Tarjetas.FechaV = @FechaV, Tarjetas.Tipo= @Tipo where Tarjetas.NumTar = @NumTar \n end";
        //            SqlCommand procBuscarUsuario;
        //            string codigoprocBuscarUsuario = "create proc procBuscarUsuario @Loginn char(40) as \n Begin \n select * from Empleados where Empleados.Loginn = @Loginn \n end";
        //            SqlCommand procBuscarTarjeta;
        //            string codigoprocBuscarTarjeta = "create proc procBuscarTarjeta @NumTar char(40) as \n Begin \n select Tarjetas.* from Tarjetas where Tarjetas.NumTar = @NumTar  \n end";
        //            SqlCommand procEliminarTarjeta;
        //            string codigoprocEliminarTarjeta = "create proc procEliminarTarjeta  @NumTar char(40) as \n Begin \n delete from Tarjetas where Tarjetas.NumTar = @NumTar \n end";
        //            SqlCommand procEliminarUsuario;
        //            string codigoprocEliminarUsuario = "create proc procEliminarUsuario @Loginn char(40) as \n begin \n update dbo.Empleados set Empleados.Activo = 1 where Empleados.Loginn = @Loginn \n end";
        //            SqlCommand procValidarUsuario;
        //            string codigoprocValidarUsuario = "create proc procValidarUsuario @Loginn char(40), @Passwordd char(20) as \n begin \n update dbo.Empleados set Empleados.Loginn = @Loginn where Empleados.Loginn = @Loginn and Empleados.Passwordd = @Passwordd and Empleados.Activo = 0 \n end";
        //            SqlCommand procRecuperarContraseña;
        //            string codigoprocRecuperarContraseña = "create proc procRecuperarContraseña @Email char(40), @Pregunta char(40), @Respuesta char(40) as \n begin \n select Empleados.* from Empleados where Empleados.Email = @Email and Empleados.Pregunta = @Pregunta and Empleados.Respuesta = @Respuesta \n end";
        //            SqlCommand procUsuariosRegistrados;
        //            string codigoprocUsuariosRegistrados = "create proc procUsuariosRegistrados @Loginn char(40) as \n begin \n select Empleados.* from Empleados \n end";
        //            SqlCommand procTarjetasRegistradas;
        //            string codigoprocTarjetasRegistradas = "create proc procTarjetasRegistradas @Loginn char(40) as \n begin \n select Tarjetas.* from Tarjetas where Tarjetas.Loginn = @Loginn \n end";
        //            SqlCommand procCiudades;
        //            string codigoprocCiudades = "create proc Ciudades  @NombreEstado varchar(50), @NombreMunicipio varchar(40) as \n begin \n  select distinct Ciudad.NombreCiudad from Ciudad, Municipio where  Ciudad.Clave_Municipio = (Select Municipio.Clave_Municipio from Municipio where Municipio.NombreMunicipio = @NombreMunicipio and Municipio.Clave_Estado = (Select Estado.Clave_Estado from Estado where Estado.NombreEstado = @NombreEstado)) and Ciudad.Clave_Estado = (Select Estado.Clave_Estado from Estado where Estado.NombreEstado = @NombreEstado) \n end";
        //            SqlCommand procMunicipios;
        //            string codigoprocMunicipios = "create proc Municipios @ClaveEst numeric(2,0) as \n begin \n select distinct Municipio.NombreMunicipio from Municipio where Municipio.Clave_Estado = @ClaveEst \n end";
        //            SqlCommand procEstados;
        //            string codigoprocEstados = "create proc Estados @ClavePais numeric(5,0) as \n begin \n select distinct Estado.NombreEstado from Estado where Estado.Clave_Pais = @ClavePais \n end";
        //            SqlCommand procPaises;
        //            string codigoprocPaises = "create proc Paises @ClavePais numeric(5,0) as \n begin \n select distinct Pais.NombrePais from Pais \n end";
        //            SqlCommand Clave;
        //            string codigoClave = "create table Clave(NClave char(10) primary key)";
        //            string insertClave = "insert into Clave values('LWP2P')";
        //            string getClave = "create proc getClave @Clave char(10) as \n begin \n select Clave.NClave from Clave \n end";
        //            string checClave = "create proc checClave @Clave char(10) as \n begin \n update Clave set Clave.NClave = @Clave where Clave.NClave = @Clave \n end";
        //            string setClave = "create proc setClave @Clave char(10) as \n begin \n update Clave set Clave.NClave = @Clave \n end";
        //            #endregion
        //            //Procedimientos del dani.
        //            SqlCommand procRegistrarDentista;
        //            string codigoprocRegistrarDentista = "create proc procRegistrarDentista @Cedula char(7), @RFC varchar(13), @Nombre varchar(40), @Direccion varchar(50), @NumeroExterior varchar(5), @Pais varchar(50), @Estado varchar(40), @Municipio varchar(50), @Ciudad varchar(60), @Colonia varchar(30), @CodigoPostal varchar(6), @Telefono varchar(15) as BEGIN insert into dbo.Dentista values (@Cedula, @RFC, @Nombre, @Direccion, @NumeroExterior, @Pais, @Estado, @Municipio, @Ciudad, @Colonia, @CodigoPostal, @Telefono) END";
        //            SqlCommand getCedulas;
        //            string codigogetCedulas = "create proc getCedulas as \n begin \n select Dentista.Cedula from Dentista \n end";
        //            SqlCommand procProductos;
        //            string codigoprocProductos = "create proc procProductos as \n begin \n select Producto.* from dbo.Producto \n end";
        //            SqlCommand procDatosDentista;
        //            string codigoprocDatosDentista = "create proc procDatosDentista @Cedula varchar(7) as \n begin \n select Dentista.* from Dentista where Cedula = @Cedula \n end";
        //            SqlCommand procActualizarDentista;
        //            string codigoprocActualizarDentista = "create proc procActualizarDentista @Cedula varchar(7), @RFC varchar(13), @Nombre varchar(40), @Direccion varchar(50), @NumeroExterior varchar(5), @Pais varchar(50), @Estado varchar(40), @Municipio varchar(50), @Ciudad varchar(60), @Colonia varchar(30), @CodigoPostal varchar(6), @Telefono varchar(15), @CedulaVieja varchar(7)as \n "
        //                    + "begin \n update dbo.Dentista set Dentista.Cedula = @Cedula, Dentista.RFC= @RFC, Dentista.Nombre = @Nombre," +
        //                    " Dentista.Direccion = @Direccion, Dentista.NumeroExterior = @NumeroExterior, Dentista.Pais = @Pais, Dentista.Estado = @Estado," +
        //                    " Dentista.Municipio = @Municipio, Dentista.Ciudad = @Ciudad, Dentista.Colonia = @Colonia, Dentista.CodigoPostal= @CodigoPostal," +
        //                    " Dentista.Telefono = @Telefono where Dentista.Cedula = @CedulaVieja \n End";
        //            SqlCommand getUltimoDentista;
        //            string codigogetUltimoDentista = "create proc getUltimoDentista as \n begin \n select ID from Dentista end";
        //            SqlCommand getMateriales;
        //            string codigogetMateriales = "create proc getMateriales as begin select * from Material end";
        //            SqlCommand getUltimoPedido;
        //            string codigogetUltimoPedido = "create proc getUltimoPedido as begin select max(IDPedido) as Ultimo from Pedido end";
        //            SqlCommand getPrecioProducto;
        //            string codigogetPrecioProducto = "create proc getPrecioProducto @Nombre char(20) as begin select * from Producto where Nombre = @Nombre end";
        //            SqlCommand getPrecioMaterial;
        //            string codigogetPrecioMaterial = "create proc getPrecioMaterial @Nombre char(20) as begin select * from Material where Nombre = @Nombre end";
        //            SqlCommand procCrearPedido;
        //            string codigoprocCrearPedido = "create proc procCrearPedido @Dentista int, @Estatus char(20) as begin insert into Pedido values (@Dentista, @Estatus, null, null, null, null, null, null) end";
        //            SqlCommand procInsertarProducto;
        //            string codigoprocInsertarProducto = "create proc procInsertarProducto @Pedido int, @Producto int, @Material char(5), @Precio int, @Cantidad int, @SubTotal int as begin insert into ProductosPedido values(@Pedido, @Producto, @Material, @Precio, @Cantidad, @SubTotal) end";
        //            SqlCommand getProductosPedido;
        //            string codigogetProductosPedido = "create proc getProductosPedido @Pedido int as begin select Producto.Codigo, Producto.Nombre, Material.Nombre as Material, Cantidad, ProductosPedido.Precio, SubTotal from ProductosPedido, Producto, Material where Pedido = @Pedido and ProductosPedido.Producto = ID and ProductosPedido.Material = Material.Codigo end";
        //            SqlCommand procSacarProducto;
        //            string codigoprocSacarProducto = "create proc procSacarProducto @Pedido int, @Codigo int, @Material char(5), @Cantidad int, @Precio int, @SubTotal int as begin delete ProductosPedido from ProductosPedido where Pedido = @Pedido and Producto = @Codigo and Material = @Material and Cantidad = @Cantidad and Precio = @Precio and SubTotal = @SubTotal end";
        //            SqlCommand procGenerarPedido;
        //            string codigoprocGenerarPedido = "create proc procGenerarPedido @Pedido int, @Dentista int, @Estatus char(20), @FechaIngreso char(10), @FechaCalculada char(10), @FechaEntrega char(10), @Urgencia char(20), @Fabricante char(40), @Total int as begin update Pedido set Pedido.Estatus = @Estatus, Pedido.FechaIngreso = @FechaIngreso, FechaCalculada = @FechaCalculada, Urgencia = @Urgencia, Fabricante = @Fabricante, Total = @Total where IDPedido = @Pedido and IDDentista = @Dentista end";
        //            SqlCommand getPedidos;
        //            string codigogetPedidos = "create proc getPedidos as begin select Pedido.IDPedido, Dentista.Nombre, Pedido.Estatus, Pedido.FechaIngreso, Pedido.FechaCalculada, Pedido.Fabricante from Pedido, Dentista where Pedido.IDDentista = Dentista.ID end";
        //            SqlCommand getIDProducto;
        //            string codigogetIDProducto = "create proc getIDProducto @Codigo char(5) as begin select ID from Producto where Codigo = @Codigo end";
        //            SqlCommand getCodigoMaterial;
        //            string codigogetCodigoMaterial = "create proc getCodigoMaterial @Nombre char(20) as begin select Codigo from Material where Nombre = @Nombre end";
        //            SqlCommand selectIDDentista;
        //            string codigoselectIDDentista = "create proc selectIDDentista @IDPedido int as begin select IDDentista from Pedido where IDPedido = @IDPedido end";
        //            SqlCommand selectNombreCedula;
        //            string codigoselectNombreCedula = "create proc selectNombreCedula @IDPedido int as begin select Dentista.Cedula, Dentista.Nombre from Dentista, Pedido where Pedido.IDPedido = @IDPedido and Pedido.IDDentista = Dentista.ID end";
        //            SqlCommand selectPedido;
        //            string codigoselectPedido = "create proc selectPedido @IDPedido int as begin select * from Pedido where IDPedido = @IDPedido end";
        //            SqlCommand BorrarPedido;
        //            string codigoBorrarPedido = "create proc EliminarPedido @IDPedido int as begin delete ProductosPedido where Pedido = @IDPedido; delete Pedido where IDPedido = @IDPedido end";
        //            SqlCommand getTiempos;
        //            string codigogetTiempos = "create proc getTiempos @Pedido int as begin select Producto.Tiempo as PTiempo, Material.Tiempo as MTiempo from ProductosPedido, Producto, Material where Pedido = @Pedido and Material = Material.Codigo and Producto = Producto.ID end";

        //            SqlCommand TablaFacturas;
        //            string codigoTablaFacturas = @"

        //    create table Facturas (
        //        Factura int identity(1,1) primary key,
        //        Pedido int foreign key references Pedido(IDPedido),
        //    FechaEmision char(10),
        //        Nombre char(40),
        //        RFC char(13),
        //        Cedula char(7),
        //        Direccion char(50),
        //        Pais char(50),
        //    Estado char(40),
        //        Municipio char(50),
        //        Ciudad char(60),
        //        Colonia char(30),
        //        CodigoPostal char(6),
        //        Telefono char(15),
        //    constraint U_Pedido Unique(Pedido)
        //    );";
        //            SqlCommand TablaComentarioNota;
        //            string codigoTablaComentarioNota = @"create table ComentarioNota (
        //        IDPedido int foreign key references Pedido(IDPedido),
        //        Comentario char(1000)
        //    );";
        //            SqlCommand FacturaYReportes;

        //            #region cosas sin interes;
        //            cnn2.Open();
        //            string ser = "SELECT @@SERVERNAME AS 'Server Name'";
        //            servidor = new SqlCommand(ser, cnn2);
        //            TablaDentista = new SqlCommand(codigoTablaDentista, cnn2);
        //            try { TablaDentista.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaProducto = new SqlCommand(codigoTablaProducto, cnn2);
        //            try { TablaProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaProducto = new SqlCommand(codigoInsertProductos, cnn2);
        //            try { TablaProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaMaterial = new SqlCommand(codigoTablaMaterial, cnn2);
        //            try { TablaMaterial.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaMaterial = new SqlCommand(codigoInsertMateriales, cnn2);
        //            try { TablaMaterial.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaPedido = new SqlCommand(codigoTablaPedido, cnn2);
        //            try { TablaPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaProductosPedido = new SqlCommand(codigoTablaProductosPedido, cnn2);
        //            try { TablaProductosPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            //TablaPedidos = new SqlCommand(codigoTablaPedidos, cnn2);
        //            //try { TablaPedidos.ExecuteNonQuery(); } catch (Exception) { };

        //            procRegistrarDentista = new SqlCommand(codigoprocRegistrarDentista, cnn2);
        //            try { procRegistrarDentista.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            getCedulas = new SqlCommand(codigogetCedulas, cnn2);
        //            try { getCedulas.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procProductos = new SqlCommand(codigoprocProductos, cnn2);
        //            try { procProductos.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procDatosDentista = new SqlCommand(codigoprocDatosDentista, cnn2);
        //            try { procDatosDentista.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procActualizarDentista = new SqlCommand(codigoprocActualizarDentista, cnn2);
        //            try { procActualizarDentista.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getUltimoDentista = new SqlCommand(codigogetUltimoDentista, cnn2);
        //            try { getUltimoDentista.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getMateriales = new SqlCommand(codigogetMateriales, cnn2);
        //            try { getMateriales.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getUltimoPedido = new SqlCommand(codigogetUltimoPedido, cnn2);
        //            try { getUltimoPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getPrecioProducto = new SqlCommand(codigogetPrecioProducto, cnn2);
        //            try { getPrecioProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getPrecioMaterial = new SqlCommand(codigogetPrecioMaterial, cnn2);
        //            try { getPrecioMaterial.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procCrearPedido = new SqlCommand(codigoprocCrearPedido, cnn2);
        //            try { procCrearPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procInsertarProducto = new SqlCommand(codigoprocInsertarProducto, cnn2);
        //            try { procInsertarProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getProductosPedido = new SqlCommand(codigogetProductosPedido, cnn2);
        //            try { getProductosPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procSacarProducto = new SqlCommand(codigoprocSacarProducto, cnn2);
        //            try { procSacarProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            procGenerarPedido = new SqlCommand(codigoprocGenerarPedido, cnn2);
        //            try { procGenerarPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getPedidos = new SqlCommand(codigogetPedidos, cnn2);
        //            try { getPedidos.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getIDProducto = new SqlCommand(codigogetIDProducto, cnn2);
        //            try { getIDProducto.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getCodigoMaterial = new SqlCommand(codigogetCodigoMaterial, cnn2);
        //            try { getCodigoMaterial.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            selectIDDentista = new SqlCommand(codigoselectIDDentista, cnn2);
        //            try { selectIDDentista.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            selectNombreCedula = new SqlCommand(codigoselectNombreCedula, cnn2);
        //            try { selectNombreCedula.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            selectPedido = new SqlCommand(codigoselectPedido, cnn2);
        //            try { selectPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            BorrarPedido = new SqlCommand(codigoBorrarPedido, cnn2);
        //            try { BorrarPedido.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            getTiempos = new SqlCommand(codigogetTiempos, cnn2);
        //            try { getTiempos.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaFacturas = new SqlCommand(codigoTablaFacturas, cnn2);
        //            try { TablaFacturas.ExecuteNonQuery(); }
        //            catch (Exception) { };
        //            TablaComentarioNota = new SqlCommand(codigoTablaComentarioNota, cnn2);
        //            try { TablaComentarioNota.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procRegistrarDatosFactura  @NoPedido int, @FechaEmision char(10),@Nombre char(40),@RFC char(13), @Cedula char(7), @Direccion char(50), @Pais char(50), @Estado char(40), @Municipio char(50), @Ciudad char(60), @Colonia char(30), @CodPos char(6), @Telefono char(15)
        //    as
        //    begin
	       //     if not exists (select top 1 * from Facturas where Pedido = @NoPedido)
        //        update Pedido set Estatus = 'FACTURADO' where IDPedido = @NoPedido
	       //     insert into dbo.Facturas([Pedido],[FechaEmision],[Nombre],[RFC],[Cedula],[Direccion],[Pais],[Estado],[Municipio],[Ciudad],[Colonia],[CodigoPostal],[Telefono])
	       //     values(@NoPedido,@FechaEmision,@Nombre,@RFC, @Cedula, @Direccion, @Pais, @Estado, @Municipio, @Ciudad, @Colonia, @CodPos, @Telefono)
        //    end ", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procModificarDatosFactura @NoPedido int,@FechaEmision char(10), @Nombre char(40),@RFC char(13), @Cedula char(7), @Direccion char(50), @Pais char(50), @Estado char(40), @Municipio char(50), @Ciudad char(60), @Colonia char(30), @CodPos char(6), @Telefono char(15)
        //    as
        //    begin
        //    update Pedido set Estatus = 'FACTURADO' where IDPedido = @NoPedido
        //    update dbo.Facturas set Nombre=@Nombre, FechaEmision =@FechaEmision,RFC= @RFC, Cedula=@Cedula, Direccion=@Direccion, Pais=@Pais, Estado=@Estado, Municipio=@Municipio, Ciudad=@Ciudad, Colonia=@Colonia, CodigoPostal= @CodPos,Telefono =@Telefono where Pedido= @NoPedido
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procLlenarFactura @Pedido int as 
        //    begin 
		      //      select * from Facturas where Pedido = @Pedido 
        //    end", cnn2);

        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procMostrarPedido as 
        //    begin	
        //        select Pedido.IDPedido,Dentista.Nombre, Dentista.Direccion, Dentista.Telefono, Pedido.Estatus  
        //        from Dentista, Pedido where Dentista.ID= Pedido.IDDentista 
        //    end", cnn2);

        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procFacturar @IDPedido int as 
        //    begin 
	       //     select Pedido.IDPedido,Dentista.Cedula, Dentista.RFC, Dentista.Nombre, 
		      //      Dentista.Direccion, Dentista.Pais, Dentista.Estado,Dentista.Municipio, Dentista.Ciudad, 
		      //      Dentista.Colonia, Dentista.CodigoPostal, Dentista.Telefono from Dentista, Pedido where  Dentista.ID = Pedido.IDDentista and Pedido.IDPedido = @IDPedido 
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procProductosFacturar @IDPedido int as 
        //    begin
        //        select Producto.Codigo, Producto.Nombre as NombreProducto, Material.Nombre as Material,ProductosPedido.Cantidad,
        //        ProductosPedido.Precio,ProductosPedido.SubTotal from ProductosPedido, Producto, Material, Pedido where 
        //    Pedido.IDPedido = ProductosPedido.Pedido and Pedido.IDPedido= @IDPedido and ProductosPedido.Producto = Producto.ID and ProductosPedido.Material = Material.Codigo 
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procProductosFacturar2 @Pedido int as 
        //    begin
        //        select Producto.Codigo, Producto.Nombre as NombreProducto, Material.Nombre as Material,ProductosPedido.Cantidad,
        //        ProductosPedido.Precio,ProductosPedido.SubTotal from ProductosPedido, Producto, Material, Pedido where 
        //    Pedido.IDPedido = ProductosPedido.Pedido and Pedido.IDPedido= @Pedido and ProductosPedido.Producto = Producto.ID and ProductosPedido.Material = Material.Codigo 
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procBuscarFactura @IDPedido int, @NoFactura int
        //    as
        //    begin
	       //     select * from Facturas where Pedido = @IDPedido or Factura = @NoFactura
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procCrearFactura @IDPedido int
        //    as
        //    begin
	       //     if not exists (select top 1 * from Facturas where Pedido = @IDPedido)
		      //      insert Facturas (Facturas.Pedido)  values (@IDPedido)
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procBuscarPorPedido @IDPedido int, @NombreDent char(20)
        //    as
        //    begin
	       //     select IDPedido, Nombre, Direccion, Telefono, Estatus
	       //     from Pedido, Dentista where IDDentista = ID and (IDPedido = @IDPedido or (Nombre like IsNull(@NombreDent+'%', ''))) order by IDPedido asc
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procBuscarPorFactura @NoFactura int, @NoPedido int
        //    as
        //    begin
        //    select IDPedido,Factura, Dentista.Nombre, FechaEmision
	       //     from Pedido, Dentista, Facturas where Pedido.IDDentista = Dentista.ID and Pedido.IDPedido = Facturas.Pedido and (Facturas.Factura = @NoFactura or Facturas.Pedido = @NoPedido) order by Pedido.IDPedido asc
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procVerFacturas as begin
        //    select Facturas.Factura,Pedido.IDPedido,Dentista.Nombre, Facturas.FechaEmision from Facturas,Pedido, Dentista
		      //      where Pedido.IDPedido = Facturas.Pedido and Dentista.ID = Pedido.IDDentista	
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@"
        //    create proc procReportes as begin
        //    select ProductosPedido.Pedido, ProductosPedido.Producto,Pedido.Estatus, Producto.Nombre, Dentista.Nombre, Dentista.Direccion, Dentista.Telefono
        //    from ProductosPedido,Producto, Dentista, Pedido
        //    where ProductosPedido.Pedido = Pedido.IDPedido and ProductosPedido.Producto = Producto.ID and Dentista.ID=Pedido.IDDentista
        //    end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@" create proc procRegistrarComentario @IDPedido int, @Comentario char(1000) as
        //        begin  delete from ComentarioNota where IDPedido = @IDPedido
        //        insert into ComentarioNota values(@IDPedido,@Comentario) end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };

        //            FacturaYReportes = new SqlCommand(@" create proc procMostrarDatosNota @IDPedido int as
        //    begin select Pedido.IDPedido, Dentista.Nombre, Dentista.RFC, Dentista.Direccion, Dentista.Telefono, Pedido.FechaEntrega, (Select Comentario 
	       //     From ComentarioNota Where ComentarioNota.IDPedido = @IDPedido) as 'Comentario' from Pedido, Dentista
	       //     Where Pedido.IDDentista = Dentista.ID And Pedido.IDPedido = @IDPedido end", cnn2);
        //            try { FacturaYReportes.ExecuteNonQuery(); }
        //            catch (Exception) { };


        //            Clave = new SqlCommand(codigoClave, cnn2);
        //            try { Clave.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Clave = new SqlCommand(insertClave, cnn2);
        //            try { Clave.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Clave = new SqlCommand(getClave, cnn2);
        //            try { Clave.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Clave = new SqlCommand(setClave, cnn2);
        //            try { Clave.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Clave = new SqlCommand(checClave, cnn2);
        //            try { Clave.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            tablaEmpleados = new SqlCommand(codigoEmpleados, cnn2);
        //            try { tablaEmpleados.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            tablaEmpleados = new SqlCommand(insertAdmin, cnn2);
        //            try { tablaEmpleados.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            tablaTarjetas = new SqlCommand(codigoTarjetas, cnn2);
        //            try { tablaTarjetas.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            Paises = new SqlCommand(codigoPaises, cnn2);
        //            try { Paises.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Paises = new SqlCommand(insertPaises, cnn2);
        //            try { Paises.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            Estado = new SqlCommand(codigoEstado, cnn2);
        //            try { Estado.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Estado = new SqlCommand(insertEstado, cnn2);
        //            try { Estado.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            Municipio = new SqlCommand(codigoMunicipio, cnn2);
        //            try { Municipio.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Municipio = new SqlCommand(insertMunicipio, cnn2);
        //            try { Municipio.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Municipio = new SqlCommand(insertMunicipio2, cnn2);
        //            try { Municipio.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            Ciudad = new SqlCommand(codigoCiudad, cnn2);
        //            try { Ciudad.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Ciudad = new SqlCommand(insertCiudad, cnn2);
        //            try { Ciudad.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            Ciudad = new SqlCommand(insertCiudad2, cnn2);
        //            try { Ciudad.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            procRegistrar = new SqlCommand(codigoprocRegistrar, cnn2);
        //            try { procRegistrar.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procRegistrarTarjeta = new SqlCommand(codigoprocRegistrarTarjeta, cnn2);
        //            try { procRegistrarTarjeta.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procActualizarTarjeta = new SqlCommand(codigoprocActualizarTarjeta, cnn2);
        //            try { procActualizarTarjeta.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procActualizarUsuario = new SqlCommand(codigoprocActualizarUsuario, cnn2);
        //            try { procActualizarUsuario.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procBuscarTarjeta = new SqlCommand(codigoprocBuscarTarjeta, cnn2);
        //            try { procBuscarTarjeta.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procBuscarUsuario = new SqlCommand(codigoprocBuscarUsuario, cnn2);
        //            try { procBuscarUsuario.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procEliminarTarjeta = new SqlCommand(codigoprocEliminarTarjeta, cnn2);
        //            try { procEliminarTarjeta.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procEliminarUsuario = new SqlCommand(codigoprocEliminarUsuario, cnn2);
        //            try { procEliminarUsuario.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procRecuperarContraseña = new SqlCommand(codigoprocRecuperarContraseña, cnn2);
        //            try { procRecuperarContraseña.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procTarjetasRegistradas = new SqlCommand(codigoprocTarjetasRegistradas, cnn2);
        //            try { procTarjetasRegistradas.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procUsuariosRegistrados = new SqlCommand(codigoprocUsuariosRegistrados, cnn2);
        //            try { procUsuariosRegistrados.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procValidarUsuario = new SqlCommand(codigoprocValidarUsuario, cnn2);
        //            try { procValidarUsuario.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procCiudades = new SqlCommand(codigoprocCiudades, cnn2);
        //            try { procCiudades.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procEstados = new SqlCommand(codigoprocEstados, cnn2);
        //            try { procEstados.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procMunicipios = new SqlCommand(codigoprocMunicipios, cnn2);
        //            try { procMunicipios.ExecuteNonQuery(); }
        //            catch (Exception) { }
        //            procPaises = new SqlCommand(codigoprocPaises, cnn2);
        //            try { procPaises.ExecuteNonQuery(); }
        //            catch (Exception) { }

        //            //Jesus Tablas
        //            SqlCommand Codigos;
        //            List<string> codigos = new List<string>();

        //            codigos.Add("create proc procAgregarPieza @CodPieza char(5), @NombrePieza char(20), @TiempoFab char(2), @Precio int as begin     insert into dbo.Producto values(@CodPieza, @NombrePieza, @TiempoFab, @Precio) end");
        //            codigos.Add("create proc procAgregarMaterial @Codigo char(5), @Nombre char(20), @Precio int, @Tiempo char(2) as begin insert into dbo.Material values(@Codigo, @Nombre, @Precio, @Tiempo) end");
        //            codigos.Add("create proc procActualizarPieza @CodPieza char(5), @NombrePieza char(20), @TiempoFab char(2), @Precio int as begin update dbo.Producto set Producto.Codigo = @CodPieza, Producto.Nombre = @NombrePieza, Producto.Tiempo = @TiempoFab, Producto.Precio = @Precio where Producto.CodPieza = @CodPieza end");
        //            codigos.Add("create proc procActualizarMaterial @CodMaterial char(5), @NombreMat char(20), @Precio int, @Tiempo char(2) as begin update dbo.Material set Material.Codigo = @CodMaterial, Material.Nombre = @NombreMat, Material.Precio = @Precio, Material.Tiempo = @Tiempo where Material.Codigo = @CodMaterial end");
        //            codigos.Add("create proc procEditarPieza @CodPieza char(5) as begin     select * from Producto where Producto.Codigo = @CodPieza end");
        //            codigos.Add("create proc procEditarMaterial @CodMaterial char(5) as begin select * from Material where Material.Codigo = @CodMaterial end");
        //            codigos.Add("create proc procPiezas @CodPieza char(5) as begin select * from Producto end");
        //            codigos.Add("create proc procMateriales @CodMaterial char(5) as begin select * from Material end");
        //            codigos.Add("create proc procEliminarPieza @CodPieza char(5) as begin delete from Producto where Producto.Codigo = @CodPieza end");
        //            codigos.Add("create proc procEliminarMaterial @CodMaterial char(5) as begin delete from Material where Material.Codigo = @CodMaterial end");
        //            codigos.Add("create proc procMostrarPedidos @CodPedido varchar(5) as begin select Pedido.*, Pedidos.Producto from Pedido, Pedidos where Pedidos.Pedido = Pedido.ID end");

        //            codigos.Add("create proc procCambiarEstado @CodPedido varchar(5), @Estado varchar(20) as begin update Pedido set Pedido.Estatus = @Estado where Pedido.IDPedido = @CodPedido end");
        //            codigos.Add("create proc procCambiarLab @CodPedido varchar (5), @Laboratorista varchar(30) as begin     update Pedido set Pedido.Fabricante = @Laboratorista where Pedido.IDPedido = @CodPedido end");
        //            codigos.Add("create proc getTodosProductosPedido @Pedido varchar(5) as begin select Pedido.IDPedido, Pedido.IDDentista, Pedido.Estatus, Pedido.FechaIngreso, Pedido.FechaCalculada, Pedido.Fabricante, Pedido.Urgencia from Pedido end");
        //            codigos.Add("create proc procPedidoUrgente @Pedido varchar(5), @Urgente varchar(2) as begin update Pedido set Pedido.Urgente = @Urgencia where Pedido.IDPedido = @Pedido end");
        //            codigos.Add("create proc procDepartamento @Loginn char(40) as begin select Empleados.Departamento from Empleados where Empleados.Loginn = @Loginn end");
        //            codigos.Add("create proc Laboratorista @Departamento char(40) as begin select Empleados.Loginn from Empleados where Empleados.Departamento = @Departamento end");
        //            codigos.Add("create proc ObtenerPedido @Pedido varchar(5) as begin select Pedido.IDPedido, Pedido.IDDentista, Pedido.Estatus, Pedido.FechaIngreso, Pedido.FechaCalculada, Pedido.Fabricante, Pedido.Urgencia from Pedido where Pedido.IDPedido = @Pedido end");
        //            codigos.Add("insert into Empleados values ('Daniel', 'Calle','Colonia','La Paz','La Paz','Baja California Sur','México','12345','125-3434','123-4656','(612)-754-7852','daniel@gmail.com','Avalos','Avalos123','Avalos','Color Favorito','Rojo',0, 'Recepción')");
        //            codigos.Add("insert into Empleados values ('Maribel', 'Calle','Colonia','La Paz','La Paz','Baja California Sur','México','12345','125-3434','123-4656','(612)-754-7852','maribel@gmail.com','MaribelG','Maribel123','Montes','Color Favorito','Rojo',0, 'Contabilidad')");
        //            codigos.Add("insert into Empleados values ('Jesus', 'Calle','Colonia','La Paz','La Paz','Baja California Sur','México','12345','125-3434','123-4656','(612)-754-7852','jesus@gmail.com','JesusM','Jesus123','León','Color Favorito','Rojo',0, 'Laboratorio')");
        //            for (int i = 0; i < codigos.Count; i++)
        //            {
        //                Codigos = new SqlCommand(codigos[i], cnn2);
        //                try { Codigos.ExecuteNonQuery(); }
        //                catch (Exception ms)
        //                {


        //                }
        //            }

        //            SqlDataReader Cmrd;
        //            try
        //            {
        //                Cmrd = servidor.ExecuteReader();
        //                Cmrd.Read();
        //            }
        //            catch (Exception) { }

        //        }
        //        catch (Exception)
        //        {
        //        }
        //        cnn2.Close();
        //        #endregion;
        //    }
        //}

    }
}