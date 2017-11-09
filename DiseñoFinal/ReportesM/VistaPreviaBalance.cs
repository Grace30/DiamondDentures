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
    public partial class VistaPreviaBalance : SuperVistaPrevia
    {
        public VistaPreviaBalance()
        {
            InitializeComponent();
        }

        private void VistaPreviaBalance_Load(object sender, EventArgs e)
        {
            ReporteBalance obj = new ReporteBalance();
            obj.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = obj;

        }
    }
}
