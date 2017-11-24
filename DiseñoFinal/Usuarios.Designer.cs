namespace DiseñoFinal
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBEliminar = new System.Windows.Forms.PictureBox();
            this.cheListUsuarios = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "USUARIOS";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(279, 345);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(33, 31);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 166;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir.MouseLeave += new System.EventHandler(this.pBSalir_MouseLeave);
            this.pBSalir.MouseHover += new System.EventHandler(this.pBSalir_MouseHover);
            // 
            // pBEliminar
            // 
            this.pBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBEliminar.Image = global::DiseñoFinal.Properties.Resources.eliminar;
            this.pBEliminar.Location = new System.Drawing.Point(144, 290);
            this.pBEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBEliminar.Name = "pBEliminar";
            this.pBEliminar.Size = new System.Drawing.Size(55, 53);
            this.pBEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEliminar.TabIndex = 165;
            this.pBEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBEliminar, "Eliminar");
            this.pBEliminar.Click += new System.EventHandler(this.pBEliminar_Click);
            this.pBEliminar.MouseLeave += new System.EventHandler(this.pBEliminar_MouseLeave);
            this.pBEliminar.MouseHover += new System.EventHandler(this.pBEliminar_MouseHover);
            // 
            // cheListUsuarios
            // 
            this.cheListUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheListUsuarios.ForeColor = System.Drawing.Color.Blue;
            this.cheListUsuarios.FormattingEnabled = true;
            this.cheListUsuarios.Location = new System.Drawing.Point(79, 159);
            this.cheListUsuarios.Name = "cheListUsuarios";
            this.cheListUsuarios.Size = new System.Drawing.Size(159, 112);
            this.cheListUsuarios.TabIndex = 167;
            this.cheListUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cheListUsuarios_MouseClick);
            this.cheListUsuarios.SelectedIndexChanged += new System.EventHandler(this.cheListUsuarios_SelectedIndexChanged);
            this.cheListUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cheListUsuarios_MouseDoubleClick);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.salir11;
            this.pBSalir2.Location = new System.Drawing.Point(301, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 168;
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 81);
            this.panel1.TabIndex = 168;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 169;
            this.label2.Text = "Doble clic en el enlace  para ver la \r\ninformación del usuario.";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(324, 388);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cheListUsuarios);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.pBEliminar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBEliminar;
        private System.Windows.Forms.CheckedListBox cheListUsuarios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
    }
}