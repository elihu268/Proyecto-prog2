using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Utilities;
using System.Data;
using NLog;
using Sistema_VentasCore.Controller;
using Sistema_VentasCore.Model;
using System.Net;

namespace PuntodeVenta.View
{
    /// <summary>
    /// Formulario para la generación de reportes de ventas con diversos filtros
    /// </summary>
    public partial class frmReportes : Form
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.View.frmReportes");

        public frmReportes(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            InicializaVentanaReportes();

            _logger.Info("El formulario de reporte de ventas ha sido cargado correctamente.");
            _logger.Debug("Inicializando filtros y parámetros para generación de reportes.");
        }

        /// <summary>
        /// Inicializa la configuración básica de la ventana de reportes
        /// </summary>
        public void InicializaVentanaReportes()
        {
            PoblaComboNomCliente();
            PoblaComboNomProducto();

            // Ajustar MaxDate correcto para evitar errores de rango
            dtpFechaInicio.MaxDate = new DateTime(9998, 12, 31);
            dtpFechaFin.MaxDate = new DateTime(9998, 12, 31);

            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;

            cbxNomCliente.Enabled = false;
            cbxNomProducto.Enabled = false;
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
        }

        /// <summary>
        /// Llena el ComboBox de clientes desde la base de datos
        /// </summary>
        private void PoblaComboNomCliente()
        {
            try
            {
                ClientesController clienteController = new ClientesController();
                List<Cliente> clientes = clienteController.ObtenerClientes();

                if (clientes.Count == 0)
                {
                    MessageBox.Show("No hay clientes registrados para seleccionar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cbxNomCliente.DataSource = clientes;
                cbxNomCliente.DisplayMember = "NombreCompletoCliente";
                cbxNomCliente.ValueMember = "Id";
                cbxNomCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxNomCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al cargar clientes en el ComboBox");
                MessageBox.Show("Error al cargar la lista de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Llena el ComboBox de productos desde la base de datos
        /// </summary>
        private void PoblaComboNomProducto()
        {
            try
            {
                ProductosController productoController = new ProductosController();
                List<Producto> productos = productoController.ObtenerProductos();

                if (productos.Count == 0)
                {
                    MessageBox.Show("No hay productos registrados para seleccionar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cbxNomProducto.DataSource = productos;
                cbxNomProducto.DisplayMember = "Nombre";
                cbxNomProducto.ValueMember = "IdProducto";
                cbxNomProducto.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxNomProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al cargar productos en el ComboBox");
                MessageBox.Show("Error al cargar la lista de productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbxNomCliente.Enabled = cbCliente.Checked;
        }

        private void cbProducto_CheckedChanged(object sender, EventArgs e)
        {
            cbxNomProducto.Enabled = cbProducto.Checked;
        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicio.Enabled = cbFecha.Checked;
            dtpFechaFin.Enabled = cbFecha.Checked;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                dtpFechaFin.Value = dtpFechaInicio.Value;
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaFin.Value = dtpFechaInicio.Value;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                int? idCliente = null;
                int? idProducto = null;
                DateTime? fechaInicio = null;
                DateTime? fechaFin = null;
                int? estatus = null;

                if (cbCliente.Checked && cbxNomCliente.SelectedValue != null)
                    idCliente = Convert.ToInt32(cbxNomCliente.SelectedValue);

                if (cbProducto.Checked && cbxNomProducto.SelectedValue != null)
                    idProducto = Convert.ToInt32(cbxNomProducto.SelectedValue);

                if (cbFecha.Checked)
                {
                    fechaInicio = dtpFechaInicio.Value.Date;
                    fechaFin = dtpFechaFin.Value.Date;
                }

                CompraController compraController = new CompraController();
                List<Compra> compras = compraController.BuscarCompras(idCliente, idProducto, fechaInicio, fechaFin, estatus);


                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Generacion Reporte",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    Sesión.IdUsuario
                );
                auditoriaController.AudioriaAdd(auditoria);


                MostrarReporteVentas(compras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte. Contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.Error(ex, "Error al generar reporte de ventas");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Muestra el listado de compras en el DataGridView
        /// </summary>
        private void MostrarReporteVentas(List<Compra> compras)
        {
            dgvReporteVentas.DataSource = null;

            if (compras.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados con los filtros aplicados.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("ID Compra", typeof(int));
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Subtotal", typeof(decimal));
            dt.Columns.Add("IVA", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            dt.Columns.Add("Fecha de Compra", typeof(DateTime));
            dt.Columns.Add("Estatus", typeof(string));
            dt.Columns.Add("Estatus Numérico", typeof(int));

            foreach (var compra in compras)
            {
                dt.Rows.Add(
                    compra.IdCompra,
                    compra.Codigo,
                    compra.NombreCliente ?? "Desconocido",                    
                    compra.Subtotal,
                    compra.Iva,
                    compra.Descuento,
                    compra.Total,
                    compra.FechaCompra,
                    EstatusVentaHelper.ObtenerDescripcionEstatus(compra.Estatus),
                    compra.Estatus
                );
            }

            dgvReporteVentas.DataSource = dt;

            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvReporteVentas.AllowUserToAddRows = false;
            dgvReporteVentas.AllowUserToDeleteRows = false;

            dgvReporteVentas.Columns["Estatus Numérico"].Visible = false; // Ocultar columna de estatus numérico

            // CONFIGURAR EL COMBOBOX CON ESTATUS FILTRADOS SEGÚN PERMISOS
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.Name = "Estatus";
            comboColumn.HeaderText = "Estatus";
            comboColumn.DataSource = EstatusVentaHelper.ObtenerTodosLosEstatus().Select(x => x.Value).ToList();
            comboColumn.DataPropertyName = "Estatus";
            comboColumn.FlatStyle = FlatStyle.Flat;

            int estatusIndex = dgvReporteVentas.Columns["Estatus"].Index;
            dgvReporteVentas.Columns.RemoveAt(estatusIndex);
            dgvReporteVentas.Columns.Insert(estatusIndex, comboColumn);
                        
            if (Sesión.TienePermiso("SALE_EDIT"))
            {
                dgvReporteVentas.ReadOnly = false;
                foreach (DataGridViewColumn column in dgvReporteVentas.Columns)
                {
                    column.ReadOnly = column.Name == "ID Compra" || column.Name == "Código";
                }
            }
            else if (Sesión.TienePermiso("SALE_UPDATE"))
            {
                // Usuario con SALE_UPDATE solo puede editar la columna Estatus
                dgvReporteVentas.ReadOnly = false; // Necesario para permitir edición del ComboBox
                foreach (DataGridViewColumn column in dgvReporteVentas.Columns)
                {
                    column.ReadOnly = column.Name != "Estatus";
                }
            }
            else
            {
                // Sin permisos de edición, toda la tabla es solo lectura
                dgvReporteVentas.ReadOnly = true;
            }


            // Ajustar ancho de columnas automáticamente
            dgvReporteVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Alineaciones
            dgvReporteVentas.Columns["ID Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReporteVentas.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporteVentas.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            
            dgvReporteVentas.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporteVentas.Columns["IVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporteVentas.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporteVentas.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReporteVentas.Columns["Fecha de Compra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReporteVentas.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formato de moneda para columnas monetarias
            dgvReporteVentas.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            dgvReporteVentas.Columns["IVA"].DefaultCellStyle.Format = "C2";
            dgvReporteVentas.Columns["Descuento"].DefaultCellStyle.Format = "C2";
            dgvReporteVentas.Columns["Total"].DefaultCellStyle.Format = "C2";

            // Estilo alternado
            dgvReporteVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvReporteVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Cabecera
            dgvReporteVentas.EnableHeadersVisualStyles = false;
            dgvReporteVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvReporteVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReporteVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvReporteVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvReporteVentas.ColumnHeadersHeight = 30;

            // Eventos para manejar cambios y formato
            dgvReporteVentas.CellFormatting += DgvReporteVentas_CellFormatting;
            dgvReporteVentas.CellValueChanged += DgvReporteVentas_CellValueChanged;
            dgvReporteVentas.DataBindingComplete += DgvReporteVentas_DataBindingComplete;
            dgvReporteVentas.CellBeginEdit += DgvReporteVentas_CellBeginEdit;
        }

        private void DgvReporteVentas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Solo aplicar lógica si es la columna de Estatus
            if (dgvReporteVentas.Columns[e.ColumnIndex].Name == "Estatus")
            {
                // Obtener el valor actual del estatus de la fila
                var estatusActual = dgvReporteVentas.Rows[e.RowIndex].Cells["Estatus"].Value?.ToString();

                // Si el movimiento está autorizado y el usuario no tiene permiso para editar movimientos autorizados
                if (estatusActual == "Autorizado" && !Sesión.TienePermiso("EDIT_MOV_AUTH"))
                {
                    // Cancelar la edición
                    e.Cancel = true;

                    // Opcional: Mostrar mensaje al usuario
                    MessageBox.Show("No puedes modificar movimientos autorizados.",
                                  "Acceso Denegado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // CONTROL ADICIONAL: Si no tiene permiso MOV_AUTH, personalizar el ComboBox
                if (!Sesión.TienePermiso("MOV_AUTH"))
                {
                    // Obtener la celda del ComboBox
                    var comboBoxCell = dgvReporteVentas.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                    if (comboBoxCell != null)
                    {
                        // Crear lista filtrada sin "Autorizado" para este usuario
                        var estatusFiltrados = EstatusVentaHelper.ObtenerTodosLosEstatus()
                            .Select(x => x.Value)
                            .Where(estatus => estatus != "Autorizado")
                            .ToList();

                        // Agregar el valor actual si no está en la lista (para mantener consistencia)
                        if (!string.IsNullOrEmpty(estatusActual) && !estatusFiltrados.Contains(estatusActual))
                        {
                            estatusFiltrados.Add(estatusActual);
                        }

                        // Asignar la lista filtrada solo a esta celda
                        comboBoxCell.DataSource = estatusFiltrados;
                    }
                }
            }
        }

        // MÉTODO COMBINADO PARA DATA BINDING COMPLETE
        private void DgvReporteVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Aplicar colores después de que se complete el binding de datos
            AplicarColoresEstatus();
        }

        private void AplicarColoresEstatus()
        {
            foreach (DataGridViewRow row in dgvReporteVentas.Rows)
            {
                if (row.Cells["Estatus Numérico"].Value != null)
                {
                    var estatusNumerico = Convert.ToInt32(row.Cells["Estatus Numérico"].Value);
                    var estatusValue = row.Cells["Estatus"].Value?.ToString();
                    var estatusCell = row.Cells["Estatus"];

                    // Aplicar colores base según el estatus numérico
                    estatusCell.Style.BackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                    estatusCell.Style.ForeColor = Color.White;
                    estatusCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    estatusCell.Style.SelectionBackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                    estatusCell.Style.SelectionForeColor = Color.White;

                    // LÓGICA ADICIONAL PARA MOVIMIENTOS AUTORIZADOS
                    if (estatusValue == "Autorizado")
                    {
                        // Si no tiene permiso para editar autorizados, aplicar estilo de solo lectura
                        if (!Sesión.TienePermiso("EDIT_MOV_AUTH"))
                        {
                            // Oscurecer el color base para indicar que no es editable
                            var colorBase = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                            var colorOscuro = Color.FromArgb(
                                Math.Max(0, colorBase.R - 50),
                                Math.Max(0, colorBase.G - 50),
                                Math.Max(0, colorBase.B - 50)
                            );

                            estatusCell.Style.BackColor = colorOscuro;
                            estatusCell.Style.SelectionBackColor = colorOscuro;

                            // Agregar borde para indicar que no es editable
                            estatusCell.Style.Font = new Font("Arial", 9, FontStyle.Bold | FontStyle.Italic);
                        }
                    }
                }
            }
        }

        private void dgvReporteVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Validar que no sea encabezado
            {
                int idCompra = Convert.ToInt32(dgvReporteVentas.Rows[e.RowIndex].Cells["ID Compra"].Value);

                DetalleCompraController detalleController = new DetalleCompraController();
                List<DetalleCompra> detalles = detalleController.ObtenerDetallePorCompra(idCompra);

                string mensaje = $"Detalle de la compra #{idCompra}:\n\n";

                foreach (var detalle in detalles)
                {
                    mensaje += $"- {detalle.Productoi?.Nombre ?? "Producto"}: {detalle.Cantidad} x {detalle.Productoi?.Precio:C} = {detalle.TotalPorUnidad:C}\n";
                }

                MessageBox.Show(mensaje, "Detalle de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImportarExcelCompras()
        {
            try
            {
                // Generar reporte en la vista
                btnGenerarReporte.PerformClick();

                // Crear instancia del controlador
                CompraController compraController = new CompraController();

                // Obtener filtros de la vista
                int? idCliente = null;
                int? idProducto = null;
                DateTime? fechaInicio = null;
                DateTime? fechaFin = null;
                int? estatus = null;

                if (cbCliente.Checked && cbxNomCliente.SelectedValue != null)
                    idCliente = Convert.ToInt32(cbxNomCliente.SelectedValue);

                if (cbProducto.Checked && cbxNomProducto.SelectedValue != null)
                    idProducto = Convert.ToInt32(cbxNomProducto.SelectedValue);

                if (cbFecha.Checked)
                {
                    fechaInicio = dtpFechaInicio.Value.Date;
                    fechaFin = dtpFechaFin.Value.Date;
                }

                // Diálogo para guardar el archivo
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        bool resultado = compraController.ExportarComprasExcel(
                            saveFileDialog.FileName,
                            idCliente,
                            idProducto,
                            fechaInicio,
                            fechaFin,
                            estatus
                        );

                        Cursor.Current = Cursors.Default;

                        if (resultado)
                        {
                            MessageBox.Show("Archivo Excel exportado correctamente.",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            DialogResult abrir = MessageBox.Show("¿Desea abrir el archivo generado?",
                                                                 "Abrir archivo",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question);
                            if (abrir == DialogResult.Yes)
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
                            MessageBox.Show("No se encontraron compras para exportar.",
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
            ImportarExcelCompras();
        }

        private void DgvReporteVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReporteVentas.Columns[e.ColumnIndex].Name == "Estatus" && e.Value != null)
            {
                // Obtener el valor numérico del estatus desde la columna oculta
                var estatusNumerico = Convert.ToInt32(dgvReporteVentas.Rows[e.RowIndex].Cells["Estatus Numérico"].Value);

                // Aplicar color de fondo según el estatus
                e.CellStyle.BackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void DgvReporteVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvReporteVentas.Columns[e.ColumnIndex].Name == "Estatus")
            {
                try
                {
                    var row = dgvReporteVentas.Rows[e.RowIndex];
                    var idCompra = Convert.ToInt32(row.Cells["ID Compra"].Value);
                    var nuevoEstatus = row.Cells["Estatus"].Value.ToString();
                    bool exito = false;
                    string mensaje;
                    int numCiclo = 0;

                    // Obtener el valor numérico del estatus
                    var estatusNumerico = EstatusVentaHelper.ObtenerTodosLosEstatus()
                        .FirstOrDefault(x => x.Value == nuevoEstatus).Key;

                    // Actualizar la columna oculta
                    row.Cells["Estatus Numérico"].Value = estatusNumerico;

                    // Aplicar el nuevo color inmediatamente
                    var estatusCell = row.Cells["Estatus"];
                    estatusCell.Style.BackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                    estatusCell.Style.ForeColor = Color.White;
                    estatusCell.Style.Font = new Font("Arial", 9, FontStyle.Bold);
                    estatusCell.Style.SelectionBackColor = EstatusVentaHelper.ObtenerColorEstatus(estatusNumerico);
                    estatusCell.Style.SelectionForeColor = Color.White;

                    CompraController cc = new CompraController();
                    (exito, mensaje) = cc.ActualizarEstatusCompra(idCompra, estatusNumerico);

                    // Refrescar el formato de la celda
                    dgvReporteVentas.InvalidateRow(e.RowIndex);
                    if (exito && numCiclo == 0)
                    {
                        MessageBox.Show($"{mensaje}: {nuevoEstatus}",
                        "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    numCiclo++;

                    AuditoriaController auditoriaController = new AuditoriaController();
                    Auditoria auditoria = new Auditoria(
                        "Actualización estatus",
                        DateTime.Now,
                        Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                        System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                        Sesión.UsuarioActual,
                        Sesión.IdUsuario,
                        idCompra
                    );
                    auditoriaController.AudioriaAdd(auditoria);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el estatus: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxNomProducto_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cbxNomCliente_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lblNomProducto_Click(object sender, EventArgs e) { }

        private void lblFechaFin_Click(object sender, EventArgs e) { }

        private void gbxFiltroVentas_Enter(object sender, EventArgs e) { }

        private void cbxNomProducto_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}
