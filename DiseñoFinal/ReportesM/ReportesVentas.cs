using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidad;
using DiseñoFinal.ReportesM;

namespace DiseñoFinal
{
    public partial class ReportesVentas : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public ReportesVentas()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
          
            v = new Validación();
        }
        public ReportesVentas(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            this.pantalla = pantalla;
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }

        private void ReportesVentas_Load(object sender, EventArgs e)
        {

            lblUsuario.Text = UsuarioEnCurso;
            RellenarTODO();
            //lblDesde.Visible = false;
            //lblHasta.Visible = false;
            //dtFechaDesde.Visible = false;
            //dtFechaHasta.Visible = false;
            //lblNombreE.Visible = false;
            //txtNombreEmpleado.Visible = false;

            //if (rdbFecha.Checked == true)
            //{
            //    lblDesde.Visible = true;
            //    lblHasta.Visible = true;
            //    dtFechaDesde.Visible = true;
            //    dtFechaHasta.Visible = true;
            //}
            //else
            //{
            //    lblNombreE.Visible = true;
            //    txtNombreEmpleado.Visible = true;
            //}

        }
        public void RellenarTODO()
        {
            var Ventas = new DataTable();
            string[] Datos = { "","","" };
            Ventas = mare.ObtenerDatosVentas(Datos);
            dgvRepoVentas.ColumnCount = Ventas.Columns.Count;
            dgvRepoVentas.RowCount = Ventas.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in Ventas.Rows)
            {
                dgvRepoVentas["FolioVenta", renglon].Value = ReducirEspaciado(fila["FolioVenta"].ToString());
                dgvRepoVentas["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvRepoVentas["IDPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                dgvRepoVentas["Importe", renglon].Value = ReducirEspaciado(fila["Importe"].ToString());
                dgvRepoVentas["Abono", renglon].Value = ReducirEspaciado(fila["Abono"].ToString());
                dgvRepoVentas["Feria", renglon].Value = ReducirEspaciado(fila["Feria"].ToString());
                dgvRepoVentas["FormadePago", renglon].Value = ReducirEspaciado(fila["FormaDePago"].ToString());
                dgvRepoVentas["Descripcion", renglon].Value = ReducirEspaciado(fila["Descripcion"].ToString());
                dgvRepoVentas["FechaPago", renglon].Value = ReducirEspaciado(fila["FechaPago"].ToString());
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var Tabla = new DataTable();
          //  DataTable Tabla = null;
            if (rdbFecha.Checked == true)
            {
                Tabla = mare.BuscarPorFecha(new string[]
                { v.FormatoFecha(dtFechaDesde.Value), v.FormatoFecha(dtFechaHasta.Value) }); 
            }
            else
            {
                Tabla = mare.BuscarPorNombreE(txtNombreEmpleado.Text);
            }
          
            dgvRepoVentas.RowCount = Tabla.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in Tabla.Rows)
            {

                dgvRepoVentas["FolioVenta", renglon].Value = ReducirEspaciado(fila["FolioVenta"].ToString());
                dgvRepoVentas["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvRepoVentas["IDPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                dgvRepoVentas["Importe", renglon].Value = ReducirEspaciado(fila["Importe"].ToString());
                dgvRepoVentas["Abono", renglon].Value = ReducirEspaciado(fila["Abono"].ToString());
                dgvRepoVentas["Feria", renglon].Value = ReducirEspaciado(fila["Feria"].ToString());
                dgvRepoVentas["FormadePago", renglon].Value = ReducirEspaciado(fila["FormaDePago"].ToString());
                dgvRepoVentas["Descripcion", renglon].Value = ReducirEspaciado(fila["Descripcion"].ToString());
                dgvRepoVentas["FechaPago", renglon].Value = ReducirEspaciado(fila["FechaPago"].ToString());
                renglon++;
            }

        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            SuperVistaPrevia objForm = new SuperVistaPrevia();
            objForm.ShowDialog();
        }

        private void btnVentasFecha_Click(object sender, EventArgs e)
        {
            VistaPreviaVentasFecha objForm = new VistaPreviaVentasFecha();
            string FechaDesde = v.FormatoFecha(dtFechaDesde.Value);
            string FechaHasta = v.FormatoFecha(dtFechaHasta.Value);
            objForm.FechaDesde = FechaDesde;
            objForm.FechaHasta = FechaHasta;
            objForm.ShowDialog();
        }

        private void btnVentasEmpleado_Click(object sender, EventArgs e)
        {
            VistaPreviaVentasNombre objForm = new VistaPreviaVentasNombre();
            string Empleado = txtNombreEmpleado.Text;
            objForm.Empleado = Empleado;
            objForm.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            VIstaPreviaTicket objForm = new VIstaPreviaTicket();
            string Folio = dgvRepoVentas[0, dgvRepoVentas.CurrentCell.RowIndex].Value.ToString();
            objForm.Folio = Folio;
            objForm.ShowDialog();

        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
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
