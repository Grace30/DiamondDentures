namespace DiseñoFinal
{
    partial class Tarjetas_RegistradasUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjetas_RegistradasUser));
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBEliminar = new System.Windows.Forms.PictureBox();
            this.cheListTarjetas = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "TARJETAS REGISTRADAS";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir2;
            this.pBSalir.Location = new System.Drawing.Point(280, 387);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(39, 37);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 164;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir.MouseLeave += new System.EventHandler(this.pBSalir_MouseLeave);
            this.pBSalir.MouseHover += new System.EventHandler(this.pBSalir_MouseHover);
            // 
            // pBEliminar
            // 
            this.pBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBEliminar.Image = global::DiseñoFinal.Properties.Resources.eliminar2;
            this.pBEliminar.Location = new System.Drawing.Point(125, 318);
            this.pBEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBEliminar.Name = "pBEliminar";
            this.pBEliminar.Size = new System.Drawing.Size(57, 55);
            this.pBEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEliminar.TabIndex = 163;
            this.pBEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBEliminar, "Eliminar");
            this.pBEliminar.Click += new System.EventHandler(this.pBEliminar_Click);
            this.pBEliminar.MouseLeave += new System.EventHandler(this.pBEliminar_MouseLeave);
            this.pBEliminar.MouseHover += new System.EventHandler(this.pBEliminar_MouseHover);
            // 
            // cheListTarjetas
            // 
            this.cheListTarjetas.CheckOnClick = true;
            this.cheListTarjetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheListTarjetas.ForeColor = System.Drawing.Color.Blue;
            this.cheListTarjetas.FormattingEnabled = true;
            this.cheListTarjetas.Items.AddRange(new object[] {
            "No. Tarjeta X"});
            this.cheListTarjetas.Location = new System.Drawing.Point(96, 163);
            this.cheListTarjetas.Name = "cheListTarjetas";
            this.cheListTarjetas.Size = new System.Drawing.Size(119, 148);
            this.cheListTarjetas.TabIndex = 1;
            this.cheListTarjetas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cheListTarjetas_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiseñoFinal.Properties.Resources.tarjetas2;
            this.pictureBox1.Location = new System.Drawing.Point(111, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(300, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 204;
            this.pBSalir2.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir2, "Salir");
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            this.pBSalir2.MouseLeave += new System.EventHandler(this.pBSalir2_MouseLeave);
            this.pBSalir2.MouseHover += new System.EventHandler(this.pBSalir2_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 67);
            this.panel1.TabIndex = 165;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 166;
            this.label2.Text = "Doble clic en el enlace  para ver la \r\ninformación de la tarjeta.";
            // 
            // Tarjetas_RegistradasUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.u;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(322, 436);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cheListTarjetas);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBEliminar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tarjetas_RegistradasUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Tarjetas_RegistradasUser_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBEliminar;
        private System.Windows.Forms.CheckedListBox cheListTarjetas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
    }
}