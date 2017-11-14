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
    public partial class Nomina : Form
    {
        double saldo;
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        ManejadorBanco manejadorBanco = new ManejadorBanco();
        ManejadorRequisicion manejadorRequisicion = new ManejadorRequisicion();

        public Nomina()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            timerBanco.Start();
            timerRequisiciones.Start();
        }

        private void firmarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmarAsistencia frm = new FirmarAsistencia();
            frm.ShowDialog();
        }

        private void listadeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeAsistencia frm = new ListaDeAsistencia();
            frm.ShowDialog();
        }

        private void asistenciaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaPorEmpleado frm = new AsistenciaPorEmpleado();
            frm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadosDeEmpleados frm = new ListadosDeEmpleados();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.ShowDialog();
        }

        private void pagoAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PagoAEmpleados().ShowDialog();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerBanco.Stop();
            timerRequisiciones.Stop();
            new Balance().ShowDialog();
        }

        private void timerBanco_Tick(object sender, EventArgs e)

        {
            timerBanco.Stop();
            lbl_Saldo.BackColor = Color.FromArgb(185, 209, 234);
            double saldonuevo = manejadorBanco.GetSaldoEnBanco();
            if (saldo < saldonuevo)
                lbl_Saldo.BackColor = Color.Green;
            else if (saldo > saldonuevo)
                lbl_Saldo.BackColor = Color.Red;
            if (saldo != saldonuevo)
                lbl_Saldo.Text = string.Format("{0} MXN", saldonuevo.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            saldo = saldonuevo;
            //timerBanco.Start();

        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.Rows[0].Selected = true;
            lbl_Saldo.Text = string.Format("{0} MXN", manejadorBanco.GetSaldoEnBanco().ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));

            /// Prueba 
            //dataGridView2[3, 0].Value = Properties.Resources.Checkmark_20px;
            



        }

        private void timerRequisiciones_Tick(object sender, EventArgs e)
        {
            timerRequisiciones.Stop();
            int rowSelect = 0;
            if (dataGridView1.RowCount > 0)
                if (dataGridView1.SelectedRows.Count > 0)
                    rowSelect = dataGridView1.SelectedRows[0].Index;
            int rows = dataGridView1.RowCount;
            DataTable t = manejadorRequisicion.getRequisicionesPorAprobar();
            dataGridView1.DataSource = t;
            dataGridView1.Columns[0].FillWeight = 1;
            dataGridView1.Columns[1].FillWeight = 40;
            dataGridView1.Columns[3].FillWeight = 80;
            dataGridView1.Columns[4].FillWeight = 70;

            dataGridView1.ClearSelection();
            if (rows == dataGridView1.RowCount)
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows[rowSelect].Selected = true;
            }
            else
            {

                if (Math.Abs((dataGridView1.RowCount - rows)) >= 0 && dataGridView1.RowCount > 0)
                    if(rowSelect != 0)
                     dataGridView1.Rows[Math.Abs((dataGridView1.RowCount - rows))].Selected = true;
                    else
                        dataGridView1.Rows[0].Selected = true;
            }
            //timerRequisiciones.Start();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            timerRequisiciones.Stop();
            if (e.RowIndex > -1)
                new AprobarRequisicion(Convert.ToInt32(dataGridView1[1, e.RowIndex].Value)).ShowDialog();
            timerRequisiciones.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Saldo_Click(object sender, EventArgs e)
        {
            new CorrecionBalance().ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timerBanco.Start();
            timerRequisiciones.Start();
        }
    }
}
