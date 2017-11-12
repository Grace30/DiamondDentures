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
    public partial class VerPedido : Form
    {
        InterfaceUsuario It;
        ManejadorPrincipal map = new ManejadorPrincipal();
        ManejadorRegistroDentista mar = new ManejadorRegistroDentista();
        Validación v = new Validación();
        string[] Datos;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form pantalla;
        public VerPedido(string[] Datos)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.Datos = Datos;
        }
        public VerPedido(string[] Datos, Form pantalla)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.Datos = Datos;
            this.pantalla = pantalla;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Pedidos))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Pedidos))
                    {
                        frm.Show();
                    }
                }
            }
            else if(pantalla.GetType() == typeof(ControlPedidos))
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text != "CANCELADO")
            {
                if (lblStatus.Text != "EN PROCESO" && lblStatus.Text != "FINALIZADO" && lblStatus.Text != "FACTURADO")
                {
                    string[] Datos = { this.Datos[0], this.Datos[1], this.Datos[2], this.Datos[3], lblCedula.Text, "VerPedido" };
                    It.enviarEvento("ActualizarPedido", Datos);
                }
                else
                    MessageBox.Show("No se puede modificar un pedido en proceso");
            }
            else
                MessageBox.Show("Pedido Cancelado");
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
            try
            {
                var dentista = new DataTable();
                dentista = mar.selectCedulaNombre(Datos);
                DataRow fila = dentista.Rows[0];
                lblCedula.Text = fila["Cedula"].ToString().ToUpper();
                lblDentista.Text = fila["Nombre"].ToString().ToUpper();
                string[] Datos1 = { lblPedido.Text.Substring(1), "", "", "", "", "", "", "", "" };
                var Pedido = new DataTable();
                Pedido = map.selectPedido(Datos);
                DataRow fila1 = Pedido.Rows[0];
                lblStatus.Text = v.reducirCadena(fila1["Estatus"].ToString());
                lblFechaSolicitud.Text = v.reducirCadena(fila1["FechaIngreso"].ToString());
                lblFechaEstimada.Text = v.reducirCadena(fila1["FechaCalculada"].ToString());
            }
            catch (Exception) { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text != "CANCELADO")
            {
                if (dataGridView1.ColumnCount != 0)
                {
                    string[] Datos = { lblPedido.Text.Substring(1), "", "", "", "", "", "", "", "" };
                    var Pedido = new DataTable();
                    Pedido = map.selectPedido(Datos);
                    DataRow fila = Pedido.Rows[0];
                    if (v.reducirCadena(fila["Estatus"].ToString()) != "CONFIRMADO")
                    {
                        if (fila["Urgencia"].ToString() == "SI")
                            Datos[4] = CalculaFecha(0);
                        else
                            Datos[4] = CalculaFecha(3);
                        Datos[3] = DateTime.Now.ToShortDateString();
                    }
                    else
                    {
                        Datos[3] = fila["FechaIngreso"].ToString();
                        Datos[4] = fila["FechaCalculada"].ToString();
                    }
                    Datos[0] = fila["IDPedido"].ToString();
                    Datos[1] = fila["IDDentista"].ToString();
                    if (v.reducirCadena(fila["Estatus"].ToString()) == "SIN ELABORAR")
                        Datos[2] = "SIN CONFIRMAR";
                    else
                        Datos[2] = fila["Estatus"].ToString();
                    Datos[5] = fila["FechaEntrega"].ToString();
                    Datos[6] = fila["Urgencia"].ToString();
                    Datos[7] = fila["Fabricante"].ToString();
                    Datos[8] = fila["Total"].ToString();
                    It.enviarEvento("GenerarPedido", Datos);
                    VistaPreviaForma objForm = new VistaPreviaForma();

                    string idPed = lblPedido.Text.Substring(1);

                    objForm.Folio = idPed;

                    objForm.ShowDialog();
                }
                else
                    MessageBox.Show("No puede generarse una forma de pedido sin productos");
            }
            else
                MessageBox.Show("Pedido Cancelado");
        }

        public string CalculaFecha(int dias)
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
            return hoy.ToShortDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text != "CANCELADO")
            {
                if (lblStatus.Text != "SIN ELABORAR")
                {
                    if (lblStatus.Text == "POR CONFIRMAR")
                    {
                        MessageBox.Show("Pedido Confirmado");
                        string[] Datos = { lblPedido.Text.Substring(1), "", "", "", "", "", "", "", "" };
                        var Pedido = new DataTable();
                        Pedido = map.selectPedido(Datos);
                        DataRow fila = Pedido.Rows[0];
                        if (fila["Estatus"].ToString() != "CONFIRMADO")
                        {
                            if (fila["Urgencia"].ToString() == "SI")
                                Datos[4] = CalculaFecha(0);
                            else
                                Datos[4] = CalculaFecha(3);
                            Datos[3] = DateTime.Now.ToShortDateString();
                        }
                        else
                        {
                            Datos[3] = fila["FechaIngreso"].ToString();
                            Datos[4] = fila["FechaCalculada"].ToString();
                        }
                        Datos[0] = fila["IDPedido"].ToString();
                        Datos[1] = fila["IDDentista"].ToString();
                        Datos[2] = "CONFIRMADO";
                        Datos[5] = fila["FechaEntrega"].ToString();
                        Datos[6] = fila["Urgencia"].ToString();
                        Datos[7] = fila["Fabricante"].ToString();
                        Datos[8] = fila["Total"].ToString();
                        It.enviarEvento("GenerarPedido", Datos);
                    }
                    VistaPreviaOficio objForm = new VistaPreviaOficio();

                    string idPed = lblPedido.Text.Substring(1);

                    objForm.Folio = idPed;

                    objForm.ShowDialog();
                }
                else
                    MessageBox.Show("No se puede confirmar un pedido sin estar elaborado, favor de elaborar");
            }
            else
                MessageBox.Show("Pedido Cancelado");
            RellenarTODO();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (v.reducirCadena(lblStatus.Text) != "FACTURADO" &&
                v.reducirCadena(lblStatus.Text) != "FINALIZADO" &&
                v.reducirCadena(lblStatus.Text) != "EN PROCESO" &&
                v.reducirCadena(lblStatus.Text) != "CONFIRMADO")
            {
                DialogResult x = MessageBox.Show("¿Seguro que desea cancelar el pedido?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (x == DialogResult.Yes)
                {
                    MessageBox.Show("Pedido Cancelado");
                    string[] Datos = { lblPedido.Text.Substring(1), "", "", "", "", "", "", "", "" };
                    var Pedido = new DataTable();
                    Pedido = map.selectPedido(Datos);
                    DataRow fila = Pedido.Rows[0];
                    if (fila["Estatus"].ToString() != "CONFIRMADO")
                    {
                        if (fila["Urgencia"].ToString() == "SI")
                            Datos[4] = CalculaFecha(0);
                        else
                            Datos[4] = CalculaFecha(3);
                        Datos[3] = DateTime.Now.ToShortDateString();
                    }
                    else
                    {
                        Datos[3] = fila["FechaIngreso"].ToString();
                        Datos[4] = fila["FechaCalculada"].ToString();
                    }
                    Datos[0] = fila["IDPedido"].ToString();
                    Datos[1] = fila["IDDentista"].ToString();
                    Datos[2] = "CANCELADO";
                    Datos[5] = fila["FechaEntrega"].ToString();
                    Datos[6] = "NO";
                    Datos[7] = fila["Fabricante"].ToString();
                    Datos[8] = fila["Total"].ToString();
                    It.enviarEvento("GenerarPedido", Datos);
                }
            }
            else
                MessageBox.Show("Pedido imposible de cancelar");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
                Application.Exit();
        }

        private void VerPedido_Activated(object sender, EventArgs e)
        {
            RellenarTODO();
        }
    }
}
