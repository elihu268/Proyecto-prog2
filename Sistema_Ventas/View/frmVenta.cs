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

namespace Sistema_Ventas.View
{
    public partial class frmVenta : Form
    {
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
            PoblacomboProducto();//producto por codigo
            PoblaDataProducto();

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

            // Obtener la lista de clientes (estudiantes)
            List<Cliente> listaClientes = clienteController.ObtenerClientes();

            cb_clientes.Items.Clear(); // Limpia primero el combo

            foreach (Cliente c in listaClientes)
            {
                cb_clientes.Items.Add(c.DatosPersonales.Correo); // Solo agregas el correo al combo
            }
            cb_clientes.DataSource = listaClientes;
            cb_clientes.DisplayMember = "Correo";
            cb_clientes.ValueMember = "Id";
            cb_clientes.SelectedIndex = -1; // Para que no aparezca uno seleccionado por defecto

        }
        private void PoblacomboProducto()
        {
            ProductosController productoController = new ProductosController();

            // Obtener la lista de clientes (estudiantes)
            List<Producto> listaProducto = productoController.ObtenerProductos();

            cBox_codigo.Items.Clear(); // Limpia primero el combo

            foreach (Producto p in listaProducto)
            {
                cBox_codigo.Items.Add(p.Codigo); // Solo agregas el correo al combo
            }
            cBox_codigo.DataSource = listaProducto;
            cBox_codigo.DisplayMember = "Codigo";
            cBox_codigo.ValueMember = "IdProducto";
            cBox_codigo.SelectedIndex = 0; // Para que no aparezca uno seleccionado por defecto

        }

        private void PoblaDataProducto()
        {
            

            try
            {
                Cursor = Cursors.WaitCursor;
                
                ProductosController productosController = new ProductosController();
                List<Producto> productos = productosController.ObtenerProductos();

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
        private bool TerminarCompra()
        {
            if (!SeleccionBusquedaCliente())
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// metodo para validar seleccion de busqueda
        /// </summary>
        /// <returns>falso si la inforacion ingresada no es valida</returns>
        private bool SeleccionBusquedaCliente()
        {
            if (cb_clientes.Text == "")
            {
                MessageBox.Show("Seleccione un cliente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Utilities.Validaciones.EsUnNumero(cb_clientes.Text))
            {
                MessageBox.Show("cliente no valido..", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            
            if (!detalleController.ValidarCantidad(cBox_codigo.Text
                , txt_cantidad.Text))
            {
                MessageBox.Show("la cantidad que se desea comprar rebasa el limite permitido", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //agregar en una lista el producto seleccionado
            Producto prod = (Producto)cBox_codigo.SelectedItem;
            List<Producto> productosSeleccionados = new List<Producto>();
            productosSeleccionados.Add(prod);
            ConfigurarDgvCarrito(productosSeleccionados);
            //mostrarla en la tabla de detalle

            int cantidad = Convert.ToInt32(txt_cantidad.Text);
            bool exito = true;
            if (exito)
            {
                MessageBox.Show("Producto agregado a la compra.");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el producto.");
            }


        }

        public void ConfigurarDgvCarrito(List<Producto> productos)
        {
            dgv_carrito.DataSource = null;
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
            //dgv_productos.Size = new Size(600, 400);
            //Ajustes generales


            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgv_productos.Columns["ID"].Width = 100;
            dgv_productos.Columns["Codigo"].Width = 200;
            dgv_productos.Columns["Nombre"].Width = 200;
            dgv_productos.Columns["Precio"].Width = 80;
            dgv_productos.Columns["Descripcion"].Width = 250;
            dgv_productos.Columns["Existencia"].Width = 120;

            // Ocultar columna ID si es necesario
            dgv_productos.Columns["ID"].Visible = false;
            dgv_productos.Columns["Codigo"].Visible = false;
            dgv_productos.Columns["Descripcion"].Visible = false;
            dgv_productos.Columns["Existencia"].Visible = false;


            // Alineación
            dgv_productos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Selección de fila completa
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_productos.Font, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_productos.ColumnHeadersHeight = 35;


        }

        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_clientes.SelectedItem is Cliente clienteSeleccionado)
            {
                txt_nombre.Text = clienteSeleccionado.DatosPersonales.NombreCompleto;

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
        public void ConfigurarDgvProductos()
        {

            //Ajustes generales
            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgv_productos.Columns["Codigo"].Width = 100;
            dgv_productos.Columns["Nombre"].Width = 100;
            dgv_productos.Columns["Precio"].Width = 50;
            dgv_productos.Columns["Descripcion"].Width = 200;
            dgv_productos.Columns["Existencia"].Width = 50;

            // Ocultar columna ID si es necesario
            dgv_productos.Columns["ID"].Visible = false;
            // Alineación
            dgv_productos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

            // Selección de fila completa
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_productos.Font, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_productos.ColumnHeadersHeight = 35;
        }
        public void ConfigurarDgvDetalle()
        {

            //Ajustes generales
            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgv_productos.Columns["Codigo"].Width = 100;
            dgv_productos.Columns["Nombre"].Width = 100;
            dgv_productos.Columns["Precio"].Width = 50;
            dgv_productos.Columns["Descripcion"].Width = 200;
            dgv_productos.Columns["Existencia"].Width = 50;

            // Ocultar columna ID si es necesario
            dgv_productos.Columns["ID"].Visible = false;
            // Alineación
            dgv_productos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

            // Selección de fila completa
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_productos.Font, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_productos.ColumnHeadersHeight = 35;
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
            //dgv_productos.Size = new Size(600, 400);
            //Ajustes generales


            dgv_productos.AllowUserToAddRows = false;
            dgv_productos.AllowUserToDeleteRows = false;
            dgv_productos.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgv_productos.Columns["ID"].Width = 100;
            dgv_productos.Columns["Codigo"].Width = 200;
            dgv_productos.Columns["Nombre"].Width = 200;
            dgv_productos.Columns["Precio"].Width = 80;
            dgv_productos.Columns["Descripcion"].Width = 250;
            dgv_productos.Columns["Existencia"].Width = 120;

            // Ocultar columna ID si es necesario
            dgv_productos.Columns["ID"].Visible = false;
          

            // Alineación
            dgv_productos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgv_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Selección de fila completa
            dgv_productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgv_productos.EnableHeadersVisualStyles = false;
            dgv_productos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_productos.Font, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_productos.ColumnHeadersHeight = 35;
        }

        private void cb_metodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
