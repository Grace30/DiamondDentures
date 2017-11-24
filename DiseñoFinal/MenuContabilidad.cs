using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using Entidad;

namespace DiseñoFinal
{
    public partial class MenuContabilidad : Form
    {
        bool admin = false;
        InterfaceUsuario intusuario;
        string UsuarioEnCurso = "";
        Form pantalla;
        public MenuContabilidad()
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            timer1.Start();
            CheckForIllegalCrossThreadCalls = false;
        }
        public MenuContabilidad(Form pantalla)
        {
            InitializeComponent();
            intusuario = new InterfaceUsuario(this);
            this.pantalla = pantalla;
            UsuarioEnCurso = MenuPrincipal.UsuarioEnCurso;
            timer1.Start();
            CheckForIllegalCrossThreadCalls = false;

        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void pBAdministrar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //Facturas frm = new Facturas();
            //frm.Show();
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaFacturas", Datos);
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaFacturar", Datos);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
           
        }

        private void pBCrearFactura_Click(object sender, EventArgs e)
        {
            timer1.Stop();
             string[] Datos = new string[1];
           // string[] Datos = { UsuarioEnCurso };
            intusuario.enviarEvento("PantallaFacturar", Datos);
            timer1.Start();
        }

        private void pBSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            if (pantalla.GetType()==typeof(MenuPrincipal))
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(MenuPrincipal))
                    {
                        frm.Show();
                    }
                }
            }
            else
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Login))
                    {
                        frm.Show();
                    }
                }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuPrincipal frm = new MenuPrincipal();
            frm.Show();
        }

        private void pBSalir2_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void MenuContabilidad_Load(object sender, EventArgs e)
        {
            button3.Text = Program.Departamento + " - " + Program.Loginn;
            GetSaldo();
            requests();
            getCajaConta();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[1];
            intusuario.enviarEvento("PantallaNomina", Datos);
        }
        int countRAnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            new Thread(requests).Start();
            new Thread(GetSaldo).Start();
            new Thread(getCajaConta).Start();
        }

        private void GetSaldo()
        {
            saldonuevoBanc = new ManejadorBanco().GetSaldoEnBanco(saldonuevoBanc);
            lbl_SaldoActual.Text = string.Format("Saldo en banco: {0} MXN", saldonuevoBanc.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
        }
        double saldonuevoBanc = 0;
        double saldonuevo = 0;
        private void getCajaConta()
        {
            saldonuevo = new ManejadorBanco().getSaldoEnCajaConta(saldonuevo);
            cajaConta.Text = string.Format("Saldo en caja Contabilidad: {0} MXN", saldonuevo.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
        }


        private void requests()
        {
            int countR = new ManejadorRequisicion().CountRequisicionesPendientes(countRAnt);
            if (countR != countRAnt)
            {
                if(countR > countRAnt)
                    Notification();
                switch (countR)
                {
                    case 0:
                        pbox_Requisiciones.Image = Properties.Resources.Request0;
                        break;
                    case 1:
                        pbox_Requisiciones.Image = Properties.Resources.Request1;
                        break;
                    case 2:
                        pbox_Requisiciones.Image = Properties.Resources.Request2;
                        break;
                    case 3:
                        pbox_Requisiciones.Image = Properties.Resources.Request3;
                        break;
                    case 4:
                        pbox_Requisiciones.Image = Properties.Resources.Request4;
                        break;
                    case 5:
                        pbox_Requisiciones.Image = Properties.Resources.Request5;
                        break;
                    default:
                        if (countR > 5)
                            pbox_Requisiciones.Image = Properties.Resources.RequestMoreOf5;
                        break;
                }
                countRAnt = countR;
            }
        }

        private void Notification()
        {
            
            SoundPlayer player =
            new SoundPlayer();
            player.Stream = Properties.Resources.drip_echo;
            player.Load();
            player.Play();

            new Thread(brillo).Start();
        }

        private void brillo() {
            for (int i = 0; i < 3; i++)
            {
                pbox_Requisiciones.BackColor = Color.Green;
                Thread.Sleep(400);
                pbox_Requisiciones.BackColor = Color.Transparent;
                Thread.Sleep(400);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width + 3, ((PictureBox)sender).Size.Height + 3);
            ((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X - 1, ((PictureBox)sender).Location.Y - 1);
            ((PictureBox)sender).BackColor = Color.GhostWhite;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(((PictureBox)sender).Size.Width - 3, ((PictureBox)sender).Size.Height - 3);
            ((PictureBox)sender).Location = new Point(((PictureBox)sender).Location.X + 1, ((PictureBox)sender).Location.Y + 1);
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //timer1.Stop();
            new OrdenesDeCompra().ShowDialog();
            //timer1.Start();
        }

        private void pbox_Balance_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            new Balance().ShowDialog();
            timer1.Start();
        }

        private void lbl_SaldoActual_Click(object sender, EventArgs e)
        {
            new CorrecionBalance().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            new PagoAEmpleados().ShowDialog();
        }

        private void pBReportes_Click(object sender, EventArgs e)
        {
            MenúReportes frm = new MenúReportes(this);
            intusuario.desplegarPantalla(frm);
            intusuario.cerrarPantalla(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Datos = new string[] { Program.Loginn };
            intusuario.enviarEvento("PerfilUsuario",Datos );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new FirmarAsistencia().ShowDialog();
        }
    }
}
