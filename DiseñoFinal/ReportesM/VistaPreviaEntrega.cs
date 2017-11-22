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
    public partial class VistaPreviaEntrega : SuperVistaPrevia
    {
        public string Pedido;
        public VistaPreviaEntrega()
        {
            InitializeComponent();
        }

        private void VGeneral_Load(object sender, EventArgs e)
        {
            ReporteEntrega objReporte = new ReporteEntrega();

            //   objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = objReporte;
        }
    }
}
