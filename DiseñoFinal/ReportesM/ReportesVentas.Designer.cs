namespace DiseñoFinal
{
    partial class ReportesVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.dgvRepoVentas = new System.Windows.Forms.DataGridView();
            this.FolioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.btnVentasFecha = new System.Windows.Forms.Button();
            this.btnVentasEmpleado = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepoVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbEmpleado.Checked = true;
            this.rdbEmpleado.Location = new System.Drawing.Point(117, 19);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(90, 17);
            this.rdbEmpleado.TabIndex = 0;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Por empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(6, 19);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(71, 17);
            this.rdbFecha.TabIndex = 1;
            this.rdbFecha.Text = "Por fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // dgvRepoVentas
            // 
            this.dgvRepoVentas.AllowUserToAddRows = false;
            this.dgvRepoVentas.AllowUserToDeleteRows = false;
            this.dgvRepoVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepoVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRepoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRepoVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRepoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepoVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolioVenta,
            this.Empleado,
            this.IDPedido,
            this.Importe,
            this.Abono,
            this.Feria,
            this.FormaDePago,
            this.Descripcion,
            this.FechaPago});
            this.dgvRepoVentas.GridColor = System.Drawing.Color.Purple;
            this.dgvRepoVentas.Location = new System.Drawing.Point(12, 191);
            this.dgvRepoVentas.Name = "dgvRepoVentas";
            this.dgvRepoVentas.ReadOnly = true;
            this.dgvRepoVentas.RowHeadersVisible = false;
            this.dgvRepoVentas.Size = new System.Drawing.Size(841, 256);
            this.dgvRepoVentas.TabIndex = 171;
            // 
            // FolioVenta
            // 
            this.FolioVenta.HeaderText = "FolioVenta";
            this.FolioVenta.Name = "FolioVenta";
            this.FolioVenta.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "ID Pedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            this.Abono.ReadOnly = true;
            // 
            // Feria
            // 
            this.Feria.HeaderText = "Feria";
            this.Feria.Name = "Feria";
            this.Feria.ReadOnly = true;
            // 
            // FormaDePago
            // 
            this.FormaDePago.HeaderText = "Forma de pago";
            this.FormaDePago.Name = "FormaDePago";
            this.FormaDePago.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFecha);
            this.groupBox1.Controls.Add(this.rdbEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 47);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar ";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(292, 74);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(295, 20);
            this.txtNombreEmpleado.TabIndex = 173;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(314, 111);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(101, 20);
            this.dtFechaDesde.TabIndex = 174;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(472, 111);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(98, 20);
            this.dtFechaHasta.TabIndex = 175;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscar.Location = new System.Drawing.Point(370, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 176;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(264, 113);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 177;
            this.lblDesde.Text = "Desde: ";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(425, 113);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 13);
            this.lblHasta.TabIndex = 178;
            this.lblHasta.Text = "Hasta :";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(178, 77);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(100, 13);
            this.lblNombreE.TabIndex = 179;
            this.lblNombreE.Text = "Nombre Empleado :";
            // 
            // btnVentasFecha
            // 
            this.btnVentasFecha.BackColor = System.Drawing.Color.Silver;
            this.btnVentasFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasFecha.Location = new System.Drawing.Point(602, 111);
            this.btnVentasFecha.Name = "btnVentasFecha";
            this.btnVentasFecha.Size = new System.Drawing.Size(192, 26);
            this.btnVentasFecha.TabIndex = 181;
            this.btnVentasFecha.Text = "Ver Ventas por Fecha";
            this.btnVentasFecha.UseVisualStyleBackColor = false;
            this.btnVentasFecha.Click += new System.EventHandler(this.btnVentasFecha_Click);
            // 
            // btnVentasEmpleado
            // 
            this.btnVentasEmpleado.BackColor = System.Drawing.Color.Silver;
            this.btnVentasEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasEmpleado.Location = new System.Drawing.Point(602, 69);
            this.btnVentasEmpleado.Name = "btnVentasEmpleado";
            this.btnVentasEmpleado.Size = new System.Drawing.Size(192, 26);
            this.btnVentasEmpleado.TabIndex = 182;
            this.btnVentasEmpleado.Text = "Ver Ventas por Empleado";
            this.btnVentasEmpleado.UseVisualStyleBackColor = false;
            this.btnVentasEmpleado.Click += new System.EventHandler(this.btnVentasEmpleado_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Silver;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(370, 462);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(192, 26);
            this.btnTicket.TabIndex = 183;
            this.btnTicket.TabStop = false;
            this.btnTicket.Text = "Ver Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(871, 462);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 33);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 184;
            this.pBSalir.TabStop = false;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(745, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 216;
            this.lblUsuario.Text = "label1";
            // 
            // ReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 507);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnVentasEmpleado);
            this.Controls.Add(this.btnVentasFecha);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRepoVentas);
            this.Name = "ReportesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Ventas";
            this.Load += new System.EventHandler(this.ReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepoVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.DataGridView dgvRepoVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.Button btnVentasFecha;
        private System.Windows.Forms.Button btnVentasEmpleado;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.Label lblUsuario;
    }
}