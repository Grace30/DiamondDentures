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
    public partial class Piezas : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        Form pantalla;

        public Piezas()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }
        public Piezas(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        public void DatosData(DataTable DatosPiezas)
        {
            dgvPiezas.DataSource = DatosPiezas;
        }

        private void pbAgregarPieza_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaAgregarPieza", Datos);


            var datosPiezas = new DataTable();
            datosPiezas = mancp.ObtenerDatosPiezas(Datos);
            DatosData(datosPiezas);


            dgvPiezas.ClearSelection();
        }

        private void pbActualizarPieza_Click(object sender, EventArgs e)
        {
            if (dgvPiezas.CurrentCell.Selected == true)
            {
                string[] Datos = { dgvPiezas[1, dgvPiezas.CurrentCell.RowIndex].Value.ToString() };
                intusuario.enviarEvento("PantallaActualizarPieza", Datos);


                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                DatosData(datosPiezas);


                dgvPiezas.ClearSelection();
            }
        }

        private void pbBuscarPieza_Click(object sender, EventArgs e)
        {
            if (txtCodigoPieza.Text == "")
            {
                string[] Datos = new string[1];
                this.Close();
                intusuario.enviarEvento("BuscarPieza", Datos);
            }
            else
            {
                string[] Datos = { txtCodigoPieza.Text };
                this.Close();
                intusuario.enviarEvento("BuscarPieza", Datos);
            }
        }

        private void Piezas_Load(object sender, EventArgs e)
        {
            dgvPiezas.ClearSelection();
        }

        private void txtCodigoPieza_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(ControlPedidos))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ControlPedidos))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(MenuLaboratorio))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuLaboratorio))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void pbBuscarPieza_Click_1(object sender, EventArgs e)
        {
            string[] Datos = { txtCodigoPieza.Text };
            if (Datos[0] == "")
            {
                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                DatosData(datosPiezas);
            }
            else
            {
                var datosPiezas = new DataTable();
                datosPiezas = mancp.EditarPieza(Datos);
                if (datosPiezas.Rows.Count > 0)
                {
                    DatosData(datosPiezas);
                }
                else
                {
                    datosPiezas = new DataTable();
                    datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                    DatosData(datosPiezas);
                }
            }
            dgvPiezas.ClearSelection();
        }

        private void txtCodigoPieza_TextChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtCodigoPieza.Text };
            if (Datos[0] == "")
            {
                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                DatosData(datosPiezas);
            }
            else
            {
                var datosPiezas = new DataTable();
                datosPiezas = mancp.EditarPieza(Datos);
                if (datosPiezas.Rows.Count > 0)
                {
                    DatosData(datosPiezas);
                }
                else
                {
                    datosPiezas = new DataTable();
                    datosPiezas = mancp.ObtenerDatosPiezas(Datos);
                    DatosData(datosPiezas);
                }
            }
            dgvPiezas.ClearSelection();
        }
    }
}
