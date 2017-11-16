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
    public partial class VistaPreviaOficio : Form
    {
        public string Pedido;
        public VistaPreviaOficio()
        {
            InitializeComponent();
        }

        private void VistaPreviaOficio_Load(object sender, EventArgs e)
        {
            Oficio_de_confirmación2 objReporte = new Oficio_de_confirmación2();
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
          //  objReporte.SetParameterValue("@FolioOficio", Folio);
            objReporte.SetParameterValue("@Pedido", Pedido);
            VOficio.ReportSource = objReporte;

        }

        private void VOficio_Load(object sender, EventArgs e)
        {

        }
    }
}
