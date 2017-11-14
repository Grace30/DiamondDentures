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
    public partial class Pedido : Form
    {
        InterfaceUsuario It;
        ManejadorRegistroDentista marr = new ManejadorRegistroDentista();
        ManejadorPrincipal map = new ManejadorPrincipal();
        Validación v = new Validación();
        string preciounitario = "0", preciounitario2 = "0", preciounitario3 = "0";
        float punitario = 0, subtotal = 0;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form pantalla;
        int filaactual;
        string UsuarioActual;
        public Pedido()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
        }

        public Pedido(Form pantalla, string usuarioactual)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            UsuarioActual = usuarioactual;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBVerP_Click(object sender, EventArgs e)
        {
            string[] Datos = { cBCedula.Text };
            It.enviarEvento("Pedido Total", Datos);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            It.enviarEvento("Registrar Dentista", new string[0]);
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            var Ultimo = new DataTable();
            Ultimo = map.getUltimoPedido();
            foreach (DataRow fila in Ultimo.Rows)
            {
                if (fila["Ultimo"].ToString() != "")
                    lblPedido.Text = "#" + (int.Parse(fila["Ultimo"].ToString()) + 1).ToString();
                else
                    lblPedido.Text = "#" + 1;
            }
            cBCedula.Items.Clear();
            cBCedula.Items.Add(" ");
            var Cedulas = new DataTable();
            Cedulas = marr.Cedulas();
            foreach (DataRow fila in Cedulas.Rows)
            {
                cBCedula.Items.Add(fila["Cedula"].ToString());
            }
            cBProducto.Items.Clear();
            cBProducto.Items.Add(" ");
            var Productos = new DataTable();
            Productos = map.Productos();
            foreach(DataRow fila in Productos.Rows)
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
        }

        private void cBCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea seleccionar este Dentista?, Una vez seleccionado se creara un pedido listo para añadir productos pero no podra modificar ni cambiar el dentista.", "Seleccionar Dentista", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                if (cBCedula.SelectedItem!= null)
                {
                    cBCedula.Enabled = false;
                    string[] cedula = { cBCedula.SelectedItem.ToString() };
                    var x = new DataTable();
                    x = marr.getDatosDentista(cedula);
                    string dato = "";
                    foreach (DataRow item in x.Rows)
                    {
                        dato = item["ID"].ToString();
                    }
                    string[] Datos = { dato, UsuarioActual ,"SIN ELABORAR"};
                    It.enviarEvento("CrearPedido", Datos);
                    cBMaterial.Enabled = true;
                    cBProducto.Enabled = true;
                    comboBox1.Enabled = true;
                    pBAñadir.Enabled = true;
                    nCantidad.Enabled = true;
                    linkLabel2.Enabled = false;
                    linkLabel3.Enabled = false;
                }
                else
                    MessageBox.Show("No se ha elegido ninguna Cedula, favor de elegir una");
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
                txtCodigo.Text = (fila["CodigoProducto"].ToString());
            }
            foreach (DataRow fila in Productos.Rows)
            {
                preciounitario=(fila["PrecioBase"].ToString());
            }
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2);
            subtotal = punitario * (int)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
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

        private void cBMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            preciounitario2 = sacacodigomaterial(cBMaterial.Text, txtCodigoMaterial);
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2) + float.Parse(preciounitario3);
            subtotal = punitario * (float)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void nCantidad_ValueChanged(object sender, EventArgs e)
        {
            subtotal = punitario * (int)nCantidad.Value;
            txtSubTotal.Text = subtotal.ToString();
        }

        private void cBCedula_Enter(object sender, EventArgs e)
        {
            cBCedula.Items.Clear();
            cBCedula.Items.Add(" ");
            var Cedulas = new DataTable();
            Cedulas = marr.Cedulas();
            foreach (DataRow fila in Cedulas.Rows)
            {
                cBCedula.Items.Add(fila["Cedula"].ToString());
            }
        }

        private void cBCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.OnlyNumber(e);
        }

        private void cBProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
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

        private void Pedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pantalla.GetType() == typeof(Recepcion))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Recepcion))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(ControlPedidos))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ControlPedidos))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Datos = { lblPedido.Text.Substring(1), dataGridView1[0, filaactual].Value.ToString() };
                map.SacarProducto(Datos);
                RellenarTODO();
            }
            catch (Exception) { MessageBox.Show("No hay productos que sacar"); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            hoy = dateTimePicker1.Value;
            if (checkBox1.Checked)
                hoy.AddDays(-3);
            else
                hoy.AddDays(3);
            dateTimePicker1.Value = hoy;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
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

        private void pBGenerarPedido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string[] Datos = new string[17];
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
                Datos[2] = UsuarioActual;
                Datos[4] = DateTime.Today.ToShortDateString();
                string x = Datos[4];
                Datos[5] = dateTimePicker1.Value.ToShortDateString();
                Datos[4] = x.Substring(6);
                Datos[4] += "-" + x.Substring(3, 2);
                Datos[4] += "-" + x.Substring(0, 2);
                x = Datos[5];
                Datos[5] = x.Substring(6);
                Datos[5] += "-" + x.Substring(3, 2);
                Datos[5] += "-" + x.Substring(0, 2);
                Datos[6] = "";
                Datos[8] = txtTotal.Text;
                Datos[9] = "";
                Datos[3] = "SIN CONFIRMAR";
                Datos[7] = urgente;
                Datos[10] = "NO";
                Datos[11] = txtTotal.Text;
                Datos[12] = "16%";
                Datos[13] = "NO";
                Datos[14] = "";
                Datos[15] = "NO";
                Datos[16] = "";
                It.enviarEvento("GenerarPedido", Datos);
                //VistaPreviaForma objForm = new VistaPreviaForma();
                //string idPed = lblPedido.Text.Substring(1);
                //objForm.IDPedido = idPed;
                //objForm.ShowDialog();
                checkBox1.Enabled = false;
            }
            else
                MessageBox.Show("No se puede Elaborar una forma de pedido sin productos");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preciounitario3 = sacacodigomaterial(comboBox1.Text, textBox1);
            punitario += float.Parse(preciounitario) + float.Parse(preciounitario2) + float.Parse(preciounitario3);
            subtotal = punitario * (float)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] Datos = { cBCedula.Text };
            It.enviarEvento("Modificar Dentista", Datos);
        }

        private void pBAñadir_Click(object sender, EventArgs e)
        {
            if(cBMaterial.SelectedItem!=null && cBProducto.SelectedItem!=null && txtCodigo.Text!="" && 
                txtCodigoMaterial.Text!="" && txtPrecioUnitario.Text!="" && txtSubTotal.Text != "")
            {
                string[] Datos = { txtCodigoMaterial.Text, textBox1.Text, txtCodigo.Text };
                DataTable gg = map.getMaterialesProducto(Datos);
                if (gg.Rows.Count != 0)
                {
                    string especial = gg.Rows[0]["CodigoEspecial"].ToString();
                    Datos = new string[]{ lblPedido.Text.Substring(1), especial, nCantidad.Value.ToString(), txtSubTotal.Text };
                    map.InsertarProducto(Datos);
                    RellenarTODO();
                }
                else
                    MessageBox.Show("No existe esa clase de combinación de producto y materiales dentro de la base de datos");                               
            }
        }
    }
}
