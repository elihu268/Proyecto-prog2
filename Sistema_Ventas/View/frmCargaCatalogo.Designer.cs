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
            idProducto = new DataGridViewTextBoxColumn();
            codProducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            existencia = new DataGridViewTextBoxColumn();
            ofdCatalogo = new OpenFileDialog();
            pbCatalogo = new PictureBox();
            lbl_titulo = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.BackColor = SystemColors.ActiveCaption;
            btnCargaCatalogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaCatalogo.Location = new Point(275, 30);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(292, 48);
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
            btnActualizar.Location = new Point(322, 92);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(174, 37);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatalogo.BackgroundColor = SystemColors.ActiveCaption;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatalogo.Columns.AddRange(new DataGridViewColumn[] { idProducto, codProducto, nombre, precio, descripcion, existencia });
            dgvCatalogo.Enabled = false;
            dgvCatalogo.Location = new Point(1, 213);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(874, 263);
            dgvCatalogo.TabIndex = 4;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID";
            idProducto.MinimumWidth = 8;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Width = 150;
            // 
            // codProducto
            // 
            codProducto.HeaderText = "Codigo";
            codProducto.MinimumWidth = 8;
            codProducto.Name = "codProducto";
            codProducto.ReadOnly = true;
            codProducto.Width = 150;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 8;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 150;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 8;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 150;
            // 
            // existencia
            // 
            existencia.HeaderText = "Existencia";
            existencia.MinimumWidth = 8;
            existencia.Name = "existencia";
            existencia.ReadOnly = true;
            existencia.Width = 150;
            // 
            // ofdCatalogo
            // 
            ofdCatalogo.FileName = "ofdCatalogo";
            // 
            // pbCatalogo
            // 
            pbCatalogo.Image = Properties.Resources.catalogo1;
            pbCatalogo.Location = new Point(27, 30);
            pbCatalogo.Name = "pbCatalogo";
            pbCatalogo.Size = new Size(108, 82);
            pbCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCatalogo.TabIndex = 5;
            pbCatalogo.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titulo.BackColor = Color.SteelBlue;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(856, 51);
            lbl_titulo.TabIndex = 6;
            lbl_titulo.Text = "Resumen de ventas";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnCargaCatalogo);
            groupBox1.Controls.Add(pbCatalogo);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 135);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Herramientas";
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(889, 489);
            Controls.Add(groupBox1);
            Controls.Add(lbl_titulo);
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
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn codProducto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn existencia;
        private Label lbl_titulo;
        private GroupBox groupBox1;
    }
}