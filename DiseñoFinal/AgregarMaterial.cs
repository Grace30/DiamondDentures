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
    public partial class AgregarMaterial : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();

        public AgregarMaterial()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAgregarMat_Click(object sender, EventArgs e)
        {
            if (v.ValidaCamposMat(txtCodMat, txtNombre, txtTiempo, txtPrecio))
            {
                string[] Datos = { txtCodMat.Text, txtNombre.Text , txtPrecio.Text, txtTiempo.Text};
                intusuario.enviarEvento("AgregarMaterial", Datos);
            }
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

        private void pBSalir2_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}