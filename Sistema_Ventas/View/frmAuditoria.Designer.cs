namespace PuntodeVenta.View
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            gbxBusquedaAuditoria = new GroupBox();
            btnExportExcel = new Button();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            lbFechaFin = new Label();
            lbFechaInicio = new Label();
            btnBuscarAuditoria = new Button();
            txtBusqueda = new TextBox();
            lbBusqueda = new Label();
            dgvAuditorias = new DataGridView();
            gbxBusquedaAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).BeginInit();
            SuspendLayout();
            // 
            // gbxBusquedaAuditoria
            // 
            gbxBusquedaAuditoria.Controls.Add(btnExportExcel);
            gbxBusquedaAuditoria.Controls.Add(dtpFechaFin);
            gbxBusquedaAuditoria.Controls.Add(dtpFechaInicio);
            gbxBusquedaAuditoria.Controls.Add(lbFechaFin);
            gbxBusquedaAuditoria.Controls.Add(lbFechaInicio);
            gbxBusquedaAuditoria.Controls.Add(btnBuscarAuditoria);
            gbxBusquedaAuditoria.Controls.Add(txtBusqueda);
            gbxBusquedaAuditoria.Controls.Add(lbBusqueda);
            gbxBusquedaAuditoria.Dock = DockStyle.Top;
            gbxBusquedaAuditoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBusquedaAuditoria.Location = new Point(0, 0);
            gbxBusquedaAuditoria.Name = "gbxBusquedaAuditoria";
            gbxBusquedaAuditoria.Size = new Size(616, 85);
            gbxBusquedaAuditoria.TabIndex = 0;
            gbxBusquedaAuditoria.TabStop = false;
            gbxBusquedaAuditoria.Text = "Busqueda de Auditorias";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(486, 36);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(118, 23);
            btnExportExcel.TabIndex = 7;
            btnExportExcel.Text = "Exportar Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(302, 22);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(137, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(96, 22);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(137, 23);
            dtpFechaInicio.TabIndex = 5;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(239, 26);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 4;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(20, 26);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(71, 15);
            lbFechaInicio.TabIndex = 3;
            lbFechaInicio.Text = "Fecha Inicio";
            // 
            // btnBuscarAuditoria
            // 
            btnBuscarAuditoria.BackColor = SystemColors.ActiveCaption;
            btnBuscarAuditoria.Image = Sistema_Ventas.Properties.Resources.search;
            btnBuscarAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarAuditoria.Location = new Point(373, 53);
            btnBuscarAuditoria.Name = "btnBuscarAuditoria";
            btnBuscarAuditoria.Size = new Size(66, 23);
            btnBuscarAuditoria.TabIndex = 2;
            btnBuscarAuditoria.Text = "Buscar";
            btnBuscarAuditoria.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarAuditoria.UseVisualStyleBackColor = false;
            btnBuscarAuditoria.Click += btnBuscarAuditoria_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(120, 54);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(247, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(20, 54);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(94, 15);
            lbBusqueda.TabIndex = 0;
            lbBusqueda.Text = "Buscar Auditoria";
            // 
            // dgvAuditorias
            // 
            dgvAuditorias.BackgroundColor = SystemColors.Control;
            dgvAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditorias.Dock = DockStyle.Fill;
            dgvAuditorias.Location = new Point(0, 85);
            dgvAuditorias.Name = "dgvAuditorias";
            dgvAuditorias.RowHeadersWidth = 62;
            dgvAuditorias.Size = new Size(616, 393);
            dgvAuditorias.TabIndex = 1;
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(616, 478);
            Controls.Add(dgvAuditorias);
            Controls.Add(gbxBusquedaAuditoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAuditoria";
            Text = "Auditoria";
            Load += frmAuditoria_Load_1;
            gbxBusquedaAuditoria.ResumeLayout(false);
            gbxBusquedaAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxBusquedaAuditoria;
        private Button btnBuscarAuditoria;
        private TextBox txtBusqueda;
        private Label lbBusqueda;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private DataGridView dgvAuditorias;
        private Button btnExportExcel;
    }
}