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
            btn_inciar = new Button();
            btn_cerrar = new Button();
            txt_password = new TextBox();
            txt_usuario = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(320, 111);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(72, 25);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(292, 165);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(101, 25);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // btn_inciar
            // 
            btn_inciar.BackColor = SystemColors.ActiveCaption;
            btn_inciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inciar.Image = (Image)resources.GetObject("btn_inciar.Image");
            btn_inciar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inciar.Location = new Point(136, 295);
            btn_inciar.Name = "btn_inciar";
            btn_inciar.Size = new Size(181, 59);
            btn_inciar.TabIndex = 2;
            btn_inciar.Text = "Iniciar sesion";
            btn_inciar.UseVisualStyleBackColor = false;
            btn_inciar.Click += btn_inciar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = SystemColors.ActiveCaption;
            btn_cerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrar.Location = new Point(489, 295);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(193, 59);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(410, 159);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(262, 31);
            txt_password.TabIndex = 4;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(410, 108);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(262, 31);
            txt_usuario.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txt_usuario);
            Controls.Add(txt_password);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_inciar);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label lbl_password;
        private Button btn_inciar;
        private Button btn_cerrar;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private PictureBox pictureBox1;
    }
}