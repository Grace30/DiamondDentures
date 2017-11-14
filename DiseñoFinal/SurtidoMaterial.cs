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
    public partial class SurtidoMaterial : Form
    {
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;
        public List<string> IdR = new List<string>();
        public List<string> EmpleadoA = new List<string>();
        public List<string> FechaS = new List<string>();
        public List<string> CodMat = new List<string>();
        public List<string> NombreMat = new List<string>();
        public List<string> Cantidad = new List<string>();
        public List<string> Proveedor = new List<string>();
        List<string[,]> Cantidades = new List<string[,]>();
        int contador = 0;
        string C = "", R = "", Mat = "";
        int ingresados = 0;
        string IDRequisicion = "";

        public SurtidoMaterial()
        {

        }
        public SurtidoMaterial(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        private void SurtidoMaterial_Load(object sender, EventArgs e)
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
            IdR = new List<string>();
            EmpleadoA = new List<string>();
            FechaS = new List<string>();
            CodMat = new List<string>();
            NombreMat = new List<string>();
            Cantidad = new List<string>();
            Proveedor = new List<string>();
            if (DatosAlmacen.Rows.Count == 0 && txtRequi.Text == "")
            {
                MessageBox.Show("No hay materiales por recibir");
            }
            dgvMateriales.Rows.Clear();
            dgvMateriales.Refresh();
            foreach (DataRow fila in DatosAlmacen.Rows)
            {
                IdR.Add(fila["IDRequisicion"].ToString());
                EmpleadoA.Add(fila["EmpleadoAutoriza"].ToString());
                FechaS.Add(fila["Fecha de Solicitud"].ToString());
                CodMat.Add(fila["CodigoMaterial"].ToString());
                NombreMat.Add(fila["Material"].ToString());
                Proveedor.Add(fila["Proveedor"].ToString());
                Cantidad.Add(fila["Cantidad"].ToString());
            }
            if (IdR.Count > 0)
            {
                dgvMateriales.RowCount = IdR.Count;
                for (int i = 0; i < IdR.Count; i++)
                {
                    dgvMateriales[0, i].Value = ReducirEspaciado(IdR[i]);
                    dgvMateriales[1, i].Value = ReducirEspaciado(EmpleadoA[i]);
                    dgvMateriales[2, i].Value = ReducirEspaciado(FechaS[i]);
                    dgvMateriales[3, i].Value = ReducirEspaciado(CodMat[i]);
                    dgvMateriales[4, i].Value = ReducirEspaciado(NombreMat[i]);
                    dgvMateriales[5, i].Value = ReducirEspaciado(Proveedor[i]);
                    dgvMateriales[6, i].Value = ReducirEspaciado(Cantidad[i]);

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
            Cantidades = new List<string[,]>();
            contador = 0;
            int pedidos = 0;
            ingresados = 0;            
            while (contador < dgvMateriales.RowCount)
            {
                if (dgvMateriales[7, contador].Value.ToString() != null)
                {
                    IDRequisicion = dgvMateriales[0, contador].Value.ToString();
                    C = dgvMateriales[6, contador].Value.ToString();
                    R = dgvMateriales[7, contador].Value.ToString();
                    Mat = dgvMateriales[4, contador].Value.ToString();
                    if (C == R)
                    {
                        string[] Datos = { dgvMateriales[3, contador].Value.ToString(), dgvMateriales[7, contador].Value.ToString() };
                        mancp.SumarMat(Datos);
                        ingresados++;
                        string[] Datos2 = { txtRequi.Text };
                        mancp.EstadoRequi(Datos2);
                    }
                    else
                    {
                        Cantidades.Add(new string[,] { { dgvMateriales[3, contador].Value.ToString(), dgvMateriales[7, contador].Value.ToString(),C,R,Mat , dgvMateriales[5,contador].Value.ToString(), IDRequisicion} });                     
                    }
                    pedidos++;
                }
                contador++;
            }
            if (ingresados == pedidos)
            {
                string[] Datos2 = { txtRequi.Text };
                mancp.EstadoRequi(Datos2);

                MessageBox.Show("Materiales Surtidos al Almacen");

                string[] Datos3 = { txtRequi.Text };
                var datosRequi = new DataTable();
                datosRequi = mancp.RequisicionesAcep(Datos3);
                DatosData(datosRequi);
            }
            else
            {
                ingresados = 0;
                panel1.Visible = true;
                HuboFaltantes();
            }
        }

        public void HuboFaltantes()
        {
            txtRequi.Enabled = false;
            button1.Enabled = false;
            dgvMateriales.Enabled = false;
            pictureBox1.Enabled = false;
            if (ingresados < Cantidades.Count)
            {
                C = Cantidades[ingresados][0, 2];
                R = Cantidades[ingresados][0, 3];
                Mat = Cantidades[ingresados][0, 4];
                string mensaje = "El proveedor te está entregando la cantidad de " + R + " del material " + Mat + ", \nTu solicitud era de " + C + ". \n                                                    ¿Que deseas hacer?";
                lblMensaje.Text = mensaje;
            }
            else
            {
                txtRequi.Enabled = true;
                button1.Enabled = true;
                dgvMateriales.Enabled = true;
                pictureBox1.Enabled = true;
                panel1.Visible = false;
                string[] Datos3 = { txtRequi.Text };
                var datosRequi = new DataTable();
                datosRequi = mancp.RequisicionesAcep(Datos3);
                DatosData(datosRequi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea borrar el Material de la Requisicion?", "¿?", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //Borrar Material de la Requisicion
                string[] Datos = { Cantidades[ingresados][0, 2], txtRequi.Text, Cantidades[ingresados][0, 0] };
                if (mancp.BorrardeRequi(Datos) > 0) { MessageBox.Show("Material borrado de la Requisicion"); }
                ingresados++;
                HuboFaltantes();
            }
        }

        private void txtRequi_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtRequi.Text };
            var datosRequi = new DataTable();
            datosRequi = mancp.RequisicionesAcep(Datos);
            DatosData(datosRequi);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int diferencia = Convert.ToInt32(Cantidades[ingresados][0, 2]) - Convert.ToInt32(Cantidades[ingresados][0, 3]);
            if (diferencia>0) {
                DialogResult resultado = MessageBox.Show("Desea crear una nueva requisicion con la cantidad del material faltante?", "¿?", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    //Sumar materiales
                    string[] Datos = { Cantidades[ingresados][0, 0], Cantidades[ingresados][0, 1] };
                    if (mancp.SumarMat(Datos) > 0) { MessageBox.Show("Se han agregado la cantidad de " + Cantidades[ingresados][0, 1] + " al material " + Cantidades[ingresados][0, 4]); }
                    //Cambiar el estado a Surtido
                    string[] Datos0 = { txtRequi.Text };
                    mancp.EstadoRequi(Datos0);
                    //Actualizar cantidades
                    string[] DatosCantidades = { Cantidades[ingresados][0, 1], diferencia.ToString(), txtRequi.Text, Cantidades[ingresados][0, 0] };
                    if (mancp.ActualizarCantidades(DatosCantidades) > 0) { MessageBox.Show("Se actualizó el total de la Requisicion por el material faltante"); }
                    //Crear nueva requisiicion
                    string[] today = DateTime.Today.ToString("d").Split('/');
                    string fecha = "";
                    int i = 2;
                    while (i >= 0)
                    {
                        fecha += today[i];
                        if (i > 0) { fecha += "/"; }
                        i--;
                    }
                    string[] Datos1 = { lblUsuario.Text, fecha, diferencia.ToString(), Cantidades[ingresados][0, 5] };
                    if (mancp.InsertarRequisicion(Datos1) > 0)
                    {
                        string[] Datos2 = new string[0];
                        var datosRequi = new DataTable();
                        datosRequi = mancp.TodasRequisicion(Datos2);
                        string IDRequi = "";
                        foreach (DataRow fila in datosRequi.Rows)
                        {
                            IDRequi = (fila["IDRequisicion"].ToString());
                        }
                        string[] Datos3 = { IDRequi, Cantidades[ingresados][0, 0], diferencia.ToString() };
                        mancp.InsertarDetalleRequisicion(Datos3);
                        MessageBox.Show("Se creó la nueva requisicion del material " + Cantidades[ingresados][0, 4] + " por la cantidad de " + diferencia.ToString());
                    }
                    ingresados++;
                    HuboFaltantes();
                }
                else if (resultado == DialogResult.No)
                {
                    //Sumar materiales
                    string[] Datos = { Cantidades[ingresados][0, 0], Cantidades[ingresados][0, 1] };
                    mancp.SumarMat(Datos);
                    //Cambiar el estado a Surtido
                    string[] Datos0 = { txtRequi.Text };
                    mancp.EstadoRequi(Datos0);
                    //Actualizar cantidades
                    string[] DatosCantidades = { Cantidades[ingresados][0, 1], diferencia.ToString(), txtRequi.Text, Cantidades[ingresados][0, 0] };
                    mancp.ActualizarCantidades(DatosCantidades);
                    ingresados++;
                    HuboFaltantes();
                }
                else if (resultado == DialogResult.Cancel)
                {
                }
            }
            else
            {
                //Sumar materiales
                string[] Datos = { Cantidades[ingresados][0, 0], Cantidades[ingresados][0, 2] };
                if (mancp.SumarMat(Datos) > 0) { MessageBox.Show("Se han agregado la cantidad de " + Cantidades[ingresados][0, 2] + " al material " + Cantidades[ingresados][0, 4]+". Se le regresó " + -(diferencia) + " al proveedor"); }
                //Cambiar el estado a Surtido
                string[] Datos0 = { txtRequi.Text };
                mancp.EstadoRequi(Datos0);
                ingresados++;
                HuboFaltantes();
            }
        }
    }
}
