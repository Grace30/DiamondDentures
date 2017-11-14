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
    public partial class Proveedores : Form
    {
        ManejadorRegistroProveedor manejadorProveedor = new ManejadorRegistroProveedor();

        public Proveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string idProv = txt_IdProveedor.Text;
            string provNombre = txt_Nombre.Text;
            string provCorreo = txt_Correo.Text;
            string provRFC = txt_RFC.Text;
            string provContacto = txt_Contacto.Text;
            string provEstatus = (cbox_Estatus.Text == "TODOS") ? "":cbox_Estatus.Text ;
            DataTable t = manejadorProveedor.ObtenerProvedores(idProv, provNombre, provCorreo, provRFC, provContacto, provEstatus);
            if (t != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.ColumnCount = 0;
                dataGridView1.DataSource = t;
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            cbox_Estatus.SelectedIndex = 0;
        }
    }
}
