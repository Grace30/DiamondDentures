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
    public partial class VistaPreviaNota : Form
    {
        public string IDPedido;
        public VistaPreviaNota()
        {
            InitializeComponent();
        }

        private void VistaPreviaNota_Load(object sender, EventArgs e)
        {
            CrystalReport1 objReporte = new CrystalReport1();
            objReporte.SetParameterValue("@IDPedido", IDPedido);
            VOficio.ReportSource = objReporte;
        }
    }
}
