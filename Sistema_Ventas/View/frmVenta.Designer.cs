namespace Sistema_Ventas.View
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            sc_venta = new SplitContainer();
            gbx_venta = new GroupBox();
            gbx_metodo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)sc_venta).BeginInit();
            sc_venta.Panel1.SuspendLayout();
            sc_venta.Panel2.SuspendLayout();
            sc_venta.SuspendLayout();
            SuspendLayout();
            // 
            // sc_venta
            // 
            sc_venta.Dock = DockStyle.Fill;
            sc_venta.Location = new Point(0, 0);
            sc_venta.Name = "sc_venta";
            // 
            // sc_venta.Panel1
            // 
            sc_venta.Panel1.Controls.Add(gbx_venta);
            // 
            // sc_venta.Panel2
            // 
            sc_venta.Panel2.Controls.Add(gbx_metodo);
            sc_venta.Panel2.Paint += splitContainer1_Panel2_Paint;
            sc_venta.Size = new Size(1115, 636);
            sc_venta.SplitterDistance = 762;
            sc_venta.TabIndex = 0;
            // 
            // gbx_venta
            // 
            gbx_venta.Location = new Point(8, 8);
            gbx_venta.Name = "gbx_venta";
            gbx_venta.Size = new Size(751, 616);
            gbx_venta.TabIndex = 0;
            gbx_venta.TabStop = false;
            gbx_venta.Text = "Compra";
            // 
            // gbx_metodo
            // 
            gbx_metodo.Location = new Point(11, 10);
            gbx_metodo.Name = "gbx_metodo";
            gbx_metodo.Size = new Size(335, 623);
            gbx_metodo.TabIndex = 0;
            gbx_metodo.TabStop = false;
            gbx_metodo.Text = "Metodo de pago";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1115, 636);
            Controls.Add(sc_venta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVenta";
            Text = "Compra";
            Load += frmVenta_Load;
            sc_venta.Panel1.ResumeLayout(false);
            sc_venta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc_venta).EndInit();
            sc_venta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer sc_venta;
        private GroupBox gbx_venta;
        private GroupBox gbx_metodo;
    }
}