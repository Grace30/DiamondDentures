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
    public partial class VistaPreviaForma2 : SuperVistaPrevia
    {
        public string Pedido, Folio;

        public VistaPreviaForma2()
        {
            InitializeComponent();
        }
        private void VistaPreviaForma2_Load(object sender, EventArgs e)
        {
            FormaPedido2 objReporte = new FormaPedido2();
            objReporte.SetParameterValue("@Folio", Folio);
            //      producto obj = new producto();
            objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = objReporte;

            //objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            //VForma.ReportSource = obj;
        }

    }
}
