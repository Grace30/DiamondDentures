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
    public partial class OrdenesDeCompra : Form
    {
        ManejadorRequisicion manejadorRequisicion = new ManejadorRequisicion();
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario = new InterfaceUsuario(new Form());

        public OrdenesDeCompra()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void OrdenesDeCompra_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
            button3.Text = Program.Departamento + " - " + Program.Loginn;

            new Thread(LlenarCboxContadores).Start();
            new Thread(LlenarCboxEmpleados).Start();
            new Thread(LlenarCboxProveedores).Start();

            cbox_Autorizo.SelectedIndex = 0;
            cbox_Estatus.SelectedIndex = 0;
            cbox_EstatusSurtido.SelectedIndex = 0;
            cbx_Solicitante.SelectedIndex = 0;

            cbox_Proovedor.SelectedIndex = 0;

        }
        //cM16K21a9V
        private void button1_Click(object sender, EventArgs e)
        {
            string estatus = (cbox_Estatus.Text == "(TODAS)") ? "" : cbox_Estatus.Text;
            string surtido = (cbox_EstatusSurtido.Text == "(TODAS)") ? "" : cbox_EstatusSurtido.Text;
            string autorizo = (cbox_Autorizo.Text == "(TODOS)") ? "" : cbox_Autorizo.Text.Split('-')[0].TrimEnd();
            string solicitante = (cbx_Solicitante.Text == "(TODOS)") ? "" : cbx_Solicitante.Text.Split('-')[0].TrimEnd();
            string proveedor = (cbox_Proovedor.Text == "(TODOS)") ? "" : cbox_Proovedor.Text;


            DataTable t = manejadorRequisicion.getRequisicionesConFiltro(txt_IDRequisicion.Text, estatus, surtido, solicitante, autorizo, proveedor, (datePicker_SolicitudIni.Checked) ? datePicker_SolicitudIni.Value : new DateTime(2000, 01, 01), (datePicker_SolicitudFin.Checked) ? datePicker_SolicitudFin.Value : new DateTime(2100, 01, 01),
                (datePicker_AutoriIni.Checked) ? datePicker_AutoriIni.Value : new DateTime(2000, 01, 01), (datePicker_AutoriFin.Checked) ? datePicker_AutoriFin.Value : new DateTime(2100,01,01),
                (datePicker_EntregaIni.Checked) ? datePicker_EntregaIni.Value: new DateTime(2000, 01, 01), (datePicker_EntregaFin.Checked) ? datePicker_EntregaFin.Value : new DateTime(2100, 01, 01)); 

            //DataTable t = manejadorRequisicion.getRequisicionesPorAprobar();
            listarRequis(t);
        }
        private void listarRequis(DataTable t)
        {
            int rowSelect = 0;
            if (dataGridView1.RowCount > 0)
                if (dataGridView1.SelectedRows.Count > 0)
                    rowSelect = dataGridView1.SelectedRows[0].Index;
            int rows = dataGridView1.RowCount;

            dataGridView1.DataSource = t;
            if (dataGridView1.ColumnCount > 0)
            {
                dataGridView1.Columns[0].FillWeight = 40;
                dataGridView1.Columns[1].FillWeight = 70;
                dataGridView1.Columns[3].FillWeight = 80;
                dataGridView1.Columns[4].FillWeight = 70;
            }

            dataGridView1.ClearSelection();
            /*if (rows == dataGridView1.RowCount)
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
            }*/
            toolStripStatusLabel1.Text = "Requisiciones: Se obtuvieron " + dataGridView1.RowCount + " registros";
            if (dataGridView1.RowCount > 0)
                dataGridView1.Rows[0].Selected = true;
        }

        private void pBSalir2_Click(object sender, EventArgs e) { this.Close(); }

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
            AUTORIZADO
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
            if (e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            new AprobarRequisicion(Convert.ToInt32(dataGridView1[0,e.RowIndex].Value)).ShowDialog();
            button1.PerformClick();
        }

      

        private void LlenarCboxEmpleados() { cbx_Solicitante.Items.AddRange(manejadorUsuario.NombreEmpleados()); }
        private void LlenarCboxContadores() { cbox_Autorizo.Items.AddRange(manejadorUsuario.NombreEmpleadosContabilidad()); }
        private void LlenarCboxProveedores() { cbox_Proovedor.Items.AddRange(manejadorUsuario.NombreProveedores()); }
        private void datePicker_SolicitudIni_ValueChanged(object sender, EventArgs e) { datePicker_SolicitudFin.Checked = datePicker_SolicitudIni.Checked;}
        private void datePicker_SolicitudFin_ValueChanged(object sender, EventArgs e) { datePicker_SolicitudIni.Checked = datePicker_SolicitudFin.Checked;}
        private void datePicker_AutoriIni_ValueChanged(object sender, EventArgs e) { datePicker_AutoriFin.Checked = datePicker_AutoriIni.Checked;}
        private void datePicker_AutoriFin_ValueChanged(object sender, EventArgs e) { datePicker_AutoriIni.Checked = datePicker_AutoriFin.Checked;}
        private void datePicker_EntregaIni_ValueChanged(object sender, EventArgs e){ datePicker_EntregaFin.Checked = datePicker_EntregaIni.Checked;}
        private void datePicker_EntregaFin_ValueChanged(object sender, EventArgs e) { datePicker_EntregaIni.Checked = datePicker_EntregaFin.Checked; }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportesM.VistaPreviaReq objform = new ReportesM.VistaPreviaReq();
            string NoReq = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            objform.NoReq = NoReq;
            objform.ShowDialog();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[] { Program.Loginn };
            intusuario.enviarEvento("PerfilUsuario", Datos);
        }
    }
}
