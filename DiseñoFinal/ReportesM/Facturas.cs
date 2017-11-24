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
    public partial class Facturas : Form
    {
        InterfaceUsuario intusuario = new InterfaceUsuario(new Form());
        Form pantalla;
        bool admin = false;
        ManejadorFacturas maf = new ManejadorFacturas();
        public string IDPedido;
        Validación v;
        public Facturas(Form pantalla)
        {
            InitializeComponent();
            v = new Validación();
            this.pantalla = pantalla;
            intusuario = new InterfaceUsuario(this);
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void Facturas_Load(object sender, EventArgs e)
        {
            button3.Text = Program.Departamento + " - " + Program.Loginn;

            RellenarTODO();
            
           

        }
        public void RellenarTODO()
        {
           
            var facturas = new DataTable();
            facturas = maf.ObtenerFacturas();
            dgvFacturas.ColumnCount = facturas.Columns.Count;
            dgvFacturas.RowCount = facturas.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in facturas.Rows)
            {
                dgvFacturas["NoFac", renglon].Value = ReducirEspaciado(fila["NoFactura"].ToString());
                dgvFacturas["NoPed", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                dgvFacturas["Nombre", renglon].Value = ReducirEspaciado(fila["NombreDentista"].ToString());
                dgvFacturas["Fecha", renglon].Value = ReducirEspaciado(fila["FechaEmision"].ToString());
                dgvFacturas["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());

                renglon++;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenúReportes))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenúReportes))
                        frm.Show();
                }
            }
            else if (pantalla.GetType() == typeof(MenuContabilidad))
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuContabilidad))
                        frm.Show();
                }
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
          
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBVerFactura_Click(object sender, EventArgs e)
        {

            VistaPrevia objForm = new VistaPrevia();

            //maf.CrearFactura(new string[] { dgvFacturas.SelectedCells[0].Value.ToString() });
            //int Factura = Convert.ToInt32(maf.BuscarFactura(new string[] { dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString() }).Rows[0].ItemArray[1]);

            string idPed = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();
            string NoFac = dgvFacturas[0, dgvFacturas.CurrentCell.RowIndex].Value.ToString();

            objForm.NoFactura = NoFac;
            objForm.Pedido = idPed;
            objForm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dgvFacturas.Rows.Clear();
                DataTable Tabla = null;
               
                if (rdNoFac.Checked)
                {
                    Tabla = maf.BuscarPorFactura(new string[] { textBox1.Text, "" });
                }
                else
                {
                    Tabla = maf.BuscarPorFactura(new string[] { "",textBox1.Text});
                    
                }
               
                int renglon = 0;
                textBox1.Clear();
                dgvFacturas.RowCount = Tabla.Rows.Count;
                
                foreach (DataRow fila in Tabla.Rows)
                {
                  
                    dgvFacturas["NoFac", renglon].Value = ReducirEspaciado(fila["NoFactura"].ToString());
                    dgvFacturas["NoPed", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvFacturas["Nombre", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvFacturas["Fecha", renglon].Value = ReducirEspaciado(fila["FechaEmision"].ToString());
                    dgvFacturas["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());

                    renglon++;
                }
               
            }
            else
                
                RellenarTODO();
          
        }

        private void dgvFacturas_CurrentCellChanged(object sender, EventArgs e)
        {
                pBVerFactura.Visible = dgvFacturas.CurrentCell!=null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
 
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dgvFacturas.Rows.Clear();
                DataTable Tabla = null;

                if (rdNoFac.Checked)
                {
                    Tabla = maf.BuscarPorFactura(new string[] { textBox1.Text, "" });
                }
                else
                {
                    Tabla = maf.BuscarPorFactura(new string[] { "", textBox1.Text });

                }

                int renglon = 0;
              //  textBox1.Clear();
                dgvFacturas.RowCount = Tabla.Rows.Count;

                foreach (DataRow fila in Tabla.Rows)
                {

                    dgvFacturas["NoFac", renglon].Value = ReducirEspaciado(fila["NoFactura"].ToString());
                    dgvFacturas["NoPed", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvFacturas["Nombre", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvFacturas["Fecha", renglon].Value = ReducirEspaciado(fila["FechaEmision"].ToString());
                    dgvFacturas["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                    renglon++;
                }

            }
            else

                RellenarTODO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenuContabilidad))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuContabilidad))
                    {
                        frm.Show();
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[] { Program.Loginn };
            intusuario.enviarEvento("PerfilUsuario", Datos);
        }
    }
}
