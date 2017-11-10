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
    public partial class RequisicionMateriales : Form
    {
        InterfaceUsuario intusuario;
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        Form pantalla;
        public List<string> CodM = new List<string>();
        public List<string> Nombre = new List<string>();
        public List<string> Existencia = new List<string>();
        public List<string> Stock = new List<string>();
        public List<string> Falt = new List<string>();
        public List<string> Prov = new List<string>();

        public RequisicionMateriales(Form pantalla,string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void RequisicionMateriales_Load(object sender, EventArgs e)
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

        public void DatosData(DataTable DatosPiezas, int F)
        {
            if (F == 1)
            {
                dgvMateriales.Rows.Clear();
                dgvMateriales.Refresh();
                foreach (DataRow fila in DatosPiezas.Rows)
                {
                    CodM.Add(fila["CodigoMaterial"].ToString());
                    Nombre.Add(fila["Nombre"].ToString());
                    Existencia.Add(fila["Existencia"].ToString());
                    Stock.Add(fila["Stock"].ToString());
                    Prov.Add(fila["Proveedor"].ToString());
                }
                if (CodM.Count > 0)
                {
                    dgvMateriales.RowCount = CodM.Count;
                    for (int i = 0; i < CodM.Count; i++)
                    {
                        dgvMateriales[0, i].Value = ReducirEspaciado(CodM[i]);
                        dgvMateriales[1, i].Value = ReducirEspaciado(Nombre[i]);
                        dgvMateriales[2, i].Value = ReducirEspaciado(Existencia[i]);
                        dgvMateriales[3, i].Value = ReducirEspaciado(Stock[i]);
                        dgvMateriales[4, i].Value = ReducirEspaciado(Prov[i]);

                    }
                }
            }
            else
            {
                dgvMaterialesF.Rows.Clear();
                dgvMaterialesF.Refresh();
                CodM = new List<string>();
                Nombre = new List<string>();
                Existencia = new List<string>();
                Stock = new List<string>();
                Falt = new List<string>();
                Prov = new List<string>();
                foreach (DataRow fila in DatosPiezas.Rows)
                {
                    CodM.Add(fila["CodigoMaterial"].ToString());
                    Nombre.Add(fila["Nombre"].ToString());
                    Existencia.Add(fila["Existencia"].ToString());
                    Stock.Add(fila["Stock"].ToString());
                    Falt.Add(fila["Faltantes"].ToString());
                    Prov.Add(fila["Proveedor"].ToString());
                }
                if (CodM.Count > 0)
                {
                    dgvMaterialesF.RowCount = CodM.Count;
                    for (int i = 0; i < CodM.Count; i++)
                    {
                        dgvMaterialesF[0, i].Value = ReducirEspaciado(CodM[i]);
                        dgvMaterialesF[1, i].Value = ReducirEspaciado(Nombre[i]);
                        dgvMaterialesF[2, i].Value = ReducirEspaciado(Existencia[i]);
                        dgvMaterialesF[3, i].Value = ReducirEspaciado(Stock[i]);
                        dgvMaterialesF[4, i].Value = ReducirEspaciado(Falt[i]);
                        dgvMaterialesF[5, i].Value = ReducirEspaciado(Prov[i]);
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<string[,]>> Proveedores = new List<List<string[,]>>();
            List<int> CantidadT = new List<int>();
            int i = 0;
            while (i < dgvMateriales.RowCount)
            {
                if (dgvMateriales[5, i].Value != null)
                {
                    string p = dgvMateriales[4, i].Value.ToString();
                    int j = 0;
                    bool insertado = false;
                    while(j < Proveedores.Count)
                    {
                        if(Proveedores[j][0][0,0].Contains(p))
                        {
                            Proveedores[j].Add(new string[,] { {p, dgvMateriales[0, i].Value.ToString(), dgvMateriales[5, i].Value.ToString() } });
                            CantidadT[j] += Convert.ToInt32(dgvMateriales[5, i].Value.ToString());
                            insertado = true;
                            break;
                        }
                        j++;
                    }
                    if(!insertado)
                    {
                        Proveedores.Add(new List<string[,]> { new string[,] { { p, dgvMateriales[0, i].Value.ToString(), dgvMateriales[5, i].Value.ToString() } } });
                        CantidadT.Add(Convert.ToInt32(dgvMateriales[5, i].Value.ToString()));
                    }
                }
                i++;
            }

            i = 0;
            while (i < dgvMaterialesF.RowCount)
            {
                if (dgvMaterialesF[6, i].Value != null)
                {
                    string p = dgvMaterialesF[5, i].Value.ToString();
                    int j = 0;
                    bool insertado = false;
                    while (j < Proveedores.Count)
                    {
                        if (Proveedores[j][0][0, 0].Contains(p))
                        {
                            Proveedores[j].Add(new string[,] { { p, dgvMaterialesF[0, i].Value.ToString(), dgvMaterialesF[6, i].Value.ToString() } });
                            CantidadT[j] += Convert.ToInt32(dgvMaterialesF[6, i].Value.ToString());
                            insertado = true;
                            break;
                        }
                        j++;
                    }
                    if (!insertado)
                    {
                        Proveedores.Add(new List<string[,]> { new string[,] { { p, dgvMaterialesF[0, i].Value.ToString(), dgvMaterialesF[6, i].Value.ToString() } } });
                        CantidadT.Add(Convert.ToInt32(dgvMaterialesF[6, i].Value.ToString()));
                    }
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
            int requisiciones = 0;
            while (i < Proveedores.Count)
            {
                int j = 0;
                while (j < Proveedores[i].Count)
                {
                    string[] Datos = { lblUsuario.Text, fecha, CantidadT[i].ToString(),Proveedores[i][j][0,0] };
                    if (mancp.InsertarRequisicion(Datos) > 0)
                    {
                        string[] Datos1 = new string[0];
                        var datosRequi = new DataTable();
                        datosRequi = mancp.TodasRequisicion(Datos1);
                        string IDRequi = "";
                        foreach (DataRow fila in datosRequi.Rows)
                        {
                            IDRequi = (fila["IDRequisicion"].ToString());
                        }
                        while (j < Proveedores[i].Count)
                        {
                            string[] Datos2 = { IDRequi, Proveedores[i][j][0, 1], Proveedores[i][j][0, 2] };
                            mancp.InsertarDetalleRequisicion(Datos2);
                            j++;
                            requisiciones++;
                        }
                    }                                
                }
                i++;
            }
                MessageBox.Show("Las Requisiciones han sido Insertadas con sus Respectivos Proveedores");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text };
            intusuario.enviarEvento("PantallaRequisiciones", Datos);
        }
    }
}
