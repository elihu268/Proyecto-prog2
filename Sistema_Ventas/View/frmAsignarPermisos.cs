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
        public void AsignarPermiso()
        {
            if (cbox_rol.SelectedIndex == -1)
            {
                MessageBox.Show("seleccione rol", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SeleccionoPermiso().Count == 0)
            {
                MessageBox.Show("seleccione permiso", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Permisos seleccionados: " + string.Join(", ", SeleccionoPermiso()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsignarPermiso();
        }



        private void frmAsignarPermisos_Load(object sender, EventArgs e)
        {
            InicializarVentanaPermisos();
        }
        private void InicializarVentanaPermisos()
        {
            //sc_asignacion.Panel1Collapsed = true;
            PoblaDataPermiso();
            PoblacboxRol();
        }
        public void PoblacboxRol()
        {

        }
        private void PoblaDataPermiso()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Seleccionar";
            chk.Name = "chkSeleccionar";
            chk.Width = 60;
            dgv_permisos.Columns.Add(chk);
            dgv_permisos.Columns.Add("nombre", "Nombre del Permiso");
            dgv_permisos.Columns.Add("descripcion", "Descripción");


            dgv_permisos.Rows.Add(false, "CrearUsuarios", "Permite crear nuevos usuarios");
            dgv_permisos.Rows.Add(false, "EditarUsuarios", "Permite modificar datos");
            dgv_permisos.Rows.Add(false, "EliminarUsuarios", "Permite eliminar usuarios");

        }

        private List<string> SeleccionoPermiso()
        {
            List<string> permisosSeleccionados = new List<string>();

            foreach (DataGridViewRow row in dgv_permisos.Rows)
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["chkSeleccionar"].Value);

                if (seleccionado)
                {
                    string nombrePermiso = row.Cells["nombre"].Value.ToString();
                    permisosSeleccionados.Add(nombrePermiso);

                }
            }

            return permisosSeleccionados;
        }
        private void sc_asignacion_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbox_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
