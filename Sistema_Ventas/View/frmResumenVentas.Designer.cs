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
            lblTitulo = new Label();
            dgvResumVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResumVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = SystemColors.ActiveCaption;
            lblTitulo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(776, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Resumen de ventas";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvResumVentas
            // 
            dgvResumVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResumVentas.BackgroundColor = SystemColors.Window;
            dgvResumVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumVentas.Location = new Point(12, 44);
            dgvResumVentas.Name = "dgvResumVentas";
            dgvResumVentas.Size = new Size(776, 394);
            dgvResumVentas.TabIndex = 1;
            dgvResumVentas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmResumenVentas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResumVentas);
            Controls.Add(lblTitulo);
            Name = "frmResumenVentas";
            Text = "frmResumenVentas";
            ((System.ComponentModel.ISupportInitialize)dgvResumVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvResumVentas;
    }
}