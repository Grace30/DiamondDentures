using DiseñoFinal.ReportesM.Reportes.Listados;
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
    public partial class VistaPreviaNominaMes : SuperVistaPrevia
    {
        public VistaPreviaNominaMes(int mesesito)
        {
            InitializeComponent();
            ListadoNómina nom = new ListadoNómina();
            nom.SetParameterValue("@Mes", mesesito);
            nom.SetDatabaseLogon("AdminDD", "Admin123123", "Rebeater.Database.Windows.Net", "DiamondDentures");
            VGeneral.ReportSource = nom;
        }

    }
}
