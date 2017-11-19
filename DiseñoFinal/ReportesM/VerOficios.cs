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
        Form pantalla;
        ManejadorReportes mare = new ManejadorReportes();
        Validación v;
      
        string UsuarioEnCurso = "";
        public VerOficios(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            v = new Validación();
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
        }
        public void RellenarTODO()
        {
            var oficios = new DataTable();
            string[] Datos = { "", "" };
            oficios = mare.ObtenerOficios(Datos);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtBuscar.Text, txtBuscar.Text };
            var oficios = new DataTable();
           
            oficios = mare.ObtenerOficios(Datos);
        
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
