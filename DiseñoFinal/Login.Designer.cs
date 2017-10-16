namespace DiseñoFinal
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkHeOlvidado = new System.Windows.Forms.LinkLabel();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.bPSalir = new System.Windows.Forms.PictureBox();
            this.pBMostrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.pBIngresar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIngresar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiseñoFinal.Properties.Resources.holi;
            this.pictureBox1.Location = new System.Drawing.Point(113, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "¿No tienes una cuenta?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 16;
            // 
            // linkHeOlvidado
            // 
            this.linkHeOlvidado.AutoSize = true;
            this.linkHeOlvidado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHeOlvidado.Location = new System.Drawing.Point(77, 345);
            this.linkHeOlvidado.Name = "linkHeOlvidado";
            this.linkHeOlvidado.Size = new System.Drawing.Size(175, 17);
            this.linkHeOlvidado.TabIndex = 98;
            this.linkHeOlvidado.TabStop = true;
            this.linkHeOlvidado.Text = "He olvidado  mi contraseña.";
            this.linkHeOlvidado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHeOlvidado_LinkClicked);
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistrarse.Location = new System.Drawing.Point(192, 376);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(72, 17);
            this.linkRegistrarse.TabIndex = 99;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Regístrate.";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarse_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(45, 242);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(45, 200);
            this.txtLogin.MaxLength = 40;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(232, 27);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Login";
            this.txtLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLogin_MouseClick);
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // bPSalir
            // 
            this.bPSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.bPSalir.Location = new System.Drawing.Point(279, 364);
            this.bPSalir.Name = "bPSalir";
            this.bPSalir.Size = new System.Drawing.Size(39, 37);
            this.bPSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bPSalir.TabIndex = 19;
            this.bPSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.bPSalir, "Salir");
            this.bPSalir.Click += new System.EventHandler(this.pBSalir_Click);
            this.bPSalir.MouseEnter += new System.EventHandler(this.bPSalir_MouseEnter);
            this.bPSalir.MouseHover += new System.EventHandler(this.bPSalir_MouseHover);
            // 
            // pBMostrar
            // 
            this.pBMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBMostrar.Image = global::DiseñoFinal.Properties.Resources.ojo_1;
            this.pBMostrar.Location = new System.Drawing.Point(279, 243);
            this.pBMostrar.Name = "pBMostrar";
            this.pBMostrar.Size = new System.Drawing.Size(27, 27);
            this.pBMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMostrar.TabIndex = 21;
            this.pBMostrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBMostrar, "Ver Contraseña");
            this.pBMostrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBMostrar_MouseDown);
            this.pBMostrar.MouseLeave += new System.EventHandler(this.pBMostrar_MouseLeave);
            this.pBMostrar.MouseHover += new System.EventHandler(this.pBMostrar_MouseHover);
            this.pBMostrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBMostrar_MouseUp);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.salir11;
            this.pBSalir2.Location = new System.Drawing.Point(302, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 24;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir2.MouseLeave += new System.EventHandler(this.pBSalir2_MouseLeave_1);
            this.pBSalir2.MouseHover += new System.EventHandler(this.pBSalir2_MouseHover_1);
            // 
            // pBIngresar
            // 
            this.pBIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBIngresar.Image = global::DiseñoFinal.Properties.Resources.ingresar;
            this.pBIngresar.Location = new System.Drawing.Point(145, 286);
            this.pBIngresar.Name = "pBIngresar";
            this.pBIngresar.Size = new System.Drawing.Size(46, 50);
            this.pBIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBIngresar.TabIndex = 23;
            this.pBIngresar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBIngresar, "Ingresar");
            this.pBIngresar.Click += new System.EventHandler(this.pBIngresar_Click);
            this.pBIngresar.MouseLeave += new System.EventHandler(this.pBIngresar_MouseLeave);
            this.pBIngresar.MouseHover += new System.EventHandler(this.pBIngresar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pBIngresar);
            this.panel1.Controls.Add(this.pBMostrar);
            this.panel1.Controls.Add(this.bPSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkHeOlvidado);
            this.panel1.Controls.Add(this.linkRegistrarse);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 413);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pBSalir2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 79);
            this.panel2.TabIndex = 24;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(331, 413);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIngresar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkHeOlvidado;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox bPSalir;
        private System.Windows.Forms.PictureBox pBMostrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBIngresar;
    }
}

