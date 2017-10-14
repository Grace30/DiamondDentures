namespace DiseñoFinal
{
    partial class Recepcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recepcion));
            this.pBPedido = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.pBPedidos = new System.Windows.Forms.PictureBox();
            this.pbxSemaforo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBPedido)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSemaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBPedido
            // 
            this.pBPedido.BackColor = System.Drawing.Color.Transparent;
            this.pBPedido.BackgroundImage = global::DiseñoFinal.Properties.Resources.Nuevo_pedido;
            this.pBPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBPedido.Location = new System.Drawing.Point(44, 158);
            this.pBPedido.Name = "pBPedido";
            this.pBPedido.Size = new System.Drawing.Size(70, 76);
            this.pBPedido.TabIndex = 2;
            this.pBPedido.TabStop = false;
            this.toolTip1.SetToolTip(this.pBPedido, "Pedido Nuevo");
            this.pBPedido.Click += new System.EventHandler(this.pBPedido_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DiseñoFinal.Properties.Resources.fondo_recepcion2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-7, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 136);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pBSalir1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 61);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DiseñoFinal.Properties.Resources.Logo_dd;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 59);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "RECEPCIÓN";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pBSalir1
            // 
            this.pBSalir1.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir1.BackgroundImage = global::DiseñoFinal.Properties.Resources._1489837723_Close;
            this.pBSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBSalir1.Location = new System.Drawing.Point(325, 3);
            this.pBSalir1.Name = "pBSalir1";
            this.pBSalir1.Size = new System.Drawing.Size(36, 36);
            this.pBSalir1.TabIndex = 0;
            this.pBSalir1.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir1, "Salir");
            this.pBSalir1.Click += new System.EventHandler(this.pBSalir1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DiseñoFinal.Properties.Resources.fondo_recepcion;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.pBSalir);
            this.panel1.Location = new System.Drawing.Point(-8, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 142);
            this.panel1.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(146, 12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(303, 79);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(51, 49);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 9;
            this.pBSalir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSalir, "Regresar");
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // pBPedidos
            // 
            this.pBPedidos.BackColor = System.Drawing.Color.Transparent;
            this.pBPedidos.BackgroundImage = global::DiseñoFinal.Properties.Resources.Pedidos12;
            this.pBPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBPedidos.Location = new System.Drawing.Point(138, 158);
            this.pBPedidos.Name = "pBPedidos";
            this.pBPedidos.Size = new System.Drawing.Size(71, 76);
            this.pBPedidos.TabIndex = 3;
            this.pBPedidos.TabStop = false;
            this.toolTip1.SetToolTip(this.pBPedidos, "Ver Pedidos");
            this.pBPedidos.Click += new System.EventHandler(this.pBPedidos_Click);
            // 
            // pbxSemaforo
            // 
            this.pbxSemaforo.BackColor = System.Drawing.Color.Transparent;
            this.pbxSemaforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSemaforo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSemaforo.Image = global::DiseñoFinal.Properties.Resources._1496024715_traffic_light_lb;
            this.pbxSemaforo.Location = new System.Drawing.Point(237, 158);
            this.pbxSemaforo.Name = "pbxSemaforo";
            this.pbxSemaforo.Size = new System.Drawing.Size(72, 78);
            this.pbxSemaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSemaforo.TabIndex = 37;
            this.pbxSemaforo.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxSemaforo, "Semáforo");
            this.pbxSemaforo.Click += new System.EventHandler(this.pbxSemaforo_Click);
            // 
            // Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 396);
            this.Controls.Add(this.pbxSemaforo);
            this.Controls.Add(this.pBPedidos);
            this.Controls.Add(this.pBPedido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recepcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepcion";
            this.Load += new System.EventHandler(this.Recepcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBPedido)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSemaforo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pBSalir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBPedido;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pBPedidos;
        private System.Windows.Forms.PictureBox pbxSemaforo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVentas;
    }
}