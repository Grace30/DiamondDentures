using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using System.Runtime.InteropServices;

namespace DiseñoFinal
{
    public partial class ModificarDentista : Form
    {
        ManejadorPrincipal map = new ManejadorPrincipal();
        InterfaceUsuario It;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        string[] Cedula;
        Validación v = new Validación();
        public ModificarDentista()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
        }

        public ModificarDentista(string Cedula)
        {
            InitializeComponent();
            this.Cedula = new string[] { Cedula };
            It = new InterfaceUsuario(this);
        }

        private void ModificarDentista_Load(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtColonia.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtNumExt.Text = "";
            txtRFC.Text = "";
            cbCiudad.Text = "";
            cbEstado.Text = "";
            cbMunicipio.Text = "";
            cbPais.Text = "";
            maskedCodigo.Text = "";
            maskedTCasa.Text = "";
            var Datos = new DataTable();
            Datos = map.DatosDentista(Cedula);
            foreach (DataRow fila in Datos.Rows)
            {
                txtCedula.Text = fila["Cedula"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                txtRFC.Text = fila["RFC"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                txtNombre.Text = fila["Nombre"].ToString();
            }
            txtApellidos.Text = Datos.Rows[0][4].ToString();
            foreach (DataRow fila in Datos.Rows)
            {
                txtDireccion.Text = fila["Direccion"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                txtNumExt.Text = fila["NumeroExterior"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                cbPais.Text = fila["Pais"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                cbEstado.Text = fila["Estado"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                cbMunicipio.Text = fila["Municipio"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                cbCiudad.Text = fila["Ciudad"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                txtColonia.Text = fila["Colonia"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                maskedCodigo.Text = fila["CodigoPostal"].ToString();
            }
            foreach (DataRow fila in Datos.Rows)
            {
                maskedTCasa.Text = fila["Telefono"].ToString();
            }
            txtEmail.Text = Datos.Rows[0][14].ToString();
            txtConsultorio.Text = Datos.Rows[0][16].ToString();
            txtFechaNac.Text = Datos.Rows[0][18].ToString();
            var Paises = new DataTable();
            cbPais.Items.Clear();
            cbPais.Items.Add(" ");
            Paises = map.Paises();
            foreach (DataRow fila in Paises.Rows)
            {
                cbPais.Items.Add(fila["NombrePais"].ToString());
            }
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
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
                    cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, txtColonia.Text, maskedCodigo.Text, maskedTCasa.Text, Cedula[0], txtApellidos.Text.ToUpper(), txtEmail.Text, txtConsultorio.Text, txtFechaNac.Text.Substring(0,10) };
                It.enviarEvento("ActualizarDentista", Datos);

            }
            else
                MessageBox.Show("No se puede Actualizar, algunos campos no estan debidamente llenos");
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
                Estados = map.Estados(Datos);
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
            Municipios = map.Municipios(Datos);
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
            Ciudades = map.Ciudades(Datos);
            foreach (DataRow fila in Ciudades.Rows)
            {
                cbCiudad.Items.Add(fila["NombreCiudad"].ToString());
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            v.NumerosLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void maskedCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.noEspacios(e);
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
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
    }
}
