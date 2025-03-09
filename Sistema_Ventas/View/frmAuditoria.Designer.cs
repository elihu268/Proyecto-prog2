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
            lbBusqueda = new Label();
            textBox1 = new TextBox();
            btnBuscarAuditoria = new Button();
            gbxBusquedaAuditoria.SuspendLayout();
            SuspendLayout();
            // 
            // gbxBusquedaAuditoria
            // 
            gbxBusquedaAuditoria.Controls.Add(btnBuscarAuditoria);
            gbxBusquedaAuditoria.Controls.Add(textBox1);
            gbxBusquedaAuditoria.Controls.Add(lbBusqueda);
            gbxBusquedaAuditoria.Location = new Point(0, 0);
            gbxBusquedaAuditoria.Name = "gbxBusquedaAuditoria";
            gbxBusquedaAuditoria.Size = new Size(800, 55);
            gbxBusquedaAuditoria.TabIndex = 0;
            gbxBusquedaAuditoria.TabStop = false;
            gbxBusquedaAuditoria.Text = "Busqueda de Auditorias";
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Location = new Point(23, 27);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(94, 15);
            lbBusqueda.TabIndex = 0;
            lbBusqueda.Text = "Buscar Auditoria";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
            // 
            // btnBuscarAuditoria
            // 
            btnBuscarAuditoria.Location = new Point(397, 27);
            btnBuscarAuditoria.Name = "btnBuscarAuditoria";
            btnBuscarAuditoria.Size = new Size(82, 23);
            btnBuscarAuditoria.TabIndex = 2;
            btnBuscarAuditoria.Text = "Buscar";
            btnBuscarAuditoria.UseVisualStyleBackColor = true;
            // 
            // frmAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}