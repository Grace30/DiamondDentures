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
    public partial class Retiro : Form
    {
        string UsuarioEnCurso;
        ManejadorControlPedido mcp;
        public Retiro(string Usuario)
        {
            InitializeComponent();
            UsuarioEnCurso = Usuario;
        }

        private void txtMil_TextChanged(object sender, EventArgs e)
        {
            float valor = 0;
            float cantidad = 0;
            float resultado = 0;
            if(txtMil.Text!="")
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
            if(txtRMil.Text!="" && txtRQuinientos.Text!="" && txtRDoscientos.Text!=""&&
                txtRCien.Text!=""&&txtRCincuenta.Text!=""&& txtRVeinte.Text!=""&&
                txtRDiez.Text!=""&&txtRCinco.Text!=""&&txtRDos.Text!=""&&txtRUno.Text!=""&&
                txtRCincuentaCentavos.Text!=""&&txtRVeinteCentavos.Text!=""&&txtRDiezCentavos.Text!=""&&
                txtRCincoCentavos.Text != "")
            {
                float rfinal = 0;
                rfinal = float.Parse(txtRMil.Text) + float.Parse(txtRQuinientos.Text) + float.Parse(txtRDoscientos.Text) +
                    float.Parse(txtRCien.Text) + float.Parse(txtRCincuenta.Text) + float.Parse(txtRVeinte.Text) +
                    float.Parse(txtRDiez.Text) + float.Parse(txtRCinco.Text) + float.Parse(txtRDos.Text) +
                    float.Parse(txtRUno.Text) + float.Parse(txtRCincuentaCentavos.Text) +
                    float.Parse(txtRVeinteCentavos.Text) + float.Parse(txtRDiezCentavos.Text) +
                    float.Parse(txtRCincoCentavos.Text);
                txtMonto.Text = rfinal.ToString();
                mcp = new ManejadorControlPedido();
                var Pedidos = new DataTable();
                //Fecha y caja chica (1500)
                DateTime localdate = DateTime.Now.Date;
                string año, mes, dia;
                año = localdate.Year.ToString();
                mes = localdate.Month.ToString();
                dia = localdate.Day.ToString();
                string[] Datos = { año + "-" + mes + "-" + dia};
                Pedidos = mcp.VentasDelDia(Datos);
                float ventas = 0, retiros = 0;
                if (Pedidos.Rows[0][0].ToString() != "")
                    ventas = float.Parse(Pedidos.Rows[0][0].ToString());
                Pedidos = mcp.RetirosDelDia(Datos);
                if (Pedidos.Rows[0][0].ToString() != "")
                    retiros = float.Parse(Pedidos.Rows[0][0].ToString());
                float restante = -rfinal;
                    restante = ventas + 1500 - retiros - rfinal; //1500 de caja chica
                txtRestante.Text = restante.ToString();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Admin")
            {
                int motivo = 0;
                if (comboBox1.Text == "Caja Llena")
                    motivo = 0;
                else
                    motivo = 1;
                string[] Datos = { };
                mcp = new ManejadorControlPedido();
                var Pedidos = mcp.UltimoCorte(Datos);
                int ultimocorte;
                if (Pedidos.Rows[0][0].ToString() != "NULL")
                    ultimocorte = int.Parse(Pedidos.Rows[0][0].ToString()) + 1;
                else
                    ultimocorte = 1;
                DateTime localdate = DateTime.Now.Date;
                string año, mes, dia, hora, minutos, segundos, milisegundos;
                año = localdate.Year.ToString();
                mes = localdate.Month.ToString();
                dia = localdate.Day.ToString();
                hora = DateTime.Now.Hour.ToString();
                minutos = DateTime.Now.Minute.ToString();
                segundos = DateTime.Now.Second.ToString();
                milisegundos = DateTime.Now.Millisecond.ToString();
                Datos = new string[] { ultimocorte.ToString(), año + "-" + mes + "-" + dia,
                    hora + ":" + minutos + ":" + segundos + ":" + milisegundos, txtMonto.Text, txtMil.Text,
                    txtQuinientos.Text, txtDosc.Text, txtCien.Text,
                    txtCincuenta.Text, txtVeinte.Text, txtDiez.Text, txtCinco.Text, txtDos.Text, txtUno.Text,
                    txtCincuentaCentavos.Text, txtVeinteCentavos.Text, txtDiezCentavos.Text, txtCincoCentavos.Text,
                    txtRestante.Text, UsuarioEnCurso, "Admin", motivo.ToString(), rtxtComentarios.Text };
                int x = mcp.InsertRetiro(Datos);
                if (x == 1)
                    MessageBox.Show("Retiro efectuado correctamente");
                else
                    MessageBox.Show("No se pudo efectuar el retiro");
            }
            else
                MessageBox.Show("Contraseña de administrador incorrecta");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Ventas))
                {
                    frm.Show();
                }
            }
        }
    }
}
