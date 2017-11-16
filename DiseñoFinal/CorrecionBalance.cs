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
        private void load() {
            saldoActual = manejadorBanco.GetSaldoEnBanco();
            textBox1.Text = "$ " + saldoActual.ToString("n", System.Globalization.CultureInfo.CurrentCulture) + " MXN";
            textBox2.Text = saldoActual.ToString("n", System.Globalization.CultureInfo.CurrentCulture);
        }
        private void CorrecionBalance_Load(object sender, EventArgs e)
        {
            load();
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad =  Convert.ToDouble(textBox2.Text) - saldoActual;
            if (cantidad > 0)
                manejadorBanco.InsertIngreso(Program.Loginn, cantidad);
            else if (cantidad < 0)
                manejadorBanco.InsertRetiro(Program.Loginn, cantidad);
            MessageBox.Show("Operación realizada con exito");
            load();
        }

        private void CorrecionBalance_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }
    }
}
