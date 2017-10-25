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
    public partial class VistaPreviaProveedores : SuperVistaPrevia
    {
        public VistaPreviaProveedores()
        {
            InitializeComponent();
        }

        private void VistaPreviaProveedores_Load(object sender, EventArgs e)
        {
            ReporteProveedores objReport = new ReporteProveedores();
            VGeneral.ReportSource = objReport;
        }
    }
}
