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
    public partial class VistaPreviaNota : Form
    {
        public string Folio, Pedido;
        public VistaPreviaNota()
        {
            InitializeComponent();
        }

        private void VistaPreviaNota_Load(object sender, EventArgs e)
        {
            NotaTerminación objReporte = new NotaTerminación();
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            objReporte.SetParameterValue("@FolioNota", Folio);
            objReporte.SetParameterValue("@Pedido", Pedido);
            VOficio.ReportSource = objReporte;
        }

        private void VOficio_Load(object sender, EventArgs e)
        {

        }
    }
}
