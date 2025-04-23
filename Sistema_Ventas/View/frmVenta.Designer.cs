namespace Sistema_Ventas.View
{
    partial class frmVenta
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
            components = new System.ComponentModel.Container();
            Label lbl_cantidad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            gpbox_cliente = new GroupBox();
            txt_nombre_prod = new TextBox();
            lbl_nombre_c = new Label();
            lbl_buscar_cliente = new Label();
            cb_clientes = new ComboBox();
            lbl_titulo = new Label();
            toolTip_buscar_cli = new ToolTip(components);
            toolTip_limpar = new ToolTip(components);
            btn_limpiar = new Button();
            splitCVenta = new SplitContainer();
            gpBox_producto = new GroupBox();
            dgv_productos = new DataGridView();
            lbl_buscar_prod = new Label();
            txt_buscar = new TextBox();
            btn_actualizar = new Button();
            grpbox_agregarP = new GroupBox();
            cBox_codigo = new ComboBox();
            lblcodigo = new Label();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            btn_agregar = new Button();
            lbl_precio = new Label();
            txt_cantidad = new TextBox();
            txt_precio = new TextBox();
            splitter1 = new Splitter();
            gpbox_carrito = new GroupBox();
            dgv_carrito = new DataGridView();
            cms_eliminar = new ContextMenuStrip(components);
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            cbox_estatus = new ComboBox();
            lbl_estatus = new Label();
            lbl_seleccionar_eli = new Label();
            lbl_metodo = new Label();
            txt_total = new TextBox();
            txt_IVA = new TextBox();
            txt_descuento = new TextBox();
            txt_subtotal = new TextBox();
            cb_metodo = new ComboBox();
            btn_cobrar = new Button();
            lbl_descuento = new Label();
            lbl_total = new Label();
            lbl_IVA = new Label();
            lbl_subtotal = new Label();
            lbl_cantidad = new Label();
            gpbox_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitCVenta).BeginInit();
            splitCVenta.Panel1.SuspendLayout();
            splitCVenta.Panel2.SuspendLayout();
            splitCVenta.SuspendLayout();
            gpBox_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            grpbox_agregarP.SuspendLayout();
            gpbox_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).BeginInit();
            cms_eliminar.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(27, 105);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(86, 25);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "Cantidad";
            // 
            // gpbox_cliente
            // 
            gpbox_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpbox_cliente.BackColor = SystemColors.InactiveBorder;
            gpbox_cliente.Controls.Add(txt_nombre_prod);
            gpbox_cliente.Controls.Add(lbl_nombre_c);
            gpbox_cliente.Controls.Add(lbl_buscar_cliente);
            gpbox_cliente.Controls.Add(cb_clientes);
            gpbox_cliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbox_cliente.Location = new Point(12, 67);
            gpbox_cliente.Name = "gpbox_cliente";
            gpbox_cliente.Size = new Size(1239, 79);
            gpbox_cliente.TabIndex = 6;
            gpbox_cliente.TabStop = false;
            gpbox_cliente.Text = "Cliente disponible";
            // 
            // txt_nombre_prod
            // 
            txt_nombre_prod.Enabled = false;
            txt_nombre_prod.Location = new Point(951, 27);
            txt_nombre_prod.MaxLength = 30;
            txt_nombre_prod.Name = "txt_nombre_prod";
            txt_nombre_prod.Size = new Size(240, 31);
            txt_nombre_prod.TabIndex = 20;
            // 
            // lbl_nombre_c
            // 
            lbl_nombre_c.AutoSize = true;
            lbl_nombre_c.Location = new Point(844, 27);
            lbl_nombre_c.Name = "lbl_nombre_c";
            lbl_nombre_c.Size = new Size(81, 25);
            lbl_nombre_c.TabIndex = 17;
            lbl_nombre_c.Text = "Nombre";
            // 
            // lbl_buscar_cliente
            // 
            lbl_buscar_cliente.AutoSize = true;
            lbl_buscar_cliente.Location = new Point(30, 33);
            lbl_buscar_cliente.Name = "lbl_buscar_cliente";
            lbl_buscar_cliente.Size = new Size(140, 25);
            lbl_buscar_cliente.TabIndex = 16;
            lbl_buscar_cliente.Text = "Buscar (Correo)";
            // 
            // cb_clientes
            // 
            cb_clientes.AutoCompleteCustomSource.AddRange(new string[] { "Cliente general" });
            cb_clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_clientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Items.AddRange(new object[] { "cliente general" });
            cb_clientes.Location = new Point(195, 30);
            cb_clientes.MaxLength = 100;
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(347, 33);
            cb_clientes.TabIndex = 15;
            toolTip_buscar_cli.SetToolTip(cb_clientes, "busqueda por correo");
            cb_clientes.SelectedIndexChanged += cb_clientes_SelectedIndexChanged;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.BackColor = Color.SteelBlue;
            lbl_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.ActiveCaptionText;
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(1233, 55);
            lbl_titulo.TabIndex = 9;
            lbl_titulo.Tag = "";
            lbl_titulo.Text = "Venta de productos";
            lbl_titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.IndianRed;
            btn_limpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Image = Properties.Resources.limpiar;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(51, 504);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(180, 46);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            toolTip_limpar.SetToolTip(btn_limpiar, "Eliminar productor seleccionados");
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // splitCVenta
            // 
            splitCVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitCVenta.Location = new Point(12, 152);
            splitCVenta.Name = "splitCVenta";
            // 
            // splitCVenta.Panel1
            // 
            splitCVenta.Panel1.Controls.Add(gpBox_producto);
            splitCVenta.Panel1.Controls.Add(grpbox_agregarP);
            splitCVenta.Panel1.Controls.Add(splitter1);
            splitCVenta.Panel1.Paint += splitCVenta_Panel1_Paint;
            // 
            // splitCVenta.Panel2
            // 
            splitCVenta.Panel2.Controls.Add(gpbox_carrito);
            splitCVenta.Size = new Size(1239, 580);
            splitCVenta.SplitterDistance = 692;
            splitCVenta.TabIndex = 10;
            splitCVenta.SplitterMoved += splitCVenta_SplitterMoved;
            // 
            // gpBox_producto
            // 
            gpBox_producto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpBox_producto.BackColor = SystemColors.InactiveBorder;
            gpBox_producto.Controls.Add(dgv_productos);
            gpBox_producto.Controls.Add(lbl_buscar_prod);
            gpBox_producto.Controls.Add(txt_buscar);
            gpBox_producto.Controls.Add(btn_actualizar);
            gpBox_producto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpBox_producto.Location = new Point(12, 217);
            gpBox_producto.Name = "gpBox_producto";
            gpBox_producto.Size = new Size(666, 360);
            gpBox_producto.TabIndex = 14;
            gpBox_producto.TabStop = false;
            gpBox_producto.Text = "Producto disponible";
            // 
            // dgv_productos
            // 
            dgv_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Location = new Point(18, 105);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.Size = new Size(608, 240);
            dgv_productos.TabIndex = 18;
            // 
            // lbl_buscar_prod
            // 
            lbl_buscar_prod.AutoSize = true;
            lbl_buscar_prod.Location = new Point(18, 27);
            lbl_buscar_prod.Name = "lbl_buscar_prod";
            lbl_buscar_prod.Size = new Size(199, 25);
            lbl_buscar_prod.TabIndex = 17;
            lbl_buscar_prod.Text = "Busqueda por nombre";
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(15, 56);
            txt_buscar.MaxLength = 100;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(365, 31);
            txt_buscar.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = SystemColors.ActiveCaption;
            btn_actualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_actualizar.Image = Properties.Resources.search;
            btn_actualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_actualizar.Location = new Point(475, 46);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(143, 48);
            btn_actualizar.TabIndex = 0;
            btn_actualizar.Text = "Buscar";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // grpbox_agregarP
            // 
            grpbox_agregarP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpbox_agregarP.BackColor = SystemColors.InactiveBorder;
            grpbox_agregarP.Controls.Add(cBox_codigo);
            grpbox_agregarP.Controls.Add(lblcodigo);
            grpbox_agregarP.Controls.Add(lbl_nombre);
            grpbox_agregarP.Controls.Add(txt_nombre);
            grpbox_agregarP.Controls.Add(btn_agregar);
            grpbox_agregarP.Controls.Add(lbl_precio);
            grpbox_agregarP.Controls.Add(txt_cantidad);
            grpbox_agregarP.Controls.Add(txt_precio);
            grpbox_agregarP.Controls.Add(lbl_cantidad);
            grpbox_agregarP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpbox_agregarP.Location = new Point(12, 12);
            grpbox_agregarP.Name = "grpbox_agregarP";
            grpbox_agregarP.Size = new Size(666, 184);
            grpbox_agregarP.TabIndex = 13;
            grpbox_agregarP.TabStop = false;
            grpbox_agregarP.Text = "Agregar producto";
            // 
            // cBox_codigo
            // 
            cBox_codigo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBox_codigo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBox_codigo.FormattingEnabled = true;
            cBox_codigo.Location = new Point(27, 69);
            cBox_codigo.Name = "cBox_codigo";
            cBox_codigo.Size = new Size(246, 33);
            cBox_codigo.TabIndex = 23;
            cBox_codigo.SelectedIndexChanged += cBox_codigo_SelectedIndexChanged_1;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(24, 39);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(249, 25);
            lblcodigo.TabIndex = 22;
            lblcodigo.Text = "ingrese codigo del producto";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(362, 54);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(81, 25);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Enabled = false;
            txt_nombre.Location = new Point(362, 82);
            txt_nombre.MaxLength = 30;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(256, 31);
            txt_nombre.TabIndex = 18;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Image = Properties.Resources.Agregar;
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.Location = new Point(183, 125);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(142, 43);
            btn_agregar.TabIndex = 21;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click_1;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(362, 116);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(64, 25);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(27, 137);
            txt_cantidad.MaxLength = 4;
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(86, 31);
            txt_cantidad.TabIndex = 20;
            // 
            // txt_precio
            // 
            txt_precio.Enabled = false;
            txt_precio.Location = new Point(362, 144);
            txt_precio.MaxLength = 5;
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(134, 31);
            txt_precio.TabIndex = 19;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(689, 580);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // gpbox_carrito
            // 
            gpbox_carrito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpbox_carrito.BackColor = SystemColors.InactiveBorder;
            gpbox_carrito.Controls.Add(dgv_carrito);
            gpbox_carrito.Controls.Add(cbox_estatus);
            gpbox_carrito.Controls.Add(lbl_estatus);
            gpbox_carrito.Controls.Add(lbl_seleccionar_eli);
            gpbox_carrito.Controls.Add(lbl_metodo);
            gpbox_carrito.Controls.Add(txt_total);
            gpbox_carrito.Controls.Add(txt_IVA);
            gpbox_carrito.Controls.Add(txt_descuento);
            gpbox_carrito.Controls.Add(txt_subtotal);
            gpbox_carrito.Controls.Add(cb_metodo);
            gpbox_carrito.Controls.Add(btn_cobrar);
            gpbox_carrito.Controls.Add(lbl_descuento);
            gpbox_carrito.Controls.Add(lbl_total);
            gpbox_carrito.Controls.Add(lbl_IVA);
            gpbox_carrito.Controls.Add(lbl_subtotal);
            gpbox_carrito.Controls.Add(btn_limpiar);
            gpbox_carrito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gpbox_carrito.Location = new Point(22, 12);
            gpbox_carrito.Name = "gpbox_carrito";
            gpbox_carrito.Size = new Size(501, 556);
            gpbox_carrito.TabIndex = 8;
            gpbox_carrito.TabStop = false;
            gpbox_carrito.Text = "Carrito";
            // 
            // dgv_carrito
            // 
            dgv_carrito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_carrito.ContextMenuStrip = cms_eliminar;
            dgv_carrito.Location = new Point(23, 64);
            dgv_carrito.Name = "dgv_carrito";
            dgv_carrito.RowHeadersWidth = 62;
            dgv_carrito.Size = new Size(465, 184);
            dgv_carrito.TabIndex = 26;
            // 
            // cms_eliminar
            // 
            cms_eliminar.ImageScalingSize = new Size(24, 24);
            cms_eliminar.Items.AddRange(new ToolStripItem[] { eliminarProductoToolStripMenuItem });
            cms_eliminar.Name = "cms_eliminar";
            cms_eliminar.Size = new Size(226, 36);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(225, 32);
            eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            eliminarProductoToolStripMenuItem.Click += eliminarProductoToolStripMenuItem_Click;
            // 
            // cbox_estatus
            // 
            cbox_estatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbox_estatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_estatus.FormattingEnabled = true;
            cbox_estatus.Location = new Point(320, 468);
            cbox_estatus.Name = "cbox_estatus";
            cbox_estatus.Size = new Size(151, 33);
            cbox_estatus.TabIndex = 25;
            // 
            // lbl_estatus
            // 
            lbl_estatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_estatus.AutoSize = true;
            lbl_estatus.Location = new Point(217, 464);
            lbl_estatus.Name = "lbl_estatus";
            lbl_estatus.Size = new Size(71, 25);
            lbl_estatus.TabIndex = 24;
            lbl_estatus.Text = "Estatus";
            // 
            // lbl_seleccionar_eli
            // 
            lbl_seleccionar_eli.AutoSize = true;
            lbl_seleccionar_eli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_seleccionar_eli.Location = new Point(161, 21);
            lbl_seleccionar_eli.Name = "lbl_seleccionar_eli";
            lbl_seleccionar_eli.Size = new Size(327, 25);
            lbl_seleccionar_eli.TabIndex = 23;
            lbl_seleccionar_eli.Text = "click izquierdo para eliminar producto";
            // 
            // lbl_metodo
            // 
            lbl_metodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_metodo.AutoSize = true;
            lbl_metodo.Location = new Point(144, 422);
            lbl_metodo.Name = "lbl_metodo";
            lbl_metodo.Size = new Size(152, 25);
            lbl_metodo.TabIndex = 19;
            lbl_metodo.Text = "Metodo de pago";
            // 
            // txt_total
            // 
            txt_total.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_total.Enabled = false;
            txt_total.Location = new Point(321, 368);
            txt_total.MaxLength = 6;
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(150, 31);
            txt_total.TabIndex = 18;
            // 
            // txt_IVA
            // 
            txt_IVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_IVA.Enabled = false;
            txt_IVA.Location = new Point(323, 334);
            txt_IVA.MaxLength = 5;
            txt_IVA.Name = "txt_IVA";
            txt_IVA.Size = new Size(150, 31);
            txt_IVA.TabIndex = 17;
            // 
            // txt_descuento
            // 
            txt_descuento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_descuento.Enabled = false;
            txt_descuento.Location = new Point(323, 295);
            txt_descuento.MaxLength = 5;
            txt_descuento.Name = "txt_descuento";
            txt_descuento.Size = new Size(150, 31);
            txt_descuento.TabIndex = 16;
            // 
            // txt_subtotal
            // 
            txt_subtotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_subtotal.Enabled = false;
            txt_subtotal.Location = new Point(323, 254);
            txt_subtotal.MaxLength = 6;
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(150, 31);
            txt_subtotal.TabIndex = 15;
            // 
            // cb_metodo
            // 
            cb_metodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cb_metodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_metodo.FormattingEnabled = true;
            cb_metodo.Location = new Point(321, 419);
            cb_metodo.Name = "cb_metodo";
            cb_metodo.Size = new Size(150, 33);
            cb_metodo.TabIndex = 14;
            cb_metodo.SelectedIndexChanged += cb_metodo_SelectedIndexChanged;
            // 
            // btn_cobrar
            // 
            btn_cobrar.BackColor = Color.YellowGreen;
            btn_cobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cobrar.Image = Properties.Resources.pagar1;
            btn_cobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cobrar.Location = new Point(305, 507);
            btn_cobrar.Name = "btn_cobrar";
            btn_cobrar.Size = new Size(198, 45);
            btn_cobrar.TabIndex = 13;
            btn_cobrar.Text = "Terminar compra";
            btn_cobrar.UseVisualStyleBackColor = false;
            btn_cobrar.Click += btn_cobrar_Click;
            // 
            // lbl_descuento
            // 
            lbl_descuento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_descuento.AutoSize = true;
            lbl_descuento.Location = new Point(196, 298);
            lbl_descuento.Name = "lbl_descuento";
            lbl_descuento.Size = new Size(101, 25);
            lbl_descuento.TabIndex = 12;
            lbl_descuento.Text = "Descuento";
            // 
            // lbl_total
            // 
            lbl_total.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(243, 371);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(52, 25);
            lbl_total.TabIndex = 10;
            lbl_total.Text = "Total";
            // 
            // lbl_IVA
            // 
            lbl_IVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(253, 337);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(40, 25);
            lbl_IVA.TabIndex = 9;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(213, 261);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(83, 25);
            lbl_subtotal.TabIndex = 8;
            lbl_subtotal.Text = "Subtotal";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1263, 744);
            Controls.Add(splitCVenta);
            Controls.Add(lbl_titulo);
            Controls.Add(gpbox_cliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1285, 800);
            MinimizeBox = false;
            MinimumSize = new Size(1285, 749);
            Name = "frmVenta";
            Text = "Venta";
            Load += frmVenta_Load;
            gpbox_cliente.ResumeLayout(false);
            gpbox_cliente.PerformLayout();
            splitCVenta.Panel1.ResumeLayout(false);
            splitCVenta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCVenta).EndInit();
            splitCVenta.ResumeLayout(false);
            gpBox_producto.ResumeLayout(false);
            gpBox_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            grpbox_agregarP.ResumeLayout(false);
            grpbox_agregarP.PerformLayout();
            gpbox_carrito.ResumeLayout(false);
            gpbox_carrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).EndInit();
            cms_eliminar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_nombreBusqueda;
        private GroupBox gpbox_cliente;
        private Label lbl_buscar_cliente;
        private ComboBox cb_clientes;
        private TextBox txt_nombre_prod;
        private Label lbl_nombre_c;
        private Label lbl_titulo;
        private ToolTip toolTip_buscar_cli;
        private ToolTip toolTip_limpar;
        private SplitContainer splitCVenta;
        private GroupBox gpbox_carrito;
        private ComboBox cbox_estatus;
        private Label lbl_estatus;
        private Label lbl_seleccionar_eli;
        private Label lbl_metodo;
        private TextBox txt_total;
        private TextBox txt_IVA;
        private TextBox txt_descuento;
        private TextBox txt_subtotal;
        private ComboBox cb_metodo;
        private Button btn_cobrar;
        private Label lbl_descuento;
        private Label lbl_total;
        private Label lbl_IVA;
        private Label lbl_subtotal;
        private Button btn_limpiar;
        private GroupBox grpbox_agregarP;
        private ComboBox cBox_codigo;
        private Label lblcodigo;
        private Label lbl_nombre;
        private TextBox txt_nombre;
        private Button btn_agregar;
        private Label lbl_precio;
        private TextBox txt_cantidad;
        private TextBox txt_precio;
        private Splitter splitter1;
        private GroupBox gpBox_producto;
        private Label lbl_buscar_prod;
        private TextBox txt_buscar;
        private Button btn_actualizar;
        private DataGridView dgv_productos;
        private DataGridView dgv_carrito;
        private ContextMenuStrip cms_eliminar;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
    }
}