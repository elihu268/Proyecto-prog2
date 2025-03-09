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
            lblTitulo = new Label();
            btnCargaCatalogo = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = SystemColors.ButtonFace;
            lblTitulo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(776, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carga de Catalogo";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCargaCatalogo
            // 
            btnCargaCatalogo.Location = new Point(356, 51);
            btnCargaCatalogo.Name = "btnCargaCatalogo";
            btnCargaCatalogo.Size = new Size(192, 34);
            btnCargaCatalogo.TabIndex = 1;
            btnCargaCatalogo.Text = "Carga de Catalogo";
            btnCargaCatalogo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(356, 109);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(450, 109);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 34);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmCargaCatalogo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargaCatalogo);
            Controls.Add(lblTitulo);
            Name = "frmCargaCatalogo";
            Text = "frmCargaCatalogo";
            Load += frmCatalogo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnCargaCatalogo;
        private Button btnGuardar;
        private Button btnActualizar;
    }
}