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
            dtpFechaFin = new DateTimePicker();
            stpFechaInicio = new DateTimePicker();
            lbFechaFin = new Label();
            lbFechaInicio = new Label();
            btnBuscarAuditoria = new Button();
            textBox1 = new TextBox();
            lbBusqueda = new Label();
            dgvAuditorias = new DataGridView();
            gbxBusquedaAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).BeginInit();
            SuspendLayout();
            // 
            // gbxBusquedaAuditoria
            // 
            gbxBusquedaAuditoria.Controls.Add(dtpFechaFin);
            gbxBusquedaAuditoria.Controls.Add(stpFechaInicio);
            gbxBusquedaAuditoria.Controls.Add(lbFechaFin);
            gbxBusquedaAuditoria.Controls.Add(lbFechaInicio);
            gbxBusquedaAuditoria.Controls.Add(btnBuscarAuditoria);
            gbxBusquedaAuditoria.Controls.Add(textBox1);
            gbxBusquedaAuditoria.Controls.Add(lbBusqueda);
            gbxBusquedaAuditoria.Dock = DockStyle.Top;
            gbxBusquedaAuditoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBusquedaAuditoria.Location = new Point(0, 0);
            gbxBusquedaAuditoria.Margin = new Padding(4, 5, 4, 5);
            gbxBusquedaAuditoria.Name = "gbxBusquedaAuditoria";
            gbxBusquedaAuditoria.Padding = new Padding(4, 5, 4, 5);
            gbxBusquedaAuditoria.Size = new Size(667, 131);
            gbxBusquedaAuditoria.TabIndex = 0;
            gbxBusquedaAuditoria.TabStop = false;
            gbxBusquedaAuditoria.Text = "Busqueda de Auditorias";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(388, 34);
            dtpFechaFin.Margin = new Padding(4, 5, 4, 5);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(175, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // stpFechaInicio
            // 
            stpFechaInicio.Format = DateTimePickerFormat.Short;
            stpFechaInicio.Location = new Point(123, 34);
            stpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            stpFechaInicio.Name = "stpFechaInicio";
            stpFechaInicio.Size = new Size(175, 23);
            stpFechaInicio.TabIndex = 5;
            // 
            // lbFechaFin
            // 
            lbFechaFin.AutoSize = true;
            lbFechaFin.Location = new Point(307, 40);
            lbFechaFin.Margin = new Padding(4, 0, 4, 0);
            lbFechaFin.Name = "lbFechaFin";
            lbFechaFin.Size = new Size(57, 15);
            lbFechaFin.TabIndex = 4;
            lbFechaFin.Text = "Fecha Fin";
            // 
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(26, 40);
            lbFechaInicio.Margin = new Padding(4, 0, 4, 0);
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
            btnBuscarAuditoria.Location = new Point(480, 81);
            btnBuscarAuditoria.Margin = new Padding(4, 5, 4, 5);
            btnBuscarAuditoria.Name = "btnBuscarAuditoria";
            btnBuscarAuditoria.Size = new Size(85, 35);
            btnBuscarAuditoria.TabIndex = 2;
            btnBuscarAuditoria.Text = "Buscar";
            btnBuscarAuditoria.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarAuditoria.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 83);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 1;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(26, 83);
            lbBusqueda.Margin = new Padding(4, 0, 4, 0);
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
            dgvAuditorias.Location = new Point(0, 131);
            dgvAuditorias.Margin = new Padding(4, 5, 4, 5);
            dgvAuditorias.Name = "dgvAuditorias";
            dgvAuditorias.RowHeadersWidth = 62;
            dgvAuditorias.Size = new Size(667, 602);
            dgvAuditorias.TabIndex = 1;
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(667, 733);
            Controls.Add(dgvAuditorias);
            Controls.Add(gbxBusquedaAuditoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAuditoria";
            Text = "Auditoria";
            gbxBusquedaAuditoria.ResumeLayout(false);
            gbxBusquedaAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxBusquedaAuditoria;
        private Button btnBuscarAuditoria;
        private TextBox textBox1;
        private Label lbBusqueda;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker stpFechaInicio;
        private Label lbFechaFin;
        private Label lbFechaInicio;
        private DataGridView dgvAuditorias;
    }
}