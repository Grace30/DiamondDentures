namespace DiseñoFinal
{
    partial class Ventas
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.rbtnCedula = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnPedido = new System.Windows.Forms.RadioButton();
            this.dataPedidos = new System.Windows.Forms.DataGridView();
            this.dataPedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRestante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoAbono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(108, 44);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(409, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.rbtnCedula);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnPedido);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de búsqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(550, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(463, 71);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // rbtnCedula
            // 
            this.rbtnCedula.AutoSize = true;
            this.rbtnCedula.Location = new System.Drawing.Point(7, 68);
            this.rbtnCedula.Name = "rbtnCedula";
            this.rbtnCedula.Size = new System.Drawing.Size(58, 17);
            this.rbtnCedula.TabIndex = 4;
            this.rbtnCedula.TabStop = true;
            this.rbtnCedula.Text = "Cédula";
            this.rbtnCedula.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(7, 44);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 3;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnPedido
            // 
            this.rbtnPedido.AutoSize = true;
            this.rbtnPedido.Checked = true;
            this.rbtnPedido.Location = new System.Drawing.Point(7, 20);
            this.rbtnPedido.Name = "rbtnPedido";
            this.rbtnPedido.Size = new System.Drawing.Size(58, 17);
            this.rbtnPedido.TabIndex = 2;
            this.rbtnPedido.TabStop = true;
            this.rbtnPedido.Text = "Pedido";
            this.rbtnPedido.UseVisualStyleBackColor = true;
            // 
            // dataPedidos
            // 
            this.dataPedidos.AllowUserToAddRows = false;
            this.dataPedidos.AllowUserToDeleteRows = false;
            this.dataPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedidos.Location = new System.Drawing.Point(12, 137);
            this.dataPedidos.MultiSelect = false;
            this.dataPedidos.Name = "dataPedidos";
            this.dataPedidos.ReadOnly = true;
            this.dataPedidos.RowHeadersVisible = false;
            this.dataPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPedidos.Size = new System.Drawing.Size(544, 150);
            this.dataPedidos.TabIndex = 3;
            this.dataPedidos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPedidos_RowEnter);
            // 
            // dataPedido
            // 
            this.dataPedido.AllowUserToAddRows = false;
            this.dataPedido.AllowUserToDeleteRows = false;
            this.dataPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedido.Location = new System.Drawing.Point(12, 293);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.ReadOnly = true;
            this.dataPedido.RowHeadersVisible = false;
            this.dataPedido.Size = new System.Drawing.Size(544, 150);
            this.dataPedido.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo Actual";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(659, 159);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(88, 20);
            this.txtSaldoActual.TabIndex = 6;
            this.txtSaldoActual.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Abono";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(659, 244);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(88, 20);
            this.txtAbono.TabIndex = 8;
            this.txtAbono.Text = "0";
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(659, 203);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(88, 20);
            this.txtImporte.TabIndex = 10;
            this.txtImporte.Text = "0";
            this.txtImporte.Enter += new System.EventHandler(this.txtImporte_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Restante";
            // 
            // txtRestante
            // 
            this.txtRestante.Location = new System.Drawing.Point(659, 282);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.ReadOnly = true;
            this.txtRestante.Size = new System.Drawing.Size(88, 20);
            this.txtRestante.TabIndex = 12;
            this.txtRestante.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saldo Despues \r\ndel Abono";
            // 
            // txtSaldoAbono
            // 
            this.txtSaldoAbono.Location = new System.Drawing.Point(659, 320);
            this.txtSaldoAbono.Name = "txtSaldoAbono";
            this.txtSaldoAbono.ReadOnly = true;
            this.txtSaldoAbono.Size = new System.Drawing.Size(88, 20);
            this.txtSaldoAbono.TabIndex = 14;
            this.txtSaldoAbono.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Forma de págo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Tarjeta de Debito"});
            this.comboBox1.Location = new System.Drawing.Point(589, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "--Selecciona--";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(19, 461);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(648, 484);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Descripción de venta";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(574, 373);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(481, 12);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 22;
            this.btnRetiro.Text = "Retiros";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnCorte
            // 
            this.btnCorte.Location = new System.Drawing.Point(562, 12);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(75, 23);
            this.btnCorte.TabIndex = 23;
            this.btnCorte.Text = "Corte";
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // btnEntregas
            // 
            this.btnEntregas.Location = new System.Drawing.Point(643, 12);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(75, 23);
            this.btnEntregas.TabIndex = 24;
            this.btnEntregas.Text = "Entregas";
            this.btnEntregas.UseVisualStyleBackColor = true;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 517);
            this.Controls.Add(this.btnEntregas);
            this.Controls.Add(this.btnCorte);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSaldoAbono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldoActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPedido);
            this.Controls.Add(this.dataPedidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Activated += new System.EventHandler(this.Ventas_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCedula;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnPedido;
        private System.Windows.Forms.DataGridView dataPedidos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dataPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRestante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoAbono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnEntregas;
    }
}