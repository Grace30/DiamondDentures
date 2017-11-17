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


namespace DiseñoFinal
{
    public partial class Reportes : Form
    {
        InterfaceUsuario intusuario;
        ManejadorFacturas maf = new ManejadorFacturas();
        Validación v;
        Form pantalla;
        public Reportes()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
        }
        public Reportes(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            this.pantalla = pantalla;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void Reportes_Load(object sender, EventArgs e)
        {
            RellenarTODO();
            pBForma.Visible = false;
            pBNota.Visible = false;
            pBOficio.Visible = false;
            pBFactura.Visible = false;
            //if (dgvPedidos[4, dgvPedidos.CurrentCell.RowIndex].Value.ToString() == "Terminado")
            //{
            //    pBForma.Visible = true;
            //    pBNota.Visible = true;
            //    pBFactura.Visible = true;

            //}
            //if (dgvPedidos[4, dgvPedidos.CurrentCell.RowIndex].Value.ToString() == "Sin Confirmar")
            //{
            //    pBForma.Visible = true;
            //    pBOficio.Visible = true;

            //}
            //if (dgvPedidos[4, dgvPedidos.CurrentCell.RowIndex].Value.ToString() == "Confirmado")
            //{
            //    pBForma.Visible = true;
            //    pBNota.Visible = false;
            //}

        }
        public void RellenarTODO()
        {
            var Pedidos = new DataTable();
            Pedidos = maf.ObtenerDatosPedido();
            dgvPedidos.ColumnCount = Pedidos.Columns.Count;
            dgvPedidos.RowCount = Pedidos.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in Pedidos.Rows)
            {
                dgvPedidos["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                dgvPedidos["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                dgvPedidos["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                dgvPedidos["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                dgvPedidos["EstadoP", renglon].Value = ReducirEspaciado(fila["EstatusPedido"].ToString());
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

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenuPrincipal))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuPrincipal))
                    {
                        frm.Show();
                    }
                }
            }
            else if(pantalla.GetType() == typeof(MenuGeneral))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuGeneral))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void dgvPedidos_CurrentCellChanged(object sender, EventArgs e)
        {

            pBForma.Visible = pBOficio.Visible = pBNota.Visible = pBFactura.Visible = false;
            if (dgvPedidos.CurrentCell != null)
            {
                DataGridViewCell t = dgvPedidos[4, dgvPedidos.CurrentCell.RowIndex];
                if (t.Value != null)
                {
                    string Estado = t.Value.ToString();
                    if (Estado.ToUpper() == "Finalizado".ToUpper())
                    {
                      //  pBNota.Visible = pBFactura.Visible = true;
                        pBNota.Visible = pBOficio.Visible = pBForma.Visible = true;
                    }
                    else
                    {
                        if (Estado.ToUpper() == "Confirmado".ToUpper())
                        {
                            pBForma.Visible = pBOficio.Visible = true;
                        }
                        else
                        {
                            if (Estado.ToUpper() == "Por Confirmar".ToUpper())
                            {
                                pBForma.Visible =  true;
                            }
                            else
                            {
                                if (Estado.ToUpper() == "Sin Elaborar".ToUpper())
                                {
                                    //pBNota.Visible = pBOficio.Visible = pBForma.Visible = true;
                                }
                                else
                                {
                                    if (Estado.ToUpper() == "En Proceso".ToUpper())
                                    {
                                        pBForma.Visible = pBOficio.Visible = true;
                                    }

                                    else
                                    {
                                        if (Estado.ToUpper() == "Facturado".ToUpper())
                                        {
                                            pBFactura.Visible = true;
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {

                dgvPedidos.Rows.Clear();
                DataTable Tabla = null;
                if (rbDentista.Checked)
                {
                    Tabla = maf.BuscarPorPedido(new string[] { "", txtBuscar.Text });
                }
                else
                {
                    Tabla = maf.BuscarPorPedido(new string[] { txtBuscar.Text, "" });
                }
                txtBuscar.Clear();
                dgvPedidos.RowCount = Tabla.Rows.Count;
                int renglon = 0;
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvPedidos["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvPedidos["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvPedidos["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                    dgvPedidos["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                    dgvPedidos["EstadoP", renglon].Value = ReducirEspaciado(fila["EstatusPedido"].ToString());
                    renglon++;
                }
            }
            else
                RellenarTODO();
            dgvPedidos_CurrentCellChanged(dgvPedidos, new EventArgs());
        }

        private void pBOficio_Click(object sender, EventArgs e)
        {

            //string[] Datos3 = { dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString(), "CONFIRMADO" };
            //intusuario.enviarEvento("CambiarEstado", Datos3);
       
            //dgvPedidos[4, dgvPedidos.SelectedCells[0].RowIndex].Value = "CONFIRMADO";

            VistaPreviaOficio objForm = new VistaPreviaOficio();

            string idPed= dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString();

            objForm.Pedido = idPed;

            objForm.ShowDialog();
        }

        private void pBNota_Click(object sender, EventArgs e)
        {
            string[] Datos = { dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString() };
            intusuario.enviarEvento("Elaborar nota", Datos);
            //VistaPreviaNota objForm = new VistaPreviaNota();

            //string idPed = dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString();

            //objForm.Folio = idPed;

            //objForm.ShowDialog();
        }

        private void pBFactura_Click(object sender, EventArgs e)
        {
            

            //string Estado = dgvPedidos[4, dgvPedidos.CurrentCell.RowIndex].Value.ToString();
            //if (Estado.ToUpper() == "Finalizado".ToUpper())
            //{
            //    string[] Datos = { dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString() };
            //    intusuario.enviarEvento("PantallaElaborarFactura", Datos);
            //}
            //else
            //{
            //    if (Estado.ToUpper() == "Facturado".ToUpper())
            //    {
                    DesplegarFactura(dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString());
            //    }
            //}
           

        }

        private void pBForma_Click(object sender, EventArgs e)
        {
            VistaPreviaForma objForm = new VistaPreviaForma();

            string idPed = dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString();

            objForm.Pedido = idPed;

            objForm.ShowDialog();
        }

        //Métodos para los reportes
        public void DesplegarFactura(string IDPedido)
        {
            VistaPrevia objForm = new VistaPrevia();

            objForm.Pedido = IDPedido;

            objForm.ShowDialog();
        }
        public void DesplegarFormaDePedido(string IDPedido)
        {
            VistaPreviaForma objForm = new VistaPreviaForma();

            objForm.Pedido = IDPedido;

            objForm.ShowDialog();
        }
        public void DesplegarOficioConfirmacion(string IDPedido)
        {
            VistaPreviaOficio objForm = new VistaPreviaOficio();

            objForm.Pedido = IDPedido;

            objForm.ShowDialog();
        }
        public void DesplegarNotaTerminacion(string IDPedido)
        {
            VistaPreviaNota objForm = new VistaPreviaNota();

            objForm.Folio = IDPedido;

            objForm.ShowDialog();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbDentista.Checked)
            {
                v.SoloLetras(e);
            }
            else
                v.SoloNumeros(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {

                dgvPedidos.Rows.Clear();
                DataTable Tabla = null;
                if (rbDentista.Checked)
                {
                    Tabla = maf.BuscarPorPedido(new string[] { "", txtBuscar.Text });
                }
                else
                {
                    Tabla = maf.BuscarPorPedido(new string[] { txtBuscar.Text, "" });
                }
              //  txtBuscar.Clear();
                dgvPedidos.RowCount = Tabla.Rows.Count;
                int renglon = 0;
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvPedidos["NoPedido", renglon].Value = ReducirEspaciado(fila["IDPedido"].ToString());
                    dgvPedidos["NombreD", renglon].Value = ReducirEspaciado(fila["Nombre"].ToString());
                    dgvPedidos["DireccionD", renglon].Value = ReducirEspaciado(fila["Direccion"].ToString());
                    dgvPedidos["TelefonoD", renglon].Value = ReducirEspaciado(fila["Telefono"].ToString());
                    dgvPedidos["EstadoP", renglon].Value = ReducirEspaciado(fila["EstatusPedido"].ToString());
                    renglon++;
                }
            }
            else
                RellenarTODO();
            dgvPedidos_CurrentCellChanged(dgvPedidos, new EventArgs());
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
