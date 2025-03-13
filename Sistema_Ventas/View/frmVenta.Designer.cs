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
            Label lbl_cantidad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            dgv_productos = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_precio = new DataGridViewTextBoxColumn();
            clm_stock = new DataGridViewTextBoxColumn();
            gpBox_producto = new GroupBox();
            lbl_seleccionar = new Label();
            btn_agregar = new Button();
            txt_cantidad = new TextBox();
            txt_precio = new TextBox();
            txt_nombre = new TextBox();
            lbl_buscar_prod = new Label();
            txt_buscar = new TextBox();
            lbl_precio = new Label();
            lbl_nombre = new Label();
            btn_actualizar = new Button();
            btn_eliminar = new Button();
            gpbox_carrito = new GroupBox();
            lbl_seleccionar_eli = new Label();
            lbl_metodo = new Label();
            txt_total = new TextBox();
            txt_IVA = new TextBox();
            txt_descuento = new TextBox();
            txt_subtotal = new TextBox();
            cb_metodo = new ComboBox();
            btn_cobrar = new Button();
            lbl_descuento = new Label();
            dgv_carrito = new DataGridView();
            clm_c_nombre = new DataGridViewTextBoxColumn();
            clm_c_cantidad = new DataGridViewTextBoxColumn();
            clm_c_precio = new DataGridViewTextBoxColumn();
            lbl_total = new Label();
            lbl_IVA = new Label();
            lbl_subtotal = new Label();
            btn_limpiar = new Button();
            gpbox_cliente = new GroupBox();
            txt_correo = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre_prod = new TextBox();
            lbl_correo = new Label();
            lbl_apellido_p = new Label();
            lbl_nombre_c = new Label();
            lbl_buscar_cliente = new Label();
            cb_clientes = new ComboBox();
            lbl_titulo = new Label();
            lbl_cantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            gpBox_producto.SuspendLayout();
            gpbox_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).BeginInit();
            gpbox_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(354, 81);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(86, 25);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "Cantidad";
            // 
            // dgv_productos
            // 
            dgv_productos.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clm_nombre, clm_precio, clm_stock });
            dgv_productos.Location = new Point(7, 167);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.Size = new Size(654, 349);
            dgv_productos.TabIndex = 9;
            // 
            // clmCodigo
            // 
            clmCodigo.HeaderText = "Codigo";
            clmCodigo.MinimumWidth = 8;
            clmCodigo.Name = "clmCodigo";
            clmCodigo.Width = 150;
            // 
            // clm_nombre
            // 
            clm_nombre.HeaderText = "Nombre";
            clm_nombre.MinimumWidth = 8;
            clm_nombre.Name = "clm_nombre";
            clm_nombre.Width = 150;
            // 
            // clm_precio
            // 
            clm_precio.HeaderText = "Precio";
            clm_precio.MinimumWidth = 8;
            clm_precio.Name = "clm_precio";
            clm_precio.Width = 150;
            // 
            // clm_stock
            // 
            clm_stock.HeaderText = "Stock";
            clm_stock.MinimumWidth = 8;
            clm_stock.Name = "clm_stock";
            clm_stock.Width = 150;
            // 
            // gpBox_producto
            // 
            gpBox_producto.BackColor = SystemColors.InactiveBorder;
            gpBox_producto.Controls.Add(dgv_productos);
            gpBox_producto.Controls.Add(lbl_seleccionar);
            gpBox_producto.Controls.Add(btn_agregar);
            gpBox_producto.Controls.Add(txt_cantidad);
            gpBox_producto.Controls.Add(txt_precio);
            gpBox_producto.Controls.Add(txt_nombre);
            gpBox_producto.Controls.Add(lbl_buscar_prod);
            gpBox_producto.Controls.Add(lbl_cantidad);
            gpBox_producto.Controls.Add(txt_buscar);
            gpBox_producto.Controls.Add(lbl_precio);
            gpBox_producto.Controls.Add(lbl_nombre);
            gpBox_producto.Controls.Add(btn_actualizar);
            gpBox_producto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpBox_producto.Location = new Point(5, 152);
            gpBox_producto.Name = "gpBox_producto";
            gpBox_producto.Size = new Size(687, 539);
            gpBox_producto.TabIndex = 8;
            gpBox_producto.TabStop = false;
            gpBox_producto.Text = "Producto disponible";
            // 
            // lbl_seleccionar
            // 
            lbl_seleccionar.AutoSize = true;
            lbl_seleccionar.Location = new Point(473, 139);
            lbl_seleccionar.Name = "lbl_seleccionar";
            lbl_seleccionar.Size = new Size(188, 25);
            lbl_seleccionar.TabIndex = 22;
            lbl_seleccionar.Text = "Click para seleccionar";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Image = Properties.Resources.Agregar;
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.Location = new Point(518, 69);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(142, 43);
            btn_agregar.TabIndex = 21;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(443, 75);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(53, 31);
            txt_cantidad.TabIndex = 20;
            // 
            // txt_precio
            // 
            txt_precio.Enabled = false;
            txt_precio.Location = new Point(264, 75);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(84, 31);
            txt_precio.TabIndex = 19;
            // 
            // txt_nombre
            // 
            txt_nombre.Enabled = false;
            txt_nombre.Location = new Point(90, 73);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(102, 31);
            txt_nombre.TabIndex = 18;
            // 
            // lbl_buscar_prod
            // 
            lbl_buscar_prod.AutoSize = true;
            lbl_buscar_prod.Location = new Point(30, 27);
            lbl_buscar_prod.Name = "lbl_buscar_prod";
            lbl_buscar_prod.Size = new Size(66, 25);
            lbl_buscar_prod.TabIndex = 17;
            lbl_buscar_prod.Text = "Buscar";
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(99, 27);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(290, 31);
            txt_buscar.TabIndex = 0;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(198, 75);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(64, 25);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(6, 73);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(81, 25);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = SystemColors.ActiveCaption;
            btn_actualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_actualizar.Image = Properties.Resources.actualizar;
            btn_actualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_actualizar.Location = new Point(30, 113);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(143, 48);
            btn_actualizar.TabIndex = 0;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click_;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = SystemColors.ActiveCaption;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Image = Properties.Resources.delete;
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(403, 22);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(144, 42);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // gpbox_carrito
            // 
            gpbox_carrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gpbox_carrito.BackColor = SystemColors.InactiveBorder;
            gpbox_carrito.Controls.Add(lbl_seleccionar_eli);
            gpbox_carrito.Controls.Add(lbl_metodo);
            gpbox_carrito.Controls.Add(txt_total);
            gpbox_carrito.Controls.Add(txt_IVA);
            gpbox_carrito.Controls.Add(txt_descuento);
            gpbox_carrito.Controls.Add(txt_subtotal);
            gpbox_carrito.Controls.Add(cb_metodo);
            gpbox_carrito.Controls.Add(btn_cobrar);
            gpbox_carrito.Controls.Add(lbl_descuento);
            gpbox_carrito.Controls.Add(dgv_carrito);
            gpbox_carrito.Controls.Add(lbl_total);
            gpbox_carrito.Controls.Add(lbl_IVA);
            gpbox_carrito.Controls.Add(btn_eliminar);
            gpbox_carrito.Controls.Add(lbl_subtotal);
            gpbox_carrito.Controls.Add(btn_limpiar);
            gpbox_carrito.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gpbox_carrito.Location = new Point(698, 152);
            gpbox_carrito.Name = "gpbox_carrito";
            gpbox_carrito.Size = new Size(553, 539);
            gpbox_carrito.TabIndex = 7;
            gpbox_carrito.TabStop = false;
            gpbox_carrito.Text = "Carrito";
            // 
            // lbl_seleccionar_eli
            // 
            lbl_seleccionar_eli.AutoSize = true;
            lbl_seleccionar_eli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_seleccionar_eli.Location = new Point(184, 31);
            lbl_seleccionar_eli.Name = "lbl_seleccionar_eli";
            lbl_seleccionar_eli.Size = new Size(213, 25);
            lbl_seleccionar_eli.TabIndex = 23;
            lbl_seleccionar_eli.Text = "Selecciona para eliminar";
            // 
            // lbl_metodo
            // 
            lbl_metodo.AutoSize = true;
            lbl_metodo.Location = new Point(184, 455);
            lbl_metodo.Name = "lbl_metodo";
            lbl_metodo.Size = new Size(152, 25);
            lbl_metodo.TabIndex = 19;
            lbl_metodo.Text = "Metodo de pago";
            // 
            // txt_total
            // 
            txt_total.Enabled = false;
            txt_total.Location = new Point(361, 401);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(150, 31);
            txt_total.TabIndex = 18;
            // 
            // txt_IVA
            // 
            txt_IVA.Enabled = false;
            txt_IVA.Location = new Point(363, 367);
            txt_IVA.Name = "txt_IVA";
            txt_IVA.Size = new Size(150, 31);
            txt_IVA.TabIndex = 17;
            // 
            // txt_descuento
            // 
            txt_descuento.Enabled = false;
            txt_descuento.Location = new Point(363, 328);
            txt_descuento.Name = "txt_descuento";
            txt_descuento.Size = new Size(150, 31);
            txt_descuento.TabIndex = 16;
            // 
            // txt_subtotal
            // 
            txt_subtotal.Enabled = false;
            txt_subtotal.Location = new Point(363, 287);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(150, 31);
            txt_subtotal.TabIndex = 15;
            // 
            // cb_metodo
            // 
            cb_metodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_metodo.FormattingEnabled = true;
            cb_metodo.Location = new Point(361, 452);
            cb_metodo.Name = "cb_metodo";
            cb_metodo.Size = new Size(150, 33);
            cb_metodo.TabIndex = 14;
            // 
            // btn_cobrar
            // 
            btn_cobrar.BackColor = SystemColors.ActiveCaption;
            btn_cobrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cobrar.Location = new Point(179, 491);
            btn_cobrar.Name = "btn_cobrar";
            btn_cobrar.Size = new Size(198, 45);
            btn_cobrar.TabIndex = 13;
            btn_cobrar.Text = "Cobrar";
            btn_cobrar.UseVisualStyleBackColor = false;
            btn_cobrar.Click += btn_terminar_Click;
            // 
            // lbl_descuento
            // 
            lbl_descuento.AutoSize = true;
            lbl_descuento.Location = new Point(236, 331);
            lbl_descuento.Name = "lbl_descuento";
            lbl_descuento.Size = new Size(101, 25);
            lbl_descuento.TabIndex = 12;
            lbl_descuento.Text = "Descuento";
            // 
            // dgv_carrito
            // 
            dgv_carrito.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv_carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_carrito.Columns.AddRange(new DataGridViewColumn[] { clm_c_nombre, clm_c_cantidad, clm_c_precio });
            dgv_carrito.Location = new Point(26, 73);
            dgv_carrito.Name = "dgv_carrito";
            dgv_carrito.RowHeadersWidth = 62;
            dgv_carrito.Size = new Size(507, 208);
            dgv_carrito.TabIndex = 11;
            // 
            // clm_c_nombre
            // 
            clm_c_nombre.HeaderText = "nombre";
            clm_c_nombre.MinimumWidth = 8;
            clm_c_nombre.Name = "clm_c_nombre";
            clm_c_nombre.Width = 150;
            // 
            // clm_c_cantidad
            // 
            clm_c_cantidad.HeaderText = "cantidad";
            clm_c_cantidad.MinimumWidth = 8;
            clm_c_cantidad.Name = "clm_c_cantidad";
            clm_c_cantidad.Width = 150;
            // 
            // clm_c_precio
            // 
            clm_c_precio.HeaderText = "Precio";
            clm_c_precio.MinimumWidth = 8;
            clm_c_precio.Name = "clm_c_precio";
            clm_c_precio.ReadOnly = true;
            clm_c_precio.Width = 150;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(283, 404);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(52, 25);
            lbl_total.TabIndex = 10;
            lbl_total.Text = "Total";
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(293, 370);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(40, 25);
            lbl_IVA.TabIndex = 9;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(253, 294);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(83, 25);
            lbl_subtotal.TabIndex = 8;
            lbl_subtotal.Text = "Subtotal";
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.ActiveCaption;
            btn_limpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Image = Properties.Resources.limpiar;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(45, 294);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(144, 46);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // gpbox_cliente
            // 
            gpbox_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpbox_cliente.BackColor = SystemColors.InactiveBorder;
            gpbox_cliente.Controls.Add(txt_correo);
            gpbox_cliente.Controls.Add(txt_apellido);
            gpbox_cliente.Controls.Add(txt_nombre_prod);
            gpbox_cliente.Controls.Add(lbl_correo);
            gpbox_cliente.Controls.Add(lbl_apellido_p);
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
            // txt_correo
            // 
            txt_correo.Enabled = false;
            txt_correo.Location = new Point(987, 30);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(232, 31);
            txt_correo.TabIndex = 22;
            // 
            // txt_apellido
            // 
            txt_apellido.Enabled = false;
            txt_apellido.Location = new Point(797, 33);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(102, 31);
            txt_apellido.TabIndex = 21;
            // 
            // txt_nombre_prod
            // 
            txt_nombre_prod.Enabled = false;
            txt_nombre_prod.Location = new Point(578, 32);
            txt_nombre_prod.Name = "txt_nombre_prod";
            txt_nombre_prod.Size = new Size(102, 31);
            txt_nombre_prod.TabIndex = 20;
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(922, 33);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(69, 25);
            lbl_correo.TabIndex = 19;
            lbl_correo.Text = "Correo";
            // 
            // lbl_apellido_p
            // 
            lbl_apellido_p.AutoSize = true;
            lbl_apellido_p.Location = new Point(693, 39);
            lbl_apellido_p.Name = "lbl_apellido_p";
            lbl_apellido_p.Size = new Size(98, 25);
            lbl_apellido_p.TabIndex = 18;
            lbl_apellido_p.Text = "Apellido P";
            // 
            // lbl_nombre_c
            // 
            lbl_nombre_c.AutoSize = true;
            lbl_nombre_c.Location = new Point(498, 35);
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
            lbl_buscar_cliente.Size = new Size(66, 25);
            lbl_buscar_cliente.TabIndex = 16;
            lbl_buscar_cliente.Text = "Buscar";
            // 
            // cb_clientes
            // 
            cb_clientes.AutoCompleteCustomSource.AddRange(new string[] { "Cliente general" });
            cb_clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_clientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(118, 30);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(271, 33);
            cb_clientes.TabIndex = 15;
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
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1263, 693);
            Controls.Add(lbl_titulo);
            Controls.Add(gpBox_producto);
            Controls.Add(gpbox_carrito);
            Controls.Add(gpbox_cliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVenta";
            Text = "Venta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            gpBox_producto.ResumeLayout(false);
            gpBox_producto.PerformLayout();
            gpbox_carrito.ResumeLayout(false);
            gpbox_carrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_carrito).EndInit();
            gpbox_cliente.ResumeLayout(false);
            gpbox_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_nombreBusqueda;
        private DataGridView dgv_productos;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_precio;
        private DataGridViewTextBoxColumn clm_stock;
        private GroupBox gpBox_producto;
        private TextBox txt_buscar;
        private Label lbl_precio;
        private Label lbl_nombre;
        private Button btn_actualizar;
        private Button btn_eliminar;
        private GroupBox gpbox_carrito;
        private Label lbl_descuento;
        private DataGridView dgv_carrito;
        private DataGridViewTextBoxColumn clm_c_nombre;
        private DataGridViewTextBoxColumn clm_c_cantidad;
        private DataGridViewTextBoxColumn clm_c_precio;
        private Label lbl_total;
        private Label lbl_IVA;
        private Label lbl_subtotal;
        private Button btn_limpiar;
        private GroupBox gpbox_cliente;
        private GroupBox groupBox1;
        private Button btn_agregar;
        private Button btn_cobrar;
        private Label lbl_buscar_prod;
        private ComboBox cb_metodo;
        private Label lbl_buscar_cliente;
        private ComboBox cb_clientes;
        private TextBox txt_cantidad;
        private TextBox txt_precio;
        private TextBox txt_nombre;
        private Label lbl_metodo;
        private TextBox txt_total;
        private TextBox txt_IVA;
        private TextBox txt_descuento;
        private TextBox txt_subtotal;
        private Label lbl_seleccionar;
        private Label lbl_seleccionar_eli;
        private TextBox txt_correo;
        private TextBox txt_apellido;
        private TextBox txt_nombre_prod;
        private Label lbl_correo;
        private Label lbl_apellido_p;
        private Label lbl_nombre_c;
        private Label lbl_titulo;
    }
}