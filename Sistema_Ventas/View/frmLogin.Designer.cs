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
            lbl_usuario.Location = new Point(305, 87);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(68, 23);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(279, 123);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(97, 23);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(101, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(395, 87);
            txt_usuario.MaxLength = 50;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(173, 30);
            txt_usuario.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(395, 128);
            txt_password.MaxLength = 20;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(173, 30);
            txt_password.TabIndex = 4;
            // 
            // btn_iniciar
            // 
            btn_iniciar.BackColor = SystemColors.ActiveCaption;
            btn_iniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_iniciar.Image = Properties.Resources.login;
            btn_iniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_iniciar.Location = new Point(134, 227);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(197, 45);
            btn_iniciar.TabIndex = 5;
            btn_iniciar.Text = "Iniciar sesion";
            btn_iniciar.UseVisualStyleBackColor = false;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = SystemColors.ActiveCaption;
            btn_cerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.Image = Properties.Resources.salir;
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(395, 227);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(176, 45);
            btn_cerrar.TabIndex = 6;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(720, 414);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_iniciar);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "inicio de sesion";
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