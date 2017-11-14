using DiseñoFinal.ReportesM.Reportes;
using System;


namespace DiseñoFinal.ReportesM
{
    public partial class VistaPreviaReq : SuperVistaPrevia
    {
        public string NoReq;
        public VistaPreviaReq()
        {
            InitializeComponent();
        }

        private void VistaPreviaReq_Load(object sender, EventArgs e)
        {
            ReporteRequisicion objrepo = new ReporteRequisicion();
            objrepo.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            objrepo.SetParameterValue("@IDRequisicion", NoReq);
   
            VGeneral.ReportSource = objrepo;
        }
    }
}
