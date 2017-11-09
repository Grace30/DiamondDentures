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
            data1.RowCount = 1;
            List<string> listempleados = manejadorUsuario.listaDeUsuarios().ToList();

            List<Salario> salarios = new List<Salario>();

            for (int i = 0; i < listempleados.Count; i++)
            {
                salarios.Add(manejadorUsuario.calcularPagoPorMes(listempleados[i], Convert.ToInt32(comboBox1.SelectedIndex + 1)));
            }
            data1.RowCount = listempleados.Count;
            for (int i = 0; i < listempleados.Count; i++)
            {
                data1["Mes", i].Value = salarios[i].mes;
                data1["Usuario", i].Value = salarios[i].usuario;
                data1["IdPago", i].Value = salarios[i].idPago;
                data1["SalarioDiario", i].Value = salarios[i].salarioDiario;
                data1["DiasTrabajados", i].Value = salarios[i].dias;
                data1["Sueldo", i].Value = salarios[i].sueldo;
                data1["TasaISR", i].Value = salarios[i].tasaISR;
                data1["CuotaISR", i].Value = salarios[i].cuotaISR;
                data1["APagar", i].Value = salarios[i].aPagar;
                data1["Pagar", i].Value = false;

                if (salarios[i].idPago == "No Pagado ")
                    data1["IdPago", i].Style.ForeColor = Color.Red;
                //else
                //((DataGridViewCheckBoxCell)dataGridView1["Pagar", i].Value).


            }
            if (data1.RowCount > 0)
                tablalista = true;
            else
                tablalista = false;
            statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Listo" }); 
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (data1[0, 0].Value.ToString() == comboBox1.Items[DateTime.Now.Month - 1].ToString() && DateTime.Now.Day <= DateTime.DaysInMonth(2017,comboBox1.SelectedIndex + 1))
            {
                if (MessageBox.Show("¿Desea pagar antes del fin de mes? \r\nDespués no será posible realizar ningún pago para los empleados seleccionados en este mes.", "Pago antes del día de pago", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    PagarAEmpleados();
            }
            else if((comboBox1.SelectedIndex + 1) < DateTime.Now.Month)
            {
                PagarAEmpleados();
            }
            
            
            
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tablalista)
                if (e.ColumnIndex == 9)
                {
                    if (data1["IdPago", e.RowIndex].Value.ToString() != "No Pagado ")
                    {
                        if (marcarTodo == false)
                            MessageBox.Show("Ya se le pago a este empleado");
                        data1["Pagar", e.RowIndex].Value = false;
                    }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if ((bool)data1[e.ColumnIndex, e.RowIndex].Value == true)
                    data1[e.ColumnIndex, e.RowIndex].Value = false;
                else
                {

                    if (data1["IdPago", e.RowIndex].Value.ToString() != "No Pagado ")
                    {
                        MessageBox.Show("Ya se le pago a este empleado");
                        data1["Pagar", e.RowIndex].Value = false;
                    }
                    else
                        data1[e.ColumnIndex, e.RowIndex].Value = !((bool)data1[e.ColumnIndex, e.RowIndex].Value);
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
            for (int i = 0; i < data1.RowCount; i++)
            {
                data1["Pagar", i].Value = estado;
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

        private void PagarAEmpleados()
        {
           // List<string> empleadosApagar = new List<string>();
            //List<double> CantidadApagar = new List<double>();
            List<Salario> Salarios = new List<Salario>();
            string msg = "";
            double totalAPagar = 0;

            for (int i = 0; i < data1.RowCount; i++)
            {
                if ((bool)data1["Pagar", i].Value == true)
                {
                    msg += data1["Usuario", i].Value.ToString().TrimEnd() + "\r\n";

                    Salarios.Add(new Salario((comboBox1.SelectedIndex+1).ToString(), 
                        data1["Usuario", i].Value.ToString(),
                        data1["SalarioDiario", i].Value.ToString(),
                        data1["DiasTrabajados", i].Value.ToString(),
                        data1["Sueldo", i].Value.ToString(),
                        data1["TasaISR", i].Value.ToString(),
                        data1["CuotaISR", i].Value.ToString(),
                        data1["APagar", i].Value.ToString(),
                          data1["IdPago", i].Value.ToString()));

                    totalAPagar += Convert.ToDouble(data1["APagar", i].Value.ToString().Split('$')[1]);
                   // empleadosApagar.Add(data1["Usuario", i].Value.ToString().TrimEnd());
                    //CantidadApagar.Add(Convert.ToDouble(money));
                }

            }
            if (MessageBox.Show(msg + "\r\nTotal a pagar: " + totalAPagar.ToString("C2"), "Empleados", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (manejadorUsuario.GetSaldoEnBanco() < totalAPagar)
                    MessageBox.Show("No se puede realizar el pago debido a saldo insuficiente");
                else
                {
                    for (int i = 0; i < Salarios.Count; i++)
                    {
                        statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Generando pago para el empleado " + Salarios[i].usuario + "..." });
                        
                        manejadorUsuario.PagarAEmpleado(Salarios[i].usuario,
                            Convert.ToDouble(Salarios[i].sueldo.Split('$')[1]),
                            int.Parse(Salarios[i].mes),
                            Salarios[i].tasaISR.Split('%')[0],
                            Salarios[i].cuotaISR.Split('$')[1]
                            ,Salarios[i].aPagar.Split('$')[1]);
                    }
                    statusStrip1.Invoke(new CambiarMensajeCallBack(CambiarMensaje), new object[] { "Listo" });
                    MessageBox.Show("Pago realizado");

                }
            }
            button1.PerformClick();
        }
    }
}
 
