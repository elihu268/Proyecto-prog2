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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            gbxFiltroVentas = new GroupBox();
            btnExportarExcel = new Button();
            picBoxReportes = new PictureBox();
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
            toolTipDetalle = new ToolTip(components);
            gbxFiltroVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentas).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltroVentas
            // 
            gbxFiltroVentas.BackColor = SystemColors.GradientInactiveCaption;
            gbxFiltroVentas.Controls.Add(btnExportarExcel);
            gbxFiltroVentas.Controls.Add(picBoxReportes);
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
            gbxFiltroVentas.Name = "gbxFiltroVentas";
            gbxFiltroVentas.Size = new Size(587, 241);
            gbxFiltroVentas.TabIndex = 0;
            gbxFiltroVentas.TabStop = false;
            gbxFiltroVentas.Text = "Filtrado de ventas";
            gbxFiltroVentas.Enter += gbxFiltroVentas_Enter;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnExportarExcel.AutoSize = true;
            btnExportarExcel.BackColor = SystemColors.ActiveCaption;
            btnExportarExcel.Image = Sistema_Ventas.Properties.Resources.Excel1;
            btnExportarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarExcel.Location = new Point(246, 209);
            btnExportarExcel.MaximumSize = new Size(114, 32);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(114, 32);
            btnExportarExcel.TabIndex = 25;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.TextAlign = ContentAlignment.MiddleRight;
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // picBoxReportes
            // 
            picBoxReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picBoxReportes.Image = Sistema_Ventas.Properties.Resources.iconoPregunta;
            picBoxReportes.Location = new Point(285, 134);
            picBoxReportes.Name = "picBoxReportes";
            picBoxReportes.Size = new Size(33, 31);
            picBoxReportes.TabIndex = 23;
            picBoxReportes.TabStop = false;
            toolTipDetalle.SetToolTip(picBoxReportes, "Haz clic derecho sobre un registro para ver los detalles de la compra\r\nHaz doble clic sobre una celda para actualizar su contenido");
            // 
            // cbFecha
            // 
            cbFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbFecha.AutoSize = true;
            cbFecha.Location = new Point(220, 87);
            cbFecha.Name = "cbFecha";
            cbFecha.Size = new Size(146, 19);
            cbFecha.TabIndex = 24;
            cbFecha.Text = "Por intervalo de fechas";
            cbFecha.UseVisualStyleBackColor = true;
            cbFecha.CheckedChanged += cbFecha_CheckedChanged;
            // 
            // lblNomProducto
            // 
            lblNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNomProducto.AutoSize = true;
            lblNomProducto.ForeColor = SystemColors.Desktop;
            lblNomProducto.Location = new Point(317, 44);
            lblNomProducto.Name = "lblNomProducto";
            lblNomProducto.Size = new Size(73, 30);
            lblNomProducto.TabIndex = 23;
            lblNomProducto.Text = "Nombre del \r\nproducto";
            // 
            // cbxNomProducto
            // 
            cbxNomProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxNomProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomProducto.Enabled = false;
            cbxNomProducto.FormattingEnabled = true;
            cbxNomProducto.Location = new Point(395, 47);
            cbxNomProducto.Name = "cbxNomProducto";
            cbxNomProducto.Size = new Size(180, 23);
            cbxNomProducto.TabIndex = 22;
            cbxNomProducto.SelectedIndexChanged += cbxNomProducto_SelectedIndexChanged_1;
            // 
            // cbProducto
            // 
            cbProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbProducto.AutoSize = true;
            cbProducto.Location = new Point(316, 22);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(87, 19);
            cbProducto.TabIndex = 21;
            cbProducto.Text = "Por artículo";
            cbProducto.UseVisualStyleBackColor = true;
            cbProducto.CheckedChanged += cbProducto_CheckedChanged;
            // 
            // lblNomCliente
            // 
            lblNomCliente.AutoSize = true;
            lblNomCliente.ForeColor = SystemColors.Desktop;
            lblNomCliente.Location = new Point(20, 44);
            lblNomCliente.Name = "lblNomCliente";
            lblNomCliente.Size = new Size(73, 30);
            lblNomCliente.TabIndex = 20;
            lblNomCliente.Text = "Nombre del \r\ncliente";
            // 
            // cbxNomCliente
            // 
            cbxNomCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomCliente.Enabled = false;
            cbxNomCliente.FormattingEnabled = true;
            cbxNomCliente.Location = new Point(99, 47);
            cbxNomCliente.Name = "cbxNomCliente";
            cbxNomCliente.Size = new Size(180, 23);
            cbxNomCliente.TabIndex = 19;
            cbxNomCliente.SelectedIndexChanged += cbxNomCliente_SelectedIndexChanged;
            // 
            // cbCliente
            // 
            cbCliente.AutoSize = true;
            cbCliente.Location = new Point(20, 22);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(106, 19);
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
            dtpFechaFin.Location = new Point(395, 112);
            dtpFechaFin.MaxDate = new DateTime(2025, 3, 13, 1, 25, 0, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 23);
            dtpFechaFin.TabIndex = 6;
            dtpFechaFin.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Enabled = false;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(99, 112);
            dtpFechaInicio.MaxDate = new DateTime(2025, 3, 13, 1, 25, 12, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 23);
            dtpFechaInicio.TabIndex = 5;
            dtpFechaInicio.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // lblFechaFin
            // 
            lblFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFechaFin.AutoSize = true;
            lblFechaFin.ForeColor = SystemColors.Desktop;
            lblFechaFin.Location = new Point(317, 116);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(64, 15);
            lblFechaFin.TabIndex = 4;
            lblFechaFin.Text = "Fecha final";
            lblFechaFin.Click += lblFechaFin_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = SystemColors.Desktop;
            lblFechaInicio.Location = new Point(20, 116);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(72, 15);
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
            btnGenerarReporte.Location = new Point(266, 171);
            btnGenerarReporte.MaximumSize = new Size(75, 32);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(75, 32);
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
            dgvReporteVentas.Location = new Point(0, 246);
            dgvReporteVentas.Margin = new Padding(2);
            dgvReporteVentas.Name = "dgvReporteVentas";
            dgvReporteVentas.ReadOnly = true;
            dgvReporteVentas.RowHeadersWidth = 62;
            dgvReporteVentas.Size = new Size(587, 201);
            dgvReporteVentas.TabIndex = 5;
            dgvReporteVentas.CellMouseClick += dgvReporteVentas_CellMouseClick;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(587, 449);
            Controls.Add(dgvReporteVentas);
            Controls.Add(gbxFiltroVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportes";
            Text = "Reportes de ventas";
            Load += frmReportes_Load;
            gbxFiltroVentas.ResumeLayout(false);
            gbxFiltroVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxReportes).EndInit();
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
        private PictureBox picBoxReportes;
        private ToolTip toolTipDetalle;
        private Button btnExportarExcel;
    }
}