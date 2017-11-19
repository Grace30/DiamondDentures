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
    public partial class VistaPreviaSyE : SuperVistaPrevia
    {
        public VistaPreviaSyE()
        {
            InitializeComponent();
        }

        private void VistaPreviaSyE_Load(object sender, EventArgs e)
        {
            ReporteSalidas rs = new ReporteSalidas();
            rs.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = rs;
        }
    }
}
