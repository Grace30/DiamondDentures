namespace DiseñoFinal
{
    partial class MenuContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuContabilidad));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.pbox_CrearFactura = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pbox_Administrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbox_Requisiciones = new System.Windows.Forms.PictureBox();
            this.pbox_Balance = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_SaldoActual = new System.Windows.Forms.Label();
            this.cajaConta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_CrearFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Administrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Requisiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Balance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 208;
            this.label2.Text = "MENÚ CONTABILIDAD";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 75);
            this.panel1.TabIndex = 214;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(564, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 214;
            this.lblUsuario.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DiseñoFinal.Properties.Resources.Logo_dd;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 213;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(612, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 209;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click_1);
            // 
            // pbox_CrearFactura
            // 
            this.pbox_CrearFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_CrearFactura.BackColor = System.Drawing.Color.Transparent;
            this.pbox_CrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_CrearFactura.Image = global::DiseñoFinal.Properties.Resources.fact2;
            this.pbox_CrearFactura.Location = new System.Drawing.Point(332, 164);
            this.pbox_CrearFactura.Name = "pbox_CrearFactura";
            this.pbox_CrearFactura.Size = new System.Drawing.Size(97, 105);
            this.pbox_CrearFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_CrearFactura.TabIndex = 212;
            this.pbox_CrearFactura.TabStop = false;
            this.toolTip1.SetToolTip(this.pbox_CrearFactura, "Facturar");
            this.pbox_CrearFactura.Click += new System.EventHandler(this.pBCrearFactura_Click);
            this.pbox_CrearFactura.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbox_CrearFactura.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pBSalir
            // 
            this.pBSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(579, 320);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(48, 45);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 211;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click_1);
            // 
            // pbox_Administrar
            // 
            this.pbox_Administrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_Administrar.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Administrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Administrar.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Administrar.Image")));
            this.pbox_Administrar.Location = new System.Drawing.Point(211, 164);
            this.pbox_Administrar.Name = "pbox_Administrar";
            this.pbox_Administrar.Size = new System.Drawing.Size(97, 105);
            this.pbox_Administrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Administrar.TabIndex = 210;
            this.pbox_Administrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbox_Administrar, "Facturas");
            this.pbox_Administrar.Click += new System.EventHandler(this.pBAdministrar_Click);
            this.pbox_Administrar.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbox_Administrar.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pbox_Requisiciones
            // 
            this.pbox_Requisiciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_Requisiciones.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Requisiciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Requisiciones.Image = global::DiseñoFinal.Properties.Resources.Request0;
            this.pbox_Requisiciones.Location = new System.Drawing.Point(93, 164);
            this.pbox_Requisiciones.Name = "pbox_Requisiciones";
            this.pbox_Requisiciones.Size = new System.Drawing.Size(97, 105);
            this.pbox_Requisiciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Requisiciones.TabIndex = 216;
            this.pbox_Requisiciones.TabStop = false;
            this.toolTip1.SetToolTip(this.pbox_Requisiciones, "Requisiciones");
            this.pbox_Requisiciones.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pbox_Requisiciones.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbox_Requisiciones.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // pbox_Balance
            // 
            this.pbox_Balance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_Balance.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Balance.Image = global::DiseñoFinal.Properties.Resources.Balance;
            this.pbox_Balance.Location = new System.Drawing.Point(446, 164);
            this.pbox_Balance.Name = "pbox_Balance";
            this.pbox_Balance.Size = new System.Drawing.Size(105, 105);
            this.pbox_Balance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Balance.TabIndex = 217;
            this.pbox_Balance.TabStop = false;
            this.toolTip1.SetToolTip(this.pbox_Balance, "Balance");
            this.pbox_Balance.Click += new System.EventHandler(this.pbox_Balance_Click);
            this.pbox_Balance.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pbox_Balance.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 215;
            this.button1.Text = "Nomina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_SaldoActual
            // 
            this.lbl_SaldoActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SaldoActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaldoActual.Location = new System.Drawing.Point(12, 80);
            this.lbl_SaldoActual.Name = "lbl_SaldoActual";
            this.lbl_SaldoActual.Size = new System.Drawing.Size(615, 20);
            this.lbl_SaldoActual.TabIndex = 215;
            this.lbl_SaldoActual.Text = "Saldo en banco: $1,000,000,000.00 MXN";
            this.lbl_SaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_SaldoActual.Click += new System.EventHandler(this.lbl_SaldoActual_Click);
            // 
            // cajaConta
            // 
            this.cajaConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cajaConta.BackColor = System.Drawing.Color.Transparent;
            this.cajaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaConta.Location = new System.Drawing.Point(12, 100);
            this.cajaConta.Name = "cajaConta";
            this.cajaConta.Size = new System.Drawing.Size(615, 20);
            this.cajaConta.TabIndex = 218;
            this.cajaConta.Text = "Saldo en caja Contabilidad: $1,000,000,000.00 MXN";
            this.cajaConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Captura1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 377);
            this.ControlBox = false;
            this.Controls.Add(this.cajaConta);
            this.Controls.Add(this.pbox_Balance);
            this.Controls.Add(this.lbl_SaldoActual);
            this.Controls.Add(this.pbox_Requisiciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbox_CrearFactura);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pbox_Administrar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuContabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuContabilidad";
            this.Load += new System.EventHandler(this.MenuContabilidad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_CrearFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Administrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Requisiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbox_CrearFactura;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pbox_Administrar;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbox_Requisiciones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_SaldoActual;
        private System.Windows.Forms.PictureBox pbox_Balance;
        private System.Windows.Forms.Label cajaConta;
    }
}