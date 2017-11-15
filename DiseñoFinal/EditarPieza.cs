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
    public partial class EditarPieza : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        public string CodPieza, Nombre, TiempoFab, Precio;

        public EditarPieza()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }
        private void EditarPieza_Load(object sender, EventArgs e)
        {

        }

        private void pbActualizarPieza_Click(object sender, EventArgs e)
        {
            if (v.ValidaCamposPieza(txtCodPieza, txtNombre, nudTiempo, txtPrecio))
            {
                string[] Datos = { txtCodPieza.Text, txtNombre.Text, nudTiempo.Value.ToString(), txtPrecio.Text };
                intusuario.enviarEvento("ActualizarPieza", Datos);
            }
        }

        private void pbBorrarPieza_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtCodPieza.Text };
            intusuario.enviarEvento("BorrarPieza", Datos);
            this.Close();
        }

        private void txtCodPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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


        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
        public static string ReducirEspaciado(string Cadena)
        {
            if (Cadena != null)
            {
                while (Cadena.Contains("  "))
                {
                    Cadena = Cadena.Replace("  ", "");
                }
                if (Cadena.Length > 0)
                {
                    if (Cadena[Cadena.Length - 1] == ' ')
                    {
                        Cadena = Cadena.Remove(Cadena.Length - 1, 1);
                    }
                }
            }
            return Cadena;
        }

        private void EditarPieza_Load_1(object sender, EventArgs e)
        {
            txtCodPieza.Text = CodPieza;
            txtNombre.Text = Nombre;
            nudTiempo.Value = Convert.ToInt32(TiempoFab);
            txtPrecio.Text = Precio;
        }
        public void DatosTabla(DataTable datosPieza)
        {
            foreach (DataRow fila in datosPieza.Rows)
            {
                CodPieza = ReducirEspaciado(fila["CodigoProducto"].ToString());
                Nombre = ReducirEspaciado(fila["Nombre"].ToString());
                TiempoFab = ReducirEspaciado(fila["TiempoBase"].ToString());
                Precio = ReducirEspaciado(fila["PrecioBase"].ToString());
            }
        }
    }
}
