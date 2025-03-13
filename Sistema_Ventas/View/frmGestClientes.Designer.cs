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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ofdClientes = new OpenFileDialog();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            scClientes = new SplitContainer();
            gbxActulizardatos = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)scClientes).BeginInit();
            scClientes.Panel1.SuspendLayout();
            scClientes.Panel2.SuspendLayout();
            scClientes.SuspendLayout();
            gbxActulizardatos.SuspendLayout();
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
            scClientes.Location = new Point(0, 36);
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
            scClientes.Size = new Size(839, 380);
            scClientes.SplitterDistance = 270;
            scClientes.TabIndex = 0;
            // 
            // gbxActulizardatos
            // 
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
            gbxActulizardatos.Location = new Point(0, 0);
            gbxActulizardatos.Name = "gbxActulizardatos";
            gbxActulizardatos.Size = new Size(270, 380);
            gbxActulizardatos.TabIndex = 0;
            gbxActulizardatos.TabStop = false;
            gbxActulizardatos.Text = "Alta o Actulizacion";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Sistema_Ventas.Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(149, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(79, 31);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(10, 251);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(121, 23);
            cbxEstatus.TabIndex = 19;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(8, 233);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(44, 15);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus";
            // 
            // dtpNacimientoCliente
            // 
            dtpNacimientoCliente.Format = DateTimePickerFormat.Short;
            dtpNacimientoCliente.Location = new Point(10, 207);
            dtpNacimientoCliente.Name = "dtpNacimientoCliente";
            dtpNacimientoCliente.Size = new Size(200, 23);
            dtpNacimientoCliente.TabIndex = 17;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(10, 153);
            txtTelefonoCliente.MaxLength = 15;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(201, 23);
            txtTelefonoCliente.TabIndex = 16;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(10, 109);
            txtCorreoCliente.MaxLength = 15;
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(206, 23);
            txtCorreoCliente.TabIndex = 15;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(10, 58);
            txtNombreCliente.MaxLength = 100;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(203, 23);
            txtNombreCliente.TabIndex = 14;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(8, 135);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(53, 15);
            lbTelefono.TabIndex = 13;
            lbTelefono.Text = "Telefono";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Location = new Point(8, 182);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(119, 15);
            lbNacimiento.TabIndex = 12;
            lbNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(8, 84);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(43, 15);
            lbCorreo.TabIndex = 11;
            lbCorreo.Text = "Correo";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(8, 33);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(107, 15);
            lbNombre.TabIndex = 10;
            lbNombre.Text = "Nombre Completo";
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
            dataGridView1.Location = new Point(0, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 239);
            dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
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
            gbxBusqueda.Location = new Point(0, 48);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(565, 93);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda de Clientes";
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
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(110, 23);
            dtpFechaInicio.TabIndex = 15;
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
            lbFechaInicio.Size = new Size(70, 15);
            lbFechaInicio.TabIndex = 13;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Sistema_Ventas.Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(380, 55);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 30);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actulizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(108, 54);
            txtBusqueda.MaxLength = 100;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(253, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(20, 58);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(82, 15);
            lbBuscar.TabIndex = 0;
            lbBuscar.Text = "Buscar Cliente";
            // 
            // gbxHerramientas
            // 
            gbxHerramientas.Controls.Add(lbseleccione);
            gbxHerramientas.Controls.Add(btnCargaMasiva);
            gbxHerramientas.Controls.Add(btncollapse);
            gbxHerramientas.Dock = DockStyle.Top;
            gbxHerramientas.Location = new Point(0, 0);
            gbxHerramientas.Name = "gbxHerramientas";
            gbxHerramientas.Size = new Size(565, 48);
            gbxHerramientas.TabIndex = 0;
            gbxHerramientas.TabStop = false;
            gbxHerramientas.Text = "Herramientas";
            // 
            // lbseleccione
            // 
            lbseleccione.AutoSize = true;
            lbseleccione.Location = new Point(242, 24);
            lbseleccione.Name = "lbseleccione";
            lbseleccione.Size = new Size(171, 15);
            lbseleccione.TabIndex = 2;
            lbseleccione.Text = "Seleccione un Archivo xlsx o xls";
            // 
            // btnCargaMasiva
            // 
            btnCargaMasiva.BackColor = SystemColors.ActiveCaption;
            btnCargaMasiva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaMasiva.Image = Sistema_Ventas.Properties.Resources.upload1;
            btnCargaMasiva.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargaMasiva.Location = new Point(130, 20);
            btnCargaMasiva.Name = "btnCargaMasiva";
            btnCargaMasiva.Size = new Size(97, 23);
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
            btncollapse.Location = new Point(9, 20);
            btncollapse.Name = "btncollapse";
            btncollapse.Size = new Size(106, 23);
            btncollapse.TabIndex = 0;
            btncollapse.Text = "Cargar Cliente";
            btncollapse.TextAlign = ContentAlignment.MiddleRight;
            btncollapse.UseVisualStyleBackColor = false;
            btncollapse.Click += btncollapse_Click;
            // 
            // lbtitle
            // 
            lbtitle.BackColor = SystemColors.GradientActiveCaption;
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
            // frmGestClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(839, 416);
            Controls.Add(lbtitle);
            Controls.Add(scClientes);
            Name = "frmGestClientes";
            Text = "Gestion de Clientes";
            Load += frmGestClientes_Load;
            scClientes.Panel1.ResumeLayout(false);
            scClientes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scClientes).EndInit();
            scClientes.ResumeLayout(false);
            gbxActulizardatos.ResumeLayout(false);
            gbxActulizardatos.PerformLayout();
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
    }
}