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
    public partial class MenuPrincipal : Form
    {
        InterfaceUsuario intusuario;
        public static string UsuarioEnCurso;
        public MenuPrincipal(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
            //También Aquí :B
            //pBReportes_Click(pBReportes, new EventArgs());
            //Hide();
        }

        public MenuPrincipal()
        {
            // TODO: Complete member initialization
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
       

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Login))
                {
                    frm.Show();
                }
            }
        }

        private void pBPerfilU_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("PerfilUsuario", Datos);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioEnCurso;
        }

        private void linkLogoutMP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Login))
                {
                    frm.Show();
                }
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void pBPerfilU_MouseLeave(object sender, EventArgs e)
        {
            pBPerfilU.Image = Properties.Resources._21;
        }

        private void pBPerfilU_MouseHover(object sender, EventArgs e)
        {
            pBPerfilU.Image = Properties.Resources._23;

        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {

            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBRecepcion_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("Recepcion", Datos);
        }

        private void pBMenúContabilidad_Click(object sender, EventArgs e)
        {
            MenuContabilidad frm = new MenuContabilidad(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void pBReportes_Click(object sender, EventArgs e)
        {
            //Reportes frm = new Reportes(this);
            //intusuario.desplegarPantalla(frm);
            //intusuario.cerrarPantalla(this);
            MenúReportes frm = new MenúReportes();
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void pbxSemaforo_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("PantallaSemaforo", Datos);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
