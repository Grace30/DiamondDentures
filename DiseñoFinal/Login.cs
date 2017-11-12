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
using Entidad;   

namespace DiseñoFinal
{
    public partial class Login : Form
    {
        ManejadorPrincipal manp = new ManejadorPrincipal();
        InterfaceUsuario intusuario;
        Validación v;
        public Login()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            //Quitar esto :B
            //txtPassword.Text = txtLogin.Text = "Maribel02";
            //pBIngresar_Click(pBIngresar, new EventArgs());
            //Hide();
        }
        //quitar el marco y poder moverlo
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        
        private extern static void ReleaseCapture();

       
        private void pBSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("Registrarse", Datos);
            txtPassword.Text = "Password";
        }

        private void linkHeOlvidado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string[] Datos = new string[1];
            intusuario.enviarEvento("HeOlvidadoMiContraseña", Datos);
            txtPassword.Text = "Password";
        }
        private void pBIngresar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPassword.Text != "")
            {
                string[] Datos = { txtLogin.Text, txtPassword.Text };
                intusuario.enviarEvento("Ingresar", Datos);
                txtPassword.Text = "Password";
            }
            else
                MessageBox.Show("Favor de llenar todos los campos",
                    "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            v.Limpiartxt(txtPassword, "Password");
        }

        private void pBMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }


        private void Login_Load(object sender, EventArgs e)
        {
          //  manp.CrearBase();                        
        }

        private void bPSalir_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void txtLogin_MouseClick(object sender, MouseEventArgs e)
        {
            v.Limpiartxt(txtLogin, "Login");
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            v.Llenartxt(txtLogin, "Login");
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            v.Limpiartxt(txtLogin, "Login");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            v.Llenartxt(txtPassword, "Password");
        }

        //Avalos no funca con el picture box 
        //private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    v.Enter(e, pBIngresar);

        //}
         //Cambiar imagen del picturebox
        private void pBMostrar_MouseLeave(object sender, EventArgs e)
        {
            pBMostrar.Image = Properties.Resources.ojo_1;
        }

        private void pBMostrar_MouseHover(object sender, EventArgs e)
        {
            pBMostrar.Image = Properties.Resources.ojo_2;

        }

        private void pBIngresar_MouseLeave(object sender, EventArgs e)
        {
            pBIngresar.Image = Properties.Resources.ingresar;

        }

        private void pBIngresar_MouseHover(object sender, EventArgs e)
        {
            pBIngresar.Image = Properties.Resources.ingresar2;

        }

      

        private void bPSalir_MouseHover(object sender, EventArgs e)
        {
            bPSalir.Image = Properties.Resources.salir2;
        }
        private void bPSalir_MouseLeave(object sender, EventArgs e)
        {
            bPSalir.Image = Properties.Resources.salir;
        }

     
       

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pBSalir2_MouseLeave_1(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;
         
        }

        private void pBSalir2_MouseHover_1(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_2;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Enter(e,intusuario,txtLogin,txtPassword, this);             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
