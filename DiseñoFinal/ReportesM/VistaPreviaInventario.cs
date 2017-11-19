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
    public partial class VistaPreviaInventario : SuperVistaPrevia
    {
        public VistaPreviaInventario()
        {
            InitializeComponent();
        }

        private void VistaPreviaInventario_Load(object sender, EventArgs e)
        {
            ReporteInventario re = new ReporteInventario();
            re.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = re;
        }
    }
}
