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
            sp_efectivo = new Splitter();
            gpbox_efectivo = new GroupBox();
            dtp_nacimiento = new DateTimePicker();
            txt_telefono = new TextBox();
            txt_correo = new TextBox();
            txt_RFC = new TextBox();
            txt_nombre = new TextBox();
            lbl_fechaNacimiento = new Label();
            lbl_telefono = new Label();
            lbl_Correo = new Label();
            lbl_RFC = new Label();
            lbl_nombre = new Label();
            spc_metodoPago = new SplitContainer();
            gbox_cliente = new GroupBox();
            gpbox_tarjeta = new GroupBox();
            btn_efectivo = new Button();
            btn_tarjeta = new Button();
            btn_cobrarEfectivo = new Button();
            btn_cobrarTarjeta = new Button();
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
            gpbox_efectivo.Controls.Add(btn_cobrarEfectivo);
            gpbox_efectivo.Location = new Point(7, 9);
            gpbox_efectivo.Name = "gpbox_efectivo";
            gpbox_efectivo.Size = new Size(324, 561);
            gpbox_efectivo.TabIndex = 11;
            gpbox_efectivo.TabStop = false;
            gpbox_efectivo.Text = "Efectivo";
            // 
            // dtp_nacimiento
            // 
            dtp_nacimiento.Format = DateTimePickerFormat.Short;
            dtp_nacimiento.Location = new Point(27, 295);
            dtp_nacimiento.Name = "dtp_nacimiento";
            dtp_nacimiento.Size = new Size(225, 31);
            dtp_nacimiento.TabIndex = 19;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(119, 199);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(150, 31);
            txt_telefono.TabIndex = 18;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(119, 153);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(150, 31);
            txt_correo.TabIndex = 17;
            // 
            // txt_RFC
            // 
            txt_RFC.Location = new Point(120, 116);
            txt_RFC.Name = "txt_RFC";
            txt_RFC.Size = new Size(150, 31);
            txt_RFC.TabIndex = 16;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(120, 74);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(150, 31);
            txt_nombre.TabIndex = 15;
            // 
            // lbl_fechaNacimiento
            // 
            lbl_fechaNacimiento.AutoSize = true;
            lbl_fechaNacimiento.Location = new Point(26, 252);
            lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            lbl_fechaNacimiento.Size = new Size(174, 25);
            lbl_fechaNacimiento.TabIndex = 14;
            lbl_fechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(26, 197);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(88, 25);
            lbl_telefono.TabIndex = 13;
            lbl_telefono.Text = "Telefono: ";
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
            // lbl_RFC
            // 
            lbl_RFC.AutoSize = true;
            lbl_RFC.Location = new Point(62, 118);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new Size(52, 25);
            lbl_RFC.TabIndex = 11;
            lbl_RFC.Text = "RFC: ";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(27, 74);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(87, 25);
            lbl_nombre.TabIndex = 10;
            lbl_nombre.Text = "Nombre: ";
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
            gbox_cliente.Controls.Add(btn_tarjeta);
            gbox_cliente.Controls.Add(btn_efectivo);
            gbox_cliente.Controls.Add(dtp_nacimiento);
            gbox_cliente.Controls.Add(lbl_RFC);
            gbox_cliente.Controls.Add(txt_telefono);
            gbox_cliente.Controls.Add(lbl_nombre);
            gbox_cliente.Controls.Add(txt_correo);
            gbox_cliente.Controls.Add(lbl_Correo);
            gbox_cliente.Controls.Add(txt_RFC);
            gbox_cliente.Controls.Add(lbl_telefono);
            gbox_cliente.Controls.Add(txt_nombre);
            gbox_cliente.Controls.Add(lbl_fechaNacimiento);
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
            btn_efectivo.Location = new Point(36, 503);
            btn_efectivo.Name = "btn_efectivo";
            btn_efectivo.Size = new Size(112, 34);
            btn_efectivo.TabIndex = 20;
            btn_efectivo.Text = "Efectivo";
            btn_efectivo.UseVisualStyleBackColor = true;
            // 
            // btn_tarjeta
            // 
            btn_tarjeta.Location = new Point(199, 503);
            btn_tarjeta.Name = "btn_tarjeta";
            btn_tarjeta.Size = new Size(112, 34);
            btn_tarjeta.TabIndex = 21;
            btn_tarjeta.Text = "Tarjeta";
            btn_tarjeta.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarEfectivo
            // 
            btn_cobrarEfectivo.Location = new Point(84, 503);
            btn_cobrarEfectivo.Name = "btn_cobrarEfectivo";
            btn_cobrarEfectivo.Size = new Size(112, 34);
            btn_cobrarEfectivo.TabIndex = 0;
            btn_cobrarEfectivo.Text = "Cobrar";
            btn_cobrarEfectivo.UseVisualStyleBackColor = true;
            // 
            // btn_cobrarTarjeta
            // 
            btn_cobrarTarjeta.Location = new Point(95, 509);
            btn_cobrarTarjeta.Name = "btn_cobrarTarjeta";
            btn_cobrarTarjeta.Size = new Size(112, 34);
            btn_cobrarTarjeta.TabIndex = 1;
            btn_cobrarTarjeta.Text = "Cobrar";
            btn_cobrarTarjeta.UseVisualStyleBackColor = true;
            // 
            // frmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 582);
            Controls.Add(spc_metodoPago);
            Controls.Add(gpbox_efectivo);
            Controls.Add(sp_efectivo);
            Name = "frmMetodoDePago";
            Text = "frmMetodoDePago";
            Load += frmMetodoDePago_Load;
            gpbox_efectivo.ResumeLayout(false);
            spc_metodoPago.Panel1.ResumeLayout(false);
            spc_metodoPago.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spc_metodoPago).EndInit();
            spc_metodoPago.ResumeLayout(false);
            gbox_cliente.ResumeLayout(false);
            gbox_cliente.PerformLayout();
            gpbox_tarjeta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Splitter sp_efectivo;
        private GroupBox gpbox_efectivo;
        private DateTimePicker dtp_nacimiento;
        private TextBox txt_telefono;
        private TextBox txt_correo;
        private TextBox txt_RFC;
        private TextBox txt_nombre;
        private Label lbl_fechaNacimiento;
        private Label lbl_telefono;
        private Label lbl_Correo;
        private Label lbl_RFC;
        private Label lbl_nombre;
        private SplitContainer spc_metodoPago;
        private GroupBox gbox_cliente;
        private GroupBox gpbox_tarjeta;
        private Button btn_cobrarEfectivo;
        private Button btn_tarjeta;
        private Button btn_efectivo;
        private Button btn_cobrarTarjeta;
    }
}