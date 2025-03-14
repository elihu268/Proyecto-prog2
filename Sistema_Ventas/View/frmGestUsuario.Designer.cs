namespace PuntodeVenta.View
{
    partial class frmGestUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestUsuario));
            scUsuarios = new SplitContainer();
            gbxUsuarios = new GroupBox();
            lbconfirmcontraAlert = new Label();
            lbcontraalert = new Label();
            txtConfContrasena = new TextBox();
            txtContrasena = new TextBox();
            lbConfirmcontra = new Label();
            lbcontrasena = new Label();
            cbxRoles = new ComboBox();
            lbRol = new Label();
            btnGuardar = new Button();
            cbxEstatus = new ComboBox();
            dtpNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lbEstatus = new Label();
            lbfechaNacimiento = new Label();
            lbTelefono = new Label();
            lbCorreo = new Label();
            lbNombre = new Label();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            gbxBusqueda = new GroupBox();
            cbxtipoFecha = new ComboBox();
            lbTipoFecha = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lbFechaFin = new Label();
            lbFechaInicio = new Label();
            btnBuscar = new Button();
            txtBusqueda = new TextBox();
            lbBusqueda = new Label();
            gbxherramientas = new GroupBox();
            lbCargaMasiva = new Label();
            btnCarga = new Button();
            btncargaUsuario = new Button();
            ofdArchivo = new OpenFileDialog();
            lbTitulo = new Label();
            lbl_obligatorios = new Label();
            ((System.ComponentModel.ISupportInitialize)scUsuarios).BeginInit();
            scUsuarios.Panel1.SuspendLayout();
            scUsuarios.Panel2.SuspendLayout();
            scUsuarios.SuspendLayout();
            gbxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxBusqueda.SuspendLayout();
            gbxherramientas.SuspendLayout();
            SuspendLayout();
            // 
            // scUsuarios
            // 
            scUsuarios.Location = new Point(0, 53);
            scUsuarios.Margin = new Padding(4, 5, 4, 5);
            scUsuarios.Name = "scUsuarios";
            // 
            // scUsuarios.Panel1
            // 
            scUsuarios.Panel1.Controls.Add(gbxUsuarios);
            // 
            // scUsuarios.Panel2
            // 
            scUsuarios.Panel2.Controls.Add(dataGridView1);
            scUsuarios.Panel2.Controls.Add(gbxBusqueda);
            scUsuarios.Panel2.Controls.Add(gbxherramientas);
            scUsuarios.Size = new Size(1251, 687);
            scUsuarios.SplitterDistance = 417;
            scUsuarios.SplitterWidth = 6;
            scUsuarios.TabIndex = 0;
            // 
            // gbxUsuarios
            // 
            gbxUsuarios.BackColor = SystemColors.GradientActiveCaption;
            gbxUsuarios.Controls.Add(lbl_obligatorios);
            gbxUsuarios.Controls.Add(lbconfirmcontraAlert);
            gbxUsuarios.Controls.Add(lbcontraalert);
            gbxUsuarios.Controls.Add(txtConfContrasena);
            gbxUsuarios.Controls.Add(txtContrasena);
            gbxUsuarios.Controls.Add(lbConfirmcontra);
            gbxUsuarios.Controls.Add(lbcontrasena);
            gbxUsuarios.Controls.Add(cbxRoles);
            gbxUsuarios.Controls.Add(lbRol);
            gbxUsuarios.Controls.Add(btnGuardar);
            gbxUsuarios.Controls.Add(cbxEstatus);
            gbxUsuarios.Controls.Add(dtpNacimiento);
            gbxUsuarios.Controls.Add(txtTelefono);
            gbxUsuarios.Controls.Add(txtCorreo);
            gbxUsuarios.Controls.Add(txtNombre);
            gbxUsuarios.Controls.Add(lbEstatus);
            gbxUsuarios.Controls.Add(lbfechaNacimiento);
            gbxUsuarios.Controls.Add(lbTelefono);
            gbxUsuarios.Controls.Add(lbCorreo);
            gbxUsuarios.Controls.Add(lbNombre);
            gbxUsuarios.Dock = DockStyle.Fill;
            gbxUsuarios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxUsuarios.Location = new Point(0, 0);
            gbxUsuarios.Margin = new Padding(4, 5, 4, 5);
            gbxUsuarios.Name = "gbxUsuarios";
            gbxUsuarios.Padding = new Padding(4, 5, 4, 5);
            gbxUsuarios.Size = new Size(417, 687);
            gbxUsuarios.TabIndex = 1;
            gbxUsuarios.TabStop = false;
            gbxUsuarios.Text = "Datos del Usuario";
            // 
            // lbconfirmcontraAlert
            // 
            lbconfirmcontraAlert.AutoSize = true;
            lbconfirmcontraAlert.ForeColor = Color.Red;
            lbconfirmcontraAlert.Location = new Point(29, 640);
            lbconfirmcontraAlert.Margin = new Padding(4, 0, 4, 0);
            lbconfirmcontraAlert.Name = "lbconfirmcontraAlert";
            lbconfirmcontraAlert.Size = new Size(0, 25);
            lbconfirmcontraAlert.TabIndex = 33;
            // 
            // lbcontraalert
            // 
            lbcontraalert.AutoSize = true;
            lbcontraalert.ForeColor = Color.Red;
            lbcontraalert.Location = new Point(29, 542);
            lbcontraalert.Margin = new Padding(4, 0, 4, 0);
            lbcontraalert.Name = "lbcontraalert";
            lbcontraalert.Size = new Size(0, 25);
            lbcontraalert.TabIndex = 32;
            // 
            // txtConfContrasena
            // 
            txtConfContrasena.Location = new Point(26, 597);
            txtConfContrasena.Margin = new Padding(4, 5, 4, 5);
            txtConfContrasena.MaxLength = 16;
            txtConfContrasena.Name = "txtConfContrasena";
            txtConfContrasena.PasswordChar = '*';
            txtConfContrasena.Size = new Size(141, 31);
            txtConfContrasena.TabIndex = 31;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(26, 500);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.MaxLength = 16;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(141, 31);
            txtContrasena.TabIndex = 30;
            // 
            // lbConfirmcontra
            // 
            lbConfirmcontra.AutoSize = true;
            lbConfirmcontra.ForeColor = SystemColors.ControlText;
            lbConfirmcontra.Location = new Point(21, 567);
            lbConfirmcontra.Margin = new Padding(4, 0, 4, 0);
            lbConfirmcontra.Name = "lbConfirmcontra";
            lbConfirmcontra.Size = new Size(202, 25);
            lbConfirmcontra.TabIndex = 29;
            lbConfirmcontra.Text = "Confirmar Contraseña*";
            // 
            // lbcontrasena
            // 
            lbcontrasena.AutoSize = true;
            lbcontrasena.Location = new Point(23, 470);
            lbcontrasena.Margin = new Padding(4, 0, 4, 0);
            lbcontrasena.Name = "lbcontrasena";
            lbcontrasena.Size = new Size(114, 25);
            lbcontrasena.TabIndex = 28;
            lbcontrasena.Text = "Contraseña*";
            // 
            // cbxRoles
            // 
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Location = new Point(21, 423);
            cbxRoles.Margin = new Padding(4, 5, 4, 5);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(171, 33);
            cbxRoles.TabIndex = 27;
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Location = new Point(21, 390);
            lbRol.Margin = new Padding(4, 0, 4, 0);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(47, 25);
            lbRol.TabIndex = 26;
            lbRol.Text = "Rol*";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(283, 622);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 60);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(21, 348);
            cbxEstatus.Margin = new Padding(4, 5, 4, 5);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(191, 33);
            cbxEstatus.TabIndex = 23;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.ImeMode = ImeMode.NoControl;
            dtpNacimiento.Location = new Point(21, 273);
            dtpNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(284, 31);
            dtpNacimiento.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(21, 207);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(323, 31);
            txtTelefono.TabIndex = 21;
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(21, 135);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(320, 31);
            txtCorreo.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(23, 62);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 31);
            txtNombre.TabIndex = 19;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(19, 320);
            lbEstatus.Margin = new Padding(4, 0, 4, 0);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(79, 25);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus*";
            // 
            // lbfechaNacimiento
            // 
            lbfechaNacimiento.AutoSize = true;
            lbfechaNacimiento.Location = new Point(26, 248);
            lbfechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lbfechaNacimiento.Name = "lbfechaNacimiento";
            lbfechaNacimiento.Size = new Size(193, 25);
            lbfechaNacimiento.TabIndex = 17;
            lbfechaNacimiento.Text = "Fecha de Nacimiento*";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(21, 182);
            lbTelefono.Margin = new Padding(4, 0, 4, 0);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(92, 25);
            lbTelefono.TabIndex = 16;
            lbTelefono.Text = "Telefono*";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(21, 105);
            lbCorreo.Margin = new Padding(4, 0, 4, 0);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(77, 25);
            lbCorreo.TabIndex = 15;
            lbCorreo.Text = "Correo*";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 32);
            lbNombre.Margin = new Padding(4, 0, 4, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(176, 25);
            lbNombre.TabIndex = 14;
            lbNombre.Text = "Nombre Completo*";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Correo, Telefono, Estatus, Rol });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 218);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(828, 469);
            dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.MinimumWidth = 8;
            Estatus.Name = "Estatus";
            Estatus.Width = 150;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 8;
            Rol.Name = "Rol";
            Rol.Width = 150;
            // 
            // gbxBusqueda
            // 
            gbxBusqueda.BackColor = SystemColors.GradientInactiveCaption;
            gbxBusqueda.Controls.Add(cbxtipoFecha);
            gbxBusqueda.Controls.Add(lbTipoFecha);
            gbxBusqueda.Controls.Add(dtpFechaFin);
            gbxBusqueda.Controls.Add(dtpFechaInicio);
            gbxBusqueda.Controls.Add(lbFechaFin);
            gbxBusqueda.Controls.Add(lbFechaInicio);
            gbxBusqueda.Controls.Add(btnBuscar);
            gbxBusqueda.Controls.Add(txtBusqueda);
            gbxBusqueda.Controls.Add(lbBusqueda);
            gbxBusqueda.Dock = DockStyle.Top;
            gbxBusqueda.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBusqueda.Location = new Point(0, 95);
            gbxBusqueda.Margin = new Padding(4, 5, 4, 5);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Padding = new Padding(4, 5, 4, 5);
            gbxBusqueda.Size = new Size(828, 123);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda";
            // 
            // cbxtipoFecha
            // 
            cbxtipoFecha.FormattingEnabled = true;
            cbxtipoFecha.Location = new Point(119, 28);
            cbxtipoFecha.Margin = new Padding(4, 5, 4, 5);
            cbxtipoFecha.Name = "cbxtipoFecha";
            cbxtipoFecha.Size = new Size(123, 33);
            cbxtipoFecha.TabIndex = 12;
            // 
            // lbTipoFecha
            // 
            lbTipoFecha.AutoSize = true;
            lbTipoFecha.Location = new Point(17, 32);
            lbTipoFecha.Margin = new Padding(4, 0, 4, 0);
            lbTipoFecha.Name = "lbTipoFecha";
            lbTipoFecha.Size = new Size(100, 25);
            lbTipoFecha.TabIndex = 11;
            lbTipoFecha.Text = "Tipo Fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(604, 25);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(155, 31);
            dtpFechaFin.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(403, 28);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(110, 31);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(521, 32);
            lbFechaFin.Margin = new Padding(4, 0, 4, 0);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(88, 25);
            lbFechaFin.TabIndex = 8;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(296, 35);
            lbFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(108, 25);
            lbFechaInicio.TabIndex = 7;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = Sistema_Ventas.Properties.Resources.actualizar;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(641, 73);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 50);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Actualizar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(196, 75);
            txtBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtBusqueda.MaxLength = 100;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(380, 31);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(14, 73);
            lbBusqueda.Margin = new Padding(4, 0, 4, 0);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(197, 25);
            lbBusqueda.TabIndex = 0;
            lbBusqueda.Text = "Busqueda de Usuarios";
            // 
            // gbxherramientas
            // 
            gbxherramientas.BackColor = SystemColors.GradientActiveCaption;
            gbxherramientas.Controls.Add(lbCargaMasiva);
            gbxherramientas.Controls.Add(btnCarga);
            gbxherramientas.Controls.Add(btncargaUsuario);
            gbxherramientas.Dock = DockStyle.Top;
            gbxherramientas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxherramientas.Location = new Point(0, 0);
            gbxherramientas.Margin = new Padding(4, 5, 4, 5);
            gbxherramientas.Name = "gbxherramientas";
            gbxherramientas.Padding = new Padding(4, 5, 4, 5);
            gbxherramientas.Size = new Size(828, 95);
            gbxherramientas.TabIndex = 0;
            gbxherramientas.TabStop = false;
            gbxherramientas.Text = "herramientas";
            // 
            // lbCargaMasiva
            // 
            lbCargaMasiva.AutoSize = true;
            lbCargaMasiva.Location = new Point(337, 43);
            lbCargaMasiva.Name = "lbCargaMasiva";
            lbCargaMasiva.Size = new Size(273, 25);
            lbCargaMasiva.TabIndex = 2;
            lbCargaMasiva.Text = "Seleccione un Archivo xlsx o xls";
            // 
            // btnCarga
            // 
            btnCarga.BackColor = SystemColors.ActiveCaption;
            btnCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarga.Image = Sistema_Ventas.Properties.Resources.upload1;
            btnCarga.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarga.Location = new Point(181, 30);
            btnCarga.Margin = new Padding(4, 5, 4, 5);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(149, 50);
            btnCarga.TabIndex = 1;
            btnCarga.Text = "Carga Masiva";
            btnCarga.TextAlign = ContentAlignment.MiddleRight;
            btnCarga.UseVisualStyleBackColor = false;
            btnCarga.Click += btnCarga_Click;
            // 
            // btncargaUsuario
            // 
            btncargaUsuario.BackColor = SystemColors.ActiveCaption;
            btncargaUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncargaUsuario.Image = Sistema_Ventas.Properties.Resources.uploadUser1;
            btncargaUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btncargaUsuario.Location = new Point(9, 30);
            btncargaUsuario.Margin = new Padding(4, 5, 4, 5);
            btncargaUsuario.Name = "btncargaUsuario";
            btncargaUsuario.Size = new Size(164, 50);
            btncargaUsuario.TabIndex = 0;
            btncargaUsuario.Text = "Cargar Usuario";
            btncargaUsuario.TextAlign = ContentAlignment.MiddleRight;
            btncargaUsuario.UseVisualStyleBackColor = false;
            btncargaUsuario.Click += btncargaUsuario_Click;
            // 
            // ofdArchivo
            // 
            ofdArchivo.FileName = "Carga Masiva de Usuarios";
            // 
            // lbTitulo
            // 
            lbTitulo.BackColor = Color.SteelBlue;
            lbTitulo.Dock = DockStyle.Top;
            lbTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lbTitulo.Location = new Point(0, 0);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(1251, 48);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Gestion de Usuarios";
            lbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_obligatorios
            // 
            lbl_obligatorios.AutoSize = true;
            lbl_obligatorios.Location = new Point(26, 655);
            lbl_obligatorios.Name = "lbl_obligatorios";
            lbl_obligatorios.Size = new Size(192, 25);
            lbl_obligatorios.TabIndex = 34;
            lbl_obligatorios.Text = "*Campos obligatorios";
            // 
            // frmGestUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1251, 740);
            Controls.Add(lbTitulo);
            Controls.Add(scUsuarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmGestUsuario";
            Text = "Gestion de Usuarios";
            Load += frmGestUsuario_Load;
            scUsuarios.Panel1.ResumeLayout(false);
            scUsuarios.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scUsuarios).EndInit();
            scUsuarios.ResumeLayout(false);
            gbxUsuarios.ResumeLayout(false);
            gbxUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            gbxherramientas.ResumeLayout(false);
            gbxherramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scUsuarios;
        private GroupBox gbxUsuarios;
        private ComboBox cbxRoles;
        private Label lbRol;
        private Button btnGuardar;
        private ComboBox cbxEstatus;
        private DateTimePicker dtpNacimiento;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lbEstatus;
        private Label lbfechaNacimiento;
        private Label lbTelefono;
        private Label lbCorreo;
        private Label lbNombre;
        private GroupBox gbxherramientas;
        private Button btnCarga;
        private Button btncargaUsuario;
        private GroupBox gbxBusqueda;
        private Button btnBuscar;
        private TextBox txtBusqueda;
        private Label lbBusqueda;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private Label lbTipoFecha;
        private ComboBox cbxtipoFecha;
        private OpenFileDialog ofdArchivo;
        private Label lbCargaMasiva;
        private DataGridView dataGridView1;
        private Label lbConfirmcontra;
        private Label lbcontrasena;
        private TextBox txtContrasena;
        private TextBox txtConfContrasena;
        private Label lbcontraalert;
        private Label lbconfirmcontraAlert;
        private Label lbTitulo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estatus;
        private DataGridViewTextBoxColumn Rol;
        private Label lbl_obligatorios;
    }
}