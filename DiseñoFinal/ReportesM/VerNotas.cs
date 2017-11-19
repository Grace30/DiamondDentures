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


namespace DiseñoFinal.ReportesM
{
    public partial class VerNotas : Form
    {
        InterfaceUsuario intusuario;
        Form pantalla;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
     string UsuarioEnCurso = "";
        

        public VerNotas(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }
        private void VerNotas_Load(object sender, EventArgs e)
        {
            RellenarTODO();
        }
        public void RellenarTODO()
        {
            var notas = new DataTable();
            string[] Datos = { "", "" };
            notas = mare.ObtenerNotas(Datos);
            dgvNota.ColumnCount = notas.Columns.Count;
            dgvNota.RowCount = notas.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in notas.Rows)
            {
                dgvNota["Folio1", renglon].Value = ReducirEspaciado(fila["Folionota"].ToString());
                dgvNota["NoPed1", renglon].Value = ReducirEspaciado(fila["Pedido"].ToString());
                dgvNota["NomDent1", renglon].Value = ReducirEspaciado(fila["NombreDentista"].ToString());
                dgvNota["Fecha1", renglon].Value = ReducirEspaciado(fila["FechaEmisión"].ToString());
                dgvNota["NomEmp1", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvNota["FechaTerminaciónPedido1", renglon].Value = ReducirEspaciado(fila["FechaTerminaciónPedido"].ToString());
                dgvNota["FechaEntrega1", renglon].Value = ReducirEspaciado(fila["FechaEntrega"].ToString());
                dgvNota["Observaciones1", renglon].Value = ReducirEspaciado(fila["Observaciones"].ToString());
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

        private void btnNota_Click(object sender, EventArgs e)
        {
            VistaPreviaNota objForm = new VistaPreviaNota();
          //  string Folio = dgvNota[0, dgvNota.CurrentCell.RowIndex].Value.ToString();
            string Pedido = dgvNota[1, dgvNota.CurrentCell.RowIndex].Value.ToString();
         //   objForm.Folio = Folio;
            objForm.Pedido = Pedido;
            objForm.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var notas = new DataTable();
            string[] Datos = { txtBuscar.Text, txtBuscar.Text };
            notas = mare.ObtenerNotas(Datos);
          
            dgvNota.RowCount = notas.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in notas.Rows)
            {
                dgvNota["Folio1", renglon].Value = ReducirEspaciado(fila["Folionota"].ToString());
                dgvNota["NoPed1", renglon].Value = ReducirEspaciado(fila["Pedido"].ToString());
                dgvNota["NomDent1", renglon].Value = ReducirEspaciado(fila["NombreDentista"].ToString());
                dgvNota["Fecha1", renglon].Value = ReducirEspaciado(fila["FechaEmisión"].ToString());
                dgvNota["NomEmp1", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvNota["FechaTerminaciónPedido1", renglon].Value = ReducirEspaciado(fila["FechaTerminaciónPedido"].ToString());
                dgvNota["FechaEntrega1", renglon].Value = ReducirEspaciado(fila["FechaEntrega"].ToString());
                dgvNota["Observaciones1", renglon].Value = ReducirEspaciado(fila["Observaciones"].ToString());
                renglon++;
            }
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
