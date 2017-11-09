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
            ReporteCorteCaja objReporte = new ReporteCorteCaja();
            objReporte.SetParameterValue("@FolioCorte", Folio);
            objReporte.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = objReporte;
        }
       
    }
}
