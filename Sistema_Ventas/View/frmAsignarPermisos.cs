using DiseñoForms.View;
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


        private void InicializarVentanaPermisos()
        {

            PoblacboxRol(); // Llena el ComboBox de roles
            if (cbox_rol.Items.Count > 0)
            {
                int idRol = (int)cbox_rol.SelectedValue;
                CargarPermisosPorRol(idRol);
            }
        }

        /// <summary>
        /// llena con la lista de roles el combo
        /// </summary>
        public void PoblacboxRol()
        {
            RolesController rolesController = new RolesController();

            // Obtener la lista de roles
            List<Rol> listaRoles = rolesController.ObtenerRoles();

            cbox_rol.Items.Clear();
            cbox_rol.DataSource = listaRoles;
            cbox_rol.DisplayMember = "Codigo";
            cbox_rol.ValueMember = "Idrol";
            cbox_rol.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AsignarPermiso();
        }
        public void AsignarPermiso()

        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (cbox_rol.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un rol.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<int> permisosSeleccionados = SeleccionoPermiso();
                if (permisosSeleccionados.Count == 0)//si no selecciono permisos
                {
                    MessageBox.Show("Por favor seleccione al menos un permiso.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idRolSeleccionado = (int)cbox_rol.SelectedValue; //  SelectedValue = ID del rol
                PermisoARolController permisoARolController = new PermisoARolController();
                permisoARolController.AsignarPermisosARol(idRolSeleccionado, permisosSeleccionados);

                if (Sesión.IdRol == idRolSeleccionado)
                {
                    UsuariosController uc = new UsuariosController();
                    // Si el rol seleccionado es el mismo que el del usuario actual, actualizar los permisos en la sesión
                    Sesión.Permisos = uc.ObtenerPermisos(idRolSeleccionado);
                    if (this.MdiParent != null)
                    {
                        if (this.MdiParent is MDI_Sistema_ventas mdiForm)
                        {
                            mdiForm.ActualizarVistaPorPermisos();
                        }
                        foreach (Form childForm in this.MdiParent.MdiChildren)
                        {
                            childForm.Close();
                        }
                        

                    }
                }

                MessageBox.Show("Permisos asignados correctamente.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar los permisos. Contacta al administrador.", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }
        
        private void frmAsignarPermisos_Load(object sender, EventArgs e)
        {
            InicializarVentanaPermisos();
        }
        private void InicializarVentanaPermisos()
        {
            
            PoblacboxRol(); // Llena el ComboBox de roles
            if (cbox_rol.Items.Count > 0)
            {
                int idRol = (int)cbox_rol.SelectedValue;
                CargarPermisosPorRol(idRol);
            }
        }
        public void PoblacboxRol()
        {
            RolesController rolesController = new RolesController();

            // Obtener la lista de roles
            List<Rol> listaRoles = rolesController.ObtenerRoles();

            cbox_rol.Items.Clear(); 
            cbox_rol.DataSource = listaRoles;
            cbox_rol.DisplayMember = "Codigo";
            cbox_rol.ValueMember = "Idrol";
            cbox_rol.SelectedIndex = 0;
        }



        private void GuardarPermisosDelRol(int idRol)
        {
            PermisoARolController permisoARolController = new PermisoARolController();

            // 1. Eliminar todos los permisos actuales del puesto
            permisoARolController.EliminarPermisos(idRol);

            // 2. Insertar los permisos seleccionados
            foreach (DataGridViewRow fila in dgv_permisos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    bool asignado = Convert.ToBoolean(fila.Cells["Asignado"].Value);
                    int idPermiso = Convert.ToInt32(fila.Cells["ID"].Value);

                    if (asignado)
                    {
                        permisoARolController.AsignarPermisosARol(idRol, idPermiso);
                    }
                }
            } 
        }

         /// <summary>
        /// obtener los id de permisos seleccionados
        /// </summary>
        /// <returns>lista de los id de los permisos seleccionaos</returns>
        private List<int> SeleccionoPermiso()
        {
            List<int> permisosSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dgv_permisos.Rows)//recorre todas las filas de la tabla
            {
                bool seleccionado = Convert.ToBoolean(row.Cells["Asignado"].Value);//marca true o false si el check de la columna asignado due seleccionado

                if (seleccionado)//si fue seleccionado obtener el id
                {
                    int idPermiso = Convert.ToInt32(row.Cells["ID"].Value); // Leer la columna "ID"
                    permisosSeleccionados.Add(idPermiso);//agregar a la lista
                }
            }

            return permisosSeleccionados;
        }
        private void frmAsignarPermisos_Load(object sender, EventArgs e)
        {
            InicializarVentanaPermisos();
        }
        



       

        private void cbox_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRol;
            if (cbox_rol.SelectedValue != null && int.TryParse(cbox_rol.SelectedValue.ToString(), out idRol))
            {
                // && int.TryParse(cbox_rol.SelectedValue.ToString(), out  idRol) tarda por la bd, asique el tryparse se asgeura que sea un numero(idrol)
                //aparece exception: 'Unable to cast object of type 'Sistema_Ventas.Model.Rol' to type 'System.Int32'.'

                idRol = (int)cbox_rol.SelectedValue;
                CargarPermisosPorRol(idRol);
            }
        }
       
            private void CargarPermisosPorRol(int idRol)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Controlador
                PermisoARolController permisosRolController = new PermisoARolController();
                PermisosController permisosController = new PermisosController();
                // Obtener todos los permisos disponibles
                List<Permiso> permisos = permisosController.ObtenerPermisos();

                // Obtener los id permisos que ya tiene el rol, para seleccionar el check de la tabla
                List<int> permisosDelRol = permisosRolController.ObtenerIdsPermisosPorRol(idRol); ;

                if (permisos == null )
                {
                    MessageBox.Show("No hay permisos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    return;
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Código", typeof(string));
                dt.Columns.Add("Descripción", typeof(string));
                dt.Columns.Add("Estatus", typeof(bool));//en la tabla apareceria como ches: estatus palomeado: estatus activo
                //en la bd es boolean
                dt.Columns.Add("Asignado", typeof(bool)); // al ponerlo como bool automaticamente aparece como check

                foreach (var permiso in permisos)
                {
                    dt.Rows.Add(
                        permiso.IdPermiso,
                        permiso.Codigo,
                        permiso.Descripcion,
                        permiso.Estatus,
                        permisosDelRol.Contains(permiso.IdPermiso) // aparece marcado (true si el arreglo permisosdelrol tiene el id de ese permso
                    );
                }

                dgv_permisos.DataSource = dt;
                dgv_permisos.Columns["ID"].Visible = false;
                dgv_permisos.Columns["Estatus"].Visible = false;
                dgv_permisos.Columns["Asignado"].Width = 100;
                dgv_permisos.ReadOnly = false;
                foreach (DataGridViewColumn col in dgv_permisos.Columns)
                {
                    if (col.Name != "Asignado")
                        col.ReadOnly = true; // Solo el checkbox editable
                }
                dgv_permisos.AllowUserToAddRows = false;//que no pueda agregar mas filas
                dgv_permisos.AllowUserToDeleteRows = false;
                dgv_permisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustar automáticamente el ancho de las columnas al contenido
                dgv_permisos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar el texto en las celdas
                dgv_permisos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrar el encabezado
                dgv_permisos.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Que el texto se ajuste si es muy largo
                dgv_permisos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;// Ajustar altura de filas si el texto se expande
                
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

        private void dgv_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
