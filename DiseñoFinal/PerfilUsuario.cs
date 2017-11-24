using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace DiseñoFinal
{
    public partial class PerfilUsuario : Form
    {
        InterfaceUsuario intusuario;
        Login log;
        public string Login, Nombre, Direccion, Colonia, Pais, Estado, Municipio, Ciudad, Codigo, TelCasa, TelOficina, TelMovil, Email;
        string UsuarioEnCurso;
        bool EsAdmin = false;


        public PerfilUsuario(string Usuario, bool Admin)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            log = new Login();
            UsuarioEnCurso = Usuario;
            EsAdmin = Admin;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
       
        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if(Application.OpenForms.Count>0)
                Application.OpenForms[Application.OpenForms.Count - 1].Show();
            
            /*foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Menú_Admin) && EsAdmin)
                {
                    frm.Show();
                }
                if (frm.GetType() == typeof(MenuPrincipal) && !EsAdmin)
                    frm.Show();
                if (frm.GetType() == typeof(MenuContabilidad))
                    frm.Show();
                if (frm.GetType() == typeof(Facturar))
                    frm.Show();
                if (frm.GetType() == typeof(Facturas))
                    frm.Show();


            }*/
        }

        private void pBTarjetas_Click(object sender, EventArgs e)
        {   
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("Tarjetas", Datos);
        }

        private void pBActualizarRegistro_Click_1(object sender, EventArgs e)
        {
            if (EsAdmin)
            {
                string[] Datos = { lblLogin.Text };
                intusuario.enviarEvento("ActualizarRegistroAdmin", Datos);
            }
            else
            {
                string[] Datos = { UsuarioEnCurso };
                intusuario.enviarEvento("ActualizarRegistroUsuario", Datos);
            }
        }

        private void pBRegistrarTarjeta_Click_1(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("RegistrarTarjeta", Datos);
        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {
            lblLogin.Text = Login;
            lblNombre.Text = Nombre;
            lblDireccion.Text = Direccion;
            lblColonia.Text = Colonia;
            lblPais.Text = Pais;
            lblEstado.Text = Estado;
            lblMunicipio.Text = Municipio;
            lblCiudad.Text = Ciudad;
            lblCodigo.Text = Codigo;
            lblTelCasa.Text = TelCasa;
            lblTelOficina.Text = TelOficina;
            lblTelMovil.Text = TelMovil;
            lblEmail.Text = Email;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        private void pBSalir2_MouseLeave_1(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;

        }

        private void pBSalir2_MouseHover_1(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;

        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBActualizarRegistro_MouseLeave(object sender, EventArgs e)
        {
            pBActualizarRegistro.Image = Properties.Resources.actualizar_datos3;
        }

        private void pBActualizarRegistro_MouseHover(object sender, EventArgs e)
        {
            pBActualizarRegistro.Image = Properties.Resources.actualizar_datos_2;

        }

        private void pBRegistrarTarjeta_MouseLeave(object sender, EventArgs e)
        {
            pBRegistrarTarjeta.Image = Properties.Resources.retarjetarjeta;
        }

        private void pBRegistrarTarjeta_MouseHover(object sender, EventArgs e)
        {
            pBRegistrarTarjeta.Image = Properties.Resources.retarjetarjeta2;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }


    }
}
