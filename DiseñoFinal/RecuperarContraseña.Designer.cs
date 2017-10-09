namespace DiseñoFinal
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.cBPreguntaSeguridad = new System.Windows.Forms.ComboBox();
            this.lblMotrarContraseña = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBRecuperar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRecuperar)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(71, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "RECUPERAR CONTRASEÑA";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // cBPreguntaSeguridad
            // 
            this.cBPreguntaSeguridad.FormattingEnabled = true;
            this.cBPreguntaSeguridad.Items.AddRange(new object[] {
            "Color favorito",
            "Pasatiempo favorito",
            "Nombre de la Primera mascota",
            "Equipo deportivo preferido ",
            "Canción preferida",
            "Mejor amigo de la infancia",
            "Apodo en la infancia ",
            "Profesor favorito",
            "Ocupación del padre"});
            this.cBPreguntaSeguridad.Location = new System.Drawing.Point(32, 229);
            this.cBPreguntaSeguridad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBPreguntaSeguridad.Name = "cBPreguntaSeguridad";
            this.cBPreguntaSeguridad.Size = new System.Drawing.Size(327, 25);
            this.cBPreguntaSeguridad.TabIndex = 2;
            this.cBPreguntaSeguridad.Text = "-Elija una opción-";
            this.cBPreguntaSeguridad.SelectedIndexChanged += new System.EventHandler(this.cBPreguntaSeguridad_SelectedIndexChanged);
            // 
            // lblMotrarContraseña
            // 
            this.lblMotrarContraseña.AutoSize = true;
            this.lblMotrarContraseña.Location = new System.Drawing.Point(111, 350);
            this.lblMotrarContraseña.Name = "lblMotrarContraseña";
            this.lblMotrarContraseña.Size = new System.Drawing.Size(0, 17);
            this.lblMotrarContraseña.TabIndex = 17;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(32, 294);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRespuesta.MaxLength = 40;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(231, 22);
            this.txtRespuesta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Respuesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pregunta de seguridad";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(32, 161);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(332, 22);
            this.txtCorreo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Escribe tu  correo electrónico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiseñoFinal.Properties.Resources.contraseña1;
            this.pictureBox1.Location = new System.Drawing.Point(135, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(344, 385);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(40, 40);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 164;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            this.pBSalir.MouseLeave += new System.EventHandler(this.pBSalir_MouseLeave);
            this.pBSalir.MouseHover += new System.EventHandler(this.pBSalir_MouseHover);
            // 
            // pBRecuperar
            // 
            this.pBRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBRecuperar.Image = global::DiseñoFinal.Properties.Resources.recuperar;
            this.pBRecuperar.Location = new System.Drawing.Point(173, 334);
            this.pBRecuperar.Name = "pBRecuperar";
            this.pBRecuperar.Size = new System.Drawing.Size(58, 50);
            this.pBRecuperar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBRecuperar.TabIndex = 165;
            this.pBRecuperar.TabStop = false;
            this.toolTip1.SetToolTip(this.pBRecuperar, "Recuperar");
            this.pBRecuperar.Click += new System.EventHandler(this.pBRecuperar_Click);
            this.pBRecuperar.MouseLeave += new System.EventHandler(this.pBRecuperar_MouseLeave);
            this.pBRecuperar.MouseHover += new System.EventHandler(this.pBRecuperar_MouseHover);
            // 
            // pBSalir2
            // 
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.salir11;
            this.pBSalir2.Location = new System.Drawing.Point(376, 4);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 167;
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
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 79);
            this.panel1.TabIndex = 166;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(396, 437);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBRecuperar);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.cBPreguntaSeguridad);
            this.Controls.Add(this.lblMotrarContraseña);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRecuperar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBPreguntaSeguridad;
        private System.Windows.Forms.Label lblMotrarContraseña;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pBRecuperar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
    }
}