namespace Sistema_Ventas.View
{
    partial class frmEfectivo
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
            btn_cobrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbl_total = new Label();
            lbl_efectivo = new Label();
            lbl_cambio = new Label();
            SuspendLayout();
            // 
            // btn_cobrar
            // 
            btn_cobrar.Location = new Point(155, 198);
            btn_cobrar.Name = "btn_cobrar";
            btn_cobrar.Size = new Size(112, 34);
            btn_cobrar.TabIndex = 3;
            btn_cobrar.Text = "Cobrar";
            btn_cobrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(91, 27);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 7;
            lbl_total.Text = "Total";
            // 
            // lbl_efectivo
            // 
            lbl_efectivo.AutoSize = true;
            lbl_efectivo.Location = new Point(66, 77);
            lbl_efectivo.Name = "lbl_efectivo";
            lbl_efectivo.Size = new Size(74, 25);
            lbl_efectivo.TabIndex = 8;
            lbl_efectivo.Text = "Efectivo";
            // 
            // lbl_cambio
            // 
            lbl_cambio.AutoSize = true;
            lbl_cambio.Location = new Point(66, 132);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(74, 25);
            lbl_cambio.TabIndex = 9;
            lbl_cambio.Text = "Cambio";
            // 
            // frmEfectivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 276);
            Controls.Add(lbl_cambio);
            Controls.Add(lbl_efectivo);
            Controls.Add(lbl_total);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_cobrar);
            Name = "frmEfectivo";
            Text = "frmEfectivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cobrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_total;
        private Label lbl_efectivo;
        private Label lbl_cambio;
    }
}