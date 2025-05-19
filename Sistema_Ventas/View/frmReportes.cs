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
                List<Compra> compras = compraController.BuscarCompras(idCliente, idProducto, fechaInicio, fechaFin, 1);


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
                    compra.FechaCompra
                );
            }

            dgvReporteVentas.DataSource = dt;

            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvReporteVentas.AllowUserToAddRows = false;
            dgvReporteVentas.AllowUserToDeleteRows = false;
            dgvReporteVentas.ReadOnly = true;

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

        private void cbxNomProducto_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cbxNomCliente_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lblNomProducto_Click(object sender, EventArgs e) { }

        private void lblFechaFin_Click(object sender, EventArgs e) { }

        private void gbxFiltroVentas_Enter(object sender, EventArgs e) { }

        private void cbxNomProducto_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}
