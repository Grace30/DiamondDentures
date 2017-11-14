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
    public partial class CorrecionBalance : Form
    {
        ManejadorBanco manejadorBanco = new ManejadorBanco();
        double saldoActual = 0;

        public CorrecionBalance()
        {
            InitializeComponent();
        }

        private void CorrecionBalance_Load(object sender, EventArgs e)
        {
            saldoActual = manejadorBanco.GetSaldoEnBanco();
            textBox1.Text = "$ " + saldoActual.ToString("n", System.Globalization.CultureInfo.CurrentCulture)+ " MXN";
            textBox2.Text = saldoActual.ToString("n", System.Globalization.CultureInfo.CurrentCulture);
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad =  Convert.ToDouble(textBox2.Text) - saldoActual;
            if (cantidad > 0)
                manejadorBanco.InsertIngreso(saldoActual + cantidad);
            else if (cantidad < 0)
                manejadorBanco.InsertRetiro(saldoActual + cantidad);
        }

        private void CorrecionBalance_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }
    }
}
