namespace DiseñoFinal
{
    partial class ReportesAlmacen
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
            this.tabProv = new System.Windows.Forms.TabControl();
            this.tpCatalago = new System.Windows.Forms.TabPage();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabricacionMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabricacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInventarioMat = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvInvenMat = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBaseMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.ClaveProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListaCompras = new System.Windows.Forms.TabPage();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblProve = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.IDCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredelProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredelMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadelPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadelSurtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompras = new System.Windows.Forms.Button();
            this.tabRequisiciones = new System.Windows.Forms.TabPage();
            this.btnreq = new System.Windows.Forms.Button();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.IDRequisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSalidas = new System.Windows.Forms.TabPage();
            this.btnSal = new System.Windows.Forms.Button();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMateriall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBSalir = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabProv.SuspendLayout();
            this.tpCatalago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.tabInventarioMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvenMat)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            this.tabListaCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.tabRequisiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.tabSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProv
            // 
            this.tabProv.Controls.Add(this.tpCatalago);
            this.tabProv.Controls.Add(this.tabInventarioMat);
            this.tabProv.Controls.Add(this.tabProveedores);
            this.tabProv.Controls.Add(this.tabListaCompras);
            this.tabProv.Controls.Add(this.tabRequisiciones);
            this.tabProv.Controls.Add(this.tabSalidas);
            this.tabProv.Location = new System.Drawing.Point(12, 42);
            this.tabProv.Name = "tabProv";
            this.tabProv.SelectedIndex = 0;
            this.tabProv.Size = new System.Drawing.Size(949, 392);
            this.tabProv.TabIndex = 0;
            // 
            // tpCatalago
            // 
            this.tpCatalago.Controls.Add(this.btnCatalogo);
            this.tpCatalago.Controls.Add(this.dgvCatalogo);
            this.tpCatalago.Location = new System.Drawing.Point(4, 22);
            this.tpCatalago.Name = "tpCatalago";
            this.tpCatalago.Padding = new System.Windows.Forms.Padding(3);
            this.tpCatalago.Size = new System.Drawing.Size(941, 366);
            this.tpCatalago.TabIndex = 0;
            this.tpCatalago.Text = "Catálogo de Productos";
            this.tpCatalago.UseVisualStyleBackColor = true;
            this.tpCatalago.Click += new System.EventHandler(this.tpCatalago_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.Silver;
            this.btnCatalogo.Location = new System.Drawing.Point(355, 337);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(140, 23);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "Vista Previa Catálogo";
            this.btnCatalogo.UseVisualStyleBackColor = false;
    //        this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.TiempoBase,
            this.PrecioBase,
            this.Material,
            this.FabricacionMaterial,
            this.PrecioMaterial,
            this.FabricacionTotal,
            this.PrecioTotal});
            this.dgvCatalogo.GridColor = System.Drawing.Color.MediumBlue;
            this.dgvCatalogo.Location = new System.Drawing.Point(6, 37);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCatalogo.Size = new System.Drawing.Size(912, 270);
            this.dgvCatalogo.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // TiempoBase
            // 
            this.TiempoBase.HeaderText = "Fabricación(Dias)";
            this.TiempoBase.Name = "TiempoBase";
            // 
            // PrecioBase
            // 
            this.PrecioBase.HeaderText = "Precio";
            this.PrecioBase.Name = "PrecioBase";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.Width = 110;
            // 
            // FabricacionMaterial
            // 
            this.FabricacionMaterial.HeaderText = "Fabricación(Dias)";
            this.FabricacionMaterial.Name = "FabricacionMaterial";
            // 
            // PrecioMaterial
            // 
            this.PrecioMaterial.HeaderText = "Precio";
            this.PrecioMaterial.Name = "PrecioMaterial";
            // 
            // FabricacionTotal
            // 
            this.FabricacionTotal.HeaderText = "FabricacionTotal";
            this.FabricacionTotal.Name = "FabricacionTotal";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "PrecioTotal";
            this.PrecioTotal.Name = "PrecioTotal";
            // 
            // tabInventarioMat
            // 
            this.tabInventarioMat.Controls.Add(this.button1);
            this.tabInventarioMat.Controls.Add(this.dgvInvenMat);
            this.tabInventarioMat.Location = new System.Drawing.Point(4, 22);
            this.tabInventarioMat.Name = "tabInventarioMat";
            this.tabInventarioMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventarioMat.Size = new System.Drawing.Size(941, 366);
            this.tabInventarioMat.TabIndex = 1;
            this.tabInventarioMat.Text = "Inventario Materiales";
            this.tabInventarioMat.UseVisualStyleBackColor = true;
            this.tabInventarioMat.Click += new System.EventHandler(this.tabInventarioMat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(432, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vista Previa Inventario";
            this.button1.UseVisualStyleBackColor = false;
     //       this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvInvenMat
            // 
            this.dgvInvenMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvenMat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvenMat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInvenMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvenMat.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvInvenMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DescripcionMaterial,
            this.CostoBase,
            this.PrecioBaseMaterial,
            this.Unidad,
            this.Existencia});
            this.dgvInvenMat.GridColor = System.Drawing.Color.Purple;
            this.dgvInvenMat.Location = new System.Drawing.Point(19, 59);
            this.dgvInvenMat.Name = "dgvInvenMat";
            this.dgvInvenMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInvenMat.RowHeadersVisible = false;
            this.dgvInvenMat.Size = new System.Drawing.Size(893, 249);
            this.dgvInvenMat.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // DescripcionMaterial
            // 
            this.DescripcionMaterial.HeaderText = "Descripcion";
            this.DescripcionMaterial.Name = "DescripcionMaterial";
            // 
            // CostoBase
            // 
            this.CostoBase.HeaderText = "CostoBase";
            this.CostoBase.Name = "CostoBase";
            // 
            // PrecioBaseMaterial
            // 
            this.PrecioBaseMaterial.HeaderText = "PrecioBase";
            this.PrecioBaseMaterial.Name = "PrecioBaseMaterial";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.btnProveedores);
            this.tabProveedores.Controls.Add(this.dgvProv);
            this.tabProveedores.Location = new System.Drawing.Point(4, 22);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(941, 366);
            this.tabProveedores.TabIndex = 2;
            this.tabProveedores.Text = "Lista de Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            this.tabProveedores.Click += new System.EventHandler(this.tabProveedores_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProveedores.Location = new System.Drawing.Point(119, 337);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(229, 23);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Vista Previa Proveedores General";
            this.btnProveedores.UseVisualStyleBackColor = false;
      //      this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // dgvProv
            // 
            this.dgvProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProv.BackgroundColor = System.Drawing.Color.White;
            this.dgvProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveProveedor,
            this.NombreProveedor,
            this.Telefono,
            this.Correo,
            this.DescripcionProveedor,
            this.RFC,
            this.Contacto});
            this.dgvProv.GridColor = System.Drawing.Color.IndianRed;
            this.dgvProv.Location = new System.Drawing.Point(22, 64);
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProv.RowHeadersVisible = false;
            this.dgvProv.Size = new System.Drawing.Size(872, 253);
            this.dgvProv.TabIndex = 0;
            // 
            // ClaveProveedor
            // 
            this.ClaveProveedor.HeaderText = "ClaveProveedor";
            this.ClaveProveedor.Name = "ClaveProveedor";
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.HeaderText = "Nombre";
            this.NombreProveedor.Name = "NombreProveedor";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Email";
            this.Correo.Name = "Correo";
            // 
            // DescripcionProveedor
            // 
            this.DescripcionProveedor.HeaderText = "Descripción";
            this.DescripcionProveedor.Name = "DescripcionProveedor";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            // 
            // tabListaCompras
            // 
            this.tabListaCompras.Controls.Add(this.btnProv);
            this.tabListaCompras.Controls.Add(this.btnBuscar);
            this.tabListaCompras.Controls.Add(this.lblProve);
            this.tabListaCompras.Controls.Add(this.txtProveedor);
            this.tabListaCompras.Controls.Add(this.dgvCompras);
            this.tabListaCompras.Controls.Add(this.btnCompras);
            this.tabListaCompras.Location = new System.Drawing.Point(4, 22);
            this.tabListaCompras.Name = "tabListaCompras";
            this.tabListaCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaCompras.Size = new System.Drawing.Size(941, 366);
            this.tabListaCompras.TabIndex = 3;
            this.tabListaCompras.Text = "Lista de Compras";
            this.tabListaCompras.UseVisualStyleBackColor = true;
            // 
            // btnProv
            // 
            this.btnProv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProv.Location = new System.Drawing.Point(408, 328);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(167, 23);
            this.btnProv.TabIndex = 3;
            this.btnProv.Text = "Ver Compras Por Proveedor";
            this.btnProv.UseVisualStyleBackColor = false;
            this.btnProv.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscar.Location = new System.Drawing.Point(593, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 221;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            // 
            // lblProve
            // 
            this.lblProve.AutoSize = true;
            this.lblProve.Location = new System.Drawing.Point(190, 35);
            this.lblProve.Name = "lblProve";
            this.lblProve.Size = new System.Drawing.Size(96, 13);
            this.lblProve.TabIndex = 220;
            this.lblProve.Text = "Nombre Proveedor";
            this.lblProve.Visible = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(292, 32);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(295, 20);
            this.txtProveedor.TabIndex = 219;
            this.txtProveedor.Visible = false;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged_1);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCompra,
            this.NombredelProveedor,
            this.NombredelMaterial,
            this.Cantidad,
            this.Total,
            this.FechadelPedido,
            this.FechadelSurtido});
            this.dgvCompras.GridColor = System.Drawing.Color.Maroon;
            this.dgvCompras.Location = new System.Drawing.Point(31, 76);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCompras.Size = new System.Drawing.Size(873, 229);
            this.dgvCompras.TabIndex = 0;
            // 
            // IDCompra
            // 
            this.IDCompra.HeaderText = "IDCompra";
            this.IDCompra.Name = "IDCompra";
            // 
            // NombredelProveedor
            // 
            this.NombredelProveedor.HeaderText = "Proveedor";
            this.NombredelProveedor.Name = "NombredelProveedor";
            // 
            // NombredelMaterial
            // 
            this.NombredelMaterial.HeaderText = "Material";
            this.NombredelMaterial.Name = "NombredelMaterial";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FechadelPedido
            // 
            this.FechadelPedido.HeaderText = "FechaPedido";
            this.FechadelPedido.Name = "FechadelPedido";
            // 
            // FechadelSurtido
            // 
            this.FechadelSurtido.HeaderText = "FechaSurtido";
            this.FechadelSurtido.Name = "FechadelSurtido";
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.Location = new System.Drawing.Point(238, 328);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(131, 23);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "Vista Previa Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
         //   this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // tabRequisiciones
            // 
            this.tabRequisiciones.Controls.Add(this.btnreq);
            this.tabRequisiciones.Controls.Add(this.dgvReq);
            this.tabRequisiciones.Location = new System.Drawing.Point(4, 22);
            this.tabRequisiciones.Name = "tabRequisiciones";
            this.tabRequisiciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequisiciones.Size = new System.Drawing.Size(941, 366);
            this.tabRequisiciones.TabIndex = 4;
            this.tabRequisiciones.Text = "Requisiciones";
            this.tabRequisiciones.UseVisualStyleBackColor = true;
            // 
            // btnreq
            // 
            this.btnreq.Location = new System.Drawing.Point(451, 311);
            this.btnreq.Name = "btnreq";
            this.btnreq.Size = new System.Drawing.Size(153, 23);
            this.btnreq.TabIndex = 1;
            this.btnreq.Text = "Ver Requisición";
            this.btnreq.UseVisualStyleBackColor = true;
     //       this.btnreq.Click += new System.EventHandler(this.btnreq_Click);
            // 
            // dgvReq
            // 
            this.dgvReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReq.BackgroundColor = System.Drawing.Color.White;
            this.dgvReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRequisicion,
            this.Empleado,
            this.CantidadTotal,
            this.FechadePedido,
            this.Surtido});
            this.dgvReq.GridColor = System.Drawing.Color.SlateGray;
            this.dgvReq.Location = new System.Drawing.Point(21, 37);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.RowHeadersVisible = false;
            this.dgvReq.Size = new System.Drawing.Size(864, 232);
            this.dgvReq.TabIndex = 0;
            // 
            // IDRequisicion
            // 
            this.IDRequisicion.HeaderText = "IDRequisicion";
            this.IDRequisicion.Name = "IDRequisicion";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // CantidadTotal
            // 
            this.CantidadTotal.HeaderText = "Cantidad";
            this.CantidadTotal.Name = "CantidadTotal";
            // 
            // FechadePedido
            // 
            this.FechadePedido.HeaderText = "Fecha";
            this.FechadePedido.Name = "FechadePedido";
            // 
            // Surtido
            // 
            this.Surtido.HeaderText = "Surtido";
            this.Surtido.Name = "Surtido";
            // 
            // tabSalidas
            // 
            this.tabSalidas.Controls.Add(this.btnSal);
            this.tabSalidas.Controls.Add(this.dgvSalidas);
            this.tabSalidas.Location = new System.Drawing.Point(4, 22);
            this.tabSalidas.Name = "tabSalidas";
            this.tabSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalidas.Size = new System.Drawing.Size(941, 366);
            this.tabSalidas.TabIndex = 5;
            this.tabSalidas.Text = "Salida de Materiales";
            this.tabSalidas.UseVisualStyleBackColor = true;
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.DimGray;
            this.btnSal.ForeColor = System.Drawing.Color.White;
            this.btnSal.Location = new System.Drawing.Point(361, 343);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(176, 23);
            this.btnSal.TabIndex = 1;
            this.btnSal.Text = "Ver Vista Previa";
            this.btnSal.UseVisualStyleBackColor = false;
      //      this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvSalidas.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalidas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.NombreMaterial,
            this.CodigoMaterial,
            this.DescripcionMateriall,
            this.Cant,
            this.FechaEntrega});
            this.dgvSalidas.GridColor = System.Drawing.Color.Crimson;
            this.dgvSalidas.Location = new System.Drawing.Point(39, 37);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.Size = new System.Drawing.Size(861, 260);
            this.dgvSalidas.TabIndex = 0;
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "IDPedido";
            this.IDPedido.Name = "IDPedido";
            // 
            // NombreMaterial
            // 
            this.NombreMaterial.HeaderText = "Material";
            this.NombreMaterial.Name = "NombreMaterial";
            // 
            // CodigoMaterial
            // 
            this.CodigoMaterial.HeaderText = "Código";
            this.CodigoMaterial.Name = "CodigoMaterial";
            // 
            // DescripcionMateriall
            // 
            this.DescripcionMateriall.HeaderText = "Descripción";
            this.DescripcionMateriall.Name = "DescripcionMateriall";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            // 
            // pBSalir
            // 
            this.pBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir.Image = global::DiseñoFinal.Properties.Resources.salir1;
            this.pBSalir.Location = new System.Drawing.Point(932, 440);
            this.pBSalir.Name = "pBSalir";
            this.pBSalir.Size = new System.Drawing.Size(37, 33);
            this.pBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir.TabIndex = 176;
            this.pBSalir.TabStop = false;
            this.pBSalir.Click += new System.EventHandler(this.pBSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(871, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 215;
            this.lblUsuario.Text = "label1";
            // 
            // ReportesAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 456);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pBSalir);
            this.Controls.Add(this.tabProv);
            this.Location = new System.Drawing.Point(-5, 48);
            this.Name = "ReportesAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReportesAlmacen";
            this.Load += new System.EventHandler(this.ReportesAlmacen_Load);
            this.tabProv.ResumeLayout(false);
            this.tpCatalago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.tabInventarioMat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvenMat)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            this.tabListaCompras.ResumeLayout(false);
            this.tabListaCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.tabRequisiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.tabSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabProv;
        private System.Windows.Forms.TabPage tpCatalago;
        private System.Windows.Forms.TabPage tabInventarioMat;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.DataGridView dgvInvenMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBaseMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.DataGridView dgvProv;
        private System.Windows.Forms.TabPage tabListaCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredelMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadelPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadelSurtido;
        private System.Windows.Forms.TabPage tabRequisiciones;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRequisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surtido;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnreq;
        private System.Windows.Forms.TabPage tabSalidas;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMateriall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricacionMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricacionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.PictureBox pBSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblProve;
        private System.Windows.Forms.TextBox txtProveedor;
    }
}