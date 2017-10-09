namespace DiseñoFinal
{
    partial class RegistrarTarjeta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTarjeta));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOtroTipo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOtroBanco = new System.Windows.Forms.TextBox();
            this.cBTipo = new System.Windows.Forms.ComboBox();
            this.cBBanco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBAño = new System.Windows.Forms.ComboBox();
            this.cBMes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBGuardar = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 202;
            this.label1.Text = "REGISTRAR TARJETA";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 221;
            this.label6.Text = "Otro";
            // 
            // txtOtroTipo
            // 
            this.txtOtroTipo.Location = new System.Drawing.Point(233, 380);
            this.txtOtroTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtroTipo.MaxLength = 20;
            this.txtOtroTipo.Name = "txtOtroTipo";
            this.txtOtroTipo.Size = new System.Drawing.Size(132, 23);
            this.txtOtroTipo.TabIndex = 220;
            this.txtOtroTipo.TextChanged += new System.EventHandler(this.txtOtroTipo_TextChanged);
            this.txtOtroTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtroTipo_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(230, 303);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 17);
            this.label21.TabIndex = 219;
            this.label21.Text = "Otro";
            // 
            // txtOtroBanco
            // 
            this.txtOtroBanco.Location = new System.Drawing.Point(233, 324);
            this.txtOtroBanco.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtroBanco.MaxLength = 20;
            this.txtOtroBanco.Name = "txtOtroBanco";
            this.txtOtroBanco.Size = new System.Drawing.Size(132, 23);
            this.txtOtroBanco.TabIndex = 218;
            this.txtOtroBanco.TextChanged += new System.EventHandler(this.txtOtroBanco_TextChanged);
            this.txtOtroBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtroBanco_KeyPress);
            // 
            // cBTipo
            // 
            this.cBTipo.FormattingEnabled = true;
            this.cBTipo.Items.AddRange(new object[] {
            "OTRO",
            "Débito",
            "Crédito",
            "Monedero o Prepago",
            "Prepago Multidivisa",
            "Comercio"});
            this.cBTipo.Location = new System.Drawing.Point(30, 380);
            this.cBTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBTipo.Name = "cBTipo";
            this.cBTipo.Size = new System.Drawing.Size(176, 25);
            this.cBTipo.TabIndex = 4;
            this.cBTipo.Text = "-Elija una opción-";
            this.cBTipo.SelectedIndexChanged += new System.EventHandler(this.cBTipo_SelectedIndexChanged);
            // 
            // cBBanco
            // 
            this.cBBanco.FormattingEnabled = true;
            this.cBBanco.Items.AddRange(new object[] {
            "OTRO",
            "AcertumBank",
            "Actinver",
            "Agrofinanzas",
            "American Express Bank",
            "Banamex",
            "Banca Afirme",
            "Banca Mifel",
            "Banco Ahorro Famsa",
            "Banco Azteca",
            "Banco Bicentenario",
            "Banco del Bajio",
            "Banco Fácil",
            "Banco Finterra",
            "Banco Forjadores",
            "Banco Inbursa",
            "Banco Inmobiliario Mexicano",
            "Banco Interacciones",
            "Banco Invex",
            "Banco Monex",
            "Banco Multiva",
            "Banco Progreso Chihuahua",
            "Banco Santander",
            "Banco Ve por Más",
            "Banco WalMart",
            "Bancomer",
            "Bancomext",
            "Bancoppel",
            "Bancrea",
            "Banjército",
            "Bank of America",
            "Bank of China México",
            "Bank of Tokyo-Mitsubishi UFJ",
            "Bankaool",
            "Banobras",
            "Banorte",
            "Banregio",
            "Banrural",
            "Bansefi",
            "Bansí",
            "Barclays Bank",
            "BNP Paribas Personal Finance",
            "BradesCard México",
            "CIBanco",
            "Compartamos Banco ",
            "Consubanco",
            "Credit Suisse",
            "Credomatic",
            "Deutsche Bank",
            "Fundación Dondé Banco",
            "HSBC",
            "ICBC México",
            "ING Bank",
            "InterBanco",
            "InvestaBank",
            "Ixe Banco",
            "J.P. Morgan",
            "Mi Banco BAM",
            "Prudential Bank",
            "Sabadell Capital",
            "Scotiabank",
            "The Bank of New York Mellon",
            "The Royal Bank of Scotland México",
            "UBS Bank",
            "Volkswagen Bank"});
            this.cBBanco.Location = new System.Drawing.Point(31, 322);
            this.cBBanco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBBanco.Name = "cBBanco";
            this.cBBanco.Size = new System.Drawing.Size(185, 25);
            this.cBBanco.TabIndex = 3;
            this.cBBanco.Text = "-Elija una opción-";
            this.cBBanco.SelectedIndexChanged += new System.EventHandler(this.cBBanco_SelectedIndexChanged);
            this.cBBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBBanco_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 215;
            this.label4.Text = "Tipo*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 214;
            this.label3.Text = "Banco*";
            // 
            // cBAño
            // 
            this.cBAño.FormattingEnabled = true;
            this.cBAño.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cBAño.Location = new System.Drawing.Point(161, 437);
            this.cBAño.Margin = new System.Windows.Forms.Padding(4);
            this.cBAño.Name = "cBAño";
            this.cBAño.Size = new System.Drawing.Size(99, 25);
            this.cBAño.TabIndex = 6;
            this.cBAño.Text = "Año";
            // 
            // cBMes
            // 
            this.cBMes.FormattingEnabled = true;
            this.cBMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cBMes.Location = new System.Drawing.Point(31, 437);
            this.cBMes.Margin = new System.Windows.Forms.Padding(4);
            this.cBMes.Name = "cBMes";
            this.cBMes.Size = new System.Drawing.Size(103, 25);
            this.cBMes.TabIndex = 5;
            this.cBMes.Text = "Mes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 476);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 17);
            this.label16.TabIndex = 211;
            this.label16.Text = "*Campos obligatorios.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 208;
            this.label5.Text = "Fecha de vencimiento*";
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.Location = new System.Drawing.Point(31, 255);
            this.txtNoTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoTarjeta.MaxLength = 16;
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(251, 23);
            this.txtNoTarjeta.TabIndex = 2;
            this.txtNoTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTarjeta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "Número de tarjeta*";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(31, 188);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitular.MaxLength = 40;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(379, 23);
            this.txtTitular.TabIndex = 1;
            this.txtTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitular_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 204;
            this.label7.Text = "Titular*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiseñoFinal.Properties.Resources.retarjetarjeta2;
            this.pictureBox1.Location = new System.Drawing.Point(161, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 203;
            this.pictureBox1.TabStop = false;
            // 
            // pBGuardar
            // 
            this.pBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBGuardar.Image = global::DiseñoFinal.Properties.Resources.guardae;
            this.pBGuardar.Location = new System.Drawing.Point(171, 476);
            this.pBGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBGuardar.Name = "pBGuardar";
            this.pBGuardar.Size = new System.Drawing.Size(68, 68);
            this.pBGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGuardar.TabIndex = 222;
            this.pBGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBGuardar, "Guardar");
            this.pBGuardar.Click += new System.EventHandler(this.pBGuardar_Click);
            this.pBGuardar.MouseLeave += new System.EventHandler(this.pBGuardar_MouseLeave);
            this.pBGuardar.MouseHover += new System.EventHandler(this.pBGuardar_MouseHover);
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir2;
            this.pBSalir.Location = new System.Drawing.Point(403, 518);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 42);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 223;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalirClick);
            this.pBSalir.MouseLeave += new System.EventHandler(this.pBSalir_MouseLeave);
            this.pBSalir.MouseHover += new System.EventHandler(this.pBSalir_MouseHover);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(420, 14);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 203;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalirClick);
            this.pBSalir2.MouseLeave += new System.EventHandler(this.pBSalir2_MouseLeave);
            this.pBSalir2.MouseHover += new System.EventHandler(this.pBSalir2_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 69);
            this.panel1.TabIndex = 224;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // RegistrarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.u;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(452, 572);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOtroTipo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtOtroBanco);
            this.Controls.Add(this.cBTipo);
            this.Controls.Add(this.cBBanco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBAño);
            this.Controls.Add(this.cBMes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.RegistrarTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOtroTipo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOtroBanco;
        private System.Windows.Forms.ComboBox cBTipo;
        private System.Windows.Forms.ComboBox cBBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBAño;
        private System.Windows.Forms.ComboBox cBMes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBGuardar;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
    }
}