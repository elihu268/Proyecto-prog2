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
            Rol rolSeleccionado = (Rol)cbox_rol.SelectedItem;
            int idRolSeleccionado = rolSeleccionado.IdRol;

            GuardarPermisosDelRol(idRolSeleccionado);

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
            
            PoblacboxRol(); // Llena el ComboBox
            if (cbox_rol.Items.Count > 0)
            {
                int idRol = (int)cbox_rol.SelectedValue;
                CargarPermisosPorRol(idRol);
            }
            //PoblacboxRol();
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

       

        private void GuardarPermisosDelRol(int idRol)
        {
            PermisoARolController permisoARolController= new PermisoARolController();
            // 1. Eliminar todos los permisos actuales del puesto

            permisoARolController.EliminarPermisos(idRol);

            // 2. Insertar los permisos seleccionados
            foreach (DataGridViewRow fila in dgv_permisos.Rows)
            {
                // Asegúrate de que no sea una fila nueva vacía
                if (!fila.IsNewRow)
                {
                    bool asignado = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value);
                    int idPermiso = Convert.ToInt32(fila.Cells["codigoa@"].Value);

                    if (asignado)
                    {
                        permisoARolController.AsignarPermisosARol(idRol, idPermiso);
                    }
                }
            }

            MessageBox.Show("Permisos guardados correctamente.");
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

        private void cbox_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_rol.SelectedValue != null)
            {
                int idRol = (int)cbox_rol.SelectedValue;
                CargarPermisosPorRol(idRol);
            }
        }
       
            private void CargarPermisosPorRol(int idRol)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Controlador (o lógica de datos)
                PermisoARolController permisosRolController = new PermisoARolController();
                PermisosController permisosController = new PermisosController();
                // Obtener todos los permisos disponibles
                List<Permiso> permisos = permisosController.ObtenerPermisos();

                // Obtener los permisos que ya tiene el rol
                List<int> permisosDelRol = permisosRolController.ObtenerIdsPermisosPorRol(idRol); ;

                if (permisos == null || permisos.Count == 0)
                {
                    MessageBox.Show("No hay permisos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_permisos.DataSource = null;
                    return;
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Descripción", typeof(string));
                dt.Columns.Add("Asignado", typeof(bool)); // checkbox

                foreach (var permiso in permisos)
                {
                    dt.Rows.Add(
                        permiso.IdPermiso,
                        permiso.Codigo,
                        permiso.Descripcion,
                        permisosDelRol.Contains(permiso.IdPermiso) // true si está asignado
                    );
                }

                dgv_permisos.DataSource = dt;

                // Opcional: ocultar la columna ID si no la necesitas
                dgv_permisos.Columns["ID"].Visible = false;

                // Ajustes visuales si quieres
                dgv_permisos.Columns["Asignado"].HeaderText = "Asignado al Rol";
                dgv_permisos.Columns["Asignado"].Width = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los permisos. Contacta al administrador.", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        

        }

        /* private void LlenarTablaPermisos(string codigoRol)
         {
             dgv_permisos.Columns.Clear();
             dgv_permisos.Rows.Clear();

             PermisosController permisosController = new PermisosController();

             // 1. Obtener todos los permisos activos
             List<Permiso> permisos = permisosController.ObtenerPermisos();
             var permisosActivos = permisos.Where(p => p.Estatus == true).ToList();

             // 2. Obtener permisos asignados al rol
             List<Permiso> permisosAsignados = permisosController.ObtenerPermisosPorRol(codigoRol);

             // 3. Crear columnas del DataGridView si hay datos
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

                 // 4. Agregar filas con checkbox marcado si el permiso está asignado al rol
                 foreach (var permiso in permisosActivos)
                 {
                     bool estaAsignado = permisosAsignados.Any(p => p.Codigo == permiso.Codigo);
                     dgv_permisos.Rows.Add(estaAsignado, permiso.Codigo, permiso.Descripcion);
                 }

                 dgv_permisos.AutoResizeColumns();
                 ConfigurarDgvPermisos(); // tu método para estilo
             }
         }*/

        private void dgv_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
