using Sistema_Ventas.Bussines;
using Sistema_Ventas.Utilities;
using System.ComponentModel;
using NLog;

namespace Sistema_Ventas.View
{
    /// <summary>
    /// Formulario para la configuración y gestión de roles del sistema
    /// </summary>
    public partial class frmConfiguracionRoles : Form
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.View.frmConfiguracionRoles");
        /// <summary>
        /// Inicializa una nueva instancia del formulario de configuración de roles
        /// </summary>
        /// <param name="parent">Formulario padre para posicionamiento</param>
        public frmConfiguracionRoles(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        /// <summary>
        /// Evento Load del formulario: Configura estado inicial y carga datos
        /// </summary>
        private void frmConfiguracionRoles_Load(object sender, EventArgs e)
        {
            scRoles.Panel1Collapsed = true;
            PoblaComboEstatus();

            // Se registra información indicando que el formulario ha sido cargado
            _logger.Info("El formulario de configuración de roles ha sido cargado correctamente.");

            // Mensaje de depuración que indica que comienza la carga inicial de datos
            _logger.Debug("Iniciando carga de datos y configuraciones iniciales para roles.");

        }

        /// <summary>
        /// Carga los estados disponibles en el ComboBox de estatus
        /// </summary>
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> lista_estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 2, "Inactivo" }
            };
            //Asignar el diccionario al combobox
            cbxEstatus.DataSource = new BindingSource(lista_estatus, null);
            cbxEstatus.DisplayMember = "Value"; // lo que se muesta
            cbxEstatus.ValueMember = "Key"; // lo que se guarda como seleccionado 1, 2
            cbxEstatus.SelectedValue = 1; // opc seleccionada por default
        }

        /// <summary>
        /// Verifica campos obligatorios en el formulario de guardado
        /// </summary>
        /// <returns>True si existen campos vacíos</returns>
        private bool DatosVaciosGuardarRol()
        {
            if (numIdRol.Text == "" || txtCodigo.Text == "" || txtDescripcion.Text == "" || cbxEstatus.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida las reglas de negocio para el código del rol
        /// </summary>
        /// <returns>True si el código es válido</returns>
        private bool DatosValidosGuardarRol()
        {
            if (!RolNegocio.EsCodigoValido(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("El codigo del Rol no es valido ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ejecuta el proceso completo de guardado de un rol
        /// </summary>
        /// <returns>True si el guardado fue exitoso</returns>
        private bool GuardarRol()
        {
            if (DatosVaciosGuardarRol())
            {
                MessageBox.Show("Favor de llenar los datos obligatorios ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidosGuardarRol())
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Evento Click para el botón de Guardar: Ejecuta validación y guardado
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarRol())
            {
                MessageBox.Show("Datos guardados exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento Click para el botón Colapsar: Controla la visibilidad del panel de captura
        /// </summary>
        private void btnColapsar_Click(object sender, EventArgs e)
        {
            if (scRoles.Panel1Collapsed)
            {
                scRoles.Panel1Collapsed = false;
                btnColapsar.Text = "Ocultar captura";
            }
            else
            {
                scRoles.Panel1Collapsed = true;
                btnColapsar.Text = "Mostrar captura";
            }
        }

        /// <summary>
        /// Evento Click para el botón de buscar un rol
        /// </summary>
        private void btnBuscarRol_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento Click para el botón de Actualizar el DataGridView para aplicar filtros
        /// </summary>
        private void btnActualizarDataGridView_Click(object sender, EventArgs e)
        {

        }



    }
}