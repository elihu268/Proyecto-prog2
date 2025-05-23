namespace Sistema_Ventas.View
{
    partial class frmCargaCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaCatalogo));
            btnCargaCatalogo = new Button();
            btnActualizar = new Button();
            dgvCatalogo = new DataGridView();
            ofdCatalogo = new OpenFileDialog();
            pbCatalogo = new PictureBox();
            groupBox1 = new GroupBox();
            lblTitulo = new Label();
            btnImportarExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.BackColor = SystemColors.ActiveCaption;
            btnCargaCatalogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaCatalogo.Location = new Point(248, 28);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(263, 44);
            btnCargaCatalogo.TabIndex = 1;
            btnCargaCatalogo.Text = "Carga de Catalogo";
            btnCargaCatalogo.UseVisualStyleBackColor = false;
            btnCargaCatalogo.Click += btnCargaCatalogo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(290, 85);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(157, 34);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatalogo.BackgroundColor = SystemColors.ActiveCaption;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(1, 184);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(799, 254);
            dgvCatalogo.TabIndex = 4;
            // 
            // ofdCatalogo
            // 
            ofdCatalogo.FileName = "ofdCatalogo";
            // 
            // pbCatalogo
            // 
            pbCatalogo.Image = Properties.Resources.catalogo1;
            pbCatalogo.Location = new Point(24, 28);
            pbCatalogo.Name = "pbCatalogo";
            pbCatalogo.Size = new Size(97, 75);
            pbCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCatalogo.TabIndex = 5;
            pbCatalogo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(btnImportarExcel);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnCargaCatalogo);
            groupBox1.Controls.Add(pbCatalogo);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 124);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Herramientas";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.SteelBlue;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 51);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Carga de Catalogos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnImportarExcel
            // 
            btnImportarExcel.AccessibleDescription = "";
            btnImportarExcel.BackColor = SystemColors.ActiveCaption;
            btnImportarExcel.Cursor = Cursors.Hand;
            btnImportarExcel.FlatAppearance.BorderSize = 0;
            btnImportarExcel.FlatStyle = FlatStyle.Flat;
            btnImportarExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportarExcel.Image = (Image)resources.GetObject("btnImportarExcel.Image");
            btnImportarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportarExcel.Location = new Point(618, 35);
            btnImportarExcel.Margin = new Padding(4, 5, 4, 5);
            btnImportarExcel.Name = "btnImportarExcel";
            btnImportarExcel.Size = new Size(155, 35);
            btnImportarExcel.TabIndex = 9;
            btnImportarExcel.Text = "Importar a Excel";
            btnImportarExcel.TextAlign = ContentAlignment.MiddleRight;
            btnImportarExcel.UseVisualStyleBackColor = false;
            btnImportarExcel.Click += btnImportarExcel_Click;
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            Controls.Add(dgvCatalogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCargaCatalogo";
            Text = "Carga de catalogo";
            Load += frmCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCargaCatalogo;
        private Button btnActualizar;
        private DataGridView dgvCatalogo;
        private OpenFileDialog ofdCatalogo;
        private PictureBox pbCatalogo;
        private GroupBox groupBox1;
        private Label lblTitulo;
        private Button btnImportarExcel;
    }
}