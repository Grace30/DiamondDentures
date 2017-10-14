namespace DiseñoFinal
{
    partial class VistaPreviaNota
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
            this.VOficio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VOficio
            // 
            this.VOficio.ActiveViewIndex = -1;
            this.VOficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.VOficio.CachedPageNumberPerDoc = 10;
            this.VOficio.Cursor = System.Windows.Forms.Cursors.Default;
            this.VOficio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VOficio.Location = new System.Drawing.Point(0, 0);
            this.VOficio.Name = "VOficio";
            this.VOficio.ShowCloseButton = false;
            this.VOficio.ShowCopyButton = false;
            this.VOficio.ShowGotoPageButton = false;
            this.VOficio.ShowGroupTreeButton = false;
            this.VOficio.ShowLogo = false;
            this.VOficio.ShowPageNavigateButtons = false;
            this.VOficio.ShowParameterPanelButton = false;
            this.VOficio.ShowRefreshButton = false;
            this.VOficio.ShowTextSearchButton = false;
            this.VOficio.ShowZoomButton = false;
            this.VOficio.Size = new System.Drawing.Size(834, 543);
            this.VOficio.TabIndex = 2;
            this.VOficio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VistaPreviaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 543);
            this.Controls.Add(this.VOficio);
            this.Name = "VistaPreviaNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaPreviaNota";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VistaPreviaNota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VOficio;
    }
}