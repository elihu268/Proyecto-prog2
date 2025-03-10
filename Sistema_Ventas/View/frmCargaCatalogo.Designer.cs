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
            btnCargaCatalogo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            dgvCatalogo = new DataGridView();
            ofdCatalogo = new OpenFileDialog();
            pbCatalogo = new PictureBox();
            idProducto = new DataGridViewTextBoxColumn();
            codProducto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            existencia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).BeginInit();
            SuspendLayout();
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCargaCatalogo.BackColor = SystemColors.ActiveCaption;
            btnCargaCatalogo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaCatalogo.Location = new Point(287, 12);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(228, 34);
            btnCargaCatalogo.TabIndex = 1;
            btnCargaCatalogo.Text = "Carga de Catalogo";
            btnCargaCatalogo.UseVisualStyleBackColor = false;
            btnCargaCatalogo.Click += btnCargaCatalogo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(287, 52);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = Properties.Resources.actualizar;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(396, 52);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 34);
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
            dgvCatalogo.Location = new Point(12, 92);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.Size = new Size(776, 346);
            dgvCatalogo.TabIndex = 4;
            // 
            // ofdCatalogo
            // 
            ofdCatalogo.FileName = "ofdCatalogo";
            // 
            // pbCatalogo
            // 
            pbCatalogo.Image = Properties.Resources.catalogo1;
            pbCatalogo.Location = new Point(184, -11);
            pbCatalogo.Name = "pbCatalogo";
            pbCatalogo.Size = new Size(97, 97);
            pbCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCatalogo.TabIndex = 5;
            pbCatalogo.TabStop = false;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "ID";
            idProducto.Name = "idProducto";
            // 
            // codProducto
            // 
            codProducto.HeaderText = "Codigo";
            codProducto.Name = "codProducto";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // existencia
            // 
            existencia.HeaderText = "Existencia";
            existencia.Name = "existencia";
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pbCatalogo);
            Controls.Add(dgvCatalogo);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargaCatalogo);
            Name = "frmCargaCatalogo";
            Text = "frmCargaCatalogo";
            Load += frmCatalogo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCatalogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCargaCatalogo;
        private Button btnGuardar;
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