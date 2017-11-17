using DiseñoFinal.ReportesM;
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

namespace DiseñoFinal
{
    public partial class VistaPreviaForma : Form
    {
        public string Pedido;
        public VistaPreviaForma()
        {
            InitializeComponent();
        }

        private void VistaPreviaForma_Load(object sender, EventArgs e)
        {
            FormaPedido objReporte = new FormaPedido();

            //   objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetParameterValue("@Pedido", Pedido);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VForma.ReportSource = objReporte;
      
            
        }

    }
}
