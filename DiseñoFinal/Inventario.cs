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
    public partial class Inventario : Form
    {
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;
        public List<string> CodM = new List<string>();
        public List<string> Nombre = new List<string>();
        public List<string> Existencia = new List<string>();
        public List<string> Prov = new List<string>();
        public List<string> Unidad = new List<string>();
        public Inventario(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Datos = { "","", lblUsuario.Text };
            intusuario.enviarEvento("PantallaHistorial", Datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
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

        public void DatosData(DataTable DatosAlmacen)
        {
            dgvAlmacen.DataSource = null;
            CodM.Clear(); Nombre.Clear(); Existencia.Clear(); Unidad.Clear(); Prov.Clear();
            if (radioButton1.Checked)
            {
                dgvAlmacen.Columns.Clear();
                dgvAlmacen.Columns.Add("Codigo", "Código");
                dgvAlmacen.Columns.Add("Nombre", "Nombre");
                dgvAlmacen.Columns.Add("Prov", "Proveedor");
                dgvAlmacen.Columns.Add("Unidad", "Unidad");
                dgvAlmacen.Columns.Add("Existencia", "Existencia");
                dgvAlmacen.Columns.Add("Real", "Real");

                foreach (DataRow fila in DatosAlmacen.Rows)
                {
                    CodM.Add(fila["CodigoMaterial"].ToString());
                    Nombre.Add(fila["Nombre"].ToString());
                    Existencia.Add(fila["Existencia"].ToString());
                    Unidad.Add(fila["Unidad"].ToString());
                    Prov.Add(fila["Proveedor"].ToString());
                }

                if (CodM.Count > 0)
                {
                    dgvAlmacen.RowCount = CodM.Count;
                    for (int i = 0; i < CodM.Count; i++)
                    {
                        dgvAlmacen[0, i].Value = ReducirEspaciado(CodM[i]);
                        dgvAlmacen[1, i].Value = ReducirEspaciado(Nombre[i]);
                        dgvAlmacen[2, i].Value = ReducirEspaciado(Prov[i]);
                        dgvAlmacen[3, i].Value = ReducirEspaciado(Unidad[i]);
                        dgvAlmacen[4, i].Value = ReducirEspaciado(Existencia[i]);
                    }
                }
            }
            else { dgvAlmacen.Columns.Clear(); dgvAlmacen.DataSource = DatosAlmacen; }
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string[] Datos = { "" };
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosInsumos(Datos);
                DatosData(datosAlm);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string[] Datos = { "" };
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosAlm);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string[]> Detalles = new List<string[]>();
            int i = 0;
            while (i < dgvAlmacen.RowCount)
            {
                if (dgvAlmacen[5, i].Value != null && ReducirEspaciado(dgvAlmacen[5, i].Value.ToString()) != "")
                {
                    Detalles.Add(new string[] { dgvAlmacen[0, i].Value.ToString(),dgvAlmacen[1,i].Value.ToString(),dgvAlmacen[4,i].Value.ToString(), dgvAlmacen[5, i].Value.ToString() });
                }
                i++;
            }
            string[] today = DateTime.Today.ToString("d").Split('/');
            string fecha = "";
            i = 2;
            while (i >= 0)
            {
                fecha += today[i];
                if (i > 0) { fecha += "/"; }
                i--;
            }
            i = 0;
            while (i < Detalles.Count)
            {
                int Dif = 0;
                if (Convert.ToInt32(Detalles[i][2]) < Convert.ToInt32(Detalles[i][3]))
                { Dif = Convert.ToInt32(Detalles[i][3]) - Convert.ToInt32(Detalles[i][2]); }
                else { Dif = Convert.ToInt32(Detalles[i][2]) - Convert.ToInt32(Detalles[i][3]); }
                string[] Datos = { fecha, lblUsuario.Text, Detalles[i][0], Detalles[i][1], Detalles[i][2], Detalles[i][3], Dif.ToString() };
                mancp.HistorialInv(Datos);

                string[] Datos2 = { Detalles[i][0], Detalles[i][3] };
                mancp.ActualizarExistencia(Datos2);
                i++;
            }
            if (radioButton1.Checked)
            {
                string[] Datos = { "" };
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosAlm);
            }
            MessageBox.Show("Inventario Actualizado");
        }
    }
}
