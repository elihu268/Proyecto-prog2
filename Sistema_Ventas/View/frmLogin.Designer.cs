namespace Sistema_Ventas.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btn_inicio = new Button();
            lbl_usuario = new Label();
            lbl_password = new Label();
            btn_cerrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = SystemColors.ActiveCaption;
            btn_inicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio.Image = (Image)resources.GetObject("btn_inicio.Image");
            btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inicio.Location = new Point(160, 316);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(177, 34);
            btn_inicio.TabIndex = 0;
            btn_inicio.Text = "iniciar sesion";
            btn_inicio.UseVisualStyleBackColor = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(292, 121);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(70, 25);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(264, 192);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(98, 25);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "contraseña";
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = SystemColors.ActiveCaption;
            btn_cerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(458, 316);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(177, 34);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(388, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(388, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 31);
            textBox2.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_cerrar);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_inicio);
            Name = "frmLogin";
            Text = "Login";
            Load += this.frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_inicio;
        private Label lbl_usuario;
        private Label lbl_password;
        private Button btn_cerrar;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}