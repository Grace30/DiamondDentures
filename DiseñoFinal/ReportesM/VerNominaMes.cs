using System.Data;
using System.Windows.Forms;
using Entidad;
using System;

namespace DiseñoFinal.ReportesM
{
    public partial class VerNominaMes : Form
    {

        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public VerNominaMes(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }
        public void RellenarNomina()
        {
            var nom = new DataTable();
            nom = mare.ObtenerNominaGeneral();
            dgvNominaMes.RowCount = nom.Rows.Count;
            dgvNominaMes.ColumnCount = nom.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in nom.Rows)
            {
                dgvNominaMes["IDPago", renglon].Value = ReducirEspaciado(fila["IdPago"].ToString());
                dgvNominaMes["Mes", renglon].Value = ReducirEspaciado(fila["MesAPagar"].ToString());
                dgvNominaMes["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvNominaMes["Sueldo", renglon].Value = ReducirEspaciado(fila["Sueldo"].ToString());
                dgvNominaMes["TasaISR", renglon].Value = ReducirEspaciado(fila["TasaISR"].ToString());
                dgvNominaMes["CuotaISR", renglon].Value = ReducirEspaciado(fila["CuotaISR"].ToString());
                dgvNominaMes["APagar", renglon].Value = ReducirEspaciado(fila["APagar"].ToString());
                dgvNominaMes["FechaPago", renglon].Value = ReducirEspaciado(fila["FechaPago"].ToString());

                renglon++;
            }
        }
        public static string ReducirEspaciado(string Cadena)
        {
            string temp = "";
            if (!string.IsNullOrWhiteSpace(Cadena))
            {
                bool Empezo = false;
                for (int i = Cadena.Length - 1; i >= 0; i--)
                {
                    if (Cadena[i] != ' ')
                    {
                        Empezo = true;
                    }
                    if (Empezo)
                        temp = Cadena[i] + temp;
                }
            }
            return temp;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            var Tabla = new DataTable();
            Tabla = mare.NominaMes(Convert.ToInt32(comboBox1.SelectedIndex + 1));

            dgvNominaMes.RowCount = Tabla.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in Tabla.Rows)
            {
                dgvNominaMes["IDPago", renglon].Value = ReducirEspaciado(fila["IdPago"].ToString());
                dgvNominaMes["Mes", renglon].Value = ReducirEspaciado(fila["MesAPagar"].ToString());
                dgvNominaMes["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvNominaMes["Sueldo", renglon].Value = ReducirEspaciado(fila["Sueldo"].ToString());
                dgvNominaMes["TasaISR", renglon].Value = ReducirEspaciado(fila["TasaISR"].ToString());
                dgvNominaMes["CuotaISR", renglon].Value = ReducirEspaciado(fila["CuotaISR"].ToString());
                dgvNominaMes["APagar", renglon].Value = ReducirEspaciado(fila["APagar"].ToString());
                dgvNominaMes["FechaPago", renglon].Value = ReducirEspaciado(fila["FechaPago"].ToString());

                renglon++;
            }
        }
        private void VerNominaMes_Load(object sender, System.EventArgs e)
        {
            RellenarNomina();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(comboBox1.SelectedIndex + 1);
            VistaPreviaNominaMes obj = new VistaPreviaNominaMes(mes);
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VistaPreviaNominaGeneral objform = new VistaPreviaNominaGeneral();
            objform.ShowDialog();
        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenúReportes))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenúReportes))
                    {
                        frm.Show();
                    }
                }
            }
        }
    }
}
