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
    public partial class VistaPreviaCorteFechas :SuperVistaPrevia
    {
        public string FechaDesde, FechaHasta;
        public VistaPreviaCorteFechas()
        {
            InitializeComponent();
        }

        private void VGeneral_Load(object sender, EventArgs e)
        {
            ReporteCortesFechas objReporte = new ReporteCortesFechas();
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            objReporte.SetParameterValue("@FechaDesde", FechaDesde);
            objReporte.SetParameterValue("@FechaHasta", FechaHasta);
            VGeneral.ReportSource = objReporte;
        }
    }
}
