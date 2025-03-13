using Sistema_Ventas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PuntodeVenta.View
{
    public partial class frmReportes : Form
    {
        public frmReportes(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            InicializaVentanaReportes();
        }

        public void InicializaVentanaReportes()
        {

            PoblaComboNomCliente();
            PoblaComboNomProducto();
        }

        private void PoblaComboNomCliente()
        {
            //Crear un diccionario de valores
            Dictionary<int, string> list_nomclientes = new Dictionary<int, string>
            {
                { 1, "Julio Domingez" },
                { 2, "Jesus Vasquez" },
                { 3, "Pedro Picapiedra" }
            };
            //Asignar el diccionario al combo
            cbxNomCliente.DataSource = new BindingSource(list_nomclientes, null);
            cbxNomCliente.DisplayMember = "Value";
            cbxNomCliente.ValueMember = "Key";

            cbxNomCliente.SelectedValue = 1;
        }

        private void PoblaComboNomProducto()
        {
            //Crear un diccionario de valores
            Dictionary<int, string> list_nomproducto = new Dictionary<int, string>
            {
                { 1, "Leche" },
                { 2, "Cafe" },
                { 3, "Cereal" }
            };
            //Asignar el diccionario al combo
            cbxNomProducto.DataSource = new BindingSource(list_nomproducto, null);
            cbxNomProducto.DisplayMember = "Value";
            cbxNomProducto.ValueMember = "Key";

            cbxNomProducto.SelectedValue = 1;
        }

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar los controles según el estado del CheckBox
            bool isChecked = cbCliente.Checked;
            cbxNomCliente.Enabled = isChecked;
        }

        private void cbProducto_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar los controles según el estado del CheckBox
            bool isChecked = cbProducto.Checked;
            cbxNomProducto.Enabled = isChecked;
        }
        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar los controles según el estado del CheckBox
            bool isChecked = cbFecha.Checked;
            dtpFechaInicio.Enabled = isChecked;
            dtpFechaFin.Enabled = isChecked;
        }
        private void cbxNomProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxNomCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNomProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaFin_Click(object sender, EventArgs e)
        {

        }

        private void dgvReporteVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
