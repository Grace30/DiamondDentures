namespace DiseñoFinal.ReportesM
{
    partial class VerOficios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOficios = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConfirmacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOficio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOficios
            // 
            this.dgvOficios.AllowUserToAddRows = false;
            this.dgvOficios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvOficios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOficios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOficios.BackgroundColor = System.Drawing.Color.White;
            this.dgvOficios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOficios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NoPed,
            this.NombreDent,
            this.Fecha,
            this.FechaConfirmacion,
            this.NomEmp});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOficios.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOficios.Location = new System.Drawing.Point(12, 84);
            this.dgvOficios.Name = "dgvOficios";
            this.dgvOficios.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOficios.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvOficios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOficios.Size = new System.Drawing.Size(767, 135);
            this.dgvOficios.TabIndex = 187;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio Oficio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // NoPed
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.NoPed.DefaultCellStyle = dataGridViewCellStyle9;
            this.NoPed.HeaderText = "No. Pedido";
            this.NoPed.Name = "NoPed";
            this.NoPed.ReadOnly = true;
            // 
            // NombreDent
            // 
            this.NombreDent.HeaderText = "Nombre Dentista";
            this.NombreDent.Name = "NombreDent";
            this.NombreDent.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Emisión";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FechaConfirmacion
            // 
            this.FechaConfirmacion.HeaderText = "Fecha Confirmación";
            this.FechaConfirmacion.Name = "FechaConfirmacion";
            this.FechaConfirmacion.ReadOnly = true;
            // 
            // NomEmp
            // 
            this.NomEmp.HeaderText = "Confirmado por:";
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            // 
            // btnOficio
            // 
            this.btnOficio.BackColor = System.Drawing.Color.Silver;
            this.btnOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOficio.Location = new System.Drawing.Point(358, 300);
            this.btnOficio.Name = "btnOficio";
            this.btnOficio.Size = new System.Drawing.Size(192, 26);
            this.btnOficio.TabIndex = 188;
            this.btnOficio.TabStop = false;
            this.btnOficio.Text = "Ver Oficio de Confirmación";
            this.btnOficio.UseVisualStyleBackColor = false;
            this.btnOficio.Click += new System.EventHandler(this.btnOficio_Click);
            // 
            // VerOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 383);
            this.Controls.Add(this.btnOficio);
            this.Controls.Add(this.dgvOficios);
            this.Name = "VerOficios";
            this.Text = "VerOficios";
            this.Load += new System.EventHandler(this.VerOficios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOficios;
        private System.Windows.Forms.Button btnOficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConfirmacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
    }
}