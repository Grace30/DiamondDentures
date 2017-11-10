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
    public partial class HistorialInv : Form
    {
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;
        public HistorialInv(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtNombre.Text , txtNombre.Text};
            var datosAlm = new DataTable();
            datosAlm = mancp.ObtenerHistorial(Datos); 
            DatosData(datosAlm);
        }
        public void DatosData(DataTable DatosAlmacen)
        {
            dgvAlmacen.DataSource = DatosAlmacen;
        }

        private void HistorialInv_Load(object sender, EventArgs e)
        {
            if (lblUsuario.Text == "Admin")
            { lblDep.Text = "Administrador"; }
            else
            {
                string Dep = "";
                var Departamento = new DataTable();
                string[] Datos = { ReducirEspaciado(lblUsuario.Text) };
                Departamento = maru.Departamento(Datos);
                foreach (DataRow fila in Departamento.Rows)
                { Dep = fila["Departamento"].ToString(); }
                lblDep.Text = ReducirEspaciado(Dep);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Inventario))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Inventario))
                    {
                        frm.Show();
                    }
                }
            }
        }
    }
}
