using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class VistaPreviaOficio : Form
    {
        public string IDPedido;
        public VistaPreviaOficio()
        {
            InitializeComponent();
        }

        private void VistaPreviaOficio_Load(object sender, EventArgs e)
        {
            Oficio_de_confirmación2 objReporte = new Oficio_de_confirmación2();
            objReporte.SetParameterValue("@IDPedido", IDPedido);
            VOficio.ReportSource = objReporte;

        }
    }
}
