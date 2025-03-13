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
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).BeginInit();
            SuspendLayout();
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCargaCatalogo.BackColor = SystemColors.ActiveCaption;
            btnCargaCatalogo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaCatalogo.Location = new Point(319, 2);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(253, 48);
            btnCargaCatalogo.TabIndex = 1;
            btnCargaCatalogo.Text = "Carga de Catalogo";
            btnCargaCatalogo.UseVisualStyleBackColor = false;
            btnCargaCatalogo.Click += btnCargaCatalogo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(354, 56);
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
            dgvCatalogo.Location = new Point(13, 100);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersWidth = 62;
            dgvCatalogo.Size = new Size(862, 376);
            dgvCatalogo.TabIndex = 4;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID";
            idProducto.MinimumWidth = 8;
            idProducto.Name = "idProducto";
            idProducto.Width = 150;
            // 
            // codProducto
            // 
            codProducto.HeaderText = "Codigo";
            codProducto.MinimumWidth = 8;
            codProducto.Name = "codProducto";
            codProducto.Width = 150;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 8;
            precio.Name = "precio";
            precio.Width = 150;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 8;
            descripcion.Name = "descripcion";
            descripcion.Width = 150;
            // 
            // existencia
            // 
            existencia.HeaderText = "Existencia";
            existencia.MinimumWidth = 8;
            existencia.Name = "existencia";
            existencia.Width = 150;
            // 
            // ofdCatalogo
            // 
            ofdCatalogo.FileName = "ofdCatalogo";
            // 
            // pbCatalogo
            // 
            pbCatalogo.Image = Properties.Resources.catalogo1;
            pbCatalogo.Location = new Point(127, 12);
            pbCatalogo.Name = "pbCatalogo";
            pbCatalogo.Size = new Size(108, 82);
            pbCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCatalogo.TabIndex = 5;
            pbCatalogo.TabStop = false;
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(889, 489);
            Controls.Add(pbCatalogo);
            Controls.Add(dgvCatalogo);
            Controls.Add(btnActualizar);
            Controls.Add(btnCargaCatalogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCargaCatalogo";
            Text = "Carga de catalogo";
            Load += frmCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).EndInit();
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
    }
}