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
            txt_correo = new TextBox();
            lbl_Correo = new Label();
            spc_metodoPago = new SplitContainer();
            gbox_cliente = new GroupBox();
            gpbox_tarjeta = new GroupBox();
            btn_efectivo = new Button();
            btn_tarjeta = new Button();
            btn_cobrarEfectivo = new Button();
            btn_cobrarTarjeta = new Button();
            btn_regresarVenta = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_no_cuenta = new Label();
            lbl_cvc = new Label();
            lbl_fecha_cad = new Label();
            gpbox_efectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spc_metodoPago).BeginInit();
            spc_metodoPago.Panel1.SuspendLayout();
            spc_metodoPago.Panel2.SuspendLayout();
            spc_metodoPago.SuspendLayout();
            gbox_cliente.SuspendLayout();
            gpbox_tarjeta.SuspendLayout();
            SuspendLayout();
            // 
            // sp_efectivo
            // 
            sp_efectivo.Location = new Point(0, 0);
            sp_efectivo.Name = "sp_efectivo";
            sp_efectivo.Size = new Size(344, 582);
            sp_efectivo.TabIndex = 10;
            sp_efectivo.TabStop = false;
            sp_efectivo.SplitterMoved += splitter1_SplitterMoved;
            // 
            // gpbox_efectivo
            // 
            gpbox_efectivo.Controls.Add(label2);
            gpbox_efectivo.Controls.Add(label1);
            gpbox_efectivo.Controls.Add(btn_cobrarEfectivo);
            gpbox_efectivo.Location = new Point(7, 9);
            gpbox_efectivo.Name = "gpbox_efectivo";
            gpbox_efectivo.Size = new Size(324, 561);
            gpbox_efectivo.TabIndex = 11;
            gpbox_efectivo.TabStop = false;
            gpbox_efectivo.Text = "Efectivo";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(119, 153);
            txt_correo.MaxLength = 50;
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(150, 31);
            txt_correo.TabIndex = 17;
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize = true;
            lbl_Correo.Location = new Point(39, 156);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(75, 25);
            lbl_Correo.TabIndex = 12;
            lbl_Correo.Text = "Correo: ";
            // 
            // spc_metodoPago
            // 
            spc_metodoPago.Location = new Point(350, 0);
            spc_metodoPago.Name = "spc_metodoPago";
            // 
            // spc_metodoPago.Panel1
            // 
            spc_metodoPago.Panel1.Controls.Add(gbox_cliente);
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
            // gbox_cliente
            // 
            gbox_cliente.Controls.Add(btn_regresarVenta);
            gbox_cliente.Controls.Add(btn_tarjeta);
            gbox_cliente.Controls.Add(btn_efectivo);
            gbox_cliente.Controls.Add(txt_correo);
            gbox_cliente.Controls.Add(lbl_Correo);
            gbox_cliente.Location = new Point(13, 9);
            gbox_cliente.Name = "gbox_cliente";
            gbox_cliente.Size = new Size(340, 561);
            gbox_cliente.TabIndex = 0;
            gbox_cliente.TabStop = false;
            gbox_cliente.Text = "Cliente";
            gbox_cliente.Enter += gbox_cliente_Enter;
            // 
            // gpbox_tarjeta
            // 
            gpbox_tarjeta.Controls.Add(lbl_fecha_cad);
            gpbox_tarjeta.Controls.Add(lbl_cvc);
            gpbox_tarjeta.Controls.Add(lbl_no_cuenta);
            gpbox_tarjeta.Controls.Add(btn_cobrarTarjeta);
            gpbox_tarjeta.Location = new Point(13, 3);
            gpbox_tarjeta.Name = "gpbox_tarjeta";
            gpbox_tarjeta.Size = new Size(292, 567);
            gpbox_tarjeta.TabIndex = 0;
            gpbox_tarjeta.TabStop = false;
            gpbox_tarjeta.Text = "Tarjeta";
            // 
            // btn_efectivo
            // 
            btn_efectivo.Location = new Point(24, 216);
            btn_efectivo.Name = "btn_efectivo";
            btn_efectivo.Size = new Size(112, 34);
            btn_efectivo.TabIndex = 20;
            btn_efectivo.Text = "Efectivo";
            btn_efectivo.UseVisualStyleBackColor = true;
            // 
            // btn_tarjeta
            // 
            btn_tarjeta.Location = new Point(183, 216);
            btn_tarjeta.Name = "btn_tarjeta";
            btn_tarjeta.Size = new Size(112, 34);
            btn_tarjeta.TabIndex = 21;
            btn_tarjeta.Text = "Tarjeta";
            btn_tarjeta.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarEfectivo
            // 
            btn_cobrarEfectivo.Location = new Point(95, 508);
            btn_cobrarEfectivo.Name = "btn_cobrarEfectivo";
            btn_cobrarEfectivo.Size = new Size(112, 34);
            btn_cobrarEfectivo.TabIndex = 0;
            btn_cobrarEfectivo.Text = "Cobrar";
            btn_cobrarEfectivo.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarTarjeta
            // 
            btn_cobrarTarjeta.Location = new Point(102, 514);
            btn_cobrarTarjeta.Name = "btn_cobrarTarjeta";
            btn_cobrarTarjeta.Size = new Size(112, 34);
            btn_cobrarTarjeta.TabIndex = 1;
            btn_cobrarTarjeta.Text = "Cobrar";
            btn_cobrarTarjeta.UseVisualStyleBackColor = true;
            // 
            // btn_regresarVenta
            // 
            btn_regresarVenta.Location = new Point(0, 521);
            btn_regresarVenta.Name = "btn_regresarVenta";
            btn_regresarVenta.Size = new Size(112, 34);
            btn_regresarVenta.TabIndex = 22;
            btn_regresarVenta.Text = "Regresar";
            btn_regresarVenta.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 180);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
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
            // lbl_cvc
            // 
            lbl_cvc.AutoSize = true;
            lbl_cvc.Location = new Point(18, 159);
            lbl_cvc.Name = "lbl_cvc";
            lbl_cvc.Size = new Size(45, 25);
            lbl_cvc.TabIndex = 3;
            lbl_cvc.Text = "CVC";
            // 
            // lbl_fecha_cad
            // 
            lbl_fecha_cad.AutoSize = true;
            lbl_fecha_cad.Location = new Point(6, 258);
            lbl_fecha_cad.Name = "lbl_fecha_cad";
            lbl_fecha_cad.Size = new Size(183, 25);
            lbl_fecha_cad.TabIndex = 4;
            lbl_fecha_cad.Text = "Fecha de vencimiento";
            // 
            // frmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 582);
            Controls.Add(spc_metodoPago);
            Controls.Add(gpbox_efectivo);
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
            gbox_cliente.ResumeLayout(false);
            gbox_cliente.PerformLayout();
            gpbox_tarjeta.ResumeLayout(false);
            gpbox_tarjeta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter sp_efectivo;
        private GroupBox gpbox_efectivo;
        private TextBox txt_correo;
        private Label lbl_Correo;
        private SplitContainer spc_metodoPago;
        private GroupBox gbox_cliente;
        private GroupBox gpbox_tarjeta;
        private Button btn_cobrarEfectivo;
        private Button btn_tarjeta;
        private Button btn_efectivo;
        private Button btn_cobrarTarjeta;
        private Button btn_regresarVenta;
        private Label label2;
        private Label label1;
        private Label lbl_fecha_cad;
        private Label lbl_cvc;
        private Label lbl_no_cuenta;
    }
}