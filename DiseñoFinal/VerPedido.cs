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
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
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
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
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
                if (lblStatus.Text != "EN PROCESO" && lblStatus.Text != "FINALIZADO" && lblStatus.Text != "FACTURADO" && lblStatus.Text!= "CONFIRMADO" && lblStatus.Text != "ENTREGADO")
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
            float Total = 0;
            lblPedido.Text = "#" + Datos[0];
            var ProductosPedido = new DataTable();
            ProductosPedido = map.getDatosProductosPedido(Datos);
            dataGridView1.DataSource = ProductosPedido;
            for (int j = 0; j < ProductosPedido.Rows.Count; j++)
            {
                Total += float.Parse(ProductosPedido.Rows[j]["SubTotal"].ToString());
            }
            try
            {
                var dentista = new DataTable();
                dentista = mar.selectCedulaNombre(Datos);
                DataRow fila = dentista.Rows[0];
                lblCedula.Text = fila["Cedula"].ToString().ToUpper();
                lblDentista.Text = v.reducirCadena(fila["Nombre"].ToString().ToUpper()) + " " + v.reducirCadena(fila["Apellidos"].ToString().ToUpper());
                string[] Datos1 = { lblPedido.Text.Substring(1), "", "", "", "", "", "", "", "" };
                var Pedido = new DataTable();
                Pedido = map.selectPedido(Datos);
                DataRow fila1 = Pedido.Rows[0];
                lblStatus.Text = v.reducirCadena(fila1["EstatusPedido"].ToString());
                lblFechaSolicitud.Text = v.reducirCadena(fila1["FechaIngreso"].ToString().Substring(0,10));
                lblFechaEstimada.Text = v.reducirCadena(fila1["FechaCalculada"].ToString()).Substring(0,10);
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
                        Datos[2] = "POR CONFIRMAR";
                    else
                        Datos[2] = fila["Estatus"].ToString();
                    Datos[5] = fila["FechaEntrega"].ToString();
                    Datos[6] = fila["Urgencia"].ToString();
                    Datos[7] = fila["Fabricante"].ToString();
                    Datos[8] = fila["Total"].ToString();
                    It.enviarEvento("GenerarPedido", Datos);

                    //string[] Datos1 = { lblPedido.Text.Substring(1), UsuarioEnCurso, v.FormatoFecha(DateTime.Now)
                    //    //v.FormatoFecha(dateTimePicker1.Value)
                    //};
                    //It.enviarEvento("Registrar Datos Forma", Datos1);
                    VistaPreviaForma objForm = new VistaPreviaForma();
                    string idPed = lblPedido.Text.Substring(1);
                    objForm.Pedido = idPed;
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
                    if (lblStatus.Text == "POR CONFIRMAR" || lblStatus.Text == "SIN CONFIRMAR")
                    {
                        string[] Datos = new string[17];
                        Datos[0] = lblPedido.Text.Substring(1);
                        var Pedido = new DataTable();
                        Pedido = map.selectPedido(Datos);
                        DataRow fila = Pedido.Rows[0];
                        Datos[0] = fila["IDPedido"].ToString();
                        Datos[1] = fila["IDDentista"].ToString();
                        Datos[2] = fila["IDEmpleado"].ToString();
                        Datos[3] = "CONFIRMADO";
                        Datos[4] = fila["FechaIngreso"].ToString().Substring(0, 10);
                        string z = Datos[4];
                        Datos[4] = z.Substring(6);
                        Datos[4] += "-" + z.Substring(3, 2);
                        Datos[4] += "-" + z.Substring(0, 2);
                        Datos[5] = fila["FechaCalculada"].ToString().Substring(0,10);
                        z = Datos[5];
                        Datos[5] = z.Substring(6);
                        Datos[5] += "-" + z.Substring(3, 2);
                        Datos[5] += "-" + z.Substring(0, 2);
                        if (fila["FechaEntrega"].ToString() != "")
                        {
                            Datos[6] = fila["FechaEntrega"].ToString().Substring(0, 10);
                            z = Datos[6];
                            Datos[6] = z.Substring(6);
                            Datos[6] += "-" + z.Substring(3, 2);
                            Datos[6] += "-" + z.Substring(0, 2);
                        }
                        else
                            Datos[6] = "1900-01-01";
                        Datos[7] = fila["Urgencia"].ToString();
                        Datos[8] = fila["CostoTotal"].ToString();
                        Datos[9] = fila["Laboratorista"].ToString();
                        Datos[10] = fila["Pagado"].ToString();
                        Datos[11] = fila["RestantePorPagar"].ToString();
                        Datos[12] = fila["IVA"].ToString();
                        Datos[13] = fila["Devuelto"].ToString();
                        if (fila["FechaDevolucion"].ToString() != "")
                        {
                            Datos[14] = fila["FechaDevolucion"].ToString().Substring(0, 10);
                            z = Datos[14];
                            Datos[14] = z.Substring(6);
                            Datos[14] += "-" + z.Substring(3, 2);
                            Datos[14] += "-" + z.Substring(0, 2);
                        }
                        else
                            Datos[14] = "1900-01-01";
                        Datos[15] = fila["Modificacion"].ToString();
                        if (fila["FechaModificacion"].ToString() != "")
                        {
                            Datos[16] = fila["FechaModificacion"].ToString().Substring(0, 10);
                            z = Datos[16];
                            Datos[16] = z.Substring(6);
                            Datos[16] += "-" + z.Substring(3, 2);
                            Datos[16] += "-" + z.Substring(0, 2);
                        }
                        else
                            Datos[16] = "1900-01-01";
                        It.enviarEvento("GenerarPedido", Datos);
                        MessageBox.Show("Pedido Confirmado");
                    }

                    string[] Datos1 = { lblPedido.Text.Substring(1), UsuarioEnCurso, v.FormatoFecha(DateTime.Now), v.FormatoFecha(DateTime.Now) };
                    It.enviarEvento("Registrar Datos Oficio", Datos1);
                    VistaPreviaOficio objForm = new VistaPreviaOficio();
                    string idPed = lblPedido.Text.Substring(1);
                    objForm.Pedido = idPed;
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
                v.reducirCadena(lblStatus.Text) != "CONFIRMADO" &&
                v.reducirCadena(lblStatus.Text)!= "ENTREGADO")
            {
                DialogResult x = MessageBox.Show("¿Seguro que desea cancelar el pedido?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (x == DialogResult.Yes)
                {
                    string[] Datos = new string[17];
                    Datos[0] = lblPedido.Text.Substring(1);
                    var Pedido = new DataTable();
                    Pedido = map.selectPedido(Datos);
                    DataRow fila = Pedido.Rows[0];
                    Datos[0] = fila["IDPedido"].ToString();
                    Datos[1] = fila["IDDentista"].ToString();
                    Datos[2] = fila["IDEmpleado"].ToString();
                    Datos[3] = "CANCELADO";
                    Datos[4] = fila["FechaIngreso"].ToString();
                    Datos[5] = fila["FechaCalculada"].ToString();
                    Datos[6] = fila["FechaEntrega"].ToString();
                    Datos[7] = fila["Urgencia"].ToString();
                    Datos[8] = fila["CostoTotal"].ToString();
                    Datos[9] = fila["Laboratorista"].ToString();
                    Datos[10] = fila["Pagado"].ToString();
                    Datos[11] = fila["RestantePorPagar"].ToString();
                    Datos[12] = fila["IVA"].ToString();
                    Datos[13] = fila["Devuelto"].ToString();
                    Datos[14] = DateTime.Now.ToShortDateString();
                    string z = Datos[14];
                    Datos[14] = z.Substring(6);
                    Datos[14] += "-" + z.Substring(3, 2);
                    Datos[14] += "-" + z.Substring(0, 2);
                    Datos[15] = fila["Modificacion"].ToString();
                    Datos[16] = fila["FechaModificacion"].ToString();
                    It.enviarEvento("GenerarPedido", Datos);
                    MessageBox.Show("Pedido Cancelado");
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
