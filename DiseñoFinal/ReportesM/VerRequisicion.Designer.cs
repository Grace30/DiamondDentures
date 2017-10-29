namespace DiseñoFinal.ReportesM
{
    partial class VerRequisicion
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
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.IDRequisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnreq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReq
            // 
            this.dgvReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReq.BackgroundColor = System.Drawing.Color.White;
            this.dgvReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRequisicion,
            this.Empleado,
            this.CantidadTotal,
            this.FechadePedido,
            this.Surtido});
            this.dgvReq.GridColor = System.Drawing.Color.SlateGray;
            this.dgvReq.Location = new System.Drawing.Point(53, 88);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.RowHeadersVisible = false;
            this.dgvReq.Size = new System.Drawing.Size(618, 201);
            this.dgvReq.TabIndex = 1;
            // 
            // IDRequisicion
            // 
            this.IDRequisicion.HeaderText = "IDRequisicion";
            this.IDRequisicion.Name = "IDRequisicion";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // CantidadTotal
            // 
            this.CantidadTotal.HeaderText = "Cantidad";
            this.CantidadTotal.Name = "CantidadTotal";
            // 
            // FechadePedido
            // 
            this.FechadePedido.HeaderText = "Fecha";
            this.FechadePedido.Name = "FechadePedido";
            // 
            // Surtido
            // 
            this.Surtido.HeaderText = "Surtido";
            this.Surtido.Name = "Surtido";
            // 
            // btnreq
            // 
            this.btnreq.Location = new System.Drawing.Point(298, 331);
            this.btnreq.Name = "btnreq";
            this.btnreq.Size = new System.Drawing.Size(153, 23);
            this.btnreq.TabIndex = 2;
            this.btnreq.Text = "Ver Requisición";
            this.btnreq.UseVisualStyleBackColor = true;
            this.btnreq.Click += new System.EventHandler(this.btnreq_Click);
            // 
            // VerRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 366);
            this.Controls.Add(this.btnreq);
            this.Controls.Add(this.dgvReq);
            this.Name = "VerRequisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerRequisicion";
            this.Load += new System.EventHandler(this.VerRequisicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surtido;
        private System.Windows.Forms.Button btnreq;
    }
}