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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxBusqueda.SuspendLayout();
            gbxherramientas.SuspendLayout();
            SuspendLayout();
            // 
            // scUsuarios
            // 
            scUsuarios.Dock = DockStyle.Fill;
            scUsuarios.Location = new Point(0, 0);
            scUsuarios.Margin = new Padding(4, 5, 4, 5);
            scUsuarios.Name = "scUsuarios";
            // 
            // scUsuarios.Panel1
            // 
            scUsuarios.Panel1.Controls.Add(groupBox1);
            // 
            // scUsuarios.Panel2
            // 
            scUsuarios.Panel2.Controls.Add(dataGridView1);
            scUsuarios.Panel2.Controls.Add(gbxBusqueda);
            scUsuarios.Panel2.Controls.Add(gbxherramientas);
            scUsuarios.Size = new Size(1251, 668);
            scUsuarios.SplitterDistance = 417;
            scUsuarios.SplitterWidth = 6;
            scUsuarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
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
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 5);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(413, 668);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // cbxRoles
            // 
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Location = new Point(21, 433);
            cbxRoles.Margin = new Padding(4, 5, 4, 5);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(171, 33);
            cbxRoles.TabIndex = 27;
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.Location = new Point(21, 400);
            lbRol.Margin = new Padding(4, 0, 4, 0);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(39, 25);
            lbRol.TabIndex = 26;
            lbRol.Text = "Rol";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(236, 548);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 50);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(21, 358);
            cbxEstatus.Margin = new Padding(4, 5, 4, 5);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(191, 33);
            cbxEstatus.TabIndex = 23;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.ImeMode = ImeMode.NoControl;
            dtpNacimiento.Location = new Point(21, 283);
            dtpNacimiento.Margin = new Padding(4, 5, 4, 5);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(284, 31);
            dtpNacimiento.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(21, 217);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(323, 31);
            txtTelefono.TabIndex = 21;
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(21, 147);
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
            lbEstatus.Location = new Point(19, 330);
            lbEstatus.Margin = new Padding(4, 0, 4, 0);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(71, 25);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus";
            // 
            // lbfechaNacimiento
            // 
            lbfechaNacimiento.AutoSize = true;
            lbfechaNacimiento.Location = new Point(26, 258);
            lbfechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            lbfechaNacimiento.Name = "lbfechaNacimiento";
            lbfechaNacimiento.Size = new Size(185, 25);
            lbfechaNacimiento.TabIndex = 17;
            lbfechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(21, 192);
            lbTelefono.Margin = new Padding(4, 0, 4, 0);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(84, 25);
            lbTelefono.TabIndex = 16;
            lbTelefono.Text = "Telefono";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(21, 105);
            lbCorreo.Margin = new Padding(4, 0, 4, 0);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(69, 25);
            lbCorreo.TabIndex = 15;
            lbCorreo.Text = "Correo";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 32);
            lbNombre.Margin = new Padding(4, 0, 4, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(168, 25);
            lbNombre.TabIndex = 14;
            lbNombre.Text = "Nombre Completo";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(-1, 218);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(829, 450);
            dataGridView1.TabIndex = 2;
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
            gbxherramientas.BackColor = SystemColors.GradientInactiveCaption;
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
            lbCargaMasiva.Location = new Point(369, 32);
            lbCargaMasiva.Name = "lbCargaMasiva";
            lbCargaMasiva.Size = new Size(135, 25);
            lbCargaMasiva.TabIndex = 2;
            lbCargaMasiva.Text = "Ruta de acceso";
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
            // frmGestUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1251, 668);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}