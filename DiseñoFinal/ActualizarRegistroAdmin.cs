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
    public partial class ActualizarRegistroAdmin : Form
    {
        InterfaceUsuario intusuario;
        ManejadorPrincipal manp = new ManejadorPrincipal();
        Validación v;
        bool guardado = false;
        public string Nombre, Apellidos, Direccion, Colonia, Pais, Estado, Municipio, Ciudad, Codigo, TelCasa, TelOficina, TelMovil, Password, Pregunta, Respuesta, Email, Departamento, FechaNac;

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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pBMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pBMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            txtApellidos.Clear();
        }

        public string[] EmailPartes = new string[2];
        string UsuarioEnCurso;

        public ActualizarRegistroAdmin(string Usuario)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            v = new Validación();
            UsuarioEnCurso = Usuario;
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
                    if (frm.GetType() == typeof(PerfilUsuario))
                    {
                        frm.Show();
                    }
                }
            }
            if (x == DialogResult.Yes)
            {
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(PerfilUsuario))
                    {
                        frm.Show();
                    }
                }
            }
            else { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cBDominio.SelectedIndex != 0)
            {
                txtOtroDominio.Text = "";
            }
            if (v.ValidaCamposActualizar(txtNombre, txtApellidos, maskedTCasa,
                    txtEmail, txtPassword, cBPreguntaSeguridad,
                    txtRespuesta, cBPais, txtDireccion, txtColonia,
                    maskedTMovil, cBEstado, cBMunicipio, cBCiudad, txtConfirmar, maskedCodigo)
                    && v.VerificaDigitos(maskedTOficina) && v.Password(txtPassword.Text, txtConfirmar.Text) && v.CodigoPostal(cBPais.Text, maskedCodigo)
                    || v.NCasa(txtDireccion.Text))
            {
                if (cBPais.Text == "-Elija un País-")
                    cBPais.SelectedIndex = 0;
                if (txtDireccion.Text == "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.")
                    txtDireccion.Text = "";

                string[] today = dtNacimiento.Value.ToShortDateString().Split('/');
                string fecha = "";
                int i = 2;
                while (i >= 0)
                {
                    fecha += today[i];
                    if (i > 0) { fecha += "/"; }
                    i--;
                }
                string[] Datos = { txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtColonia.Text, cBPais.Text.ToString(), cBEstado.Text.ToString(), cBMunicipio.Text.ToString(), cBCiudad.Text.ToString(), maskedCodigo.Text, maskedTCasa.Text, maskedTOficina.Text, maskedTMovil.Text, txtEmail.Text, cBDominio.SelectedItem.ToString(), txtOtroDominio.Text, lblLogin.Text, txtPassword.Text, cBPreguntaSeguridad.SelectedItem.ToString(), txtRespuesta.Text, cbDepartamento.Text, fecha };
                intusuario.enviarEvento("Actualizar", Datos);
                guardado = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.NumerosLetras(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string[] Datos = { lblLogin.Text };
            intusuario.enviarEvento("EliminarUsuario", Datos);
            this.Close();
        }

        private void ActualizarRegistroAdmin_Load(object sender, EventArgs e)
        {
            cBPais.Items.Clear();
            cBPais.Items.Add(" ");
            cBPais.SelectedIndex = 0;
            cBEstado.SelectedIndex = 0;
            cBMunicipio.SelectedIndex = 0;
            cBCiudad.SelectedIndex = 0;
            
            var Paises = new DataTable();
            Paises = manp.Paises();
            foreach (DataRow fila in Paises.Rows)
            {
                cBPais.Items.Add(fila["NombrePais"].ToString());
            }

            cBPais.Text = Pais;
            cBEstado.Text = Estado;
            cBMunicipio.Text = Municipio;
            cBCiudad.Text = Ciudad; 
            lblLogin.Text = UsuarioEnCurso;
            txtNombre.Text = Nombre;
            txtApellidos.Text = Apellidos;
            txtDireccion.Text = Direccion;
            txtColonia.Text = Colonia;
            maskedCodigo.Text = Codigo;
            maskedTCasa.Text = TelCasa;
            maskedTOficina.Text = TelOficina;
            maskedTMovil.Text = TelMovil;
            txtPassword.Text = Password; 
            txtConfirmar.Text = Password;
            txtRespuesta.Text = Respuesta;
            cbDepartamento.Text = Departamento;
            dtNacimiento.Text = FechaNac;
            int i = 0;
            while (Email[i] != '@')
            {
                EmailPartes[0] += Email[i];
                i++;
            }
            txtEmail.Text = EmailPartes[0];
            i++;
            while (Email[i].ToString() != " ")
            {
                EmailPartes[1] += Email[i];
                i++;
            }
            i = 0;
            bool EnDominio = false;
            while (i < cBDominio.Items.Count)
            {
                if (EmailPartes[1] == cBDominio.Items[i].ToString())
                {
                    cBDominio.SelectedIndex = i;
                    EnDominio = true;
                    break;
                }
                i++;
            }
            if (EnDominio == false)
                txtOtroDominio.Text = EmailPartes[1];

            i = 0;
            while (i < cBPreguntaSeguridad.Items.Count)
            {
                string preguntaseg = "";
                int j = 0;
                while (j < Pregunta.Length)
                {
                    preguntaseg += Pregunta[j];
                    if (preguntaseg == cBPreguntaSeguridad.Items[i].ToString())
                    {
                        cBPreguntaSeguridad.SelectedIndex = i;
                        break;
                    }
                    j++;
                }
                i++;
            }  
        }

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedCodigo.ReadOnly = false;
            if (cBPais.Text != "Canadá" || cBPais.Text != "Canadá                                  ")
            { maskedCodigo.Mask = "00000"; }
            if (cBPais.Text == "Canadá" || cBPais.Text == "Canadá                                  ")
            { maskedCodigo.Mask = "?0?0?0"; }
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
            else
            {
                cBEstado.SelectedIndex = 0;
                cBMunicipio.SelectedIndex = 0;
                cBEstado.SelectedIndex = 0;
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
            string[] Datos = { cBEstado.SelectedIndex.ToString() };
            var Municipios = new DataTable();
            Municipios = manp.Municipios(Datos);
            foreach (DataRow fila in Municipios.Rows)
            {
                cBMunicipio.Items.Add(fila["NombreMunicipio"].ToString());
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir11;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void maskedCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.evtKeyPressCP(e);
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar2;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Image = Properties.Resources.eliminar;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.Image = Properties.Resources.eliminar2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.salir;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.salir2;
        }

        private void pBMostrar_MouseHover(object sender, EventArgs e)
        {
            pBMostrar.Image = Properties.Resources.ojo_2;
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void txtOtroDominio_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBDominio, txtOtroDominio);
        }

        private void pBMostrar_Click(object sender, EventArgs e)
        {

        }

        private void pBMostrar2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void pBMostrar2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = false;
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void txtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.LetrasNumerosCaracteres(e);
        }

        private void pBMostrar2_MouseHover(object sender, EventArgs e)
        {
            pBMostrar2.Image = Properties.Resources.ojo_2;
        }

        private void cBPais_TextChanged(object sender, EventArgs e)
        {
            maskedCodigo.ReadOnly = false;
            if (cBPais.Text != "Canadá" || cBPais.Text != "Canadá                                  ")
            { maskedCodigo.Mask = "00000"; }
            if (cBPais.Text == "Canadá" || cBPais.Text == "Canadá                                  ")
            { maskedCodigo.Mask = "?0?0?0"; }
            if (cBPais.SelectedIndex == 149)
            {
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
            else
            {
                cBEstado.SelectedIndex = 0;
                cBMunicipio.SelectedIndex = 0;
                cBEstado.SelectedIndex = 0;
            }
        }

       
    }
}