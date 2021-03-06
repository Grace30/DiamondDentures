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
    public partial class ActualizarRegistroUsuario : Form
    {
        ManejadorPrincipal manp = new ManejadorPrincipal();
        InterfaceUsuario intusuario;
        Validación v;
        bool guardado = false;
        public string Nombre, Apellidos, Direccion, Colonia, Pais, Estado, Municipio, Ciudad, Codigo, TelCasa, TelOficina, TelMovil, Password, Pregunta, Respuesta, Email;

        private void maskedCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.evtKeyPressCP(e);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            v.Llenartxt(txtDireccion, "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.");
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            v.Limpiartxt(txtDireccion, "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.");
        }

        private void pBMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pBMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        public string[] EmailPartes = new string[2];
        string UsuarioEnCurso;

        public ActualizarRegistroUsuario(string Usuario)
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
                    && v.VerificaDigitos(maskedTOficina) && v.CodigoPostal(cBPais.Text, maskedCodigo)
                    || v.NCasa(txtDireccion.Text))
            {
                if (cBPais.Text == "-Elija un País-")
                    cBPais.SelectedIndex = 0;
                if (txtDireccion.Text == "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.")
                    txtDireccion.Text = "";
                string[] Datos = { txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtColonia.Text, cBPais.Text.ToString(), cBEstado.Text.ToString(), cBMunicipio.Text.ToString(), cBCiudad.Text.ToString(), maskedCodigo.Text, maskedTCasa.Text, maskedTOficina.Text, maskedTMovil.Text, txtEmail.Text, cBDominio.SelectedItem.ToString(), txtOtroDominio.Text, UsuarioEnCurso, txtPassword.Text, cBPreguntaSeguridad.SelectedItem.ToString(), txtRespuesta.Text };
                intusuario.enviarEvento("Actualizar", Datos);
                guardado = true;
            }
        }

        private void ActualizarRegistroUsuario_Load(object sender, EventArgs e)
        {      
            //Codigo para Agregar los países al comboboxPaises
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
 
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

        private void cBPais_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void cBCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBSalir2_MouseLeave(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.salir2;
        }

        private void pBSalir2_MouseHover(object sender, EventArgs e)
        {
            pBSalir2.Image = Properties.Resources.Salir_3;
        }

        private void btnActualizar_MouseLeave(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar2;
        }

        private void btnActualizar_MouseHover(object sender, EventArgs e)
        {
            btnActualizar.Image = Properties.Resources.actualizar;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.salir2;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.Image = Properties.Resources.salir;
        }

        private void pBMostrar_MouseHover(object sender, EventArgs e)
        {
            pBMostrar.Image = Properties.Resources.ojo_2;
        }

        private void txtOtroDominio_TextChanged(object sender, EventArgs e)
        {
            v.Otro(cBDominio,txtOtroDominio);
        }

        private void pBMostrar2_MouseHover(object sender, EventArgs e)
        {
            pBMostrar2.Image = Properties.Resources.ojo_2;
        }

        private void pBMostrar2_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = false;
        }

        private void pBMostrar2_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
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
