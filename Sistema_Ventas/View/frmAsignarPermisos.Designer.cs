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
            btn_actualizar = new Button();
            lbl_indique = new Label();
            btn_seleccionar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = SystemColors.ActiveCaption;
            btn_actualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_actualizar.Location = new Point(719, 301);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(150, 69);
            btn_actualizar.TabIndex = 0;
            btn_actualizar.Text = "Actualizar permisos";
            btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // lbl_indique
            // 
            lbl_indique.AutoSize = true;
            lbl_indique.Location = new Point(21, 13);
            lbl_indique.Name = "lbl_indique";
            lbl_indique.Size = new Size(153, 25);
            lbl_indique.TabIndex = 1;
            lbl_indique.Text = "Ingrese id usuario";
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.BackColor = SystemColors.ActiveCaption;
            btn_seleccionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_seleccionar.Location = new Point(213, 40);
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.Size = new Size(150, 46);
            btn_seleccionar.TabIndex = 2;
            btn_seleccionar.Text = "Seleccionar";
            btn_seleccionar.UseVisualStyleBackColor = false;
            btn_seleccionar.Click += btn_seleccionar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // frmAsignarPermisos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(909, 485);
            Controls.Add(textBox1);
            Controls.Add(btn_seleccionar);
            Controls.Add(lbl_indique);
            Controls.Add(btn_actualizar);
            Name = "frmAsignarPermisos";
            Text = "Permisos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_actualizar;
        private Label lbl_indique;
        private Button btn_seleccionar;
        private TextBox textBox1;
    }
}