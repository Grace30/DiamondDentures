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
    public partial class AsistenciaPorEmpleado : Form
    {

        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();
        public AsistenciaPorEmpleado()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case "NOMBRE":
                    groupBox.Text = "Nombre";
                    panelNombre.Visible = true;
                    panelUsuario.Visible = false;
                    panel_Fecha.Visible = false;
                    break;
                case "ID EMPLEADO":
                    groupBox.Text = "Usuario";
                    panelUsuario.Visible = true;
                    panelNombre.Visible = false;
                    panel_Fecha.Visible = false;
                    break;
                case "FECHA":
                    groupBox.Text = "Fecha";
                    panelUsuario.Visible = false;
                    panelNombre.Visible = false;
                    panel_Fecha.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();

            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString()) {
                case "NOMBRE":
                    t = manejadorUsuario.ObtenerRegistroAsistencia(txt_Nombre.Text, txt_Apellido.Text);
                    break;
                case "ID EMPLEADO":
                    t = manejadorUsuario.ObtenerAsistenciaPorUsuario(txt_User.Text);
                    break;
                case "FECHA":
                    t = manejadorUsuario.ObtenerAsistenciaPorFecha(dateTimePicker1.Value.Date);
                    break;
            }

            if (t.Rows.Count > 0)
                dataGridView1.DataSource = t;
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.RowCount = 0;
                MessageBox.Show("Sin resultados");
                
            }


        }

        private void AsistenciaPorEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
