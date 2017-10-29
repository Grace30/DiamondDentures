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
            objrepo.SetParameterValue("@IDRequisicion", NoReq);
            objrepo.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = objrepo;
        }
    }
}
