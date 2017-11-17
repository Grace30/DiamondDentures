namespace DiseñoFinal
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.lblPedido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cBCedula = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pBGenerarPedido = new System.Windows.Forms.PictureBox();
            this.pBSacarProducto = new System.Windows.Forms.PictureBox();
            this.pBAñadir = new System.Windows.Forms.PictureBox();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBSalir1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGenerarPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSacarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(10, 68);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(65, 23);
            this.lblPedido.TabIndex = 165;
            this.lblPedido.Text = "#0001";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCodigoMaterial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pBAñadir);
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
            this.groupBox2.Location = new System.Drawing.Point(14, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 235);
            this.groupBox2.TabIndex = 208;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 23);
            this.textBox1.TabIndex = 224;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 223;
            this.label12.Text = "Codigo";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 25);
            this.comboBox1.TabIndex = 222;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 221;
            this.label13.Text = "Material2*";
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Location = new System.Drawing.Point(121, 96);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.ReadOnly = true;
            this.txtCodigoMaterial.Size = new System.Drawing.Size(55, 23);
            this.txtCodigoMaterial.TabIndex = 220;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 76);
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
            this.nCantidad.Enabled = false;
            this.nCantidad.Location = new System.Drawing.Point(156, 160);
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
            this.label5.Location = new System.Drawing.Point(153, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 211;
            this.label5.Text = "Cantidad*";
            // 
            // cBMaterial
            // 
            this.cBMaterial.Enabled = false;
            this.cBMaterial.FormattingEnabled = true;
            this.cBMaterial.Location = new System.Drawing.Point(13, 94);
            this.cBMaterial.Name = "cBMaterial";
            this.cBMaterial.Size = new System.Drawing.Size(101, 25);
            this.cBMaterial.TabIndex = 210;
            this.cBMaterial.SelectedIndexChanged += new System.EventHandler(this.cBMaterial_SelectedIndexChanged);
            this.cBMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 209;
            this.label4.Text = "Material1*";
            // 
            // cBProducto
            // 
            this.cBProducto.Enabled = false;
            this.cBProducto.FormattingEnabled = true;
            this.cBProducto.Location = new System.Drawing.Point(13, 45);
            this.cBProducto.Name = "cBProducto";
            this.cBProducto.Size = new System.Drawing.Size(230, 25);
            this.cBProducto.TabIndex = 208;
            this.cBProducto.SelectedIndexChanged += new System.EventHandler(this.cBProducto_SelectedIndexChanged);
            this.cBProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBProducto_KeyPress);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cBCedula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 107);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dentista";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(192, 75);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(68, 17);
            this.linkLabel3.TabIndex = 211;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Modificar";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(35, 75);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(82, 17);
            this.linkLabel2.TabIndex = 210;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Seleccionar";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(128, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 17);
            this.linkLabel1.TabIndex = 209;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cBCedula
            // 
            this.cBCedula.FormattingEnabled = true;
            this.cBCedula.Location = new System.Drawing.Point(13, 47);
            this.cBCedula.Name = "cBCedula";
            this.cBCedula.Size = new System.Drawing.Size(245, 25);
            this.cBCedula.TabIndex = 208;
            this.cBCedula.SelectedIndexChanged += new System.EventHandler(this.cBCedula_SelectedIndexChanged);
            this.cBCedula.Enter += new System.EventHandler(this.cBCedula_Enter);
            this.cBCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBCedula_KeyPress);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 418);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(371, 117);
            this.dataGridView1.TabIndex = 214;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(170, 565);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 220;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 219;
            this.label10.Text = "Total $";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(19, 594);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 21);
            this.checkBox1.TabIndex = 218;
            this.checkBox1.Text = "Definir como urgente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 217;
            this.label11.Text = "Fecha de entrega*";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 565);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 23);
            this.dateTimePicker1.TabIndex = 216;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pBGenerarPedido
            // 
            this.pBGenerarPedido.BackColor = System.Drawing.Color.Transparent;
            this.pBGenerarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBGenerarPedido.Image = global::DiseñoFinal.Properties.Resources.forma_de_pedido;
            this.pBGenerarPedido.Location = new System.Drawing.Point(346, 549);
            this.pBGenerarPedido.Name = "pBGenerarPedido";
            this.pBGenerarPedido.Size = new System.Drawing.Size(39, 39);
            this.pBGenerarPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGenerarPedido.TabIndex = 221;
            this.pBGenerarPedido.TabStop = false;
            this.toolTip1.SetToolTip(this.pBGenerarPedido, "Generar Forma de Pedido");
            this.pBGenerarPedido.Click += new System.EventHandler(this.pBGenerarPedido_Click);
            // 
            // pBSacarProducto
            // 
            this.pBSacarProducto.BackColor = System.Drawing.Color.Transparent;
            this.pBSacarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSacarProducto.Image = global::DiseñoFinal.Properties.Resources.regresar_producto;
            this.pBSacarProducto.Location = new System.Drawing.Point(297, 549);
            this.pBSacarProducto.Name = "pBSacarProducto";
            this.pBSacarProducto.Size = new System.Drawing.Size(43, 39);
            this.pBSacarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSacarProducto.TabIndex = 215;
            this.pBSacarProducto.TabStop = false;
            this.toolTip1.SetToolTip(this.pBSacarProducto, "Sacar Producto");
            this.pBSacarProducto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pBAñadir
            // 
            this.pBAñadir.BackColor = System.Drawing.Color.Transparent;
            this.pBAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBAñadir.Enabled = false;
            this.pBAñadir.Image = global::DiseñoFinal.Properties.Resources.Carrito_añadir;
            this.pBAñadir.Location = new System.Drawing.Point(318, 188);
            this.pBAñadir.Name = "pBAñadir";
            this.pBAñadir.Size = new System.Drawing.Size(39, 38);
            this.pBAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAñadir.TabIndex = 209;
            this.pBAñadir.TabStop = false;
            this.toolTip1.SetToolTip(this.pBAñadir, "Añadir Producto");
            this.pBAñadir.Click += new System.EventHandler(this.pBAñadir_Click);
            // 
            // pBSalir
            // 
            this.pBSalir.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir;
            this.pBSalir.Location = new System.Drawing.Point(346, 617);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(39, 39);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 11;
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
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 58);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "PEDIDO NUEVO";
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 668);
            this.Controls.Add(this.pBGenerarPedido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pBSacarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pedido_FormClosed);
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGenerarPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSacarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pBAñadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cBCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pBSacarProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pBGenerarPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
    }
}