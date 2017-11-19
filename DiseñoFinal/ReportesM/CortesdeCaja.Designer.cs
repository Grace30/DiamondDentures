namespace DiseñoFinal.ReportesM
{
    partial class CortesdeCaja
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCortesEmpleado = new System.Windows.Forms.Button();
            this.btnCortesFecha = new System.Windows.Forms.Button();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFolio = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.dgvCortes = new System.Windows.Forms.DataGridView();
            this.FolioCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaChica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginnSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(781, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 227;
            this.lblUsuario.Text = "label1";
            // 
            // btnCortesEmpleado
            // 
            this.btnCortesEmpleado.BackColor = System.Drawing.Color.Silver;
            this.btnCortesEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortesEmpleado.Location = new System.Drawing.Point(367, 386);
            this.btnCortesEmpleado.Name = "btnCortesEmpleado";
            this.btnCortesEmpleado.Size = new System.Drawing.Size(192, 26);
            this.btnCortesEmpleado.TabIndex = 226;
            this.btnCortesEmpleado.Text = "Ver Corte por Empleado";
            this.btnCortesEmpleado.UseVisualStyleBackColor = false;
            this.btnCortesEmpleado.Click += new System.EventHandler(this.btnCortesEmpleado_Click);
            // 
            // btnCortesFecha
            // 
            this.btnCortesFecha.BackColor = System.Drawing.Color.Silver;
            this.btnCortesFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortesFecha.Location = new System.Drawing.Point(638, 112);
            this.btnCortesFecha.Name = "btnCortesFecha";
            this.btnCortesFecha.Size = new System.Drawing.Size(192, 26);
            this.btnCortesFecha.TabIndex = 225;
            this.btnCortesFecha.Text = "Ver Cortes por Fecha";
            this.btnCortesFecha.UseVisualStyleBackColor = false;
            this.btnCortesFecha.Click += new System.EventHandler(this.btnCortesFecha_Click);
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(214, 78);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(63, 13);
            this.lblNombreE.TabIndex = 224;
            this.lblNombreE.Text = "Folio Corte :";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(461, 114);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 13);
            this.lblHasta.TabIndex = 223;
            this.lblHasta.Text = "Hasta :";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(300, 114);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 222;
            this.lblDesde.Text = "Desde: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscar.Location = new System.Drawing.Point(406, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 221;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(508, 112);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(98, 20);
            this.dtFechaHasta.TabIndex = 220;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(350, 112);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(101, 20);
            this.dtFechaDesde.TabIndex = 219;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(328, 75);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(295, 20);
            this.txtDato.TabIndex = 218;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFolio);
            this.groupBox1.Controls.Add(this.rdbFecha);
            this.groupBox1.Location = new System.Drawing.Point(299, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 47);
            this.groupBox1.TabIndex = 217;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar ";
            // 
            // rdbFolio
            // 
            this.rdbFolio.AutoSize = true;
            this.rdbFolio.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbFolio.Location = new System.Drawing.Point(189, 19);
            this.rdbFolio.Name = "rdbFolio";
            this.rdbFolio.Size = new System.Drawing.Size(109, 17);
            this.rdbFolio.TabIndex = 2;
            this.rdbFolio.Text = "Por Folio de Corte";
            this.rdbFolio.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Checked = true;
            this.rdbFecha.Location = new System.Drawing.Point(68, 19);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(71, 17);
            this.rdbFecha.TabIndex = 1;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Por fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // dgvCortes
            // 
            this.dgvCortes.AllowUserToAddRows = false;
            this.dgvCortes.AllowUserToDeleteRows = false;
            this.dgvCortes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCortes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCortes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCortes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCortes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolioCorte,
            this.Fecha,
            this.Hora,
            this.Empleado,
            this.VentasTotales,
            this.CajaChica,
            this.CajaMaxima,
            this.Real,
            this.Banco,
            this.LoginnSupervisor,
            this.Comentarios});
            this.dgvCortes.GridColor = System.Drawing.Color.Purple;
            this.dgvCortes.Location = new System.Drawing.Point(12, 179);
            this.dgvCortes.Name = "dgvCortes";
            this.dgvCortes.ReadOnly = true;
            this.dgvCortes.RowHeadersVisible = false;
            this.dgvCortes.Size = new System.Drawing.Size(907, 187);
            this.dgvCortes.TabIndex = 228;
            // 
            // FolioCorte
            // 
            this.FolioCorte.HeaderText = "FolioCorte";
            this.FolioCorte.Name = "FolioCorte";
            this.FolioCorte.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // VentasTotales
            // 
            this.VentasTotales.HeaderText = "Ventas Totales";
            this.VentasTotales.Name = "VentasTotales";
            this.VentasTotales.ReadOnly = true;
            // 
            // CajaChica
            // 
            this.CajaChica.HeaderText = "Caja Chica";
            this.CajaChica.Name = "CajaChica";
            this.CajaChica.ReadOnly = true;
            // 
            // CajaMaxima
            // 
            this.CajaMaxima.HeaderText = "Caja Máxima";
            this.CajaMaxima.Name = "CajaMaxima";
            this.CajaMaxima.ReadOnly = true;
            // 
            // Real
            // 
            this.Real.HeaderText = "Ventas Efectivo";
            this.Real.Name = "Real";
            this.Real.ReadOnly = true;
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Ventas Crédito";
            this.Banco.Name = "Banco";
            this.Banco.ReadOnly = true;
            // 
            // LoginnSupervisor
            // 
            this.LoginnSupervisor.HeaderText = "Supervisor";
            this.LoginnSupervisor.Name = "LoginnSupervisor";
            this.LoginnSupervisor.ReadOnly = true;
            // 
            // Comentarios
            // 
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(855, 412);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(51, 49);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 229;
            this.pBSalir.TabStop = false;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // CortesdeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 463);
            this.ControlBox = false;
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.dgvCortes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCortesEmpleado);
            this.Controls.Add(this.btnCortesFecha);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.groupBox1);
            this.Name = "CortesdeCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CortesdeCaja";
            this.Load += new System.EventHandler(this.CortesdeCaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCortes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCortesEmpleado;
        private System.Windows.Forms.Button btnCortesFecha;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFolio;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.DataGridView dgvCortes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaChica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Real;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginnSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.PictureBox pBSalir;
    }
}