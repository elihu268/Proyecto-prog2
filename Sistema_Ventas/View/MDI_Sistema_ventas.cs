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
using NLog;
using Sistema_Ventas.Utilities;

namespace DiseñoForms.View
{
    /// <summary>
    /// Formulario principal MDI para el sistema de ventas
    /// </summary>
    public partial class MDI_Sistema_ventas : Form
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.View.MDI_Sistema_ventas");
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

        private void MDI_Sistema_ventas_Load(object sender, EventArgs e)
        {
            _logger.Info("Usuario accedio al Dashboard despues de iniciar sesión correctamente");

            //Permisos del strip de usuarios
            if (!Sesión.TienePermiso("USR_VIEW") && !Sesión.TienePermiso("AUDIT_VIEW"))
            {
                usuariosToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("USR_VIEW")) {
                geUsuariosToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("AUDIT_VIEW"))
            {
                auditoriasToolStripMenuItem.Visible = false;
            }

            //Permisos del strip de ventas y clientes
            if (!Sesión.TienePermiso("CLI_VIEW") && !Sesión.TienePermiso("SALE_CREATE") && !Sesión.TienePermiso("CATALOG_VIEW"))
            {
                clientesVentasToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("CLI_VIEW"))
            {
                geClientesToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("SALE_CREATE"))
            {
                geVentasToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("CATALOG_VIEW"))
            {
                cargaCatalogosToolStripMenuItem.Visible = false;
            }

            //Permisos del strip de estadisticas
            if (!Sesión.TienePermiso("SALE_VIEW") && !Sesión.TienePermiso("REPORT_VIEW"))
            {
                estadisticaAnalisisToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("SALE_VIEW"))
            {
                apiVentasToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("REPORT_VIEW"))
            {
                reportesToolStripMenuItem.Visible = false;
            }

            //Permisos del strip de seguriadad
            if (!Sesión.TienePermiso("ROLE_ASSIGN") && !Sesión.TienePermiso("ROLE_CREATE"))
            {
                seguridadToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("ROLE_ASSIGN"))
            {
                permisosToolStripMenuItem.Visible = false;
            }
            if (!Sesión.TienePermiso("ROLE_CREATE"))
            {
                rolesToolStripMenuItem.Visible = false;
            }

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

        public void ActualizarVistaPorPermisos()
        {
            // Permisos del strip de usuarios
            usuariosToolStripMenuItem.Visible = Sesión.TienePermiso("USR_VIEW") || Sesión.TienePermiso("AUDIT_VIEW");
            geUsuariosToolStripMenuItem.Visible = Sesión.TienePermiso("USR_VIEW");
            auditoriasToolStripMenuItem.Visible = Sesión.TienePermiso("AUDIT_VIEW");

            // Permisos del strip de ventas y clientes
            clientesVentasToolStripMenuItem.Visible = Sesión.TienePermiso("CLI_VIEW") || Sesión.TienePermiso("SALE_CREATE") || Sesión.TienePermiso("CATALOG_VIEW");
            geClientesToolStripMenuItem.Visible = Sesión.TienePermiso("CLI_VIEW");
            geVentasToolStripMenuItem.Visible = Sesión.TienePermiso("SALE_CREATE");
            cargaCatalogosToolStripMenuItem.Visible = Sesión.TienePermiso("CATALOG_VIEW");

            // Permisos del strip de estadisticas
            estadisticaAnalisisToolStripMenuItem.Visible = Sesión.TienePermiso("SALE_VIEW") || Sesión.TienePermiso("REPORT_VIEW");
            apiVentasToolStripMenuItem.Visible = Sesión.TienePermiso("SALE_VIEW");
            reportesToolStripMenuItem.Visible = Sesión.TienePermiso("REPORT_VIEW");

            // Permisos del strip de seguridad
            seguridadToolStripMenuItem.Visible = Sesión.TienePermiso("ROLE_ASSIGN") || Sesión.TienePermiso("ROLE_CREATE");
            permisosToolStripMenuItem.Visible = Sesión.TienePermiso("ROLE_ASSIGN");
            rolesToolStripMenuItem.Visible = Sesión.TienePermiso("ROLE_CREATE");
        }

    }
}