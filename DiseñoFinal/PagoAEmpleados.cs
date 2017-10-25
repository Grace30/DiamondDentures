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
    public partial class PagoAEmpleados : Form
    {
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        public PagoAEmpleados()
        {
            InitializeComponent();
        }

        private void PagoAEmpleados_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = DateTime.Now.Month - 1;
           
            
/*
            for (int i = 0; i < empleados.Rows.Count; i++)
                listempleados.Add(empleados.Columns[0].Table.Rows[i].ToString());

//            manejadorUsuario.calcularpagoAEmpleados(listempleados);




            DataTable asistencia1 = new DataTable();

            asistencia1.Columns.AddRange(new DataColumn[] { new DataColumn("Empleado"), new DataColumn("SalarioDiario"),
             new DataColumn("DiasTrabajados"), new DataColumn("Pago") });
            //dataGridView1.DataSource = asistencia1;

           
            int k = 0;
            int j = 0;
            dataGridView1.RowCount = listempleados.Count;

            foreach (var empleado in listempleados)
            {
                asistencia1 = manejadorUsuario.calcularPagoPorMes(empleado, 9);







                foreach (DataRow row in asistencia1.Rows)
                {
                    j = 0;
                    foreach (DataColumn column in asistencia1.Columns)
                    {
                        //                     row[column] obtiene el valor de las columnas de la fila
                        dataGridView1[k, j].Value = salarios[
                        //row[column] = row[column].ToString();
                        j++;
                    }
                    k++;
                }
            }

            /*



            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i,j].Value = 
                }
            }

    */




        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            List<string> listempleados = manejadorUsuario.listaDeUsuarios().ToList();

            List<Salario> salarios = new List<Salario>();

            for (int i = 0; i < listempleados.Count; i++)
            {
                salarios.Add(manejadorUsuario.calcularPagoPorMes(listempleados[i], Convert.ToInt32(comboBox1.SelectedIndex+1)));
            }
            dataGridView1.RowCount = listempleados.Count;
            for (int i = 0; i < listempleados.Count; i++)
            {
                dataGridView1[0, i].Value = salarios[i].mes;
                dataGridView1[1, i].Value = salarios[i].usuario;
                dataGridView1[2, i].Value = salarios[i].idPago;
                dataGridView1[3, i].Value = salarios[i].salarioDiario;
                dataGridView1[4, i].Value = salarios[i].dias;
                dataGridView1[5, i].Value = salarios[i].aPagar;

                dataGridView1[6 , i].Value = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[6, i].Value = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if((bool)dataGridView1[4,i].Value == true)
                    msg += dataGridView1[0, i].Value.ToString() + "\r\n";
            }
            MessageBox.Show(msg, "Empleados");
        }
    }
}
