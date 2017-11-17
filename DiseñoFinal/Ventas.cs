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
using DiseñoFinal.ReportesM;

namespace DiseñoFinal
{
    public partial class Ventas : Form
    {
        float Abono, SaldoActual, SaldoAbono, Importe, Restante;
        InterfaceUsuario It;
        ManejadorControlPedido mcp;
        Validación v = new Validación();
        int filaactual = 0;
        string Usuarioencurso;

        private void Ventas_Activated(object sender, EventArgs e)
        {
            LlenaPrincipal();
        }
        private void LlenaPrincipal()
        {
            var PedidosSinPagar = new DataTable();
            mcp = new ManejadorControlPedido();
            string[] Datos = new string[0];
            PedidosSinPagar = mcp.getPedidosSinPagar(Datos);
            dataPedidos.DataSource = PedidosSinPagar;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataPedidos.Rows.Count != 0)
            {
                string[] Datos = { dataPedidos[0, filaactual].Value.ToString() };
                mcp = new ManejadorControlPedido();
                var Pedidos = new DataTable();
                Pedidos = mcp.getTicket(Datos);
                dataPedido.DataSource = Pedidos;
                txtSaldoActual.Text = dataPedidos[8, filaactual].Value.ToString();
                txtImporte.Text = txtAbono.Text;
                txtAbono.Text = txtSaldoActual.Text;
                if (dataPedidos.Enabled == true)
                    dataPedidos.Enabled = false;
                else
                    dataPedidos.Enabled = true;
            }
            else
                MessageBox.Show("No hay pedido que seleccionar");
        }

        private void dataPedidos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
        }

        private void txtImporte_Enter(object sender, EventArgs e)
        {
            txtImporte.SelectAll();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text != "0" && txtImporte.Text != "")
            {
                DateTime localdate = DateTime.Now.Date;
                TimeSpan localtime = DateTime.Now.TimeOfDay;
                string año, mes, dia, hora;
                año = localdate.Year.ToString();
                mes = localdate.Month.ToString();
                dia = localdate.Day.ToString();
                hora = localtime.ToString();
                string[] Datos = { dataPedidos[0, filaactual].Value.ToString(), txtImporte.Text, txtAbono.Text, txtRestante.Text, año + "/" + mes + "/" + dia + " " + hora.Substring(0, 12), Usuarioencurso, comboBox1.Text, richTextBox1.Text };
                mcp = new ManejadorControlPedido();
                int n = mcp.PagarVenta(Datos);
                if (n == 0)
                {
                    MessageBox.Show("No hubo transaccion");

                }
                else
                {
                    if (comboBox1.Text != "Efectivo")
                    {
                        Datos = new string[] { txtAbono.Text };
                        mcp.ActualizaBanco(Datos);
                    }
                    DataTable ultimocorte = mcp.UltimoCorte(new string[0]);
                    Datos = new string[] { dataPedidos[0, filaactual].Value.ToString(), txtSaldoAbono.Text };
                    mcp.ActualizaRestante(Datos);
                    Datos = new string[] { año + "-" + mes + "-" + dia };
                    var DatosTabla = new DataTable();
                    DatosTabla = mcp.VentasDelDia(Datos);
                    float CajaMaxima;
                    if (DatosTabla.Rows[0][0].ToString() != "")
                        CajaMaxima = float.Parse(DatosTabla.Rows[0][0].ToString()) + float.Parse(ultimocorte.Rows[0][5].ToString()); //1500 de caja chica
                    else
                        CajaMaxima = float.Parse(ultimocorte.Rows[0][5].ToString());
                    DatosTabla = mcp.UltimaVenta(Datos);
                    VIstaPreviaTicket objForm = new VIstaPreviaTicket();
                    string Folio = DatosTabla.Rows[0]["FolioVenta"].ToString();
                    objForm.Folio = Folio;
                    objForm.ShowDialog();
                    DatosTabla = mcp.RetirosDelDia(Datos);
                    if (DatosTabla.Rows[0][0].ToString() != "")
                        CajaMaxima -= float.Parse(DatosTabla.Rows[0][0].ToString());
                    if (CajaMaxima > float.Parse(ultimocorte.Rows[0][22].ToString()))
                    {
                        //Anunciar caja maxima
                        DialogResult resultado;
                        resultado = (MessageBox.Show("La caja se encuentra en su punto máximo, favor de realizar retiro por caja llena. ¿Desea realizar el retiro ahora?", "Caja Llena", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                        if (resultado == DialogResult.Yes)
                        {
                            Datos = new string[] { Usuarioencurso };
                            It.enviarEvento("PantallaRetiro", Datos);
                        }
                        else
                            MessageBox.Show("Favor de realizar el retiro lo antes posible", "Hacer Retiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    dataPedidos.Enabled = true;
                    LlenaPrincipal();
                    llenatxt();
                }
            }
                
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Irnos a la ventana de reportes de venta y cortes de caja
        }

        private void llenatxt()
        {
            txtAbono.Text = "0.00";
            txtSaldoActual.Text = "0.00";
            txtSaldoAbono.Text = "0.00";
            txtImporte.Text = "0.00";
            txtRestante.Text = "0.00";
            richTextBox1.Text = "";
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            string[] Datos = { Usuarioencurso };
            It.enviarEvento("PantallaCaja", Datos);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        { 
            string[] Datos = new string[] { Usuarioencurso };
            It.enviarEvento("PantallaRetiro", Datos);
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[] { Usuarioencurso };
            It.enviarEvento("PantallaEntregas", Datos);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                LlenaPrincipal();
            }
            else if (rbtnNombre.Checked == true)
            {
                string[] Datos = { "", txtBusqueda.Text+e.KeyChar };
                mcp = new ManejadorControlPedido();
                var Pedidos = new DataTable();
                Pedidos = mcp.PedidosSinPagarBuscar(Datos);
                dataPedidos.DataSource = Pedidos;
            }
            else if (rbtnPedido.Checked == true)
            {
                string[] Datos = { txtBusqueda.Text + e.KeyChar, "" };
                mcp = new ManejadorControlPedido();
                var Pedidos = new DataTable();
                Pedidos = mcp.PedidosSinPagarBuscar(Datos);
                dataPedidos.DataSource = Pedidos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerTickets ver = new VerTickets();
            ver.ShowDialog();
        }

        public Ventas(string Usuario)
        {
            InitializeComponent();
            llenatxt();
            Abono = float.Parse(txtAbono.Text);
            SaldoActual = float.Parse(txtSaldoActual.Text);
            SaldoAbono = float.Parse(txtSaldoAbono.Text);
            Importe = float.Parse(txtImporte.Text);
            Restante = float.Parse(txtRestante.Text);
            It = new InterfaceUsuario(this);
            Usuarioencurso = Usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Recepcion))
                    {
                        frm.Show();
                    }
                }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            
            if (txtAbono.Text != "" && txtSaldoActual.Text != "" && txtImporte.Text != "" && txtRestante.Text != "")
            {
                SaldoActual = float.Parse(txtSaldoActual.Text);
                Importe = float.Parse(txtImporte.Text);
                Abono = float.Parse(txtAbono.Text);
                Restante = Importe - Abono;
                txtRestante.Text = Restante.ToString();
                if (Restante >= 0)
                {
                    SaldoAbono = SaldoActual - Abono;
                    if (SaldoAbono >= 0)
                    {
                        txtSaldoAbono.Text = SaldoAbono.ToString();
                    }
                    else
                    {
                        //Calcular automaticamente el abono para que quede en ceros la cuenta.
                    }
                }
                //else
                    //MessageBox.Show("No se puede abonar mas del importe");
            }
        }
    }
}
