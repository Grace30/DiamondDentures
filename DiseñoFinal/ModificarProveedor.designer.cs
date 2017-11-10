namespace DiseñoFinal
{
    partial class ModificarProveedor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOtroDominio = new System.Windows.Forms.TextBox();
            this.cBDominio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mkTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtNombreCont = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 188;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(504, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 187;
            this.label21.Text = "Otro";
            // 
            // txtOtroDominio
            // 
            this.txtOtroDominio.Location = new System.Drawing.Point(507, 177);
            this.txtOtroDominio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtroDominio.MaxLength = 20;
            this.txtOtroDominio.Name = "txtOtroDominio";
            this.txtOtroDominio.Size = new System.Drawing.Size(116, 20);
            this.txtOtroDominio.TabIndex = 184;
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
            this.cBDominio.Location = new System.Drawing.Point(363, 177);
            this.cBDominio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cBDominio.Name = "cBDominio";
            this.cBDominio.Size = new System.Drawing.Size(138, 21);
            this.cBDominio.TabIndex = 183;
            this.cBDominio.Text = "hotmail.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(328, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 186;
            this.label11.Text = " @";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(23, 222);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(600, 84);
            this.txtDesc.TabIndex = 182;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 177);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 20);
            this.txtEmail.TabIndex = 181;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 185;
            this.label6.Text = "Email*";
            // 
            // mkTelefono
            // 
            this.mkTelefono.Location = new System.Drawing.Point(517, 33);
            this.mkTelefono.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mkTelefono.Mask = "(999)000-0000";
            this.mkTelefono.Name = "mkTelefono";
            this.mkTelefono.Size = new System.Drawing.Size(83, 20);
            this.mkTelefono.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 180;
            this.label9.Text = "Teléfono";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(70, 71);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(167, 20);
            this.txtRFC.TabIndex = 177;
            // 
            // txtNombreCont
            // 
            this.txtNombreCont.Location = new System.Drawing.Point(133, 116);
            this.txtNombreCont.MaxLength = 40;
            this.txtNombreCont.Name = "txtNombreCont";
            this.txtNombreCont.Size = new System.Drawing.Size(328, 20);
            this.txtNombreCont.TabIndex = 176;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 33);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 173;
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 172;
            this.label4.Text = "RFC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 171;
            this.label5.Text = "Nombre del Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 174;
            this.label3.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(620, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 190;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(67, 33);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(0, 13);
            this.lblClave.TabIndex = 189;
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 363);
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
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtNombreCont);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProveedor";
            this.Text = "ModificarProveedor";
            this.Load += new System.EventHandler(this.ModificarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOtroDominio;
        private System.Windows.Forms.ComboBox cBDominio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mkTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtNombreCont;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClave;
    }
}