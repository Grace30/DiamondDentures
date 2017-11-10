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
    public partial class OrdenesDeCompra : Form
    {
        ManejadorRequisicion manejadorRequisicion = new ManejadorRequisicion();

        public OrdenesDeCompra()
        {
            InitializeComponent();
        }

        private void OrdenesDeCompra_Load(object sender, EventArgs e)
        {
            button3.Text = "ASFGDTREWLASFGDTREWLASFGDTREWLASFGDTREWL";
            cbox_Autorizo.SelectedIndex = 0;
            cbox_Estatus.SelectedIndex = 0;
            cbox_EstatusSurtido.SelectedIndex = 0;
            cbx_Solicitante.SelectedIndex = 0;
            cbox_Proovedor.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowSelect = 0;
            if (dataGridView1.RowCount > 0)
                if (dataGridView1.SelectedRows.Count > 0)
                    rowSelect = dataGridView1.SelectedRows[0].Index;
            int rows = dataGridView1.RowCount;
            DataTable t = manejadorRequisicion.getRequisicionesPorAprobar();
            dataGridView1.DataSource = t;
            dataGridView1.Columns[0].FillWeight = 40;
            dataGridView1.Columns[1].FillWeight = 70;
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
                    if (rowSelect != 0)
                        dataGridView1.Rows[Math.Abs((dataGridView1.RowCount - rows))].Selected = true;
                    else
                        dataGridView1.Rows[0].Selected = true;
            }
            toolStripStatusLabel1.Text = "Requisiciones: Se obtuvieron " + dataGridView1.RowCount +  " registros";
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i_EstadoSurtido = 0;
        private void cbox_EstatusSurtido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i_EstadoSurtido != cbox_EstatusSurtido.SelectedIndex) {
                if (cbox_EstatusSurtido.SelectedIndex == 1 )
                    cbox_Estatus.SelectedIndex = 3;
                else
                    cbox_Estatus.SelectedIndex = 0;
            }
            i_EstadoSurtido = cbox_EstatusSurtido.SelectedIndex;
        }

        private void cbox_Estatus_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            (TODAS)
EN ESPERA
ACEPTADO
SURTIDO
PAGADO*/
            switch (cbox_Estatus.SelectedIndex)
            {
                case 1:
                    cbox_EstatusSurtido.SelectedIndex = 2;
                    break;
                case 2:
                    cbox_EstatusSurtido.SelectedIndex = 2;
                    break;
                case 3:
                    cbox_EstatusSurtido.SelectedIndex = 1;
                    break;
                case 4:
                    cbox_EstatusSurtido.SelectedIndex = 1;
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true; 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
