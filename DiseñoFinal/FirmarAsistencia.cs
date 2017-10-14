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
    public partial class FirmarAsistencia : Form
    {
        ManejadorRegistroUsuario manejadorUsuario = new ManejadorRegistroUsuario();

        public FirmarAsistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (manejadorUsuario.ValidarUsuario(new string[] { txt_Loginn.Text, txt_Paswordd.Text }) > 0){
                if (MessageBox.Show("¿Desea firmar la asistencia del usuario " + txt_Loginn.Text + "? \r\nLuego no sera posible modificarse. Hora actual: " + DateTime.Now.ToShortTimeString(), "", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    if (manejadorUsuario.ObtenerRegistroAsistencia(txt_Loginn.Text, DateTime.Today).Rows.Count > 0)
                        MessageBox.Show("Este usuario ya ha registrado su asistencia el dia de hoy");
                    else{
                        manejadorUsuario.RegistrarAsistencia(txt_Loginn.Text);
                        MessageBox.Show("Operacion realizada con exito");
                    }
                }
            }
            else
                MessageBox.Show("No se pudo validar los datos ingresados. Intente de nuevo o contacte a su administrador.");
        }

        private void txt_Paswordd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Continuar.PerformClick();
            }
        }
    }
}
