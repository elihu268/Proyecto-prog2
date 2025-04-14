using Sistema_Ventas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.View
{
    public partial class frmAsignarPermisos : Form
    {
        public frmAsignarPermisos(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_permisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignarPermiso();
        }
        public bool AsignarPermiso()
        {
            if (cbox_permisos.Text == "")
            {
                MessageBox.Show("seleccione permiso", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsignarPermiso();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (sc_asignacion.Panel1Collapsed)//si esta colapsado
            {
                //entonces no colapsar
                sc_asignacion.Panel1Collapsed = false;
                btn_ver.Text = "ocultar permisos asignados";
            }
            else
            {
                sc_asignacion.Panel1Collapsed = true;
                btn_ver.Text = "mostrar permisos asignados";
            }
        }

        private void frmAsignarPermisos_Load(object sender, EventArgs e)
        {
            InicializarVentanaPermisos();
        }
        private void InicializarVentanaPermisos()
        {
            sc_asignacion.Panel1Collapsed = true;
            PoblacomboPermisos();
        }
        private void PoblacomboPermisos()
        {
            Dictionary<int, string> list_cliente = new Dictionary<int, string>()
            {
            //key,value
            { 0, "asignar permisos" }
        };
            cbox_permisos.DataSource = new BindingSource(list_cliente, null);
            //es la fuente de datos que seria la lista atraves del objeto binding
            cbox_permisos.DisplayMember = "value";//lo que muestra
            cbox_permisos.ValueMember = "key";//con la que se enlaza a la base de datos
            cbox_permisos.SelectedValue = 0;//valor inicializado
        }
    }
}
