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

namespace DiseñoFinal
{
    public partial class Entregas : Form
    {
        string UsuarioActual;
        Form Pantalla;
        ManejadorControlPedido mcp;
        int filaactual;
        public Entregas(string usuarioactual, Form pantalla)
        {
            InitializeComponent();
            UsuarioActual = usuarioactual;
            Pantalla = pantalla;
        }

        private void Entregas_Activated(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
            string []Datos = new string[] { dataGridView1[0, filaactual].Value.ToString() };
            mcp = new ManejadorControlPedido();
            var Pedidos = mcp.getTicket(Datos);
            dataGridView2.DataSource = Pedidos;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now.Date;
            string año, mes, dia;
            año = localdate.Year.ToString();
            mes = localdate.Month.ToString();
            dia = localdate.Day.ToString();
            string[] Datos = { dataGridView1[0, filaactual].Value.ToString(), "Entregado", año + "-" + mes + "-" + dia };
            mcp = new ManejadorControlPedido();
            if (mcp.EntregaPedido(Datos) == 1)
                MessageBox.Show("Pedido Entregado");
            else
                MessageBox.Show("No se pudo entregar el pedido");
            llenaesta();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Pantalla.GetType() == typeof(Recepcion))
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Recepcion))
                    {
                        frm.Show();
                    }
                }
            else if (Pantalla.GetType() == typeof(Ventas))
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Ventas))
                    {
                        frm.Show();
                    }
                }
        }

        private void llenaesta()
        {
            string[] Datos = { };
            mcp = new ManejadorControlPedido();
            var Pedidos = new DataTable();
            Pedidos = mcp.PedidosPorEntregar(Datos);
            dataGridView1.DataSource = Pedidos;
            if (dataGridView1.Rows.Count != 0)
            {
                Datos = new string[] { dataGridView1[0, filaactual].Value.ToString() };
                mcp = new ManejadorControlPedido();
                Pedidos = mcp.getTicket(Datos);
                dataGridView2.DataSource = Pedidos;
            }
            else
                MessageBox.Show("No hay pedidos por entregar");
        }

        private void Entregas_Load(object sender, EventArgs e)
        {
            llenaesta();
        }
    }
}
