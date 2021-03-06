﻿using System;
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
    public partial class Almacen : Form
    {
        Validación v = new Validación();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        ManejadorRegistroUsuario maru = new ManejadorRegistroUsuario();
        InterfaceUsuario intusuario;
        Form pantalla;

        public Almacen(Form pantalla, string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblUsuario.Text = Usuario;
        }

        public void DatosData(DataTable DatosAlmacen)
        {
            dgvAlmacen.DataSource = DatosAlmacen;
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            if (lblUsuario.Text == "Admin")
            { lblDep.Text = "Administrador"; }
            else
            {
                string Dep = "";
                var Departamento = new DataTable();
                string[] Datos = { ReducirEspaciado(lblUsuario.Text)};
                Departamento = maru.Departamento(Datos);
                foreach (DataRow fila in Departamento.Rows)
                { Dep = fila["Departamento"].ToString(); }
                lblDep.Text = ReducirEspaciado(Dep);
            }
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string[] Datos = { txtNombre.Text };
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosInsumos(Datos);
                DatosData(datosAlm);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string[] Datos = { txtNombre.Text };
                var datosAlm = new DataTable();
                datosAlm = mancp.ObtenerDatosMateriales(Datos);
                DatosData(datosAlm);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] Datos = { "",lblUsuario.Text };
            intusuario.enviarEvento("PantallaProveedores", Datos);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string[] Datos = { txtNombre.Text };
            var datosAlm = new DataTable();
            if (radioButton1.Checked)
            { datosAlm = mancp.ObtenerDatosMateriales(Datos); }
            else
            { datosAlm = mancp.ObtenerDatosInsumos(Datos); }
            DatosData(datosAlm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" , lblUsuario.Text};
            intusuario.enviarEvento("PantallaCompraProveedores", Datos);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Datos = { "",lblUsuario.Text };
            intusuario.enviarEvento("PantallaRequisicionMateriales", Datos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text };
            intusuario.enviarEvento("PantallaCatalogoProductos", Datos);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            if (pantalla.GetType() == typeof(MenuLaboratorio))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuLaboratorio))
                    {
                        frm.Show();
                    }
                }
            }
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
            if (pantalla.GetType() == typeof(Login))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Login))
                    {
                        frm.Show();
                    }
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] Datos = { "" };
            intusuario.enviarEvento("PantallaEntradaSalida", Datos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text, 1.ToString() };
            intusuario.enviarEvento("PantallaRequisiciones", Datos);
        }
        public static string ReducirEspaciado(string Cadena)
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
            return Cadena;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text };
            intusuario.enviarEvento("PantallaInventario", Datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text };
            intusuario.enviarEvento("PantallaSurtidoMat", Datos);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var datosMat = new DataTable();
            string[] Datos = { "" };
            datosMat = mancp.ObtenerFaltantes(Datos);

            var datosRequi = new DataTable();
            datosRequi = mancp.RequisicionesAcep(Datos);

            int req = datosRequi.Rows.Count;
            int mat = datosMat.Rows.Count;
            switch (req)
            {
                case 0:
                    pbReq.BackgroundImage = Properties.Resources.el0;
                    break;
                case 1:
                    pbReq.BackgroundImage = Properties.Resources.el1;
                    break;
                case 2:
                    pbReq.BackgroundImage = Properties.Resources.el2;
                    break;
                case 3:
                    pbReq.BackgroundImage = Properties.Resources.el3;
                    break;
                default:
                    if (req > 3)
                        pbReq.BackgroundImage = Properties.Resources.elmas3;
                    break;
            }
            switch (mat)
            {
                case 0:
                    pbMat.BackgroundImage = Properties.Resources.el0;
                    break;
                case 1:
                    pbMat.BackgroundImage = Properties.Resources.el1;
                    break;
                case 2:
                    pbMat.BackgroundImage = Properties.Resources.el2;
                    break;
                case 3:
                    pbMat.BackgroundImage = Properties.Resources.el3;
                    break;
                default:
                    if (mat > 3)
                        pbMat.BackgroundImage = Properties.Resources.elmas3;
                    break;
            }
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] Datos = { "", lblUsuario.Text, 0.ToString() };
            intusuario.enviarEvento("PantallaRequisiciones", Datos);
        }
    }
}
