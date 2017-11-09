using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DiseñoFinal.ReportesM.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal.ReportesM
{
    public partial class VIstaPreviaTicket : SuperVistaPrevia
    {
        public string Folio;
        public VIstaPreviaTicket()
        {
            InitializeComponent();
        }

      
        private void VIstaPreviaTicket_Load(object sender, EventArgs e)
        {
            ReporteTicket objReporte = new ReporteTicket();
            objReporte.SetParameterValue("@FolioVenta", Folio);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = objReporte;
        }

        private void VGeneral_Load(object sender, EventArgs e)
        {

        }

        //private void SetDBLogonForReport(CrystalDecisions.Shared.ConnectionInfo connectionInfo)
        //{
        //    TableLogOnInfos tableLogOnInfos = VGeneral.LogOnInfo;
        //    foreach (TableLogOnInfo tableLogOnInfo in tableLogOnInfos)
        //    {
        //        tableLogOnInfo.ConnectionInfo = connectionInfo;

        //    }

        //}

    }
}
