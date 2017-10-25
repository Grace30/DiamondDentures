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
    public partial class VistaPreviaReq : SuperVistaPrevia
    {
        public VistaPreviaReq()
        {
            InitializeComponent();
        }

        private void VistaPreviaReq_Load(object sender, EventArgs e)
        {
            ReporteRequisicion objrepo = new ReporteRequisicion();
            VGeneral.ReportSource = objrepo;
        }
    }
}
