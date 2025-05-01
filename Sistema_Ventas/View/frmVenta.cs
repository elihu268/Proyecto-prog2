using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ventas.Controller;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using NLog;
using Sistema_Ventas.Bussines;
namespace Sistema_Ventas.View
{
    public partial class frmVenta : Form
    {
        private List<DetalleCompra> detalles = new List<DetalleCompra>();
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.View.frmVenta");

        public frmVenta(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            InicializaVentanaVenta();
        }
        /// <summary>
        ///funcion que da valores a controles especificos despues de su creacion
        /// </summary>
        public void InicializaVentanaVenta()
        {
            //mostrar informacion
            PoblaComboMetodo();//metodo de pago
            PoblaComboEstatus();//estatus de compra
            PoblacomboCliente();//cliente por correo
            ProductosController productoController = new ProductosController();
            List<Producto> listaProducto = productoController.ObtenerProductos();
            var (alerta, mensaje) = CompraNegocio.AlertaExistencia(listaProducto);
            if (alerta)
            {
                MessageBox.Show(
                    mensaje,
                    "Existencia Baja",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            PoblacomboProducto(listaProducto);//producto por codigo
            PoblaDataProducto(listaProducto);
            txt_nombre_prod.Text = "";
            
            _logger.Debug("se cargo correctamente los combos bos y el datagrid");
        }
        /// <summary>
        /// funcion que da una lista de valores al comntrol cb_metodo(comboBox metodo de pago)
        /// </summary>
        public void PoblaComboMetodo()
        {
            Dictionary<int, string> list_metodo = new Dictionary<int, string>()
            {
                //key,value
    { 0, "Efectivo" },
    { 1, "Tarjeta debito" },
    { 2, "Tarjeta credito" }};
            cb_metodo.DataSource = new BindingSource(list_metodo, null);
            //es la fuente de datos que seria la lista atraves del objeto binding
            cb_metodo.DisplayMember = "value";//lo que muestra
            cb_metodo.ValueMember = "key";//con la que se enlaza a la base de datos
            cb_metodo.SelectedValue = 0;//valor inicializado

        }
        public void PoblaComboEstatus()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>()
            {
                //key,value
    { 0, "liquidada" },
    { 1, "en proceso" },
    { 2, "cancelada" }};
            cbox_estatus.DataSource = new BindingSource(list_estatus, null);
            //es la fuente de datos que seria la lista atraves del objeto binding
            cbox_estatus.DisplayMember = "value";//lo que muestra
            cbox_estatus.ValueMember = "key";//con la que se enlaza a la base de datos
            cbox_estatus.SelectedValue = 1;//valor inicializado

        }

        private void PoblacomboCliente()
        {
           
            ClientesController clienteController = new ClientesController();

            // Obtener la lista de clientes
            List<Cliente> listaClientes = clienteController.ObtenerClientes();

            // Limpiar cualquier asignación previa
            cb_clientes.DataSource = null;

            cb_clientes.DataSource = listaClientes;
            cb_clientes.DisplayMember = "Correo";     
            cb_clientes.ValueMember = "Id"; 
            cb_clientes.SelectedIndex = -1; 
        }
        private void PoblacomboProducto(List<Producto> listaProducto)
        {
           

            cBox_codigo.Items.Clear(); // Limpia primero el combo

            foreach (Producto p in listaProducto)
            {
                cBox_codigo.Items.Add(p.Codigo); 
            }
            cBox_codigo.DataSource = listaProducto;
            cBox_codigo.DisplayMember = "Codigo";
            cBox_codigo.ValueMember = "IdProducto";
            cBox_codigo.SelectedIndex = 0; // Para que no aparezca uno seleccionado por defecto

        }

        private void PoblaDataProducto(List<Producto> productos)
        {


            try
            {
                Cursor = Cursors.WaitCursor;
                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos con ese nombre", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ConfigurarDataGridViewProductos(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos. Contacta al administrador del sistema", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberar el cursor
                Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// metodo para registrar datos de compra,cliente
        /// </summary>no permite pagar si no se cumplen condiciones
        /// <returns>retorna verdadeo si se cumplen condiciones</returns>
        private void TerminarCompra()
        {
            if (!SeleccionBusquedaCliente())
            {
                return;
            }
            if (detalles.Count == 0)
            {
                MessageBox.Show("no se han agregado producto al carrito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }
           
            CompraController compraController = new CompraController();
            Cliente cliente = (Cliente)cb_clientes.SelectedItem;
            if (compraController.InsertarCompra(cliente.Id, (int)cbox_estatus.SelectedValue, (int)cb_metodo.SelectedValue, detalles))
            {
                MessageBox.Show("compra generada correctamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;

            }
            else
            {
                MessageBox.Show("no se pudo generar la compra", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            limpiarCampos();
        }
        public void limpiarCampos()
        {
            // Limpiar campos de texto
            txt_cantidad.Text = "";
            txt_nombre_prod.Text = "";
            txt_IVA.Text = "";
            txt_subtotal.Text = "";
            txt_total.Text = "";
            //txt_descuento.Text = "";

            // Limpiar el DataGridView (dgv_carrito) y los detalles
            // Limpiar el DataTable vinculado al DataGridView
            if (dgv_carrito.DataSource is DataTable dt)
            {
                dt.Clear();  // Limpiar las filas del DataTable
            }
            detalles.Clear();
            // Resetear ComboBoxes o controles adicionales
            cb_clientes.SelectedIndex = -1; // Resetear selección de cliente
        }
        /// <summary>
        /// metodo para validar seleccion de busqueda
        /// </summary>
        /// <returns>falso si la inforacion ingresada no es valida</returns>
        private bool SeleccionBusquedaCliente()
        {
            if (!(cb_clientes.SelectedItem is Cliente clienteSeleccionado))
            {
                MessageBox.Show("Por favor seleccione un cliente válido", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar que el correo no sea vacío o inválido
            if (string.IsNullOrEmpty(clienteSeleccionado.DatosPersonales.Correo) || !Utilities.Validaciones.EsCorreoValido(clienteSeleccionado.DatosPersonales.Correo))
            {
                MessageBox.Show("Cliente no válido: correo inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        /// <summary>
        /// metodo para validar que la cantidad halla sido puesta correctamente
        /// </summary>
        /// <returns>booleano si se cumple toda la validacion</returns>
        private void AgregarProducto()
        {
            if (!(cBox_codigo.SelectedItem is Producto productoSeleccionado))
            {
                MessageBox.Show("porfavor seleccione un producto valido", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("por davor,ingrese cantidad de producto", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Bussines.CompraNegocio.EsCantidadValida(txt_cantidad.Text))
            {
                MessageBox.Show("solo se aceptan numeros enteros positivos mayores a 0", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DetalleCompraController detalleController = new DetalleCompraController();
            CompraController compraController = new CompraController();
            if (!detalleController.ValidarCantidad(cBox_codigo.Text
                , txt_cantidad.Text))
            {
                MessageBox.Show("la cantidad que se desea comprar rebasa el limite permitido", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            Producto prod = (Producto)cBox_codigo.SelectedItem;
            DetalleCompra producto = new DetalleCompra(prod, cantidad);
            var existente = detalles.FirstOrDefault(d => d.Productoi.IdProducto == productoSeleccionado.IdProducto);//ver si ya existen
            if (existente != null)
            { int existenciamod = existente.Cantidad + cantidad;
                if (!detalleController.ValidarCantidad(cBox_codigo.Text
                , Convert.ToString(existenciamod)))
                {
                    MessageBox.Show("la cantidad que se desea comprar rebasa el limite permitido", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existente.Cantidad += cantidad;
            }
            else
            {
                detalles.Add(new DetalleCompra(productoSeleccionado, cantidad));
            }
            txt_subtotal.Text =  compraController.DatosCompraSubtotal(detalles).ToString("#,##0.00");
            txt_IVA.Text = compraController.DatosCompraIva(detalles).ToString("#,##0.00");
            txt_total.Text = compraController.DatosCompraTotal(detalles).ToString("#,##0.00");
            //txt_descuento.Text = compraController.DatosCompraDescuento().ToString("#,##0.00");
            ConfigurarDgvCarrito(detalles);

            //MessageBox.Show("Producto agregado a la compra.{}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void ConfigurarDgvCarrito(List<DetalleCompra> detalles)
        {
            dgv_carrito.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Total Por Unidad", typeof(decimal));

            // Llenar el DataTable con los productos encontrados
            foreach (DetalleCompra prd in detalles)
            {
                dt.Rows.Add(prd.Productoi.Nombre, prd.Cantidad, prd.TotalPorUnidad);
            }

            // Asignar el DataTable al DataGridView
            dgv_carrito.DataSource = dt;

            // Configuración básica
            dgv_carrito.AllowUserToAddRows = false;
            dgv_carrito.AllowUserToDeleteRows = false;
            dgv_carrito.ReadOnly = true;

            // Establecer el tamaño fijo de las columnas
            dgv_carrito.Columns["Nombre"].Width = 200;  // Ajusta el tamaño según sea necesario
            dgv_carrito.Columns["Cantidad"].Width = 80;
            dgv_carrito.Columns["Total Por Unidad"].Width = 100;

            // Alineación de las columnas
            dgv_carrito.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_carrito.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_carrito.Columns["Total Por Unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_carrito.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            // Selección de fila completa
            dgv_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_carrito.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv_carrito.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Estilo de cabeceras
            dgv_carrito.EnableHeadersVisualStyles = false;
            dgv_carrito.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_carrito.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_carrito.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv_carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_carrito.ColumnHeadersHeight = 40;
            // Evitar que el DataGridView cambie de tamaño al agregar filas
            dgv_carrito.Dock = DockStyle.None;  // Desactivar el Dock
            dgv_carrito.Size = new Size(dgv_carrito.Width, 184);  // Configurar un tamaño fijo (ajusta la altura que desees)

            // Evitar que se modifique el tamaño de las columnas al agregar filas
            dgv_carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;  // No cambiar el tamaño de las columnas automáticamente
            dgv_carrito.ScrollBars = ScrollBars.Both;  // Habilitar desplazamiento para el DataGridView

            // Prevenir el ajuste del tamaño del DataGridView al contenedor
            dgv_carrito.Dock = DockStyle.None;

        }


        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_clientes.SelectedItem is Cliente clienteSeleccionado)
            {
                txt_nombre_prod.Text = clienteSeleccionado.DatosPersonales.NombreCompleto;
             
            }
        }
        private void splitCVenta_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitCVenta_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void cBox_codigo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cBox_codigo.SelectedItem is Producto productoSeleccionado)
            {
                txt_nombre.Text = productoSeleccionado.Nombre;
                txt_precio.Text = Convert.ToString(productoSeleccionado.Precio);

            }
        }



        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            TerminarCompra();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }


        private void BuscarProducto()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (txt_buscar.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre del producto que desee buscar", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ProductosController productosController = new ProductosController();
                List<Producto> productos = productosController.ObtenerProductoPorNombre(txt_buscar.Text.ToLower());

                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos con ese nombre", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ConfigurarDataGridViewProductos(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos. Contacta al administrador del sistema", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberar el cursor
                Cursor = Cursors.Default;
            }
        }

        public void ConfigurarDataGridViewProductos(List<Producto> productos)
        {
            dgv_productos.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Existencia", typeof(int));

            // Llenar el DataTable con los productos encontrados
            foreach (Producto prd in productos)
            {
                dt.Rows.Add(
                    prd.IdProducto,
                    prd.Codigo,
                    prd.Nombre,
                    prd.Precio,
                    prd.Descripcion,
                    prd.Existencia
                );
            }

            // Asignar el DataTable al DataGridView
            dgv_productos.DataSource = dt;

            // Configuración básica
            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.ReadOnly = true;
            dgv_productos.Columns["ID"].Visible=false;
           // Ajuste automático de las columnas
           dgv_productos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Ajustar la altura de las filas
            dgv_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Alineación de las columnas
            dgv_productos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            // Selección de fila completa
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productos.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv_productos.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Estilo de las cabeceras
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Permitir desplazamiento si el contenido es largo
            dgv_productos.ScrollBars = ScrollBars.Both;

            // Ajustar el DataGridView al tamaño del contenedor
            //dgv_productos.Dock = DockStyle.Fill;
        }


        private void cb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgv_carrito.SelectedRows[0];
                string nombre = row.Cells["Nombre"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["Total Por Unidad"].Value);
                DetalleCompra detalleEliminar = detalles.FirstOrDefault(d =>
                    d.Productoi.Nombre == nombre && d.Cantidad == cantidad && d.TotalPorUnidad == precio);



                if (detalleEliminar != null)
                {
                    detalles.Remove(detalleEliminar);
                    ConfigurarDgvCarrito(detalles);
                    CompraController compraController = new CompraController();
                    txt_subtotal.Text = compraController.DatosCompraSubtotal(detalles).ToString("#,##0.00");
                    txt_IVA.Text = compraController.DatosCompraIva(detalles).ToString("#,##0.00");
                    txt_total.Text = compraController.DatosCompraTotal(detalles).ToString("#,##0.00");
                    txt_descuento.Text = compraController.DatosCompraDescuento().ToString("#,##0.00");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
