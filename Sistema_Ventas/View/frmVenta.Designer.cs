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
            gpbox_busqueda = new GroupBox();
            gpbox_carrito = new GroupBox();
            gpBox_producto = new GroupBox();
            dgv_productos = new DataGridView();
            clmCodigo = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_precio = new DataGridViewTextBoxColumn();
            clm_stock = new DataGridViewTextBoxColumn();
            btnTerminar = new Button();
            btn_agregar = new Button();
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            txt_buscar = new TextBox();
            lbl_nombre = new Label();
            lbl_precio = new Label();
            listBox1 = new ListBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            lbl_subtotal = new Label();
            lbl_IVA = new Label();
            lbl_total = new Label();
            gpbox_busqueda.SuspendLayout();
            gpbox_carrito.SuspendLayout();
            gpBox_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).BeginInit();
            SuspendLayout();
            // 
            // gpbox_busqueda
            // 
            gpbox_busqueda.BackColor = SystemColors.InactiveBorder;
            gpbox_busqueda.Controls.Add(txt_buscar);
            gpbox_busqueda.Location = new Point(12, 43);
            gpbox_busqueda.Name = "gpbox_busqueda";
            gpbox_busqueda.Size = new Size(674, 78);
            gpbox_busqueda.TabIndex = 0;
            gpbox_busqueda.TabStop = false;
            gpbox_busqueda.Text = "Buscar";
            // 
            // gpbox_carrito
            // 
            gpbox_carrito.BackColor = SystemColors.InactiveBorder;
            gpbox_carrito.Controls.Add(lbl_total);
            gpbox_carrito.Controls.Add(lbl_IVA);
            gpbox_carrito.Controls.Add(lbl_subtotal);
            gpbox_carrito.Controls.Add(btnTerminar);
            gpbox_carrito.Controls.Add(listBox2);
            gpbox_carrito.Controls.Add(listBox3);
            gpbox_carrito.Controls.Add(listBox1);
            gpbox_carrito.Controls.Add(btn_limpiar);
            gpbox_carrito.Location = new Point(724, 43);
            gpbox_carrito.Name = "gpbox_carrito";
            gpbox_carrito.Size = new Size(426, 543);
            gpbox_carrito.TabIndex = 1;
            gpbox_carrito.TabStop = false;
            gpbox_carrito.Text = "Carrito";
            // 
            // gpBox_producto
            // 
            gpBox_producto.BackColor = SystemColors.InactiveBorder;
            gpBox_producto.Controls.Add(lbl_precio);
            gpBox_producto.Controls.Add(lbl_nombre);
            gpBox_producto.Controls.Add(btn_agregar);
            gpBox_producto.Controls.Add(btn_eliminar);
            gpBox_producto.Location = new Point(16, 130);
            gpBox_producto.Name = "gpBox_producto";
            gpBox_producto.Size = new Size(670, 99);
            gpBox_producto.TabIndex = 2;
            gpBox_producto.TabStop = false;
            gpBox_producto.Text = "Producto";
            // 
            // dgv_productos
            // 
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productos.Columns.AddRange(new DataGridViewColumn[] { clmCodigo, clm_nombre, clm_precio, clm_stock });
            dgv_productos.Location = new Point(16, 256);
            dgv_productos.Name = "dgv_productos";
            dgv_productos.RowHeadersWidth = 62;
            dgv_productos.Size = new Size(670, 225);
            dgv_productos.TabIndex = 3;
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
            // btnTerminar
            // 
            btnTerminar.Location = new Point(109, 484);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(219, 34);
            btnTerminar.TabIndex = 4;
            btnTerminar.Text = "Terminar compra";
            btnTerminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(526, 44);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(112, 34);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(157, 444);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(112, 34);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(408, 47);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 34);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(96, 33);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(407, 31);
            txt_buscar.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(15, 49);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(87, 25);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre: ";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(250, 56);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(60, 25);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(157, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(112, 154);
            listBox1.TabIndex = 4;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(26, 76);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(125, 154);
            listBox3.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(278, 76);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(119, 154);
            listBox2.TabIndex = 7;
            // 
            // lbl_subtotal
            // 
            lbl_subtotal.AutoSize = true;
            lbl_subtotal.Location = new Point(186, 254);
            lbl_subtotal.Name = "lbl_subtotal";
            lbl_subtotal.Size = new Size(79, 25);
            lbl_subtotal.TabIndex = 8;
            lbl_subtotal.Text = "Subtotal";
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new Point(195, 293);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new Size(39, 25);
            lbl_IVA.TabIndex = 9;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(190, 343);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 10;
            lbl_total.Text = "Total";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1162, 598);
            Controls.Add(dgv_productos);
            Controls.Add(gpBox_producto);
            Controls.Add(gpbox_carrito);
            Controls.Add(gpbox_busqueda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVenta";
            Text = "Compra";
            Load += frmVenta_Load;
            gpbox_busqueda.ResumeLayout(false);
            gpbox_busqueda.PerformLayout();
            gpbox_carrito.ResumeLayout(false);
            gpbox_carrito.PerformLayout();
            gpBox_producto.ResumeLayout(false);
            gpBox_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_nombreBusqueda;
        private GroupBox gpbox_busqueda;
        private GroupBox gpbox_carrito;
        private GroupBox gpBox_producto;
        private Button btn_agregar;
        private DataGridView dgv_productos;
        private DataGridViewTextBoxColumn clmCodigo;
        private DataGridViewTextBoxColumn clm_nombre;
        private DataGridViewTextBoxColumn clm_precio;
        private DataGridViewTextBoxColumn clm_stock;
        private Button btnTerminar;
        private TextBox txt_buscar;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox1;
        private Button btn_limpiar;
        private Label lbl_precio;
        private Label lbl_nombre;
        private Button btn_eliminar;
        private Label lbl_total;
        private Label lbl_IVA;
        private Label lbl_subtotal;
    }
}