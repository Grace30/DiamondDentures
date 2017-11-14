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
        string preciounitario = "0", preciounitario2 = "0", preciounitario3 = "0";
        float punitario = 0, subtotal = 0;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form llamada;
        int filaactual;
        public ModificarPedido2(string[] Datos)
        {
            InitializeComponent();
            this.Datos = Datos;
            It = new InterfaceUsuario(this);
        }

        public ModificarPedido2(string[] Datos, Form llamada)
        {
            InitializeComponent();
            this.Datos = Datos;
            It = new InterfaceUsuario(this);
            this.llamada = llamada;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(VerPedido))
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
                comboBox1.Items.Add(fila["Nombre"].ToString());
            }
            RellenarTODO();
        }
        public void RellenarTODO()
        {
            float Total = 0;
            string[] Datos = new string[] { lblPedido.Text.Substring(1) };
            DataTable tabla = map.getDatosProductosPedido(Datos);
            dataGridView1.DataSource = tabla;
            float dias = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dias += float.Parse(tabla.Rows[i]["Tiempo"].ToString()) * float.Parse(tabla.Rows[i]["Cantidad"].ToString());
                Total += float.Parse(tabla.Rows[i]["SubTotal"].ToString());
            }
            txtTotal.Text = Total.ToString();
            CalculaFecha(dias);
        }

        public void CalculaFecha(float dias)
        {
            DateTime hoy = DateTime.Now;
            int z = 0;
            if (checkBox1.Checked)
                dias += 3;
            while (dias != z)
            {
                if (hoy.DayOfWeek.ToString() != "Saturday" && hoy.DayOfWeek.ToString() != "Sunday")
                {
                    z++;
                    hoy = hoy.AddDays(1);
                }
                else
                    hoy = hoy.AddDays(1);

            }
            dateTimePicker1.Value = hoy;
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

        private void cBProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] Datos = { cBProducto.Text };
            punitario = 0;
            var Productos = new DataTable();
            Productos = map.PrecioProducto(Datos);
            foreach (DataRow fila in Productos.Rows)
            {
                txtCodigo.Text = (fila["CodigoProducto"].ToString());
            }
            foreach (DataRow fila in Productos.Rows)
            {
                preciounitario = (fila["PrecioBase"].ToString());
            }
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2);
            subtotal = punitario * (int)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void cBMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            preciounitario2 = sacacodigomaterial(cBMaterial.Text, txtCodigoMaterial);
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2) + float.Parse(preciounitario3);
            subtotal = punitario * (float)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preciounitario3 = sacacodigomaterial(comboBox1.Text, textBox1);
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2) + float.Parse(preciounitario3);
            subtotal = punitario * (float)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void nCantidad_ValueChanged_1(object sender, EventArgs e)
        {
            subtotal = punitario * (int)nCantidad.Value;
            txtSubTotal.Text = subtotal.ToString();
        }

        private void pBSacarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Datos = { lblPedido.Text.Substring(1), dataGridView1[0, filaactual].Value.ToString() };
                map.SacarProducto(Datos);
                RellenarTODO();
            }
            catch (Exception) { MessageBox.Show("No hay productos que sacar"); }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
        }

        private void pBGenerarPedido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string[] Datos = new string[13];
                string[] id = { lblPedido.Text.Substring(1) };
                var IDDentista = new DataTable();
                IDDentista = marr.selectIDDentista(id);
                foreach (DataRow item in IDDentista.Rows)
                {
                    Datos[1] = item["IDDentista"].ToString();
                }
                string urgente = "NO";
                if (checkBox1.Checked)
                    urgente = "SI";
                Datos[0] = lblPedido.Text.Substring(1);
                Datos[3] = dateTimePicker1.Value.ToShortDateString();
                string x = Datos[3];
                Datos[3] = x.Substring(6);
                Datos[3] += "-" + x.Substring(3, 2);
                Datos[3] += "-" + x.Substring(0, 2);
                Datos[12] = DateTime.Now.ToShortDateString();
                x = Datos[12];
                Datos[12] = x.Substring(6);
                Datos[12] += "-" + x.Substring(3, 2);
                Datos[12] += "-" + x.Substring(0, 2);
                Datos[5] = txtTotal.Text;
                Datos[9] = "";
                Datos[2] = "SIN CONFIRMAR";
                Datos[4] = urgente;
                Datos[6] = "NO";
                Datos[7] = txtTotal.Text;
                Datos[8] = "16%";
                Datos[9] = "NO";
                Datos[10] = "";
                Datos[11] = "SI";
                map.ModificarPedido(Datos);
                //VistaPreviaForma objForm = new VistaPreviaForma();
                //string idPed = lblPedido.Text.Substring(1);

                //objForm.IDPedido = idPed;

                //objForm.ShowDialog();
                checkBox1.Enabled = false;
            }
            else
                MessageBox.Show("No se puede Elaborar una forma de pedido sin productos");
        }

        private string sacacodigomaterial(string nombrematerial, TextBox txt)
        {
            string[] Datos = { nombrematerial };
            punitario = 0;
            var Materiales = new DataTable();
            Materiales = map.PrecioMaterial(Datos);
            foreach (DataRow fila in Materiales.Rows)
            {
                txt.Text = (fila["CodigoMaterial"].ToString());
            }
            return Materiales.Rows[0]["PrecioBase"].ToString();
        }
        private void pBAñadir_Click(object sender, EventArgs e)
        {
            if (cBMaterial.SelectedItem != null && cBProducto.SelectedItem != null && txtCodigo.Text != "" &&
                txtCodigoMaterial.Text != "" && txtPrecioUnitario.Text != "" && txtSubTotal.Text != "")
            {
                string[] Datos = { txtCodigoMaterial.Text, textBox1.Text, txtCodigo.Text };
                DataTable gg = map.getMaterialesProducto(Datos);
                if (gg.Rows.Count != 0)
                {
                    string especial = gg.Rows[0]["CodigoEspecial"].ToString();
                    Datos = new string[] { lblPedido.Text.Substring(1), especial, nCantidad.Value.ToString(), txtSubTotal.Text };
                    map.InsertarProducto(Datos);
                    RellenarTODO();
                }
                else
                    MessageBox.Show("No existe esa clase de combinación de producto y materiales dentro de la base de datos");
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
