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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnForma = new System.Windows.Forms.Button();
            this.dgvFormas = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvFormas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFormas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFormas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NoPed,
            this.NombreDent,
            this.Fecha,
            this.NomEmp});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFormas.Location = new System.Drawing.Point(32, 93);
            this.dgvFormas.Name = "dgvFormas";
            this.dgvFormas.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFormas.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvFormas.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // NomEmp
            // 
            this.NomEmp.HeaderText = "Realizado por:";
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 187;
            this.label1.Text = "FORMAS DE PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(251, 44);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 188;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 189;
            this.label2.Text = "Nombre Dentista o Folio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VerFormasPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFormas);
            this.Controls.Add(this.btnForma);
            this.Name = "VerFormasPedido";
            this.Text = "VerFormasPedido";
            this.Load += new System.EventHandler(this.VerFormasPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.DataGridView dgvFormas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
    }
}