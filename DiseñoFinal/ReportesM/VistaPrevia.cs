using DiseñoFinal.ReportesM;
using DiseñoFinal.ReportesM.Reportes;
using System;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class VistaPrevia : Form
    {
        public VistaPrevia()
        {
            InitializeComponent();
        }

        public string Pedido;
        public string NoFactura;
    
        private void VistaPrevia_Load(object sender, EventArgs e)
        {
            Factura objReporte = new Factura();
            objReporte.SetParameterValue("@NoFactura", NoFactura);
            objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            //objReporte.SetParameterValue("@Factura", NoFactura);
            crystalReportViewer1.ReportSource = objReporte;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
