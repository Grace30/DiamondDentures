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
    public partial class Caja : Form
    {
        string UsuarioActual;
        ManejadorControlPedido mcp;
        Form Pantalla;
        public Caja(string Usuario)
        {
            InitializeComponent();
            UsuarioActual = Usuario;
            
        }

        public Caja(string Usuario, Form pantalla)
        {
            InitializeComponent();
            UsuarioActual = Usuario;
            Pantalla = pantalla;
            
        }

        private void CargaPantalla()
        {
            mcp = new ManejadorControlPedido();
            DateTime localdate = DateTime.Now.Date;
            string año, mes, dia;
            año = localdate.Year.ToString();
            mes = localdate.Month.ToString();
            dia = localdate.Day.ToString();
            string[] Datos = { año + "-" + mes + "-" + dia};
            var Pedido = new DataTable();
            Pedido = mcp.VentasDelDia(Datos);
            float ventas = 0;
            if (Pedido.Rows[0][0].ToString()!="")
                ventas = float.Parse(Pedido.Rows[0][0].ToString());
            Pedido = mcp.RetirosDelDia(Datos);
            float retiros = 0;
            if (Pedido.Rows[0][0].ToString() != "")
                retiros = float.Parse(Pedido.Rows[0][0].ToString());
            float cajaactual = ventas + 1500 - retiros; //1500 de caja chica
            Datos = new string[] { año + "-" + mes + "-" + dia };
            Pedido = mcp.RetirosPorCorte(Datos);
            if (Pedido.Rows[0][0].ToString() != "")
                txtEstimado.Text = (float.Parse(Pedido.Rows[0][0].ToString()) + cajaactual).ToString();
            else
                txtEstimado.Text = cajaactual.ToString();
            txtMil.Text = Pedido.Rows[0][1].ToString();
            txtQuinientos.Text = Pedido.Rows[0][2].ToString();
            txtDosc.Text = Pedido.Rows[0][3].ToString();
            txtCien.Text = Pedido.Rows[0][4].ToString();
            txtCincuenta.Text = Pedido.Rows[0][5].ToString();
            txtVeinte.Text = Pedido.Rows[0][6].ToString();
            txtDiez.Text = Pedido.Rows[0][7].ToString();
            txtCinco.Text = Pedido.Rows[0][8].ToString();
            txtDos.Text = Pedido.Rows[0][9].ToString();
            txtUno.Text = Pedido.Rows[0][10].ToString();
            txtCincuentaCentavos.Text = Pedido.Rows[0][11].ToString();
            txtVeinteCentavos.Text = Pedido.Rows[0][12].ToString();
            txtDiezCentavos.Text = Pedido.Rows[0][13].ToString();
            txtCincoCentavos.Text = Pedido.Rows[0][14].ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Falta validar que solo se haga un corte de caja por dia
            if(txtPassword.Text == "Admin")
            {
                DateTime localdate = DateTime.Now.Date;
                string año, mes, dia, hora, minutos, segundos, milisegundos;
                año = localdate.Year.ToString();
                mes = localdate.Month.ToString();
                dia = localdate.Day.ToString();
                hora = DateTime.Now.Hour.ToString();
                minutos = DateTime.Now.Minute.ToString();
                segundos = DateTime.Now.Second.ToString();
                milisegundos = DateTime.Now.Millisecond.ToString();
                mcp = new ManejadorControlPedido();
                var Tabla = new DataTable();
                string[] Datos = { año + "-" + mes + "-" + dia };
                Tabla = mcp.VentasConTarjeta(Datos);
                string banco = Tabla.Rows[0][0].ToString();
                float cajachica = float.Parse(txtRestante.Text) * -1;
                //Que se pueda cambiar el fondo de caja y la caja máxima.
                Datos = new string[]{ año + "-" + mes + "-" + dia,
                    hora + ":" + minutos + ":" + segundos + ":" + milisegundos, UsuarioActual,"Admin","1500" ,txtMil.Text,
                    txtQuinientos.Text, txtDosc.Text, txtCien.Text,
                    txtCincuenta.Text, txtVeinte.Text, txtDiez.Text, txtCinco.Text, txtDos.Text, txtUno.Text,
                    txtCincuentaCentavos.Text, txtVeinteCentavos.Text, txtDiezCentavos.Text, txtCincoCentavos.Text,
                    txtEstimado.Text, txtTotal.Text, "10000", banco, rtxtComentarios.Text };
                //Realizar un retiro aquí con todo
                if (mcp.CorteDeCaja(Datos) == 1)
                {
                    Tabla = mcp.UltimoCorte(new string[0]);
                    VistaPreviaCorte obj = new VistaPreviaCorte();
                    string Folio = Tabla.Rows[0][0].ToString();
                    obj.Folio = Folio;
                    obj.ShowDialog();
                }
                else
                    MessageBox.Show("No transaccion");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtVerCorte_Click(object sender, EventArgs e)
        {
            //string fecha = dateTimePicker1.Text;
            string dia, mes, año;
            //dia = fecha.Substring(0, 2);
            //mes = fecha.Substring(3, 2);
            //año = fecha.Substring(6, 4);
            //string[] Datos = { año + "/" + mes + "/" + dia };
            mcp = new ManejadorControlPedido();
            var Pedidos = new DataTable();
            //Pedidos = mcp.VentasPorCorte(Datos);
            //dataGridView1.DataSource = Pedidos;
            //Pedidos = mcp.ComprasPorCorte(Datos);
            //dataGridView2.DataSource = Pedidos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            if(Pantalla.GetType() == typeof(Recepcion))
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Recepcion))
                    {
                        frm.Show();
                    }
                }
            else if(Pantalla.GetType() == typeof(Ventas))
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Ventas))
                    {
                        frm.Show();
                    }
                }
        }

        private void txtMil_TextChanged(object sender, EventArgs e)
        {
            float valor = 0;
            float cantidad = 0;
            float resultado = 0;
            if (txtMil.Text != "")
            {
                valor = 1000;
                cantidad = float.Parse(txtMil.Text);
                resultado = valor * cantidad;
                txtRMil.Text = resultado.ToString();
            }
            if (txtQuinientos.Text != "")
            {
                valor = 500;
                cantidad = float.Parse(txtQuinientos.Text);
                resultado = valor * cantidad;
                txtRQuinientos.Text = resultado.ToString();
            }
            if (txtDosc.Text != "")
            {
                valor = 200;
                cantidad = float.Parse(txtDosc.Text);
                resultado = valor * cantidad;
                txtRDoscientos.Text = resultado.ToString();
            }
            if (txtCien.Text != "")
            {
                valor = 100;
                cantidad = float.Parse(txtCien.Text);
                resultado = valor * cantidad;
                txtRCien.Text = resultado.ToString();
            }
            if (txtCincuenta.Text != "")
            {
                valor = 50;
                cantidad = float.Parse(txtCincuenta.Text);
                resultado = valor * cantidad;
                txtRCincuenta.Text = resultado.ToString();
            }
            if (txtVeinte.Text != "")
            {
                valor = 20;
                cantidad = float.Parse(txtVeinte.Text);
                resultado = valor * cantidad;
                txtRVeinte.Text = resultado.ToString();
            }
            if (txtDiez.Text != "")
            {
                valor = 10;
                cantidad = float.Parse(txtDiez.Text);
                resultado = valor * cantidad;
                txtRDiez.Text = resultado.ToString();
            }
            if (txtCinco.Text != "")
            {
                valor = 5;
                cantidad = float.Parse(txtCinco.Text);
                resultado = valor * cantidad;
                txtRCinco.Text = resultado.ToString();
            }
            if (txtDos.Text != "")
            {
                valor = 2;
                cantidad = float.Parse(txtDos.Text);
                resultado = valor * cantidad;
                txtRDos.Text = resultado.ToString();
            }
            if (txtUno.Text != "")
            {
                valor = 1;
                cantidad = float.Parse(txtUno.Text);
                resultado = valor * cantidad;
                txtRUno.Text = resultado.ToString();
            }
            if (txtCincuentaCentavos.Text != "")
            {
                valor = 0.5f;
                cantidad = float.Parse(txtCincuentaCentavos.Text);
                resultado = valor * cantidad;
                txtRCincuentaCentavos.Text = resultado.ToString();
            }
            if (txtVeinteCentavos.Text != "")
            {
                valor = 0.2f;
                cantidad = float.Parse(txtVeinteCentavos.Text);
                resultado = valor * cantidad;
                txtRVeinteCentavos.Text = resultado.ToString();
            }
            if (txtDiezCentavos.Text != "")
            {
                valor = 0.1f;
                cantidad = float.Parse(txtDiezCentavos.Text);
                resultado = valor * cantidad;
                txtRDiezCentavos.Text = resultado.ToString();
            }
            if (txtCincoCentavos.Text != "")
            {
                valor = 0.05f;
                cantidad = float.Parse(txtCincoCentavos.Text);
                resultado = valor * cantidad;
                txtRCincoCentavos.Text = resultado.ToString();
            }
            if (txtRMil.Text != "" && txtRQuinientos.Text != "" && txtRDoscientos.Text != "" &&
                txtRCien.Text != "" && txtRCincuenta.Text != "" && txtRVeinte.Text != "" &&
                txtRDiez.Text != "" && txtRCinco.Text != "" && txtRDos.Text != "" && txtRUno.Text != "" &&
                txtRCincuentaCentavos.Text != "" && txtRVeinteCentavos.Text != "" && txtRDiezCentavos.Text != "" &&
                txtRCincoCentavos.Text != "")
            {
                float rfinal = 0;
                rfinal = float.Parse(txtRMil.Text) + float.Parse(txtRQuinientos.Text) + float.Parse(txtRDoscientos.Text) +
                    float.Parse(txtRCien.Text) + float.Parse(txtRCincuenta.Text) + float.Parse(txtRVeinte.Text) +
                    float.Parse(txtRDiez.Text) + float.Parse(txtRCinco.Text) + float.Parse(txtRDos.Text) +
                    float.Parse(txtRUno.Text) + float.Parse(txtRCincuentaCentavos.Text) +
                    float.Parse(txtRVeinteCentavos.Text) + float.Parse(txtRDiezCentavos.Text) +
                    float.Parse(txtRCincoCentavos.Text);
                txtTotal.Text = rfinal.ToString();
                float restante = rfinal - float.Parse(txtEstimado.Text);
                txtRestante.Text = restante.ToString();
            }
        }

        private void Caja_Activated(object sender, EventArgs e)
        {
            CargaPantalla();
        }
    }
}
