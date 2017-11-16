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
    public partial class Total : Form
    {
        ManejadorPrincipal map = new ManejadorPrincipal();
        ManejadorRegistroDentista mar = new ManejadorRegistroDentista();
        InterfaceUsuario It;
        int filaactual = 0;
        Validación v = new Validación();
        string[] Datos;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        public Total()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
        }

        public Total(string[] Datos)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.Datos = Datos;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Pedido))
                {
                    frm.Close();
                    break;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[6];
            Datos[0] = lblPedido.Text.Substring(1);
            try
            {
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
        }

        public void RellenarTODO()
        {
            var Ultimo = new DataTable();
            string u = "";
            int Total = 0;
            Ultimo = map.getUltimoPedido();
            foreach (DataRow fila in Ultimo.Rows)
            {
                u = fila["Ultimo"].ToString();
                if (fila["Ultimo"].ToString() != "")
                    lblPedido.Text = "#" + (int.Parse(fila["Ultimo"].ToString())).ToString();
                else
                    lblPedido.Text = "#" + 1;
            }
            var ProductosPedido = new DataTable();
            string[] Datos = { u };
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
            x = mar.getDatosDentista(this.Datos);
            DataRow z = x.Rows[0];
            lblCedula.Text = z["Cedula"].ToString();
            lblDentista.Text = z["Nombre"].ToString();
            string[]Datos1={ lblPedido.Text.Substring(1) };
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

        private void pBAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Pedido))
                {
                    frm.Show();
                }
            }
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

                objForm.Pedido = idPed;

                objForm.ShowDialog();
                checkBox1.Enabled = false;
            }
            else
                MessageBox.Show("No se puede Elaborar una forma de pedido sin productos");
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

        private void Total_Activated(object sender, EventArgs e)
        {
            RellenarTODO();
        }
    }
}
