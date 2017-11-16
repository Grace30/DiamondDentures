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

namespace DiseñoFinal
{
    public partial class AgregarMaterial : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        List<string[,]> Proveedores = new List<string[,]>();

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
            string proveedor = "";
            if (v.ValidaCamposMat(txtCodMat, txtNombre, txtTiempo, txtPrecio))
            {
                for (int i = 0; i < Proveedores.Count; i++)
                {
                    if(Proveedores[i][0,1] == cbProv.Text.ToString())
                    {
                        proveedor = Proveedores[i][0, 0];
                        break;
                    }
                }
                string[] Datos = { txtCodMat.Text, txtNombre.Text ,txtDesc.Text, txtCosto.Text, txtPrecio.Text, txtTiempo.Text, proveedor,txtUnidad.Text, txtStock.Text};
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

        private void AgregarMaterial_Load(object sender, EventArgs e)
        {
            var datosProv = new DataTable();
            string[] Datos = { "" };
            datosProv = mancp.ObtenerProveedores(Datos);
            foreach (DataRow fila in datosProv.Rows)
            {
                cbProv.Items.Add(ReducirEspaciado(fila["Nombre"].ToString()));
                Proveedores.Add(new string[,] { { ReducirEspaciado(fila["ClaveProveedor"].ToString()), ReducirEspaciado(fila["Nombre"].ToString()) } });
            }
        }
        public static string ReducirEspaciado(string Cadena)
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
            return Cadena;
        }
    }
}