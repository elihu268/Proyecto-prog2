namespace Sistema_Ventas.View
{
    partial class frmMetodoDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetodoDePago));
            sp_efectivo = new Splitter();
            gpbox_efectivo = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btn_cobrarEfectivo = new Button();
            spc_metodoPago = new SplitContainer();
            gpbox_tarjeta = new GroupBox();
            lbl_fecha_cad = new Label();
            lbl_cvc = new Label();
            lbl_no_cuenta = new Label();
            btn_cobrarTarjeta = new Button();
            gpbox_efectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spc_metodoPago).BeginInit();
            spc_metodoPago.Panel1.SuspendLayout();
            spc_metodoPago.Panel2.SuspendLayout();
            spc_metodoPago.SuspendLayout();
            gpbox_tarjeta.SuspendLayout();
            SuspendLayout();
            // 
            // sp_efectivo
            // 
            sp_efectivo.Location = new Point(0, 0);
            sp_efectivo.Name = "sp_efectivo";
            sp_efectivo.Size = new Size(335, 582);
            sp_efectivo.TabIndex = 10;
            sp_efectivo.TabStop = false;
            sp_efectivo.SplitterMoved += splitter1_SplitterMoved;
            // 
            // gpbox_efectivo
            // 
            gpbox_efectivo.Controls.Add(label2);
            gpbox_efectivo.Controls.Add(label1);
            gpbox_efectivo.Controls.Add(btn_cobrarEfectivo);
            gpbox_efectivo.Location = new Point(3, 15);
            gpbox_efectivo.Name = "gpbox_efectivo";
            gpbox_efectivo.Size = new Size(324, 561);
            gpbox_efectivo.TabIndex = 11;
            gpbox_efectivo.TabStop = false;
            gpbox_efectivo.Text = "Efectivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 180);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 69);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btn_cobrarEfectivo
            // 
            btn_cobrarEfectivo.Location = new Point(95, 508);
            btn_cobrarEfectivo.Name = "btn_cobrarEfectivo";
            btn_cobrarEfectivo.Size = new Size(112, 34);
            btn_cobrarEfectivo.TabIndex = 0;
            btn_cobrarEfectivo.Text = "confirmar";
            btn_cobrarEfectivo.UseVisualStyleBackColor = true;
            // 
            // spc_metodoPago
            // 
            spc_metodoPago.Location = new Point(350, 0);
            spc_metodoPago.Name = "spc_metodoPago";
            // 
            // spc_metodoPago.Panel1
            // 
            spc_metodoPago.Panel1.Controls.Add(gpbox_efectivo);
            spc_metodoPago.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // spc_metodoPago.Panel2
            // 
            spc_metodoPago.Panel2.Controls.Add(gpbox_tarjeta);
            spc_metodoPago.Panel2.Paint += splitContainer1_Panel2_Paint;
            spc_metodoPago.Size = new Size(680, 582);
            spc_metodoPago.SplitterDistance = 356;
            spc_metodoPago.TabIndex = 12;
            // 
            // gpbox_tarjeta
            // 
            gpbox_tarjeta.Controls.Add(lbl_fecha_cad);
            gpbox_tarjeta.Controls.Add(lbl_cvc);
            gpbox_tarjeta.Controls.Add(lbl_no_cuenta);
            gpbox_tarjeta.Controls.Add(btn_cobrarTarjeta);
            gpbox_tarjeta.Location = new Point(13, 15);
            gpbox_tarjeta.Name = "gpbox_tarjeta";
            gpbox_tarjeta.Size = new Size(292, 567);
            gpbox_tarjeta.TabIndex = 0;
            gpbox_tarjeta.TabStop = false;
            gpbox_tarjeta.Text = "Tarjeta";
            // 
            // lbl_fecha_cad
            // 
            lbl_fecha_cad.AutoSize = true;
            lbl_fecha_cad.Location = new Point(32, 230);
            lbl_fecha_cad.Name = "lbl_fecha_cad";
            lbl_fecha_cad.Size = new Size(182, 25);
            lbl_fecha_cad.TabIndex = 4;
            lbl_fecha_cad.Text = "Mes de venciomiento";
            // 
            // lbl_cvc
            // 
            lbl_cvc.AutoSize = true;
            lbl_cvc.Location = new Point(18, 159);
            lbl_cvc.Name = "lbl_cvc";
            lbl_cvc.Size = new Size(45, 25);
            lbl_cvc.TabIndex = 3;
            lbl_cvc.Text = "CVC";
            // 
            // lbl_no_cuenta
            // 
            lbl_no_cuenta.AutoSize = true;
            lbl_no_cuenta.Location = new Point(18, 64);
            lbl_no_cuenta.Name = "lbl_no_cuenta";
            lbl_no_cuenta.Size = new Size(156, 25);
            lbl_no_cuenta.TabIndex = 2;
            lbl_no_cuenta.Text = "numero de cuenta";
            // 
            // btn_cobrarTarjeta
            // 
            btn_cobrarTarjeta.Location = new Point(102, 514);
            btn_cobrarTarjeta.Name = "btn_cobrarTarjeta";
            btn_cobrarTarjeta.Size = new Size(112, 34);
            btn_cobrarTarjeta.TabIndex = 1;
            btn_cobrarTarjeta.Text = "confirmar";
            btn_cobrarTarjeta.UseVisualStyleBackColor = true;
            // 
            // frmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 582);
            Controls.Add(spc_metodoPago);
            Controls.Add(sp_efectivo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMetodoDePago";
            Text = "Metodo de pago";
            Load += frmMetodoDePago_Load;
            gpbox_efectivo.ResumeLayout(false);
            gpbox_efectivo.PerformLayout();
            spc_metodoPago.Panel1.ResumeLayout(false);
            spc_metodoPago.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spc_metodoPago).EndInit();
            spc_metodoPago.ResumeLayout(false);
            gpbox_tarjeta.ResumeLayout(false);
            gpbox_tarjeta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter sp_efectivo;
        private GroupBox gpbox_efectivo;
        private SplitContainer spc_metodoPago;
        private GroupBox gpbox_tarjeta;
        private Button btn_cobrarEfectivo;
        private Button btn_cobrarTarjeta;
        private Label label2;
        private Label label1;
        private Label lbl_fecha_cad;
        private Label lbl_cvc;
        private Label lbl_no_cuenta;
    }
}