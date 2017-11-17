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
using 

namespace DiseñoFinal
{
    public partial class EntradaYSalida : Form
    {
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        InterfaceUsuario intusuario;
        Form pantalla;
        public EntradaYSalida(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Almacen))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Almacen))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string[] Datos = { txtNombre.Text };
                var datosMat = new DataTable();
                datosMat = mancp.ObtenerSalidas(Datos);
                DatosData(datosMat);
            }
        }
        public void DatosData(DataTable DatosAlmacen)
        {
            dgvAlmacen.DataSource = DatosAlmacen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string[] Datos = { txtNombre.Text };
                var datosMat = new DataTable();
                datosMat = mancp.ObtenerEntradas(Datos);
                DatosData(datosMat);
            }
        }        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtNombre.Text };
            var datosMat = new DataTable();
            if (radioButton1.Checked)
            { datosMat = mancp.ObtenerEntradas(Datos); }
            else
            { datosMat = mancp.ObtenerSalidas(Datos); }
            DatosData(datosMat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {

            }
        }
    }
}
