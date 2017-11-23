using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Entidad;

namespace DiseñoFinal
{

    public class InterfaceUsuario
    {
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroTarjeta mart = new ManejadorRegistroTarjeta();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        ManejadorRegistroDentista marr = new ManejadorRegistroDentista();
        ManejadorReportes mar = new ManejadorReportes();
        ManejadorFacturas maf = new ManejadorFacturas();
        ManejadorPrincipal manp = new ManejadorPrincipal();
        public bool EsAdmin = false;
        Form llamada = new Form();

        public InterfaceUsuario(Form llamada)
        {
            this.llamada = llamada;
        }

        public void enviarEvento(string Evento, string[] Datos)
        {
            if (Evento == "Urgente")
            {
                if (mancp.Urgente(Datos) > 0)
                {
                    MessageBox.Show("Pedido " + Datos[0] + " marcado como urgente");
                }
            }
            if (Evento == "CambiarLab")
            {
                if (mancp.CambiarLab(Datos) > 0)
                {
                    MessageBox.Show("Laboratorista Actualizado");
                }
            }
            if (Evento == "CambiarEstado")
            {
                if (mancp.CambiarEstado(Datos) > 0)
                {
                    MessageBox.Show("Estado Actualizado");
                }
            }
            if (Evento == "BorrarPieza")
            {
                if (mancp.BorrarPieza(Datos) > 0)
                {
                    MessageBox.Show("Pieza Borrada");
                }
            }
            if (Evento == "BorrarMaterial")
            {
                if (mancp.BorrarMaterial(Datos) > 0)
                {
                    MessageBox.Show("Material Borrado");
                }
            }
           
            if (Evento == "AgregarPieza")
            {
                if (mancp.AgregarDatosPieza(Datos) > 0)
                {
                    MessageBox.Show("Pieza Registrada");
                }
            }
            if (Evento == "AgregarMaterial")
            {
                if (mancp.AgregarDatosMaterial(Datos) > 0)
                {
                    MessageBox.Show("Material Registrado");
                }

            }
            if (Evento == "ActualizarPieza")
            {
                if (mancp.ActualizarPieza(Datos) > 0)
                {
                    MessageBox.Show("Pieza Actualizada");
                }
            }
            if (Evento == "ActualizarMaterial")
            {
                if (mancp.ActualizarMaterial(Datos) > 0)
                {
                    MessageBox.Show("Material Actualizado");
                }
            }
            if (Evento == "PantallaActualizarPieza")
            {
                EditarPieza edpie = new EditarPieza();

                DataTable datosPieza = new DataTable();
                datosPieza = mancp.EditarPieza(Datos);
                edpie.DatosTabla(datosPieza);                
                edpie.ShowDialog();
            }
            if (Evento == "PantallaActualizarMaterial")
            {
                EditarMaterial edmat = new EditarMaterial();

                DataTable datosMaterial = new DataTable();
                datosMaterial = mancp.EditarMaterial(Datos);
                edmat.DatosTabla(datosMaterial);
                edmat.ShowDialog();

            }
            if (Evento == "PantallaAgregarPieza")
            {
                AgregarPieza apie = new AgregarPieza();
                apie.ShowDialog();
            }
            if (Evento == "PantallaAgregarMaterial")
            {
                AgregarMaterial amat = new AgregarMaterial();
                amat.ShowDialog();
            }
            if (Evento == "MenuLaboratorio")
            {
                MenuLaboratorio menulab = new MenuLaboratorio(Datos[0], llamada);
                desplegarPantalla(menulab);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaFabricarProducto")
            {
                FabricarProducto fabp = new FabricarProducto(Datos[0], llamada);
                var datosPedidos = new DataTable();
                datosPedidos = mancp.ObtenerDatosPedido(Datos);
                fabp.DatosTabla(datosPedidos);
                desplegarPantalla(fabp);
                cerrarPantalla(llamada);
            }

            if (Evento == "PantallaSemaforo")
            {
                string Dep = "";
                var Departamento = new DataTable();
                Departamento = maru.Departamento(Datos);
                foreach (DataRow fila in Departamento.Rows)
                { Dep = fila["Departamento"].ToString(); }

                ControlPedidos conp = new ControlPedidos(Datos[0], Dep, llamada);
                var datosPedidos = new DataTable();
                datosPedidos = mancp.ObtenerDatosPedido(Datos);
                conp.DatosTabla(datosPedidos);
                desplegarPantalla(conp);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaMateriales")
            {
                Materiales mat = new Materiales(llamada);

                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosMateriales(Datos);
                mat.DatosData(datosPiezas);

                desplegarPantalla(mat);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaPiezas")
            {
                Piezas piezas = new Piezas(llamada);

                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                piezas.DatosData(datosPiezas);

                desplegarPantalla(piezas);
                cerrarPantalla(llamada);
            }
            if (Evento== "ActClave" )
            {
                if (manp.setClaveRegistro(Datos))
                {
                    MessageBox.Show("Se actualizó la clave de registro");
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm.GetType() == typeof(Menú_Admin))
                        {
                            frm.Show();
                        }
                    }
                    llamada.Close();
                }                
            }
            if(Evento == "RegistrardesdeAdmin")
            {
                Registro_Usuario regu = new Registro_Usuario("admin");
                desplegarPantalla(regu);
                cerrarPantalla(llamada);
            }
            if (Evento == "Acceder")
            {
                if (manp.checClave(Datos) > 0)
                {
                    Registro_Usuario regu = new Registro_Usuario();
                    desplegarPantalla(regu);
                }
                else { MessageBox.Show("La clave de registro es Incorrecta"); }                
                
            }
            if (Evento == "Registrarse")
            {
                ClaveRegistro clave = new ClaveRegistro();
                desplegarPantalla(clave);
                cerrarPantalla(llamada);
            } 
            if (Evento == "EntrarAdmin")
            {
                Menú_Admin menuad = new Menú_Admin();
                desplegarPantalla(menuad);
                cerrarPantalla(llamada);
            }
            if (Evento == "Ingresar")
            {
                if (maru.ValidarUsuario(Datos) > 0)
                {
                    string Dep = "";
                    var Departamento = new DataTable();
                    Departamento = maru.Departamento(Datos);
                    foreach (DataRow fila in Departamento.Rows)
                    { Dep = fila["Departamento"].ToString(); }

                    Program.Departamento = Dep.TrimEnd();
                    Program.Loginn = Datos[0].TrimEnd(); ;

                    if (Datos[0] == "Admin")
                    {
                        MenuGeneral menuge = new MenuGeneral();
                        desplegarPantalla(menuge);
                    }
                    else
                    {
                        if (Dep == "Laboratorio                             ")
                        {
                            MenuLaboratorio menulab = new MenuLaboratorio(Datos[0], llamada);
                            desplegarPantalla(menulab);
                        }
                        else
                        {
                            MenuPrincipal menup = new MenuPrincipal(Datos[0]);
                            desplegarPantalla(menup);
                        }
                    }
                    cerrarPantalla(llamada);
                }
                else
                    MessageBox.Show("No se ha podido ingresar");
            }
            if (Evento == "HeOlvidadoMiContraseña")
            {
                RecuperarContraseña recon = new RecuperarContraseña();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(RecuperarContraseña))
                    {
                        recon.MostrarContraseña(maru.RecuperarContraseña(Datos));
                        break;
                    }
                    else
                    {
                        if (Application.OpenForms.Count > 1)
                        { }
                        else
                        {
                            desplegarPantalla(recon);
                            cerrarPantalla(llamada);
                            break;
                        }
                    }
                }
                //cerrarPantalla(llamada);
            }
            if (Evento == "Registrar")
            {               
                if (maru.RegistrarUsuario(Datos) > 0)
                {
                    MessageBox.Show("Registrado");
                }
                else
                {
                    MessageBox.Show("El Login ya está en uso");
                }
            }
            if (Evento == "Actualizar")
            {
                if (maru.ActualizaDatosRegistro(Datos) > 0)
                {
                    MessageBox.Show("Actualizado");
                }
            }
            if (Evento == "PerfilAdmin" || Evento == "PerfilUsuario")
            {
                PerfilUsuario perfil;
                if (EsAdmin)
                { perfil = new PerfilUsuario(Datos[0], true); }
                else
                { perfil = new PerfilUsuario(Datos[0], false); }
                var datosRegistro = new DataTable();
                datosRegistro = maru.ObtenerRegistroUsuario(Datos);
                foreach (DataRow fila in datosRegistro.Rows)
                {
                    perfil.Login = fila["Loginn"].ToString();
                    perfil.Nombre = fila["Nombre"].ToString();
                    perfil.Direccion = fila["Direccion"].ToString();
                    perfil.Colonia = fila["Colonia"].ToString();
                    perfil.Pais = fila["Pais"].ToString();
                    perfil.Estado = fila["Estado"].ToString();
                    perfil.Municipio = fila["Municipio"].ToString();
                    perfil.Ciudad = fila["Ciudad"].ToString();
                    perfil.Codigo = fila["CodigoPostal"].ToString();
                    perfil.TelCasa = fila["TelCasa"].ToString();
                    perfil.TelOficina = fila["TelOfi"].ToString();
                    perfil.TelMovil = fila["TelCel"].ToString();
                    perfil.Email = fila["Email"].ToString();
                }
                desplegarPantalla(perfil);
                cerrarPantalla(llamada);    
            }
            if (Evento == "Usuarios")
            {
                Usuarios usu = new Usuarios();
                var UsuariosRegistrados = new DataTable();
                UsuariosRegistrados = maru.UsuariosRegistrados();
                int i = 0;
                foreach (DataRow fila in UsuariosRegistrados.Rows)
                {
                    if (Convert.ToInt32(fila["Activo"].ToString()) < 1)
                    {
                        usu.UsuariosReg[i] = fila["Loginn"].ToString();
                    }
                    i++;
                }
                desplegarPantalla(usu);
                //cerrarPantalla(llamada);
            }
            if (Evento == "EliminarUsuario")
            {
                if (maru.EliminarRegistro(Datos)> 0)
                {
                    MessageBox.Show("Usuario Eliminado");
                }
            }
            if (Evento == "ActualizarRegistroUsuario")
            {
                ActualizarRegistroUsuario actregi = new ActualizarRegistroUsuario(Datos[0]);
                var datosRegistro = new DataTable();
                datosRegistro = maru.ObtenerRegistroUsuario(Datos);
                foreach (DataRow fila in datosRegistro.Rows)
                {
                    actregi.Nombre = fila["Nombre"].ToString();
                    actregi.Apellidos = fila["Apellidos"].ToString();
                    actregi.Direccion = fila["Direccion"].ToString();
                    actregi.Colonia = fila["Colonia"].ToString();
                    actregi.Pais = fila["Pais"].ToString();
                    actregi.Estado = fila["Estado"].ToString();
                    actregi.Municipio = fila["Municipio"].ToString();
                    actregi.Ciudad = fila["Ciudad"].ToString();
                    actregi.Codigo = fila["CodigoPostal"].ToString();
                    actregi.TelCasa = fila["TelCasa"].ToString();
                    actregi.TelOficina = fila["TelOfi"].ToString();
                    actregi.TelMovil = fila["TelCel"].ToString();
                    actregi.Email = fila["Email"].ToString();
                    actregi.Pregunta = fila["Pregunta"].ToString();
                    actregi.Respuesta = fila["Respuesta"].ToString();
                    actregi.Password = fila["Passwordd"].ToString();
                }
                desplegarPantalla(actregi);
                cerrarPantalla(llamada);
            }
            if (Evento == "ActualizarRegistroAdmin")
            {
                ActualizarRegistroAdmin actregAd = new ActualizarRegistroAdmin(Datos[0]);
                var datosRegistro = new DataTable();
                datosRegistro = maru.ObtenerRegistroUsuario(Datos);
                foreach (DataRow fila in datosRegistro.Rows)
                {
                    actregAd.Nombre = fila["Nombre"].ToString();
                    actregAd.Apellidos = fila["Apellidos"].ToString();
                    actregAd.Direccion = fila["Direccion"].ToString();
                    actregAd.Colonia = fila["Colonia"].ToString();
                    actregAd.Pais = fila["Pais"].ToString();
                    actregAd.Estado = fila["Estado"].ToString();
                    actregAd.Municipio = fila["Municipio"].ToString();
                    actregAd.Ciudad = fila["Ciudad"].ToString();
                    actregAd.Codigo = fila["CodigoPostal"].ToString();
                    actregAd.TelCasa = fila["TelCasa"].ToString();
                    actregAd.TelOficina = fila["TelOfi"].ToString();
                    actregAd.TelMovil = fila["TelCel"].ToString();
                    actregAd.Email = fila["Email"].ToString();
                    actregAd.Pregunta = fila["Pregunta"].ToString();
                    actregAd.Respuesta = fila["Respuesta"].ToString();
                    actregAd.Password = fila["Passwordd"].ToString();
                    actregAd.Departamento = fila["Departamento"].ToString();
                    actregAd.FechaNac = fila["FechaNacimiento"].ToString();
                }
                desplegarPantalla(actregAd);
                cerrarPantalla(llamada);
            }
            if (Evento == "RegistrarTarjeta")
            {               
                RegistrarTarjeta regtar = new RegistrarTarjeta(Datos[0]);
                var datosRegistro = new DataTable();
                datosRegistro = maru.ObtenerRegistroUsuario(Datos);
                foreach (DataRow fila in datosRegistro.Rows)
                {
                    regtar.Titular = fila["Nombre"].ToString();
                    regtar.Titular += fila["Apellidos"].ToString();
                }
                desplegarPantalla(regtar);
                cerrarPantalla(llamada);
            }
            if (Evento == "RegTarjeta")
            {
                if (mart.RegitrarTarjeta(Datos) > 0)
                {
                    MessageBox.Show("Tarjeta Registrada");
                }
                else
                    MessageBox.Show("Tarjeta NO Registrada");
            }
            if (Evento == "Tarjetas")
            {
                Tarjetas_RegistradasUser tarjetas = new Tarjetas_RegistradasUser(Datos[0]);
                var TarjetasDeUsuario = new DataTable();
                TarjetasDeUsuario = mart.TarjetasRegistradas(Datos);
                int i = 0;
                foreach (DataRow fila in TarjetasDeUsuario.Rows)
                {
                    tarjetas.TarjetasReg[i] = fila["NumTar"].ToString();
                    i++;
                }
                desplegarPantalla(tarjetas);
                cerrarPantalla(llamada);
            }
            if (Evento == "RegistroTarjeta")
            {
                ActualizarTarjeta actTar = new ActualizarTarjeta();
                var datosTarjeta = new DataTable();
                datosTarjeta = mart.ObtenerInformacionTarjeta(Datos);
                foreach (DataRow fila in datosTarjeta.Rows)
                {
                    actTar.Titular = fila["Nombre"].ToString();
                    actTar.NumTar = fila["NumTar"].ToString();
                    actTar.Banco = fila["BancoTar"].ToString();
                    actTar.Fecha = fila["FechaV"].ToString();
                    actTar.Tipo = fila["Tipo"].ToString();
                }
                desplegarPantalla(actTar);
                cerrarPantalla(llamada);
            }
            if (Evento == "ActualizarTarjeta")
            {
                if (mart.ActualizarTarjeta(Datos) > 0)
                {
                    MessageBox.Show("Actualizado");
                }
            }
            if (Evento =="EliminarTarjeta")
            {    
                if (mart.EliminarRegistroTarjetas(Datos) > 0)
                {
                    MessageBox.Show("Tarjeta Eliminada");
                }
                
            }
            if (Evento == "Recepcion")
            {
                Recepcion rep = new Recepcion(Datos[0]);
                desplegarPantalla(rep);
                cerrarPantalla(llamada);
            }
            if(Evento == "NuevoPedido")
            {
                Pedido ped = new Pedido(llamada, Datos[0]);
                desplegarPantalla(ped);
                cerrarPantalla(llamada);
            }
            if(Evento == "Pedido Total")
            {
                Total t = new Total(Datos);
                desplegarPantalla(t);
                cerrarPantalla(llamada);
            }
            if(Evento == "Pedidos")
            {
                Pedidos p = new Pedidos(llamada, Datos[0]);
                desplegarPantalla(p);
                cerrarPantalla(llamada);
            }
            if(Evento == "Pedido")
            {
                VerPedido vp = new VerPedido(Datos, llamada);
                desplegarPantalla(vp);
                cerrarPantalla(llamada);
            }
            if(Evento == "Registrar Dentista")
            {
                RegistrarDentista rd = new RegistrarDentista();
                desplegarPantalla(rd);
                cerrarPantalla(llamada);
            }
            if(Evento == "ActualizarPedido")
            {
                ModificarPedido2 mp = new ModificarPedido2(Datos, llamada);
                desplegarPantalla(mp);
                cerrarPantalla(llamada);
            }
            if(Evento == "Actualizar Producto")
            {
                ModificarPedido2 mp2 = new ModificarPedido2(Datos);
                desplegarPantalla(mp2);
                cerrarPantalla(llamada);
            }
            if(Evento == "Registrar Dentistax2")
            {

                if (marr.RegistrarUsuario(Datos) != 0)
                {
                    MessageBox.Show("Registrado satisfactoriamente");
                }
                else
                    MessageBox.Show("La Cedula o el RFC ya estan en uso");
            }
            if(Evento == "Modificar Dentista")
            {
                ModificarDentista md = new ModificarDentista(Datos[0]);
                desplegarPantalla(md);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaVentas")
            {
                Ventas vn = new Ventas(Datos[0]);
                desplegarPantalla(vn);
                cerrarPantalla(llamada);
            }
            if(Evento == "PantallaEntregas")
            {
                Entregas et = new Entregas(Datos[0], llamada);
                desplegarPantalla(et);
                cerrarPantalla(llamada);
            }
            if(Evento == "PantallaCaja")
            {
                Caja cj = new Caja(Datos[0], llamada);
                desplegarPantalla(cj);
                cerrarPantalla(llamada);
            }
            if(Evento == "PantallaRetiro")
            {
                Retiro rt = new Retiro(Datos[0]);
                desplegarPantalla(rt);
                cerrarPantalla(llamada);
            }
            if (Evento == "ActualizarDentista")
            {
                if (marr.ActualizarDentista(Datos) != 0)
                {
                    MessageBox.Show("Registro Modificado Correctamente");
                }
                else
                    MessageBox.Show("Esa cedula o RFC ya estan en uso");
            }
            if(Evento== "getUltimoDentista")
            {
                marr.getUltimoDentista();
            }
            if(Evento == "CrearPedido")
            {
                if (manp.CrearPedido(Datos) != 0)
                {
                    MessageBox.Show("Pedido Creado Satisfactoriamente", "Pedido Creado");
                }
                else
                    MessageBox.Show("El pedido no ha sido creado");
            }
            if(Evento == "InsertarProducto")
            {
                if (manp.InsertarProducto(Datos) != 0)
                {
                    MessageBox.Show("Producto Insertado");
                }
                else
                    MessageBox.Show("Producto Perdido");
            }
            if(Evento == "GenerarPedido")
            {
                if (manp.GenerarPedido(Datos) != 0)
                {
                    
                }
                else
                    MessageBox.Show("El pedido no se genero");
            }
            if (Evento == "BorrarPedido")
            {
                if (manp.BorrarPedido(Datos) != 0)
                {
                    MessageBox.Show("Pedido Eliminado");
                }
                else
                    MessageBox.Show("El pedido no se elimino");
            }
            //EVENTOS MARIBEL
           
            if (Evento == "PantallaFacturar")
            {
                Facturar fac = new Facturar();
                desplegarPantalla(fac);
                cerrarPantalla(llamada);
            }
            //if (Evento == "PantallaFacturas")
            //{
            //    Facturas fac = new Facturas();
            //    desplegarPantalla(fac);
            //    cerrarPantalla(llamada);
            //}


            if (Evento == "PantallaElaborarFactura")
            {
                VerFactura vfac = new VerFactura();

                DataTable datosFactura = maf.BuscarFactura(new string[] { Datos[0], "" });

                if (datosFactura.Rows.Count == 0)
                {
                    datosFactura = maf.ElaborarFactura(Datos);
                    foreach (DataRow fila in datosFactura.Rows)
                    {
                        vfac.Pedido = fila["IDPedido"].ToString();
                        vfac.Loginn = MenuPrincipal.UsuarioEnCurso;
                        vfac.Nombre = fila["Nombre"].ToString();
                        vfac.Apellido = fila["Apellidos"].ToString();
                        vfac.RFC = fila["RFC"].ToString();
                        vfac.Cedula = fila["Cedula"].ToString();
                        vfac.Direccion = fila["Direccion"].ToString();
                        vfac.Pais = fila["Pais"].ToString();
                        vfac.Estado = fila["Estado"].ToString();
                        vfac.Municipio = fila["Municipio"].ToString();
                        vfac.Ciudad = fila["Ciudad"].ToString();
                        vfac.Colonia = fila["Colonia"].ToString();
                        vfac.CodigoPostal = fila["CodigoPostal"].ToString();
                        vfac.Telefono = fila["Telefono"].ToString();
                      //  vfac.Fecha = fila["FechaEmision"].ToString();

                    }
                }
                else
                {
                    foreach (DataRow fila in datosFactura.Rows)
                    {
                        vfac.Pedido = fila["Pedido"].ToString();
                        vfac.Loginn = fila["Loginn"].ToString();
                        vfac.Nombre = fila["Nombre"].ToString();
                        vfac.Apellido = fila["Apellidos"].ToString();
                        vfac.RFC = fila["RFC"].ToString();
                        vfac.Cedula = fila["Cedula"].ToString();
                        vfac.Direccion = fila["Direccion"].ToString();
                        vfac.Pais = fila["Pais"].ToString();
                        vfac.Estado = fila["Estado"].ToString();
                        vfac.Municipio = fila["Municipio"].ToString();
                        vfac.Ciudad = fila["Ciudad"].ToString();
                        vfac.Colonia = fila["Colonia"].ToString();
                        vfac.CodigoPostal = fila["CodigoPostal"].ToString();
                        vfac.Telefono = fila["Telefono"].ToString();
                        vfac.Fecha = fila["FechaEmision"].ToString();
                    }
                }

                desplegarPantalla(vfac);
            }
            if (Evento == "PantallaNomina")
            {
                new Nomina().ShowDialog();
            }

            if (Evento == "Registrar Datos Factura")
            {

                if (maf.RegistrarDatosFactura(Datos) != 0)
                {
                    MessageBox.Show("Registrado satisfactoriamente");
                }
                else
                    MessageBox.Show("No se registraron los datos");
            }
            if (Evento == "Registrar Datos Forma")
            {

                if (marr.RegistrarDatosForma(Datos) != 0)
                {
                    MessageBox.Show("Registrado satisfactoriamente");
                }
                else
                    MessageBox.Show("No se registraron los datos");
            }
            if (Evento == "Registrar Datos Oficio")
            {

                if (marr.RegistrarDatosOficio(Datos) != 0)
                {
                    MessageBox.Show("Confirmado satisfactoriamente");
                }
                else
                    MessageBox.Show("No se pudo confirmar");
            }
            if (Evento == "Registrar Datos Nota")
            {

                if (mar.RegistrarDatosNota(Datos) != 0)
                {
                    MessageBox.Show("Terminado satisfactoriamente");
                }
                else
                    MessageBox.Show("No se pudo terminar");
            }
            if (Evento == "Modificar Datos Factura")
            {
                if (maf.ModificarDatosFactura(Datos) != 0)
                {
                    MessageBox.Show("Los datos han sido modificados correctamente");
                }
                else
                    MessageBox.Show("Los datos no se modificaron");
            }
            if (Evento == "Registrar Comentario")
            {

                if (maf.RegistrarComentario(Datos) != 0)
                {
                    MessageBox.Show("Registrado satisfactoriamente");
                }
                else
                    MessageBox.Show("No se registro el comentario");
            }
            if (Evento == "Elaborar nota")
            {
                Nota notas = new Nota();
                var datosNota = new DataTable();
                datosNota = maf.MostrarDatosNota(Datos);

                foreach (DataRow fila in datosNota.Rows)
                {
                    notas.NoPedido = fila["IDPedido"].ToString();
                    notas.Nombre = fila["Nombre"].ToString();
                    notas.Nombre = fila["Apellidos"].ToString();
                    notas.RFC = fila["RFC"].ToString();
                    notas.Direccion = fila["Direccion"].ToString();
                    notas.Telefono = fila["Telefono"].ToString();
                    notas.Fecha = fila["FechaEntrega"].ToString();

                }
                desplegarPantalla(notas);
            
              //  cerrarPantalla(llamada);
            }

            if (Evento == "PantallaAlmacen")
            {
                Almacen alm = new Almacen(llamada, Datos[1]);
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosMateriales(Datos);
                alm.DatosData(datosAlm);
                desplegarPantalla(alm);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaInventario")
            {
                Inventario alm = new Inventario(llamada, Datos[1]);
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosMateriales(Datos);
                alm.DatosData(datosAlm);
                desplegarPantalla(alm);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaHistorial")
            {
                HistorialInv hinv = new HistorialInv(llamada, Datos[2]);
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerHistorial(Datos);
                hinv.DatosData(datosAlm);
                desplegarPantalla(hinv);
                cerrarPantalla(llamada);
            }

            if (Evento == "PantallaRequisiciones")
            {
                Requisiciones requi = new Requisiciones(llamada, Datos[1]);
                var datosRequi = new DataTable();
                datosRequi = mancp.ObtenerRequisiciones(Datos);
                requi.DatosData(datosRequi);
                desplegarPantalla(requi);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaSurtidoMat")
            {
                SurtidoMaterial surtm = new SurtidoMaterial(llamada, Datos[1]);
                var datosRequi = new DataTable();
                datosRequi = mancp.RequisicionesAcep(Datos);
                surtm.DatosData(datosRequi);
                desplegarPantalla(surtm);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaProveedores")
            {
                ProveedoresJesusCrack prov = new ProveedoresJesusCrack(llamada, Datos[1]);
                var datosProv = new DataTable();
                datosProv = mancp.ObtenerProveedores(Datos);
                prov.DatosData(datosProv);
                desplegarPantalla(prov);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaAgregarProveedor")
            {
                AgregarProveedor aprov = new AgregarProveedor(llamada);
                desplegarPantalla(aprov);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaActualizarProveedor")
            {
                ModificarProveedor modp = new ModificarProveedor(llamada, Datos[1]);
                var datosProv = new DataTable();
                datosProv = mancp.ObtenerProveedores(Datos);
                modp.DatosData(datosProv);
                desplegarPantalla(modp);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaRequisicionMateriales")
            {
                RequisicionMateriales remat = new RequisicionMateriales(llamada, Datos[1]);
                var datosMat = new DataTable();
                datosMat = mancp.ObtenerDatosMateriales(Datos);
                remat.DatosData(datosMat, 1);

                datosMat = mancp.ObtenerFaltantes(Datos);
                remat.DatosData(datosMat, 0);
                desplegarPantalla(remat);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaCatalogoProductos")
            {
                CatalogoProductos catpr = new CatalogoProductos(llamada, Datos[1]);
                var datosCat = new DataTable();
                datosCat = mancp.ObtenerCatalogo(Datos);
                catpr.DatosData(datosCat);
                desplegarPantalla(catpr);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaCompraProveedores")
            {
                ComprasProveedores comprov = new ComprasProveedores(llamada, Datos[1]);
                var datosComProv = new DataTable();
                datosComProv = mancp.ComprasAProveedor(Datos);
                comprov.DatosData(datosComProv);
                desplegarPantalla(comprov);
                cerrarPantalla(llamada);
            }
            if (Evento == "PantallaEntradaSalida")
            {
                EntradaYSalida eys = new EntradaYSalida(llamada);
                var datosMat = new DataTable();
                datosMat = mancp.ObtenerEntradas(Datos);
                eys.DatosData(datosMat);
                desplegarPantalla(eys);
                cerrarPantalla(llamada);
            }

            //ACABA

        }
        public void desplegarPantalla(Form Pantalla)
        {       
            Pantalla.Show();
        }

        public void cerrarPantalla(Form Pantalla)
        {
            Pantalla.Hide();
        }
    }
}
