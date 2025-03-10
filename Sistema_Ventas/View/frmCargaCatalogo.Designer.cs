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
            lblTitulo = new Label();
            btnCargaCatalogo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            dgvCatalogo = new DataGridView();
            ofdCatalogo = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = SystemColors.ActiveCaption;
            lblTitulo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(776, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carga de Catálogo";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCargaCatalogo.Location = new Point(287, 39);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(228, 34);
            btnCargaCatalogo.TabIndex = 1;
            btnCargaCatalogo.Text = "Carga de Catalogo";
            btnCargaCatalogo.UseVisualStyleBackColor = true;
            btnCargaCatalogo.Click += btnCargaCatalogo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(287, 79);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(396, 79);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 34);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatalogo.BackgroundColor = SystemColors.ActiveCaption;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Location = new Point(12, 119);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.Size = new Size(776, 319);
            dgvCatalogo.TabIndex = 4;
            // 
            // ofdCatalogo
            // 
            ofdCatalogo.FileName = "ofdCatalogo";
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCatalogo);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargaCatalogo);
            Controls.Add(lblTitulo);
            Name = "frmCargaCatalogo";
            Text = "frmCargaCatalogo";
            Load += frmCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnCargaCatalogo;
        private Button btnGuardar;
        private Button btnActualizar;
        private DataGridView dgvCatalogo;
        private OpenFileDialog ofdCatalogo;
    }
}