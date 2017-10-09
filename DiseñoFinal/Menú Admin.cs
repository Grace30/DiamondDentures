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
    public partial class Menú_Admin : Form
    {
        InterfaceUsuario intusuario;
        public Menú_Admin()
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
                if (frm.GetType() == typeof(MenuGeneral))
                {
                    frm.Show();
                }
            }
        }

        private void pBUsuarios_Click_1(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("Usuarios", Datos);
        }

        private void pBPerfilA_Click(object sender, EventArgs e)
        {
            string[] Datos = { "Admin" };
            intusuario.enviarEvento("PerfilAdmin", Datos);
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Login))
                {
                    frm.Show();
                }
            }
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(MenuGeneral))
                {
                    frm.Close();
                    break;
                }
            }
        }

    
        private void label2_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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

        private void pBPerfilA_MouseLeave(object sender, EventArgs e)
        {
            pBPerfilA.Image = Properties.Resources._21;
        }

        private void pBPerfilA_MouseHover(object sender, EventArgs e)
        {
            pBPerfilA.Image = Properties.Resources._23;
        }

        private void pBUsuarios_MouseLeave(object sender, EventArgs e)
        {
            pBUsuarios.Image = Properties.Resources.usuarios;
        }

        private void pBUsuarios_MouseHover(object sender, EventArgs e)
        {
            pBUsuarios.Image = Properties.Resources.usuarios2;

        }

      
        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }
       

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;

        }

        private void pBSalir_MouseHover_1(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;

        }

        private void Menú_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnAcualizarClave_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro_Usuario regu = new Registro_Usuario();
            intusuario.desplegarPantalla(regu);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            intusuario.enviarEvento("RegistrardesdeAdmin", new string[0]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ActualizarClave actclave = new ActualizarClave();
            actclave.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.registrar2;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.registrar;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.actualizar_key;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.actualizar_key_2;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
