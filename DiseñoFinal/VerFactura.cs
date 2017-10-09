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
    public partial class VerFactura : Form
    {
        ManejadorFacturas maf = new ManejadorFacturas();
        InterfaceUsuario intusuario;
        public string Pedido, Cedula, RFC, Nombre, Direccion, Pais, Estado, Municipio, Ciudad, Colonia, Telefono, CodigoPostal;
        public string Codigo, NombreProducto, Material, Cantidad, Precio, SubTotal, Fecha;

        bool Cambios { get; set; }
        Validación v;
        public VerFactura()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            Cambios = false;
            CambioHecho();
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void CambioHecho()
        {
            txtcedula.KeyPress += CambioHecho;
            txtciudad.KeyPress += CambioHecho;
            txtcolonia.KeyPress += CambioHecho;
            txtcp.KeyPress += CambioHecho;
            txtdireccion.KeyPress += CambioHecho;
            txtel.KeyPress += CambioHecho;
            txtestado.KeyPress += CambioHecho;
            txtmunicipio.KeyPress += CambioHecho;
            txtnombre.KeyPress += CambioHecho;
            txtpais.KeyPress += CambioHecho;
            txtrfc.KeyPress += CambioHecho;
            dateTimePicker1.ValueChanged += delegate(object sender, EventArgs e) { this.Cambios = true; };
        }

        void CambioHecho(object sender, KeyPressEventArgs e)
        {
            this.Cambios = true;
        }

        private void VerFactura_Load(object sender, EventArgs e)
        {

            lblFecha.Text = dateTimePicker1.Text;
            lblNoPedido.Text = ReducirEspaciado(Pedido);

            txtnombre.Text = ReducirEspaciado(Nombre);
            txtrfc.Text = ReducirEspaciado(RFC);
            txtcedula.Text = ReducirEspaciado(Cedula);
            txtdireccion.Text = ReducirEspaciado(Direccion);
            txtcolonia.Text = ReducirEspaciado(Colonia);
            txtciudad.Text = ReducirEspaciado(Ciudad);
            txtcp.Text = ReducirEspaciado(CodigoPostal);
            txtel.Text = ReducirEspaciado(Telefono);
            txtestado.Text = ReducirEspaciado(Estado);
            txtmunicipio.Text = ReducirEspaciado(Municipio);
            txtpais.Text = ReducirEspaciado(Pais);
            dateTimePicker1.Value = !string.IsNullOrWhiteSpace(Fecha) ? Convert.ToDateTime(Fecha) : DateTime.Now;
            Cambios = false;
            RellenarTODO();
            int subtotal = 0;
            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                subtotal += Convert.ToInt32(row.Cells["Imp"].Value);
            }
            double iva, suma;

            iva = subtotal * 0.16;
            suma = subtotal + iva;

            lbliva.Text = "$ " + Convert.ToString(iva) + ".00";
            lblsub.Text = "$" + Convert.ToString(subtotal) + ".00";
            lbltotal.Text = "$ " + Convert.ToString(suma) + ".00";



        }
        public void RellenarTODO()
        {
            string[] Datos = { lblNoPedido.Text };
            var datosProductos = new DataTable();
            datosProductos = maf.ProductosFacturar(Datos);
            dgvProducto.ColumnCount = datosProductos.Columns.Count;
            dgvProducto.RowCount = datosProductos.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in datosProductos.Rows)
            {
                dgvProducto["Cod", renglon].Value = fila[ReducirEspaciado("Codigo")].ToString();
                dgvProducto["Cant", renglon].Value = fila[ReducirEspaciado("Cantidad")].ToString();
                dgvProducto["Producto", renglon].Value = fila[ReducirEspaciado("NombreProducto")].ToString();
                dgvProducto["Mat", renglon].Value = fila[ReducirEspaciado("Material")].ToString();
                dgvProducto["Prec", renglon].Value = fila[ReducirEspaciado("Precio")].ToString();
                dgvProducto["Imp", renglon].Value = fila[ReducirEspaciado("SubTotal")].ToString();
                renglon++;
            }
        }

       
        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string ReducirEspaciado(string Cadena)
        {
            if (Cadena != null)
            {
                while (Cadena.Contains("  "))
                {
                    Cadena = Cadena.Replace("  ", "");
                }
            }
            return Cadena;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            VistaPrevia objForm = new VistaPrevia();
            DataTable RFactura = maf.BuscarFactura(new string[] { lblNoPedido.Text, "" });
            if (Cambios || RFactura.Rows.Count == 0)
            {
                if (txtcedula.Text != "" && txtrfc.Text != "" && txtnombre.Text != "" && txtcolonia.Text != "" && txtdireccion.Text != "" && txtciudad.Text != ""
                   && txtestado.Text != "" && txtmunicipio.Text != "" && txtpais.Text != "" && txtcp.Text != "" && txtel.Text != "")
                {
                    if (RFactura.Rows.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Se modificará la factura\n\n¿Continuar?", "", MessageBoxButtons.YesNoCancel))
                        {
                            string[] Datos = {lblNoPedido.Text, lblFecha.Text,txtnombre.Text,txtrfc.Text, txtcedula.Text,txtdireccion.Text, txtpais.Text,
                    txtestado.Text, txtmunicipio.Text, txtciudad.Text, txtcolonia.Text, txtcp.Text, txtel.Text };
                            intusuario.enviarEvento("Modificar Datos Factura", Datos);

                            string[] Datos0 = { lblNoPedido.Text, "FACTURADO" };
                            intusuario.enviarEvento("CambiarEstado", Datos0);
                        }
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Se registrará la factura\n\n¿Continuar?", "", MessageBoxButtons.YesNoCancel))
                        {
                            string[] Datos = {lblNoPedido.Text,lblFecha.Text,txtnombre.Text,txtrfc.Text, txtcedula.Text,txtdireccion.Text, txtpais.Text,
                    txtestado.Text, txtmunicipio.Text, txtciudad.Text, txtcolonia.Text, txtcp.Text, txtel.Text };
                            intusuario.enviarEvento("Registrar Datos Factura", Datos);

                            string[] Datos0 = { lblNoPedido.Text, "FACTURADO" };
                            intusuario.enviarEvento("CambiarEstado", Datos0);
                        }
                    }



                }
                else
                    MessageBox.Show("No se puede registrar");
            }
           
            int Factura = Convert.ToInt32(maf.BuscarFactura(new string[] { lblNoPedido.Text }).Rows[0].ItemArray[0]);

            string idPed = lblNoPedido.Text;

            objForm.IDPedido = idPed;

            Cambios = false;

            objForm.ShowDialog();
            string[] Datos2 = { lblNoPedido.Text, "FACTURADO" };
            intusuario.enviarEvento("CambiarEstado", Datos2);

        }

        private void pBActualizar_Click(object sender, EventArgs e)
        {
            if (txtcedula.Text != "" && txtrfc.Text != "" && txtnombre.Text != "" && txtcolonia.Text != "" && txtdireccion.Text != "" && txtciudad.Text != ""
               && txtestado.Text != "" && txtmunicipio.Text != "" && txtpais.Text != "" && txtcp.Text != "" && txtel.Text != "")
            {
                if (maf.BuscarFactura(new string[] { lblNoPedido.Text, "" }).Rows.Count > 0)
                {
                    string[] Datos = {lblNoPedido.Text, lblFecha.Text,txtnombre.Text,txtrfc.Text, txtcedula.Text,txtdireccion.Text, txtpais.Text,
                    txtestado.Text, txtmunicipio.Text, txtciudad.Text, txtcolonia.Text, txtcp.Text, txtel.Text };
                    intusuario.enviarEvento("Modificar Datos Factura", Datos);
                }
                else
                {
                    string[] Datos = {lblNoPedido.Text,lblFecha.Text,txtnombre.Text,txtrfc.Text, txtcedula.Text,txtdireccion.Text, txtpais.Text,
                    txtestado.Text, txtmunicipio.Text, txtciudad.Text, txtcolonia.Text, txtcp.Text, txtel.Text };
                    intusuario.enviarEvento("Registrar Datos Factura", Datos);
                }
            }
            else
                MessageBox.Show("No se puede registrar");
            Cambios = false;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtcolonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtmunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        

        private void txtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtrfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblFecha.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}

