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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOficios = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConfirmacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOficio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOficios
            // 
            this.dgvOficios.AllowUserToAddRows = false;
            this.dgvOficios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOficios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOficios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOficios.BackgroundColor = System.Drawing.Color.White;
            this.dgvOficios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOficios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NoPed,
            this.NombreDent,
            this.Fecha,
            this.FechaConfirmacion,
            this.NomEmp});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOficios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOficios.Location = new System.Drawing.Point(12, 84);
            this.dgvOficios.Name = "dgvOficios";
            this.dgvOficios.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOficios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOficios.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvOficios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOficios.Size = new System.Drawing.Size(767, 163);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.NoPed.DefaultCellStyle = dataGridViewCellStyle3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 189;
            this.label1.Text = "OFICIOS DE CONFIRMACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "Nombre Dentista o Folio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(379, 44);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 194;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // VerOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOficio);
            this.Controls.Add(this.dgvOficios);
            this.Name = "VerOficios";
            this.Text = "VerOficios";
            this.Load += new System.EventHandler(this.VerOficios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}