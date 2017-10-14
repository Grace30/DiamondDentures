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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadeAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmarAsistenciaToolStripMenuItem,
            this.listadeAsistenciaToolStripMenuItem,
            this.asistenciaPorEmpleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
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
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 392);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadeAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaPorEmpleadoToolStripMenuItem;
    }
}