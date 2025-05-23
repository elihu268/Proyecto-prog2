using Sistema_VentasCore.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_VentasCore.Bussines.ClientesNegocio;
using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Utilities;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Controller;
using System.Net;

namespace PuntodeVenta.View
{
    public partial class frmGestClientes : Form
    {
        public frmGestClientes(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
            CargarClientes();
        }

        private void frmGestClientes_Load(object sender, EventArgs e)
        {
            InicializarFrmClientes();
            if (!Sesión.TienePermiso("CLI_CREATE"))
            {
                btncollapse.Visible = false;
            }
            if (!Sesión.TienePermiso("CLIENT_IMPORT"))
            {
                btnCargaMasiva.Visible = false;
            }
            if (!Sesión.TienePermiso("CLI_EDIT"))
            {
                cmsEdit.Enabled = false;
            }
            btnActualizarInfo.Visible = false;
        }
        /// <summary>
        /// metodo para darle caracteristicas a frm despues de su creacion
        /// </summary>
        private void InicializarFrmClientes()
        {
            scClientes.Panel1Collapsed = true;
            PoblaComboEstatus();
            PoblarComboEstatusFiltro();
            PoblaTipoCliente();
        }
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
    {
        {1, "Alta" },
        {0, "Baja" }
    };

            cbxEstatus.DataSource = new BindingSource(list_estatus, null);
            cbxEstatus.DisplayMember = "Value";  // Lo que se muestra (Alta/Baja)
            cbxEstatus.ValueMember = "Key";     // Lo que se guarda (1 o 0)

            cbxEstatus.SelectedValue = 1;       // Establece el valor predeterminado (Alta)
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PoblarComboEstatusFiltro()
        {
            Dictionary<string, object> estatusFiltro = new Dictionary<string, object>
    {
        { "Todos", null },
        { "Activo", true },
        { "Inactivo", false }
    };

            cbxEstatusFiltro.DataSource = new BindingSource(estatusFiltro, null);
            cbxEstatusFiltro.DisplayMember = "Key";
            cbxEstatusFiltro.ValueMember = "Value";
            cbxEstatusFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PoblaTipoCliente()
        {
            Dictionary<int, string> list_tipoclinte = new Dictionary<int, string>
            {
                {1,"Fisico" },
                {2,"Moral" }
            };
            cbxTipoCliente.DataSource = new BindingSource(list_tipoclinte, null);
            cbxTipoCliente.DisplayMember = "Value";
            cbxTipoCliente.ValueMember = "Key";
            cbxTipoCliente.SelectedValue = 1;
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool DatosVacios()
        {
            if (txtNombreCliente.Text == "" || txtCorreoCliente.Text == "" || txtTelefonoCliente.Text == "" || cbxEstatus.Text == "" || txtrfcCliente.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DatosValidos()
        {
            if (!Sistema_VentasCore.Bussines.ClientesNegocio.EsFormatoValido(txtCorreoCliente.Text.Trim()))
            {
                MessageBox.Show("El correo no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Sistema_VentasCore.Bussines.ClientesNegocio.EsTelefonoValido(txtTelefonoCliente.Text.Trim()))
            {
                MessageBox.Show("El Telefono no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Sistema_VentasCore.Bussines.ClientesNegocio.EsRFCValido(txtrfcCliente.Text.ToUpper().Trim()))
            {
                MessageBox.Show("El RFC no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GuardarCliente()
        {
            try
            {
                if (DatosVacios())
                {
                    MessageBox.Show("Favor de llenar los datos Obligatorios. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DatosValidos())
                {
                    return;
                }

                Console.WriteLine("Valor de Estatus seleccionado: " + cbxEstatus.SelectedValue); // Depuración


                Persona persona = new Persona(
                    txtNombreCliente.Text.Trim(),
                    txtCorreoCliente.Text.Trim(),
                    txtTelefonoCliente.Text.Trim());

                persona.FechaNacimiento = dtpNacimientoCliente.Value;
                persona.Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1;

                Cliente cliente = new Cliente
                {
                    Tipo = cbxTipoCliente.SelectedValue != null ? (int)cbxTipoCliente.SelectedValue : 1,
                    Rfc = txtrfcCliente.Text.Trim(),
                    FechaRegistro = DateTime.Now,
                    DatosPersonales = persona
                };


                ClientesController clientesController = new ClientesController();

                var (idCliente, mensaje) = clientesController.RegistrarCliente(cliente);

                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Agregar Cliente",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    idCliente
                );
                auditoriaController.AudioriaAdd(auditoria);
                //Verificar el resultado
                if (idCliente > 0)
                {
                    MessageBox.Show(mensaje, "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); //Metodo para limpiar el formulario edspues de guardar

                    //Actualizar la lista de estudiantes si esta presente en la misma vista
                    CargarClientes();
                }
                else
                {
                    //Mostrar mensaje de error devuelto por el controlador
                    MessageBox.Show(mensaje, "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Enfocar el campo apropiado basado en el codigo de error
                    switch (idCliente)
                    {
                        case -2: //Error de RFC duplicado
                            txtrfcCliente.Focus();
                            txtrfcCliente.SelectAll();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                //El detalle del error ya se guardara en el log por el controlador
                MessageBox.Show("No se pudo completar el registro del estudiante.Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void btncollapse_Click(object sender, EventArgs e)
        {
            if (scClientes.Panel1Collapsed)
            {
                scClientes.Panel1Collapsed = false;
                btncollapse.Text = "Ocultar Captura";
                btnGuardar.Visible = true;
                btnActualizarInfo.Visible = false;
            }
            else
            {
                scClientes.Panel1Collapsed = true;
                btncollapse.Text = "Captura Rapida";
                LimpiarCampos(); // Limpiar los campos al ocultar el panel
                btnGuardar.Visible = true;
                btnActualizarInfo.Visible = false;
            }
        }

        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            ofdClientes.Title = "Seleccionar Archivo de Exel";
            ofdClientes.Filter = "Archivos de Exel(*.xlsx;*.xls)|*.xlsx;*.xls";
            // ofdArchivo.InitialDirectory = "C:\\";
            ofdClientes.FilterIndex = 1;
            ofdClientes.RestoreDirectory = true;
            if (ofdClientes.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdClientes.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".xlsx" || extension == ".xls")
                {
                    MessageBox.Show("Archivo Valido" + filePath, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  lbCargaMasiva.Text =  filePath;

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un archivo de exel valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarClientes()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ClientesController clienteController = new ClientesController();
                List<Cliente> clientes = clienteController.ObtenerClientes();

                dgvGesClientes.DataSource = null;

                if (clientes.Count == 0)
                {
                    if (!string.IsNullOrEmpty(txtBusqueda.Text))
                    {
                        MessageBox.Show("No se encontraron clientes con el criterio de búsqueda especificado", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                // Crear una tabla
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Tipo", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Teléfono", typeof(string));
                dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
                dt.Columns.Add("Fecha de Registro", typeof(DateTime));
                dt.Columns.Add("Estatus", typeof(string));

                // Llenar el DataTable con los clientes
                foreach (Cliente cliente in clientes)
                {
                    dt.Rows.Add(
                        cliente.Id,
                        cliente.Rfc,
                        cliente.DatosPersonales?.NombreCompleto ?? "",
                        cliente.DescripcionTipo,

                        cliente.DatosPersonales?.Correo ?? "",
                        cliente.DatosPersonales?.Telefono ?? "",
                        cliente.DatosPersonales?.FechaNacimiento ?? DateTime.MinValue,
                        cliente.FechaRegistro ?? DateTime.MinValue,
                        cliente.DatosPersonales.Estatus ? "Activo" : "Inactivo"

                    );
                }

                dgvGesClientes.DataSource = dt;

                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes. Contacta al administrador del sistema", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BuscarCliente()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string nombre = string.IsNullOrWhiteSpace(txtBusqueda.Text)
                    ? null
                    : txtBusqueda.Text.ToLower();

                DateTime? fechaInicio = dtpFechaInicio.Value.Date;
                DateTime? fechaFin = dtpFechaFin.Value.Date;

                bool? estatus = null;
                if (cbxEstatusFiltro.SelectedValue != null)
                {
                    estatus = cbxEstatusFiltro.SelectedValue as bool?;
                }

                ClientesController clienteController = new ClientesController();
                List<Cliente> clientes = clienteController.ObtenerClientePorNombre(nombre, fechaInicio, fechaFin, estatus);

                if (clientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes con los criterios de búsqueda.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ConfigurarDataGridViewClientes(clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clientes:\n{ex.Message}", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtCorreoCliente.Clear();
            txtTelefonoCliente.Clear();
            cbxTipoCliente.SelectedValue = 1;
            txtrfcCliente.Clear();
            cbxEstatus.SelectedValue = 2;
        }

        public void ConfigurarDataGridViewClientes(List<Cliente> clientes)
        {
            dgvGesClientes.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("RFC", typeof(string));
            dt.Columns.Add("Nombre Completo", typeof(string));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Correo", typeof(string));
            dt.Columns.Add("Teléfono", typeof(string));
            dt.Columns.Add("Fecha Nacimiento", typeof(string));
            dt.Columns.Add("Fecha de Registro", typeof(string));
            dt.Columns.Add("Estatus", typeof(string));

            foreach (Cliente cliente in clientes)
            {
                dt.Rows.Add(
                    cliente.Id,
                    cliente.Rfc,
                    cliente.NombreCompletoCliente,
                    cliente.Tipo == 1 ? "Físico" : "Moral",
                    cliente.DatosPersonales?.Correo ?? "",
                    cliente.DatosPersonales?.Telefono ?? "",
                    cliente.DatosPersonales?.FechaNacimiento?.ToString("dd/MM/yyyy") ?? "",
                    cliente.FechaRegistro?.ToString("dd/MM/yyyy") ?? "",
                    cliente.DatosPersonales?.Estatus == true ? "Activo" : "Inactivo"
                );
            }

            dgvGesClientes.DataSource = dt;

            // Configuración visual, igual que la que ya tienes
            dgvGesClientes.AllowUserToAddRows = false;
            dgvGesClientes.AllowUserToDeleteRows = false;
            dgvGesClientes.ReadOnly = true;
            dgvGesClientes.Columns["ID"].Visible = false;
            dgvGesClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvGesClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGesClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvGesClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGesClientes.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvGesClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Estilo de cabeceras
            dgvGesClientes.EnableHeadersVisualStyles = false;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ConfigurarDataGridView()
        {
            //Ajustes generales
            dgvGesClientes.AllowUserToAddRows = false;
            dgvGesClientes.AllowUserToDeleteRows = false;
            dgvGesClientes.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgvGesClientes.Columns["RFC"].Width = 150;
            dgvGesClientes.Columns["Nombre Completo"].Width = 200;
            dgvGesClientes.Columns["Tipo"].Width = 80;
            dgvGesClientes.Columns["Correo"].Width = 180;
            dgvGesClientes.Columns["Teléfono"].Width = 120;
            dgvGesClientes.Columns["Fecha Nacimiento"].Width = 220;
            dgvGesClientes.Columns["Fecha de Registro"].Width = 220;
            dgvGesClientes.Columns["Estatus"].Width = 100;

            // Ocultar columna ID si es necesario
            dgvGesClientes.Columns["ID"].Visible = false;

            // Formato para las fechas
            dgvGesClientes.Columns["Fecha Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGesClientes.Columns["Fecha de Registro"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            dgvGesClientes.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGesClientes.Columns["RFC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGesClientes.Columns["Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGesClientes.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgvGesClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvGesClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de las cabeceras
            dgvGesClientes.EnableHeadersVisualStyles = false;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgvGesClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGesClientes.ColumnHeadersHeight = 35;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGesClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente de la fila seleccionada (suponiendo que el ID está en la primera columna del DataGridView)
                int clienteId = Convert.ToInt32(dgvGesClientes.SelectedRows[0].Cells["ID"].Value);

                // Llamar al controlador para obtener los datos del cliente a partir del ID
                ClientesController clienteController = new ClientesController();
                Cliente cliente = clienteController.ObtenerClientePorId(clienteId);

                if (cliente != null)
                {
                    // Mostrar el panel de captura para edición (si está colapsado)
                    if (scClientes.Panel1Collapsed)
                    {
                        scClientes.Panel1Collapsed = false;
                        btncollapse.Text = "Ocultar Captura";
                    }

                    // Rellenar los controles con los datos del cliente para edición
                    txtNombreCliente.Text = cliente.DatosPersonales.NombreCompleto;
                    txtCorreoCliente.Text = cliente.DatosPersonales.Correo;
                    txtTelefonoCliente.Text = cliente.DatosPersonales.Telefono;
                    cbxTipoCliente.SelectedValue = cliente.Tipo;
                    txtrfcCliente.Text = cliente.Rfc;
                    dtpNacimientoCliente.Value = cliente.DatosPersonales.FechaNacimiento ?? DateTime.Now;
                    cbxEstatus.SelectedValue = cliente.DatosPersonales.Estatus ? 1 : 0;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnActualizarInfo.Visible = true;
                btnGuardar.Visible = false;
                txtrfcCliente.Enabled = false; // Deshabilitar el campo RFC para evitar cambios

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnActualizarInfo_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        private void ActualizarCliente()
        {
            try
            {
                int clienteId = Convert.ToInt32(dgvGesClientes.SelectedRows[0].Cells["ID"].Value);
                ClientesController clienteController = new ClientesController();
                Cliente cliente = clienteController.ObtenerClientePorId(clienteId);
                Cliente nuevaInfo = new Cliente
                {
                    Id = cliente.Id,
                    Rfc = txtrfcCliente.Text.Trim(),
                    Tipo = Convert.ToInt32(cbxTipoCliente.SelectedValue),
                    FechaRegistro = cliente.FechaRegistro,
                    DatosPersonales = new Persona
                    {
                        Id = cliente.IdPersona,
                        NombreCompleto = txtNombreCliente.Text.Trim(),
                        Correo = txtCorreoCliente.Text.Trim(),
                        Telefono = txtTelefonoCliente.Text.Trim(),
                        FechaNacimiento = dtpNacimientoCliente.Value,
                        Estatus = cbxEstatus.SelectedValue.ToString() == "1"
                    }
                };

                bool resultado = clienteController.ActualizarCliente(nuevaInfo);
                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Actualizar Cliente",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    clienteId
                );
                auditoriaController.AudioriaAdd(auditoria);

                if (resultado)
                {
                    MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtrfcCliente.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el cliente. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Limpiar los campos después de la actualización
                LimpiarCampos();
                btnGuardar.Visible = true;
                btnActualizarInfo.Visible = false;
                scClientes.Panel1Collapsed = true;
                btncollapse.Text = "Captura Rapida";
                CargarClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar los cambios. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ImportarExcelClientes(){
            try
            {
                ClientesController clientesController = new ClientesController();

                bool estatus = cbxEstatusFiltro.SelectedValue is bool valor ? valor : false;
                DateTime? fechaInicio = dtpFechaInicio.Value;
                DateTime? fechaFin = dtpFechaFin.Value;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = $"Clientes_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)//Espera confirmacion
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        // Exportar usando el método del controlador
                        bool resultado = clientesController.ExportarClientesExcel(
                            saveFileDialog.FileName,
                            estatus,
                            fechaInicio,
                            fechaFin);

                        // Restaurar cursor normal
                        Cursor.Current = Cursors.Default;

                        if (resultado)
                        {
                            MessageBox.Show("Archivo Excel exportado correctamente",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Preguntar si desea abrir el archivo
                            DialogResult abrirArchivo = MessageBox.Show(
                                            "¿Desea abrir el archivo Excel generado?",
                                            "Abrir archivo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                            if (abrirArchivo == DialogResult.Yes)
                            {
                                // Usar ProcessStartInfo para abrir el archivo con la aplicación asociada
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
                            MessageBox.Show("No se encontraron clientes para exportar",
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

        private void dtpfechaRegistroCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_fecha_registro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGesClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void cbxtipoFecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxActivos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            ImportarExcelClientes();
        }
    }
}