﻿using System;
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
    public partial class Nota : Form
    {
        ManejadorFacturas maf = new ManejadorFacturas();
        ManejadorReportes mar = new ManejadorReportes();
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
        Validación v;
        public string Codigo, NombreProducto, Material, Cantidad, Precio, SubTotal, Fecha;
        public string NoPedido, RFC, Nombre,Apellidos, Direccion, Telefono, Comentario;
        public Nota()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
            v = new Validación();
            //  lblNoPedido.Text = Pedido = NoPedido;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nota_Load(object sender, EventArgs e)
        {
            lblNoPedido.Text = ReducirEspaciado(NoPedido);
            lblFecha.Text = ReducirEspaciado(Fecha);
            lblNombre.Text = ReducirEspaciado(Nombre);
            lblApellidos.Text = ReducirEspaciado(Apellidos);
            lblRFC.Text = ReducirEspaciado(RFC);
            lblDireccion.Text = ReducirEspaciado(Direccion);
            lblTel.Text = ReducirEspaciado(Telefono);
            txtObservaciones.Text = ReducirEspaciado(Comentario);
            RellenarTODO();

        }
        public void RellenarTODO()
        {
            string[] Datos = { lblNoPedido.Text };
            var datosProductos = new DataTable();
            datosProductos = mar.ObtenerProductosPedido(Datos);
            dgvProducto.ColumnCount = datosProductos.Columns.Count;
            dgvProducto.RowCount = datosProductos.Rows.Count;
            int renglon = 0;
            foreach (DataRow fila in datosProductos.Rows)
            {
                dgvProducto["Cod", renglon].Value = fila[ReducirEspaciado("CodigoEspecial")].ToString();
                dgvProducto["Cant", renglon].Value = fila[ReducirEspaciado("Producto y Materiales")].ToString();
                dgvProducto["Producto", renglon].Value = fila[ReducirEspaciado("Precio Unitario")].ToString();
                dgvProducto["Mat", renglon].Value = fila[ReducirEspaciado("Cantidad")].ToString();
                dgvProducto["Prec", renglon].Value = fila[ReducirEspaciado("SubTotal")].ToString();
          //      dgvProducto["Imp", renglon].Value = fila[ReducirEspaciado("SubTotal")].ToString();
                renglon++;
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
            }
            return Cadena;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void pBActualizar_Click(object sender, EventArgs e)
        {
            string x = lblFecha.Text;
         DateTime dt=  Convert.ToDateTime(x);
            string[] Datos1 = { lblNoPedido.Text, UsuarioEnCurso
                    , v.FormatoFecha(DateTime.Now),v.FormatoFecha(DateTime.Now), txtObservaciones.Text,
                v.FormatoFecha(dt)
            };
            intusuario.enviarEvento("Registrar Datos Nota", Datos1);

            VistaPreviaNota objForm = new VistaPreviaNota();
            string idPed = lblNoPedido.Text;
            objForm.Pedido = idPed;
            objForm.ShowDialog();


            //string[] Datos = {lblNoPedido.Text, txtObservaciones.Text};
            //intusuario.enviarEvento("Registrar Comentario", Datos);
            //VistaPreviaNota objForm = new VistaPreviaNota();

            //string idPed = lblNoPedido.Text;

            //objForm.Folio = idPed;

            //objForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            //foreach (Form frm in Application.OpenForms)
            //{
            //    if (frm.GetType() == typeof(Reportes))
            //    {
            //        frm.Show();
            //    }
            //}

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
    }
}
