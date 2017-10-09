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
    public partial class RegistrarTarjeta : Form
    {
        InterfaceUsuario intusuario;
        Validación v;
        public string Titular;
        string UsuarioEnCurso;
        bool guardado = false;
        public RegistrarTarjeta(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
            v = new Validación();
        }                           
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        

        private void pBSalirClick(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            if (!guardado)
                x = MessageBox.Show("Aun no se ha guardado el registro, ¿seguro que quieres cerrar?",
                    "No guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(PerfilUsuario))
                    {
                        frm.Show();
                    }
                }
            if (x == DialogResult.Yes)
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(PerfilUsuario))
                    {
                        frm.Show();
                    }
                }
            this.Close();
        }

        private void pBGuardar_Click(object sender, EventArgs e)
        {
            if (cBBanco.SelectedIndex != 0)
            {
                txtOtroBanco.Text = "";
            } 
            if (cBTipo.SelectedIndex != 0)
            {
                txtOtroTipo.Text = "";
            }
            if (v.ValidaCampos(txtTitular, txtNoTarjeta, cBBanco, txtOtroBanco, cBTipo, txtOtroTipo, cBMes, cBAño))
            {
                string[] Datos = { txtTitular.Text, txtNoTarjeta.Text, cBBanco.SelectedItem.ToString(), cBTipo.SelectedItem.ToString(), txtOtroBanco.Text, txtOtroTipo.Text, cBMes.SelectedItem.ToString(), cBAño.SelectedItem.ToString(), UsuarioEnCurso };
                intusuario.enviarEvento("RegTarjeta", Datos);
                guardado = true;
            }
            else
                MessageBox.Show("Algunos campos OBLIGATORIOS no estan debidamente llenos",
                    "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtOtroBanco_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBBanco, txtOtroBanco);
        }

        private void txtOtroTipo_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBTipo, txtOtroTipo);
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

        private void pBGuardar_MouseLeave(object sender, EventArgs e)
        {
            pBGuardar.Image = Properties.Resources.guardae;
        }

        private void pBGuardar_MouseHover(object sender, EventArgs e)
        {
            pBGuardar.Image = Properties.Resources.guardar2;
        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void txtTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtNoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtOtroBanco_KeyPress(object sender, KeyPressEventArgs e)
        {           
            v.NumerosLetras(e);
        }

        private void txtOtroTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void cBBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtroBanco.Clear();
        }

        private void cBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtroTipo.Clear();
        }

        private void RegistrarTarjeta_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < Titular.Length)
            {
                txtTitular.Text += Titular[i].ToString();
                i++;
                if (Titular[i] == ' ')
                {
                    txtTitular.Text += Titular[i].ToString();
                    do
                    {
                        i++;
                        if (i == 80)
                            break;
                    } while (Titular[i] == ' ');
                }
            }
        }
    }
}

