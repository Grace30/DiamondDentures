using DiseñoFinal.ReportesM.Reportes;
using DiseñoFinal.ReportesM.Reportes.Listados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal.ReportesM.PantallaListados
{
    public partial class PantallaListadosGeneral : ListadosPersonalizados
    {
        string NombreTabla { get; set; }

        public PantallaListadosGeneral(string[,] CamposDeTabla, string NombreTabla)
        {
            InitializeComponent();
            CargarChecks(CamposDeTabla);
            this.NombreTabla = NombreTabla;
            Holiwis.Click += CargarReporte;
            Text = NombreTabla;
            WindowState = FormWindowState.Maximized;
            CenterToScreen();
        }

        private void CargarReporte(object sender, EventArgs e)
        {
            ListadoEmpleadoPersonalizado Listado = new ListadoEmpleadoPersonalizado();
            string Consulta = CreateSelectQueryAndParameters(NombreTabla);
            if (!Consulta.Contains("Column"))
            {
                MessageBox.Show("Nada para mostrar!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OleDbConnection Conn = new OleDbConnection(connString);

                OleDbDataAdapter adepter = new OleDbDataAdapter(Consulta, connString);
                DataSet1 Ds = new DataSet1();

                adepter.Fill(Ds, "Empleados");

                Listado.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = Listado;
            }
            catch (OleDbException oleEx)
            {
                MessageBox.Show(oleEx.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
