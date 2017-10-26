using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace DiseñoFinal
{
    public partial class Nomina : Form
    {
        double saldo;
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();

        public Nomina()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            timerBanco.Start();
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

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadosDeEmpleados frm = new ListadosDeEmpleados();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.ShowDialog();
        }

        private void pagoAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PagoAEmpleados().ShowDialog();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Balance().ShowDialog();
        }

        private void timerBanco_Tick(object sender, EventArgs e)

        {
            timerBanco.Stop();
            lbl_Saldo.BackColor = Color.FromArgb(185, 209, 234);
            double saldonuevo = manejadorUsuario.GetSaldoEnBanco();
            if (saldo < saldonuevo)
                lbl_Saldo.BackColor = Color.Green;
            else if (saldo > saldonuevo)
                lbl_Saldo.BackColor = Color.Red;
            lbl_Saldo.Text = string.Format("{0} MXN", saldonuevo.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            saldo = saldonuevo;
            timerBanco.Start();

        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            lbl_Saldo.Text = string.Format("{0} MXN", manejadorUsuario.GetSaldoEnBanco().ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));

        }
    }
}
