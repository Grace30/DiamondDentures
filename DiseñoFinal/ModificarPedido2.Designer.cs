namespace DiseñoFinal
{
    partial class ModificarPedido2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPedido2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBCedula = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pBVerP = new System.Windows.Forms.PictureBox();
            this.pBAñadir = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cBMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAñadir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBCedula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 97);
            this.groupBox1.TabIndex = 220;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dentista";
            // 
            // cBCedula
            // 
            this.cBCedula.Enabled = false;
            this.cBCedula.FormattingEnabled = true;
            this.cBCedula.Location = new System.Drawing.Point(13, 47);
            this.cBCedula.Name = "cBCedula";
            this.cBCedula.Size = new System.Drawing.Size(245, 25);
            this.cBCedula.TabIndex = 208;
            this.cBCedula.Text = "0000000000001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 130;
            this.label7.Text = "Número de cédula*";
            // 
            // pBVerP
            // 
            this.pBVerP.BackColor = System.Drawing.Color.Transparent;
            this.pBVerP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBVerP.Image = global::DiseñoFinal.Properties.Resources.Ver_pedido1;
            this.pBVerP.Location = new System.Drawing.Point(207, 413);
            this.pBVerP.Name = "pBVerP";
            this.pBVerP.Size = new System.Drawing.Size(61, 59);
            this.pBVerP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBVerP.TabIndex = 219;
            this.pBVerP.TabStop = false;
            this.toolTip1.SetToolTip(this.pBVerP, "Pedido Total");
            this.pBVerP.Click += new System.EventHandler(this.pBVerP_Click);
            // 
            // pBAñadir
            // 
            this.pBAñadir.BackColor = System.Drawing.Color.Transparent;
            this.pBAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBAñadir.Image = global::DiseñoFinal.Properties.Resources.Carrito_añadir;
            this.pBAñadir.Location = new System.Drawing.Point(117, 413);
            this.pBAñadir.Name = "pBAñadir";
            this.pBAñadir.Size = new System.Drawing.Size(59, 59);
            this.pBAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAñadir.TabIndex = 218;
            this.pBAñadir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBAñadir, "Añadir Producto");
            this.pBAñadir.Click += new System.EventHandler(this.pBAñadir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigoMaterial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrecioUnitario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nCantidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cBMaterial);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cBProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 197);
            this.groupBox2.TabIndex = 217;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Location = new System.Drawing.Point(257, 101);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.ReadOnly = true;
            this.txtCodigoMaterial.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoMaterial.TabIndex = 220;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 219;
            this.label3.Text = "Codigo";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(257, 159);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubTotal.TabIndex = 218;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 217;
            this.label9.Text = "Sub Total $";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(14, 159);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioUnitario.TabIndex = 216;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 215;
            this.label6.Text = "Precio Unitario $";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(257, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 214;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 213;
            this.label2.Text = "Codigo";
            // 
            // nCantidad
            // 
            this.nCantidad.Location = new System.Drawing.Point(143, 160);
            this.nCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCantidad.Name = "nCantidad";
            this.nCantidad.Size = new System.Drawing.Size(51, 23);
            this.nCantidad.TabIndex = 212;
            this.nCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCantidad.ValueChanged += new System.EventHandler(this.nCantidad_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 211;
            this.label5.Text = "Cantidad*";
            // 
            // cBMaterial
            // 
            this.cBMaterial.FormattingEnabled = true;
            this.cBMaterial.Location = new System.Drawing.Point(13, 101);
            this.cBMaterial.Name = "cBMaterial";
            this.cBMaterial.Size = new System.Drawing.Size(230, 25);
            this.cBMaterial.TabIndex = 210;
            this.cBMaterial.SelectedIndexChanged += new System.EventHandler(this.cBMaterial_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 209;
            this.label4.Text = "Material*";
            // 
            // cBProducto
            // 
            this.cBProducto.FormattingEnabled = true;
            this.cBProducto.Location = new System.Drawing.Point(13, 45);
            this.cBProducto.Name = "cBProducto";
            this.cBProducto.Size = new System.Drawing.Size(230, 25);
            this.cBProducto.TabIndex = 208;
            this.cBProducto.SelectedIndexChanged += new System.EventHandler(this.cBProducto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 130;
            this.label8.Text = "Producto*";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(12, 71);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(65, 23);
            this.lblPedido.TabIndex = 216;
            this.lblPedido.Text = "#0001";
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(329, 429);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(51, 49);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 215;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DiseñoFinal.Properties.Resources.Pedido;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBSalir1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 58);
            this.panel1.TabIndex = 214;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DiseñoFinal.Properties.Resources.Logo_dd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(5, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 59);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "AÑADIR PRODUCTO";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pBSalir1
            // 
            this.pBSalir1.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir1.BackgroundImage = global::DiseñoFinal.Properties.Resources._1489837723_Close;
            this.pBSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBSalir1.Location = new System.Drawing.Point(360, 12);
            this.pBSalir1.Name = "pBSalir1";
            this.pBSalir1.Size = new System.Drawing.Size(36, 36);
            this.pBSalir1.TabIndex = 10;
            this.pBSalir1.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir1, "Salir");
            this.pBSalir1.Click += new System.EventHandler(this.pBSalir1_Click);
            // 
            // ModificarPedido2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBVerP);
            this.Controls.Add(this.pBAñadir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarPedido2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarPedido2";
            this.Load += new System.EventHandler(this.ModificarPedido2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBVerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAñadir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pBVerP;
        private System.Windows.Forms.PictureBox pBAñadir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSalir1;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}