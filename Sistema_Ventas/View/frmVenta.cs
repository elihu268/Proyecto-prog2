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

namespace Sistema_Ventas.View
{
    public partial class frmVenta : Form
    {
        public frmVenta(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(parent,this);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
