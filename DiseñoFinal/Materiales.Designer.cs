namespace DiseñoFinal
{
    partial class Materiales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbActualizarMaterial = new System.Windows.Forms.PictureBox();
            this.pbAgregarMaterial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigMat = new System.Windows.Forms.TextBox();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbActualizarMaterial
            // 
            this.pbActualizarMaterial.BackgroundImage = global::DiseñoFinal.Properties.Resources.ActProducto;
            this.pbActualizarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbActualizarMaterial.Location = new System.Drawing.Point(135, 465);
            this.pbActualizarMaterial.Name = "pbActualizarMaterial";
            this.pbActualizarMaterial.Size = new System.Drawing.Size(81, 78);
            this.pbActualizarMaterial.TabIndex = 49;
            this.pbActualizarMaterial.TabStop = false;
            this.toolTip1.SetToolTip(this.pbActualizarMaterial, "Actualizar Material");
            this.pbActualizarMaterial.Click += new System.EventHandler(this.pbActualizarMaterial_Click);
            // 
            // pbAgregarMaterial
            // 
            this.pbAgregarMaterial.BackgroundImage = global::DiseñoFinal.Properties.Resources.Producto;
            this.pbAgregarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAgregarMaterial.Location = new System.Drawing.Point(21, 465);
            this.pbAgregarMaterial.Name = "pbAgregarMaterial";
            this.pbAgregarMaterial.Size = new System.Drawing.Size(81, 78);
            this.pbAgregarMaterial.TabIndex = 50;
            this.pbAgregarMaterial.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAgregarMaterial, "Agregar Material");
            this.pbAgregarMaterial.Click += new System.EventHandler(this.pbAgregarMaterial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(817, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Regresar");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código del Material";
            // 
            // txtCodigMat
            // 
            this.txtCodigMat.Location = new System.Drawing.Point(341, 90);
            this.txtCodigMat.MaxLength = 7;
            this.txtCodigMat.Name = "txtCodigMat";
            this.txtCodigMat.Size = new System.Drawing.Size(152, 20);
            this.txtCodigMat.TabIndex = 43;
            this.txtCodigMat.TextChanged += new System.EventHandler(this.txtCodigMat_TextChanged);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMateriales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateriales.Location = new System.Drawing.Point(21, 133);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(835, 326);
            this.dgvMateriales.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 63);
            this.panel1.TabIndex = 44;
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.Location = new System.Drawing.Point(838, 3);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(18, 18);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 26;
            this.pBSalir2.TabStop = false;
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATERIALES";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DiseñoFinal.Properties.Resources.Buscar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(499, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 59;
            this.toolTip1.SetToolTip(this.button2, "Buscar");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.footer1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbActualizarMaterial);
            this.Controls.Add(this.pbAgregarMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigMat);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.Materiales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbActualizarMaterial;
        private System.Windows.Forms.PictureBox pbAgregarMaterial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigMat;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}