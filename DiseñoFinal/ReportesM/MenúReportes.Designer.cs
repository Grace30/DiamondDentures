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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Empleados");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Empleados Por Departamento");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pedidos");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ventas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Catálogo");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Inventario");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nómina");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Corte de caja");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Compras");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Salidas");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Listados", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Consultas");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Forma de pedido");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Oficio de confirmación");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Nota de terminación");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Facturas");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tickets");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Balance General");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Requisiciones");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Reportes", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
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
            this.pBSalir.Location = new System.Drawing.Point(232, 536);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 33);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 176;
            this.pBSalir.TabStop = false;
            this.pBSalir.WaitOnLoad = true;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click_1);
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
            treeNode1.Name = "NLEmpleados";
            treeNode1.Text = "Empleados";
            treeNode2.Name = "NLEmpleadosDepartamento";
            treeNode2.Text = "Empleados Por Departamento";
            treeNode3.Name = "NLClientes";
            treeNode3.Text = "Clientes";
            treeNode4.Name = "NLPedidos";
            treeNode4.Text = "Pedidos";
            treeNode5.Name = "NLVentas";
            treeNode5.Text = "Ventas";
            treeNode6.Name = "NLCatalogo";
            treeNode6.Text = "Catálogo";
            treeNode7.Name = "NLInventario";
            treeNode7.Text = "Inventario";
            treeNode8.Name = "NLNomina";
            treeNode8.Text = "Nómina";
            treeNode9.Name = "NLCorte";
            treeNode9.Text = "Corte de caja";
            treeNode10.Name = "NLCompras";
            treeNode10.Text = "Compras";
            treeNode11.Name = "NLProveedores";
            treeNode11.Text = "Proveedores";
            treeNode12.Name = "NLSalidas";
            treeNode12.Text = "Salidas";
            treeNode13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode13.Name = "NListados";
            treeNode13.Text = "Listados";
            treeNode14.BackColor = System.Drawing.Color.Azure;
            treeNode14.Name = "NConsultas";
            treeNode14.Text = "Consultas";
            treeNode15.Name = "NRForma";
            treeNode15.Text = "Forma de pedido";
            treeNode16.Name = "NROficio";
            treeNode16.Text = "Oficio de confirmación";
            treeNode17.Name = "NRNota";
            treeNode17.Text = "Nota de terminación";
            treeNode18.Name = "NRFacturas";
            treeNode18.Text = "Facturas";
            treeNode19.Name = "NRTicket";
            treeNode19.Text = "Tickets";
            treeNode20.Name = "NRBalance";
            treeNode20.Text = "Balance General";
            treeNode21.Name = "NRRequi";
            treeNode21.Text = "Requisiciones";
            treeNode22.BackColor = System.Drawing.Color.LightCoral;
            treeNode22.Name = "Nodo13";
            treeNode22.Text = "Reportes";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode22});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(270, 509);
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