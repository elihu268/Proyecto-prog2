using PuntodeVenta.View;
using Sistema_Ventas.Properties;
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
    /// <summary>
    /// Formulario principal MDI para el sistema de ventas
    /// </summary>
    public partial class MDI_Sistema_ventas : Form
    {
        /// <summary>
        /// Inicializa el formulario MDI principal
        /// </summary>
        public MDI_Sistema_ventas()
        {
            InitializeComponent();
            AjustarFondoMDI();
        }

        /// <summary>
        /// Configura el fondo del formulario principal
        /// </summary>
        public void AjustarFondoMDI()
        {
            // Ajusta la imagen al tamaño del formulario
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Evento para salir de la aplicación
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Organiza las ventanas hijas en cascada
        /// </summary>
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Organiza las ventanas hijas en mosaico horizontal
        /// </summary>
        private void mosaicohorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Organiza las ventanas hijas en mosaico vertical
        /// </summary>
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

        /// <summary>
        /// Abre o activa una ventana hija dentro del MDI
        /// </summary>
        /// <param name="nombre_forma">Nombre del formulario a abrir</param>
        private void AbreVentanaHija(string nombre_forma)
        {
            // Busca si la ventana ya está abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.ToLower() == nombre_forma)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    return;
                }
            }

            // Crea nueva instancia si no existe
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

        // Grupo de eventos para abrir diferentes módulos
        /// <summary>
        /// Abre el módulo de gestión de usuarios
        /// </summary>
        private void geUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmgestusuario");
        }

        /// <summary>
        /// Abre el módulo de auditorías
        /// </summary>
        private void auditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmauditoria");
        }

        /// <summary>
        /// Abre el módulo de gestión de clientes
        /// </summary>
        private void geClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmgestclientes");
        }

        /// <summary>
        /// Abre el módulo de ventas
        /// </summary>
        private void geVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmventa");
        }

        /// <summary>
        /// Abre el módulo de carga de catálogos
        /// </summary>
        private void cargaCatalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmcargacatalogo");
        }

        /// <summary>
        /// Abre el módulo de reportes
        /// </summary>
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmreportes");
        }

        /// <summary>
        /// Abre el módulo de resumen de ventas
        /// </summary>
        private void apiVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmresumenventas");
        }

        /// <summary>
        /// Abre el módulo de configuración de roles
        /// </summary>
        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmconfiguracionroles");
        }

        /// <summary>
        /// Abre el módulo de asignación de permisos
        /// </summary>
        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreVentanaHija("frmasignarpermisos");
        }

        private void MDI_Sistema_ventas_Load(object sender, EventArgs e)
        {

        }
    }
}