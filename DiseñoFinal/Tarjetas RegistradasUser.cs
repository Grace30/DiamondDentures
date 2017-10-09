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
    public partial class Tarjetas_RegistradasUser : Form
    {
        InterfaceUsuario intusuario;
        public string[] TarjetasReg = new string[100];
        string UsuarioEnCurso;
        public Tarjetas_RegistradasUser(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
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
                if (frm.GetType() == typeof(PerfilUsuario))
                {
                    frm.Show();
                }
            }
        }

        private void pBEliminar_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] TarjetasElim = new string[100];
            foreach (object itemChecked in cheListTarjetas.CheckedItems)
            {
                string[] Datos = { itemChecked.ToString() };
                intusuario.enviarEvento("EliminarTarjeta", Datos);
            } 
            this.Close();
            string[] Datos2 = { UsuarioEnCurso };
            intusuario.enviarEvento("Tarjetas", Datos2);

            cheListTarjetas.Items.Clear();
            i = 0;
            while (TarjetasReg[i] != null)
            {
                if (TarjetasReg[i] != "")
                {
                    cheListTarjetas.Items.Add(TarjetasReg[i]);
                }
                i++;
            }
        }

        private void cheListTarjetas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cheListTarjetas.Items.Count > 0)
            {
                string[] Datos = { cheListTarjetas.SelectedItem.ToString() };
                intusuario.enviarEvento("RegistroTarjeta", Datos);
            }
            this.Close();
            string[] Datos2 = { UsuarioEnCurso };
            intusuario.enviarEvento("Tarjetas", Datos2);
        }    
        private void Tarjetas_RegistradasUser_Load_1(object sender, EventArgs e)
        {
            cheListTarjetas.Items.Clear();
            int i = 0;
            while (i < TarjetasReg.Length)
            {
                if (TarjetasReg[i] != null)
                {
                    cheListTarjetas.Items.Add(TarjetasReg[i]);
                }
                i++;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
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
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;
        }

        private void pBEliminar_MouseLeave(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar2;
        }

        private void pBEliminar_MouseHover(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }


    }
}
