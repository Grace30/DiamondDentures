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
    public partial class ActualizarTarjeta : Form
    {
        InterfaceUsuario intusuario;
        Validación v;
        public string Titular, NumTar, Banco, Tipo, OtroBanco, OtroTipo, Fecha;
        public string[] FechaPartes = new string[2];

        public ActualizarTarjeta()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
        }
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

        private void pBActualizar_Click(object sender, EventArgs e)
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
                string[] Datos = { txtTitular.Text, txtNoTarjeta.Text, cBBanco.SelectedItem.ToString(), cBTipo.SelectedItem.ToString(), txtOtroBanco.Text, txtOtroTipo.Text, cBMes.SelectedItem.ToString(), cBAño.SelectedItem.ToString() };
                intusuario.enviarEvento("ActualizarTarjeta", Datos);
            }
        }

        private void pBEliminar_Click(object sender, EventArgs e)
        {
            if (txtNoTarjeta.Text != "")
            {
                string[] Datos = { txtNoTarjeta.Text };
                intusuario.enviarEvento("EliminarTarjeta", Datos);
                this.Close();
            }
            else
                MessageBox.Show("Se requieren solo el número de cuenta para poder eliminar");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);   
        }

        private void ActualizarTarjeta_Load_1(object sender, EventArgs e)
        {
            txtTitular.Text = Titular;
            txtNoTarjeta.Text = NumTar;

            int i = 0;
            bool EnBanco = false;
            while (i < cBBanco.Items.Count)
            {
                string Bancoaux = "";
                int j = 0;
                while (j < Banco.Length)
                {
                    Bancoaux += Banco[j];
                    if (Bancoaux == cBBanco.Items[i].ToString())
                    {
                        cBBanco.SelectedIndex = i;
                        EnBanco = true;
                        break;
                    }
                    j++;
                }
                i++;
            }
            if (EnBanco == false)
                txtOtroBanco.Text = Banco;

            i = 0;
            bool EnTipo = false;
            while (i < cBTipo.Items.Count)
            {
                string Tipoaux = "";
                int j = 0;
                while (j < Tipo.Length)
                {
                    Tipoaux += Tipo[j];
                    if (Tipoaux == cBTipo.Items[i].ToString())
                    {
                        cBTipo.SelectedIndex = i;
                        EnTipo = true;
                        break;
                    }
                    j++;
                }
                i++;
            }
            if (EnTipo == false)
                txtOtroTipo.Text = Tipo;

            i = 0;
            while (Fecha[i] != '-')
            {
                FechaPartes[0] += Fecha[i];
                i++;
            }
            i++;
            while (Fecha[i] != ' ')
            {
                FechaPartes[1] += Fecha[i];
                i++;
            }

            i = 0;
            while (i < cBAño.Items.Count)
            {
                if (FechaPartes[0] == cBAño.Items[i].ToString())
                {
                    cBAño.SelectedIndex = i;
                    break;
                }
                i++;
            }
            i = 0;
            while (i < cBMes.Items.Count)
            {
                if (FechaPartes[1] == cBMes.Items[i].ToString())
                {
                    cBMes.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }    
        

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);  
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;
        }

        private void txtTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtNoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void pBActualizar_MouseLeave(object sender, EventArgs e)
        {
            pBActualizar.Image = Properties.Resources.actualizar2;
        }

        private void pBActualizar_MouseHover(object sender, EventArgs e)
        {
            pBActualizar.Image = Properties.Resources.actualizar;
        }

        private void pBEliminar_MouseLeave(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar2;
        }

        private void pBEliminar_MouseHover(object sender, EventArgs e)
        {
            pBEliminar.Image = Properties.Resources.eliminar;
        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void txtOtroBanco_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBBanco, txtOtroBanco);
        }

        private void txtOtroTipo_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBTipo, txtOtroTipo);
        }
    }
}
