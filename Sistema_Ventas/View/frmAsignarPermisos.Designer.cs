namespace Sistema_Ventas.View
{
    partial class frmAsignarPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarPermisos));
            grbox_permisos = new GroupBox();
            cbox_rol = new ComboBox();
            dgv_permisos = new DataGridView();
            btn_agregar = new Button();
            lbl_selec_permiso = new Label();
            lbl_buscar = new Label();
            lblt_titulo = new Label();
            grbox_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_permisos).BeginInit();
            SuspendLayout();
            // 
            // grbox_permisos
            // 
            grbox_permisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbox_permisos.BackColor = SystemColors.InactiveBorder;
            grbox_permisos.Controls.Add(cbox_rol);
            grbox_permisos.Controls.Add(dgv_permisos);
            grbox_permisos.Controls.Add(btn_agregar);
            grbox_permisos.Controls.Add(lbl_selec_permiso);
            grbox_permisos.Controls.Add(lbl_buscar);
            grbox_permisos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox_permisos.Location = new Point(12, 79);
            grbox_permisos.Name = "grbox_permisos";
            grbox_permisos.Size = new Size(634, 566);
            grbox_permisos.TabIndex = 11;
            grbox_permisos.TabStop = false;
            grbox_permisos.Text = "Permisos";
            // 
            // cbox_rol
            // 
            cbox_rol.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbox_rol.FormattingEnabled = true;
            cbox_rol.Location = new Point(23, 76);
            cbox_rol.Name = "cbox_rol";
            cbox_rol.Size = new Size(281, 33);
            cbox_rol.TabIndex = 22;
            cbox_rol.SelectedIndexChanged += cbox_rol_SelectedIndexChanged;
            // 
            // dgv_permisos
            // 
            dgv_permisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_permisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_permisos.Location = new Point(23, 161);
            dgv_permisos.MaximumSize = new Size(700, 900);
            dgv_permisos.Name = "dgv_permisos";
            dgv_permisos.RowHeadersWidth = 62;
            dgv_permisos.Size = new Size(600, 377);
            dgv_permisos.TabIndex = 21;
            dgv_permisos.CellContentClick += dgv_permisos_CellContentClick;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(357, 30);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(198, 51);
            btn_agregar.TabIndex = 20;
            btn_agregar.Text = "Asignar permisos";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += button1_Click;
            // 
            // lbl_selec_permiso
            // 
            lbl_selec_permiso.AutoSize = true;
            lbl_selec_permiso.Location = new Point(433, 115);
            lbl_selec_permiso.Name = "lbl_selec_permiso";
            lbl_selec_permiso.Size = new Size(179, 25);
            lbl_selec_permiso.TabIndex = 19;
            lbl_selec_permiso.Text = "Seleccionar permiso";
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(6, 30);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(94, 25);
            lbl_buscar.TabIndex = 17;
            lbl_buscar.Text = "Buscar rol";
            // 
            // lblt_titulo
            // 
            lblt_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblt_titulo.BackColor = Color.SteelBlue;
            lblt_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblt_titulo.Location = new Point(1, 9);
            lblt_titulo.Name = "lblt_titulo";
            lblt_titulo.Size = new Size(659, 50);
            lblt_titulo.TabIndex = 7;
            lblt_titulo.Text = "Asignacion de permisos";
            lblt_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(666, 657);
            Controls.Add(grbox_permisos);
            Controls.Add(lblt_titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 800);
            Name = "frmAsignarPermisos";
            Text = "Permisos";
            Load += frmAsignarPermisos_Load;
            grbox_permisos.ResumeLayout(false);
            grbox_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_permisos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbox_permisos;
        private Label lbl_buscar;
        private Label lblt_titulo;
        private Label lbl_selec_permiso;
        private Button btn_agregar;
        private DataGridView dgv_permisos;
        private ComboBox cbox_rol;
    }
}