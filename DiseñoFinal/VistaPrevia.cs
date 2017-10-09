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
    public partial class VistaPrevia : Form
    {
        public VistaPrevia()
        {
            InitializeComponent();
        }

        public string IDPedido;
        public string NoFactura;
    
        private void VistaPrevia_Load(object sender, EventArgs e)
        {
            Factura objReporte = new Factura();
            objReporte.SetParameterValue("@Pedido", IDPedido);
            //objReporte.SetParameterValue("@Factura", NoFactura);
            crystalReportViewer1.ReportSource = objReporte;
        }
    }
}
