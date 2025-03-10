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
            scUsuarios = new SplitContainer();
            groupBox1 = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)scUsuarios).BeginInit();
            scUsuarios.Panel1.SuspendLayout();
            scUsuarios.Panel2.SuspendLayout();
            scUsuarios.SuspendLayout();
            groupBox1.SuspendLayout();
            gbxBusqueda.SuspendLayout();
            gbxherramientas.SuspendLayout();
            SuspendLayout();
            // 
            // scUsuarios
            // 
            scUsuarios.Dock = DockStyle.Fill;
            scUsuarios.Location = new Point(0, 0);
            scUsuarios.Name = "scUsuarios";
            // 
            // scUsuarios.Panel1
            // 
            scUsuarios.Panel1.Controls.Add(groupBox1);
            // 
            // scUsuarios.Panel2
            // 
            scUsuarios.Panel2.Controls.Add(gbxBusqueda);
            scUsuarios.Panel2.Controls.Add(gbxherramientas);
            scUsuarios.Size = new Size(876, 401);
            scUsuarios.SplitterDistance = 292;
            scUsuarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(cbxRoles);
            groupBox1.Controls.Add(lbRol);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(cbxEstatus);
            groupBox1.Controls.Add(dtpNacimiento);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lbEstatus);
            groupBox1.Controls.Add(lbfechaNacimiento);
            groupBox1.Controls.Add(lbTelefono);
            groupBox1.Controls.Add(lbCorreo);
            groupBox1.Controls.Add(lbNombre);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 401);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // cbxRoles
            // 
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Location = new Point(20, 289);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(121, 23);
            cbxRoles.TabIndex = 27;
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Location = new Point(15, 271);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(24, 15);
            lbRol.TabIndex = 26;
            lbRol.Text = "Rol";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(165, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(20, 240);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(135, 23);
            cbxEstatus.TabIndex = 23;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.ImeMode = ImeMode.NoControl;
            dtpNacimiento.Location = new Point(15, 196);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(15, 149);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(227, 23);
            txtTelefono.TabIndex = 21;
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(15, 88);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(225, 23);
            txtCorreo.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(15, 37);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 19;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(13, 222);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(44, 15);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus";
            // 
            // lbfechaNacimiento
            // 
            lbfechaNacimiento.AutoSize = true;
            lbfechaNacimiento.Location = new Point(18, 178);
            lbfechaNacimiento.Name = "lbfechaNacimiento";
            lbfechaNacimiento.Size = new Size(119, 15);
            lbfechaNacimiento.TabIndex = 17;
            lbfechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(15, 131);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(53, 15);
            lbTelefono.TabIndex = 16;
            lbTelefono.Text = "Telefono";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(15, 63);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(43, 15);
            lbCorreo.TabIndex = 15;
            lbCorreo.Text = "Correo";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(15, 19);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(107, 15);
            lbNombre.TabIndex = 14;
            lbNombre.Text = "Nombre Completo";
            // 
            // gbxBusqueda
            // 
            gbxBusqueda.BackColor = SystemColors.ControlLight;
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
            gbxBusqueda.Location = new Point(0, 63);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(580, 74);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda";
            // 
            // cbxtipoFecha
            // 
            cbxtipoFecha.FormattingEnabled = true;
            cbxtipoFecha.Location = new Point(83, 17);
            cbxtipoFecha.Name = "cbxtipoFecha";
            cbxtipoFecha.Size = new Size(87, 23);
            cbxtipoFecha.TabIndex = 12;
            // 
            // lbTipoFecha
            // 
            lbTipoFecha.AutoSize = true;
            lbTipoFecha.Location = new Point(12, 19);
            lbTipoFecha.Name = "lbTipoFecha";
            lbTipoFecha.Size = new Size(65, 15);
            lbTipoFecha.TabIndex = 11;
            lbTipoFecha.Text = "Tipo Fecha";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(423, 15);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(110, 23);
            dtpFechaFin.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(282, 14);
            dtpFechaInicio.Margin = new Padding(2, 2, 2, 2);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(78, 23);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(365, 19);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 8;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(207, 19);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(70, 15);
            lbFechaInicio.TabIndex = 7;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(449, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "actualizar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(137, 45);
            txtBusqueda.MaxLength = 100;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(267, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(10, 44);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(123, 15);
            lbBusqueda.TabIndex = 0;
            lbBusqueda.Text = "Busqueda de Usuarios";
            // 
            // gbxherramientas
            // 
            gbxherramientas.BackColor = SystemColors.ControlLight;
            gbxherramientas.Controls.Add(lbCargaMasiva);
            gbxherramientas.Controls.Add(btnCarga);
            gbxherramientas.Controls.Add(btncargaUsuario);
            gbxherramientas.Dock = DockStyle.Top;
            gbxherramientas.Location = new Point(0, 0);
            gbxherramientas.Name = "gbxherramientas";
            gbxherramientas.Size = new Size(580, 63);
            gbxherramientas.TabIndex = 0;
            gbxherramientas.TabStop = false;
            gbxherramientas.Text = "herramientas";
            // 
            // lbCargaMasiva
            // 
            lbCargaMasiva.AutoSize = true;
            lbCargaMasiva.Location = new Point(220, 22);
            lbCargaMasiva.Margin = new Padding(2, 0, 2, 0);
            lbCargaMasiva.Name = "lbCargaMasiva";
            lbCargaMasiva.Size = new Size(86, 15);
            lbCargaMasiva.TabIndex = 2;
            lbCargaMasiva.Text = "Ruta de acceso";
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(127, 18);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(88, 23);
            btnCarga.TabIndex = 1;
            btnCarga.Text = "Carga Masiva";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btncargaUsuario
            // 
            btncargaUsuario.Location = new Point(6, 18);
            btncargaUsuario.Name = "btncargaUsuario";
            btncargaUsuario.Size = new Size(115, 23);
            btncargaUsuario.TabIndex = 0;
            btncargaUsuario.Text = "Cargar Usuario";
            btncargaUsuario.UseVisualStyleBackColor = true;
            btncargaUsuario.Click += btncargaUsuario_Click;
            // 
            // ofdArchivo
            // 
            ofdArchivo.FileName = "Carga Masiva de Usuarios";
            // 
            // frmGestUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 401);
            Controls.Add(scUsuarios);
            Name = "frmGestUsuario";
            Text = "frmGestUsuario";
            Load += frmGestUsuario_Load;
            scUsuarios.Panel1.ResumeLayout(false);
            scUsuarios.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scUsuarios).EndInit();
            scUsuarios.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            gbxherramientas.ResumeLayout(false);
            gbxherramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scUsuarios;
        private GroupBox groupBox1;
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
    }
}