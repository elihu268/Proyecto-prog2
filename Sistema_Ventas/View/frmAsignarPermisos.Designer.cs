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
            splitContainer1 = new SplitContainer();
            grbox_Rol = new GroupBox();
            lbl_buscar = new Label();
            dataGridView1 = new DataGridView();
            clm_id = new DataGridViewTextBoxColumn();
            clm_rol = new DataGridViewTextBoxColumn();
            txt_buscar_rol = new TextBox();
            btn_editar = new Button();
            grbox_permisos = new GroupBox();
            dataGridView2 = new DataGridView();
            clm_permiso = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            button1 = new Button();
            cbox_permisos = new ComboBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grbox_Rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbox_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-2, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grbox_Rol);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grbox_permisos);
            splitContainer1.Size = new Size(1073, 541);
            splitContainer1.SplitterDistance = 356;
            splitContainer1.TabIndex = 6;
            // 
            // grbox_Rol
            // 
            grbox_Rol.Controls.Add(lbl_buscar);
            grbox_Rol.Controls.Add(dataGridView1);
            grbox_Rol.Controls.Add(txt_buscar_rol);
            grbox_Rol.Controls.Add(btn_editar);
            grbox_Rol.Location = new Point(5, 11);
            grbox_Rol.Name = "grbox_Rol";
            grbox_Rol.Size = new Size(348, 527);
            grbox_Rol.TabIndex = 1;
            grbox_Rol.TabStop = false;
            grbox_Rol.Text = "Rol";
            // 
            // lbl_buscar
            // 
            lbl_buscar.AutoSize = true;
            lbl_buscar.Location = new Point(22, 40);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(63, 25);
            lbl_buscar.TabIndex = 17;
            lbl_buscar.Text = "Buscar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_rol });
            dataGridView1.Location = new Point(22, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(279, 225);
            dataGridView1.TabIndex = 14;
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
            // txt_buscar_rol
            // 
            txt_buscar_rol.Location = new Point(22, 87);
            txt_buscar_rol.Name = "txt_buscar_rol";
            txt_buscar_rol.Size = new Size(236, 31);
            txt_buscar_rol.TabIndex = 16;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = SystemColors.ActiveCaption;
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(135, 412);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(150, 46);
            btn_editar.TabIndex = 15;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // grbox_permisos
            // 
            grbox_permisos.Controls.Add(checkBox1);
            grbox_permisos.Controls.Add(dataGridView2);
            grbox_permisos.Controls.Add(btn_eliminar);
            grbox_permisos.Controls.Add(button1);
            grbox_permisos.Controls.Add(cbox_permisos);
            grbox_permisos.Location = new Point(15, 15);
            grbox_permisos.Name = "grbox_permisos";
            grbox_permisos.Size = new Size(682, 526);
            grbox_permisos.TabIndex = 11;
            grbox_permisos.TabStop = false;
            grbox_permisos.Text = "Permisos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clm_permiso });
            dataGridView2.Location = new Point(38, 103);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(496, 251);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // clm_permiso
            // 
            clm_permiso.HeaderText = "permiso";
            clm_permiso.MinimumWidth = 8;
            clm_permiso.Name = "clm_permiso";
            clm_permiso.Width = 150;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = SystemColors.ActiveCaption;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(281, 361);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 59);
            btn_eliminar.TabIndex = 4;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(397, 19);
            button1.Name = "button1";
            button1.Size = new Size(153, 59);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // cbox_permisos
            // 
            cbox_permisos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox_permisos.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            cbox_permisos.FormattingEnabled = true;
            cbox_permisos.Location = new Point(137, 33);
            cbox_permisos.Name = "cbox_permisos";
            cbox_permisos.Size = new Size(236, 33);
            cbox_permisos.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 418);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1083, 554);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAsignarPermisos";
            Text = "Permisos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grbox_Rol.ResumeLayout(false);
            grbox_Rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbox_permisos.ResumeLayout(false);
            grbox_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox grbox_Rol;
        private Button button1;
        private GroupBox grbox_permisos;
        private Button btn_editar;
        private DataGridView dataGridView1;
        private Button btn_eliminar;
        private ComboBox cbox_permisos;
        private TextBox txt_buscar_rol;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_rol;
        private Label lbl_buscar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn clm_permiso;
        private CheckBox checkBox1;
    }
}