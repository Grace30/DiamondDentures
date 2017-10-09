namespace DiseñoFinal
{
    partial class ActualizarTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarTarjeta));
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBActualizar = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOtroBanco = new System.Windows.Forms.TextBox();
            this.cBBanco = new System.Windows.Forms.ComboBox();
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
            this.pBEliminar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOtroTipo = new System.Windows.Forms.TextBox();
            this.cBTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACTUALIZAR DATOS DE TARJETA";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir2;
            this.pBSalir.Location = new System.Drawing.Point(355, 541);
            this.pBSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(44, 52);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 242;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir.MouseLeave += new System.EventHandler(this.pBSalir_MouseLeave);
            this.pBSalir.MouseHover += new System.EventHandler(this.pBSalir_MouseHover);
            // 
            // pBActualizar
            // 
            this.pBActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBActualizar.Image = global::DiseñoFinal.Properties.Resources.actualizar;
            this.pBActualizar.Location = new System.Drawing.Point(120, 499);
            this.pBActualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pBActualizar.Name = "pBActualizar";
            this.pBActualizar.Size = new System.Drawing.Size(65, 59);
            this.pBActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBActualizar.TabIndex = 241;
            this.pBActualizar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBActualizar, "Actualizar");
            this.pBActualizar.Click += new System.EventHandler(this.pBActualizar_Click);
            this.pBActualizar.MouseLeave += new System.EventHandler(this.pBActualizar_MouseLeave);
            this.pBActualizar.MouseHover += new System.EventHandler(this.pBActualizar_MouseHover);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(243, 280);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 16);
            this.label21.TabIndex = 238;
            this.label21.Text = "Otro";
            // 
            // txtOtroBanco
            // 
            this.txtOtroBanco.Location = new System.Drawing.Point(246, 301);
            this.txtOtroBanco.Margin = new System.Windows.Forms.Padding(5);
            this.txtOtroBanco.MaxLength = 20;
            this.txtOtroBanco.Name = "txtOtroBanco";
            this.txtOtroBanco.Size = new System.Drawing.Size(153, 21);
            this.txtOtroBanco.TabIndex = 237;
            this.txtOtroBanco.TextChanged += new System.EventHandler(this.txtOtroBanco_TextChanged);
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
            this.cBBanco.Location = new System.Drawing.Point(10, 301);
            this.cBBanco.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cBBanco.Name = "cBBanco";
            this.cBBanco.Size = new System.Drawing.Size(215, 24);
            this.cBBanco.TabIndex = 3;
            this.cBBanco.Text = "-Elija una opción-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 233;
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
            this.cBAño.Location = new System.Drawing.Point(142, 439);
            this.cBAño.Margin = new System.Windows.Forms.Padding(5);
            this.cBAño.Name = "cBAño";
            this.cBAño.Size = new System.Drawing.Size(115, 24);
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
            this.cBMes.Location = new System.Drawing.Point(12, 439);
            this.cBMes.Margin = new System.Windows.Forms.Padding(5);
            this.cBMes.Name = "cBMes";
            this.cBMes.Size = new System.Drawing.Size(119, 24);
            this.cBMes.TabIndex = 5;
            this.cBMes.Text = "Mes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(289, 474);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 230;
            this.label16.Text = "*Campos obligatorios.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 229;
            this.label5.Text = "Fecha de vencimiento*";
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.Location = new System.Drawing.Point(8, 243);
            this.txtNoTarjeta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNoTarjeta.MaxLength = 40;
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(292, 21);
            this.txtNoTarjeta.TabIndex = 2;
            this.txtNoTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTarjeta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 227;
            this.label2.Text = "Número de tarjeta*";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(10, 180);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTitular.MaxLength = 40;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(361, 21);
            this.txtTitular.TabIndex = 1;
            this.txtTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitular_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 225;
            this.label7.Text = "Titular*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiseñoFinal.Properties.Resources.atarjeta;
            this.pictureBox1.Location = new System.Drawing.Point(175, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 224;
            this.pictureBox1.TabStop = false;
            // 
            // pBEliminar
            // 
            this.pBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBEliminar.Image = global::DiseñoFinal.Properties.Resources.eliminar2;
            this.pBEliminar.Location = new System.Drawing.Point(212, 499);
            this.pBEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pBEliminar.Name = "pBEliminar";
            this.pBEliminar.Size = new System.Drawing.Size(63, 59);
            this.pBEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEliminar.TabIndex = 243;
            this.pBEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBEliminar, "Eliminar");
            this.pBEliminar.Click += new System.EventHandler(this.pBEliminar_Click);
            this.pBEliminar.MouseLeave += new System.EventHandler(this.pBEliminar_MouseLeave);
            this.pBEliminar.MouseHover += new System.EventHandler(this.pBEliminar_MouseHover);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(396, 12);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 206;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir2.MouseLeave += new System.EventHandler(this.pBSalir2_MouseLeave);
            this.pBSalir2.MouseHover += new System.EventHandler(this.pBSalir2_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 240;
            this.label6.Text = "Otro";
            // 
            // txtOtroTipo
            // 
            this.txtOtroTipo.Location = new System.Drawing.Point(246, 368);
            this.txtOtroTipo.Margin = new System.Windows.Forms.Padding(5);
            this.txtOtroTipo.MaxLength = 20;
            this.txtOtroTipo.Name = "txtOtroTipo";
            this.txtOtroTipo.Size = new System.Drawing.Size(153, 21);
            this.txtOtroTipo.TabIndex = 239;
            this.txtOtroTipo.TextChanged += new System.EventHandler(this.txtOtroTipo_TextChanged);
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
            this.cBTipo.Location = new System.Drawing.Point(10, 365);
            this.cBTipo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cBTipo.Name = "cBTipo";
            this.cBTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBTipo.Size = new System.Drawing.Size(205, 24);
            this.cBTipo.TabIndex = 4;
            this.cBTipo.Text = "-Elija una opción-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 234;
            this.label4.Text = "Tipo*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 66);
            this.panel1.TabIndex = 244;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ActualizarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.user;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(426, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBEliminar);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBActualizar);
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActualizarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.ActualizarTarjeta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBActualizar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOtroBanco;
        private System.Windows.Forms.ComboBox cBBanco;
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
        private System.Windows.Forms.PictureBox pBEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOtroTipo;
        private System.Windows.Forms.ComboBox cBTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
    }
}