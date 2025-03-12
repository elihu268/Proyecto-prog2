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
            sp_efectivo = new Splitter();
            sp_compra = new Splitter();
            dgv_productos = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_precio = new DataGridViewTextBoxColumn();
            clm_stock = new DataGridViewTextBoxColumn();
            gpBox_producto = new GroupBox();
            txt_buscar = new TextBox();
            lbl_precio = new Label();
            lbl_nombre = new Label();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            gpbox_carrito = new GroupBox();
            lbl_descuento = new Label();
            dataGridView1 = new DataGridView();
            clm_c_nombre = new DataGridViewTextBoxColumn();
            clm_c_cantidad = new DataGridViewTextBoxColumn();
            clm_c_precio = new DataGridViewTextBoxColumn();
            lbl_total = new Label();
            lbl_IVA = new Label();
            lbl_subtotal = new Label();
            btnTrjeta = new Button();
            btn_limpiar = new Button();
            gpbox_cliente = new GroupBox();
            btn_tarjeta = new Button();
            sp_tarjeta = new Splitter();
            this.gpbox_tarjeta = new GroupBox();
            gpbox_efectivo = new GroupBox();
            btn_terminar = new Button();
            lbl_cantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            gpBox_producto.SuspendLayout();
            gpbox_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sp_efectivo
            // 
            sp_efectivo.Location = new Point(0, 0);
            sp_efectivo.Name = "sp_efectivo";
            sp_efectivo.Size = new Size(339, 612);
            sp_efectivo.TabIndex = 4;
            sp_efectivo.TabStop = false;
            sp_efectivo.SplitterMoved += sp_efectivo_SplitterMoved;
            // 
            // sp_compra
            // 
            sp_compra.Location = new Point(339, 0);
            sp_compra.Name = "sp_compra";
            sp_compra.Size = new Size(1215, 612);
            sp_compra.TabIndex = 5;
            sp_compra.TabStop = false;
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clm_nombre, clm_precio, clm_stock });
            dgv_productos.Location = new Point(355, 276);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.Size = new Size(617, 324);
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
            gpBox_producto.Controls.Add(lbl_cantidad);
            gpBox_producto.Controls.Add(txt_buscar);
            gpBox_producto.Controls.Add(lbl_precio);
            gpBox_producto.Controls.Add(lbl_nombre);
            gpBox_producto.Controls.Add(btn_agregar);
            gpBox_producto.Location = new Point(355, 122);
            gpBox_producto.Name = "gpBox_producto";
            gpBox_producto.Size = new Size(623, 148);
            gpBox_producto.TabIndex = 8;
            gpBox_producto.TabStop = false;
            gpBox_producto.Text = "Producto";
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(99, 15);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(407, 31);
            txt_buscar.TabIndex = 0;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(196, 71);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(60, 25);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(19, 71);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(505, 108);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 34);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(53, 279);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 34);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // gpbox_carrito
            // 
            gpbox_carrito.BackColor = SystemColors.InactiveBorder;
            gpbox_carrito.Controls.Add(btn_tarjeta);
            gpbox_carrito.Controls.Add(lbl_descuento);
            gpbox_carrito.Controls.Add(dataGridView1);
            gpbox_carrito.Controls.Add(lbl_total);
            gpbox_carrito.Controls.Add(lbl_IVA);
            gpbox_carrito.Controls.Add(btn_eliminar);
            gpbox_carrito.Controls.Add(lbl_subtotal);
            gpbox_carrito.Controls.Add(btnTrjeta);
            gpbox_carrito.Controls.Add(btn_limpiar);
            gpbox_carrito.Location = new Point(996, 38);
            gpbox_carrito.Name = "gpbox_carrito";
            gpbox_carrito.Size = new Size(548, 543);
            gpbox_carrito.TabIndex = 7;
            gpbox_carrito.TabStop = false;
            gpbox_carrito.Text = "Carrito";
            // 
            // lbl_descuento
            // 
            lbl_descuento.AutoSize = true;
            lbl_descuento.Location = new Point(231, 298);
            lbl_descuento.Name = "lbl_descuento";
            lbl_descuento.Size = new Size(96, 25);
            lbl_descuento.TabIndex = 12;
            lbl_descuento.Text = "Descuento";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_c_nombre, clm_c_cantidad, clm_c_precio });
            dataGridView1.Location = new Point(16, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(516, 208);
            dataGridView1.TabIndex = 11;
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
            lbl_total.Location = new Point(278, 368);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 10;
            lbl_total.Text = "Total";
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(288, 334);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(39, 25);
            lbl_IVA.TabIndex = 9;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(248, 263);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(79, 25);
            lbl_subtotal.TabIndex = 8;
            lbl_subtotal.Text = "Subtotal";
            // 
            // btnTrjeta
            // 
            btnTrjeta.Location = new Point(23, 470);
            btnTrjeta.Name = "btnTrjeta";
            btnTrjeta.Size = new Size(128, 34);
            btnTrjeta.TabIndex = 4;
            btnTrjeta.Text = "Efectivo";
            btnTrjeta.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(53, 334);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 34);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // gpbox_cliente
            // 
            gpbox_cliente.BackColor = SystemColors.InactiveBorder;
            gpbox_cliente.Location = new Point(355, 38);
            gpbox_cliente.Name = "gpbox_cliente";
            gpbox_cliente.Size = new Size(623, 78);
            gpbox_cliente.TabIndex = 6;
            gpbox_cliente.TabStop = false;
            gpbox_cliente.Text = "Cliente";
            // 
            // btn_tarjeta
            // 
            btn_tarjeta.Location = new Point(312, 461);
            btn_tarjeta.Name = "btn_tarjeta";
            btn_tarjeta.Size = new Size(128, 34);
            btn_tarjeta.TabIndex = 13;
            btn_tarjeta.Text = "Tarjeta";
            btn_tarjeta.UseVisualStyleBackColor = true;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(373, 73);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(83, 25);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "Cantidad";
            // 
            // sp_tarjeta
            // 
            sp_tarjeta.Location = new Point(1554, 0);
            sp_tarjeta.Name = "sp_tarjeta";
            sp_tarjeta.Size = new Size(358, 612);
            sp_tarjeta.TabIndex = 10;
            sp_tarjeta.TabStop = false;
            // 
            // gpbox_tarjeta
            // 
            this.gpbox_tarjeta.Location = new Point(1560, 12);
            this.gpbox_tarjeta.Name = "gpbox_tarjeta";
            this.gpbox_tarjeta.Size = new Size(342, 588);
            this.gpbox_tarjeta.TabIndex = 11;
            this.gpbox_tarjeta.TabStop = false;
            this.gpbox_tarjeta.Text = "Tarjeta";
            // 
            // gpbox_efectivo
            // 
            gpbox_efectivo.Location = new Point(12, 12);
            gpbox_efectivo.Name = "gpbox_efectivo";
            gpbox_efectivo.Size = new Size(321, 588);
            gpbox_efectivo.TabIndex = 13;
            gpbox_efectivo.TabStop = false;
            gpbox_efectivo.Text = "Efectivo";
            // 
            // btn_terminar
            // 
            btn_terminar.Location = new Point(112, 547);
            btn_terminar.Name = "btn_terminar";
            btn_terminar.Size = new Size(112, 34);
            btn_terminar.TabIndex = 13;
            btn_terminar.Text = "Terminar compra";
            btn_terminar.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1924, 612);
            Controls.Add(btn_terminar);
            Controls.Add(gpbox_efectivo);
            Controls.Add(this.gpbox_tarjeta);
            Controls.Add(sp_tarjeta);
            Controls.Add(dgv_productos);
            Controls.Add(gpBox_producto);
            Controls.Add(gpbox_carrito);
            Controls.Add(gpbox_cliente);
            Controls.Add(sp_compra);
            Controls.Add(sp_efectivo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVenta";
            Text = "Compra";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            gpBox_producto.ResumeLayout(false);
            gpBox_producto.PerformLayout();
            gpbox_carrito.ResumeLayout(false);
            gpbox_carrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_nombreBusqueda;
        private Splitter sp_efectivo;
        private Splitter sp_compra;
        private DataGridView dgv_productos;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_precio;
        private DataGridViewTextBoxColumn clm_stock;
        private GroupBox gpBox_producto;
        private TextBox txt_buscar;
        private Label lbl_precio;
        private Label lbl_nombre;
        private Button btn_agregar;
        private Button btn_eliminar;
        private GroupBox gpbox_carrito;
        private Label lbl_descuento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_c_nombre;
        private DataGridViewTextBoxColumn clm_c_cantidad;
        private DataGridViewTextBoxColumn clm_c_precio;
        private Label lbl_total;
        private Label lbl_IVA;
        private Label lbl_subtotal;
        private Button btnTrjeta;
        private Button btn_limpiar;
        private GroupBox gpbox_cliente;
        private Button btn_tarjeta;
        private Splitter sp_tarjeta;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox gpbox_efectivo;
        private Button btn_terminar;
    }
}