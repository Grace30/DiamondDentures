using DiseñoFinal.ReportesM;
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
        public string Folio;
        public VistaPreviaForma()
        {
            InitializeComponent();
        }

        private void VistaPreviaForma_Load(object sender, EventArgs e)
        {
            FormaPedido objReporte = new FormaPedido();
            objReporte.SetParameterValue("@FolioForma", Folio);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VForma.ReportSource = objReporte;
        }

        private void VOficio_Load(object sender, EventArgs e)
        {

        }
    }
}
