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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void firmarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmarAsistencia frm = new FirmarAsistencia();
            frm.ShowDialog();
        }

        private void listadeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeAsistencia frm = new ListaDeAsistencia();
            frm.ShowDialog();
        }

        private void asistenciaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaPorEmpleado frm = new AsistenciaPorEmpleado();
            frm.ShowDialog();
        }
    }
}
