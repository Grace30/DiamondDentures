using System.Data;
using System.Windows.Forms;
using Entidad;


namespace DiseñoFinal.ReportesM
{
    public partial class VerRequisicion : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public VerRequisicion()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }


        public void RellenarRequisicion()
        {
            var req = new DataTable();
            req = mare.ObtenerDatosRequisicion();
            dgvReq.RowCount = req.Rows.Count;
            dgvReq.ColumnCount = req.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in req.Rows)
            {
                dgvReq["IDRequisicion", renglon].Value = ReducirEspaciado(fila["IDRequisicion"].ToString());
                dgvReq["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvReq["CantidadTotal", renglon].Value = ReducirEspaciado(fila["CantidadTotal"].ToString());
                dgvReq["FechadePedido", renglon].Value = ReducirEspaciado(fila["Fecha de Pedido"].ToString());
                dgvReq["Surtido", renglon].Value = ReducirEspaciado(fila["Surtido"].ToString());
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

        private void VerRequisicion_Load(object sender, System.EventArgs e)
        {
            RellenarRequisicion();
        }

        private void btnreq_Click(object sender, System.EventArgs e)
        {
            VistaPreviaReq objform = new VistaPreviaReq();
       
            string NoReq = dgvReq[0, dgvReq.CurrentCell.RowIndex].Value.ToString();
            objform.NoReq = NoReq;
            objform.ShowDialog();
        }
    }
}
