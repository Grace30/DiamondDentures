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
using System.Runtime.InteropServices;

namespace DiseñoFinal
{
    public partial class Pedidos : Form
    {
        InterfaceUsuario It;
        ManejadorPrincipal map = new ManejadorPrincipal();
        Validación v = new Validación();
        int filaactual = 0;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        Form llamada;
        string usuarioencurso;
        public Pedidos()
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
        }

        public Pedidos(Form llamada, string usuarioencurso)
        {
            InitializeComponent();
            It = new InterfaceUsuario(this);
            this.llamada = llamada;
            this.usuarioencurso = usuarioencurso;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Recepcion))
                {
                    frm.Show();
                }
            }
        }

        private void pBMostrar_Click(object sender, EventArgs e)
        {
            string[] Datos = { dataGridView1[0, filaactual].Value.ToString(),
                dataGridView1[2, filaactual].Value.ToString(),
            dataGridView1[3,filaactual].Value.ToString(), dataGridView1[4,filaactual].Value.ToString(),
            dataGridView1[1, filaactual].Value.ToString() };
            It.enviarEvento("Pedido", Datos);
        }

        public void RellenarTODO()
        {
            var Pedidos = new DataTable();
            Pedidos = map.getPedidos();
            dataGridView1.DataSource = Pedidos;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = e.RowIndex;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void Pedidos_Activated(object sender, EventArgs e)
        {
            RellenarTODO();
        }
    }
}
