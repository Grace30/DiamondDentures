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
    public partial class ModificarPedido : Form
    {
        InterfaceUsuario It;
        string[] Datos;
        int filaactual = 0;
        Validación v = new Validación();
        ManejadorPrincipal map = new ManejadorPrincipal();
        ManejadorRegistroDentista mar = new ManejadorRegistroDentista();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form pantalla;
        public ModificarPedido(string[] Datos)
        {
            InitializeComponent();
            this.Datos = Datos;
            It = new InterfaceUsuario(this);
        }

        public ModificarPedido(string[] Datos, Form pantalla)
        {
            InitializeComponent();
            this.Datos = Datos;
            It = new InterfaceUsuario(this);
            this.pantalla = pantalla;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Datos = new string[6];
                Datos[0] = lblPedido.Text.Substring(1);
                string[] Datos2 = { dataGridView1[0, filaactual].Value.ToString() };
                var Producto = new DataTable();
                Producto = map.getIDProducto(Datos2);
                foreach (DataRow fila in Producto.Rows)
                {
                    Datos[1] = fila["ID"].ToString();
                }
                string[] Datos3 = { dataGridView1[2, filaactual].Value.ToString() };
                var Material = new DataTable();
                Material = map.getCodigoMaterial(Datos3);
                foreach (DataRow fila in Material.Rows)
                {
                    Datos[2] = fila["Codigo"].ToString();
                }
                for (int i = 3; i < dataGridView1.ColumnCount; i++)
                {
                    Datos[i] = dataGridView1[i, filaactual].Value.ToString();
                }
                map.SacarProducto(Datos);
                RellenarTODO();
            }
            catch (Exception) { MessageBox.Show("No hay productos que sacar"); }
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(VerPedido))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(VerPedido))
                    {
                        frm.Show();
                    }
                }
            }
            else if(pantalla.GetType()== typeof(ControlPedidos))
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

        private void pBAñadir_Click(object sender, EventArgs e)
        {
            It.enviarEvento("Actualizar Producto", Datos);
        }

        public void RellenarTODO()
        {
            int Total = 0;
            lblPedido.Text = "#" + Datos[0];
            var ProductosPedido = new DataTable();
            ProductosPedido = map.getProductosPedido(Datos);
            dataGridView1.ColumnCount = ProductosPedido.Columns.Count;
            dataGridView1.RowCount = ProductosPedido.Rows.Count;
            DataRow fila2;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                fila2 = ProductosPedido.Rows[j];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i == 0)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["Codigo"].ToString());
                    if (i == 1)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["Nombre"].ToString());
                    if (i == 2)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["Material"].ToString());
                    if (i == 3)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["Cantidad"].ToString());
                    if (i == 4)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["Precio"].ToString());
                    if (i == 5)
                        dataGridView1[i, j].Value = v.reducirCadena(fila2["SubTotal"].ToString());
                }
                Total += int.Parse(dataGridView1[5, j].Value.ToString());
            }
            txtTotal.Text = Total.ToString();
            CalculaFecha(3);
            var x = new DataTable();
            DataRow z;
            string[] qw = { this.Datos[0] };
            x = mar.selectCedulaNombre(qw);
            z = x.Rows[0];
            lblCedula.Text = z["Cedula"].ToString();
            lblDentista.Text = z["Nombre"].ToString();
            string[] Datos1 = { lblPedido.Text.Substring(1) };
            x = map.selectPedido(Datos1);
            z = x.Rows[0];
            lblStatus.Text = z["Estatus"].ToString();
            if (z["Urgencia"].ToString() == "SI")
                checkBox1.Checked = true;
        }

        public void CalculaFecha(int dias)
        {
            string[] x = { lblPedido.Text.Substring(1) };
            var Tiempos = new DataTable();
            Tiempos = map.getTiempos(x);
            foreach (DataRow item in Tiempos.Rows)
            {
                dias += int.Parse(v.reducirCadena(item["PTiempo"].ToString()));
                dias += int.Parse(v.reducirCadena(item["MTiempo"].ToString()));
            }
            DateTime hoy = DateTime.Now;
            int z = 0;
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string[] Datos = new string[9];
                string[] id = { lblPedido.Text.Substring(1) };
                var IDDentista = new DataTable();
                IDDentista = mar.selectIDDentista(id);
                foreach (DataRow item in IDDentista.Rows)
                {
                    Datos[1] = item["IDDentista"].ToString();
                }
                string urgente = "NO";
                if (checkBox1.Checked)
                    urgente = "SI";
                Datos[0] = lblPedido.Text.Substring(1);
                Datos[3] = DateTime.Today.ToShortDateString();
                Datos[4] = dateTimePicker1.Value.ToShortDateString();
                Datos[5] = "";
                Datos[8] = txtTotal.Text;
                Datos[6] = urgente;
                Datos[2] = "POR CONFIRMAR";
                Datos[7] = "";
                It.enviarEvento("GenerarPedido", Datos);
                VistaPreviaForma objForm = new VistaPreviaForma();

                string idPed = lblPedido.Text.Substring(1);

                objForm.IDPedido = idPed;

                objForm.ShowDialog();
                checkBox1.Enabled = false;
            }
            else
                MessageBox.Show("No se puede elaborar una forma de pedido sin productos");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                CalculaFecha(0);
            else
                CalculaFecha(3);
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void ModificarPedido_Activated(object sender, EventArgs e)
        {
            RellenarTODO();
        }

        private void ModificarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
