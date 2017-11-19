using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class ReportNominaIndividual : Form
    {
        public string loginn;
        public int mes;

        public ReportNominaIndividual()
        {
            InitializeComponent();
        }

        private void ReportNominaIndividual_Load(object sender, EventArgs e)
        {
            NominaIndividual objReport = new NominaIndividual();
            objReport.SetParameterValue("@Loginn", loginn);
            objReport.SetParameterValue("@Login", loginn);
            objReport.SetParameterValue("@Mes", mes);

            crystalReportViewer1.ReportSource = objReport;
            objReport.SetDatabaseLogon("AdminDD", "Admin123123");
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
