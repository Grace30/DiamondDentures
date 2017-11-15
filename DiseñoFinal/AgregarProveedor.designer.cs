namespace DiseñoFinal
{
    partial class AgregarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mkTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOtroDominio = new System.Windows.Forms.TextBox();
            this.cBDominio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCont = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNCuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(250, 28);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // mkTelefono
            // 
            this.mkTelefono.Location = new System.Drawing.Point(532, 28);
            this.mkTelefono.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mkTelefono.Mask = "(999)000-0000";
            this.mkTelefono.Name = "mkTelefono";
            this.mkTelefono.Size = new System.Drawing.Size(83, 20);
            this.mkTelefono.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 147;
            this.label9.Text = "Teléfono";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(519, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 165;
            this.label21.Text = "Otro";
            // 
            // txtOtroDominio
            // 
            this.txtOtroDominio.Location = new System.Drawing.Point(522, 172);
            this.txtOtroDominio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtroDominio.MaxLength = 20;
            this.txtOtroDominio.Name = "txtOtroDominio";
            this.txtOtroDominio.Size = new System.Drawing.Size(116, 20);
            this.txtOtroDominio.TabIndex = 162;
            // 
            // cBDominio
            // 
            this.cBDominio.FormattingEnabled = true;
            this.cBDominio.Items.AddRange(new object[] {
            "OTRO",
            "hotmail.com",
            "yahoo.com",
            "gmail.com",
            "live.com.mx",
            "live.com",
            "prodigy.net.mx",
            "outlook.com"});
            this.cBDominio.Location = new System.Drawing.Point(378, 172);
            this.cBDominio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cBDominio.Name = "cBDominio";
            this.cBDominio.Size = new System.Drawing.Size(138, 21);
            this.cBDominio.TabIndex = 161;
            this.cBDominio.Text = "hotmail.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 164;
            this.label11.Text = " @";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(38, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 20);
            this.txtEmail.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = "Email*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 167;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 28);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(109, 20);
            this.txtClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(85, 9);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(0, 13);
            this.lblClave.TabIndex = 168;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(38, 217);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(600, 84);
            this.txtDesc.TabIndex = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(637, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(85, 66);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(167, 20);
            this.txtRFC.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del Contacto";
            // 
            // txtNombreCont
            // 
            this.txtNombreCont.Location = new System.Drawing.Point(148, 111);
            this.txtNombreCont.MaxLength = 40;
            this.txtNombreCont.Name = "txtNombreCont";
            this.txtNombreCont.Size = new System.Drawing.Size(328, 20);
            this.txtNombreCont.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 170;
            this.label7.Text = "Numero de Cuenta";
            // 
            // txtNCuenta
            // 
            this.txtNCuenta.Location = new System.Drawing.Point(373, 65);
            this.txtNCuenta.MaxLength = 16;
            this.txtNCuenta.Name = "txtNCuenta";
            this.txtNCuenta.Size = new System.Drawing.Size(103, 20);
            this.txtNCuenta.TabIndex = 171;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 356);
            this.Controls.Add(this.txtNCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtOtroDominio);
            this.Controls.Add(this.cBDominio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mkTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNombreCont);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.Load += new System.EventHandler(this.AgregarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mkTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOtroDominio;
        private System.Windows.Forms.ComboBox cBDominio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNCuenta;
    }
}