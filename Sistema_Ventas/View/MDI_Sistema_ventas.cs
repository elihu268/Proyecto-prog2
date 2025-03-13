using PuntodeVenta.View;
using Sistema_Ventas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoForms.View
{
    public partial class MDI_Sistema_ventas : Form
    {
        public MDI_Sistema_ventas()
        {
            InitializeComponent();
            AjustarFondoMDI();
        }

        public void AjustarFondoMDI()
        {
            // Ajusta la imagen al tamaño del formulario
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicohorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicohorizontalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void AbreVentanaHija(string nombre_forma)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.ToLower() == nombre_forma)
                {
                    // Si la ventana ya está abierta, traerla al frente y restaurarla si estaba minimizada
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            // Si no está abierta, crear y mostrar una nueva instancia
            Form childForm;
            switch (nombre_forma.ToLower())
            {
                case "frmgestusuario":
                    childForm = new frmGestUsuario(this);
                    break;
                case "frmauditoria":
                    childForm = new frmAuditoria(this);
                    break;
                case "frmgestclientes":
                    childForm = new frmGestClientes(this);
                    break;
                case "frmventa":
                    childForm = new frmVenta(this);
                    break;
                case "frmcargacatalogo":
                    childForm = new frmCargaCatalogo(this);
                    break;
                case "frmreportes":
                    childForm = new frmReportes(this);
                    break;
                case "frmresumenventas":
                    childForm = new frmResumenVentas(this);
                    break;
                case "frmconfiguracionroles":
                    childForm = new frmConfiguracionRoles(this);
                    break;
                case "frmasignarpermisos":
                    childForm = new frmAsignarPermisos(this);
                    break;
                default:
                    return;
            }
            childForm.Show();
        }

        private void geUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmgestusuario");
        }

        private void auditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmauditoria");
        }

        private void geClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmgestclientes");
        }

        private void geVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmventa");
        }

        private void cargaCatalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmcargacatalogo");
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmreportes");
        }

        private void apiVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmresumenventas");
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmconfiguracionroles");
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmasignarpermisos");
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        //private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AbreVentanaHija("frmestudiantes");
        //}
    }

}
