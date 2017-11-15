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
    public partial class MenuLaboratorio : Form
    {
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
        Form pantalla;

        public MenuLaboratorio(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
        }
        public MenuLaboratorio(string Usuario, Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
            this.pantalla = pantalla;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pbxFabricarProducto_Click(object sender, EventArgs e)
        {
            string[] Datos = {UsuarioEnCurso};
            intusuario.enviarEvento("PantallaFabricarProducto", Datos);
        }

        private void pbxSemaforo_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("PantallaSemaforo", Datos);
        }

        private void pbMateriales_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" };
            intusuario.enviarEvento("PantallaMateriales", Datos);
        }

        private void pbPiezas_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaPiezas", Datos);
        }

        private void MenuLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Login))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Login))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(MenuGeneral))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuGeneral))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", UsuarioEnCurso };
            intusuario.enviarEvento("PantallaAlmacen", Datos);
        }
    }
}

