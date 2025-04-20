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

            // Filtrar solo los permisos activos
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

                // Agregar filas para permisos activos
                foreach (var permiso in permisosActivos)
                {
                    dgv_permisos.Rows.Add(false, permiso.Codigo, permiso.Descripcion);
                }

                dgv_permisos.AutoResizeColumns();
                ConfigurarDgvPermisos();
            }
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
            if (cbox_rol.SelectedItem != null)
            {
                Rol rolSeleccionado = (Rol)cbox_rol.SelectedItem;
                string codigoRol = rolSeleccionado.Codigo; // o usar el ID si prefieres

                LlenarTablaPermisos(codigoRol);
            }
        }
        private void LlenarTablaPermisos(string codigoRol)
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
        }
        
        private void dgv_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ConfigurarDgvPermisos()
        {

            //Ajustes generales
            dgv_permisos.AllowUserToAddRows = false;
            dgv_permisos.AllowUserToDeleteRows = false;
            //dgv_permisos.ReadOnly = true;

            /* Ajustar el ancho de las columnas
            dgv_permisos.Columns["Codigo"].Width = 100;
            dgv_permisos.Columns["Descripcion"].Width = 200;

            // Ocultar columna ID si es necesario
            dgv_permisos.Columns["ID"].Visible = false;
            // Alineación
            dgv_permisos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_permisos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_permisos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            */
            // Color alternado de filas
            dgv_permisos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;

            // Selección de fila completa
            dgv_permisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgv_permisos.EnableHeadersVisualStyles = false;
            dgv_permisos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_permisos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_permisos.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_permisos.Font, FontStyle.Bold);
            dgv_permisos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgv_permisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_permisos.ColumnHeadersHeight = 35;
        }
    }
}
