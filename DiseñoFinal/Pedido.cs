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
        string preciounitario = "0", preciounitario2 = "0";
        int punitario = 0, subtotal = 0;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form pantalla;
        public Pedido()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
        }

        public Pedido(Form pantalla)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.pantalla = pantalla;
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
                    string[] Datos = { dato, "SIN ELABORAR"};
                    It.enviarEvento("CrearPedido", Datos);
                    cBMaterial.Enabled = true;
                    cBProducto.Enabled = true;
                    pBAñadir.Enabled = true;
                    pBVerP.Enabled = true;
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
                txtCodigo.Text = (fila["Codigo"].ToString());
            }
            foreach (DataRow fila in Productos.Rows)
            {
                preciounitario=(fila["Precio"].ToString());
            }
            punitario += int.Parse(preciounitario) + int.Parse(preciounitario2);
            subtotal = punitario * (int)nCantidad.Value;
            txtPrecioUnitario.Text = punitario.ToString();
            txtSubTotal.Text = subtotal.ToString();
        }

        private void cBMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Datos = { cBMaterial.Text};
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
                int Pedido = 0;
                var Ultimo = new DataTable();
                Ultimo = map.getUltimoPedido();
                foreach (DataRow fila in Ultimo.Rows)
                {
                    if (fila["Ultimo"].ToString() != "")
                        Pedido = int.Parse(fila["Ultimo"].ToString());
                    else
                        Pedido = 1;
                }
                string[] x = {txtCodigo.Text};
                Ultimo = map.getIDProducto(x);
                DataRow fila2 = Ultimo.Rows[0];
                string[] Datos = { "" + Pedido, fila2["ID"].ToString(), txtCodigoMaterial.Text, txtPrecioUnitario.Text, nCantidad.Value.ToString(), txtSubTotal.Text };
                It.enviarEvento("InsertarProducto", Datos);
            }
        }
    }
}
