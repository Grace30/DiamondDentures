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

namespace DiseñoFinal
{
    public partial class ControlPedidos : Form
    {
        Validación v = new Validación();
        InterfaceUsuario intusuario;
        ManejadorRegistroUsuario manu = new ManejadorRegistroUsuario();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorFacturas maf = new ManejadorFacturas();
        public List<string> Dent = new List<string>();
        public List<string> CodPed = new List<string>();
        public List<string> Est = new List<string>();
        public List<string> FechaEnt = new List<string>();
        public List<string> Labor = new List<string>();
        public List<string> FechaLle = new List<string>();
        public List<string> Urg = new List<string>();
        string UsuarioEnCurso = "";
        string Departamento = "";
        Form pantalla;

        public ControlPedidos(string Usuario, string Depa)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
            Departamento = Depa;
        }

        public ControlPedidos(string Usuario, string Depa, Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = Usuario;
            Departamento = Depa;
            this.pantalla = pantalla;
        }

        private void ControlPedidos_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioEnCurso;
            lblDepa.Text = ReducirEspaciado(Departamento);

            if (CodPed.Count > 0)
            {
                OrganizarPedidos();
                dgvPedidos.RowCount = CodPed.Count;
                for (int i = 0; i < CodPed.Count; i++)
                {
                    dgvPedidos[0, i].Value = CodPed[i];
                    dgvPedidos[1, i].Value = Dent[i];
                    dgvPedidos[2, i].Value = Est[i];
                    dgvPedidos[3, i].Value = FechaLle[i];
                    dgvPedidos[4, i].Value = FechaEnt[i];
                    dgvPedidos[5, i].Value = Labor[i];

                }
                PintarEstado();
            }
            if (lblDepa.Text == "Administración")
            {
                gBAcotaciones.Enabled = true;
                gBAcotaciones.BackColor = Color.White;
                gBLaboratorio.Enabled = true;
                gBLaboratorio.BackColor = Color.White;
                gBRecepcion.Enabled = true;
                gBRecepcion.BackColor = Color.White;
                gBReportes.Enabled = true;
                gBReportes.BackColor = Color.White;
                cbLaboratorista.Enabled = true;
                llRegistrar.Enabled = true;
                pbFormaPedido.Enabled = true;
                pbFormaPedido.BackColor = Color.White;
                pbNotaTerm.Enabled = true;
                pbNotaTerm.BackColor = Color.White;
            }
            else
            {
                if (lblDepa.Text == "Laboratorio")
                {
                    gBAcotaciones.Enabled = true;
                    gBAcotaciones.BackColor = Color.White;
                    gBLaboratorio.Enabled = true;
                    gBLaboratorio.BackColor = Color.White;
                    gBReportes.Enabled = true;
                    gBReportes.BackColor = Color.White;
                    pbFormaPedido.Enabled = true;
                    pbFormaPedido.BackColor = Color.White;
                    pbNotaTerm.Enabled = true;
                    pbNotaTerm.BackColor = Color.White;
                }
                else
                {
                    if (lblDepa.Text == "Contabilidad")
                    {
                        gBReportes.Enabled = true;
                        gBReportes.BackColor = Color.White;
                        pbFormaPedido.Enabled = true;
                        pbNotaTerm.Enabled = true;
                    }
                    else
                    {
                        if (lblDepa.Text == "Recepción")
                        {
                            gBRecepcion.Enabled = true;
                            gBRecepcion.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        public void OrganizarPedidos()
        {
            int i = 0;
            for (i = 0; i < Est.Count; i++)
            {
                if (Est[i] == "FINALIZADO")
                { Urg[i] = "NO"; }
                if (Est[i] == "FACTURADO")
                { Urg[i] = "NO"; }
            }
            i = 0;
            for (i = 0; i < CodPed.Count; i++)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Urg[j] == "SI")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
            }
            i = 0;
            for (i = 0; i < Urg.Count; i++)
            {
                if (Urg[i] != "SI")
                {
                    break;
                }
            }

            while(i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "CONFIRMADO")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
            i = 0;
            while (i < Urg.Count)
            {
                if (Urg[i] != "SI")
                {
                    break;
                }
                i++;
            }
            while(i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO")
                { break; }
                i++;
            }

            while (i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "EN PROCESO")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
            i = 0;
            while(i < Urg.Count)
            {
                if (Urg[i] != "SI")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO")
                { break; }
                i++;
            }

            while(i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "POR CONFIRMAR")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
            i = 0;
            while (i < Urg.Count)
            {
                if (Urg[i] != "SI")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "POR CONFIRMAR")
                { break; }
                i++;
            }

            while(i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "SIN ELABORAR")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
            i = 0;
            while (i < Urg.Count)
            {
                if (Urg[i] != "SI")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "POR CONFIRMAR")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "SIN ELABORAR")
                { break; }
                i++;
            }

            while(i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "FINALIZADO")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
            i = 0;
            while (i < Urg.Count)
            {
                if (Urg[i] != "SI")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "POR CONFIRMAR")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "SIN ELABORAR")
                { break; }
                i++;
            }
            while(i < Urg.Count)
            {
                if (Est[i] != "FINALIZADO")
                { break; }
                i++;
            }

            while(i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "FACTURADO")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Dent[i];
                        Dent[i] = Dent[j];
                        Dent[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

                        temp = FechaLle[i];
                        FechaLle[i] = FechaLle[j];
                        FechaLle[j] = temp;

                        temp = FechaEnt[i];
                        FechaEnt[i] = FechaEnt[j];
                        FechaEnt[j] = temp;

                        temp = Labor[i];
                        Labor[i] = Labor[j];
                        Labor[j] = temp;

                        break;
                    }
                }
                i++;
            }
        }

        private void btnConfirmado_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                //if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR")
                //{
                //    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "CONFIRMADO" };
                //    intusuario.enviarEvento("CambiarEstado", Datos);
                //    dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
                //    dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "CONFIRMADO";
                //    dgvPedidos.ClearSelection();
                //    RecargarPantalla(sender, e);
                //}
            }
        }

        private void pbMateriales_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" };
            intusuario.enviarEvento("PantallaMateriales", Datos);
        }

        private void pbPiezas_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaPiezas", Datos);
        }

        private void pbFabricar_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            FabricarProducto fabp = new FabricarProducto(lblUsuario.Text, this);
            var datosPedidos = new DataTable();
            datosPedidos = mancp.ObtenerDatosPedido(Datos);
            foreach (DataRow fila in datosPedidos.Rows)
            {
                fabp.CodPed.Add(fila["IDPedido"].ToString());
                fabp.Est.Add(fila["Estatus"].ToString());
                fabp.FechaEnt.Add(fila["FechaCalculada"].ToString());
                fabp.Labor.Add(fila["Fabricante"].ToString());
                fabp.Urg.Add(fila["Urgencia"].ToString());
            }
            fabp.Show();
            this.Hide();

            RecargarPantalla(sender, e);
        }
       
        private void btnEnProceso_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                bool conpedido = false;
                for (int i = 0; i < Urg.Count; i++)
                {
                    if (Est[i] == "EN PROCESO          ")
                    {
                        if (v.reducirCadena(ReducirEspaciado(Labor[i])) == v.reducirCadena(lblUsuario.Text))
                        { conpedido = true; break; }
                        else { conpedido = false; }
                    }
                }
                if (!conpedido)
                {
                    if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE ")
                    {
                        if (v.reducirCadena(ReducirEspaciado(dgvPedidos[5, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString())) == lblUsuario.Text || lblUsuario.Text == "Admin" || dgvPedidos[5, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "")
                        {
                            dgvPedidos[5, dgvPedidos.SelectedCells[0].RowIndex].Value = lblUsuario.Text;
                            string[] Datos1 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), lblUsuario.Text };
                            intusuario.enviarEvento("CambiarLab", Datos1);

                            string[] Datos = { Datos1[0], "EN PROCESO " };
                            intusuario.enviarEvento("CambiarEstado", Datos);
                            dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                            dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "EN PROCESO ";
                            RecargarPantalla(sender, e);
                        }
                    }
                }
                else { MessageBox.Show("El laboratorista no puede tener más de un pedido en proceso"); }
                //dgvPedidos.ClearSelection();
            }
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO")
                {
                    if (dgvPedidos[5, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == lblUsuario.Text || lblUsuario.Text == "Admin")
                    {
                        dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Lime;
                        dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "FINALIZADO";

                        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "FINALIZADO" };
                        intusuario.enviarEvento("CambiarEstado", Datos);
                        dgvPedidos.ClearSelection();
                        RecargarPantalla(sender, e);
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

        private void btnPorConfirmar_Click(object sender, EventArgs e)
        {
            //if (dgvPedidos.SelectedCells[0].ColumnIndex == 2)
            //{

            //    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "Por Confirmar" };
            //    intusuario.enviarEvento("CambiarEstado", Datos);
            //    dgvPedidos.SelectedCells[0].Style.BackColor = Color.Silver;
            //    dgvPedidos.SelectedCells[0].Value = "Por Confirmar";
            //    dgvPedidos.ClearSelection();
            //}
        }

        private void btnUrgente_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR")
                {
                    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "SI" };
                    intusuario.enviarEvento("Urgente", Datos);
                    dgvPedidos[6, dgvPedidos.SelectedCells[0].RowIndex].Style.BackColor = Color.Red;
                    dgvPedidos.ClearSelection();
                }
            }
        }

        public void RecargarPantalla(object sender, EventArgs e)
        {
            Dent = new List<string>();
            CodPed = new List<string>();
            Est = new List<string>();
            FechaEnt = new List<string>();
            Labor = new List<string>();
            FechaLle = new List<string>();
            Urg = new List<string>();

            string[] Datos2 = new string[1];
            var datosPedidos2 = new DataTable();
            datosPedidos2 = mancp.ObtenerDatosPedido(Datos2);
            foreach (DataRow fila in datosPedidos2.Rows)
            {
                Dent.Add(ReducirEspaciado(fila["IDDentista"].ToString()));
                CodPed.Add(ReducirEspaciado(fila["IDPedido"].ToString()));
                Est.Add(ReducirEspaciado(fila["EstatusPedido"].ToString()));
                FechaLle.Add(ReducirEspaciado(fila["FechaIngreso"].ToString()));
                FechaEnt.Add(ReducirEspaciado(fila["FechaCalculada"].ToString()));
                Labor.Add(ReducirEspaciado(fila["Laboratorista"].ToString()));
                Urg.Add(ReducirEspaciado(fila["Urgencia"].ToString()));
            }
            this.ControlPedidos_Load(sender, e);
        }

        public void PintarEstado()
        {
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "POR CONFIRMAR")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
                if (Urg[i] == "SI")
                {
                    dgvPedidos[6, i].Style.BackColor = Color.Red;
                }
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "CONFIRMADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
                }
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "EN PROCESO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "FINALIZADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "FACTURADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dgvPedidos[2, i].Value.ToString().ToUpper() == "CANCELADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Brown;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(MenuGeneral))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuGeneral))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(Recepcion))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Recepcion))
                    {
                        frm.Show();
                    }
                }
            }
            else if(pantalla.GetType() == typeof(MenuLaboratorio))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuLaboratorio))
                    {
                        frm.Show();
                    }
                }
            }
            else if(pantalla.GetType()== typeof(FabricarProducto))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FabricarProducto))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(MenuPrincipal))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuPrincipal))
                    {
                        frm.Show();
                    }
                }
            }
            
        }

        public string ReducirEspaciado(string Cadena)
        {
            if (Cadena != null)
            {
                while (Cadena.Contains("  "))
                {
                    Cadena = Cadena.Replace("  ", "");
                }
                if (Cadena.Length > 0)
                {
                    if (Cadena[Cadena.Length - 1] == ' ')
                    {
                        Cadena = Cadena.Remove(Cadena.Length - 1, 1);
                    }
                }
            }
            return Cadena;
        }

        private void pbCancP_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CANCELADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CANCELADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CONFIRMADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CONFIRMADO ")
                {
                    DialogResult x = MessageBox.Show("¿Seguro que desea cancelar el pedido?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (x == DialogResult.Yes)
                    {
                        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "CANCELADO" };
                        intusuario.enviarEvento("CambiarEstado", Datos);
                        dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
                        dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "CANCELADO";
                        dgvPedidos.ClearSelection();
                    }
                    dgvPedidos.ClearSelection();
                    RecargarPantalla(sender, e);
                }
                else
                { MessageBox.Show("No se puede cancelar el pedido"); dgvPedidos.ClearSelection(); }
            }
        }

        private void pbVerP_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(),
                dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(),
            dgvPedidos[3,dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), dgvPedidos[4,dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(),
            dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() };
                intusuario.enviarEvento("Pedido", Datos);
                dgvPedidos.ClearSelection();
                RecargarPantalla(sender, e);
            }
        }

        private void pbCrearP_Click(object sender, EventArgs e)
        {
            intusuario.enviarEvento("NuevoPedido", new string[0]);
            RecargarPantalla(sender, e);
        }

        private void pbModP_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CANCELADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "CANCELADO ")
                {
                    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "", "", "", dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() };
                    intusuario.enviarEvento("ActualizarPedido", Datos);
                    dgvPedidos.ClearSelection();

                    RecargarPantalla(sender, e);
                }
                else
                { MessageBox.Show("No se puede modificar el pedido"); dgvPedidos.ClearSelection(); }
            }
        }

        private void pbFacturar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO ")
                {

                    VerFactura vfac = new VerFactura();

                    DataTable datosFactura = maf.BuscarFactura(new string[] { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "" });

                    if (datosFactura.Rows.Count == 0)
                    {
                        datosFactura = maf.ElaborarFactura(new string[] { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() });
                        foreach (DataRow fila in datosFactura.Rows)
                        {
                            vfac.Pedido = fila["IDPedido"].ToString();
                            vfac.Nombre = fila["Nombre"].ToString();
                            vfac.RFC = fila["RFC"].ToString();
                            vfac.Cedula = fila["Cedula"].ToString();
                            vfac.Direccion = fila["Direccion"].ToString();
                            vfac.Pais = fila["Pais"].ToString();
                            vfac.Estado = fila["Estado"].ToString();
                            vfac.Municipio = fila["Municipio"].ToString();
                            vfac.Ciudad = fila["Ciudad"].ToString();
                            vfac.Colonia = fila["Colonia"].ToString();
                            vfac.CodigoPostal = fila["CodigoPostal"].ToString();
                            vfac.Telefono = fila["Telefono"].ToString();

                        }
                    }
                    else
                    {
                        foreach (DataRow fila in datosFactura.Rows)
                        {
                            vfac.Pedido = fila["Pedido"].ToString();
                            vfac.Nombre = fila["Nombre"].ToString();
                            vfac.RFC = fila["RFC"].ToString();
                            vfac.Cedula = fila["Cedula"].ToString();
                            vfac.Direccion = fila["Direccion"].ToString();
                            vfac.Pais = fila["Pais"].ToString();
                            vfac.Estado = fila["Estado"].ToString();
                            vfac.Municipio = fila["Municipio"].ToString();
                            vfac.Ciudad = fila["Ciudad"].ToString();
                            vfac.Colonia = fila["Colonia"].ToString();
                            vfac.CodigoPostal = fila["CodigoPostal"].ToString();
                            vfac.Telefono = fila["Telefono"].ToString();
                            vfac.Fecha = fila["FechaEmision"].ToString();
                        }
                    }

                    vfac.ShowDialog();
                    RecargarPantalla(sender, e);

                    //string[] Datos2 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() };
                    //intusuario.enviarEvento("ProductosAFacturar", Datos2);

                    //string[] Datos3 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "FACTURADO" };
                    //intusuario.enviarEvento("CambiarEstado", Datos3);
                    //dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    //dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "FACTURADO";
                    //dgvPedidos.ClearSelection();
                }
                else
                {
                    if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FACTURADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FACTURADO ")
                    {
                        VistaPrevia objForm = new VistaPrevia();

                        objForm.Pedido = dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString();

                        objForm.ShowDialog();
                        RecargarPantalla(sender, e);

                    }
                }
            }
        }

        private void pbFormaPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                //if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR")
                //{
                //    if (lblDepa.Text == "Laboratorio " || lblDepa.Text == "Administrador" || lblDepa.Text == "Contabilidad")
                //    {
                VistaPreviaForma objForm = new VistaPreviaForma();

                string idPed = dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString();

                objForm.Pedido = idPed;

                objForm.ShowDialog();

                dgvPedidos.ClearSelection();
                //}
                //}
            }
        }

        private void pbOficioConf_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO")
                {
                    VistaPreviaOficio objForm = new VistaPreviaOficio();

                    string idPed = dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString();

                    objForm.Pedido = idPed;

                    objForm.ShowDialog();
                    //string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "CONFIRMADO" };
                    //intusuario.enviarEvento("CambiarEstado", Datos);
                    //dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
                    //dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "CONFIRMADO";
                    dgvPedidos.ClearSelection();
                }


                RecargarPantalla(sender, e);

            }
        }

        private void pbNotaTerm_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO" || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FACTURADO " || dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FACTURADO")
                {
                    if (lblDepa.Text == "Laboratorio " || lblDepa.Text == "Administrador")
                    {
                        string[] Datos = { dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString() };
                        intusuario.enviarEvento("Elaborar nota", Datos);

                        //string[] Datos1 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "FINALIZADO" };
                        //intusuario.enviarEvento("CambiarEstado", Datos1);
                        //dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Lime;
                        //dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value = "FINALIZADO";
                        //dgvPedidos.ClearSelection();
                        //RecargarPantalla(sender, e);
                    }
                    else
                    {
                        VistaPreviaNota objForm = new VistaPreviaNota();

                        string idPed = dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString();

                        objForm.Folio = idPed;

                        objForm.ShowDialog();
                    }

                }
            }
        }

        private void cbLaboratorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "EN PROCESO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO" && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FINALIZADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO " && dgvPedidos[2, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() != "FACTURADO")
                {
                    if (dgvPedidos.SelectedCells.Count > 0)
                    {
                        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), cbLaboratorista.SelectedItem.ToString() };
                        intusuario.enviarEvento("CambiarLab", Datos);
                    }
                    dgvPedidos[5, dgvPedidos.SelectedCells[0].RowIndex].Value = cbLaboratorista.SelectedItem.ToString();
                    dgvPedidos.ClearSelection();
                    cbLaboratorista.Text = "";
                }
            }
        }

        private void llRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvPedidos.ClearSelection();
            Registro_Usuario regu = new Registro_Usuario();
            regu.labo = true;
            intusuario.cerrarPantalla(this);
            intusuario.desplegarPantalla(regu);
        }

        private void cbLaboratorista_Click(object sender, EventArgs e)
        {
            cbLaboratorista.Items.Clear();
            var Laboratoristas = new DataTable();
            string[] Datos = { "Laboratorio" };
            Laboratoristas = manu.Laboratoristas(Datos);
            foreach (DataRow fila in Laboratoristas.Rows)
            {
                cbLaboratorista.Items.Add(ReducirEspaciado(fila["Loginn"].ToString()));
            }
        }

        private void dgvPedidos_Enter(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoPedido_TextChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtCodigoPedido.Text };
            if (txtCodigoPedido.Text == "")
            { RecargarPantalla(sender, e); }
            else
            {
                var datosPedido = new DataTable();
                datosPedido = mancp.ObtenerPedido(Datos);
                if (datosPedido.Rows.Count > 0)
                {
                    Dent = new List<string>();
                    CodPed = new List<string>();
                    Est = new List<string>();
                    FechaEnt = new List<string>();
                    Labor = new List<string>();
                    FechaLle = new List<string>();
                    Urg = new List<string>();

                    foreach (DataRow fila in datosPedido.Rows)
                    {
                        Dent.Add(ReducirEspaciado(fila["IDDentista"].ToString()));
                        CodPed.Add(ReducirEspaciado(fila["IDPedido"].ToString()));
                        Est.Add(ReducirEspaciado(fila["Estatus"].ToString()));
                        FechaLle.Add(ReducirEspaciado(fila["FechaIngreso"].ToString()));
                        FechaEnt.Add(ReducirEspaciado(fila["FechaCalculada"].ToString()));
                        Labor.Add(ReducirEspaciado(fila["Fabricante"].ToString()));
                        Urg.Add(ReducirEspaciado(fila["Urgencia"].ToString()));
                    }
                    this.ControlPedidos_Load(sender, e);
                }
            }
            dgvPedidos.ClearSelection();
        }

        private void dgvPedidos_CurrentCellChanged(object sender, EventArgs e)
        {
            pbFormaPedido.Visible = pbOficioConf.Visible = pbNotaTerm.Visible = pbFacturar.Visible = false;
            if (dgvPedidos.CurrentCell != null)
            {
                DataGridViewCell t = dgvPedidos[2, dgvPedidos.CurrentCell.RowIndex];
                if (t.Value != null)
                {
                    string Estado = t.Value.ToString();
                    if (lblDepa.Text == "Laboratorio ")
                    {
                        if (Estado.ToUpper() == "Finalizado".ToUpper())
                        {
                            //  pBNota.Visible = pBFactura.Visible = true;
                            pbNotaTerm.Visible = pbFormaPedido.Visible = true;
                        }
                        else
                        {
                            if (Estado.ToUpper() == "Confirmado".ToUpper())
                            {
                                pbFormaPedido.Visible = true;
                            }
                            else
                            {
                                if (Estado.ToUpper() == "POR CONFIRMAR ".ToUpper() || Estado.ToUpper() == "POR CONFIRMAR".ToUpper())
                                {
                                    pbFormaPedido.Visible = true;
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
                                            pbFormaPedido.Visible = true;
                                        }

                                    }
                                }

                            }
                        }

                    }
                    else
                    {
                        if (lblDepa.Text == "Contabilidad")
                        {
                            if (Estado.ToUpper() == "Finalizado".ToUpper())
                            {
                                //  pBNota.Visible = pBFactura.Visible = true;
                                pbNotaTerm.Visible = pbFormaPedido.Visible = pbFacturar.Visible = pbOficioConf.Visible = true;
                            }
                            else
                            {
                                if (Estado.ToUpper() == "Confirmado".ToUpper())
                                {
                                    pbFormaPedido.Visible = pbOficioConf.Visible = true;
                                }
                                else
                                {
                                    if (Estado.ToUpper() == "POR CONFIRMAR ".ToUpper() || Estado.ToUpper() == "POR CONFIRMAR".ToUpper())
                                    {
                                        pbFormaPedido.Visible = true;
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
                                                pbFormaPedido.Visible = pbOficioConf.Visible = true;
                                            }
                                            else
                                            {
                                                if (Estado.ToUpper() == "Facturado ".ToUpper())
                                                {
                                                    pbFacturar.Visible = true;
                                                }
                                            }
                                        }

                                    }
                                }

                            }
                        }
                        else
                        {
                            if (lblDepa.Text == "Administrador")
                            {
                                if (Estado.ToUpper() == "Finalizado".ToUpper())
                                {
                                    //  pBNota.Visible = pBFactura.Visible = true;
                                    pbNotaTerm.Visible = pbFormaPedido.Visible = pbFacturar.Visible = pbOficioConf.Visible = true;
                                }
                                else
                                {
                                    if (Estado.ToUpper() == "Confirmado".ToUpper())
                                    {
                                        pbFormaPedido.Visible = pbOficioConf.Visible = true;
                                    }
                                    else
                                    {
                                        if (Estado.ToUpper() == "POR CONFIRMAR ".ToUpper() || Estado.ToUpper() == "POR CONFIRMAR".ToUpper())
                                        {
                                            pbFormaPedido.Visible = true;
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
                                                    pbFormaPedido.Visible = pbOficioConf.Visible = true;
                                                }
                                                else
                                                {
                                                    if (Estado.ToUpper() == "Facturado ".ToUpper())
                                                    {
                                                        pbFacturar.Visible = true;
                                                    }
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                }

            }
        }

        private void ControlPedidos_Activated(object sender, EventArgs e)
        {
            RecargarPantalla(sender, e);
        }

        public void DatosTabla(DataTable datosPedidos)
        {
            foreach (DataRow fila in datosPedidos.Rows)
            {
                Dent.Add(ReducirEspaciado(fila["IDDentista"].ToString()));
                CodPed.Add(ReducirEspaciado(fila["IDPedido"].ToString()));
                Est.Add(ReducirEspaciado(fila["EstatusPedido"].ToString()));
                FechaLle.Add(ReducirEspaciado(fila["FechaIngreso"].ToString()));
                FechaEnt.Add(ReducirEspaciado(fila["FechaCalculada"].ToString()));
                Labor.Add(ReducirEspaciado(fila["Laboratorista"].ToString()));
                Urg.Add(ReducirEspaciado(fila["Urgencia"].ToString()));
            }
        }
    }
}
