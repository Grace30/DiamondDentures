using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiseñoFinal.ReportesM.Reportes;

namespace DiseñoFinal.ReportesM
{
    public partial class VistaPreviaRequiProv : SuperVistaPrevia
    {
        public string ClaveProv;
        public VistaPreviaRequiProv()
        {
            InitializeComponent();
        }

        private void VistaPreviaRequiProv_Load(object sender, EventArgs e)
        {
            ReporteRequiProv objrepo = new ReporteRequiProv();
            objrepo.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            objrepo.SetParameterValue("@ClaveProv",  ClaveProv);
             VGeneral.ReportSource = objrepo;

        }
    }
}
