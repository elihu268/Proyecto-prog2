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
            gbxBusquedaAuditoria = new GroupBox();
            btnBuscarAuditoria = new Button();
            textBox1 = new TextBox();
            lbBusqueda = new Label();
            lbFechaInicio = new Label();
            lbFechaFin = new Label();
            stpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            gbxBusquedaAuditoria.SuspendLayout();
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
            gbxBusquedaAuditoria.Location = new Point(0, 0);
            gbxBusquedaAuditoria.Name = "gbxBusquedaAuditoria";
            gbxBusquedaAuditoria.Size = new Size(533, 85);
            gbxBusquedaAuditoria.TabIndex = 0;
            gbxBusquedaAuditoria.TabStop = false;
            gbxBusquedaAuditoria.Text = "Busqueda de Auditorias";
            // 
            // btnBuscarAuditoria
            // 
            btnBuscarAuditoria.Location = new Point(373, 53);
            btnBuscarAuditoria.Name = "btnBuscarAuditoria";
            btnBuscarAuditoria.Size = new Size(82, 23);
            btnBuscarAuditoria.TabIndex = 2;
            btnBuscarAuditoria.Text = "Buscar";
            btnBuscarAuditoria.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
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
            // lbFechaInicio
            // 
            lbFechaInicio.AutoSize = true;
            lbFechaInicio.Location = new Point(20, 26);
            lbFechaInicio.Name = "lbFechaInicio";
            lbFechaInicio.Size = new Size(70, 15);
            lbFechaInicio.TabIndex = 3;
            lbFechaInicio.Text = "Fecha Inicio";
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
            // stpFechaInicio
            // 
            stpFechaInicio.Format = DateTimePickerFormat.Short;
            stpFechaInicio.Location = new Point(96, 22);
            stpFechaInicio.Name = "stpFechaInicio";
            stpFechaInicio.Size = new Size(137, 23);
            stpFechaInicio.TabIndex = 5;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(302, 22);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(137, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(gbxBusquedaAuditoria);
            Name = "frmAuditoria";
            Text = "frmAuditoria";
            gbxBusquedaAuditoria.ResumeLayout(false);
            gbxBusquedaAuditoria.PerformLayout();
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
    }
}