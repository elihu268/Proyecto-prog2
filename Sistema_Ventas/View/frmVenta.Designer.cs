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
            btn_limpiar = new Button();
            gpbox_cliente = new GroupBox();
            btn_terminar = new Button();
            cb_metodo = new ComboBox();
            comboBox2 = new ComboBox();
            lbl_buscar_cliente = new Label();
            lbl_buscar_prod = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            txt_subtotal = new TextBox();
            txt_descuento = new TextBox();
            txt_IVA = new TextBox();
            txt_total = new TextBox();
            lbl_metodo = new Label();
            btn_actualizar = new Button();
            lbl_cantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            gpBox_producto.SuspendLayout();
            gpbox_carrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpbox_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(354, 76);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(83, 25);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "Cantidad";
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clm_nombre, clm_precio, clm_stock });
            dgv_productos.Location = new Point(12, 260);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.Size = new Size(668, 328);
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
            gpBox_producto.Controls.Add(btn_actualizar);
            gpBox_producto.Controls.Add(textBox3);
            gpBox_producto.Controls.Add(textBox2);
            gpBox_producto.Controls.Add(textBox1);
            gpBox_producto.Controls.Add(lbl_buscar_prod);
            gpBox_producto.Controls.Add(lbl_cantidad);
            gpBox_producto.Controls.Add(txt_buscar);
            gpBox_producto.Controls.Add(lbl_precio);
            gpBox_producto.Controls.Add(lbl_nombre);
            gpBox_producto.Controls.Add(btn_agregar);
            gpBox_producto.Location = new Point(12, 110);
            gpBox_producto.Name = "gpBox_producto";
            gpBox_producto.Size = new Size(663, 126);
            gpBox_producto.TabIndex = 8;
            gpBox_producto.TabStop = false;
            gpBox_producto.Text = "Producto";
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
            lbl_precio.Size = new Size(60, 25);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(6, 73);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(524, 24);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 34);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Actualizar";
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
            gpbox_carrito.Controls.Add(lbl_metodo);
            gpbox_carrito.Controls.Add(txt_total);
            gpbox_carrito.Controls.Add(txt_IVA);
            gpbox_carrito.Controls.Add(txt_descuento);
            gpbox_carrito.Controls.Add(txt_subtotal);
            gpbox_carrito.Controls.Add(cb_metodo);
            gpbox_carrito.Controls.Add(btn_terminar);
            gpbox_carrito.Controls.Add(lbl_descuento);
            gpbox_carrito.Controls.Add(dataGridView1);
            gpbox_carrito.Controls.Add(lbl_total);
            gpbox_carrito.Controls.Add(lbl_IVA);
            gpbox_carrito.Controls.Add(btn_eliminar);
            gpbox_carrito.Controls.Add(lbl_subtotal);
            gpbox_carrito.Controls.Add(btn_limpiar);
            gpbox_carrito.Location = new Point(698, 26);
            gpbox_carrito.Name = "gpbox_carrito";
            gpbox_carrito.Size = new Size(548, 562);
            gpbox_carrito.TabIndex = 7;
            gpbox_carrito.TabStop = false;
            gpbox_carrito.Text = "Carrito";
            // 
            // lbl_descuento
            // 
            lbl_descuento.AutoSize = true;
            lbl_descuento.Location = new Point(231, 310);
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
            lbl_total.Location = new Point(278, 383);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 10;
            lbl_total.Text = "Total";
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(288, 349);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(39, 25);
            lbl_IVA.TabIndex = 9;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(248, 273);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(79, 25);
            lbl_subtotal.TabIndex = 8;
            lbl_subtotal.Text = "Subtotal";
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
            gpbox_cliente.Controls.Add(lbl_buscar_cliente);
            gpbox_cliente.Controls.Add(comboBox2);
            gpbox_cliente.Location = new Point(12, 12);
            gpbox_cliente.Name = "gpbox_cliente";
            gpbox_cliente.Size = new Size(663, 92);
            gpbox_cliente.TabIndex = 6;
            gpbox_cliente.TabStop = false;
            gpbox_cliente.Text = "Cliente";
            // 
            // btn_terminar
            // 
            btn_terminar.Location = new Point(179, 502);
            btn_terminar.Name = "btn_terminar";
            btn_terminar.Size = new Size(198, 34);
            btn_terminar.TabIndex = 13;
            btn_terminar.Text = "Terminar compra";
            btn_terminar.UseVisualStyleBackColor = true;
            btn_terminar.Click += btn_terminar_Click;
            // 
            // cb_metodo
            // 
            cb_metodo.FormattingEnabled = true;
            cb_metodo.Location = new Point(356, 426);
            cb_metodo.Name = "cb_metodo";
            cb_metodo.Size = new Size(150, 33);
            cb_metodo.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(118, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(271, 33);
            comboBox2.TabIndex = 15;
            // 
            // lbl_buscar_cliente
            // 
            lbl_buscar_cliente.AutoSize = true;
            lbl_buscar_cliente.Location = new Point(34, 27);
            lbl_buscar_cliente.Name = "lbl_buscar_cliente";
            lbl_buscar_cliente.Size = new Size(63, 25);
            lbl_buscar_cliente.TabIndex = 16;
            lbl_buscar_cliente.Text = "Buscar";
            // 
            // lbl_buscar_prod
            // 
            lbl_buscar_prod.AutoSize = true;
            lbl_buscar_prod.Location = new Point(30, 27);
            lbl_buscar_prod.Name = "lbl_buscar_prod";
            lbl_buscar_prod.Size = new Size(63, 25);
            lbl_buscar_prod.TabIndex = 17;
            lbl_buscar_prod.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 31);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(84, 31);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(443, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(53, 31);
            textBox3.TabIndex = 20;
            // 
            // txt_subtotal
            // 
            txt_subtotal.Location = new Point(358, 266);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(150, 31);
            txt_subtotal.TabIndex = 15;
            // 
            // txt_descuento
            // 
            txt_descuento.Location = new Point(358, 307);
            txt_descuento.Name = "txt_descuento";
            txt_descuento.Size = new Size(150, 31);
            txt_descuento.TabIndex = 16;
            // 
            // txt_IVA
            // 
            txt_IVA.Location = new Point(358, 346);
            txt_IVA.Name = "txt_IVA";
            txt_IVA.Size = new Size(150, 31);
            txt_IVA.TabIndex = 17;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(356, 380);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(150, 31);
            txt_total.TabIndex = 18;
            // 
            // lbl_metodo
            // 
            lbl_metodo.AutoSize = true;
            lbl_metodo.Location = new Point(179, 434);
            lbl_metodo.Name = "lbl_metodo";
            lbl_metodo.Size = new Size(148, 25);
            lbl_metodo.TabIndex = 19;
            lbl_metodo.Text = "Metodo de pago";
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(524, 76);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(112, 34);
            btn_actualizar.TabIndex = 21;
            btn_actualizar.Text = "Agregar";
            btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1249, 612);
            Controls.Add(dgv_productos);
            Controls.Add(gpBox_producto);
            Controls.Add(gpbox_carrito);
            Controls.Add(gpbox_cliente);
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
        private Button btn_limpiar;
        private GroupBox gpbox_cliente;
        private GroupBox groupBox1;
        private Button btn_actualizar;
        private Button btn_terminar;
        private Label lbl_buscar_prod;
        private ComboBox cb_metodo;
        private Label lbl_buscar_cliente;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbl_metodo;
        private TextBox txt_total;
        private TextBox txt_IVA;
        private TextBox txt_descuento;
        private TextBox txt_subtotal;
    }
}