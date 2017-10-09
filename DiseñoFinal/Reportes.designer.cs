namespace DiseñoFinal
{
    partial class Reportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBForma = new System.Windows.Forms.PictureBox();
            this.pBOficio = new System.Windows.Forms.PictureBox();
            this.pBNota = new System.Windows.Forms.PictureBox();
            this.pBFactura = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDentista = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBForma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOficio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(280, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "REPORTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 169;
            this.label3.Text = "Lista de pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoPedido,
            this.NombreD,
            this.DireccionD,
            this.TelefonoD,
            this.EstadoP});
            this.dgvPedidos.Location = new System.Drawing.Point(25, 242);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(604, 132);
            this.dgvPedidos.TabIndex = 170;
            this.dgvPedidos.CurrentCellChanged += new System.EventHandler(this.dgvPedidos_CurrentCellChanged);
            // 
            // NoPedido
            // 
            this.NoPedido.HeaderText = "No. Pedido";
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
            // pBForma
            // 
            this.pBForma.BackColor = System.Drawing.Color.Transparent;
            this.pBForma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBForma.Image = global::DiseñoFinal.Properties.Resources.forma_de_pedido;
            this.pBForma.Location = new System.Drawing.Point(107, 443);
            this.pBForma.Name = "pBForma";
            this.pBForma.Size = new System.Drawing.Size(71, 67);
            this.pBForma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBForma.TabIndex = 171;
            this.pBForma.TabStop = false;
            this.pBForma.Click += new System.EventHandler(this.pBForma_Click);
            // 
            // pBOficio
            // 
            this.pBOficio.BackColor = System.Drawing.Color.Transparent;
            this.pBOficio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBOficio.Image = global::DiseñoFinal.Properties.Resources.oficio_de_confirmación;
            this.pBOficio.Location = new System.Drawing.Point(238, 443);
            this.pBOficio.Name = "pBOficio";
            this.pBOficio.Size = new System.Drawing.Size(71, 67);
            this.pBOficio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBOficio.TabIndex = 172;
            this.pBOficio.TabStop = false;
            this.pBOficio.Click += new System.EventHandler(this.pBOficio_Click);
            // 
            // pBNota
            // 
            this.pBNota.BackColor = System.Drawing.Color.Transparent;
            this.pBNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBNota.Image = global::DiseñoFinal.Properties.Resources.Nota_de_terminación;
            this.pBNota.Location = new System.Drawing.Point(374, 443);
            this.pBNota.Name = "pBNota";
            this.pBNota.Size = new System.Drawing.Size(71, 67);
            this.pBNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBNota.TabIndex = 173;
            this.pBNota.TabStop = false;
            this.pBNota.Click += new System.EventHandler(this.pBNota_Click);
            // 
            // pBFactura
            // 
            this.pBFactura.BackColor = System.Drawing.Color.Transparent;
            this.pBFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBFactura.Image = global::DiseñoFinal.Properties.Resources.factura1;
            this.pBFactura.Location = new System.Drawing.Point(501, 443);
            this.pBFactura.Name = "pBFactura";
            this.pBFactura.Size = new System.Drawing.Size(71, 67);
            this.pBFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFactura.TabIndex = 174;
            this.pBFactura.TabStop = false;
            this.pBFactura.Click += new System.EventHandler(this.pBFactura_Click);
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(609, 512);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 33);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 175;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(634, 11);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 176;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::DiseñoFinal.Properties.Resources.Logo_dd;
            this.pictureBox4.Location = new System.Drawing.Point(3, 1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 207;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::DiseñoFinal.Properties.Resources.reportes;
            this.pictureBox5.Location = new System.Drawing.Point(287, 78);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 208;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::DiseñoFinal.Properties.Resources.search;
            this.pictureBox6.Location = new System.Drawing.Point(607, 78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 211;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(303, 171);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar.TabIndex = 210;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDentista);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 54);
            this.groupBox1.TabIndex = 209;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbDentista
            // 
            this.rbDentista.AutoSize = true;
            this.rbDentista.Location = new System.Drawing.Point(101, 22);
            this.rbDentista.Name = "rbDentista";
            this.rbDentista.Size = new System.Drawing.Size(149, 21);
            this.rbDentista.TabIndex = 172;
            this.rbDentista.Text = "Nombre del Dentista";
            this.rbDentista.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 173;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No. Pedido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 212;
            this.label1.Text = "Forma de Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 213;
            this.label4.Text = "Oficio de Confirmación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 214;
            this.label5.Text = "Nota de terminación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 215;
            this.label6.Text = "Factura";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 70);
            this.panel1.TabIndex = 216;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DiseñoFinal.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(564, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 217;
            this.toolTip1.SetToolTip(this.button1, "Buscar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.user;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 557);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBFactura);
            this.Controls.Add(this.pBNota);
            this.Controls.Add(this.pBOficio);
            this.Controls.Add(this.pBForma);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBForma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBOficio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.PictureBox pBForma;
        private System.Windows.Forms.PictureBox pBOficio;
        private System.Windows.Forms.PictureBox pBNota;
        private System.Windows.Forms.PictureBox pBFactura;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDentista;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}