using System.Data;
using System.Windows.Forms;
using Entidad;


namespace DiseñoFinal.ReportesM
{
    public partial class VerRequisicion : Form
    {
        InterfaceUsuario intusuario;
        Form pantalla;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        string UsuarioEnCurso = "";
        public VerRequisicion(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }


        public void RellenarRequisicion()
        {
            string[] Datos = { "", "" };
            var req = new DataTable();
        
            req = mare.ObtenerDatosRequisicion(Datos);
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
                dgvReq["FechaAutorizado", renglon].Value = ReducirEspaciado(fila["FechaAutorizado"].ToString());
                dgvReq["FechaSurtido", renglon].Value = ReducirEspaciado(fila["FechaSurtido"].ToString());
                dgvReq["Proveedor", renglon].Value = ReducirEspaciado(fila["Proveedor"].ToString());
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

        private void dgvReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            var req = new DataTable();
            string[] Datos = { txtBuscar.Text, txtBuscar.Text };
            req = mare.ObtenerDatosRequisicion(Datos);
            dgvReq.RowCount = req.Rows.Count;
         //   dgvReq.ColumnCount = req.Columns.Count;

            int renglon = 0;
            foreach (DataRow fila in req.Rows)
            {
                dgvReq["IDRequisicion", renglon].Value = ReducirEspaciado(fila["IDRequisicion"].ToString());
                dgvReq["Empleado", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvReq["CantidadTotal", renglon].Value = ReducirEspaciado(fila["CantidadTotal"].ToString());
                dgvReq["FechadePedido", renglon].Value = ReducirEspaciado(fila["Fecha de Pedido"].ToString());
                dgvReq["Surtido", renglon].Value = ReducirEspaciado(fila["Surtido"].ToString());
                dgvReq["FechaAutorizado", renglon].Value = ReducirEspaciado(fila["FechaAutorizado"].ToString());
                dgvReq["FechaSurtido", renglon].Value = ReducirEspaciado(fila["FechaSurtido"].ToString());
                dgvReq["Proveedor", renglon].Value = ReducirEspaciado(fila["Proveedor"].ToString());
                renglon++;
            }
        }

        private void pBSalir_Click(object sender, System.EventArgs e)
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
