using Sistema_Ventas.Bussines;
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using Sistema_Ventas.Controller;
using System.Data;
using NLog;

namespace Sistema_Ventas.View
{
    /// <summary>
    /// Formulario para la configuración y gestión de roles del sistema
    /// </summary>
    public partial class frmConfiguracionRoles : Form
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.View.frmConfiguracionRoles");
        private readonly RolesController _rolesController = new RolesController();

        /// <summary>
        /// Inicializa una nueva instancia del formulario de configuración de roles
        /// </summary>
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
            numIdRol.ReadOnly = true;
            numIdRol.Enabled = false;
            scRoles.Panel1Collapsed = true;
            PoblaComboEstatus();
            PoblarComboFiltroEstatus();
            PoblarComboCodigos();
            CargarRoles();

            _logger.Info("El formulario de configuración de roles ha sido cargado correctamente.");
            _logger.Debug("Iniciando carga de datos y configuraciones iniciales para roles.");
        }

        /// <summary>
        /// Llena el ComboBox de estatus en captura
        /// </summary>
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> lista_estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 0, "Inactivo" }
            };
            cbxEstatus.DataSource = new BindingSource(lista_estatus, null);
            cbxEstatus.DisplayMember = "Value";
            cbxEstatus.ValueMember = "Key";
            cbxEstatus.SelectedValue = 1;
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Llena el ComboBox de estatus para filtros
        /// </summary>
        private void PoblarComboFiltroEstatus()
        {
            Dictionary<string, object?> estatusFiltro = new Dictionary<string, object?>
            {
                { "Activo", 1 },
                { "Inactivo", 0 }
            };
            cbxEstatusBusqueda.DataSource = new BindingSource(estatusFiltro, null);
            cbxEstatusBusqueda.DisplayMember = "Key";
            cbxEstatusBusqueda.ValueMember = "Value";
        }

        /// <summary>
        /// Llena el ComboBox con todos los códigos de rol disponibles
        /// </summary>
        private void PoblarComboCodigos()
        {
            List<Rol> roles = _rolesController.ObtenerRoles();
            Dictionary<string, string> codigos = roles.ToDictionary(r => r.Codigo, r => r.Codigo);
            codigos.Add("Sin especificar", "");

            cbxCodigoBusqueda.DataSource = new BindingSource(codigos, null);
            cbxCodigoBusqueda.DisplayMember = "Key";
            cbxCodigoBusqueda.ValueMember = "Value";
            cbxCodigoBusqueda.SelectedValue = "";
        }

        /// <summary>
        /// Ejecuta el proceso de guardado de un nuevo rol (validando campos)
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar cursor de espera mientras se procesa
                Cursor = Cursors.WaitCursor;

                // Desactivar temporalmente los botones de acción
                btnGuardar.Enabled = false;
                btnEditarRol.Enabled = false;

                // Validar si hay campos obligatorios vacíos
                if (DatosVaciosGuardarRol())
                {
                    MessageBox.Show("Favor de llenar los datos obligatorios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar formato del código ingresado
                if (!DatosValidosGuardarRol())
                {
                    return;
                }

                // Crear una nueva instancia de Rol con los datos del formulario
                Rol nuevoRol = new Rol
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estatus = (int)cbxEstatus.SelectedValue == 1
                };

                // Llamar al controlador para registrar el nuevo rol
                var (id, mensaje) = _rolesController.RegistrarRol(nuevoRol);

                if (id > 0)
                {
                    // Registro exitoso
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarRoles();
                }
                else
                {
                    // Hubo advertencias o errores al guardar
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    txtCodigo.SelectAll();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores no controlados
                MessageBox.Show($"Ocurrió un error al guardar el rol:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar estado visual al finalizar el proceso
                Cursor = Cursors.Default;
                btnGuardar.Enabled = true;
                btnEditarRol.Enabled = true;
            }
        }

        private void btnActualizarDataGridView_Click(object sender, EventArgs e)
        {
            CargarRoles();
        }

        /// <summary>
        /// Carga los roles en el DataGridView aplicando los filtros seleccionados
        /// </summary>
        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            string? codigo = cbxCodigoBusqueda.SelectedValue?.ToString();
            string? descripcion = string.IsNullOrWhiteSpace(txtDescBusqueda.Text) ? null : txtDescBusqueda.Text.Trim();
            int? estatus = cbxEstatusBusqueda.SelectedValue as int?;

            List<Rol> rolesFiltrados = _rolesController.ObtenerRolesFiltrados(codigo, descripcion, estatus);
            ConfigurarDataGridViewRoles(rolesFiltrados);
        }

        /// <summary>
        /// Carga todos los roles activos por defecto en la tabla
        /// </summary>
        private void CargarRoles()
        {
            List<Rol> roles = _rolesController.ObtenerRoles();
            ConfigurarDataGridViewRoles(roles);
        }

        /// <summary>
        /// Aplica la configuración y carga de datos al DataGridView de roles
        /// </summary>
        private void ConfigurarDataGridViewRoles(List<Rol> roles)
        {
            dgvRoles.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Estatus", typeof(string));

            foreach (Rol rol in roles)
            {
                dt.Rows.Add(rol.IdRol, rol.Codigo, rol.Descripcion, rol.Estatus ? "Activo" : "Inactivo");
            }

            dgvRoles.DataSource = dt;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRoles.Columns["ID"].Visible = false;
            //dgvRoles.Columns["Código"].Width = 120;
            //dgvRoles.Columns["Descripción"].Width = 220;
            //dgvRoles.Columns["Estatus"].Width = 100;

            dgvRoles.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.ReadOnly = true;
        }

        private void btnColapsar_Click(object sender, EventArgs e)
        {
            scRoles.Panel1Collapsed = !scRoles.Panel1Collapsed;
            btnColapsar.Text = scRoles.Panel1Collapsed ? "Mostrar captura" : "Ocultar captura";
        }

        private void editRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                int idRol = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["ID"].Value);
                Rol? rol = _rolesController.ObtenerDetalleRol(idRol);

                if (rol != null)
                {
                    btnGuardar.Visible = false;
                    btnEditarRol.Visible = true;

                    numIdRol.Value = rol.IdRol;
                    txtCodigo.Text = rol.Codigo;
                    txtDescripcion.Text = rol.Descripcion;
                    cbxEstatus.SelectedValue = rol.Estatus ? 1 : 0;

                    if (scRoles.Panel1Collapsed)
                    {
                        scRoles.Panel1Collapsed = false;
                        btnColapsar.Text = "Ocultar captura";
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el rol seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool DatosVaciosGuardarRol()
        {
            return string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text);
        }

        private bool DatosValidosGuardarRol()
        {
            if (!RolNegocio.EsCodigoValido(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("El código del Rol no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            numIdRol.Value = 1;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            cbxEstatus.SelectedValue = 1;
            btnGuardar.Visible = true;
            btnEditarRol.Visible = false;
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            try
            {
                // Cambia el cursor a modo espera para indicar procesamiento
                Cursor = Cursors.WaitCursor;

                // Desactiva temporalmente los botones de acción para evitar múltiples clics
                btnEditarRol.Enabled = false;
                btnGuardar.Enabled = false;

                // Validar que el ID del rol sea mayor que cero
                if (numIdRol.Value <= 0)
                {
                    MessageBox.Show("Debe seleccionar un rol para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos vacíos
                if (DatosVaciosGuardarRol())
                {
                    MessageBox.Show("Favor de llenar los datos obligatorios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar formato del código
                if (!DatosValidosGuardarRol())
                {
                    return;
                }

                // Crear un objeto Rol con los datos actualizados
                Rol rolActualizado = new Rol
                {
                    IdRol = (int)numIdRol.Value,
                    Codigo = txtCodigo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estatus = (int)cbxEstatus.SelectedValue == 1
                };

                // Llamar al controlador para actualizar el rol
                var (exito, mensaje) = _rolesController.ActualizarRol(rolActualizado);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos de entrada
                    LimpiarCampos();

                    // Restaurar visibilidad de botones
                    btnGuardar.Visible = true;
                    btnEditarRol.Visible = false;

                    // Recargar los datos actualizados en la tabla
                    CargarRoles();

                    // Ocultar panel de captura
                    scRoles.Panel1Collapsed = true;
                    btnColapsar.Text = "Mostrar captura";
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el rol.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar el cursor y reactivar botones al final del proceso
                Cursor = Cursors.Default;
                btnEditarRol.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

    }
}
