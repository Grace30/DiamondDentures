namespace DiseñoFinal
{
    partial class FabricarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmado = new System.Windows.Forms.Button();
            this.btnEnProceso = new System.Windows.Forms.Button();
            this.btnPorConfirmar = new System.Windows.Forms.Button();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFabricar = new System.Windows.Forms.PictureBox();
            this.pbNotaTerm = new System.Windows.Forms.PictureBox();
            this.btnFinalizado = new System.Windows.Forms.Button();
            this.btnSinElaborar = new System.Windows.Forms.Button();
            this.btnFacturado = new System.Windows.Forms.Button();
            this.cbLaboratorista = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.llRegistrar = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEntregado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFabricar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotaTerm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Estado,
            this.Fecha,
            this.Laboratorista,
            this.Urgente});
            this.dgvPedidos.Location = new System.Drawing.Point(29, 198);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(558, 217);
            this.dgvPedidos.TabIndex = 248;
            this.dgvPedidos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellEndEdit);
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Código del Pedido";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 80;
            // 
            // Estado
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.Width = 125;
            // 
            // Fecha
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha de Entrega";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 75;
            // 
            // Laboratorista
            // 
            this.Laboratorista.Frozen = true;
            this.Laboratorista.HeaderText = "Laboratorista";
            this.Laboratorista.MaxInputLength = 40;
            this.Laboratorista.Name = "Laboratorista";
            this.Laboratorista.ReadOnly = true;
            this.Laboratorista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Laboratorista.Width = 175;
            // 
            // Urgente
            // 
            this.Urgente.Frozen = true;
            this.Urgente.HeaderText = "Urgente";
            this.Urgente.Name = "Urgente";
            this.Urgente.ReadOnly = true;
            // 
            // btnConfirmado
            // 
            this.btnConfirmado.BackColor = System.Drawing.Color.Cyan;
            this.btnConfirmado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmado.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmado.Location = new System.Drawing.Point(608, 218);
            this.btnConfirmado.Name = "btnConfirmado";
            this.btnConfirmado.Size = new System.Drawing.Size(113, 23);
            this.btnConfirmado.TabIndex = 246;
            this.btnConfirmado.Text = "CONFIRMADO";
            this.btnConfirmado.UseVisualStyleBackColor = false;
            this.btnConfirmado.Click += new System.EventHandler(this.btnConfirmado_Click);
            // 
            // btnEnProceso
            // 
            this.btnEnProceso.BackColor = System.Drawing.Color.Orange;
            this.btnEnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnProceso.ForeColor = System.Drawing.Color.Black;
            this.btnEnProceso.Location = new System.Drawing.Point(608, 247);
            this.btnEnProceso.Name = "btnEnProceso";
            this.btnEnProceso.Size = new System.Drawing.Size(113, 23);
            this.btnEnProceso.TabIndex = 247;
            this.btnEnProceso.Text = "EN PROCESO";
            this.btnEnProceso.UseVisualStyleBackColor = false;
            this.btnEnProceso.Click += new System.EventHandler(this.btnEnProceso_Click);
            // 
            // btnPorConfirmar
            // 
            this.btnPorConfirmar.BackColor = System.Drawing.Color.Silver;
            this.btnPorConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnPorConfirmar.Location = new System.Drawing.Point(608, 276);
            this.btnPorConfirmar.Name = "btnPorConfirmar";
            this.btnPorConfirmar.Size = new System.Drawing.Size(113, 23);
            this.btnPorConfirmar.TabIndex = 244;
            this.btnPorConfirmar.Text = "POR CONFIRMAR ";
            this.btnPorConfirmar.UseVisualStyleBackColor = false;
            this.btnPorConfirmar.Click += new System.EventHandler(this.btnPorConfirmar_Click);
            // 
            // btnUrgente
            // 
            this.btnUrgente.BackColor = System.Drawing.Color.Red;
            this.btnUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgente.ForeColor = System.Drawing.Color.Black;
            this.btnUrgente.Location = new System.Drawing.Point(608, 189);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(113, 23);
            this.btnUrgente.TabIndex = 245;
            this.btnUrgente.Text = "URGENTE";
            this.btnUrgente.UseVisualStyleBackColor = false;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 70);
            this.panel1.TabIndex = 243;
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(701, 10);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 26;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "FABRICAR PRODUCTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(29, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 102);
            this.groupBox1.TabIndex = 242;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código del Pedido";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DiseñoFinal.Properties.Resources.Buscar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(267, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Buscar");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 20);
            this.textBox3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(650, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.TabIndex = 249;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Regresar");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbFabricar
            // 
            this.pbFabricar.BackgroundImage = global::DiseñoFinal.Properties.Resources.Fabricar1;
            this.pbFabricar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFabricar.Location = new System.Drawing.Point(35, 437);
            this.pbFabricar.Name = "pbFabricar";
            this.pbFabricar.Size = new System.Drawing.Size(58, 58);
            this.pbFabricar.TabIndex = 250;
            this.pbFabricar.TabStop = false;
            this.toolTip1.SetToolTip(this.pbFabricar, "Fabricar");
            this.pbFabricar.Click += new System.EventHandler(this.pbFabricar_Click);
            // 
            // pbNotaTerm
            // 
            this.pbNotaTerm.BackgroundImage = global::DiseñoFinal.Properties.Resources.Nota_de_terminación;
            this.pbNotaTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNotaTerm.Location = new System.Drawing.Point(175, 437);
            this.pbNotaTerm.Name = "pbNotaTerm";
            this.pbNotaTerm.Size = new System.Drawing.Size(58, 58);
            this.pbNotaTerm.TabIndex = 251;
            this.pbNotaTerm.TabStop = false;
            this.pbNotaTerm.Click += new System.EventHandler(this.pbNotaTerm_Click);
            // 
            // btnFinalizado
            // 
            this.btnFinalizado.BackColor = System.Drawing.Color.Lime;
            this.btnFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizado.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizado.Location = new System.Drawing.Point(608, 334);
            this.btnFinalizado.Name = "btnFinalizado";
            this.btnFinalizado.Size = new System.Drawing.Size(113, 23);
            this.btnFinalizado.TabIndex = 252;
            this.btnFinalizado.Text = "FINALIZADO";
            this.btnFinalizado.UseVisualStyleBackColor = false;
            this.btnFinalizado.Click += new System.EventHandler(this.btnFinalizado_Click);
            // 
            // btnSinElaborar
            // 
            this.btnSinElaborar.BackColor = System.Drawing.Color.Transparent;
            this.btnSinElaborar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinElaborar.ForeColor = System.Drawing.Color.Black;
            this.btnSinElaborar.Location = new System.Drawing.Point(608, 305);
            this.btnSinElaborar.Name = "btnSinElaborar";
            this.btnSinElaborar.Size = new System.Drawing.Size(113, 23);
            this.btnSinElaborar.TabIndex = 253;
            this.btnSinElaborar.Text = "SIN ELABORAR";
            this.btnSinElaborar.UseVisualStyleBackColor = false;
            this.btnSinElaborar.Click += new System.EventHandler(this.btnSinElaborar_Click);
            // 
            // btnFacturado
            // 
            this.btnFacturado.BackColor = System.Drawing.Color.Yellow;
            this.btnFacturado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturado.ForeColor = System.Drawing.Color.Black;
            this.btnFacturado.Location = new System.Drawing.Point(608, 363);
            this.btnFacturado.Name = "btnFacturado";
            this.btnFacturado.Size = new System.Drawing.Size(113, 23);
            this.btnFacturado.TabIndex = 254;
            this.btnFacturado.Text = "FACTURADO";
            this.btnFacturado.UseVisualStyleBackColor = false;
            this.btnFacturado.Click += new System.EventHandler(this.btnFacturado_Click);
            // 
            // cbLaboratorista
            // 
            this.cbLaboratorista.Enabled = false;
            this.cbLaboratorista.FormattingEnabled = true;
            this.cbLaboratorista.Location = new System.Drawing.Point(285, 456);
            this.cbLaboratorista.Name = "cbLaboratorista";
            this.cbLaboratorista.Size = new System.Drawing.Size(161, 21);
            this.cbLaboratorista.TabIndex = 256;
            this.cbLaboratorista.SelectedIndexChanged += new System.EventHandler(this.cbLaboratorista_SelectedIndexChanged);
            this.cbLaboratorista.Click += new System.EventHandler(this.cbLaboratorista_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(282, 437);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 255;
            this.label17.Text = "Cambiar Laboratorista";
            // 
            // llRegistrar
            // 
            this.llRegistrar.AutoSize = true;
            this.llRegistrar.Enabled = false;
            this.llRegistrar.Location = new System.Drawing.Point(282, 480);
            this.llRegistrar.Name = "llRegistrar";
            this.llRegistrar.Size = new System.Drawing.Size(113, 13);
            this.llRegistrar.TabIndex = 257;
            this.llRegistrar.TabStop = true;
            this.llRegistrar.Text = "Registrar Laboratorista";
            this.llRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegistrar_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(531, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 44);
            this.groupBox2.TabIndex = 258;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificación ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 212;
            this.label5.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(66, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 13);
            this.lblUsuario.TabIndex = 212;
            this.lblUsuario.Text = "User123";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(608, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 259;
            this.button1.Text = "CANCELADO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 260;
            this.label12.Text = "Nota de Terminación";
            // 
            // btnEntregado
            // 
            this.btnEntregado.BackColor = System.Drawing.Color.Fuchsia;
            this.btnEntregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregado.ForeColor = System.Drawing.Color.Black;
            this.btnEntregado.Location = new System.Drawing.Point(608, 392);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Size = new System.Drawing.Size(113, 23);
            this.btnEntregado.TabIndex = 254;
            this.btnEntregado.Text = "ENTREGADO";
            this.btnEntregado.UseVisualStyleBackColor = false;
            this.btnEntregado.Click += new System.EventHandler(this.btnFacturado_Click);
            // 
            // FabricarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.u1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(733, 517);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.llRegistrar);
            this.Controls.Add(this.cbLaboratorista);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSinElaborar);
            this.Controls.Add(this.btnEntregado);
            this.Controls.Add(this.btnFacturado);
            this.Controls.Add(this.btnFinalizado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbFabricar);
            this.Controls.Add(this.pbNotaTerm);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnConfirmado);
            this.Controls.Add(this.btnEnProceso);
            this.Controls.Add(this.btnPorConfirmar);
            this.Controls.Add(this.btnUrgente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FabricarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FabricarProducto";
            this.Load += new System.EventHandler(this.FabricarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFabricar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotaTerm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnConfirmado;
        private System.Windows.Forms.Button btnEnProceso;
        private System.Windows.Forms.Button btnPorConfirmar;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbFabricar;
        private System.Windows.Forms.PictureBox pbNotaTerm;
        private System.Windows.Forms.Button btnFinalizado;
        private System.Windows.Forms.Button btnSinElaborar;
        private System.Windows.Forms.Button btnFacturado;
        private System.Windows.Forms.ComboBox cbLaboratorista;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgente;
        private System.Windows.Forms.LinkLabel llRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEntregado;
    }
}