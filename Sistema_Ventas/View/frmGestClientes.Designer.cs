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
            splitContainer1 = new SplitContainer();
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
            gbxBusqueda = new GroupBox();
            btnActualizar = new Button();
            txtBusqueda = new TextBox();
            lbBuscar = new Label();
            gbxHerramientas = new GroupBox();
            lbseleccione = new Label();
            btnCargaMasiva = new Button();
            btncollapse = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dtpFechaFin = new DateTimePicker();
            stpFechaInicio = new DateTimePicker();
            lbFechaFin = new Label();
            lbFechaInicio = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbxActulizardatos.SuspendLayout();
            gbxBusqueda.SuspendLayout();
            gbxHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbxActulizardatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gbxBusqueda);
            splitContainer1.Panel2.Controls.Add(gbxHerramientas);
            splitContainer1.Size = new Size(839, 416);
            splitContainer1.SplitterDistance = 279;
            splitContainer1.TabIndex = 0;
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
            gbxActulizardatos.Size = new Size(279, 416);
            gbxActulizardatos.TabIndex = 0;
            gbxActulizardatos.TabStop = false;
            gbxActulizardatos.Text = "Alta o Actulizacion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(149, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(12, 251);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(121, 23);
            cbxEstatus.TabIndex = 19;
            // 
            // lbEstatus
            // 
            lbEstatus.AutoSize = true;
            lbEstatus.Location = new Point(14, 233);
            lbEstatus.Name = "lbEstatus";
            lbEstatus.Size = new Size(44, 15);
            lbEstatus.TabIndex = 18;
            lbEstatus.Text = "Estatus";
            // 
            // dtpNacimientoCliente
            // 
            dtpNacimientoCliente.Format = DateTimePickerFormat.Short;
            dtpNacimientoCliente.Location = new Point(12, 207);
            dtpNacimientoCliente.Name = "dtpNacimientoCliente";
            dtpNacimientoCliente.Size = new Size(200, 23);
            dtpNacimientoCliente.TabIndex = 17;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(9, 153);
            txtTelefonoCliente.MaxLength = 15;
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(201, 23);
            txtTelefonoCliente.TabIndex = 16;
            // 
            // txtCorreoCliente
            // 
            txtCorreoCliente.Location = new Point(9, 109);
            txtCorreoCliente.MaxLength = 15;
            txtCorreoCliente.Name = "txtCorreoCliente";
            txtCorreoCliente.Size = new Size(206, 23);
            txtCorreoCliente.TabIndex = 15;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 58);
            txtNombreCliente.MaxLength = 100;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(203, 23);
            txtNombreCliente.TabIndex = 14;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(14, 135);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(53, 15);
            lbTelefono.TabIndex = 13;
            lbTelefono.Text = "Telefono";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Location = new Point(14, 182);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(119, 15);
            lbNacimiento.TabIndex = 12;
            lbNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Location = new Point(9, 84);
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
            // gbxBusqueda
            // 
            gbxBusqueda.Controls.Add(dtpFechaFin);
            gbxBusqueda.Controls.Add(stpFechaInicio);
            gbxBusqueda.Controls.Add(lbFechaFin);
            gbxBusqueda.Controls.Add(lbFechaInicio);
            gbxBusqueda.Controls.Add(btnActualizar);
            gbxBusqueda.Controls.Add(txtBusqueda);
            gbxBusqueda.Controls.Add(lbBuscar);
            gbxBusqueda.Location = new Point(0, 49);
            gbxBusqueda.Name = "gbxBusqueda";
            gbxBusqueda.Size = new Size(556, 83);
            gbxBusqueda.TabIndex = 1;
            gbxBusqueda.TabStop = false;
            gbxBusqueda.Text = "Busqueda de Clientes";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(380, 54);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actulizar";
            btnActualizar.UseVisualStyleBackColor = true;
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
            lbBuscar.Location = new Point(20, 57);
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
            gbxHerramientas.Location = new Point(0, 0);
            gbxHerramientas.Name = "gbxHerramientas";
            gbxHerramientas.Size = new Size(557, 48);
            gbxHerramientas.TabIndex = 0;
            gbxHerramientas.TabStop = false;
            gbxHerramientas.Text = "Herramientas";
            // 
            // lbseleccione
            // 
            lbseleccione.AutoSize = true;
            lbseleccione.Location = new Point(208, 24);
            lbseleccione.Name = "lbseleccione";
            lbseleccione.Size = new Size(171, 15);
            lbseleccione.TabIndex = 2;
            lbseleccione.Text = "Seleccione un Archivo xlsx o xls";
            // 
            // btnCargaMasiva
            // 
            btnCargaMasiva.Location = new Point(108, 20);
            btnCargaMasiva.Name = "btnCargaMasiva";
            btnCargaMasiva.Size = new Size(80, 23);
            btnCargaMasiva.TabIndex = 1;
            btnCargaMasiva.Text = "Cargar Excel";
            btnCargaMasiva.UseVisualStyleBackColor = true;
            // 
            // btncollapse
            // 
            btncollapse.Location = new Point(9, 20);
            btncollapse.Name = "btncollapse";
            btncollapse.Size = new Size(93, 23);
            btncollapse.TabIndex = 0;
            btncollapse.Text = "Cargar Cliente";
            btncollapse.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(304, 22);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(137, 23);
            dtpFechaFin.TabIndex = 10;
            // 
            // stpFechaInicio
            // 
            stpFechaInicio.Format = DateTimePickerFormat.Short;
            stpFechaInicio.Location = new Point(98, 22);
            stpFechaInicio.Name = "stpFechaInicio";
            stpFechaInicio.Size = new Size(137, 23);
            stpFechaInicio.TabIndex = 9;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(241, 26);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 8;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(22, 26);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(70, 15);
            lbFechaInicio.TabIndex = 7;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // frmGestClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 416);
            Controls.Add(splitContainer1);
            Name = "frmGestClientes";
            Text = "frmGestClientes";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbxActulizardatos.ResumeLayout(false);
            gbxActulizardatos.PerformLayout();
            gbxBusqueda.ResumeLayout(false);
            gbxBusqueda.PerformLayout();
            gbxHerramientas.ResumeLayout(false);
            gbxHerramientas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbxHerramientas;
        private Button btnCargaMasiva;
        private Button btncollapse;
        private Label lbseleccione;
        private GroupBox gbxBusqueda;
        private Button btnActualizar;
        private TextBox txtBusqueda;
        private Label lbBuscar;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker stpFechaInicio;
        private Label lbFechaFin;
        private Label lbFechaInicio;
    }
}