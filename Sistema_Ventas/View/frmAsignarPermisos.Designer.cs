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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_editar = new Button();
            dataGridView1 = new DataGridView();
            clm_usuario = new DataGridViewTextBoxColumn();
            clm_rol = new DataGridViewTextBoxColumn();
            clm_estatus = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-2, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(899, 472);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(5, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 458);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_editar);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(15, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(578, 454);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn_editar
            // 
            btn_editar.BackColor = SystemColors.ActiveCaption;
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(63, 62);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(150, 46);
            btn_editar.TabIndex = 15;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clm_usuario, clm_rol, clm_estatus });
            dataGridView1.Location = new Point(30, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(516, 225);
            dataGridView1.TabIndex = 14;
            // 
            // clm_usuario
            // 
            clm_usuario.HeaderText = "Usuario";
            clm_usuario.MinimumWidth = 8;
            clm_usuario.Name = "clm_usuario";
            clm_usuario.Width = 150;
            // 
            // clm_rol
            // 
            clm_rol.HeaderText = "Rol";
            clm_rol.MinimumWidth = 8;
            clm_rol.Name = "clm_rol";
            clm_rol.Width = 150;
            // 
            // clm_estatus
            // 
            clm_estatus.HeaderText = "Estatus";
            clm_estatus.MinimumWidth = 8;
            clm_estatus.Name = "clm_estatus";
            clm_estatus.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 360);
            button1.Name = "button1";
            button1.Size = new Size(153, 59);
            button1.TabIndex = 1;
            button1.Text = "Actualizar permisos";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(909, 485);
            Controls.Add(splitContainer1);
            Name = "frmAsignarPermisos";
            Text = "Permisos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button btn_editar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clm_usuario;
        private DataGridViewTextBoxColumn clm_rol;
        private DataGridViewTextBoxColumn clm_estatus;
    }
}