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
    public partial class VerTickets : Form
    {

        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public VerTickets()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
         
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            VIstaPreviaTicket objForm = new VIstaPreviaTicket();
            string Folio = dgvRepoVentas[0, dgvRepoVentas.CurrentCell.RowIndex].Value.ToString();
            objForm.Folio = Folio;
            objForm.ShowDialog();
        }
        public void RellenarTODO()
        {
            var Ventas = new DataTable();
            Ventas = mare.ObtenerDatosVentas();
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

        private void VerTickets_Load(object sender, EventArgs e)
        {
            RellenarTODO();
        }

        private void dgvRepoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
