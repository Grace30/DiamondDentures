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
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();

        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DataTable t = manejadorUsuario.getBalance(dateDesde.Value, dateHasta.Value);
            dataGridView1.DataSource = t;
            dataGridView1.Columns[0].FillWeight = 70;
            dataGridView1.Columns[1].FillWeight = 230;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 40;
        }
    }
}
