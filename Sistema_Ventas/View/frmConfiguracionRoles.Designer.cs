namespace Sistema_Ventas.View
{
    partial class frmConfiguracionRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionRoles));
            scRoles = new SplitContainer();
            gbxAltaEdicionRol = new GroupBox();
            lblInfo = new Label();
            picBoxFormato = new PictureBox();
            numIdRol = new NumericUpDown();
            btnGuardar = new Button();
            cbxEstatus = new ComboBox();
            lblEstatus = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            lblDescripcion = new Label();
            lblCodigo = new Label();
            lblIdRol = new Label();
            dgvRoles = new DataGridView();
            idRol = new DataGridViewTextBoxColumn();
            codigoRol = new DataGridViewTextBoxColumn();
            descripcionRol = new DataGridViewTextBoxColumn();
            estatusRol = new DataGridViewTextBoxColumn();
            gbxBusquedaRol = new GroupBox();
            cbxTipoFecha = new ComboBox();
            lblTipoFecha = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            btnActualizar = new Button();
            txtBusquedaRol = new TextBox();
            lblBuscar = new Label();
            gbxHerramienta = new GroupBox();
            btnColapsar = new Button();
            lblTituloRol = new Label();
            toolTipCodigo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)scRoles).BeginInit();
            scRoles.Panel1.SuspendLayout();
            scRoles.Panel2.SuspendLayout();
            scRoles.SuspendLayout();
            gbxAltaEdicionRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFormato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdRol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            gbxBusquedaRol.SuspendLayout();
            gbxHerramienta.SuspendLayout();
            SuspendLayout();
            // 
            // scRoles
            // 
            scRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scRoles.Location = new Point(-1, 54);
            scRoles.Name = "scRoles";
            // 
            // scRoles.Panel1
            // 
            scRoles.Panel1.Controls.Add(gbxAltaEdicionRol);
            // 
            // scRoles.Panel2
            // 
            scRoles.Panel2.Controls.Add(dgvRoles);
            scRoles.Panel2.Controls.Add(gbxBusquedaRol);
            scRoles.Panel2.Controls.Add(gbxHerramienta);
            scRoles.Size = new Size(1048, 521);
            scRoles.SplitterDistance = 285;
            scRoles.TabIndex = 6;
            // 
            // gbxAltaEdicionRol
            // 
            gbxAltaEdicionRol.Controls.Add(lblInfo);
            gbxAltaEdicionRol.Controls.Add(picBoxFormato);
            gbxAltaEdicionRol.Controls.Add(numIdRol);
            gbxAltaEdicionRol.Controls.Add(btnGuardar);
            gbxAltaEdicionRol.Controls.Add(cbxEstatus);
            gbxAltaEdicionRol.Controls.Add(lblEstatus);
            gbxAltaEdicionRol.Controls.Add(txtDescripcion);
            gbxAltaEdicionRol.Controls.Add(txtCodigo);
            gbxAltaEdicionRol.Controls.Add(lblDescripcion);
            gbxAltaEdicionRol.Controls.Add(lblCodigo);
            gbxAltaEdicionRol.Controls.Add(lblIdRol);
            gbxAltaEdicionRol.Dock = DockStyle.Fill;
            gbxAltaEdicionRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxAltaEdicionRol.Location = new Point(0, 0);
            gbxAltaEdicionRol.Margin = new Padding(4, 5, 4, 5);
            gbxAltaEdicionRol.Name = "gbxAltaEdicionRol";
            gbxAltaEdicionRol.Padding = new Padding(4, 5, 4, 5);
            gbxAltaEdicionRol.Size = new Size(285, 521);
            gbxAltaEdicionRol.TabIndex = 1;
            gbxAltaEdicionRol.TabStop = false;
            gbxAltaEdicionRol.Text = "Alta o Edición";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(109, 328);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(124, 15);
            lblInfo.TabIndex = 23;
            lblInfo.Text = "* Campos obligatorios";
            // 
            // picBoxFormato
            // 
            picBoxFormato.Image = Properties.Resources.iconoPregunta;
            picBoxFormato.Location = new Point(237, 129);
            picBoxFormato.Margin = new Padding(4, 5, 4, 5);
            picBoxFormato.Name = "picBoxFormato";
            picBoxFormato.Size = new Size(41, 55);
            picBoxFormato.TabIndex = 22;
            picBoxFormato.TabStop = false;
            toolTipCodigo.SetToolTip(picBoxFormato, "3 mayusculas que son el tipo de rol - 3 numeros que consisten en la categoria");
            // 
            // numIdRol
            // 
            numIdRol.Location = new Point(17, 72);
            numIdRol.Margin = new Padding(5, 8, 5, 8);
            numIdRol.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numIdRol.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIdRol.Name = "numIdRol";
            numIdRol.Size = new Size(261, 23);
            numIdRol.TabIndex = 21;
            numIdRol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(89, 380);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 48);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(17, 273);
            cbxEstatus.Margin = new Padding(4, 5, 4, 5);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(260, 23);
            cbxEstatus.TabIndex = 19;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(17, 245);
            lblEstatus.Margin = new Padding(4, 0, 4, 0);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(52, 15);
            lblEstatus.TabIndex = 18;
            lblEstatus.Text = "Estatus *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(17, 205);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(17, 135);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 15;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(211, 23);
            txtCodigo.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 178);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(78, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción *";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(17, 107);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(53, 15);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Código *";
            // 
            // lblIdRol
            // 
            lblIdRol.AutoSize = true;
            lblIdRol.Location = new Point(17, 37);
            lblIdRol.Margin = new Padding(4, 0, 4, 0);
            lblIdRol.Name = "lblIdRol";
            lblIdRol.Size = new Size(64, 15);
            lblIdRol.TabIndex = 10;
            lblIdRol.Text = "ID del rol *";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.BackgroundColor = SystemColors.ActiveCaption;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { idRol, codigoRol, descripcionRol, estatusRol });
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.Enabled = false;
            dgvRoles.Location = new Point(0, 217);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersWidth = 62;
            dgvRoles.Size = new Size(759, 304);
            dgvRoles.TabIndex = 14;
            // 
            // idRol
            // 
            idRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idRol.HeaderText = "ID";
            idRol.MinimumWidth = 10;
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            // 
            // codigoRol
            // 
            codigoRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codigoRol.HeaderText = "Código";
            codigoRol.MinimumWidth = 10;
            codigoRol.Name = "codigoRol";
            codigoRol.ReadOnly = true;
            // 
            // descripcionRol
            // 
            descripcionRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcionRol.HeaderText = "Descripción";
            descripcionRol.MinimumWidth = 10;
            descripcionRol.Name = "descripcionRol";
            descripcionRol.ReadOnly = true;
            // 
            // estatusRol
            // 
            estatusRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estatusRol.HeaderText = "Estatus";
            estatusRol.MinimumWidth = 10;
            estatusRol.Name = "estatusRol";
            estatusRol.ReadOnly = true;
            // 
            // gbxBusquedaRol
            // 
            gbxBusquedaRol.Controls.Add(cbxTipoFecha);
            gbxBusquedaRol.Controls.Add(lblTipoFecha);
            gbxBusquedaRol.Controls.Add(dtpFechaFin);
            gbxBusquedaRol.Controls.Add(dtpFechaInicio);
            gbxBusquedaRol.Controls.Add(lblFechaFin);
            gbxBusquedaRol.Controls.Add(lblFechaInicio);
            gbxBusquedaRol.Controls.Add(btnActualizar);
            gbxBusquedaRol.Controls.Add(txtBusquedaRol);
            gbxBusquedaRol.Controls.Add(lblBuscar);
            gbxBusquedaRol.Dock = DockStyle.Top;
            gbxBusquedaRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBusquedaRol.Location = new Point(0, 74);
            gbxBusquedaRol.Margin = new Padding(4, 5, 4, 5);
            gbxBusquedaRol.Name = "gbxBusquedaRol";
            gbxBusquedaRol.Padding = new Padding(4, 5, 4, 5);
            gbxBusquedaRol.Size = new Size(759, 143);
            gbxBusquedaRol.TabIndex = 13;
            gbxBusquedaRol.TabStop = false;
            gbxBusquedaRol.Text = "Busqueda";
            // 
            // cbxTipoFecha
            // 
            cbxTipoFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoFecha.FormattingEnabled = true;
            cbxTipoFecha.Location = new Point(120, 38);
            cbxTipoFecha.Margin = new Padding(4, 5, 4, 5);
            cbxTipoFecha.Name = "cbxTipoFecha";
            cbxTipoFecha.Size = new Size(111, 23);
            cbxTipoFecha.TabIndex = 18;
            // 
            // lblTipoFecha
            // 
            lblTipoFecha.AutoSize = true;
            lblTipoFecha.Location = new Point(12, 43);
            lblTipoFecha.Margin = new Padding(4, 0, 4, 0);
            lblTipoFecha.Name = "lblTipoFecha";
            lblTipoFecha.Size = new Size(79, 15);
            lblTipoFecha.TabIndex = 17;
            lblTipoFecha.Text = "Tipo de fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(557, 38);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.MaxDate = new DateTime(2025, 3, 13, 6, 39, 35, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(127, 23);
            dtpFechaFin.TabIndex = 16;
            dtpFechaFin.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(339, 38);
            dtpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtpFechaInicio.MaxDate = new DateTime(2025, 3, 13, 6, 38, 54, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(127, 23);
            dtpFechaInicio.TabIndex = 15;
            dtpFechaInicio.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(478, 43);
            lblFechaFin.Margin = new Padding(4, 0, 4, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(55, 15);
            lblFechaFin.TabIndex = 14;
            lblFechaFin.Text = "Fecha fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(242, 43);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 13;
            lblFechaInicio.Text = "Fecha inicio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(563, 81);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 46);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBusquedaRol
            // 
            txtBusquedaRol.Location = new Point(120, 87);
            txtBusquedaRol.Margin = new Padding(4, 5, 4, 5);
            txtBusquedaRol.MaxLength = 100;
            txtBusquedaRol.Name = "txtBusquedaRol";
            txtBusquedaRol.Size = new Size(307, 23);
            txtBusquedaRol.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 94);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(70, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar roles";
            // 
            // gbxHerramienta
            // 
            gbxHerramienta.Controls.Add(btnColapsar);
            gbxHerramienta.Dock = DockStyle.Top;
            gbxHerramienta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxHerramienta.Location = new Point(0, 0);
            gbxHerramienta.Margin = new Padding(4, 5, 4, 5);
            gbxHerramienta.Name = "gbxHerramienta";
            gbxHerramienta.Padding = new Padding(4, 5, 4, 5);
            gbxHerramienta.Size = new Size(759, 74);
            gbxHerramienta.TabIndex = 12;
            gbxHerramienta.TabStop = false;
            gbxHerramienta.Text = "Herramientas";
            // 
            // btnColapsar
            // 
            btnColapsar.BackColor = SystemColors.ActiveCaption;
            btnColapsar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColapsar.Image = Properties.Resources.iconoVer;
            btnColapsar.ImageAlign = ContentAlignment.MiddleLeft;
            btnColapsar.Location = new Point(12, 26);
            btnColapsar.Margin = new Padding(4, 5, 4, 5);
            btnColapsar.Name = "btnColapsar";
            btnColapsar.Size = new Size(172, 40);
            btnColapsar.TabIndex = 0;
            btnColapsar.Text = "Mostrar captura";
            btnColapsar.TextAlign = ContentAlignment.MiddleRight;
            btnColapsar.UseVisualStyleBackColor = false;
            btnColapsar.Click += btnColapsar_Click;
            // 
            // lblTituloRol
            // 
            lblTituloRol.BackColor = Color.SteelBlue;
            lblTituloRol.Dock = DockStyle.Top;
            lblTituloRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRol.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloRol.Location = new Point(0, 0);
            lblTituloRol.Margin = new Padding(4, 0, 4, 0);
            lblTituloRol.Name = "lblTituloRol";
            lblTituloRol.Size = new Size(1047, 51);
            lblTituloRol.TabIndex = 7;
            lblTituloRol.Text = "Configuración de roles";
            lblTituloRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmConfiguracionRoles
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1047, 577);
            Controls.Add(lblTituloRol);
            Controls.Add(scRoles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConfiguracionRoles";
            Text = "Gestión de rol";
            Load += frmConfiguracionRoles_Load;
            scRoles.Panel1.ResumeLayout(false);
            scRoles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRoles).EndInit();
            scRoles.ResumeLayout(false);
            gbxAltaEdicionRol.ResumeLayout(false);
            gbxAltaEdicionRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFormato).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdRol).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            gbxBusquedaRol.ResumeLayout(false);
            gbxBusquedaRol.PerformLayout();
            gbxHerramienta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scRoles;
        private Label lblTituloRol;
        private GroupBox gbxHerramienta;
        private Label lbseleccione;
        private Button btnCargaMasiva;
        private Button btnColapsar;
        private GroupBox gbxBusquedaRol;
        private ComboBox cbxTipoFecha;
        private Label lblTipoFecha;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private Button btnActualizar;
        private TextBox txtBusquedaRol;
        private Label lblBuscar;
        private GroupBox gbxAltaEdicionRol;
        private Button btnGuardar;
        private ComboBox cbxEstatus;
        private Label lblEstatus;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label lblDescripcion;
        private Label lblCodigo;
        private Label lblIdRol;
        private NumericUpDown numIdRol;
        private PictureBox picBoxFormato;
        private ToolTip toolTipCodigo;
        private Label lblInfo;
        private DataGridView dgvRoles;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn codigoRol;
        private DataGridViewTextBoxColumn descripcionRol;
        private DataGridViewTextBoxColumn estatusRol;
    }
}