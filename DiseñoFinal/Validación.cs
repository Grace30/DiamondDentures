using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public class Validación
    {
        public Validación()
        {

        }
        public bool ValidaCamposMat(TextBox Codigo, TextBox Nombre, TextBox Tiempo, TextBox Precio)
        {
            if (Codigo.Text != "" && Nombre.Text != "" && Tiempo.Text != "" && Precio.Text != "")
            { return true; }
            else
            { return false; }
        }
        public bool ValidaCamposPieza(TextBox Codigo, TextBox Nombre, NumericUpDown Tiempo, TextBox Precio)
        {
            if (Codigo.Text != "" && Nombre.Text != "" && Precio.Text != "" && Tiempo.Value > 0)
            { return true; }
            else
            { return false; }
        }
        public bool EnCombo(ComboBox combo, string valor)
        {
            int i =0  ;
            while (i < combo.Items.Count)
            {
                if (combo.Items[i].ToString() == valor)
                {
                    return true;                    
                }
            }
            return false;
        }

        public void Limpiartxt(TextBox x, string c)
        {
            if (x.Text == c)
                x.Clear();
        }

        public void Llenartxt(TextBox x, string c)
        {
            if (x.Text == "")
                x.Text = c;
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (int)Keys.Space || e.KeyChar == (int)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Space || e.KeyChar == (int)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        public void OnlyNumber(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        public void noEspacios(KeyPressEventArgs e)
        {
             if (e.KeyChar != (int)Keys.Space)
            {

            }
            else
                e.Handled = true;
        }

        public void NumerosLetras(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (int)Keys.Space || e.KeyChar == (int)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        public void OnlyNumerosLetras(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back)
            {

            }
            else
                e.Handled = true;
        }

        public void LetrasNumerosCaracteres(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (int)Keys.Space
                || e.KeyChar == (int)Keys.Back || char.IsPunctuation(e.KeyChar)
                || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {

            }
            else
                e.Handled = true;
        }

        public bool Mayus(string cadena)
        {
            bool si = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsUpper(cadena[i]))
                    si = true;
            }
            return si;
        }
        public bool Minus(string cadena)
        {
            bool si = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsLower(cadena[i]))
                    si = true;
            }
            return si;
        }

        public bool Numero(string cadena)
        {
            bool si = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsDigit(cadena[i]))
                    si = true;
            }
            return si;
        }

        public bool ValidaCampos(TextBox Nombre, TextBox Apellido,
            MaskedTextBox Tcasa, TextBox Email, TextBox Login,
            TextBox Password, ComboBox Pregunta, TextBox Respuesta, ComboBox Pais, TextBox Direccion, 
            TextBox Colonia, MaskedTextBox Cel, ComboBox Estado, ComboBox Municipio, ComboBox Ciudad, TextBox CPassword, MaskedTextBox CP)
        {
            bool validado = false;
            if (Nombre.Text == "" || Apellido.Text == "" || Tcasa.Text == "(   )   -" ||
                Email.Text == "" || Login.Text == "" || Password.Text == "" ||
                Pregunta.Text == "" || Respuesta.Text == "" || Tcasa.Text.Count() != 13 ||
                Pais.Text == "" || Direccion.Text == "" || Colonia.Text == "" || Cel.Text == "(   )   -" ||
                Estado.Text == "" || Municipio.Text == "" || Ciudad.Text == "" || CPassword.Text == "" || CP.Text == "")
            {
                validado = false;
                string mensaje = "Los campos: ";
                if (Nombre.Text == "")
                    mensaje += "Nombre, ";
                if (Apellido.Text == "")
                    mensaje += "Apellido, ";
                if (Tcasa.Text == "" || Tcasa.Text.Length != 13)
                    mensaje += "Teléfono Casa, ";
                if (Email.Text == "")
                    mensaje += "Email, ";
                if (Login.Text == "")
                    mensaje += "Login, ";
                if (Password.Text == "")
                    mensaje += "Password, ";
                if (Pregunta.Text == "-Elija una opción-" || Pregunta.Text == "" || Pregunta.Text == " ")
                    mensaje += "Pregunta de seguridad, ";
                if (Respuesta.Text == "" || Respuesta.Text == " ")
                    mensaje += "Respuesta, ";
                if (Pais.Text == " " || Pais.Text == "")
                    mensaje += "Pais, ";
                if (Direccion.Text == "" || Direccion.Text == " ")
                    mensaje += "Dirección, ";
                if (Colonia.Text == "" || Colonia.Text == " ")
                    mensaje += "Colonia, ";
                if (Cel.Text == "(   ) -" || Cel.Text.Length != 13)
                    mensaje += "Telefono Movil, ";
                if (Estado.Text == " " || Estado.Text == "")
                    mensaje += "Estado, "; 
                if (Municipio.Text == " " || Municipio.Text == "")
                    mensaje += "Municipio, ";
                if (Ciudad.Text == " " || Ciudad.Text == "")
                    mensaje += "Ciudad, ";
                if (CPassword.Text == "" || CPassword.Text == " ")
                    mensaje += "Confirmar Contraseña, ";
                if (CP.Text == "")
                    mensaje += "Codigo Postal, ";
                mensaje += "no estan debidamente llenos";
                Mensaje(mensaje);
            }
            else if (Password.Text.Length >= 8 && Mayus(Password.Text) && Numero(Password.Text) && Minus(Password.Text))
            {
                validado = true;
            }
            else
            {
                validado = false;
                MessageBox.Show("El campo Password no esta debidamente lleno. Se necesita al menos 1 mayuscula, 1 minuscula, 1 número y 8 caracteres."
                    , "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return validado;
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Campos obligatorios",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool ValidaCamposActualizar(TextBox Nombre, TextBox Apellido,
            MaskedTextBox Tcasa, TextBox Email, TextBox Password, ComboBox Pregunta,
            TextBox Respuesta, ComboBox Pais, TextBox Direccion,
            TextBox Colonia, MaskedTextBox Cel, ComboBox Estado, ComboBox Municipio,
            ComboBox Ciudad, TextBox CPassword, MaskedTextBox CP)
        {
            bool validado = false;
            if (Nombre.Text == "" || Apellido.Text == "" || Tcasa.Text == "(   )   -" ||
                Email.Text == "" || Password.Text == "" ||
                Pregunta.Text == "" || Respuesta.Text == "" || Tcasa.Text.Count() != 13 ||
                Pais.Text == "" || Direccion.Text == "" || Colonia.Text == "" || Cel.Text == "(   )   -" ||
                Estado.Text == "" || Municipio.Text == "" || Ciudad.Text == "" || CPassword.Text == "" || CP.Text == "")
            {
                validado = false;
                string mensaje = "Los campos: ";
                if (Nombre.Text == "")
                    mensaje += "Nombre, ";
                if (Apellido.Text == "")
                    mensaje += "Apellido, ";
                if (Tcasa.Text == "" || Tcasa.Text.Length != 13)
                    mensaje += "Teléfono Casa, ";
                if (Email.Text == "")
                    mensaje += "Email, ";
                if (Password.Text == "")
                    mensaje += "Password, ";
                if (Pregunta.Text == "-Elija una opción-" || Pregunta.Text == "" || Pregunta.Text == " ")
                    mensaje += "Pregunta de seguridad, ";
                if (Respuesta.Text == "")
                    mensaje += "Respuesta, ";
                if (Pais.Text == " " || Pais.Text == "")
                    mensaje += "Pais, ";
                if (Direccion.Text == "" || Direccion.Text == " ")
                    mensaje += "Dirección, ";
                if (Colonia.Text == "" || Colonia.Text == " ")
                    mensaje += "Colonia, ";
                if (Cel.Text == "(   ) -" || Cel.Text.Length != 13)
                    mensaje += "Telefono Movil, ";
                if (Estado.Text == " " || Estado.Text == "")
                    mensaje += "Estado, ";
                if (Municipio.Text == " " || Municipio.Text == "")
                    mensaje += "Municipio, ";
                if (Ciudad.Text == " " || Ciudad.Text == "")
                    mensaje += "Ciudad, ";
                if (CPassword.Text == "" || CPassword.Text == " ")
                    mensaje += "Confirmar Contraseña, ";
                if (CP.Text == "")
                    mensaje += "Codigo Postal, ";
                mensaje += "no estan debidamente llenos";
                Mensaje(mensaje);
            }
            else if (Password.Text.Length >= 8 && Mayus(Password.Text) && Numero(Password.Text) && Minus(Password.Text))
            {
                validado = true;
            }
            else
            {
                validado = false;
                MessageBox.Show("El campo Password no esta debidamente lleno. Se necesita al menos 1 mayuscula, 1 minuscula, 1 número y 8 caracteres."
                    , "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return validado;
        }

        public bool VerificaDigitos( MaskedTextBox TOficina)
        {
            bool bien = true;
            if ( TOficina.Text != "(   )   -" && TOficina.Text.Length != 13)
                bien = false;
            if (!bien)
                MessageBox.Show("El campo Teleono Oficina no está totalmente lleno.",
                    "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return bien;
        }

        //Este metodo esta obsoleto
        public bool VerificaDigitosCanada(MaskedTextBox Codigo, MaskedTextBox TOficina, MaskedTextBox TMovil)
        {
            bool bien = true;
            string codigo = Codigo.Text; 
            if (char.IsUpper(codigo[0]) && char.IsDigit(codigo[1]) && char.IsUpper(codigo[2]) && char.IsDigit(codigo[3]) && char.IsUpper(codigo[4]) && char.IsDigit(codigo[5]))
            {
                if (Codigo.Text != "" && Codigo.Text.Length != 6 || TOficina.Text != "(   )   -" && TOficina.Text.Length != 13
                    || TMovil.Text != "(   )   -" && TMovil.Text.Length != 13)
                {

                    bien = false;
                }
                if (!bien)
                    MessageBox.Show("Algunos campos NO OBLIGATORIOS no estan debidamente llenos",
                        "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                bien = false;
            return bien;
        }

        public bool CodigoPostal(string pais, MaskedTextBox CP)
        {
            bool si = false;
            string codigo = CP.Text;
            if (pais != "Canadá" && CP.Text.Length == 5 || pais != "Canadá                                  " && CP.Text.Length == 5)
                si = true;
            else if (pais == "Canadá" && CP.Text.Length == 6 || pais == "Canadá                                  " && CP.Text.Length == 6)
                si = true;
            if (!si)
                MessageBox.Show("El campo Codigo Postal no cumple con los requisitos",
                    "Codigo postal no valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return si;
        }


        public void Enter(KeyPressEventArgs e, InterfaceUsuario intusuario, TextBox txtLogin, TextBox txtPassword, Form x)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (txtLogin.Text != "" && txtPassword.Text != "")
                {
                    string[] Datos = { txtLogin.Text, txtPassword.Text };
                    intusuario.enviarEvento("Ingresar", Datos);
                    txtPassword.Text = "PASSWORD";
                    
                }
                else
                    MessageBox.Show("Favor de llenar todos los campos",
                        "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        //Metodo tal vez obsoleto
        public bool NCasa(string cadena)
        {
            bool si = false;
            bool six2 = false;
            if (cadena != "" || cadena != "Calle Principal/  Calle Secundaria                    Número exterior                   Etc.")
            {
                foreach (char digitos in cadena)
                {
                    if (si && char.IsDigit(digitos))
                        six2 = true;
                    if (digitos == '#')
                        si = true;
                    else
                        si = false;
                }
                if (!six2)
                    MessageBox.Show("Algunos campos NO OBLIGATORIOS no estan debidamente llenos",
                        "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return six2;
        }

        public void Otro(ComboBox c, TextBox t)
        {
            if (t.Text != "")
                c.Text = "OTRO";
        }

        public bool ValidaCampos(TextBox titual, TextBox numero,
            ComboBox banco, TextBox otrob, ComboBox tipo,
            TextBox otrot, ComboBox mes, ComboBox año)
        {
            bool si = false;
            if (titual.Text != "" && numero.Text != "" && banco.Text != "-Elija una opción-" &&
                tipo.Text != "-Elija una opción-" && mes.Text != "Mes" && año.Text != "Año")
            {
                si = true;
            }
            else
            {
                MessageBox.Show("Algunos campos OBLIGATORIOS no estan debidamente llenos",
                        "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return si;
        }

        public bool Password(string a, string b)
        {
            bool si = false;
            if (a == b)
                si = true;
            if (!si)
                MessageBox.Show("El campo Password y el campo Confirmar Password no coinciden",
                    "No hay coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return si;
        }


        //Aqui habia intentado hacer el de validar en tiempo real el CP pero no me funco...
        public void evtKeyPressCP(KeyPressEventArgs e)
        {
            if (Mayus(e.KeyChar.ToString()) || Numero(e.KeyChar.ToString()))
            {

            }
            else { e.KeyChar = '<'; }
        }
        public string reducirCadena(string cadena)
        {
            if (cadena != null)
            {
                cadena = cadena.TrimEnd(' ');
            }
            return cadena;
        }
    }
}
