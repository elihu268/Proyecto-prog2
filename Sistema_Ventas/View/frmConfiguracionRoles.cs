using Sistema_VentasCore.Bussines;
using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Utilities;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Controller;
using System.Data;
using NLog;
using System.Net;

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
            numIdRol.Value = _rolesController.ObtenerSiguienteId();
            numIdRol.ReadOnly = true;
            numIdRol.Enabled = false;
            scRoles.Panel1Collapsed = true;
            PoblaComboEstatus();
            PoblarComboFiltroEstatus();
            PoblarComboCodigos();
            CargarRolesActivos();

            _logger.Info("El formulario de configuración de roles ha sido cargado correctamente.");
            _logger.Debug("Iniciando carga de datos y configuraciones iniciales para roles.");
        }

        /// <summary>
        /// Permite la manipulación dependiendo de la sesión
        /// </summary>
        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sesión.TienePermiso("ROLE_EDIT"))
            {
                // Código para mandar los datos de la fila seleccionada para editar
            }
            else
            {
                MessageBox.Show("No tiene permiso para editar roles", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                { "Inactivo", 0 },
                { "Sin especificar", null }
            };
            cbxEstatusBusqueda.DataSource = new BindingSource(estatusFiltro, null);
            cbxEstatusBusqueda.DisplayMember = "Key";
            cbxEstatusBusqueda.ValueMember = "Value";
            cbxEstatusBusqueda.SelectedIndex = cbxEstatusBusqueda.FindStringExact("Sin especificar");
            cbxEstatusBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
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

                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Guardar Rol",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    id
                );
                auditoriaController.AudioriaAdd(auditoria);

                if (id > 0)
                {
                    // Registro exitoso
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarRolesActivos();
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
            CargarTodosRoles();
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
        private void CargarRolesActivos()
        {
            List<Rol> roles = _rolesController.ObtenerRoles();
            ConfigurarDataGridViewRoles(roles);
        }

        /// <summary>
        /// Carga todos los roles
        /// </summary>
        private void CargarTodosRoles()
        {
            try
            {
                List<Rol> roles = _rolesController.ObtenerRolesFiltrados();
                ConfigurarDataGridViewRoles(roles);
                _logger.Info("Se cargaron todos los roles.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los roles.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.Error(ex, "Error al cargar todos los roles");
            }
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
            numIdRol.Value = _rolesController.ObtenerSiguienteId();
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

                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Actualizar Rol",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    rolActualizado.IdRol
                );
                auditoriaController.AudioriaAdd(auditoria);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos de entrada
                    LimpiarCampos();

                    // Restaurar visibilidad de botones
                    btnGuardar.Visible = true;
                    btnEditarRol.Visible = false;

                    // Recargar los datos actualizados en la tabla
                    CargarRolesActivos();

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

        public void ImportarExcelRoles()
        {
            try
            {
                // Generar busqueda en la vista
                btnBuscarRol.PerformClick();

                // Instanciar el controlador
                RolesController rolesController = new RolesController();

                // Obtener filtros desde la vista
                string? codigo = cbxCodigoBusqueda.SelectedValue?.ToString();
                string? descripcion = string.IsNullOrWhiteSpace(txtDescBusqueda.Text) ? null : txtDescBusqueda.Text.Trim();
                int? estatus = cbxEstatusBusqueda.SelectedValue as int?;

                //int? estatus = null;
                //if (cbxEstatusBusqueda.SelectedValue != null)
                //{
                //    int estatusSeleccionado = (int)cbxEstatusBusqueda.SelectedValue;
                //    if (estatusSeleccionado == 0 || estatusSeleccionado == 1)
                //        estatus = estatusSeleccionado;
                //}
                //string codigo = cbxCodigoRol.SelectedItem != null && cbxCodigoRol.SelectedIndex > 0
                //                ? cbxCodigoRol.SelectedItem.ToString()
                //                : null;

                // Diálogo para guardar el archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = $"Roles_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        // Ejecutar la exportación
                        bool resultado = rolesController.ExportarRolesExcel(
                            saveFileDialog.FileName,
                            estatus,
                            string.IsNullOrWhiteSpace(descripcion) ? null : descripcion,
                            string.IsNullOrWhiteSpace(codigo) ? null : codigo
                        );

                        Cursor.Current = Cursors.Default;

                        if (resultado)
                        {
                            MessageBox.Show("Archivo Excel exportado correctamente.",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            DialogResult abrirArchivo = MessageBox.Show(
                                "¿Desea abrir el archivo Excel generado?",
                                "Abrir archivo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (abrirArchivo == DialogResult.Yes)
                            {
                                var startInfo = new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = saveFileDialog.FileName,
                                    UseShellExecute = true
                                };
                                System.Diagnostics.Process.Start(startInfo);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron roles para exportar.",
                                            "Información",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ImportarExcelRoles();
        }
    }
}
