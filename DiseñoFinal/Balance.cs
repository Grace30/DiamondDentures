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
    public partial class Balance : Form
    {
		ManejadorBanco manejadorBanco = new ManejadorBanco();
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        ManejadorBanco manejadorBanco = new ManejadorBanco();
        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            cbox_Año.Items.Clear();
            cbox_Año.Items.AddRange(manejadorBanco.getAñoBalance());
            if (cbox_Año.Items.Count > 0)
                cbox_Año.SelectedIndex = 0;

            cbox_Mes.Items.Clear();
            cbox_Mes.Items.AddRange(manejadorBanco.getPeriodosBalance(Convert.ToInt32(cbox_Año.Items[cbox_Año.SelectedIndex])));
            if (cbox_Mes.Items.Count > 0)
                cbox_Mes.SelectedIndex = 0;

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DataTable t = manejadorBanco.getBalance(dateDesde.Value, dateHasta.Value);
            dataGridView1.DataSource = t;
            if (t.Rows.Count > 0)
            {
                dataGridView1.Columns[0].FillWeight = 70;
                dataGridView1.Columns[1].FillWeight = 230;
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Height = 40;
                double[] Totales = manejadorBanco.getTotalesBalance(dateDesde.Value, dateHasta.Value);
                txt_TotalRetiros.Text = Totales[0].ToString("c2", System.Globalization.CultureInfo.CurrentCulture);
                txt_TotalDepositos.Text = Totales[1].ToString("c2", System.Globalization.CultureInfo.CurrentCulture);
            }
            else
                MessageBox.Show("No se encontraron resultados");



        }
        string[] mesesArray = new string[] { "Enero", "Feberero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int año = Convert.ToInt32(cbox_Año.Items[cbox_Año.SelectedIndex]);
            int mes = mesesArray.ToList().IndexOf(cbox_Mes.Items[cbox_Mes.SelectedIndex].ToString());
            int dia = DateTime.DaysInMonth(año, mes+1);
            dateDesde.Value = new DateTime(año, mes+1, 1);
            dateHasta.Value = new DateTime(año, mes+1, dia);
        }
    }
}
