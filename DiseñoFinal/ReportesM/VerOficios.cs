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
    public partial class VerOficios : Form
    {
        InterfaceUsuario intusuario;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
        Form pantalla;
        string UsuarioEnCurso = "";
        public VerOficios()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }
        public void RellenarTODO()
        {
            var oficios = new DataTable();
            oficios = mare.ObtenerOficios();
            dgvOficios.ColumnCount = oficios.Columns.Count;
            dgvOficios.RowCount = oficios.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in oficios.Rows)
            {
                dgvOficios["Folio", renglon].Value = ReducirEspaciado(fila["FolioOficio"].ToString());
                dgvOficios["NoPed", renglon].Value = ReducirEspaciado(fila["Pedido"].ToString());
                dgvOficios["NombreDent", renglon].Value = ReducirEspaciado(fila["NombreDentista"].ToString());
                dgvOficios["Fecha", renglon].Value = ReducirEspaciado(fila["FechaEmisión"].ToString());
                dgvOficios["NomEmp", renglon].Value = ReducirEspaciado(fila["Empleado"].ToString());
                dgvOficios["FechaConfirmacion", renglon].Value = ReducirEspaciado(fila["FechaConfirmaciónPedido"].ToString());
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

        private void VerOficios_Load(object sender, EventArgs e)
        {
            RellenarTODO();
        }

        private void btnOficio_Click(object sender, EventArgs e)
        {
            VistaPreviaOficio objForm = new VistaPreviaOficio();
            string Folio = dgvOficios[0, dgvOficios.CurrentCell.RowIndex].Value.ToString();
            string Pedido = dgvOficios[1, dgvOficios.CurrentCell.RowIndex].Value.ToString();
            //objForm.Folio = Folio;
            objForm.Pedido = Pedido;
            objForm.ShowDialog();
        }
    }
}
