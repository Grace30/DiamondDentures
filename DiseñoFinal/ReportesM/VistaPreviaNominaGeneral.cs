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
    public partial class VistaPreviaNominaGeneral : SuperVistaPrevia
    {
        public VistaPreviaNominaGeneral()
        {
            InitializeComponent();
            ListadoNóminaGeneral list = new ListadoNóminaGeneral();
            VGeneral.ReportSource = list;
        }
    }
}
