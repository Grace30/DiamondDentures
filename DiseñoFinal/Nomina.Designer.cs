namespace DiseñoFinal
{
    partial class Nomina
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoAEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerBanco = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timerRequisiciones = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmarAsistenciaToolStripMenuItem,
            this.listadeAsistenciaToolStripMenuItem,
            this.asistenciaPorEmpleadoToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.pagoAEmpleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmarAsistenciaToolStripMenuItem
            // 
            this.firmarAsistenciaToolStripMenuItem.Name = "firmarAsistenciaToolStripMenuItem";
            this.firmarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.firmarAsistenciaToolStripMenuItem.Text = "Firmar Asistencia";
            this.firmarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.firmarAsistenciaToolStripMenuItem_Click);
            // 
            // listadeAsistenciaToolStripMenuItem
            // 
            this.listadeAsistenciaToolStripMenuItem.Name = "listadeAsistenciaToolStripMenuItem";
            this.listadeAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.listadeAsistenciaToolStripMenuItem.Text = "Lista de Asistencia";
            this.listadeAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.listadeAsistenciaToolStripMenuItem_Click);
            // 
            // asistenciaPorEmpleadoToolStripMenuItem
            // 
            this.asistenciaPorEmpleadoToolStripMenuItem.Name = "asistenciaPorEmpleadoToolStripMenuItem";
            this.asistenciaPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.asistenciaPorEmpleadoToolStripMenuItem.Text = "Asistencia Por Empleado";
            this.asistenciaPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.asistenciaPorEmpleadoToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.empleadosToolStripMenuItem.Text = "Listados de Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // pagoAEmpleadosToolStripMenuItem
            // 
            this.pagoAEmpleadosToolStripMenuItem.Name = "pagoAEmpleadosToolStripMenuItem";
            this.pagoAEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.pagoAEmpleadosToolStripMenuItem.Text = "Pago a Empleados";
            this.pagoAEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.pagoAEmpleadosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contabilidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 33);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(676, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProvedoresToolStripMenuItem,
            this.solicitudesToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // listadoDeProvedoresToolStripMenuItem
            // 
            this.listadoDeProvedoresToolStripMenuItem.Name = "listadoDeProvedoresToolStripMenuItem";
            this.listadoDeProvedoresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listadoDeProvedoresToolStripMenuItem.Text = "Listado de Provedores";
            this.listadoDeProvedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProvedoresToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem,
            this.materialToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo.Location = new System.Drawing.Point(508, 48);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(162, 30);
            this.lbl_Saldo.TabIndex = 5;
            this.lbl_Saldo.Text = "$0.00 MXN";
            this.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Saldo.Click += new System.EventHandler(this.lbl_Saldo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo en Banco";
            // 
            // timerBanco
            // 
            this.timerBanco.Interval = 1000;
            this.timerBanco.Tick += new System.EventHandler(this.timerBanco_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requisiciones (Doble click para abir requisición)";
            // 
            // timerRequisiciones
            // 
            this.timerRequisiciones.Interval = 1000;
            this.timerRequisiciones.Tick += new System.EventHandler(this.timerRequisiciones_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(373, 256);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(705, 130);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadeAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProvedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoAEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerRequisiciones;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}