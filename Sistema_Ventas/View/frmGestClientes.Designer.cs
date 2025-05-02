namespace PuntodeVenta.View
{
    partial class frmGestClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestClientes));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ofdClientes = new OpenFileDialog();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            scClientes = new SplitContainer();
            gbxActulizardatos = new GroupBox();
            lbl_obligatorios = new Label();
            pbxInformacionrfc = new PictureBox();
            txtrfcCliente = new TextBox();
            cbxTipoCliente = new ComboBox();
            lbfrcCliente = new Label();
            lbtipoCliente = new Label();
            btnGuardar = new Button();
            cbxEstatus = new ComboBox();
            lbEstatus = new Label();
            dtpNacimientoCliente = new DateTimePicker();
            txtTelefonoCliente = new TextBox();
            txtCorreoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            lbTelefono = new Label();
            lbNacimiento = new Label();
            lbCorreo = new Label();
            lbNombre = new Label();
            dgvGesClientes = new DataGridView();
            cmsEdit = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            gbxBusqueda = new GroupBox();
            checkBoxActivos = new CheckBox();
            cbxtipoFecha = new ComboBox();
            lbTipoFecha = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lbFechaFin = new Label();
            lbFechaInicio = new Label();
            btnActualizar = new Button();
            txtBusqueda = new TextBox();
            lbBuscar = new Label();
            gbxHerramientas = new GroupBox();
            lbseleccione = new Label();
            btnCargaMasiva = new Button();
            btncollapse = new Button();
            lbtitle = new Label();
            ttipinfo = new ToolTip(components);
            btnActualizarInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)scClientes).BeginInit();
            scClientes.Panel1.SuspendLayout();
            scClientes.Panel2.SuspendLayout();
            scClientes.SuspendLayout();
            gbxActulizardatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxInformacionrfc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGesClientes).BeginInit();
            cmsEdit.SuspendLayout();
            gbxBusqueda.SuspendLayout();
            gbxHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // ofdClientes
            // 
            ofdClientes.FileName = "Carga Masiva de Clientes";
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.Size = new Size(839, 391);
            // 
            // scClientes
            // 
            scClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scClientes.Location = new Point(0, 36);
            scClientes.Name = "scClientes";
            // 
            // scClientes.Panel1
            // 
            scClientes.Panel1.Controls.Add(gbxActulizardatos);
            // 
            // scClientes.Panel2
            // 
            scClientes.Panel2.Controls.Add(dgvGesClientes);
            scClientes.Panel2.Controls.Add(gbxBusqueda);
            scClientes.Panel2.Controls.Add(gbxHerramientas);
            scClientes.Size = new Size(839, 469);
            scClientes.SplitterDistance = 268;
            scClientes.TabIndex = 0;
            // 
            // gbxActulizardatos
            // 
            gbxActulizardatos.Controls.Add(btnActualizarInfo);
            gbxActulizardatos.Controls.Add(lbl_obligatorios);
            gbxActulizardatos.Controls.Add(pbxInformacionrfc);
            gbxActulizardatos.Controls.Add(txtrfcCliente);
            gbxActulizardatos.Controls.Add(cbxTipoCliente);
            gbxActulizardatos.Controls.Add(lbfrcCliente);
            gbxActulizardatos.Controls.Add(lbtipoCliente);
            gbxActulizardatos.Controls.Add(btnGuardar);
            gbxActulizardatos.Controls.Add(cbxEstatus);
            gbxActulizardatos.Controls.Add(lbEstatus);
            gbxActulizardatos.Controls.Add(dtpNacimientoCliente);
            gbxActulizardatos.Controls.Add(txtTelefonoCliente);
            gbxActulizardatos.Controls.Add(txtCorreoCliente);
            gbxActulizardatos.Controls.Add(txtNombreCliente);
            gbxActulizardatos.Controls.Add(lbTelefono);
            gbxActulizardatos.Controls.Add(lbNacimiento);
            gbxActulizardatos.Controls.Add(lbCorreo);
            gbxActulizardatos.Controls.Add(lbNombre);
            gbxActulizardatos.Dock = DockStyle.Fill;
            gbxActulizardatos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxActulizardatos.Location = new Point(0, 0);
            gbxActulizardatos.Name = "gbxActulizardatos";
            gbxActulizardatos.Size = new Size(268, 469);
            gbxActulizardatos.TabIndex = 0;
            gbxActulizardatos.TabStop = false;
            gbxActulizardatos.Text = "Alta o Actulizacion";
            // 
            // lbl_obligatorios
            // 
            lbl_obligatorios.AutoSize = true;
            lbl_obligatorios.Location = new Point(6, 369);
            lbl_obligatorios.Margin = new Padding(2, 0, 2, 0);
            lbl_obligatorios.Name = "lbl_obligatorios";
            lbl_obligatorios.Size = new Size(121, 15);
            lbl_obligatorios.TabIndex = 35;
            lbl_obligatorios.Text = "*Campos obligatorios";
            // 
            // pbxInformacionrfc
            // 
            pbxInformacionrfc.Image = Sistema_Ventas.Properties.Resources.iconoPregunta;
            pbxInformacionrfc.Location = new Point(159, 337);
            pbxInformacionrfc.Name = "pbxInformacionrfc";
            pbxInformacionrfc.Size = new Size(31, 31);
            pbxInformacionrfc.TabIndex = 30;
            pbxInformacionrfc.TabStop = false;
            ttipinfo.SetToolTip(pbxInformacionrfc, "iniciales del nombre, fecha de nacimiento,3  caracteres dados por el SAT,tamaño 13 caracteres");
            // 
            // txtrfcCliente
            // 
            txtrfcCliente.Location = new Point(6, 341);
            txtrfcCliente.MaxLength = 13;
            txtrfcCliente.Name = "txtrfcCliente";
            txtrfcCliente.Size = new Size(133, 23);
            txtrfcCliente.TabIndex = 29;
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Location = new Point(6, 293);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(121, 23);
            cbxTipoCliente.TabIndex = 27;
            cbxTipoCliente.SelectedIndexChanged += cbxTipoCliente_SelectedIndexChanged;
            // 
            // lbfrcCliente
            // 
            lbfrcCliente.AutoSize = true;
            lbfrcCliente.Location = new Point(8, 321);
            lbfrcCliente.Name = "lbfrcCliente";
            lbfrcCliente.Size = new Size(32, 15);
            lbfrcCliente.TabIndex = 26;
            lbfrcCliente.Text = "RFC*";
            // 
            // lbtipoCliente
            // 
            lbtipoCliente.AutoSize = true;
            lbtipoCliente.Location = new Point(8, 273);
            lbtipoCliente.Name = "lbtipoCliente";
            lbtipoCliente.Size = new Size(94, 15);
            lbtipoCliente.TabIndex = 24;
            lbtipoCliente.Text = "Tipo de Cliente* ";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(8, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 31);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(6, 245);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(121, 23);
            cbxEstatus.TabIndex = 19;
            cbxEstatus.SelectedIndexChanged += cbxEstatus_SelectedIndexChanged;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(8, 225);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(49, 15);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus*";
            // 
            // dtpNacimientoCliente
            // 
            dtpNacimientoCliente.Format = DateTimePickerFormat.Short;
            dtpNacimientoCliente.Location = new Point(6, 197);
            dtpNacimientoCliente.Name = "dtpNacimientoCliente";
            dtpNacimientoCliente.Size = new Size(206, 23);
            dtpNacimientoCliente.TabIndex = 17;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(6, 149);
            txtTelefonoCliente.MaxLength = 12;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(206, 23);
            txtTelefonoCliente.TabIndex = 16;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(6, 101);
            txtCorreoCliente.MaxLength = 15;
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(206, 23);
            txtCorreoCliente.TabIndex = 15;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(6, 53);
            txtNombreCliente.MaxLength = 100;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(203, 23);
            txtNombreCliente.TabIndex = 14;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(6, 129);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(58, 15);
            lbTelefono.TabIndex = 13;
            lbTelefono.Text = "Telefono*";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Location = new Point(8, 177);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(119, 15);
            lbNacimiento.TabIndex = 12;
            lbNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(8, 81);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(47, 15);
            lbCorreo.TabIndex = 11;
            lbCorreo.Text = "Correo*";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(8, 33);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(111, 15);
            lbNombre.TabIndex = 10;
            lbNombre.Text = "Nombre Completo*";
            // 
            // dgvGesClientes
            // 
            dgvGesClientes.AllowUserToAddRows = false;
            dgvGesClientes.AllowUserToDeleteRows = false;
            dgvGesClientes.AllowUserToOrderColumns = true;
            dgvGesClientes.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvGesClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGesClientes.ContextMenuStrip = cmsEdit;
            dgvGesClientes.Dock = DockStyle.Fill;
            dgvGesClientes.Location = new Point(0, 143);
            dgvGesClientes.Name = "dgvGesClientes";
            dgvGesClientes.ReadOnly = true;
            dgvGesClientes.RowHeadersWidth = 62;
            dgvGesClientes.Size = new Size(567, 326);
            dgvGesClientes.TabIndex = 2;
            dgvGesClientes.CellContentClick += dgvGesClientes_CellContentClick;
            // 
            // cmsEdit
            // 
            cmsEdit.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem });
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(105, 26);
            cmsEdit.Opening += contextMenuStrip1_Opening;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(104, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // gbxBusqueda
            // 
            gbxBusqueda.Controls.Add(checkBoxActivos);
            gbxBusqueda.Controls.Add(cbxtipoFecha);
            gbxBusqueda.Controls.Add(lbTipoFecha);
            gbxBusqueda.Controls.Add(dtpFechaFin);
            gbxBusqueda.Controls.Add(dtpFechaInicio);
            gbxBusqueda.Controls.Add(lbFechaFin);
            gbxBusqueda.Controls.Add(lbFechaInicio);
            gbxBusqueda.Controls.Add(btnActualizar);
            gbxBusqueda.Controls.Add(txtBusqueda);
            gbxBusqueda.Controls.Add(lbBuscar);
            gbxBusqueda.Dock = DockStyle.Top;
            gbxBusqueda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBusqueda.Location = new Point(0, 48);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(567, 95);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda de Clientes";
            // 
            // checkBoxActivos
            // 
            checkBoxActivos.BackColor = SystemColors.GradientActiveCaption;
            checkBoxActivos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxActivos.ForeColor = SystemColors.ControlText;
            checkBoxActivos.Location = new Point(346, 61);
            checkBoxActivos.Name = "checkBoxActivos";
            checkBoxActivos.Size = new Size(104, 24);
            checkBoxActivos.TabIndex = 19;
            checkBoxActivos.Text = "Sólo Activos";
            checkBoxActivos.TextAlign = ContentAlignment.MiddleRight;
            checkBoxActivos.UseVisualStyleBackColor = false;
            // 
            // cbxtipoFecha
            // 
            cbxtipoFecha.FormattingEnabled = true;
            cbxtipoFecha.Location = new Point(89, 25);
            cbxtipoFecha.Name = "cbxtipoFecha";
            cbxtipoFecha.Size = new Size(87, 23);
            cbxtipoFecha.TabIndex = 18;
            // 
            // lbTipoFecha
            // 
            lbTipoFecha.AutoSize = true;
            lbTipoFecha.Location = new Point(18, 28);
            lbTipoFecha.Name = "lbTipoFecha";
            lbTipoFecha.Size = new Size(65, 15);
            lbTipoFecha.TabIndex = 17;
            lbTipoFecha.Text = "Tipo Fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(429, 25);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(110, 23);
            dtpFechaFin.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(255, 25);
            dtpFechaInicio.MaxDate = new DateTime(2025, 5, 1, 15, 43, 38, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(110, 23);
            dtpFechaInicio.TabIndex = 15;
            dtpFechaInicio.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(371, 28);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 14;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(182, 28);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(71, 15);
            lbFechaInicio.TabIndex = 13;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Sistema_Ventas.Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(460, 54);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 30);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(108, 54);
            txtBusqueda.MaxLength = 100;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(220, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(20, 58);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(81, 15);
            lbBuscar.TabIndex = 0;
            lbBuscar.Text = "Buscar Cliente";
            // 
            // gbxHerramientas
            // 
            gbxHerramientas.Controls.Add(lbseleccione);
            gbxHerramientas.Controls.Add(btnCargaMasiva);
            gbxHerramientas.Controls.Add(btncollapse);
            gbxHerramientas.Dock = DockStyle.Top;
            gbxHerramientas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxHerramientas.Location = new Point(0, 0);
            gbxHerramientas.Name = "gbxHerramientas";
            gbxHerramientas.Size = new Size(567, 48);
            gbxHerramientas.TabIndex = 0;
            gbxHerramientas.TabStop = false;
            gbxHerramientas.Text = "Herramientas";
            // 
            // lbseleccione
            // 
            lbseleccione.AutoSize = true;
            lbseleccione.Location = new Point(242, 24);
            lbseleccione.Name = "lbseleccione";
            lbseleccione.Size = new Size(175, 15);
            lbseleccione.TabIndex = 2;
            lbseleccione.Text = "Seleccione un Archivo xlsx o xls";
            // 
            // btnCargaMasiva
            // 
            btnCargaMasiva.BackColor = SystemColors.ActiveCaption;
            btnCargaMasiva.Cursor = Cursors.Hand;
            btnCargaMasiva.FlatAppearance.BorderSize = 0;
            btnCargaMasiva.FlatStyle = FlatStyle.Flat;
            btnCargaMasiva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaMasiva.Image = Sistema_Ventas.Properties.Resources.upload1;
            btnCargaMasiva.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargaMasiva.Location = new Point(130, 20);
            btnCargaMasiva.Name = "btnCargaMasiva";
            btnCargaMasiva.Size = new Size(106, 23);
            btnCargaMasiva.TabIndex = 1;
            btnCargaMasiva.Text = "Cargar Excel";
            btnCargaMasiva.TextAlign = ContentAlignment.MiddleRight;
            btnCargaMasiva.UseVisualStyleBackColor = false;
            btnCargaMasiva.Click += btnCargaMasiva_Click;
            // 
            // btncollapse
            // 
            btncollapse.BackColor = SystemColors.ActiveCaption;
            btncollapse.Cursor = Cursors.Hand;
            btncollapse.FlatAppearance.BorderSize = 0;
            btncollapse.FlatStyle = FlatStyle.Flat;
            btncollapse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncollapse.Image = Sistema_Ventas.Properties.Resources.uploadUser1;
            btncollapse.ImageAlign = ContentAlignment.MiddleLeft;
            btncollapse.Location = new Point(9, 20);
            btncollapse.Name = "btncollapse";
            btncollapse.Size = new Size(115, 23);
            btncollapse.TabIndex = 0;
            btncollapse.Text = "Cargar Cliente";
            btncollapse.TextAlign = ContentAlignment.MiddleRight;
            btncollapse.UseVisualStyleBackColor = false;
            btncollapse.Click += btncollapse_Click;
            // 
            // lbtitle
            // 
            lbtitle.BackColor = Color.SteelBlue;
            lbtitle.Dock = DockStyle.Top;
            lbtitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitle.ForeColor = SystemColors.ActiveCaptionText;
            lbtitle.Location = new Point(0, 0);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(839, 33);
            lbtitle.TabIndex = 1;
            lbtitle.Text = "Gestion de Clientes";
            lbtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ttipinfo
            // 
            ttipinfo.Tag = "xd";
            ttipinfo.ToolTipTitle = "RFC";
            // 
            // btnActualizarInfo
            // 
            btnActualizarInfo.BackColor = SystemColors.ActiveCaption;
            btnActualizarInfo.FlatAppearance.BorderSize = 0;
            btnActualizarInfo.FlatStyle = FlatStyle.Flat;
            btnActualizarInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActualizarInfo.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnActualizarInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarInfo.Location = new Point(144, 387);
            btnActualizarInfo.Name = "btnActualizarInfo";
            btnActualizarInfo.Size = new Size(97, 31);
            btnActualizarInfo.TabIndex = 36;
            btnActualizarInfo.Text = "Actualizar";
            btnActualizarInfo.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarInfo.UseVisualStyleBackColor = false;
            btnActualizarInfo.Click += btnActualizarInfo_Click;
            // 
            // frmGestClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(839, 502);
            Controls.Add(lbtitle);
            Controls.Add(scClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGestClientes";
            Text = "Gestion de Clientes";
            Load += frmGestClientes_Load;
            scClientes.Panel1.ResumeLayout(false);
            scClientes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scClientes).EndInit();
            scClientes.ResumeLayout(false);
            gbxActulizardatos.ResumeLayout(false);
            gbxActulizardatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxInformacionrfc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGesClientes).EndInit();
            cmsEdit.ResumeLayout(false);
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            gbxHerramientas.ResumeLayout(false);
            gbxHerramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private OpenFileDialog ofdClientes;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private SplitContainer scClientes;
        private GroupBox gbxActulizardatos;
        private Button btnGuardar;
        private ComboBox cbxEstatus;
        private Label lbEstatus;
        private DateTimePicker dtpNacimientoCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtCorreoCliente;
        private TextBox txtNombreCliente;
        private Label lbTelefono;
        private Label lbNacimiento;
        private Label lbCorreo;
        private Label lbNombre;
        private GroupBox gbxBusqueda;
        private ComboBox cbxtipoFecha;
        private Label lbTipoFecha;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private Button btnActualizar;
        private TextBox txtBusqueda;
        private Label lbBuscar;
        private GroupBox gbxHerramientas;
        private Label lbseleccione;
        private Button btnCargaMasiva;
        private Button btncollapse;
        private DataGridView dgvGesClientes;
        private Label lbtitle;
        private ComboBox cbxTipoCliente;
        private Label lbfrcCliente;
        private Label lbtipoCliente;
        private TextBox txtrfcCliente;
        private PictureBox pbxInformacionrfc;
        private ToolTip ttipinfo;
        private Label lbl_obligatorios;
        private CheckBox checkBoxActivos;
        private ContextMenuStrip cmsEdit;
        private ToolStripMenuItem editarToolStripMenuItem;
        private Button btnActualizarInfo;
    }
}