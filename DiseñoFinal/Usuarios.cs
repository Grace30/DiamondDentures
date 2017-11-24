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
    public partial class Usuarios : Form
    {
        InterfaceUsuario intusuario;
        public string[] UsuariosReg = new string[100];
        public Usuarios()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        private void pBEliminar_Click(object sender, EventArgs e)
        {
            string[] UsuariosElim = new string[100]; 
            foreach (object itemChecked in cheListUsuarios.CheckedItems)
            {
                string[] Datos = { itemChecked.ToString() };
                intusuario.enviarEvento("EliminarUsuario", Datos);
            }
            this.Close();
            string[] Datos2 = new string[1];
            intusuario.enviarEvento("Usuarios", Datos2);
        }

        private void cheListUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cheListUsuarios.Items.Count > 0)
            {
                string[] Datos = { cheListUsuarios.SelectedItem.ToString() };
                intusuario.EsAdmin = true;
                intusuario.enviarEvento("PerfilUsuario", Datos);
            }
            this.Close();
            string[] Datos2 = new string[1];
            intusuario.enviarEvento("Usuarios", Datos2);

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < UsuariosReg.Length)
            {
                if (UsuariosReg[i] != "Admin                                   ")
                {
                    if (UsuariosReg[i] != null)
                    {       
                        cheListUsuarios.Items.Add(UsuariosReg[i]);                        
                    }
                }
                i++;
            }
        }

        private void cheListUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (cheListUsuarios.SelectedIndex != 1)
            {
                cheListUsuarios.SetItemChecked(cheListUsuarios.SelectedIndex, true);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void pBEliminar_MouseLeave(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar;
        }

        private void pBEliminar_MouseHover(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar2;
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
            pBSalir2.Image = Properties.Resources.salir11;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void cheListUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

