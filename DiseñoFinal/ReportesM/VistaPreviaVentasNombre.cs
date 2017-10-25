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
    public partial class VistaPreviaVentasNombre : SuperVistaPrevia
    {
        public string Empleado;
        public VistaPreviaVentasNombre()
        {
            InitializeComponent();
        }

        private void VistaPreviaVentasNombre_Load(object sender, EventArgs e)
        {
            ReporteVentasEmpleado objReporte = new ReporteVentasEmpleado();
            objReporte.SetParameterValue("@Empleado", Empleado);
            VGeneral.ReportSource = objReporte;
        }
    }
}
