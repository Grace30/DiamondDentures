namespace DiseñoFinal
{
    partial class Piezas
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
            this.pbActualizarPieza = new System.Windows.Forms.PictureBox();
            this.pbAgregarPieza = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoPieza = new System.Windows.Forms.TextBox();
            this.dgvPiezas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarPieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbActualizarPieza
            // 
            this.pbActualizarPieza.BackgroundImage = global::DiseñoFinal.Properties.Resources.ActPieza;
            this.pbActualizarPieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbActualizarPieza.Location = new System.Drawing.Point(148, 422);
            this.pbActualizarPieza.Name = "pbActualizarPieza";
            this.pbActualizarPieza.Size = new System.Drawing.Size(78, 85);
            this.pbActualizarPieza.TabIndex = 56;
            this.pbActualizarPieza.TabStop = false;
            this.toolTip1.SetToolTip(this.pbActualizarPieza, "Actualizar Pieza");
            this.pbActualizarPieza.Click += new System.EventHandler(this.pbActualizarPieza_Click);
            // 
            // pbAgregarPieza
            // 
            this.pbAgregarPieza.BackgroundImage = global::DiseñoFinal.Properties.Resources.AgregarPieza;
            this.pbAgregarPieza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAgregarPieza.Location = new System.Drawing.Point(39, 422);
            this.pbAgregarPieza.Name = "pbAgregarPieza";
            this.pbAgregarPieza.Size = new System.Drawing.Size(78, 85);
            this.pbAgregarPieza.TabIndex = 57;
            this.pbAgregarPieza.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAgregarPieza, "Agregar Pieza");
            this.pbAgregarPieza.Click += new System.EventHandler(this.pbAgregarPieza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiseñoFinal.Properties.Resources.salir;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(506, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Regresar");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Código del Producto";
            // 
            // txtCodigoPieza
            // 
            this.txtCodigoPieza.Location = new System.Drawing.Point(74, 123);
            this.txtCodigoPieza.MaxLength = 5;
            this.txtCodigoPieza.Name = "txtCodigoPieza";
            this.txtCodigoPieza.Size = new System.Drawing.Size(152, 20);
            this.txtCodigoPieza.TabIndex = 50;
            this.txtCodigoPieza.TextChanged += new System.EventHandler(this.txtCodigoPieza_TextChanged);
            // 
            // dgvPiezas
            // 
            this.dgvPiezas.AllowUserToAddRows = false;
            this.dgvPiezas.AllowUserToDeleteRows = false;
            this.dgvPiezas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPiezas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPiezas.Location = new System.Drawing.Point(26, 174);
            this.dgvPiezas.MultiSelect = false;
            this.dgvPiezas.Name = "dgvPiezas";
            this.dgvPiezas.ReadOnly = true;
            this.dgvPiezas.RowHeadersVisible = false;
            this.dgvPiezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiezas.Size = new System.Drawing.Size(531, 225);
            this.dgvPiezas.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pBSalir2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 63);
            this.panel1.TabIndex = 51;
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.BackgroundImage = global::DiseñoFinal.Properties.Resources.Salir_2;
            this.pBSalir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Location = new System.Drawing.Point(554, 12);
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
            this.label2.Location = new System.Drawing.Point(261, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIEZAS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DiseñoFinal.Properties.Resources.Buscar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(232, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 58;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Piezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.lineas_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbActualizarPieza);
            this.Controls.Add(this.pbAgregarPieza);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoPieza);
            this.Controls.Add(this.dgvPiezas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Piezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piezas";
            this.Load += new System.EventHandler(this.Piezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarPieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbActualizarPieza;
        private System.Windows.Forms.PictureBox pbAgregarPieza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoPieza;
        private System.Windows.Forms.DataGridView dgvPiezas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}