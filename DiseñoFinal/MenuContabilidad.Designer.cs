namespace DiseñoFinal
{
    partial class MenuContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuContabilidad));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.pBCrearFactura = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBAdministrar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCrearFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAdministrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 208;
            this.label2.Text = "MENÚ CONTABILIDAD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 75);
            this.panel1.TabIndex = 214;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DiseñoFinal.Properties.Resources.Logo_dd;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 213;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(383, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 209;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click_1);
            // 
            // pBCrearFactura
            // 
            this.pBCrearFactura.BackColor = System.Drawing.Color.Transparent;
            this.pBCrearFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBCrearFactura.Image = global::DiseñoFinal.Properties.Resources.fact;
            this.pBCrearFactura.Location = new System.Drawing.Point(237, 163);
            this.pBCrearFactura.Name = "pBCrearFactura";
            this.pBCrearFactura.Size = new System.Drawing.Size(97, 105);
            this.pBCrearFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCrearFactura.TabIndex = 212;
            this.pBCrearFactura.TabStop = false;
            this.toolTip1.SetToolTip(this.pBCrearFactura, "Facturar");
            this.pBCrearFactura.Click += new System.EventHandler(this.pBCrearFactura_Click);
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(350, 320);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(48, 45);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 211;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click_1);
            // 
            // pBAdministrar
            // 
            this.pBAdministrar.BackColor = System.Drawing.Color.Transparent;
            this.pBAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("pBAdministrar.Image")));
            this.pBAdministrar.Location = new System.Drawing.Point(107, 163);
            this.pBAdministrar.Name = "pBAdministrar";
            this.pBAdministrar.Size = new System.Drawing.Size(97, 105);
            this.pBAdministrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAdministrar.TabIndex = 210;
            this.pBAdministrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBAdministrar, "Facturas");
            this.pBAdministrar.Click += new System.EventHandler(this.pBAdministrar_Click);
            // 
            // MenuContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Captura1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 377);
            this.ControlBox = false;
            this.Controls.Add(this.pBCrearFactura);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBAdministrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuContabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuContabilidad";
            this.Load += new System.EventHandler(this.MenuContabilidad_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCrearFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAdministrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pBCrearFactura;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBAdministrar;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}