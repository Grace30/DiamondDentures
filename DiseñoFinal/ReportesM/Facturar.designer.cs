namespace DiseñoFinal
{
    partial class Facturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBFacturar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.rbDentista = new System.Windows.Forms.RadioButton();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFacturar = new System.Windows.Forms.TextBox();
            this.pbBuscarPedido = new System.Windows.Forms.PictureBox();
            this.dgvFPedido = new System.Windows.Forms.DataGridView();
            this.NoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "FACTURAR ";
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = ((System.Drawing.Image)(resources.GetObject("pBSalir.Image")));
            this.pBSalir.Location = new System.Drawing.Point(579, 435);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(39, 37);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 169;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // pBFacturar
            // 
            this.pBFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBFacturar.Image = ((System.Drawing.Image)(resources.GetObject("pBFacturar.Image")));
            this.pBFacturar.Location = new System.Drawing.Point(300, 398);
            this.pBFacturar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBFacturar.Name = "pBFacturar";
            this.pBFacturar.Size = new System.Drawing.Size(65, 67);
            this.pBFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFacturar.TabIndex = 168;
            this.pBFacturar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBFacturar, "Elaborar Factura");
            this.pBFacturar.Click += new System.EventHandler(this.pBFacturar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 170;
            this.label2.Text = "Elegir pedido a facturar:";
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = ((System.Drawing.Image)(resources.GetObject("pBSalir2.Image")));
            this.pBSalir2.Location = new System.Drawing.Point(617, 13);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 171;
            this.pBSalir2.TabStop = false;
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            // 
            // rbDentista
            // 
            this.rbDentista.AutoSize = true;
            this.rbDentista.Location = new System.Drawing.Point(101, 22);
            this.rbDentista.Name = "rbDentista";
            this.rbDentista.Size = new System.Drawing.Size(149, 21);
            this.rbDentista.TabIndex = 172;
            this.rbDentista.TabStop = true;
            this.rbDentista.Text = "Nombre del Dentista";
            this.rbDentista.UseVisualStyleBackColor = true;
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Checked = true;
            this.rbPedido.Location = new System.Drawing.Point(6, 22);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(91, 21);
            this.rbPedido.TabIndex = 173;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "No. Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDentista);
            this.groupBox1.Controls.Add(this.rbPedido);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 56);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // txtFacturar
            // 
            this.txtFacturar.Location = new System.Drawing.Point(300, 164);
            this.txtFacturar.Name = "txtFacturar";
            this.txtFacturar.Size = new System.Drawing.Size(203, 20);
            this.txtFacturar.TabIndex = 175;
            this.txtFacturar.TextChanged += new System.EventHandler(this.txtFacturar_TextChanged);
            this.txtFacturar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturar_KeyPress);
            // 
            // pbBuscarPedido
            // 
            this.pbBuscarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarPedido.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarPedido.Image")));
            this.pbBuscarPedido.Location = new System.Drawing.Point(579, 99);
            this.pbBuscarPedido.Name = "pbBuscarPedido";
            this.pbBuscarPedido.Size = new System.Drawing.Size(39, 37);
            this.pbBuscarPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarPedido.TabIndex = 176;
            this.pbBuscarPedido.TabStop = false;
            this.pbBuscarPedido.Visible = false;
            this.pbBuscarPedido.Click += new System.EventHandler(this.pbBuscarPedido_Click);
            // 
            // dgvFPedido
            // 
            this.dgvFPedido.AllowUserToAddRows = false;
            this.dgvFPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvFPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvFPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoPedido,
            this.NombreD,
            this.DireccionD,
            this.TelefonoD,
            this.EstadoP});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFPedido.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFPedido.Location = new System.Drawing.Point(11, 249);
            this.dgvFPedido.MultiSelect = false;
            this.dgvFPedido.Name = "dgvFPedido";
            this.dgvFPedido.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFPedido.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvFPedido.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFPedido.Size = new System.Drawing.Size(607, 135);
            this.dgvFPedido.TabIndex = 177;
            this.dgvFPedido.CurrentCellChanged += new System.EventHandler(this.dgvFPedido_CurrentCellChanged);
            // 
            // NoPedido
            // 
            this.NoPedido.HeaderText = "No.Pedido";
            this.NoPedido.Name = "NoPedido";
            this.NoPedido.ReadOnly = true;
            // 
            // NombreD
            // 
            this.NombreD.HeaderText = "Nombre Dentista";
            this.NombreD.Name = "NombreD";
            this.NombreD.ReadOnly = true;
            // 
            // DireccionD
            // 
            this.DireccionD.HeaderText = "Dirección";
            this.DireccionD.Name = "DireccionD";
            this.DireccionD.ReadOnly = true;
            // 
            // TelefonoD
            // 
            this.TelefonoD.HeaderText = "Teléfono";
            this.TelefonoD.Name = "TelefonoD";
            this.TelefonoD.ReadOnly = true;
            // 
            // EstadoP
            // 
            this.EstadoP.HeaderText = "Estado";
            this.EstadoP.Name = "EstadoP";
            this.EstadoP.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 178;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 63);
            this.panel1.TabIndex = 179;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DiseñoFinal.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(509, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 180;
            this.toolTip1.SetToolTip(this.button1, "Buscar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 30);
            this.flowLayoutPanel1.TabIndex = 215;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::DiseñoFinal.Properties.Resources.User_Male_10px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(373, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Usuario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(648, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvFPedido);
            this.Controls.Add(this.pbBuscarPedido);
            this.Controls.Add(this.txtFacturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBFacturar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CrearFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBFacturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.RadioButton rbDentista;
        private System.Windows.Forms.RadioButton rbPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFacturar;
        private System.Windows.Forms.PictureBox pbBuscarPedido;
        private System.Windows.Forms.DataGridView dgvFPedido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
    }
}