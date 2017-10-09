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
    public partial class ActualizarClave : Form
    {
    //HOLAAA
        InterfaceUsuario intusuario;
        ManejadorPrincipal manp = new ManejadorPrincipal();

        public ActualizarClave()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }

        private void ActualizarClave_Load(object sender, EventArgs e)
        {
            var clave = new DataTable();
            clave = manp.getClave();
            foreach (DataRow fila in clave.Rows)
            {
                txtClave.Text = (fila["NClave"].ToString());
            } 
                     
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtClave.Text };
            intusuario.enviarEvento("ActClave", Datos); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length == 10)
            {
                string[] Datos = { txtClave.Text };
                intusuario.enviarEvento("ActClave", Datos);
            }
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar2;
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_2;
        }
    }
}
