using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad   ;

namespace DiseñoFinal
{
    public partial class ClaveRegistro : Form
    {
        InterfaceUsuario intusuario;
        public ClaveRegistro()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {                          
            string[] Datos = {txtClave.Text};
            intusuario.enviarEvento("Acceder", Datos);        
        }

        private void ClaveRegistro_Load(object sender, EventArgs e)
        {   
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_2;
        }

        private void btnAcceser_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtClave.Text };
            intusuario.enviarEvento("Acceder", Datos);
            this.Close();
        }

        private void btnAcceder_MouseLeave(object sender, EventArgs e)
        {
            btnAcceder.Image = Properties.Resources.acceder;
        }

        private void btnAcceder_MouseHover(object sender, EventArgs e)
        {
            btnAcceder.Image = Properties.Resources.acceder2;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
