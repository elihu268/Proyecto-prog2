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
            Formas.InicializaForma(this, parent);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            InicializaVentanaVenta();
        }

        public void InicializaVentanaVenta()
        {
            PoblaComboMetodo();
        }
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
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }
        private bool AgregarProducto()
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("porfavor,ingrese cantidad de producto", "Informacion del sistema", MessageBoxButtons.OK);
                return false;
            }
            if (!Bussines.Negocio.CompraNegocio.EsCantidadValida(txt_cantidad.Text))
            {
                MessageBox.Show("solo se aceptan numeros enteros positivos mayores a 0", "informacion del sistema", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btn_actualizar_Click_(object sender, EventArgs e)
        {

        }
    }
}
