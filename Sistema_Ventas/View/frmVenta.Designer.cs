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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            sc_venta = new SplitContainer();
            grbox_carrito = new GroupBox();
            lbl_total = new Label();
            btn_terminar = new Button();
            lbl_IVA = new Label();
            lbl_subtotal = new Label();
            lbl_Concepto = new Label();
            lbl_xcantidad = new Label();
            lbl_producto = new Label();
            txt_Subtotal = new TextBox();
            txt_IVA = new TextBox();
            txt_total = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            lb_Producto = new ListBox();
            btn_limpiar = new Button();
            dtv_productos = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_precio = new DataGridViewTextBoxColumn();
            clm_stock = new DataGridViewTextBoxColumn();
            grp_busqueda = new GroupBox();
            rb_nombre = new RadioButton();
            rb_codigo = new RadioButton();
            textBox1 = new TextBox();
            gbx_venta = new GroupBox();
            btn_eliminar = new Button();
            textBox2 = new TextBox();
            btn_agregar = new Button();
            lbl_cantidad = new Label();
            lbl_nombre = new Label();
            gbx_metodo = new GroupBox();
            rb_tarjeta = new RadioButton();
            rb_efectivo = new RadioButton();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)sc_venta).BeginInit();
            sc_venta.Panel1.SuspendLayout();
            sc_venta.Panel2.SuspendLayout();
            sc_venta.SuspendLayout();
            grbox_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtv_productos).BeginInit();
            grp_busqueda.SuspendLayout();
            gbx_venta.SuspendLayout();
            gbx_metodo.SuspendLayout();
            SuspendLayout();
            // 
            // sc_venta
            // 
            sc_venta.Dock = DockStyle.Fill;
            sc_venta.Location = new Point(0, 0);
            sc_venta.Name = "sc_venta";
            // 
            // sc_venta.Panel1
            // 
            sc_venta.Panel1.Controls.Add(grbox_carrito);
            sc_venta.Panel1.Controls.Add(dtv_productos);
            sc_venta.Panel1.Controls.Add(grp_busqueda);
            sc_venta.Panel1.Controls.Add(gbx_venta);
            // 
            // sc_venta.Panel2
            // 
            sc_venta.Panel2.Controls.Add(gbx_metodo);
            sc_venta.Panel2.Paint += splitContainer1_Panel2_Paint;
            sc_venta.Size = new Size(1452, 636);
            sc_venta.SplitterDistance = 1044;
            sc_venta.TabIndex = 0;
            sc_venta.SplitterMoved += sc_venta_SplitterMoved;
            // 
            // grbox_carrito
            // 
            grbox_carrito.BackColor = SystemColors.InactiveBorder;
            grbox_carrito.Controls.Add(lbl_total);
            grbox_carrito.Controls.Add(btn_terminar);
            grbox_carrito.Controls.Add(lbl_IVA);
            grbox_carrito.Controls.Add(lbl_subtotal);
            grbox_carrito.Controls.Add(lbl_Concepto);
            grbox_carrito.Controls.Add(lbl_xcantidad);
            grbox_carrito.Controls.Add(lbl_producto);
            grbox_carrito.Controls.Add(txt_Subtotal);
            grbox_carrito.Controls.Add(txt_IVA);
            grbox_carrito.Controls.Add(txt_total);
            grbox_carrito.Controls.Add(listBox2);
            grbox_carrito.Controls.Add(listBox1);
            grbox_carrito.Controls.Add(lb_Producto);
            grbox_carrito.Controls.Add(btn_limpiar);
            grbox_carrito.Location = new Point(666, 12);
            grbox_carrito.Name = "grbox_carrito";
            grbox_carrito.Size = new Size(375, 612);
            grbox_carrito.TabIndex = 5;
            grbox_carrito.TabStop = false;
            grbox_carrito.Text = "Carrito de compras";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(154, 387);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 17;
            lbl_total.Text = "Total";
            // 
            // btn_terminar
            // 
            btn_terminar.BackColor = SystemColors.ActiveCaption;
            btn_terminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_terminar.Location = new Point(88, 545);
            btn_terminar.Name = "btn_terminar";
            btn_terminar.Size = new Size(195, 34);
            btn_terminar.TabIndex = 3;
            btn_terminar.Text = "Terminar Compra";
            btn_terminar.UseVisualStyleBackColor = false;
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(164, 339);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(39, 25);
            lbl_IVA.TabIndex = 16;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(117, 295);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(90, 25);
            lbl_subtotal.TabIndex = 15;
            lbl_subtotal.Text = "Subototal";
            // 
            // lbl_Concepto
            // 
            lbl_Concepto.AutoSize = true;
            lbl_Concepto.Location = new Point(244, 52);
            lbl_Concepto.Name = "lbl_Concepto";
            lbl_Concepto.Size = new Size(89, 25);
            lbl_Concepto.TabIndex = 14;
            lbl_Concepto.Text = "Concepto";
            // 
            // lbl_xcantidad
            // 
            lbl_xcantidad.AutoSize = true;
            lbl_xcantidad.Location = new Point(132, 52);
            lbl_xcantidad.Name = "lbl_xcantidad";
            lbl_xcantidad.Size = new Size(106, 25);
            lbl_xcantidad.TabIndex = 13;
            lbl_xcantidad.Text = "$x Cantidad";
            // 
            // lbl_producto
            // 
            lbl_producto.AutoSize = true;
            lbl_producto.Location = new Point(24, 52);
            lbl_producto.Name = "lbl_producto";
            lbl_producto.Size = new Size(86, 25);
            lbl_producto.TabIndex = 12;
            lbl_producto.Text = "producto";
            // 
            // txt_Subtotal
            // 
            txt_Subtotal.Location = new Point(211, 295);
            txt_Subtotal.Name = "txt_Subtotal";
            txt_Subtotal.Size = new Size(135, 31);
            txt_Subtotal.TabIndex = 11;
            // 
            // txt_IVA
            // 
            txt_IVA.Location = new Point(214, 339);
            txt_IVA.Name = "txt_IVA";
            txt_IVA.Size = new Size(134, 31);
            txt_IVA.TabIndex = 10;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(211, 376);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(137, 31);
            txt_total.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(134, 83);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(104, 179);
            listBox2.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(244, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(104, 179);
            listBox1.TabIndex = 7;
            // 
            // lb_Producto
            // 
            lb_Producto.FormattingEnabled = true;
            lb_Producto.ItemHeight = 25;
            lb_Producto.Location = new Point(24, 83);
            lb_Producto.Name = "lb_Producto";
            lb_Producto.Size = new Size(104, 179);
            lb_Producto.TabIndex = 6;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.ActiveCaption;
            btn_limpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(88, 487);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(195, 34);
            btn_limpiar.TabIndex = 4;
            btn_limpiar.Text = "limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // dtv_productos
            // 
            dtv_productos.AllowUserToAddRows = false;
            dtv_productos.AllowUserToDeleteRows = false;
            dtv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_productos.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_nombre, clm_precio, clm_stock });
            dtv_productos.Location = new Point(12, 230);
            dtv_productos.Name = "dtv_productos";
            dtv_productos.RowHeadersWidth = 62;
            dtv_productos.Size = new Size(636, 375);
            dtv_productos.TabIndex = 2;
            // 
            // clm_id
            // 
            clm_id.HeaderText = "Id";
            clm_id.MinimumWidth = 8;
            clm_id.Name = "clm_id";
            clm_id.Width = 150;
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
            clm_precio.HeaderText = "precio";
            clm_precio.MinimumWidth = 8;
            clm_precio.Name = "clm_precio";
            clm_precio.Width = 150;
            // 
            // clm_stock
            // 
            clm_stock.HeaderText = "Strock";
            clm_stock.MinimumWidth = 8;
            clm_stock.Name = "clm_stock";
            clm_stock.Width = 150;
            // 
            // grp_busqueda
            // 
            grp_busqueda.BackColor = SystemColors.InactiveBorder;
            grp_busqueda.Controls.Add(rb_nombre);
            grp_busqueda.Controls.Add(rb_codigo);
            grp_busqueda.Controls.Add(textBox1);
            grp_busqueda.Location = new Point(3, 3);
            grp_busqueda.Name = "grp_busqueda";
            grp_busqueda.Size = new Size(645, 86);
            grp_busqueda.TabIndex = 1;
            grp_busqueda.TabStop = false;
            grp_busqueda.Text = "busqueda";
            // 
            // rb_nombre
            // 
            rb_nombre.AutoSize = true;
            rb_nombre.Location = new Point(458, 32);
            rb_nombre.Name = "rb_nombre";
            rb_nombre.Size = new Size(103, 29);
            rb_nombre.TabIndex = 5;
            rb_nombre.Text = "Nombre";
            rb_nombre.UseVisualStyleBackColor = true;
            // 
            // rb_codigo
            // 
            rb_codigo.AutoSize = true;
            rb_codigo.Checked = true;
            rb_codigo.Location = new Point(356, 32);
            rb_codigo.Name = "rb_codigo";
            rb_codigo.Size = new Size(96, 29);
            rb_codigo.TabIndex = 4;
            rb_codigo.TabStop = true;
            rb_codigo.Text = "Codigo";
            rb_codigo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // gbx_venta
            // 
            gbx_venta.BackColor = SystemColors.InactiveBorder;
            gbx_venta.Controls.Add(textBox3);
            gbx_venta.Controls.Add(btn_eliminar);
            gbx_venta.Controls.Add(textBox2);
            gbx_venta.Controls.Add(btn_agregar);
            gbx_venta.Controls.Add(lbl_cantidad);
            gbx_venta.Controls.Add(lbl_nombre);
            gbx_venta.Location = new Point(12, 95);
            gbx_venta.Name = "gbx_venta";
            gbx_venta.Size = new Size(636, 105);
            gbx_venta.TabIndex = 0;
            gbx_venta.TabStop = false;
            gbx_venta.Text = "datos articulo";
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = SystemColors.ActiveCaption;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(539, 65);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(91, 34);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(539, 25);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(91, 34);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(284, 42);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(80, 25);
            lbl_cantidad.TabIndex = 1;
            lbl_cantidad.Text = "cantidad";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(13, 41);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(84, 25);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "nombre: ";
            // 
            // gbx_metodo
            // 
            gbx_metodo.Controls.Add(rb_tarjeta);
            gbx_metodo.Controls.Add(rb_efectivo);
            gbx_metodo.Location = new Point(11, 10);
            gbx_metodo.Name = "gbx_metodo";
            gbx_metodo.Size = new Size(433, 79);
            gbx_metodo.TabIndex = 0;
            gbx_metodo.TabStop = false;
            gbx_metodo.Text = "Metodo de pago";
            gbx_metodo.Enter += gbx_metodo_Enter;
            // 
            // rb_tarjeta
            // 
            rb_tarjeta.AutoSize = true;
            rb_tarjeta.Location = new Point(216, 25);
            rb_tarjeta.Name = "rb_tarjeta";
            rb_tarjeta.Size = new Size(87, 29);
            rb_tarjeta.TabIndex = 7;
            rb_tarjeta.Text = "Tarjeta";
            rb_tarjeta.UseVisualStyleBackColor = true;
            // 
            // rb_efectivo
            // 
            rb_efectivo.AutoSize = true;
            rb_efectivo.Checked = true;
            rb_efectivo.Location = new Point(114, 25);
            rb_efectivo.Name = "rb_efectivo";
            rb_efectivo.Size = new Size(99, 29);
            rb_efectivo.TabIndex = 6;
            rb_efectivo.TabStop = true;
            rb_efectivo.Text = "Efectivo";
            rb_efectivo.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 31);
            textBox3.TabIndex = 7;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1452, 636);
            Controls.Add(sc_venta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVenta";
            Text = "Compra";
            Load += frmVenta_Load;
            sc_venta.Panel1.ResumeLayout(false);
            sc_venta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_venta).EndInit();
            sc_venta.ResumeLayout(false);
            grbox_carrito.ResumeLayout(false);
            grbox_carrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtv_productos).EndInit();
            grp_busqueda.ResumeLayout(false);
            grp_busqueda.PerformLayout();
            gbx_venta.ResumeLayout(false);
            gbx_venta.PerformLayout();
            gbx_metodo.ResumeLayout(false);
            gbx_metodo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer sc_venta;
        private GroupBox gbx_venta;
        private GroupBox gbx_metodo;
        private GroupBox grp_busqueda;
        private DataGridView dtv_productos;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_precio;
        private DataGridViewTextBoxColumn clm_stock;
        private Button btn_terminar;
        private Button btn_limpiar;
        private TextBox textBox1;
        private Label lbl_cantidad;
        private Label lbl_nombre;
        private GroupBox grbox_carrito;
        private Button btn_agregar;
        private TextBox textBox2;
        private Label lbl_nombreBusqueda;
        private ListBox listBox2;
        private ListBox listBox1;
        private ListBox lb_Producto;
        private Label lbl_total;
        private Label lbl_IVA;
        private Label lbl_subtotal;
        private Label lbl_Concepto;
        private Label lbl_xcantidad;
        private Label lbl_producto;
        private TextBox txt_Subtotal;
        private TextBox txt_IVA;
        private TextBox txt_total;
        private RadioButton rb_codigo;
        private Button btn_eliminar;
        private RadioButton rb_nombre;
        private TextBox textBox3;
        private RadioButton rb_tarjeta;
        private RadioButton rb_efectivo;
    }
}