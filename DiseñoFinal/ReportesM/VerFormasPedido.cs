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
    public partial class VerFormasPedido : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public VerFormasPedido()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }

        public void RellenarTODO()
        {
            var formas = new DataTable();
            formas = mare.ObtenerFormas();
            dgvFormas.ColumnCount = formas.Columns.Count;
            dgvFormas.RowCount = formas.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in formas.Rows)
            {
                dgvFormas["Folio", renglon].Value = ReducirEspaciado(fila["FolioForma"].ToString());
                dgvFormas["NoPed", renglon].Value = ReducirEspaciado(fila["Pedido"].ToString());
                dgvFormas["NombreDent", renglon].Value = ReducirEspaciado(fila["NombreDentista"].ToString());
                dgvFormas["Fecha", renglon].Value = ReducirEspaciado(fila["FechaEmisión"].ToString());
                dgvFormas["NomEmp", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
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

        private void VerFormasPedido_Load(object sender, EventArgs e)
        {
            RellenarTODO();
        }

        private void btnForma_Click(object sender, EventArgs e)
        {
            VistaPreviaForma objForm = new VistaPreviaForma();
            string Folio = dgvFormas[0, dgvFormas.CurrentCell.RowIndex].Value.ToString();
            string Pedido = dgvFormas[0, dgvFormas.CurrentCell.RowIndex].Value.ToString();
            objForm.Folio = Folio;
            objForm.Pedido = Pedido;
            objForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
