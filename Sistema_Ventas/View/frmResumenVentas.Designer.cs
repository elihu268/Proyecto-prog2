namespace Sistema_Ventas.View
{
    partial class frmResumenVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenVentas));
            dgvResumVentas = new DataGridView();
            gbFiltros = new GroupBox();
            lblprueba = new Label();
            pictureBox1 = new PictureBox();
            btnActualizar = new Button();
            dtpFechaFin = new DateTimePicker();
            dtpFechaIn = new DateTimePicker();
            lblFechaIni = new Label();
            lblFechaFin = new Label();
            lblBusquedaTex = new Label();
            txtBusqueda = new TextBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResumVentas).BeginInit();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvResumVentas
            // 
            dgvResumVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResumVentas.BackgroundColor = SystemColors.ActiveCaption;
            dgvResumVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumVentas.Location = new Point(0, 139);
            dgvResumVentas.Margin = new Padding(2);
            dgvResumVentas.Name = "dgvResumVentas";
            dgvResumVentas.ReadOnly = true;
            dgvResumVentas.RowHeadersWidth = 62;
            dgvResumVentas.Size = new Size(622, 232);
            dgvResumVentas.TabIndex = 1;
            dgvResumVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.BackColor = SystemColors.InactiveBorder;
            gbFiltros.Controls.Add(lblprueba);
            gbFiltros.Controls.Add(pictureBox1);
            gbFiltros.Controls.Add(btnActualizar);
            gbFiltros.Controls.Add(dtpFechaFin);
            gbFiltros.Controls.Add(dtpFechaIn);
            gbFiltros.Controls.Add(lblFechaIni);
            gbFiltros.Controls.Add(lblFechaFin);
            gbFiltros.Controls.Add(lblBusquedaTex);
            gbFiltros.Controls.Add(txtBusqueda);
            gbFiltros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFiltros.Location = new Point(0, 34);
            gbFiltros.Margin = new Padding(2);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Padding = new Padding(2);
            gbFiltros.Size = new Size(622, 101);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // lblprueba
            // 
            lblprueba.AutoSize = true;
            lblprueba.Location = new Point(389, 76);
            lblprueba.Name = "lblprueba";
            lblprueba.Size = new Size(37, 15);
            lblprueba.TabIndex = 27;
            lblprueba.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Resumen1;
            pictureBox1.Location = new Point(495, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(214, 69);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 25);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.ImeMode = ImeMode.NoControl;
            dtpFechaFin.Location = new Point(339, 37);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(100, 23);
            dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaIn
            // 
            dtpFechaIn.Format = DateTimePickerFormat.Short;
            dtpFechaIn.ImeMode = ImeMode.NoControl;
            dtpFechaIn.Location = new Point(102, 37);
            dtpFechaIn.Name = "dtpFechaIn";
            dtpFechaIn.Size = new Size(100, 23);
            dtpFechaIn.TabIndex = 23;
            // 
            // lblFechaIni
            // 
            lblFechaIni.AutoSize = true;
            lblFechaIni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIni.Location = new Point(16, 41);
            lblFechaIni.Margin = new Padding(2, 0, 2, 0);
            lblFechaIni.Name = "lblFechaIni";
            lblFechaIni.Size = new Size(76, 15);
            lblFechaIni.TabIndex = 3;
            lblFechaIni.Text = "Fecha inicio: ";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.Location = new Point(265, 37);
            lblFechaFin.Margin = new Padding(2, 0, 2, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(58, 15);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha fin:";
            // 
            // lblBusquedaTex
            // 
            lblBusquedaTex.AutoSize = true;
            lblBusquedaTex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaTex.Location = new Point(16, 14);
            lblBusquedaTex.Margin = new Padding(2, 0, 2, 0);
            lblBusquedaTex.Name = "lblBusquedaTex";
            lblBusquedaTex.Size = new Size(108, 15);
            lblBusquedaTex.TabIndex = 1;
            lblBusquedaTex.Text = "Busqueda de texto:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(141, 11);
            txtBusqueda.Margin = new Padding(2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(298, 23);
            txtBusqueda.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.SteelBlue;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(622, 33);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Resumen de Ventas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmResumenVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(622, 370);
            Controls.Add(lblTitulo);
            Controls.Add(gbFiltros);
            Controls.Add(dgvResumVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmResumenVentas";
            Text = "Resumen Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvResumVentas).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvResumVentas;
        private GroupBox gbFiltros;
        private Label lblFechaIni;
        private Label lblFechaFin;
        private Label lblBusquedaTex;
        private TextBox txtBusqueda;
        private Button btnActualizar;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaIn;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblprueba;
    }
}