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
            dgvResumVentas = new DataGridView();
            gbFiltros = new GroupBox();
            txtBusqueda = new TextBox();
            lblBusquedaTex = new Label();
            lblFechaFin = new Label();
            lblFechaIni = new Label();
            dtpFechaIn = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            btnActualizar = new Button();
            pictureBox1 = new PictureBox();
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
            dgvResumVentas.Location = new Point(12, 168);
            dgvResumVentas.Name = "dgvResumVentas";
            dgvResumVentas.Size = new Size(776, 270);
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
            gbFiltros.Location = new Point(12, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(776, 150);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(177, 32);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(382, 30);
            txtBusqueda.TabIndex = 0;
            // 
            // lblBusquedaTex
            // 
            lblBusquedaTex.AutoSize = true;
            lblBusquedaTex.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusquedaTex.Location = new Point(6, 35);
            lblBusquedaTex.Name = "lblBusquedaTex";
            lblBusquedaTex.Size = new Size(165, 23);
            lblBusquedaTex.TabIndex = 1;
            lblBusquedaTex.Text = "Busqueda de texto:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.Location = new Point(330, 73);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(87, 23);
            lblFechaFin.TabIndex = 2;
            lblFechaFin.Text = "Fecha fin:";
            // 
            // lblFechaIni
            // 
            lblFechaIni.AutoSize = true;
            lblFechaIni.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaIni.Location = new Point(59, 73);
            lblFechaIni.Name = "lblFechaIni";
            lblFechaIni.Size = new Size(113, 23);
            lblFechaIni.TabIndex = 3;
            lblFechaIni.Text = "Fecha inicio: ";
            // 
            // dtpFechaIn
            // 
            dtpFechaIn.Format = DateTimePickerFormat.Short;
            dtpFechaIn.ImeMode = ImeMode.NoControl;
            dtpFechaIn.Location = new Point(177, 67);
            dtpFechaIn.Margin = new Padding(4, 5, 4, 5);
            dtpFechaIn.Name = "dtpFechaIn";
            dtpFechaIn.Size = new Size(127, 30);
            dtpFechaIn.TabIndex = 23;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.ImeMode = ImeMode.NoControl;
            dtpFechaFin.Location = new Point(424, 67);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(127, 30);
            dtpFechaFin.TabIndex = 24;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(275, 106);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 33);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Resumen1;
            pictureBox1.Location = new Point(569, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // frmResumenVentas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(gbFiltros);
            Controls.Add(dgvResumVentas);
            Name = "frmResumenVentas";
            Text = "frmResumenVentas";
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