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
            txt_fecha_registro = new TextBox();
            pbxInformacionrfc = new PictureBox();
            txtrfcCliente = new TextBox();
            cbxTipoCliente = new ComboBox();
            lbfrcCliente = new Label();
            lbfechaRegistroCli = new Label();
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
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            gbxBusqueda = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)scClientes).BeginInit();
            scClientes.Panel1.SuspendLayout();
            scClientes.Panel2.SuspendLayout();
            scClientes.SuspendLayout();
            gbxActulizardatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxInformacionrfc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            scClientes.Location = new Point(0, 55);
            scClientes.Margin = new Padding(4, 5, 4, 5);
            scClientes.Name = "scClientes";
            // 
            // scClientes.Panel1
            // 
            scClientes.Panel1.Controls.Add(gbxActulizardatos);
            // 
            // scClientes.Panel2
            // 
            scClientes.Panel2.Controls.Add(dataGridView1);
            scClientes.Panel2.Controls.Add(gbxBusqueda);
            scClientes.Panel2.Controls.Add(gbxHerramientas);
            scClientes.Size = new Size(1079, 719);
            scClientes.SplitterDistance = 345;
            scClientes.SplitterWidth = 5;
            scClientes.TabIndex = 0;
            // 
            // gbxActulizardatos
            // 
            gbxActulizardatos.Controls.Add(txt_fecha_registro);
            gbxActulizardatos.Controls.Add(pbxInformacionrfc);
            gbxActulizardatos.Controls.Add(txtrfcCliente);
            gbxActulizardatos.Controls.Add(cbxTipoCliente);
            gbxActulizardatos.Controls.Add(lbfrcCliente);
            gbxActulizardatos.Controls.Add(lbfechaRegistroCli);
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
            gbxActulizardatos.Margin = new Padding(4, 5, 4, 5);
            gbxActulizardatos.Name = "gbxActulizardatos";
            gbxActulizardatos.Padding = new Padding(4, 5, 4, 5);
            gbxActulizardatos.Size = new Size(345, 719);
            gbxActulizardatos.TabIndex = 0;
            gbxActulizardatos.TabStop = false;
            gbxActulizardatos.Text = "Alta o Actulizacion";
            // 
            // txt_fecha_registro
            // 
            txt_fecha_registro.Enabled = false;
            txt_fecha_registro.Location = new Point(14, 522);
            txt_fecha_registro.Name = "txt_fecha_registro";
            txt_fecha_registro.Size = new Size(187, 23);
            txt_fecha_registro.TabIndex = 31;
            txt_fecha_registro.TextChanged += txt_fecha_registro_TextChanged;
            // 
            // pbxInformacionrfc
            // 
            pbxInformacionrfc.Image = Sistema_Ventas.Properties.Resources.iconoPregunta;
            pbxInformacionrfc.Location = new Point(213, 563);
            pbxInformacionrfc.Margin = new Padding(4, 5, 4, 5);
            pbxInformacionrfc.Name = "pbxInformacionrfc";
            pbxInformacionrfc.Size = new Size(40, 48);
            pbxInformacionrfc.TabIndex = 30;
            pbxInformacionrfc.TabStop = false;
            ttipinfo.SetToolTip(pbxInformacionrfc, "iniciales del nombre, fecha de nacimiento,3  caracteres dados por el SAT,tamaño 13 caracteres");
            // 
            // txtrfcCliente
            // 
            txtrfcCliente.Location = new Point(17, 575);
            txtrfcCliente.Margin = new Padding(4, 5, 4, 5);
            txtrfcCliente.MaxLength = 13;
            txtrfcCliente.Name = "txtrfcCliente";
            txtrfcCliente.Size = new Size(170, 23);
            txtrfcCliente.TabIndex = 29;
            // 
            // cbxTipoCliente
            // 
            cbxTipoCliente.FormattingEnabled = true;
            cbxTipoCliente.Location = new Point(13, 449);
            cbxTipoCliente.Margin = new Padding(4, 5, 4, 5);
            cbxTipoCliente.Name = "cbxTipoCliente";
            cbxTipoCliente.Size = new Size(154, 23);
            cbxTipoCliente.TabIndex = 27;
            // 
            // lbfrcCliente
            // 
            lbfrcCliente.AutoSize = true;
            lbfrcCliente.Location = new Point(15, 554);
            lbfrcCliente.Margin = new Padding(4, 0, 4, 0);
            lbfrcCliente.Name = "lbfrcCliente";
            lbfrcCliente.Size = new Size(32, 15);
            lbfrcCliente.TabIndex = 26;
            lbfrcCliente.Text = "RFC*";
            // 
            // lbfechaRegistroCli
            // 
            lbfechaRegistroCli.AutoSize = true;
            lbfechaRegistroCli.Location = new Point(8, 489);
            lbfechaRegistroCli.Margin = new Padding(4, 0, 4, 0);
            lbfechaRegistroCli.Name = "lbfechaRegistroCli";
            lbfechaRegistroCli.Size = new Size(100, 15);
            lbfechaRegistroCli.TabIndex = 25;
            lbfechaRegistroCli.Text = "Fecha de Registro";
            // 
            // lbtipoCliente
            // 
            lbtipoCliente.AutoSize = true;
            lbtipoCliente.Location = new Point(13, 426);
            lbtipoCliente.Margin = new Padding(4, 0, 4, 0);
            lbtipoCliente.Name = "lbtipoCliente";
            lbtipoCliente.Size = new Size(94, 15);
            lbtipoCliente.TabIndex = 24;
            lbtipoCliente.Text = "Tipo de Cliente* ";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(237, 649);
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
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(13, 385);
            cbxEstatus.Margin = new Padding(4, 5, 4, 5);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(154, 23);
            cbxEstatus.TabIndex = 19;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(10, 357);
            lbEstatus.Margin = new Padding(4, 0, 4, 0);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(49, 15);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus*";
            // 
            // dtpNacimientoCliente
            // 
            dtpNacimientoCliente.Format = DateTimePickerFormat.Short;
            dtpNacimientoCliente.Location = new Point(13, 317);
            dtpNacimientoCliente.Margin = new Padding(4, 5, 4, 5);
            dtpNacimientoCliente.Name = "dtpNacimientoCliente";
            dtpNacimientoCliente.Size = new Size(264, 23);
            dtpNacimientoCliente.TabIndex = 17;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(13, 235);
            txtTelefonoCliente.Margin = new Padding(4, 5, 4, 5);
            txtTelefonoCliente.MaxLength = 12;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(257, 23);
            txtTelefonoCliente.TabIndex = 16;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(13, 167);
            txtCorreoCliente.Margin = new Padding(4, 5, 4, 5);
            txtCorreoCliente.MaxLength = 30;
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(264, 23);
            txtCorreoCliente.TabIndex = 15;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(13, 89);
            txtNombreCliente.Margin = new Padding(4, 5, 4, 5);
            txtNombreCliente.MaxLength = 50;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(260, 23);
            txtNombreCliente.TabIndex = 14;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(10, 207);
            lbTelefono.Margin = new Padding(4, 0, 4, 0);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(58, 15);
            lbTelefono.TabIndex = 13;
            lbTelefono.Text = "Telefono*";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Location = new Point(10, 279);
            lbNacimiento.Margin = new Padding(4, 0, 4, 0);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(119, 15);
            lbNacimiento.TabIndex = 12;
            lbNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(10, 129);
            lbCorreo.Margin = new Padding(4, 0, 4, 0);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(47, 15);
            lbCorreo.TabIndex = 11;
            lbCorreo.Text = "Correo*";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(10, 51);
            lbNombre.Margin = new Padding(4, 0, 4, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(111, 15);
            lbNombre.TabIndex = 10;
            lbNombre.Text = "Nombre Completo*";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Correo, Telefono, Estatus });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 217);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(729, 502);
            dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 150;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.MinimumWidth = 8;
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 150;
            // 
            // gbxBusqueda
            // 
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
            gbxBusqueda.Location = new Point(0, 74);
            gbxBusqueda.Margin = new Padding(4, 5, 4, 5);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Padding = new Padding(4, 5, 4, 5);
            gbxBusqueda.Size = new Size(729, 143);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda de Clientes";
            // 
            // cbxtipoFecha
            // 
            cbxtipoFecha.FormattingEnabled = true;
            cbxtipoFecha.Location = new Point(114, 39);
            cbxtipoFecha.Margin = new Padding(4, 5, 4, 5);
            cbxtipoFecha.Name = "cbxtipoFecha";
            cbxtipoFecha.Size = new Size(111, 23);
            cbxtipoFecha.TabIndex = 18;
            // 
            // lbTipoFecha
            // 
            lbTipoFecha.AutoSize = true;
            lbTipoFecha.Location = new Point(23, 43);
            lbTipoFecha.Margin = new Padding(4, 0, 4, 0);
            lbTipoFecha.Name = "lbTipoFecha";
            lbTipoFecha.Size = new Size(65, 15);
            lbTipoFecha.TabIndex = 17;
            lbTipoFecha.Text = "Tipo Fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(552, 39);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(140, 23);
            dtpFechaFin.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(328, 39);
            dtpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(140, 23);
            dtpFechaInicio.TabIndex = 15;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(477, 43);
            lbFechaFin.Margin = new Padding(4, 0, 4, 0);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 14;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(234, 43);
            lbFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(71, 15);
            lbFechaInicio.TabIndex = 13;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Sistema_Ventas.Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(489, 85);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 46);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(139, 83);
            txtBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtBusqueda.MaxLength = 100;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(324, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(26, 89);
            lbBuscar.Margin = new Padding(4, 0, 4, 0);
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
            gbxHerramientas.Margin = new Padding(4, 5, 4, 5);
            gbxHerramientas.Name = "gbxHerramientas";
            gbxHerramientas.Padding = new Padding(4, 5, 4, 5);
            gbxHerramientas.Size = new Size(729, 74);
            gbxHerramientas.TabIndex = 0;
            gbxHerramientas.TabStop = false;
            gbxHerramientas.Text = "Herramientas";
            // 
            // lbseleccione
            // 
            lbseleccione.AutoSize = true;
            lbseleccione.Location = new Point(311, 37);
            lbseleccione.Margin = new Padding(4, 0, 4, 0);
            lbseleccione.Name = "lbseleccione";
            lbseleccione.Size = new Size(175, 15);
            lbseleccione.TabIndex = 2;
            lbseleccione.Text = "Seleccione un Archivo xlsx o xls";
            // 
            // btnCargaMasiva
            // 
            btnCargaMasiva.BackColor = SystemColors.ActiveCaption;
            btnCargaMasiva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaMasiva.Image = Sistema_Ventas.Properties.Resources.upload1;
            btnCargaMasiva.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargaMasiva.Location = new Point(167, 30);
            btnCargaMasiva.Margin = new Padding(4, 5, 4, 5);
            btnCargaMasiva.Name = "btnCargaMasiva";
            btnCargaMasiva.Size = new Size(125, 35);
            btnCargaMasiva.TabIndex = 1;
            btnCargaMasiva.Text = "Cargar Excel";
            btnCargaMasiva.TextAlign = ContentAlignment.MiddleRight;
            btnCargaMasiva.UseVisualStyleBackColor = false;
            btnCargaMasiva.Click += btnCargaMasiva_Click;
            // 
            // btncollapse
            // 
            btncollapse.BackColor = SystemColors.ActiveCaption;
            btncollapse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncollapse.Image = Sistema_Ventas.Properties.Resources.uploadUser1;
            btncollapse.ImageAlign = ContentAlignment.MiddleLeft;
            btncollapse.Location = new Point(12, 30);
            btncollapse.Margin = new Padding(4, 5, 4, 5);
            btncollapse.Name = "btncollapse";
            btncollapse.Size = new Size(136, 35);
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
            lbtitle.Margin = new Padding(4, 0, 4, 0);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(1079, 51);
            lbtitle.TabIndex = 1;
            lbtitle.Text = "Gestion de Clientes";
            lbtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ttipinfo
            // 
            ttipinfo.Tag = "xd";
            ttipinfo.ToolTipTitle = "RFC";
            // 
            // frmGestClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1079, 770);
            Controls.Add(lbtitle);
            Controls.Add(scClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label lbtitle;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estatus;
        private ComboBox cbxTipoCliente;
        private Label lbfrcCliente;
        private Label lbfechaRegistroCli;
        private Label lbtipoCliente;
        private TextBox txtrfcCliente;
        private PictureBox pbxInformacionrfc;
        private ToolTip ttipinfo;
        private TextBox txt_fecha_registro;
    }
}