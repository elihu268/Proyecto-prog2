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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionRoles));
            scRoles = new SplitContainer();
            gbxAltaEdicionRol = new GroupBox();
            numIdRol = new NumericUpDown();
            btnGuardar = new Button();
            cbxEstatus = new ComboBox();
            lblEstatus = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            lblDescripcion = new Label();
            lblCodigo = new Label();
            lblIdRol = new Label();
            dgvRol = new DataGridView();
            idRol = new DataGridViewTextBoxColumn();
            CodigoRol = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)scRoles).BeginInit();
            scRoles.Panel1.SuspendLayout();
            scRoles.Panel2.SuspendLayout();
            scRoles.SuspendLayout();
            gbxAltaEdicionRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdRol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRol).BeginInit();
            gbxBusquedaRol.SuspendLayout();
            gbxHerramienta.SuspendLayout();
            SuspendLayout();
            // 
            // scRoles
            // 
            scRoles.Location = new Point(-1, 35);
            scRoles.Margin = new Padding(2);
            scRoles.Name = "scRoles";
            // 
            // scRoles.Panel1
            // 
            scRoles.Panel1.Controls.Add(gbxAltaEdicionRol);
            // 
            // scRoles.Panel2
            // 
            scRoles.Panel2.Controls.Add(dgvRol);
            scRoles.Panel2.Controls.Add(gbxBusquedaRol);
            scRoles.Panel2.Controls.Add(gbxHerramienta);
            scRoles.Size = new Size(815, 340);
            scRoles.SplitterDistance = 223;
            scRoles.SplitterWidth = 3;
            scRoles.TabIndex = 6;
            // 
            // gbxAltaEdicionRol
            // 
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
            gbxAltaEdicionRol.Location = new Point(0, 0);
            gbxAltaEdicionRol.Name = "gbxAltaEdicionRol";
            gbxAltaEdicionRol.Size = new Size(223, 340);
            gbxAltaEdicionRol.TabIndex = 1;
            gbxAltaEdicionRol.TabStop = false;
            gbxAltaEdicionRol.Text = "Alta o Edición";
            // 
            // numIdRol
            // 
            numIdRol.Location = new Point(13, 42);
            numIdRol.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numIdRol.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIdRol.Name = "numIdRol";
            numIdRol.Size = new Size(203, 23);
            numIdRol.TabIndex = 21;
            numIdRol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(137, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(79, 31);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbxEstatus
            // 
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(13, 178);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(203, 23);
            cbxEstatus.TabIndex = 19;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(13, 160);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 18;
            lblEstatus.Text = "Estatus";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 134);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(203, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(13, 88);
            txtCodigo.MaxLength = 15;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(203, 23);
            txtCodigo.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(13, 116);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(13, 70);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Código";
            // 
            // lblIdRol
            // 
            lblIdRol.AutoSize = true;
            lblIdRol.Location = new Point(13, 24);
            lblIdRol.Name = "lblIdRol";
            lblIdRol.Size = new Size(57, 15);
            lblIdRol.TabIndex = 10;
            lblIdRol.Text = "ID del rol:";
            // 
            // dgvRol
            // 
            dgvRol.AllowUserToAddRows = false;
            dgvRol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRol.BackgroundColor = SystemColors.ActiveCaption;
            dgvRol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRol.Columns.AddRange(new DataGridViewColumn[] { idRol, CodigoRol, descripcionRol, estatusRol });
            dgvRol.Location = new Point(0, 136);
            dgvRol.Margin = new Padding(2);
            dgvRol.Name = "dgvRol";
            dgvRol.RowHeadersWidth = 62;
            dgvRol.Size = new Size(590, 204);
            dgvRol.TabIndex = 14;
            // 
            // idRol
            // 
            idRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idRol.HeaderText = "ID";
            idRol.MinimumWidth = 10;
            idRol.Name = "idRol";
            // 
            // CodigoRol
            // 
            CodigoRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CodigoRol.HeaderText = "Código";
            CodigoRol.MinimumWidth = 10;
            CodigoRol.Name = "CodigoRol";
            // 
            // descripcionRol
            // 
            descripcionRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcionRol.HeaderText = "Descripción";
            descripcionRol.MinimumWidth = 10;
            descripcionRol.Name = "descripcionRol";
            // 
            // estatusRol
            // 
            estatusRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estatusRol.HeaderText = "Estatus";
            estatusRol.MinimumWidth = 10;
            estatusRol.Name = "estatusRol";
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
            gbxBusquedaRol.Location = new Point(0, 48);
            gbxBusquedaRol.Name = "gbxBusquedaRol";
            gbxBusquedaRol.Size = new Size(589, 93);
            gbxBusquedaRol.TabIndex = 13;
            gbxBusquedaRol.TabStop = false;
            gbxBusquedaRol.Text = "Busqueda";
            // 
            // cbxTipoFecha
            // 
            cbxTipoFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoFecha.FormattingEnabled = true;
            cbxTipoFecha.Location = new Point(93, 25);
            cbxTipoFecha.Name = "cbxTipoFecha";
            cbxTipoFecha.Size = new Size(87, 23);
            cbxTipoFecha.TabIndex = 18;
            // 
            // lblTipoFecha
            // 
            lblTipoFecha.AutoSize = true;
            lblTipoFecha.Location = new Point(9, 28);
            lblTipoFecha.Name = "lblTipoFecha";
            lblTipoFecha.Size = new Size(78, 15);
            lblTipoFecha.TabIndex = 17;
            lblTipoFecha.Text = "Tipo de fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(433, 25);
            dtpFechaFin.MaxDate = new DateTime(2025, 3, 13, 6, 39, 35, 0);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(100, 23);
            dtpFechaFin.TabIndex = 16;
            dtpFechaFin.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(264, 25);
            dtpFechaInicio.MaxDate = new DateTime(2025, 3, 13, 6, 38, 54, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(100, 23);
            dtpFechaInicio.TabIndex = 15;
            dtpFechaInicio.Value = new DateTime(2025, 3, 13, 0, 0, 0, 0);
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(372, 28);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(55, 15);
            lblFechaFin.TabIndex = 14;
            lblFechaFin.Text = "Fecha fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(188, 28);
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
            btnActualizar.Location = new Point(438, 53);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 30);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtBusquedaRol
            // 
            txtBusquedaRol.Location = new Point(93, 57);
            txtBusquedaRol.MaxLength = 50;
            txtBusquedaRol.Name = "txtBusquedaRol";
            txtBusquedaRol.Size = new Size(240, 23);
            txtBusquedaRol.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(9, 61);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(70, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar roles";
            // 
            // gbxHerramienta
            // 
            gbxHerramienta.Controls.Add(btnColapsar);
            gbxHerramienta.Dock = DockStyle.Top;
            gbxHerramienta.Location = new Point(0, 0);
            gbxHerramienta.Name = "gbxHerramienta";
            gbxHerramienta.Size = new Size(589, 48);
            gbxHerramienta.TabIndex = 12;
            gbxHerramienta.TabStop = false;
            gbxHerramienta.Text = "Herramientas";
            // 
            // btnColapsar
            // 
            btnColapsar.BackColor = SystemColors.ActiveCaption;
            btnColapsar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColapsar.ImageAlign = ContentAlignment.MiddleLeft;
            btnColapsar.Location = new Point(9, 20);
            btnColapsar.Name = "btnColapsar";
            btnColapsar.Size = new Size(106, 23);
            btnColapsar.TabIndex = 0;
            btnColapsar.Text = "Mostrar captura";
            btnColapsar.TextAlign = ContentAlignment.MiddleRight;
            btnColapsar.UseVisualStyleBackColor = false;
            // 
            // lblTituloRol
            // 
            lblTituloRol.BackColor = SystemColors.GradientActiveCaption;
            lblTituloRol.Dock = DockStyle.Top;
            lblTituloRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRol.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloRol.Location = new Point(0, 0);
            lblTituloRol.Name = "lblTituloRol";
            lblTituloRol.Size = new Size(814, 33);
            lblTituloRol.TabIndex = 7;
            lblTituloRol.Text = "Configuración de roles";
            lblTituloRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmConfiguracionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(814, 376);
            Controls.Add(lblTituloRol);
            Controls.Add(scRoles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmConfiguracionRoles";
            Text = "Gestión de rol";
            scRoles.Panel1.ResumeLayout(false);
            scRoles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scRoles).EndInit();
            scRoles.ResumeLayout(false);
            gbxAltaEdicionRol.ResumeLayout(false);
            gbxAltaEdicionRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdRol).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRol).EndInit();
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
        private DataGridView dgvRol;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn CodigoRol;
        private DataGridViewTextBoxColumn descripcionRol;
        private DataGridViewTextBoxColumn estatusRol;
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
    }
}