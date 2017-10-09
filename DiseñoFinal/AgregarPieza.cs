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
    public partial class AgregarPieza : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();

        public AgregarPieza()
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

        private void pbAgregarPieza_Click(object sender, EventArgs e)
        {
            if (v.ValidaCamposPieza(txtCodPieza, txtNomPieza, nudDias, txtPrecio))
            {
                string[] Datos = { txtCodPieza.Text, txtNomPieza.Text, nudDias.Value.ToString(), txtPrecio.Text };
                intusuario.enviarEvento("AgregarPieza", Datos);
            }
        }

        private void txtCodPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNomPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}