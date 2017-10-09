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
    public partial class Facturar : Form
    {
        InterfaceUsuario intusuario;
        bool admin = false;
        ManejadorFacturas maf = new ManejadorFacturas();
        Validación v;
     
        public Facturar()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            RellenarTODO();
            pBFacturar.Visible = false;
          
        }

        public void RellenarTODO()
        {

            var Pedidos = new DataTable();
            Pedidos = maf.ObtenerDatosPedido();
            dgvFPedido.ColumnCount = Pedidos.Columns.Count;
            int renglon = 0;
            foreach (DataRow fila in Pedidos.Rows)
            {
                if (v.reducirCadena(fila["Estatus"].ToString()) == "FINALIZADO" || v.reducirCadena(fila["Estatus"].ToString()) == "FACTURADO")
                {
                    dgvFPedido.RowCount++;
                    dgvFPedido["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvFPedido["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvFPedido["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                    dgvFPedido["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                    dgvFPedido["EstadoP", renglon].Value = ReducirEspaciado(fila["Estatus"].ToString());
                    renglon++;
                }
            }
        
            
        }


        public static string ReducirEspaciado(string Cadena)
        {
            string temp = "";
            if (!string.IsNullOrWhiteSpace(Cadena))
            {
                bool Empezo = false;
                for (int i = Cadena.Length - 1; i >= 0; i--)
                {
                    if (Cadena[i] != ' ')
                    {
                        Empezo = true;
                    }
                    if (Empezo)
                        temp = Cadena[i] + temp;
                }
            }
            return temp;
        }
        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!admin)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuContabilidad))
                    {
                        frm.Show();
                    }
                }
            }
            else
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuContabilidad))
                    {
                        frm.Show();
                    }
                }

        }

        private void pBFacturar_Click(object sender, EventArgs e)
        {
            if (dgvFPedido[4, dgvFPedido.CurrentCell.RowIndex].Value.ToString() == "FINALIZADO")
            {
                string[] Datos = { dgvFPedido[0, dgvFPedido.CurrentCell.RowIndex].Value.ToString() };
                intusuario.enviarEvento("PantallaElaborarFactura", Datos);

                string[] Datos2 = { dgvFPedido[0, dgvFPedido.CurrentCell.RowIndex].Value.ToString() };
                intusuario.enviarEvento("ProductosAFacturar", Datos2);
            }
 
        }

        private void pbBuscarPedido_Click(object sender, EventArgs e)
        {
           // pBFacturar.Visible = true;
           
            if (!string.IsNullOrWhiteSpace(txtFacturar.Text))
            {
              
                dgvFPedido.Rows.Clear();
                DataTable Tabla = null;
                if (rbDentista.Checked)
                {
                    Tabla = maf.BuscarPorPedido(new string[] { "", txtFacturar.Text });
                }
                else
                {
                    Tabla = maf.BuscarPorPedido(new string[] { txtFacturar.Text, "" });
                }
               // txtFacturar.Clear();
                int renglon = 0;
                dgvFPedido.RowCount = Tabla.Rows.Count;
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvFPedido["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvFPedido["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvFPedido["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                    dgvFPedido["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                    dgvFPedido["EstadoP", renglon].Value = ReducirEspaciado(fila["Estatus"].ToString());
                    renglon++;
                }
            }
            else
                RellenarTODO();
        }

        private void dgvFPedido_CurrentCellChanged(object sender, EventArgs e)
        {
            pBFacturar.Visible = false;
            if (dgvFPedido.CurrentCell != null)
            {
                DataGridViewCell t = dgvFPedido[4, dgvFPedido.CurrentCell.RowIndex];
                if (t.Value != null)
                    if (t.Value.ToString() == "FINALIZADO")
                        pBFacturar.Visible = true;
            }
        }

        private void txtFacturar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbDentista.Checked)
            {
                v.SoloLetras(e);
            }
            else
                v.SoloNumeros(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pBFacturar.Visible = true;

            if (!string.IsNullOrWhiteSpace(txtFacturar.Text))
            {

                dgvFPedido.Rows.Clear();
                DataTable Tabla = null;
                if (rbDentista.Checked)
                {
                    Tabla = maf.BuscarPorPedido(new string[] { "", txtFacturar.Text });
                }
                else
                {
                    Tabla = maf.BuscarPorPedido(new string[] { txtFacturar.Text, "" });
                }
               // txtFacturar.Clear();
                int renglon = 0;
                dgvFPedido.RowCount = Tabla.Rows.Count;
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvFPedido["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvFPedido["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvFPedido["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                    dgvFPedido["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                    dgvFPedido["EstadoP", renglon].Value = ReducirEspaciado(fila["Estatus"].ToString());
                    renglon++;
                }
            }
            else
                RellenarTODO();
        }

        private void txtFacturar_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
