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
            lbl_usuario = new Label();
            lbl_password = new Label();
            pictureBox1 = new PictureBox();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            btn_iniciar = new Button();
            btn_cerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(270, 49);
            lbl_usuario.Margin = new Padding(2, 0, 2, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(55, 16);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(248, 116);
            lbl_password.Margin = new Padding(2, 0, 2, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(82, 16);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(82, 39);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(350, 45);
            txt_usuario.Margin = new Padding(2, 3, 2, 3);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(155, 23);
            txt_usuario.TabIndex = 3;
            txt_usuario.Text = "a@a.a";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(350, 106);
            txt_password.Margin = new Padding(2, 3, 2, 3);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(155, 23);
            txt_password.TabIndex = 4;
            txt_password.Text = "a";
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = SystemColors.ActiveCaption;
            btn_iniciar.Cursor = Cursors.Hand;
            btn_iniciar.FlatAppearance.BorderSize = 0;
            btn_iniciar.FlatStyle = FlatStyle.Flat;
            btn_iniciar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_iniciar.Image = Properties.Resources.login;
            btn_iniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_iniciar.Location = new Point(82, 182);
            btn_iniciar.Margin = new Padding(2, 3, 2, 3);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(155, 42);
            btn_iniciar.TabIndex = 5;
            btn_iniciar.Text = "Iniciar Sesión";
            btn_iniciar.TextAlign = ContentAlignment.MiddleRight;
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = SystemColors.ActiveCaption;
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.Image = Properties.Resources.salir;
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(430, 182);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(96, 42);
            btn_cerrar.TabIndex = 6;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(583, 269);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_iniciar);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label lbl_password;
        private PictureBox pictureBox1;
        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button btn_iniciar;
        private Button btn_cerrar;
    }
}