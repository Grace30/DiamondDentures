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

namespace DiseñoFinal.ReportesM
{
    public partial class CortesdeCaja : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public CortesdeCaja()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
            v = new Validación();
        }

        private void CortesdeCaja_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioEnCurso;
            RellenarTODO();

        }
        public void RellenarTODO()
        {
            var cortes = new DataTable();
            cortes = mare.ObtenerCortes();
            dgvCortes.ColumnCount = cortes.Columns.Count;
            dgvCortes.RowCount = cortes.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in cortes.Rows)
            {
                dgvCortes["FolioCorte", renglon].Value = ReducirEspaciado(fila["FolioCorte"].ToString());
                dgvCortes["Fecha", renglon].Value = ReducirEspaciado(fila["Fecha"].ToString());
                dgvCortes["Hora", renglon].Value = ReducirEspaciado(fila["Hora"].ToString());
                dgvCortes["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvCortes["CajaChica", renglon].Value = ReducirEspaciado(fila["CajaChica"].ToString());
                dgvCortes["CajaMaxima", renglon].Value = ReducirEspaciado(fila["CajaMaxima"].ToString());
                dgvCortes["VentasTotales", renglon].Value = ReducirEspaciado(fila["VentasTotales"].ToString());
                dgvCortes["Real", renglon].Value = ReducirEspaciado(fila["Real"].ToString());
                dgvCortes["Banco", renglon].Value = ReducirEspaciado(fila["Banco"].ToString());
                dgvCortes["LoginnSupervisor", renglon].Value = ReducirEspaciado(fila["LoginnSupervisor"].ToString());
                dgvCortes["Comentarios", renglon].Value = ReducirEspaciado(fila["Comentarios"].ToString());

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

        private void btnCortesEmpleado_Click(object sender, EventArgs e)
        {
            VistaPreviaCorte obj = new VistaPreviaCorte();
            string Folio = dgvCortes[0, dgvCortes.CurrentCell.RowIndex].Value.ToString();
            obj.Folio = Folio;
            obj.ShowDialog();
        }

        private void btnCortesFecha_Click(object sender, EventArgs e)
        {
            VistaPreviaCorteFechas objForm = new VistaPreviaCorteFechas();
            string FechaDesde = v.FormatoFecha(dtFechaDesde.Value);
            string FechaHasta = v.FormatoFecha(dtFechaHasta.Value);
            objForm.FechaDesde = FechaDesde;
            objForm.FechaHasta = FechaHasta;
            objForm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var Tabla = new DataTable();
            //  DataTable Tabla = null;
            if (rdbFecha.Checked == true)
            {
                Tabla = mare.BuscarCortePorFecha(new string[]
                { v.FormatoFecha(dtFechaDesde.Value), v.FormatoFecha(dtFechaHasta.Value) });
            }
            else
            //if (rdbFolio.Checked == true)
            {
                Tabla = mare.BuscarCorteCaja(new string[] { txtDato.Text, "" });
            }
            //else
            //{
            //    Tabla = mare.BuscarCorteCaja(new string[] {  "", txtDato.Text });

            //}

            dgvCortes.RowCount = Tabla.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in Tabla.Rows)
            {
                dgvCortes["FolioCorte", renglon].Value = ReducirEspaciado(fila["FolioCorte"].ToString());
                dgvCortes["Fecha", renglon].Value = ReducirEspaciado(fila["Fecha"].ToString());
                dgvCortes["Hora", renglon].Value = ReducirEspaciado(fila["Hora"].ToString());
                dgvCortes["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvCortes["CajaChica", renglon].Value = ReducirEspaciado(fila["CajaChica"].ToString());
                dgvCortes["CajaMaxima", renglon].Value = ReducirEspaciado(fila["CajaMaxima"].ToString());
                dgvCortes["VentasTotales", renglon].Value = ReducirEspaciado(fila["VentasTotales"].ToString());
                dgvCortes["Real", renglon].Value = ReducirEspaciado(fila["Real"].ToString());
                dgvCortes["Banco", renglon].Value = ReducirEspaciado(fila["Banco"].ToString());
                dgvCortes["LoginnSupervisor", renglon].Value = ReducirEspaciado(fila["LoginnSupervisor"].ToString());
                dgvCortes["Comentarios", renglon].Value = ReducirEspaciado(fila["Comentarios"].ToString());

                renglon++;
            }
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

