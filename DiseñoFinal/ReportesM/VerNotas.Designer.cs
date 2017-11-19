namespace DiseñoFinal.ReportesM
{
    partial class VerNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNota = new System.Windows.Forms.Button();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.Folio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPed1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomDent1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTerminaciónPedido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNota
            // 
            this.btnNota.BackColor = System.Drawing.Color.Silver;
            this.btnNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNota.Location = new System.Drawing.Point(304, 319);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(192, 26);
            this.btnNota.TabIndex = 189;
            this.btnNota.TabStop = false;
            this.btnNota.Text = "Ver Nota de Terminación";
            this.btnNota.UseVisualStyleBackColor = false;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // dgvNota
            // 
            this.dgvNota.AllowUserToAddRows = false;
            this.dgvNota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNota.BackgroundColor = System.Drawing.Color.White;
            this.dgvNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio1,
            this.NoPed1,
            this.NomDent1,
            this.Fecha1,
            this.FechaTerminaciónPedido1,
            this.NomEmp1,
            this.FechaEntrega1,
            this.Observaciones1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNota.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNota.GridColor = System.Drawing.Color.Black;
            this.dgvNota.Location = new System.Drawing.Point(12, 91);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNota.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNota.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvNota.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNota.Size = new System.Drawing.Size(824, 192);
            this.dgvNota.TabIndex = 190;
            // 
            // Folio1
            // 
            this.Folio1.HeaderText = "Folio Nota";
            this.Folio1.Name = "Folio1";
            this.Folio1.ReadOnly = true;
            // 
            // NoPed1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.NoPed1.DefaultCellStyle = dataGridViewCellStyle3;
            this.NoPed1.HeaderText = "No. Pedido";
            this.NoPed1.Name = "NoPed1";
            this.NoPed1.ReadOnly = true;
            // 
            // NomDent1
            // 
            this.NomDent1.HeaderText = "Nombre Dentista";
            this.NomDent1.Name = "NomDent1";
            this.NomDent1.ReadOnly = true;
            // 
            // Fecha1
            // 
            this.Fecha1.HeaderText = "Fecha Emisión";
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.ReadOnly = true;
            // 
            // FechaTerminaciónPedido1
            // 
            this.FechaTerminaciónPedido1.HeaderText = "Fecha Terminación";
            this.FechaTerminaciónPedido1.Name = "FechaTerminaciónPedido1";
            this.FechaTerminaciónPedido1.ReadOnly = true;
            // 
            // NomEmp1
            // 
            this.NomEmp1.HeaderText = "Terminado por:";
            this.NomEmp1.Name = "NomEmp1";
            this.NomEmp1.ReadOnly = true;
            // 
            // FechaEntrega1
            // 
            this.FechaEntrega1.HeaderText = "Fecha Entrega";
            this.FechaEntrega1.Name = "FechaEntrega1";
            this.FechaEntrega1.ReadOnly = true;
            // 
            // Observaciones1
            // 
            this.Observaciones1.HeaderText = "Observaciones";
            this.Observaciones1.Name = "Observaciones1";
            this.Observaciones1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 191;
            this.label1.Text = "NOTAS DE TERMINACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 193;
            this.label2.Text = "Nombre Dentista o Folio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(335, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 192;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(785, 338);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(51, 49);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 201;
            this.pBSalir.TabStop = false;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // VerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 387);
            this.ControlBox = false;
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.btnNota);
            this.Name = "VerNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerNotas";
            this.Load += new System.EventHandler(this.VerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dgvNotas;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NoPed;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NombreDent;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        //private System.Windows.Forms.DataGridViewTextBoxColumn FechaTerminaciónPedido;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        //private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        //private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPed1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomDent1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTerminaciónPedido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pBSalir;
    }
}