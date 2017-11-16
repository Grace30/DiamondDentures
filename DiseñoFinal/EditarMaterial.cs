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
    public partial class EditarMaterial : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        public string CodMat, Nombre, Descrip, Costo , Precio, Tiempo,Unidad,Proveedor,Stock;
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        List<string[,]> Proveedores = new List<string[,]>();

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
                for (int i = 0; i < Proveedores.Count; i++)
                {
                    if (Proveedores[i][0, 1] == cbProv.Text.ToString())
                    {
                        Proveedor = Proveedores[i][0, 0];
                        break;
                    }
                }
                string[] Datos = { txtCodMat.Text, txtNombre.Text, txtDesc.Text, txtCosto.Text, txtPrecio.Text, txtTiempo.Text, Proveedor, txtUnidad.Text, txtStock.Text };
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
            var datosProv = new DataTable();
            string[] Datos = { "" };
            datosProv = mancp.ObtenerProveedores(Datos);
            foreach (DataRow fila in datosProv.Rows)
            {
                cbProv.Items.Add(ReducirEspaciado(fila["Nombre"].ToString()));
                Proveedores.Add(new string[,] { { ReducirEspaciado(fila["ClaveProveedor"].ToString()), ReducirEspaciado(fila["Nombre"].ToString()) } });
            }

            txtCodMat.Text = ReducirEspaciado(CodMat);
            txtNombre.Text = ReducirEspaciado(Nombre);
            txtPrecio.Text = ReducirEspaciado(Precio);
            txtTiempo.Text = ReducirEspaciado(Tiempo);
            txtCosto.Text = ReducirEspaciado(Costo);
            txtDesc.Text = ReducirEspaciado(Descrip);
            txtStock.Text = ReducirEspaciado(Stock);
            txtUnidad.Text = ReducirEspaciado(Unidad);
            for (int i = 0; i < Proveedores.Count; i++)
            {
                if(Proveedor == Proveedores[i][0, 0])
                {
                    cbProv.Text = Proveedores[i][0, 1];
                    break;
                }
            }
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

        public void DatosTabla(DataTable datosMaterial)
        {
            foreach (DataRow fila in datosMaterial.Rows)
            {
                CodMat = fila["CodigoMaterial"].ToString();
                Nombre = fila["Nombre"].ToString();
                Descrip = fila["Descripcion"].ToString();
                Costo = fila["CostoBase"].ToString();
                Precio = fila["PrecioBase"].ToString();
                Tiempo = fila["TiempoBase"].ToString();
                Proveedor = ReducirEspaciado(fila["Proveedor"].ToString());
                Unidad = fila["Unidad"].ToString();
                Stock = fila["Stock"].ToString();
            }
        }
    }
}
