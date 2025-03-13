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
            sc_asignacion = new SplitContainer();
            grbox_lista_permisos = new GroupBox();
            lbl_rol = new Label();
            txt_rol = new TextBox();
            fgb_permisos = new DataGridView();
            clm_permiso = new DataGridViewTextBoxColumn();
            grbox_permisos = new GroupBox();
            btn_agregar = new Button();
            lbl_selec_permiso = new Label();
            lbl_seleccionar = new Label();
            btn_ver = new Button();
            dgv_rol = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_rol = new DataGridViewTextBoxColumn();
            lbl_buscar = new Label();
            txt_buscar_rol = new TextBox();
            cbox_permisos = new ComboBox();
            lblt_titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)sc_asignacion).BeginInit();
            sc_asignacion.Panel1.SuspendLayout();
            sc_asignacion.Panel2.SuspendLayout();
            sc_asignacion.SuspendLayout();
            grbox_lista_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fgb_permisos).BeginInit();
            grbox_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rol).BeginInit();
            SuspendLayout();
            // 
            // sc_asignacion
            // 
            sc_asignacion.Location = new Point(-2, 59);
            sc_asignacion.Name = "sc_asignacion";
            // 
            // sc_asignacion.Panel1
            // 
            sc_asignacion.Panel1.Controls.Add(grbox_lista_permisos);
            sc_asignacion.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // sc_asignacion.Panel2
            // 
            sc_asignacion.Panel2.Controls.Add(grbox_permisos);
            sc_asignacion.Size = new Size(1079, 483);
            sc_asignacion.SplitterDistance = 357;
            sc_asignacion.TabIndex = 6;
            // 
            // grbox_lista_permisos
            // 
            grbox_lista_permisos.BackColor = SystemColors.InactiveBorder;
            grbox_lista_permisos.Controls.Add(lbl_rol);
            grbox_lista_permisos.Controls.Add(txt_rol);
            grbox_lista_permisos.Controls.Add(fgb_permisos);
            grbox_lista_permisos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox_lista_permisos.Location = new Point(3, 3);
            grbox_lista_permisos.Name = "grbox_lista_permisos";
            grbox_lista_permisos.Size = new Size(335, 481);
            grbox_lista_permisos.TabIndex = 1;
            grbox_lista_permisos.TabStop = false;
            grbox_lista_permisos.Text = "Permisos asignados";
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Location = new Point(18, 65);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(39, 25);
            lbl_rol.TabIndex = 20;
            lbl_rol.Text = "Rol";
            // 
            // txt_rol
            // 
            txt_rol.Enabled = false;
            txt_rol.Location = new Point(76, 65);
            txt_rol.MaxLength = 30;
            txt_rol.Name = "txt_rol";
            txt_rol.Size = new Size(181, 31);
            txt_rol.TabIndex = 19;
            // 
            // fgb_permisos
            // 
            fgb_permisos.BackgroundColor = SystemColors.GradientInactiveCaption;
            fgb_permisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fgb_permisos.Columns.AddRange(new DataGridViewColumn[] { clm_permiso });
            fgb_permisos.Enabled = false;
            fgb_permisos.GridColor = SystemColors.InactiveBorder;
            fgb_permisos.Location = new Point(53, 121);
            fgb_permisos.Name = "fgb_permisos";
            fgb_permisos.RowHeadersWidth = 62;
            fgb_permisos.Size = new Size(215, 301);
            fgb_permisos.TabIndex = 18;
            fgb_permisos.CellContentClick += dataGridView2_CellContentClick;
            // 
            // clm_permiso
            // 
            clm_permiso.HeaderText = "permiso";
            clm_permiso.MinimumWidth = 8;
            clm_permiso.Name = "clm_permiso";
            clm_permiso.Width = 150;
            // 
            // grbox_permisos
            // 
            grbox_permisos.BackColor = SystemColors.InactiveBorder;
            grbox_permisos.Controls.Add(btn_agregar);
            grbox_permisos.Controls.Add(lbl_selec_permiso);
            grbox_permisos.Controls.Add(lbl_seleccionar);
            grbox_permisos.Controls.Add(btn_ver);
            grbox_permisos.Controls.Add(dgv_rol);
            grbox_permisos.Controls.Add(lbl_buscar);
            grbox_permisos.Controls.Add(txt_buscar_rol);
            grbox_permisos.Controls.Add(cbox_permisos);
            grbox_permisos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbox_permisos.Location = new Point(20, 3);
            grbox_permisos.Name = "grbox_permisos";
            grbox_permisos.Size = new Size(692, 484);
            grbox_permisos.TabIndex = 11;
            grbox_permisos.TabStop = false;
            grbox_permisos.Text = "Permisos";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(406, 416);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(198, 51);
            btn_agregar.TabIndex = 20;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += button1_Click;
            // 
            // lbl_selec_permiso
            // 
            lbl_selec_permiso.AutoSize = true;
            lbl_selec_permiso.Location = new Point(372, 27);
            lbl_selec_permiso.Name = "lbl_selec_permiso";
            lbl_selec_permiso.Size = new Size(179, 25);
            lbl_selec_permiso.TabIndex = 19;
            lbl_selec_permiso.Text = "Seleccionar permiso";
            // 
            // lbl_seleccionar
            // 
            lbl_seleccionar.AutoSize = true;
            lbl_seleccionar.Location = new Point(72, 103);
            lbl_seleccionar.Name = "lbl_seleccionar";
            lbl_seleccionar.Size = new Size(216, 25);
            lbl_seleccionar.TabIndex = 18;
            lbl_seleccionar.Text = "Click para seleccionar rol";
            // 
            // btn_ver
            // 
            btn_ver.BackColor = SystemColors.ActiveCaption;
            btn_ver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ver.Location = new Point(45, 416);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(198, 61);
            btn_ver.TabIndex = 15;
            btn_ver.Text = "Ver permisos asignados";
            btn_ver.UseVisualStyleBackColor = false;
            btn_ver.Click += btn_ver_Click;
            // 
            // dgv_rol
            // 
            dgv_rol.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv_rol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rol.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_rol });
            dgv_rol.Location = new Point(19, 131);
            dgv_rol.Name = "dgv_rol";
            dgv_rol.RowHeadersWidth = 62;
            dgv_rol.Size = new Size(269, 266);
            dgv_rol.TabIndex = 14;
            // 
            // clm_id
            // 
            clm_id.HeaderText = "Id";
            clm_id.MinimumWidth = 8;
            clm_id.Name = "clm_id";
            clm_id.Width = 150;
            // 
            // clm_rol
            // 
            clm_rol.HeaderText = "Rol";
            clm_rol.MinimumWidth = 8;
            clm_rol.Name = "clm_rol";
            clm_rol.Width = 150;
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(6, 27);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(94, 25);
            lbl_buscar.TabIndex = 17;
            lbl_buscar.Text = "Buscar rol";
            // 
            // txt_buscar_rol
            // 
            txt_buscar_rol.Location = new Point(19, 55);
            txt_buscar_rol.MaxLength = 50;
            txt_buscar_rol.Name = "txt_buscar_rol";
            txt_buscar_rol.Size = new Size(269, 31);
            txt_buscar_rol.TabIndex = 16;
            // 
            // cbox_permisos
            // 
            cbox_permisos.AutoCompleteCustomSource.AddRange(new string[] { "Cobrar" });
            cbox_permisos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox_permisos.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            cbox_permisos.FormattingEnabled = true;
            cbox_permisos.Location = new Point(372, 65);
            cbox_permisos.Name = "cbox_permisos";
            cbox_permisos.Size = new Size(270, 33);
            cbox_permisos.TabIndex = 2;
            cbox_permisos.SelectedIndexChanged += cbox_permisos_SelectedIndexChanged;
            // 
            // lblt_titulo
            // 
            lblt_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblt_titulo.BackColor = Color.SteelBlue;
            lblt_titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblt_titulo.Location = new Point(1, 9);
            lblt_titulo.Name = "lblt_titulo";
            lblt_titulo.Size = new Size(1076, 50);
            lblt_titulo.TabIndex = 7;
            lblt_titulo.Text = "Asignacion de permisos";
            lblt_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1083, 554);
            Controls.Add(lblt_titulo);
            Controls.Add(sc_asignacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAsignarPermisos";
            Text = "Permisos";
            sc_asignacion.Panel1.ResumeLayout(false);
            sc_asignacion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_asignacion).EndInit();
            sc_asignacion.ResumeLayout(false);
            grbox_lista_permisos.ResumeLayout(false);
            grbox_lista_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fgb_permisos).EndInit();
            grbox_permisos.ResumeLayout(false);
            grbox_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer sc_asignacion;
        private GroupBox grbox_lista_permisos;
        private GroupBox grbox_permisos;
        private Button btn_ver;
        private DataGridView dgv_rol;
        private ComboBox cbox_permisos;
        private TextBox txt_buscar_rol;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_rol;
        private Label lbl_buscar;
        private DataGridView fgb_permisos;
        private DataGridViewTextBoxColumn clm_permiso;
        private Label lblt_titulo;
        private Label lbl_selec_permiso;
        private Label lbl_seleccionar;
        private Label lbl_rol;
        private TextBox txt_rol;
        private Button btn_agregar;
    }
}