namespace DiseñoFinal
{
    partial class MenúReportes
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Empleados");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Pedidos");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Ventas");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Catálogo");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Inventario");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Nómina");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Corte de caja");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Compras");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Salidas");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Listados", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Consultas");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Forma de pedido");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Oficio de confirmación");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Nota de terminación");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Facturas");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Tickets");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Balance General");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Reportes", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39});
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(51, 363);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 33);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 176;
            this.pBSalir.TabStop = false;
            this.pBSalir.WaitOnLoad = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(179, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 216;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Ivory;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.Indent = 30;
            this.treeView1.ItemHeight = 25;
            this.treeView1.LineColor = System.Drawing.Color.Maroon;
            this.treeView1.Location = new System.Drawing.Point(-1, 22);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "NLEmpleados";
            treeNode21.Text = "Empleados";
            treeNode22.Name = "NLClientes";
            treeNode22.Text = "Clientes";
            treeNode23.Name = "NLPedidos";
            treeNode23.Text = "Pedidos";
            treeNode24.Name = "NLVentas";
            treeNode24.Text = "Ventas";
            treeNode25.Name = "NLCatalogo";
            treeNode25.Text = "Catálogo";
            treeNode26.Name = "NLInventario";
            treeNode26.Text = "Inventario";
            treeNode27.Name = "NLNomina";
            treeNode27.Text = "Nómina";
            treeNode28.Name = "NLCorte";
            treeNode28.Text = "Corte de caja";
            treeNode29.Name = "NLCompras";
            treeNode29.Text = "Compras";
            treeNode30.Name = "NLProveedores";
            treeNode30.Text = "Proveedores";
            treeNode31.Name = "NLSalidas";
            treeNode31.Text = "Salidas";
            treeNode32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode32.Name = "NListados";
            treeNode32.Text = "Listados";
            treeNode33.BackColor = System.Drawing.Color.Azure;
            treeNode33.Name = "NConsultas";
            treeNode33.Text = "Consultas";
            treeNode34.Name = "NRForma";
            treeNode34.Text = "Forma de pedido";
            treeNode35.Name = "NROficio";
            treeNode35.Text = "Oficio de confirmación";
            treeNode36.Name = "NRNota";
            treeNode36.Text = "Nota de terminación";
            treeNode37.Name = "NRFacturas";
            treeNode37.Text = "Facturas";
            treeNode38.Name = "NRTicket";
            treeNode38.Text = "Tickets";
            treeNode39.Name = "NRBalance";
            treeNode39.Text = "Balance General";
            treeNode40.BackColor = System.Drawing.Color.LightCoral;
            treeNode40.Name = "Nodo13";
            treeNode40.Text = "Reportes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode40});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(270, 547);
            this.treeView1.TabIndex = 217;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(275, 31);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1067, 538);
            this.crystalReportViewer1.TabIndex = 220;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // MenúReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 581);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.treeView1);
            this.Name = "MenúReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Menú";
            this.Load += new System.EventHandler(this.MenúReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TreeView treeView1;
        protected CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}