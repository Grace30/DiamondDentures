using DiseñoFinal.ReportesM.Reportes;
using System;

namespace DiseñoFinal.ReportesM
{
    public partial class VistaPreviaVentasFecha : SuperVistaPrevia
    {
        public string FechaDesde, FechaHasta;
        public VistaPreviaVentasFecha()
        {
            InitializeComponent();
        }

        private void VGeneral_Load(object sender, EventArgs e)
        {

        }

        private void VistaPreviaVentasFecha_Load(object sender, EventArgs e)
        {
            ReporteVentasFecha objReporte = new ReporteVentasFecha();
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            objReporte.SetParameterValue("@FechaDesde", FechaDesde);
            objReporte.SetParameterValue("@FechaHasta", FechaHasta);
            VGeneral.ReportSource = objReporte;
        }
    }
}
