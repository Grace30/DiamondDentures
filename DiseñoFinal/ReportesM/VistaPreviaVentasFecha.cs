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
        private void VistaPreviaVentasFecha_Load(object sender, EventArgs e)
        {
            ReporteVentasFecha objReporte = new ReporteVentasFecha();
            objReporte.SetParameterValue("@FechaDesde", FechaDesde);
            objReporte.SetParameterValue("@FechaHasta", FechaHasta);
            VGeneral.ReportSource = objReporte;
        }
    }
}
