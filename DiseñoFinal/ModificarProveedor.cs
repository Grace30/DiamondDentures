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
    public partial class ModificarProveedor : Form
    {
        Validación v = new Validación();
        ManejadorPrincipal manp = new ManejadorPrincipal();
        ManejadorControlPedido mancp = new ManejadorControlPedido();
        InterfaceUsuario intusuario;
        Form pantalla;
        public ModificarProveedor(Form pantalla, string Clave)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            lblClave.Text = Clave;
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        public void DatosData(DataTable Datos)
        {
            string Email = "", EmailPartes = "";
            foreach (DataRow fila in Datos.Rows)
            {
                txtNombre.Text = ReducirEspaciado(fila["Nombre"].ToString());
                txtDesc.Text = ReducirEspaciado(fila["Descripcion"].ToString());
                mkTelefono.Text = ReducirEspaciado(fila["Telefono"].ToString());
                Email = fila["Correo"].ToString();
                txtRFC.Text = ReducirEspaciado(fila["RFC"].ToString());
                txtNombreCont.Text = ReducirEspaciado(fila["Contacto"].ToString());
            }

            int i = 0;
            while (Email[i] != '@')
            {
                EmailPartes += Email[i];
                i++;
            }
            txtEmail.Text = EmailPartes;
            EmailPartes = "";
            i++;
            while (Email[i].ToString() != " ")
            {
                EmailPartes += Email[i];
                i++;
            }
            i = 0;
            bool EnDominio = false;
            while (i < cBDominio.Items.Count)
            {
                if (EmailPartes == cBDominio.Items[i].ToString())
                {
                    cBDominio.SelectedIndex = i;
                    EnDominio = true;
                    break;
                }
                i++;
            }
            if (EnDominio == false)
                txtOtroDominio.Text = EmailPartes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Datos = { lblClave.Text, txtNombre.Text, mkTelefono.Text, txtEmail.Text, cBDominio.SelectedItem.ToString(), txtOtroDominio.Text, txtDesc.Text, txtRFC.Text, txtNombreCont.Text, "ACT" };
            if (manp.ActualizarProveedor(Datos) > 0) { MessageBox.Show("Proveedor Actualizado"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType() == typeof(Proveedores))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Proveedores))
                    {
                        frm.Show();
                    }
                }
            }
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
                    Cadena.Remove(Cadena.Length - 1, 1);
                }
            }

            return Cadena;
        }
    }
}
