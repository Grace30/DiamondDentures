namespace DiseñoFinal.ReportesM
{
    partial class VerFormasPedido
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
            this.btnForma = new System.Windows.Forms.Button();
            this.dgvFormas = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForma
            // 
            this.btnForma.BackColor = System.Drawing.Color.Silver;
            this.btnForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForma.Location = new System.Drawing.Point(273, 297);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(192, 26);
            this.btnForma.TabIndex = 185;
            this.btnForma.TabStop = false;
            this.btnForma.Text = "Ver Forma de Pedido";
            this.btnForma.UseVisualStyleBackColor = false;
            this.btnForma.Click += new System.EventHandler(this.btnForma_Click);
            // 
            // dgvFormas
            // 
            this.dgvFormas.AllowUserToAddRows = false;
            this.dgvFormas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFormas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NoPed,
            this.NombreDent,
            this.Fecha,
            this.NomEmp});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFormas.Location = new System.Drawing.Point(24, 94);
            this.dgvFormas.Name = "dgvFormas";
            this.dgvFormas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFormas.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvFormas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFormas.Size = new System.Drawing.Size(665, 135);
            this.dgvFormas.TabIndex = 186;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio Forma";
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
            // NomEmp
            // 
            this.NomEmp.HeaderText = "Realizado por:";
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            // 
            // VerFormasPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.dgvFormas);
            this.Controls.Add(this.btnForma);
            this.Name = "VerFormasPedido";
            this.Text = "VerFormasPedido";
            this.Load += new System.EventHandler(this.VerFormasPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.DataGridView dgvFormas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
    }
}