using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ventas.Utilities;
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
            PoblaComboMetodo();
            PoblacomboCliente();

        }
        /// <summary>
        /// duncion que da una lista de valores al comntrol cb_metodo(comboBox metodo de pago)
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


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbx_metodo_Enter(object sender, EventArgs e)
        {

        }

        private void sc_venta_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sp_efectivo_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            TerminarCompra();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
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
            if (cb_clientes.Text=="")
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
        private bool AgregarProducto()
        {
            if (txt_cantidad.Text=="")
            {
                MessageBox.Show("porfavor,ingrese cantidad de producto", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Bussines.Negocio.CompraNegocio.EsCantidadValida(txt_cantidad.Text))
            {
                MessageBox.Show("solo se aceptan numeros enteros positivos mayores a 0", "informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn_actualizar_Click_(object sender, EventArgs e)
        {

        }

        private void cb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void PoblacomboCliente()
        {
            Dictionary<int, string> list_cliente = new Dictionary<int, string>()
            {
            //key,value
            { 0, "cliente general" }
        };
            cb_clientes.DataSource = new BindingSource(list_cliente, null);
            //es la fuente de datos que seria la lista atraves del objeto binding
            cb_clientes.DisplayMember = "value";//lo que muestra
            cb_clientes.ValueMember = "key";//con la que se enlaza a la base de datos
            cb_clientes.SelectedValue = 0;//valor inicializado
        }

        private void gpbox_cliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
