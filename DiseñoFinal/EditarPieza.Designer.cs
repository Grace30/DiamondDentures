namespace DiseñoFinal
{
    partial class EditarPieza
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
            this.pbBorrarPieza = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTiempo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbActualizarPieza = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodPieza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrarPieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPieza)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBorrarPieza
            // 
            this.pbBorrarPieza.BackgroundImage = global::DiseñoFinal.Properties.Resources._1489841508_trash_bin;
            this.pbBorrarPieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBorrarPieza.Location = new System.Drawing.Point(135, 197);
            this.pbBorrarPieza.Name = "pbBorrarPieza";
            this.pbBorrarPieza.Size = new System.Drawing.Size(64, 75);
            this.pbBorrarPieza.TabIndex = 81;
            this.pbBorrarPieza.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBorrarPieza, "Eliminar Pieza");
            this.pbBorrarPieza.Click += new System.EventHandler(this.pbBorrarPieza_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(313, 120);
            this.txtPrecio.MaxLength = 7;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "(dias)";
            // 
            // nudTiempo
            // 
            this.nudTiempo.Location = new System.Drawing.Point(187, 121);
            this.nudTiempo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudTiempo.Name = "nudTiempo";
            this.nudTiempo.Size = new System.Drawing.Size(47, 20);
            this.nudTiempo.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 59);
            this.panel1.TabIndex = 79;
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(464, 12);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 26;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MODIFICAR PIEZA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(432, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Regresar");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbActualizarPieza
            // 
            this.pbActualizarPieza.BackColor = System.Drawing.Color.Transparent;
            this.pbActualizarPieza.BackgroundImage = global::DiseñoFinal.Properties.Resources.ActPieza;
            this.pbActualizarPieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbActualizarPieza.Location = new System.Drawing.Point(46, 197);
            this.pbActualizarPieza.Name = "pbActualizarPieza";
            this.pbActualizarPieza.Size = new System.Drawing.Size(65, 75);
            this.pbActualizarPieza.TabIndex = 78;
            this.pbActualizarPieza.TabStop = false;
            this.toolTip1.SetToolTip(this.pbActualizarPieza, "Actualizar Pieza");
            this.pbActualizarPieza.Click += new System.EventHandler(this.pbActualizarPieza_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(313, 84);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "PRECIO:";
            // 
            // txtCodPieza
            // 
            this.txtCodPieza.Enabled = false;
            this.txtCodPieza.Location = new System.Drawing.Point(135, 84);
            this.txtCodPieza.MaxLength = 5;
            this.txtCodPieza.Name = "txtCodPieza";
            this.txtCodPieza.Size = new System.Drawing.Size(100, 20);
            this.txtCodPieza.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "CODIGO PIEZA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "TIEMPO DE FABRICACIÓN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "NOMBRE:";
            // 
            // EditarPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.lineas_1;
            this.ClientSize = new System.Drawing.Size(497, 279);
            this.Controls.Add(this.pbBorrarPieza);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudTiempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbActualizarPieza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodPieza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPieza";
            this.Load += new System.EventHandler(this.EditarPieza_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrarPieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPieza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBorrarPieza;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTiempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbActualizarPieza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodPieza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}