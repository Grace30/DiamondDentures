using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidad;

namespace DiseñoFinal
{
    public partial class PagoAEmpleados : Form
    {

        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        bool tablalista = false;
        bool marcarTodo = false;
        public PagoAEmpleados()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void PagoAEmpleados_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Calculando..." });
            tablalista = false;
            dataGridView1.RowCount = 1;
            List<string> listempleados = manejadorUsuario.listaDeUsuarios().ToList();

            List<Salario> salarios = new List<Salario>();

            for (int i = 0; i < listempleados.Count; i++)
            {
                salarios.Add(manejadorUsuario.calcularPagoPorMes(listempleados[i], Convert.ToInt32(comboBox1.SelectedIndex + 1)));
            }
            dataGridView1.RowCount = listempleados.Count;
            for (int i = 0; i < listempleados.Count; i++)
            {
                dataGridView1["Mes", i].Value = salarios[i].mes;
                dataGridView1["Usuario", i].Value = salarios[i].usuario;
                dataGridView1["IdPago", i].Value = salarios[i].idPago;
                dataGridView1["SalarioDiario", i].Value = salarios[i].salarioDiario;
                dataGridView1["DiasTrabajados", i].Value = salarios[i].dias;
                dataGridView1["Sueldo", i].Value = salarios[i].sueldo;
                dataGridView1["TasaISR", i].Value = salarios[i].tasaISR;
                dataGridView1["CuotaISR", i].Value = salarios[i].cuotaISR;
                dataGridView1["APagar", i].Value = salarios[i].aPagar;
                dataGridView1["Pagar", i].Value = false;

                if (salarios[i].idPago == "No Pagado ")
                    dataGridView1["IdPago", i].Style.ForeColor = Color.Red;
                //else
                //((DataGridViewCheckBoxCell)dataGridView1["Pagar", i].Value).


            }
            if (dataGridView1.RowCount > 0)
                tablalista = true;
            else
                tablalista = false;
            statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Listo" });
        }



        private void button3_Click(object sender, EventArgs e)
        {
            List<string> empleadosApagar = new List<string>();
            List<double> CantidadApagar = new List<double>();
            string msg = "";
            double totalAPagar = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1["Pagar", i].Value == true)
                {
                    msg += dataGridView1["Usuario", i].Value.ToString() + "\r\n";

                    string money = dataGridView1["APagar", i].Value.ToString().Split('$')[1];
                    totalAPagar += Convert.ToDouble(money);
                    empleadosApagar.Add(dataGridView1["Usuario", i].Value.ToString().TrimEnd());
                    CantidadApagar.Add(Convert.ToDouble(money));
                }

            }
            if (MessageBox.Show(msg + "\r\nTotal a pagar: " + totalAPagar.ToString("C2"), "Empleados", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (manejadorUsuario.GetSaldoEnBanco() < totalAPagar)
                    MessageBox.Show("No se puede realizar el pago debido a saldo insuficiente");
                else
                {
                    for (int i = 0; i < empleadosApagar.Count; i++)
                    {
                        statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] {"Generando pago para el empleado " + empleadosApagar[i] + "..."});
                        //Thread newThread = new Thread(CambiarMensaje);
                        //newThread.Start("Generando pago para el empleado " + empleadosApagar[i] + "...");
                        manejadorUsuario.PagarAEmpleado(empleadosApagar[i], CantidadApagar[i], comboBox1.SelectedIndex + 1);
                        //newThread = new Thread(CambiarMensaje);
                        //newThread.Start("Listo");

                    }
                    statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Listo" });
                    MessageBox.Show("Pago realizado");
                    
                }
            }
            button1.PerformClick();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tablalista)
                if (e.ColumnIndex == 9)
                {
                    if (dataGridView1["IdPago", e.RowIndex].Value.ToString() != "No Pagado ")
                    {
                        if (marcarTodo == false)
                            MessageBox.Show("Ya se le pago a este empleado");
                        dataGridView1["Pagar", e.RowIndex].Value = false;
                    }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].Value == true)
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = false;
                else
                {

                    if (dataGridView1["IdPago", e.RowIndex].Value.ToString() != "No Pagado ")
                    {
                        MessageBox.Show("Ya se le pago a este empleado");
                        dataGridView1["Pagar", e.RowIndex].Value = false;
                    }
                    else
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = !((bool)dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MarcarDesmarcar(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcarDesmarcar(true);
        }

        private void MarcarDesmarcar(bool estado)
        {
            marcarTodo = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1["Pagar", i].Value = estado;
            }
            marcarTodo = false;
        }
        private void CambiarMensaje(string mensaje)
        { 
            toolStripStatusLabel1.Text = mensaje;
            statusStrip1.Refresh();
        }
        public delegate void CambiarMensajeCallBack(string msg);

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex<11)
                comboBox1.SelectedIndex++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
                comboBox1.SelectedIndex--;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Mes.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            button1.PerformClick();
        }
    }
}
 
