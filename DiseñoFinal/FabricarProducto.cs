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
    public partial class FabricarProducto : Form
    {
        Validación v = new Validación();
        InterfaceUsuario intusuario;
        ManejadorRegistroUsuario manu = new ManejadorRegistroUsuario();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        public List<string> CodPed = new List<string>();
        public List<string> Est = new List<string>();
        public List<string> FechaEnt = new List<string>();
        public List<string> Labor = new List<string>();
        public List<string> Urg = new List<string>();
        string usuarioencurso = "";
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
            //if (dgvPedidos.SelectedCells[0].ColumnIndex == 2)
            //{
            //    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "Urgente" };
            //    intusuario.enviarEvento("CambiarEstado", Datos);
            //    dgvPedidos.SelectedCells[0].Style.BackColor = Color.Red;
            //    dgvPedidos.SelectedCells[0].Value = "Urgente";
            //    dgvPedidos.ClearSelection();
            //}
        }

        private void btnConfirmado_Click(object sender, EventArgs e)
        {
            //if (dgvPedidos.CurrentCell.Selected == true)
            //{
            //    if (dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR" || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "POR CONFIRMAR ")
            //    {
            //        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "CONFIRMADO" };
            //        intusuario.enviarEvento("CambiarEstado", Datos);
            //        dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Cyan;
            //        dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value = "CONFIRMADO";
            //        dgvPedidos.ClearSelection();
            //    }
            //}
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
                        if (v.reducirCadena(ReducirEspaciado(Labor[i])) == lblUsuario.Text)
                        {
                            conpedido = true; break;
                        }
                        else { conpedido = false; }
                    }
                }
                if (!conpedido)
                {
                    if (dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE " || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE")
                    {
                        if (dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == lblUsuario.Text || lblUsuario.Text == "Admin" || dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "")
                        {
                            dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value = lblUsuario.Text;
                            string[] Datos1 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), lblUsuario.Text };
                            intusuario.enviarEvento("CambiarLab", Datos1);

                            string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "EN PROCESO" };
                            intusuario.enviarEvento("CambiarEstado", Datos);
                            dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                            dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value = "EN PROCESO";
                        }
                    }
                }
            }
            dgvPedidos.ClearSelection();
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO" || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "EN PROCESO ")
                {
                    if (dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value == lblUsuario.Text || lblUsuario.Text == "Admin")
                    {
                        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "FINALIZADO" };
                        intusuario.enviarEvento("CambiarEstado", Datos);
                        dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Lime;
                        dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value = "FINALIZADO";
                        dgvPedidos.ClearSelection();
                    }
                }
            }
        }
        Form pantalla;
        public FabricarProducto(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.usuarioencurso = Usuario;
        }

        public FabricarProducto(string Usuario, Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.usuarioencurso = Usuario;
            this.pantalla = pantalla;
        }

        private void FabricarProducto_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioencurso;
            if (CodPed.Count > 0)
            {
                OrganizarPedidos();
                dgvPedidos.RowCount = CodPed.Count;
                for (int i = 0; i < CodPed.Count; i++)
                {
                    dgvPedidos[0, i].Value = ReducirEspaciado(CodPed[i]);
                    dgvPedidos[1, i].Value = ReducirEspaciado(Est[i]);
                    dgvPedidos[2, i].Value = ReducirEspaciado(FechaEnt[i]);
                    dgvPedidos[3, i].Value = ReducirEspaciado(Labor[i]);
                }
                PintarEstado();
                dgvPedidos.ClearSelection();
            }
            if (lblUsuario.Text == "Admin")
            {
                cbLaboratorista.Enabled = true;
                llRegistrar.Enabled = true;
                
            }
        }

        public void OrganizarPedidos()
        {
            int i = 0;
            for (i = 0; i < Est.Count; i++)
            {
                if (Est[i] == "FINALIZADO")
                { Urg[i] = "NO"; }
                if (Est[i] == "FACTURAD")
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

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

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

            while (i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "CONFIRMADO")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

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
            while (i < Urg.Count)
            {
                if (Est[i] != "CONFIRMADO          ")
                { break; }
                i++;
            }

            while (i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "EN PROCESO          ")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

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

            while (i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "POR CONFIRMAR       ")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;


                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;


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
                if (Est[i] != "CONFIRMADO          ")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO          ")
                { break; }
                i++;
            }
            while (i < Urg.Count)
            {
                if (Est[i] != "POR CONFIRMAR       ")
                { break; }
                i++;
            }

            while (i < CodPed.Count)
            {
                for (int j = i; j < CodPed.Count; j++)
                {
                    if (Est[j] == "SIN ELABORAR        ")
                    {
                        string temp = CodPed[i];
                        CodPed[i] = CodPed[j];
                        CodPed[j] = temp;

                        temp = Urg[i];
                        Urg[i] = Urg[j];
                        Urg[j] = temp;


                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;


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

            while (i < CodPed.Count)
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
                        

                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;
                        

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
            while(i < Urg.Count)
            {
                if (Est[i] != "EN PROCESO")
                { break; }
                i++;
            }
            while(i < Urg.Count)
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
            while (i < Urg.Count)
            {
                if (Est[i] != "FINALIZADO")
                { break; }
                i++;
            }

            while (i < CodPed.Count)
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
                        
                        temp = Est[i];
                        Est[i] = Est[j];
                        Est[j] = temp;

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

        public void PintarEstado()
        {
            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {
                if (dgvPedidos[1, i].Value.ToString() == "POR CONFIRMAR")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
                if (Urg[i] == "SI")
                {
                    dgvPedidos[4, i].Style.BackColor = Color.Red;
                }
                if (dgvPedidos[1, i].Value.ToString() == "CONFIRMADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
                }
                if (dgvPedidos[1, i].Value.ToString() == "EN PROCESO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                if (dgvPedidos[1, i].Value.ToString() == "FINALIZADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
                if (dgvPedidos[1, i].Value.ToString() == "FACTURADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (dgvPedidos[1, i].Value.ToString() == "CANCELADO")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.Brown;
                }
            }
        }
 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(ControlPedidos))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ControlPedidos))
                    {
                        frm.Show();
                    }
                }
            }
            else if (pantalla.GetType() == typeof(MenuLaboratorio))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuLaboratorio))
                    {
                        frm.Show();
                    }
                }
            }
        }

        private void pbFabricar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO" || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "CONFIRMADO " || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE " || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "URGENTE")
                {
                    if (dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value == lblUsuario.Text || lblUsuario.Text == "Admin")
                    {
                        string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "EN PROCESO" };
                        intusuario.enviarEvento("CambiarEstado", Datos);
                        dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                        dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value = "EN PROCESO";
                        dgvPedidos.ClearSelection();
                    }
                }
            }
        }



        public static string ReducirEspaciado(string Cadena)
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

        private void dgvPedidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.SelectedCells.Count > 0)
            {
                string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() };
                intusuario.enviarEvento("CambiarLab", Datos);
            }
            dgvPedidos.ClearSelection();
        }

        private void pBSalir2_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pbNotaTerm_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO" || dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString() == "FINALIZADO ")
                {

                   
                        string[] Datos = { dgvPedidos[0, dgvPedidos.CurrentCell.RowIndex].Value.ToString() };
                        intusuario.enviarEvento("Elaborar nota", Datos);

                    string[] Datos1 = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), "FINALIZADO" };
                    intusuario.enviarEvento("CambiarEstado", Datos1);
                    dgvPedidos.Rows[dgvPedidos.SelectedCells[0].RowIndex].DefaultCellStyle.BackColor = Color.Lime;
                    dgvPedidos[1, dgvPedidos.SelectedCells[0].RowIndex].Value = "FINALIZADO";
                    dgvPedidos.ClearSelection();
                    RecargarPantalla(sender, e);
                }
            }
        }

        private void btnFacturado_Click(object sender, EventArgs e)
        {

        }

        private void btnSinElaborar_Click(object sender, EventArgs e)
        {

        }

        private void cbLaboratorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentCell.Selected == true)
            {
                if (dgvPedidos.SelectedCells.Count > 0)
                {
                    string[] Datos = { dgvPedidos[0, dgvPedidos.SelectedCells[0].RowIndex].Value.ToString(), cbLaboratorista.SelectedItem.ToString() };
                    intusuario.enviarEvento("CambiarLab", Datos);
                }
                dgvPedidos[3, dgvPedidos.SelectedCells[0].RowIndex].Value = cbLaboratorista.SelectedItem.ToString();
                dgvPedidos.ClearSelection();
                cbLaboratorista.Text = "";
            }
        }

        private void llRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvPedidos.ClearSelection();
            Registro_Usuario regu = new Registro_Usuario();
            regu.labo = true;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void RecargarPantalla(object sender, EventArgs e)
        {
            CodPed = new List<string>();
            Est = new List<string>();
            FechaEnt = new List<string>();
            Labor = new List<string>();
            Urg = new List<string>();

            string[] Datos2 = new string[1];
            var datosPedidos2 = new DataTable();
            datosPedidos2 = mancp.ObtenerDatosPedido(Datos2);
            foreach (DataRow fila in datosPedidos2.Rows)
            {
                CodPed.Add(ReducirEspaciado(fila["IDPedido"].ToString()));
                Est.Add(ReducirEspaciado(fila["Estatus"].ToString()));
                FechaEnt.Add(ReducirEspaciado(fila["FechaCalculada"].ToString()));
                Labor.Add(ReducirEspaciado(fila["Fabricante"].ToString()));
                Urg.Add(ReducirEspaciado(fila["Urgencia"].ToString()));
            }
            this.FabricarProducto_Load(sender, e);
        }

        public void DatosTabla(DataTable datosPedidos)
        {
            foreach (DataRow fila in datosPedidos.Rows)
            {
                CodPed.Add(ReducirEspaciado(fila["IDPedido"].ToString()));
                Est.Add(ReducirEspaciado(fila["EstatusPedido"].ToString()));
                FechaEnt.Add(ReducirEspaciado(fila["FechaCalculada"].ToString()));
                Labor.Add(ReducirEspaciado(fila["Laboratorista"].ToString()));
                Urg.Add(ReducirEspaciado(fila["Urgencia"].ToString()));
            }
        }
    }
}
