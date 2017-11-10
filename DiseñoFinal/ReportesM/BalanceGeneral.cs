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
    public partial class BalanceGeneral : Form
    {

        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public BalanceGeneral()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RellenarTODO();
        }

        private void dgvRepoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BalanceGeneral_Load(object sender, EventArgs e)
        {
            //lblUsuario.Text = UsuarioEnCurso;
           
        }
        public void RellenarTODO()
        {
            var bal = new DataTable();
            bal = mare.ObtenerBalanceGeneral(new string[]
                { v.FormatoFecha(dtFechaDesde.Value), v.FormatoFecha(dtFechaHasta.Value) });
            dgvBalance.ColumnCount = bal.Columns.Count;
            dgvBalance.RowCount = bal.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in bal.Rows)
            {
                dgvBalance["Fecha", renglon].Value = ReducirEspaciado(fila["Fecha"].ToString());
                dgvBalance["Concepto", renglon].Value = ReducirEspaciado(fila["Concepto"].ToString());
                dgvBalance["Retiro", renglon].Value = ReducirEspaciado(fila["Retiro"].ToString());
                dgvBalance["Deposito", renglon].Value = ReducirEspaciado(fila["Deposito"].ToString());
                dgvBalance["saldo", renglon].Value = ReducirEspaciado(fila["saldo"].ToString());

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

        private void btnVista_Click(object sender, EventArgs e)
        {
            VistaPreviaBalance form = new VistaPreviaBalance();
            form.ShowDialog();
            
        }
    }
}
