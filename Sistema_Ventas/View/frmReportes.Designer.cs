namespace PuntodeVenta.View
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            gbxFiltroVentas = new GroupBox();
            cbFecha = new CheckBox();
            lblNomProducto = new Label();
            cbxNomProducto = new ComboBox();
            cbProducto = new CheckBox();
            lblNomCliente = new Label();
            cbxNomCliente = new ComboBox();
            cbCliente = new CheckBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            btnGenerarReporte = new Button();
            dgvReporteVentas = new DataGridView();
            idVt = new DataGridViewTextBoxColumn();
            fechaVt = new DataGridViewTextBoxColumn();
            clienteVt = new DataGridViewTextBoxColumn();
            productoVt = new DataGridViewTextBoxColumn();
            cantidadVt = new DataGridViewTextBoxColumn();
            precioUniVt = new DataGridViewTextBoxColumn();
            gbxFiltroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltroVentas
            // 
            gbxFiltroVentas.BackColor = SystemColors.GradientInactiveCaption;
            gbxFiltroVentas.Controls.Add(cbFecha);
            gbxFiltroVentas.Controls.Add(lblNomProducto);
            gbxFiltroVentas.Controls.Add(cbxNomProducto);
            gbxFiltroVentas.Controls.Add(cbProducto);
            gbxFiltroVentas.Controls.Add(lblNomCliente);
            gbxFiltroVentas.Controls.Add(cbxNomCliente);
            gbxFiltroVentas.Controls.Add(cbCliente);
            gbxFiltroVentas.Controls.Add(dtpFechaFin);
            gbxFiltroVentas.Controls.Add(dtpFechaInicio);
            gbxFiltroVentas.Controls.Add(lblFechaFin);
            gbxFiltroVentas.Controls.Add(lblFechaInicio);
            gbxFiltroVentas.Controls.Add(btnGenerarReporte);
            gbxFiltroVentas.Dock = DockStyle.Top;
            gbxFiltroVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxFiltroVentas.Location = new Point(0, 0);
            gbxFiltroVentas.Margin = new Padding(4, 5, 4, 5);
            gbxFiltroVentas.Name = "gbxFiltroVentas";
            gbxFiltroVentas.Padding = new Padding(4, 5, 4, 5);
            gbxFiltroVentas.Size = new Size(838, 328);
            gbxFiltroVentas.TabIndex = 0;
            gbxFiltroVentas.TabStop = false;
            gbxFiltroVentas.Text = "Filtrado de ventas";
            gbxFiltroVentas.Enter += gbxFiltroVentas_Enter;
            // 
            // cbFecha
            // 
            cbFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbFecha.AutoSize = true;
            cbFecha.Location = new Point(314, 145);
            cbFecha.Margin = new Padding(4, 5, 4, 5);
            cbFecha.Name = "cbFecha";
            cbFecha.Size = new Size(228, 29);
            cbFecha.TabIndex = 24;
            cbFecha.Text = "Por intervalo de fechas";
            cbFecha.UseVisualStyleBackColor = true;
            cbFecha.CheckedChanged += cbFecha_CheckedChanged;
            // 
            // lblNomProducto
            // 
            lblNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNomProducto.AutoSize = true;
            lblNomProducto.Enabled = false;
            lblNomProducto.Location = new Point(477, 73);
            lblNomProducto.Margin = new Padding(4, 0, 4, 0);
            lblNomProducto.Name = "lblNomProducto";
            lblNomProducto.Size = new Size(117, 50);
            lblNomProducto.TabIndex = 23;
            lblNomProducto.Text = "Nombre del \r\nproducto";
            // 
            // cbxNomProducto
            // 
            cbxNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxNomProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomProducto.Enabled = false;
            cbxNomProducto.FormattingEnabled = true;
            cbxNomProducto.Location = new Point(589, 78);
            cbxNomProducto.Margin = new Padding(4, 5, 4, 5);
            cbxNomProducto.Name = "cbxNomProducto";
            cbxNomProducto.Size = new Size(213, 33);
            cbxNomProducto.TabIndex = 22;
            // 
            // cbProducto
            // 
            cbProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbProducto.AutoSize = true;
            cbProducto.Location = new Point(465, 37);
            cbProducto.Margin = new Padding(4, 5, 4, 5);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(135, 29);
            cbProducto.TabIndex = 21;
            cbProducto.Text = "Por artículo";
            cbProducto.UseVisualStyleBackColor = true;
            cbProducto.CheckedChanged += cbProducto_CheckedChanged;
            // 
            // lblNomCliente
            // 
            lblNomCliente.AutoSize = true;
            lblNomCliente.Enabled = false;
            lblNomCliente.Location = new Point(29, 73);
            lblNomCliente.Margin = new Padding(4, 0, 4, 0);
            lblNomCliente.Name = "lblNomCliente";
            lblNomCliente.Size = new Size(117, 50);
            lblNomCliente.TabIndex = 20;
            lblNomCliente.Text = "Nombre del \r\ncliente";
            // 
            // cbxNomCliente
            // 
            cbxNomCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomCliente.Enabled = false;
            cbxNomCliente.FormattingEnabled = true;
            cbxNomCliente.Location = new Point(141, 78);
            cbxNomCliente.Margin = new Padding(4, 5, 4, 5);
            cbxNomCliente.Name = "cbxNomCliente";
            cbxNomCliente.Size = new Size(213, 33);
            cbxNomCliente.TabIndex = 19;
            cbxNomCliente.SelectedIndexChanged += cbxNomCliente_SelectedIndexChanged;
            // 
            // cbCliente
            // 
            cbCliente.AutoSize = true;
            cbCliente.Location = new Point(29, 37);
            cbCliente.Margin = new Padding(4, 5, 4, 5);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(162, 29);
            cbCliente.TabIndex = 7;
            cbCliente.Text = "Por comprador";
            cbCliente.UseVisualStyleBackColor = true;
            cbCliente.CheckedChanged += cbCliente_CheckedChanged;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpFechaFin.Enabled = false;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(589, 187);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.MaxDate = new DateTime(2025, 3, 13, 1, 25, 0, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(213, 31);
            dtpFechaFin.TabIndex = 6;
            dtpFechaFin.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Enabled = false;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(141, 187);
            dtpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtpFechaInicio.MaxDate = new DateTime(2025, 3, 13, 1, 25, 12, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(213, 31);
            dtpFechaInicio.TabIndex = 5;
            dtpFechaInicio.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // lblFechaFin
            // 
            lblFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(477, 193);
            lblFechaFin.Margin = new Padding(4, 0, 4, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(99, 25);
            lblFechaFin.TabIndex = 4;
            lblFechaFin.Text = "Fecha final";
            lblFechaFin.Click += lblFechaFin_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(29, 193);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(111, 25);
            lblFechaInicio.TabIndex = 3;
            lblFechaInicio.Text = "Fecha inicial";
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGenerarReporte.AutoSize = true;
            btnGenerarReporte.BackColor = SystemColors.ActiveCaption;
            btnGenerarReporte.Image = Sistema_Ventas.Properties.Resources.generarReporte;
            btnGenerarReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarReporte.Location = new Point(380, 240);
            btnGenerarReporte.Margin = new Padding(4, 5, 4, 5);
            btnGenerarReporte.MaximumSize = new Size(107, 50);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(107, 50);
            btnGenerarReporte.TabIndex = 2;
            btnGenerarReporte.Text = "Generar";
            btnGenerarReporte.TextAlign = ContentAlignment.MiddleRight;
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // dgvReporteVentas
            // 
            dgvReporteVentas.AllowUserToAddRows = false;
            dgvReporteVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporteVentas.BackgroundColor = SystemColors.ActiveCaption;
            dgvReporteVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteVentas.Columns.AddRange(new DataGridViewColumn[] { idVt, fechaVt, clienteVt, productoVt, cantidadVt, precioUniVt });
            dgvReporteVentas.Location = new Point(0, 361);
            dgvReporteVentas.Name = "dgvReporteVentas";
            dgvReporteVentas.ReadOnly = true;
            dgvReporteVentas.RowHeadersWidth = 62;
            dgvReporteVentas.Size = new Size(838, 437);
            dgvReporteVentas.TabIndex = 5;
            dgvReporteVentas.CellContentClick += dgvReporteVentas_CellContentClick;
            // 
            // idVt
            // 
            idVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idVt.HeaderText = "ID";
            idVt.MinimumWidth = 10;
            idVt.Name = "idVt";
            idVt.ReadOnly = true;
            // 
            // fechaVt
            // 
            fechaVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaVt.HeaderText = "Fecha";
            fechaVt.MinimumWidth = 10;
            fechaVt.Name = "fechaVt";
            fechaVt.ReadOnly = true;
            // 
            // clienteVt
            // 
            clienteVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clienteVt.HeaderText = "Cliente";
            clienteVt.MinimumWidth = 10;
            clienteVt.Name = "clienteVt";
            clienteVt.ReadOnly = true;
            // 
            // productoVt
            // 
            productoVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productoVt.HeaderText = "Producto";
            productoVt.MinimumWidth = 10;
            productoVt.Name = "productoVt";
            productoVt.ReadOnly = true;
            // 
            // cantidadVt
            // 
            cantidadVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidadVt.HeaderText = "Cantidad";
            cantidadVt.MinimumWidth = 10;
            cantidadVt.Name = "cantidadVt";
            cantidadVt.ReadOnly = true;
            // 
            // precioUniVt
            // 
            precioUniVt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precioUniVt.HeaderText = "Precio Unitario";
            precioUniVt.MinimumWidth = 10;
            precioUniVt.Name = "precioUniVt";
            precioUniVt.ReadOnly = true;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(838, 797);
            Controls.Add(dgvReporteVentas);
            Controls.Add(gbxFiltroVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReportes";
            Text = "Reportes de ventas";
            Load += frmReportes_Load;
            gbxFiltroVentas.ResumeLayout(false);
            gbxFiltroVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxFiltroVentas;
        private Button btnGenerarReporte;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private CheckBox cbCliente;
        private ComboBox cbxNomCliente;
        private Label lblNomCliente;
        private CheckBox cbProducto;
        private Label lblNomProducto;
        private ComboBox cbxNomProducto;
        private CheckBox cbFecha;
        private DataGridView dgvReporteVentas;
        private DataGridViewTextBoxColumn idVt;
        private DataGridViewTextBoxColumn fechaVt;
        private DataGridViewTextBoxColumn clienteVt;
        private DataGridViewTextBoxColumn productoVt;
        private DataGridViewTextBoxColumn cantidadVt;
        private DataGridViewTextBoxColumn precioUniVt;
    }
}