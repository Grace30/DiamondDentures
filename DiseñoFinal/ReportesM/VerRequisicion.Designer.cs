﻿namespace DiseñoFinal.ReportesM
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
            this.FechaAutorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSurtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnreq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
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
            this.Surtido,
            this.FechaAutorizado,
            this.FechaSurtido,
            this.Proveedor});
            this.dgvReq.GridColor = System.Drawing.Color.SlateGray;
            this.dgvReq.Location = new System.Drawing.Point(12, 95);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.RowHeadersVisible = false;
            this.dgvReq.Size = new System.Drawing.Size(773, 201);
            this.dgvReq.TabIndex = 1;
            this.dgvReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReq_CellContentClick);
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
            // FechaAutorizado
            // 
            this.FechaAutorizado.HeaderText = "Fecha Autorización";
            this.FechaAutorizado.Name = "FechaAutorizado";
            // 
            // FechaSurtido
            // 
            this.FechaSurtido.HeaderText = "Fecha Surtido";
            this.FechaSurtido.Name = "FechaSurtido";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // btnreq
            // 
            this.btnreq.Location = new System.Drawing.Point(332, 314);
            this.btnreq.Name = "btnreq";
            this.btnreq.Size = new System.Drawing.Size(153, 23);
            this.btnreq.TabIndex = 2;
            this.btnreq.Text = "Ver Requisición";
            this.btnreq.UseVisualStyleBackColor = true;
            this.btnreq.Click += new System.EventHandler(this.btnreq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 188;
            this.label1.Text = "REQUISICIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 16);
            this.label2.TabIndex = 197;
            this.label2.Text = "IDRequisición o Nombre Empleado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(370, 49);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 196;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(775, 314);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(51, 49);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 198;
            this.pBSalir.TabStop = false;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // VerRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 366);
            this.ControlBox = false;
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreq);
            this.Controls.Add(this.dgvReq);
            this.Name = "VerRequisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerRequisicion";
            this.Load += new System.EventHandler(this.VerRequisicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.Button btnreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surtido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAutorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSurtido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pBSalir;
    }
}