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
    public partial class CatalogoProductos : Form
    {
        InterfaceUsuario intusuario;
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        Form pantalla;
        public CatalogoProductos(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void CatalogoProductos_Load(object sender, EventArgs e)
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
        public void DatosData(DataTable DatosAlmacen)
        {
            dgvCatalogo.DataSource = DatosAlmacen;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtNombre.Text };
            var datosCat = new DataTable();
            datosCat = mancp.ObtenerCatalogo(Datos);
            DatosData(datosCat);
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

        private void button1_Click(object sender, EventArgs e)
        {
            VistaPreviaCatalogo vpc = new VistaPreviaCatalogo();
            vpc.ShowDialog();
        }
    }
}
