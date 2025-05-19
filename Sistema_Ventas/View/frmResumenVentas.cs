using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.View
{
    public partial class frmResumenVentas : Form
    {
        public frmResumenVentas(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sesión.TienePermiso("SALE_EDIT"))
            {
                //Código para la edición de una venta

            } 

            if (Sesión.TienePermiso("SALE_UPDATE"))
            {
                //Código para actualizar el estado de una venta
            }
        }
    }
}
