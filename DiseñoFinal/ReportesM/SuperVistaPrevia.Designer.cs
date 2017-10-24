namespace DiseñoFinal.ReportesM
{
    partial class SuperVistaPrevia
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
            this.VGeneral = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VGeneral
            // 
            this.VGeneral.ActiveViewIndex = -1;
            this.VGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.VGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VGeneral.Location = new System.Drawing.Point(0, 0);
            this.VGeneral.Name = "VGeneral";
            this.VGeneral.ReuseParameterValuesOnRefresh = true;
            this.VGeneral.ShowCloseButton = false;
            this.VGeneral.ShowCopyButton = false;
            this.VGeneral.ShowGotoPageButton = false;
            this.VGeneral.ShowGroupTreeButton = false;
            this.VGeneral.ShowLogo = false;
            this.VGeneral.ShowParameterPanelButton = false;
            this.VGeneral.Size = new System.Drawing.Size(987, 447);
            this.VGeneral.TabIndex = 0;
            this.VGeneral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SuperVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 447);
            this.Controls.Add(this.VGeneral);
            this.Name = "SuperVistaPrevia";
            this.Text = "SuperVistaPrevia";
            this.Load += new System.EventHandler(this.SuperVistaPrevia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected CrystalDecisions.Windows.Forms.CrystalReportViewer VGeneral;
    }
}