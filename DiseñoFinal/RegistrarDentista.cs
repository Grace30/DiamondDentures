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
    public partial class RegistrarDentista : Form
    {
        InterfaceUsuario It;
        ManejadorPrincipal manp = new ManejadorPrincipal();
        ManejadorRegistroDentista mar = new ManejadorRegistroDentista();
        Validación v = new Validación();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        public RegistrarDentista()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            maskedCodigo.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtRFC.Text != "" && txtNombre.Text != "" && txtColonia.Text != "" && txtDireccion.Text != "" && txtNumExt.Text != "" && cbCiudad.Text != ""
                && cbEstado.Text != "" && cbMunicipio.Text != "" &&
                cbPais.Text != "" && maskedCodigo.Text != "" && maskedTCasa.Text != "" &&
                (maskedCodigo.Text.Length == 5 || maskedCodigo.Text.Length == 6) &&
                maskedTCasa.Text.Length == 13 && txtCedula.Text.Length == 7 && txtRFC.Text.Length == 13)
            {
                string[] Datos = { txtCedula.Text, txtRFC.Text.ToUpper(), txtNombre.Text.ToUpper(), txtDireccion.Text, txtNumExt.Text, cbPais.Text,
                    cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, txtColonia.Text, maskedCodigo.Text, maskedTCasa.Text };
                It.enviarEvento("Registrar Dentistax2", Datos);

            }
            else
                MessageBox.Show("No se puede registrar, algunos campos no estan debidamente llenos");

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Pedido))
                {
                    frm.Show();
                }
            }
        }

        private void RegistrarDentista_Load(object sender, EventArgs e)
        {
            cbPais.Items.Clear();
            cbPais.Items.Add(" ");
            var Paises = new DataTable();
            Paises = manp.Paises();
            foreach (DataRow fila in Paises.Rows)
            {
                cbPais.Items.Add(fila["NombrePais"].ToString());
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedCodigo.ReadOnly = false;
            if (cbPais.SelectedItem.ToString() != "Canadá")
            { maskedCodigo.Mask = "00000"; }
            if (cbPais.SelectedItem.ToString() == "Canadá")
            { maskedCodigo.Mask = "A0A0A0"; }
            if (cbPais.SelectedIndex == 149)
            {
                cbEstado.Enabled = true;
                cbMunicipio.Enabled = true;
                cbCiudad.Enabled = true;
                cbEstado.Items.Clear();
                cbEstado.Items.Add(" ");
                cbEstado.SelectedIndex = 0;
                cbMunicipio.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
                string[] Datos = { cbPais.SelectedIndex.ToString() };
                var Estados = new DataTable();
                Estados = manp.Estados(Datos);
                foreach (DataRow fila in Estados.Rows)
                {
                    cbEstado.Items.Add(fila["NombreEstado"].ToString());
                }
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMunicipio.Items.Clear();
            cbMunicipio.Items.Add(" ");
            cbMunicipio.SelectedIndex = 0;
            string[] Datos = { cbEstado.SelectedIndex.ToString() };
            var Municipios = new DataTable();
            Municipios = manp.Municipios(Datos);
            foreach (DataRow fila in Municipios.Rows)
            {
                cbMunicipio.Items.Add(fila["NombreMunicipio"].ToString());
            }
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();
            cbCiudad.Items.Add(" ");
            cbCiudad.SelectedIndex = 0;
            string[] Datos = { cbMunicipio.SelectedItem.ToString(), cbEstado.SelectedItem.ToString() };
            var Ciudades = new DataTable();
            Ciudades = manp.Ciudades(Datos);
            foreach (DataRow fila in Ciudades.Rows)
            {
                cbCiudad.Items.Add(fila["NombreCiudad"].ToString());
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.OnlyNumber(e);
        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.OnlyNumerosLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void txtNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.OnlyNumber(e);
        }

        private void maskedTCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.noEspacios(e);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
