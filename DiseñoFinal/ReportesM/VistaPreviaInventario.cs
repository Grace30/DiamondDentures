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
    public partial class VistaPreviaInventario : SuperVistaPrevia
    {
        public VistaPreviaInventario()
        {
            InitializeComponent();
        }

        private void VistaPreviaInventario_Load(object sender, EventArgs e)
        {
            ReporteInventario objReporte = new ReporteInventario();
            VGeneral.ReportSource = objReporte;
        }
    }
}
