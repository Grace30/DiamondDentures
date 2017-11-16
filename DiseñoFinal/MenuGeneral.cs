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
    public partial class MenuGeneral : Form
    {
        InterfaceUsuario intusuario;
        public MenuGeneral()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void MenuGeneral_Load(object sender, EventArgs e)
        {

        }

        private void pBAdministrar_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("EntrarAdmin", Datos);
        }

        private void pBAdministrar_MouseLeave(object sender, EventArgs e)
        {
            pBAdministrar.Image = Properties.Resources.administrar;
        }

        private void pBAdministrar_MouseHover(object sender, EventArgs e)
        {
            pBAdministrar.Image = Properties.Resources.administrar2;

        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

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

        private void pBRecepcion_Click(object sender, EventArgs e)
        {
            string[] Datos = { "Admin" };
            intusuario.enviarEvento("Recepcion", Datos);
        }

        private void pbxSemaforo_Click(object sender, EventArgs e)
        {
            string[] Datos = { "Admin" };
            intusuario.enviarEvento("PantallaSemaforo", Datos);
        }

        private void pbLaboratorio_Click(object sender, EventArgs e)
        {
            string[] Datos = { "Admin" };
            intusuario.enviarEvento("MenuLaboratorio", Datos);
        }

        private void pBMenúContabilidad_Click(object sender, EventArgs e)
        {
            MenuContabilidad frm = new MenuContabilidad(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void pBReportes_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", "Admin" };
            intusuario.enviarEvento("PantallaAlmacen", Datos);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width + 3, ((PictureBox)sender).Size.Height + 3);
            ((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X - 1, ((PictureBox)sender).Location.Y - 1);
            ((PictureBox)sender).BackColor = Color.GhostWhite;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width - 3, ((PictureBox)sender).Size.Height - 3);
            ((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X + 1, ((PictureBox)sender).Location.Y + 1);
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void C(object sender, EventArgs e)
        {
            new FirmarAsistencia().ShowDialog();

        }
    }
}
