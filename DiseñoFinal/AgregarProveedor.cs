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
    public partial class AgregarProveedor : Form
    {
        Validación v = new Validación();
        ManejadorPrincipal manp = new ManejadorPrincipal();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        InterfaceUsuario intusuario;
        Form pantalla;

        public AgregarProveedor(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Datos = { txtClave.Text, txtNombre.Text, mkTelefono.Text, txtEmail.Text, cBDominio.SelectedItem.ToString(), txtOtroDominio.Text, txtDesc.Text, txtRFC.Text, txtNombreCont.Text, "ACT" };
           if(manp.AgregarProveedor(Datos) > 0) { MessageBox.Show("Proveedor Registrado"); }
        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            string[] Datos = { "" };
            var datosProv = new DataTable();
            datosProv = mancp.ObtenerProveedores(Datos);
            foreach (DataRow fila in datosProv.Rows)
            {
                lblClave.Text = (fila["ClaveProveedor"].ToString());
            }
            lblClave.Text += " Ultimo Proveedor Registrado";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Almacen))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Almacen))
                    {
                        frm.Show();
                    }
                }
            }
        }
    }
}
