using Sistema_Ventas.Controller;
using Sistema_Ventas.Model;
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
            RolesController rolesController = new RolesController();

            // Obtener la lista de clientes (estudiantes)
            List<Rol> listaRoles = rolesController.ObtenerRoles();

            cbox_rol.Items.Clear(); // Limpia primero el combo

            foreach (Rol r in listaRoles)
            {
                cbox_rol.Items.Add(r.Codigo); // Solo agregas el correo al combo
            }
            cbox_rol.DataSource = listaRoles;
            cbox_rol.DisplayMember = "Codigo";
            cbox_rol.ValueMember = "Idrol";
            cbox_rol.SelectedIndex = -1;
        }

        private void PoblaDataPermiso()
        {
            dgv_permisos.Columns.Clear();
            dgv_permisos.Rows.Clear();

            PermisosController permisosController = new PermisosController();
            List<Permiso> permisos = permisosController.ObtenerPermisos();

            // Filtrar solo los permisos activos (opcional)
            var permisosActivos = permisos.Where(p => p.Estatus == true).ToList();

            // Solo agregar columnas si hay datos
            if (permisosActivos.Count > 0)
            {

                // Columna de checkbox
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Seleccionar";
                chk.Name = "chkSeleccionar";
                chk.Width = 60;
                dgv_permisos.Columns.Add(chk);

                // Otras columnas
                dgv_permisos.Columns.Add("codigoa@", "Nombre del Permiso");
                dgv_permisos.Columns.Add("descripcion", "Descripción");

                

                // Agregar filas
                foreach (var permiso in permisos)
                {
                    if (permiso.Estatus == true) // Solo activos (opcional)
                    {
                        dgv_permisos.Rows.Add(false, permiso.Codigo, permiso.Descripcion);
                    }
                }

                dgv_permisos.AutoResizeColumns();
            }

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

        private void dgv_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
