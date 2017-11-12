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
    public partial class VistaPreviaCorte : SuperVistaPrevia
    {
        public string Folio;
        public VistaPreviaCorte()
        {
            InitializeComponent();
            
        }

        private void VistaPreviaCorte_Load(object sender, EventArgs e)
        {
            PruebaCorte obj = new PruebaCorte();
            obj.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");

            obj.SetParameterValue("@FolioCorte", Folio);

            VGeneral.ReportSource = obj;
        }
    }
}
