namespace DiseñoFinal.ReportesM
{
    partial class VerTickets
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
            this.btnTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepoVentas)).BeginInit();
            this.SuspendLayout();
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
            this.dgvRepoVentas.Location = new System.Drawing.Point(12, 104);
            this.dgvRepoVentas.Name = "dgvRepoVentas";
            this.dgvRepoVentas.ReadOnly = true;
            this.dgvRepoVentas.RowHeadersVisible = false;
            this.dgvRepoVentas.Size = new System.Drawing.Size(709, 244);
            this.dgvRepoVentas.TabIndex = 172;
            // 
            // FolioVenta
            // 
            this.FolioVenta.HeaderText = "FolioTicket";
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
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Silver;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(277, 354);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(192, 26);
            this.btnTicket.TabIndex = 184;
            this.btnTicket.TabStop = false;
            this.btnTicket.Text = "Ver Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 188;
            this.label1.Text = "TICKETS DE VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "Nombre Empleado o Folio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(308, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 194;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // VerTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.dgvRepoVentas);
            this.Name = "VerTickets";
            this.Text = "VerTickets";
            this.Load += new System.EventHandler(this.VerTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}