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
    public partial class Registro_Usuario : Form
    {
        ManejadorPrincipal manp = new ManejadorPrincipal();
        InterfaceUsuario intusuario;
        Validación v;
        bool guardado = false;
        bool admin = false;
        public bool labo = false;
        public Registro_Usuario()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            admin = false;
        }

        public Registro_Usuario(string x)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            admin = true;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void pBSalir_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            if (!guardado)
                x = MessageBox.Show("Aun no se ha guardado el registro, ¿seguro que quieres cerrar?",
                    "No guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
            {
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (labo)
                    {
                        if (frm.GetType() == typeof(ControlPedidos))
                        {
                            frm.Show();
                            break;
                        }
                    }
                    else
                    {
                        if (!admin)
                        {
                            if (frm.GetType() == typeof(Login))
                            {
                                frm.Show();
                            }
                        }
                        else
                        {
                            if (frm.GetType() == typeof(Menú_Admin))
                            {
                                frm.Show();
                            }
                        }
                    }
                }
            }
            if (x == DialogResult.Yes)
            {
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (labo)
                    {
                        if (frm.GetType() == typeof(ControlPedidos))
                        {
                            frm.Show();
                            break;
                        }
                    }
                    else
                    {
                        if (!admin)
                        {
                            if (frm.GetType() == typeof(Login))
                            {
                                frm.Show();
                            }
                        }
                        else
                        {
                            if (frm.GetType() == typeof(Menú_Admin))
                            {
                                frm.Show();
                            }

                        }
                    }
                }
            }
            else { }
        }

        private void pBGuardar_Click(object sender, EventArgs e)
        {
            //AQUÍ DEBEN IR TODAS LAS VALIDACIONES
            if (txtLogin.Text != "Login" && txtPassword.Text != "Password")
            {
                if (cBDominio.SelectedIndex != 0)
                {
                    txtOtroDominio.Text = "";
                }
                if (v.ValidaCampos(txtNombre, txtApellidos, maskedTCasa,
                    txtEmail, txtLogin, txtPassword, cBPreguntaSeguridad,
                    txtRespuesta, cBPais, txtDireccion, txtColonia,
                    maskedTMovil, cBEstado, cBMunicipio, cBCiudad, txtConfirmar, maskedCodigo)
                    && v.VerificaDigitos(maskedTOficina) && v.Password(txtPassword.Text, txtConfirmar.Text) && v.CodigoPostal(cBPais.Text, maskedCodigo))
                {
                    if (cBPais.Text == "-Elija un País-")
                        cBPais.SelectedIndex = 0;
                    if (txtDireccion.Text == "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.")
                        txtDireccion.Text = "";
                    string[] Datos = { txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtColonia.Text, cBPais.Text.ToString(), cBEstado.Text.ToString(), cBMunicipio.Text.ToString(), cBCiudad.Text.ToString(), maskedCodigo.Text, maskedTCasa.Text, maskedTOficina.Text, maskedTMovil.Text, txtEmail.Text, cBDominio.SelectedItem.ToString(), txtOtroDominio.Text, txtLogin.Text, txtPassword.Text, cBPreguntaSeguridad.SelectedItem.ToString(), txtRespuesta.Text, cbDepartamento.SelectedItem.ToString() };
                    intusuario.enviarEvento("Registrar", Datos);
                    guardado = true;
                }
            }
            else
                MessageBox.Show("No es posible elegir ese Login",
                "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
 
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void maskedCodigo_Enter(object sender, EventArgs e)
        {
            maskedCodigo.Clear();
        }

        private void maskedTCasa_Enter(object sender, EventArgs e)
        {
            maskedTCasa.Clear();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
        }

        private void pBMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            v.Limpiartxt(txtDireccion, "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.");
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            v.Llenartxt(txtDireccion, "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.");
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            v.Limpiartxt(txtEmail, "ejemplo");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            v.Llenartxt(txtEmail, "ejemplo");
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {           
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void maskedCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBPais.Text != "Canadá")
                v.SoloNumeros(e);
            else
                v.NumerosLetras(e);
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            cBPais.Items.Clear();
            cBPais.Items.Add(" ");
            cBEstado.SelectedIndex = 0;
            cBMunicipio.SelectedIndex = 0;
            cBCiudad.SelectedIndex = 0;
            cBPais.SelectedIndex = 0;
            var Paises = new DataTable();
            Paises = manp.Paises();
            foreach (DataRow fila in Paises.Rows)
            {
                cBPais.Items.Add(fila["NombrePais"].ToString());
            }
            if (labo)
            {
                cbDepartamento.Enabled = false;
                cbDepartamento.SelectedIndex = 2;
            }
        }

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedCodigo.ReadOnly= false;
            if (cBPais.SelectedItem.ToString() != "Canadá")
            { maskedCodigo.Mask = "00000"; }
            if (cBPais.SelectedItem.ToString() == "Canadá")
            { maskedCodigo.Mask = "A0A0A0"; }
            if (cBPais.SelectedIndex == 149)
            {                   
                cBEstado.Enabled = true;
                cBMunicipio.Enabled = true;
                cBCiudad.Enabled = true;
                cBEstado.Items.Clear();
                cBEstado.Items.Add(" ");
                cBEstado.SelectedIndex = 0;
                cBMunicipio.SelectedIndex = 0;
                cBEstado.SelectedIndex = 0;
                string[] Datos = { cBPais.SelectedIndex.ToString() };
                var Estados = new DataTable();
                Estados = manp.Estados(Datos);
                foreach (DataRow fila in Estados.Rows)
                {
                    cBEstado.Items.Add(fila["NombreEstado"].ToString());
                }
            }
        }

        private void cBMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBCiudad.Items.Clear();
            cBCiudad.Items.Add(" ");
            cBCiudad.SelectedIndex = 0;
            string[] Datos = { cBMunicipio.SelectedItem.ToString(), cBEstado.SelectedItem.ToString() };
            var Ciudades = new DataTable();
            Ciudades = manp.Ciudades(Datos);
            foreach (DataRow fila in Ciudades.Rows)
            {
                cBCiudad.Items.Add(fila["NombreCiudad"].ToString());
            }
        }

        private void cBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBMunicipio.Items.Clear();
            cBMunicipio.Items.Add(" ");
            cBMunicipio.SelectedIndex = 0;
            string[] Datos = {cBEstado.SelectedIndex.ToString() };
            var Municipios = new DataTable();
            Municipios = manp.Municipios(Datos);
            foreach (DataRow fila in Municipios.Rows)
            {
                cBMunicipio.Items.Add(fila["NombreMunicipio"].ToString());
            }
        }

        private void txtOtroDominio_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBDominio, txtOtroDominio);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
 
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;
        }

        private void pBMostrar_MouseHover(object sender, EventArgs e)
        {
            pBMostrar.Image = Properties.Resources.ojo_2;
        }

        private void pBGuardar_MouseLeave(object sender, EventArgs e)
        {
            pBGuardar.Image = Properties.Resources.guardae;
        }

        private void pBGuardar_MouseHover(object sender, EventArgs e)
        {
            pBGuardar.Image = Properties.Resources.guardar2;
        }

        private void pBSalir_MouseLeave(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir2;
        }

        private void pBSalir_MouseHover(object sender, EventArgs e)
        {
            pBSalir.Image = Properties.Resources.salir;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void cBCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void txtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void pBMostrar2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = false;
        }

        private void pBMostrar2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void pBMostrar2_MouseHover(object sender, EventArgs e)
        {
            pBMostrar2.Image = Properties.Resources.ojo_2;
        }
    }
}

