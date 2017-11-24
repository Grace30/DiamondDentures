using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class Recepcion : Form
    {
        InterfaceUsuario ItUs;
        string UsuarioEnCurso = "";
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        bool admin = false;
        public Recepcion(string Usuario)
        {
            InitializeComponent();
            ItUs = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (UsuarioEnCurso != "Admin")
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Login))
                    {
                        frm.Show();
                    }
                }
            }
            else
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Login))
                    {
                        frm.Show();
                    }
                }
        }

        private void pBPedido_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            ItUs.enviarEvento("NuevoPedido", Datos);
        }

        private void pBPedidos_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            ItUs.enviarEvento("Pedidos", Datos);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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



        private void pbxSemaforo_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            ItUs.enviarEvento("PantallaSemaforo", Datos);
        }

        private void Recepcion_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            ItUs.enviarEvento("PantallaVentas", Datos);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            string[] Datos = { UsuarioEnCurso };
            ItUs.enviarEvento("PantallaCaja", Datos);
        }

        private void pBReportes_Click(object sender, EventArgs e)
        {
            MenúReportes frm = new MenúReportes(this);
            ItUs.desplegarPantalla(frm);
            ItUs.cerrarPantalla(this);
        }
    }
}
