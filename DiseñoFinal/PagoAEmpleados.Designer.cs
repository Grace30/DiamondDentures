﻿namespace DiseñoFinal
{
    partial class PagoAEmpleados
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasTrabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.Usuario,
            this.IdPago,
            this.SalarioDiario,
            this.DiasTrabajados,
            this.Sueldo,
            this.TasaISR,
            this.CuotaISR,
            this.APagar,
            this.Pagar});
            this.data1.Location = new System.Drawing.Point(2, 75);
            this.data1.Name = "dataGridView1";
            this.data1.Size = new System.Drawing.Size(952, 350);
            this.data1.TabIndex = 0;
            this.data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.data1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mes.Location = new System.Drawing.Point(402, 47);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(103, 20);
            this.lbl_Mes.TabIndex = 3;
            this.lbl_Mes.Text = "Diciembre";
            this.lbl_Mes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Seleccionar todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "PAGAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox1.Location = new System.Drawing.Point(52, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // IdPago
            // 
            this.IdPago.HeaderText = "Id Pago";
            this.IdPago.Name = "IdPago";
            this.IdPago.ReadOnly = true;
            // 
            // SalarioDiario
            // 
            this.SalarioDiario.HeaderText = "Salario Diario";
            this.SalarioDiario.Name = "SalarioDiario";
            this.SalarioDiario.ReadOnly = true;
            // 
            // DiasTrabajados
            // 
            this.DiasTrabajados.HeaderText = "Dias Trabajados";
            this.DiasTrabajados.Name = "DiasTrabajados";
            this.DiasTrabajados.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // TasaISR
            // 
            this.TasaISR.HeaderText = "Tasa ISR";
            this.TasaISR.Name = "TasaISR";
            this.TasaISR.ReadOnly = true;
            // 
            // CuotaISR
            // 
            this.CuotaISR.HeaderText = "CuotaISR";
            this.CuotaISR.Name = "CuotaISR";
            this.CuotaISR.ReadOnly = true;
            // 
            // APagar
            // 
            this.APagar.HeaderText = "A Pagar";
            this.APagar.Name = "APagar";
            this.APagar.ReadOnly = true;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            this.Pagar.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(847, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Anular selección";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "                                          ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(511, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(360, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PagoAEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(966, 479);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data1);
            this.Name = "PagoAEmpleados";
            this.Text = "PagoAEmpleados";
            this.Load += new System.EventHandler(this.PagoAEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasTrabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn APagar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}