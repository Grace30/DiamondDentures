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
    public partial class ListaDeAsistencia : Form
    {
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();

        public ListaDeAsistencia()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manejadorUsuario.ObtenerAsistenciaPorFecha(dateTimePicker1.Value.Date);
        }

        private void ListaDeAsistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
