using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class Ventas : Form
    {
        float Abono, SaldoActual, SaldoAbono, Importe, Restante;
        public Ventas()
        {
            InitializeComponent();
            txtAbono.Text = "0.00";
            txtSaldoActual.Text = "0.00";
            txtSaldoAbono.Text = "0.00";
            txtImporte.Text = "0.00";
            txtRestante.Text = "0.00";
            Abono = float.Parse(txtAbono.Text);
            SaldoActual = float.Parse(txtSaldoActual.Text);
            SaldoAbono = float.Parse(txtSaldoAbono.Text);
            Importe = float.Parse(txtImporte.Text);
            Restante = float.Parse(txtRestante.Text);
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
            if (rbtnCedula.Checked == true)
            {

            }
            else if(rbtnNombre.Checked == true)
            {

            }
            else if(rbtnPedido.Checked == true)
            {

            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            SaldoActual = float.Parse(txtSaldoActual.Text);
            Importe = float.Parse(txtImporte.Text);
            Abono = float.Parse(txtAbono.Text);
            Restante = Importe - Abono;
            if (Restante >= 0)
            {
                SaldoAbono = SaldoActual - Abono;
                if(SaldoAbono >= 0)
                {
                    txtSaldoAbono.Text = SaldoAbono.ToString();
                }
                else
                {
                    //Calcular automaticamente el abono para que quede en ceros la cuenta.
                }
            }
            else
                MessageBox.Show("No se puede abonar mas del importe");
            

        }
    }
}
