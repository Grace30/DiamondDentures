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
    public partial class Materiales : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        Form pantalla;

        public Materiales()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
        }

        public Materiales(Form pantalla)
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

        private void Materiales_Load(object sender, EventArgs e)
        {
            dgvMateriales.ClearSelection();
        }

        private void pbAgregarMaterial_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaAgregarMaterial", Datos);

            var datosPiezas = new DataTable();
            datosPiezas = mancp.ObtenerDatosMateriales(Datos);
            DatosData(datosPiezas);


            dgvMateriales.ClearSelection();
        }

        public void DatosData(DataTable DatosPiezas)
        {
            dgvMateriales.DataSource = DatosPiezas;
        }

        private void pbActualizarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentCell.Selected == true)
            {
                string[] Datos = { dgvMateriales[0, dgvMateriales.CurrentCell.RowIndex].Value.ToString() };
                intusuario.enviarEvento("PantallaActualizarMaterial", Datos);


                var datosPiezas = new DataTable();
                datosPiezas = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosPiezas);

                dgvMateriales.ClearSelection();
            }
        }

        private void txtCodigMat_KeyPress(object sender, KeyPressEventArgs e)
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
            if (pantalla.GetType() == typeof(MenuLaboratorio))
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

        private void pbBuscarMaterial_Click_1(object sender, EventArgs e)
        {
            string[] Datos = { txtCodigMat.Text };
            if (Datos[0] == "")
            {
                var datosMateriales = new DataTable();
                datosMateriales = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosMateriales);
            }
            else
            {
                var datosMateriales = new DataTable();
                datosMateriales = mancp.EditarMaterial(Datos);
                if (datosMateriales.Rows.Count > 0)
                { DatosData(datosMateriales); }
            }
            dgvMateriales.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtCodigMat.Text };
            if (Datos[0] == "")
            {
                var datosMateriales = new DataTable();
                datosMateriales = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosMateriales);
            }
            else
            {
                var datosMateriales = new DataTable();
                datosMateriales = mancp.EditarMaterial(Datos);
                if (datosMateriales.Rows.Count > 0)
                { DatosData(datosMateriales); }
            }
            dgvMateriales.ClearSelection();
        }

        private void txtCodigMat_TextChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}