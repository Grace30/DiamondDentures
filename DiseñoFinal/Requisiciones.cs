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
    public partial class Requisiciones : Form
    {
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;
        int Proveedor = 1;
        public Requisiciones(Form pantalla, string Usuario, int Prov)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
            Proveedor = Prov;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string Estado = "";
            if(cbEstado.Text != "TODAS") { Estado = cbEstado.Text; }
            string[] Datos = { txtRequi.Text, Estado };
            var datosRequi = new DataTable();
            if (Proveedor == 1)
            {
                datosRequi = mancp.ObtenerRequisiciones(Datos);
                DatosData(datosRequi);
            }else
            {
                datosRequi = mancp.ObtenerRequiProv(Datos);
                DatosData(datosRequi);
            }
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
            if (pantalla.GetType() == typeof(RequisicionMateriales))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(RequisicionMateriales))
                    {
                        frm.Show();
                    }
                }
            }
        }

        public void DatosData(DataTable DatosAlmacen)
        {
            dgvAlmacen.DataSource = DatosAlmacen;
        }

        private void Requisiciones_Load(object sender, EventArgs e)
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
            if (Proveedor == 0)
            {
                btnProv.Visible = false;
                label1.Text = "Proveedor";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRequi.Text != null)
            {
                VistaPreviaReq objform = new VistaPreviaReq();

                string NoReq = txtRequi.Text;
                objform.NoReq = NoReq;
                objform.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRequi.Text != null)
            {
                string [] Datos = { txtRequi.Text};
                if(mancp.EnviarRequi(Datos) > 0)
                {
                    MessageBox.Show("Requisicion Enviada al Proveedor");
                    VistaPreviaReq objform = new VistaPreviaReq();

                    string NoReq = txtRequi.Text;
                    objform.NoReq = NoReq;
                    objform.ShowDialog();
                }
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Estado = "";
            if (cbEstado.Text != "TODAS") { Estado = cbEstado.Text; }
            string[] Datos = { txtRequi.Text, Estado };
            var datosRequi = new DataTable();
            if (Proveedor == 1)
            {
                datosRequi = mancp.ObtenerRequisiciones(Datos);
                DatosData(datosRequi);
            }
            else
            {
                datosRequi = mancp.ObtenerRequiProv(Datos);
                DatosData(datosRequi);
            }
        }
    }
}
