using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class MenuContabilidad : Form
    {
        bool admin = false;
        InterfaceUsuario intusuario;
        Form pantalla;
        public MenuContabilidad()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }
        public MenuContabilidad(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pBAdministrar_Click(object sender, EventArgs e)
        {
            //Facturas frm = new Facturas();
            //frm.Show();
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaFacturas", Datos);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaFacturar", Datos);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBCrearFactura_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaFacturar", Datos);
        }

        private void pBSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType()==typeof(MenuPrincipal))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuPrincipal))
                    {
                        frm.Show();
                    }
                }
            }
            else
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuGeneral))
                    {
                        frm.Show();
                    }
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.Show();
        }

        private void pBSalir2_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void MenuContabilidad_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
    }
}
