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
using DiseñoFinal.ReportesM;

namespace DiseñoFinal
{
    public partial class ProveedoresJesusCrack : Form
    {
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;
        public ProveedoresJesusCrack()
        {
            InitializeComponent();
        }
        public ProveedoresJesusCrack(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            if (lblUsuario.Text == "Admin")
            { lblDep.Text = "Administrador"; }
            else
            {
                string Dep = "";
                var Departamento = new DataTable();
                string[] Datos = { lblUsuario.Text };
                Departamento = maru.Departamento(Datos);
                foreach (DataRow fila in Departamento.Rows)
                { Dep = fila["Departamento"].ToString(); }
                lblDep.Text = ReducirEspaciado(Dep);
            }

        }

        public void DatosData(DataTable datosProv)
        {
            dgvProveedores.DataSource = datosProv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" , lblUsuario.Text};
            intusuario.enviarEvento("PantallaCompraProveedores", Datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtNombre.Text };
            var datosProv = new DataTable();
            datosProv = mancp.ObtenerProveedores(Datos);
            DatosData(datosProv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" };
            intusuario.enviarEvento("PantallaAgregarProveedor", Datos);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] Datos = { dgvProveedores[1, dgvProveedores.SelectedCells[0].RowIndex].Value.ToString(), dgvProveedores[0, dgvProveedores.SelectedCells[0].RowIndex].Value.ToString() };
            intusuario.enviarEvento("PantallaActualizarProveedor", Datos);
        }
        public static string ReducirEspaciado(string Cadena)
        {

            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", "");
            }
            if (Cadena.Length > 0)
            {
                if (Cadena[Cadena.Length - 1] == ' ')
                {
                    Cadena.Remove(Cadena.Length - 1, 1);
                }
            }

            return Cadena;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaPreviaComprasProve vpc = new VistaPreviaComprasProve();
            vpc.ShowDialog();
        }
    }
}
