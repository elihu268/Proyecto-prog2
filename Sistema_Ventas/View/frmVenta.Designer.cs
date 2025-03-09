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
            grp_busqueda = new GroupBox();
            gbx_venta = new GroupBox();
            gbx_metodo = new GroupBox();
            dtv_productos = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_nombre = new DataGridViewTextBoxColumn();
            clm_precio = new DataGridViewTextBoxColumn();
            clm_stock = new DataGridViewTextBoxColumn();
            btn_terminar = new Button();
            btn_limpiar = new Button();
            lbl_nombre = new Label();
            lbl_cantidad = new Label();
            textBox1 = new TextBox();
            nud_cantidad = new NumericUpDown();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            grbox_carrito = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)sc_venta).BeginInit();
            sc_venta.Panel1.SuspendLayout();
            sc_venta.Panel2.SuspendLayout();
            sc_venta.SuspendLayout();
            grp_busqueda.SuspendLayout();
            gbx_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtv_productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            grbox_carrito.SuspendLayout();
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
            sc_venta.Panel1.Controls.Add(btn_terminar);
            sc_venta.Panel1.Controls.Add(dtv_productos);
            sc_venta.Panel1.Controls.Add(grp_busqueda);
            sc_venta.Panel1.Controls.Add(gbx_venta);
            // 
            // sc_venta.Panel2
            // 
            sc_venta.Panel2.Controls.Add(gbx_metodo);
            sc_venta.Panel2.Paint += splitContainer1_Panel2_Paint;
            sc_venta.Size = new Size(1452, 636);
            sc_venta.SplitterDistance = 992;
            sc_venta.TabIndex = 0;
            // 
            // grp_busqueda
            // 
            grp_busqueda.Controls.Add(textBox1);
            grp_busqueda.Location = new Point(3, 3);
            grp_busqueda.Name = "grp_busqueda";
            grp_busqueda.Size = new Size(986, 86);
            grp_busqueda.TabIndex = 1;
            grp_busqueda.TabStop = false;
            grp_busqueda.Text = "busqueda";
            // 
            // gbx_venta
            // 
            gbx_venta.Controls.Add(btn_agregar);
            gbx_venta.Controls.Add(nud_cantidad);
            gbx_venta.Controls.Add(lbl_cantidad);
            gbx_venta.Controls.Add(lbl_nombre);
            gbx_venta.Location = new Point(12, 95);
            gbx_venta.Name = "gbx_venta";
            gbx_venta.Size = new Size(977, 105);
            gbx_venta.TabIndex = 0;
            gbx_venta.TabStop = false;
            gbx_venta.Text = "datos articulo";
            // 
            // gbx_metodo
            // 
            gbx_metodo.Location = new Point(11, 10);
            gbx_metodo.Name = "gbx_metodo";
            gbx_metodo.Size = new Size(433, 623);
            gbx_metodo.TabIndex = 0;
            gbx_metodo.TabStop = false;
            gbx_metodo.Text = "Metodo de pago";
            gbx_metodo.Enter += gbx_metodo_Enter;
            // 
            // dtv_productos
            // 
            dtv_productos.AllowUserToAddRows = false;
            dtv_productos.AllowUserToDeleteRows = false;
            dtv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtv_productos.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_nombre, clm_precio, clm_stock });
            dtv_productos.Location = new Point(41, 250);
            dtv_productos.Name = "dtv_productos";
            dtv_productos.RowHeadersWidth = 62;
            dtv_productos.Size = new Size(606, 225);
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
            // btn_terminar
            // 
            btn_terminar.BackColor = SystemColors.ActiveCaption;
            btn_terminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_terminar.Location = new Point(287, 590);
            btn_terminar.Name = "btn_terminar";
            btn_terminar.Size = new Size(195, 34);
            btn_terminar.TabIndex = 3;
            btn_terminar.Text = "Terminar Compra";
            btn_terminar.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.ActiveCaption;
            btn_limpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(55, 321);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(195, 34);
            btn_limpiar.TabIndex = 4;
            btn_limpiar.Text = "limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(19, 30);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(84, 25);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "nombre: ";
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(163, 29);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(80, 25);
            lbl_cantidad.TabIndex = 1;
            lbl_cantidad.Text = "cantidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Location = new Point(167, 61);
            nud_cantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nud_cantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(180, 31);
            nud_cantidad.TabIndex = 2;
            nud_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(427, 65);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(91, 34);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = SystemColors.ActiveCaption;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(55, 267);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(195, 34);
            btn_eliminar.TabIndex = 5;
            btn_eliminar.Text = "eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // grbox_carrito
            // 
            grbox_carrito.Controls.Add(btn_eliminar);
            grbox_carrito.Controls.Add(btn_limpiar);
            grbox_carrito.Location = new Point(671, 202);
            grbox_carrito.Name = "grbox_carrito";
            grbox_carrito.Size = new Size(300, 410);
            grbox_carrito.TabIndex = 5;
            grbox_carrito.TabStop = false;
            grbox_carrito.Text = "Carrito de compras";
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
            grp_busqueda.ResumeLayout(false);
            grp_busqueda.PerformLayout();
            gbx_venta.ResumeLayout(false);
            gbx_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtv_productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            grbox_carrito.ResumeLayout(false);
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
        private NumericUpDown nud_cantidad;
        private Label lbl_cantidad;
        private Label lbl_nombre;
        private GroupBox grbox_carrito;
        private Button btn_eliminar;
        private Button btn_agregar;
    }
}