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
    public partial class RecuperarContraseña : Form
    {
        InterfaceUsuario intusuario;
        public RecuperarContraseña()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
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


        private void pBRecuperar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" && txtRespuesta.Text != "" && cBPreguntaSeguridad.Text != "")
            {
                string[] Datos = { txtCorreo.Text, cBPreguntaSeguridad.Text.ToString(), txtRespuesta.Text };
                intusuario.enviarEvento("HeOlvidadoMiContraseña", Datos);
            }
            else
                MessageBox.Show("Favor de llenar todos los campos");
        }

        public void MostrarContraseña(string[] DatosUsuario)
        {
            MessageBox.Show("Su Login es " + DatosUsuario[0] + "\nSu Password es " + DatosUsuario[1],
                "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
 
        }

        private void cBPreguntaSeguridad_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBRecuperar_MouseLeave(object sender, EventArgs e)
        {
            pBRecuperar.Image = Properties.Resources.recuperar;
        }

        private void pBRecuperar_MouseHover(object sender, EventArgs e)
        {
            pBRecuperar.Image = Properties.Resources.recuperar2;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

    }
}
