namespace DiseñoFinal
{
    partial class VistaPreviaForma
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
            this.VForma = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VForma
            // 
            this.VForma.ActiveViewIndex = -1;
            this.VForma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VForma.Cursor = System.Windows.Forms.Cursors.Default;
            this.VForma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VForma.Location = new System.Drawing.Point(0, 0);
            this.VForma.Name = "VForma";
            this.VForma.ShowCloseButton = false;
            this.VForma.ShowCopyButton = false;
            this.VForma.ShowGotoPageButton = false;
            this.VForma.ShowGroupTreeButton = false;
            this.VForma.ShowLogo = false;
            this.VForma.ShowPageNavigateButtons = false;
            this.VForma.ShowParameterPanelButton = false;
            this.VForma.ShowRefreshButton = false;
            this.VForma.ShowTextSearchButton = false;
            this.VForma.ShowZoomButton = false;
            this.VForma.Size = new System.Drawing.Size(739, 457);
            this.VForma.TabIndex = 3;
            this.VForma.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.VForma.Load += new System.EventHandler(this.VOficio_Load);
            // 
            // VistaPreviaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.VForma);
            this.Name = "VistaPreviaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaPreviaForma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VistaPreviaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VForma;
    }
}