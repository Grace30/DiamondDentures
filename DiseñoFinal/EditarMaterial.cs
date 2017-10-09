using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class EditarMaterial : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        public string CodMat, Nombre, Precio, Tiempo;

        public EditarMaterial()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }


        private void pbActualizar_Click(object sender, EventArgs e)
        {
            if (v.ValidaCamposMat(txtCodMat, txtNombre, txtTiempo, txtPrecio))
            {
                string[] Datos = { txtCodMat.Text, txtNombre.Text , txtPrecio.Text , txtTiempo.Text};
                intusuario.enviarEvento("ActualizarMaterial", Datos);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtCodMat.Text };
            intusuario.enviarEvento("BorrarMaterial", Datos);
            this.Close();
        }

        private void txtCodMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarMaterial_Load_1(object sender, EventArgs e)
        {
            txtCodMat.Text = ReducirEspaciado(CodMat);
            txtNombre.Text = ReducirEspaciado(Nombre);
            txtPrecio.Text = ReducirEspaciado(Precio);
            txtTiempo.Text = ReducirEspaciado(Tiempo);
        }

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", "");
            }

            return Cadena;
        }
    }
}
