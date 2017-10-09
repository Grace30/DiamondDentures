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
    public partial class ModificarPedido2 : Form
    {
        InterfaceUsuario It;
        Validación v = new Validación();
        ManejadorPrincipal map = new ManejadorPrincipal();
        ManejadorRegistroDentista marr = new ManejadorRegistroDentista();
        string[] Datos;
        string preciounitario = "0", preciounitario2 = "0";
        int punitario = 0, subtotal = 0;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        public ModificarPedido2(string[] Datos)
        {
            InitializeComponent();
            this.Datos = Datos;
            It = new InterfaceUsuario(this);
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ModificarPedido))
                {
                    frm.Show();
                }
            }
        }

        private void ModificarPedido2_Load(object sender, EventArgs e)
        {
            lblPedido.Text = "#" + this.Datos[0];
            cBCedula.Items.Clear();
            cBCedula.Items.Add(" ");
            string[] Datos = { this.Datos[0] };
            var Cedulas = new DataTable();
            Cedulas = marr.selectCedulaNombre(Datos);
            foreach (DataRow fila in Cedulas.Rows)
            {
                cBCedula.Items.Add(fila["Cedula"].ToString());
            }
            cBCedula.Text = this.Datos[4];
            cBProducto.Items.Clear();
            cBProducto.Items.Add(" ");
            var Productos = new DataTable();
            Productos = map.Productos();
            foreach (DataRow fila in Productos.Rows)
            {
                cBProducto.Items.Add(fila["Nombre"].ToString());
            }
            cBMaterial.Items.Clear();
            cBMaterial.Items.Add(" ");
            var Materiales = new DataTable();
            Materiales = map.Materiales();
            foreach (DataRow fila in Materiales.Rows)
            {
                cBMaterial.Items.Add(fila["Nombre"].ToString());
            }
        }

        private void cBMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Datos = { cBMaterial.Text };
            punitario = 0;
            var Materiales = new DataTable();
            Materiales = map.PrecioMaterial(Datos);
            foreach (DataRow fila in Materiales.Rows)
            {
                txtCodigoMaterial.Text = (fila["Codigo"].ToString());
            }
            foreach (DataRow fila in Materiales.Rows)
            {
                preciounitario2 = (fila["Precio"].ToString());
            }
            punitario += int.Parse(preciounitario) + int.Parse(preciounitario2);
            subtotal = punitario * (int)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void nCantidad_ValueChanged(object sender, EventArgs e)
        {
            subtotal = punitario * (int)nCantidad.Value;
            txtSubTotal.Text = subtotal.ToString();
        }

        private void pBVerP_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ModificarPedido))
                {
                    frm.Show();
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBAñadir_Click(object sender, EventArgs e)
        {
            if (cBMaterial.SelectedItem != null && cBProducto.SelectedItem != null && txtCodigo.Text != "" &&
                txtCodigoMaterial.Text != "" && txtPrecioUnitario.Text != "" && txtSubTotal.Text != "")
            {
                string[] Datos = { this.Datos[0], txtCodigo.Text, txtCodigoMaterial.Text, txtPrecioUnitario.Text, nCantidad.Value.ToString(), txtSubTotal.Text };
                It.enviarEvento("InsertarProducto", Datos);
            }
        }

        private void cBProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Datos = { cBProducto.Text };
            punitario = 0;
            var Productos = new DataTable();
            Productos = map.PrecioProducto(Datos);
            foreach (DataRow fila in Productos.Rows)
            {
                txtCodigo.Text = (fila["Codigo"].ToString());
            }
            foreach (DataRow fila in Productos.Rows)
            {
                preciounitario = (fila["Precio"].ToString());
            }
            punitario += int.Parse(preciounitario) + int.Parse(preciounitario2);
            subtotal = punitario * (int)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }
    }
}
