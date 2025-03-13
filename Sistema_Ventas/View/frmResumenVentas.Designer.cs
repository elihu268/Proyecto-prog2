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
            pictureBox1 = new PictureBox();
            btnActualizar = new Button();
            dtpFechaFin = new DateTimePicker();
            dtpFechaIn = new DateTimePicker();
            lblFechaIni = new Label();
            lblFechaFin = new Label();
            lblBusquedaTex = new Label();
            txtBusqueda = new TextBox();
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
            dgvResumVentas.Location = new Point(13, 183);
            dgvResumVentas.Name = "dgvResumVentas";
            dgvResumVentas.RowHeadersWidth = 62;
            dgvResumVentas.Size = new Size(862, 293);
            dgvResumVentas.TabIndex = 1;
            dgvResumVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gbFiltros
            // 
            gbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFiltros.Controls.Add(pictureBox1);
            gbFiltros.Controls.Add(btnActualizar);
            gbFiltros.Controls.Add(dtpFechaFin);
            gbFiltros.Controls.Add(dtpFechaIn);
            gbFiltros.Controls.Add(lblFechaIni);
            gbFiltros.Controls.Add(lblFechaFin);
            gbFiltros.Controls.Add(lblBusquedaTex);
            gbFiltros.Controls.Add(txtBusqueda);
            gbFiltros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFiltros.Location = new Point(13, 13);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(862, 163);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Resumen1;
            pictureBox1.Location = new Point(708, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 120);
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
            btnActualizar.Location = new Point(306, 115);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(162, 42);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.ImeMode = ImeMode.NoControl;
            dtpFechaFin.Location = new Point(484, 62);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(141, 31);
            dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaIn
            // 
            dtpFechaIn.Format = DateTimePickerFormat.Short;
            dtpFechaIn.ImeMode = ImeMode.NoControl;
            dtpFechaIn.Location = new Point(146, 62);
            dtpFechaIn.Margin = new Padding(4, 5, 4, 5);
            dtpFechaIn.Name = "dtpFechaIn";
            dtpFechaIn.Size = new Size(141, 31);
            dtpFechaIn.TabIndex = 23;
            // 
            // lblFechaIni
            // 
            lblFechaIni.AutoSize = true;
            lblFechaIni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIni.Location = new Point(22, 68);
            lblFechaIni.Name = "lblFechaIni";
            lblFechaIni.Size = new Size(117, 25);
            lblFechaIni.TabIndex = 3;
            lblFechaIni.Text = "Fecha inicio: ";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.Location = new Point(379, 62);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(89, 25);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha fin:";
            // 
            // lblBusquedaTex
            // 
            lblBusquedaTex.AutoSize = true;
            lblBusquedaTex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaTex.Location = new Point(22, 24);
            lblBusquedaTex.Name = "lblBusquedaTex";
            lblBusquedaTex.Size = new Size(173, 25);
            lblBusquedaTex.TabIndex = 1;
            lblBusquedaTex.Text = "Busqueda de texto:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(201, 18);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(424, 31);
            txtBusqueda.TabIndex = 0;
            // 
            // frmResumenVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(889, 489);
            Controls.Add(gbFiltros);
            Controls.Add(dgvResumVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}