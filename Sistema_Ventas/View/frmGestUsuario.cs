using Sistema_VentasCore.Bussines;
using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Controller;
using System.Net;


namespace PuntodeVenta.View
{
    public partial class frmGestUsuario : Form
    {
        public frmGestUsuario(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmGestUsuario_Load(object sender, EventArgs e)
        {
            scUsuarios.Panel1Collapsed = true;
            CargarUsuarios();
            PoblaComboEstatus();
            //PoblaTipoFecha();
            PoblaRoles();
            PoblaEstatus();



            //Se oculta el boton para cargar un nuevo usuario si no tiene el permiso.
            if (!Sesión.TienePermiso("USR_CREATE"))
            {
                // Si no tiene el permiso, ocultar el botón
                btncargaUsuario.Visible = false;
            }
            // Se oculta el botón de carga masiva si no tiene el permiso
            if (!Sesión.TienePermiso("USER_IMPORT"))
            {
                // Si no tiene el permiso, ocultar el botón
                btnCarga.Visible = false;
            }
            if (!Sesión.TienePermiso("USR_EDIT"))
            {
                menuStrip.Enabled = false;
            }

        }
        //creacion del direccion en la cual se mostrara en el combobox de estatus
        private void PoblaComboEstatus()
        {
            Dictionary<string, bool> list_estat = new Dictionary<string, bool>
            {
                 {"Alta",true },
                {"Baja",false }
            };
            //asignar el diccionario al combobox
            cbxEstatus.DataSource = new BindingSource(list_estat, null);
            cbxEstatus.DisplayMember = "Key"; //lo que se muesta
            cbxEstatus.ValueMember = "Value"; // lo que se guarda como seleccionado 0,1,2
            cbxEstatus.SelectedValue = true;
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstatus.SelectedIndex = 0;

        }
        /*private void PoblaTipoFecha()
        {
            Dictionary<int, string> list_tipofecha = new Dictionary<int, string>
            {
                { 1, "Nacimiento" },
                { 2, "Alta" },
                { 3, "Baja" }
            };
            cbxtipoFecha.DataSource = new BindingSource(list_tipofecha, null);
            cbxtipoFecha.DisplayMember = "Value";
            cbxtipoFecha.ValueMember = "Key";
            cbxtipoFecha.SelectedValue = 1;
            cbxtipoFecha.DropDownStyle = ComboBoxStyle.DropDownList;
        }*/
        private void PoblaEstatus()
        {
            Dictionary<string, object> list_estat = new Dictionary<string, object>
            {

                {"Todos", "" },
                {"Activo",true },
                {"Inactivo",false }
            };
            //asignar el diccionario al combobox
            cbxEstatusB.DataSource = new BindingSource(list_estat, null);
            cbxEstatusB.DisplayMember = "Key"; //lo que se muesta
            cbxEstatusB.ValueMember = "Value"; // lo que se guarda como seleccionado 0,1,2
            cbxEstatusB.SelectedValue = "";
            cbxEstatusB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void PoblaRoles()
        {
            RolesController rc = new RolesController();

            List<Rol> roles = rc.ObtenerRoles();

            Dictionary<int, string> rolesD = new Dictionary<int, string>();

            // Llenar el diccionario con los roles
            foreach (var rol in roles)
            {
                rolesD.Add(rol.IdRol, rol.Codigo);
            }

            // Asignar el DataSource al ComboBox
            cbxRoles.DataSource = new BindingSource(rolesD, null);
            cbxRoles.DisplayMember = "Value";
            cbxRoles.ValueMember = "Key";

            // Establecer el estilo del ComboBox para que sea de selección única
            cbxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool DatosVacios()
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || cbxEstatus.Text == "" || cbxRoles.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DatosValidos()
        {
            if (!UsuariosNegocio.EsFormatoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!UsuariosNegocio.EsTelefonoValido(txtTelefono.Text.Trim()))
            {
                MessageBox.Show("El Telefono no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GuardarUsuario()
        {
            try
            {
                if (DatosVacios())
                {
                    MessageBox.Show("Por favor llene todos los campos", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ValidarContrasenas())
                {
                    return;
                }
                if (!DatosValidos())
                {
                    return;
                }
                Persona persona = new Persona(
                    txtNombre.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtTelefono.Text.Trim());

                persona.FechaNacimiento = dtpFechaNacimiento.Value;

                Usuario usuario = new Usuario
                {
                    idRol = cbxRoles.SelectedValue != null ? (int)cbxRoles.SelectedValue : 1,
                    Cuenta = txtCorreo.Text.Trim(),
                    Constrasena = txtContrasena.Text.Trim(),
                    Estatus = true,
                    DatosPersonales = persona
                };

                //agregar bitacora

                UsuariosController usuariosController = new UsuariosController();
                var (idUsuario, mensaje) = usuariosController.AgregarUsuario(usuario);
                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Agregar Usuario",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    idUsuario
                );
                auditoriaController.AudioriaAdd(auditoria);
                if (idUsuario > 0)
                {
                    MessageBox.Show(mensaje, "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch (idUsuario)
                    {
                        case -2:
                            MessageBox.Show("El usuario ya existe", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCorreo.Focus();
                            txtCorreo.SelectAll();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        private void btncargaUsuario_Click(object sender, EventArgs e)
        {
            if (scUsuarios.Panel1Collapsed)
            {
                scUsuarios.Panel1Collapsed = false;
                btncargaUsuario.Text = "Ocultar Captura";
            }
            else
            {
                scUsuarios.Panel1Collapsed = true;
                btncargaUsuario.Text = "Captura Rapida";
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                UsuariosController usuariosController = new UsuariosController();
                List<Usuario> usuarios = usuariosController.ObtenerUsuarios();
                dgvUsuarios.DataSource = null;
                if (usuarios.Count == 0)
                {
                    if (!string.IsNullOrEmpty(txtBusqueda.Text))
                    {
                        MessageBox.Show("No se encontraron resultados para la busqueda", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Teléfono", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Rol", typeof(string));

                //llenado de la tabla
                foreach (Usuario usuario in usuarios)
                {
                    dt.Rows.Add(
                        usuario.IdUsuario,
                        usuario.DatosPersonales.NombreCompleto,
                        usuario.DatosPersonales.Correo,
                        usuario.DatosPersonales.Telefono,
                        usuario.Estatus,
                        usuario.idRol);
                }
                dgvUsuarios.DataSource = dt;

                ConfigurarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void CargarBusquedaUsuarios(List<Usuario> usuarios)
        {
            dgvUsuarios.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre Completo", typeof(string));
            dt.Columns.Add("Correo", typeof(string));
            dt.Columns.Add("Teléfono", typeof(string));
            dt.Columns.Add("Estatus", typeof(string));
            dt.Columns.Add("Rol", typeof(string));

            //llenado de la tabla
            foreach (Usuario usuario in usuarios)
            {
                dt.Rows.Add(
                    usuario.IdUsuario,
                    usuario.DatosPersonales.NombreCompleto,
                    usuario.DatosPersonales.Correo,
                    usuario.DatosPersonales.Telefono,
                    usuario.Estatus,
                    usuario.idRol);
            }
            dgvUsuarios.DataSource = dt;
            // Configurar el DataGridView
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns["ID"].Visible = false; // Ocultar la columna ID
            dgvUsuarios.Columns["Nombre Completo"].HeaderText = "Nombre Completo";
            dgvUsuarios.Columns["Correo"].HeaderText = "Correo";
            dgvUsuarios.Columns["Teléfono"].HeaderText = "Teléfono";
            dgvUsuarios.Columns["Estatus"].HeaderText = "Estatus";
            dgvUsuarios.Columns["Rol"].HeaderText = "Rol";
            // Configurar el DataGridView
            dgvUsuarios.Columns["Nombre Completo"].Width = 200;
            dgvUsuarios.Columns["Correo"].Width = 180;
            dgvUsuarios.Columns["Teléfono"].Width = 120;
            dgvUsuarios.Columns["Estatus"].Width = 100;
            dgvUsuarios.Columns["Rol"].Width = 120;

            dgvUsuarios.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Color alternado de filas
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font(dgvUsuarios.Font, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void ConfigurarDGV()
        {
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgvUsuarios.Columns["ID"].Visible = false; // Ocultar la columna ID
            dgvUsuarios.Columns["Nombre Completo"].Width = 200;
            dgvUsuarios.Columns["Correo"].Width = 180;
            dgvUsuarios.Columns["Teléfono"].Width = 120;
            dgvUsuarios.Columns["Estatus"].Width = 100;
            dgvUsuarios.Columns["Rol"].Width = 120;


            // Ocultar columna ID si es necesario
            //dgvUsuarios.Columns["ID"].Visible = false;

            // Formato para las fechas
            // dgvUsuarios.Columns["Fecha Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            //   dgvUsuarios.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUsuarios.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font(dgvUsuarios.Font, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            ofdArchivo.Title = "Seleccionar Archivo de Exel";
            ofdArchivo.Filter = "Archivos de Exel(*.xlsx;*.xls)|*.xlsx;*.xls";
            // ofdArchivo.InitialDirectory = "C:\\";
            ofdArchivo.FilterIndex = 1;
            ofdArchivo.RestoreDirectory = true;
            if (ofdArchivo.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdArchivo.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".xlsx" || extension == ".xls")
                {
                    MessageBox.Show("Archivo Valido" + filePath, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  lbCargaMasiva.Text =  filePath;

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un archivo de exel valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarContrasenas()
        {
            if (txtContrasena.Text != txtConfContrasena.Text)
            {
                lbcontraalert.Text = "La contrasenas no coinciden";
                lbconfirmcontraAlert.Text = "La contrasenas no coinciden";
                return false;
            }
            if (txtContrasena.Text.Length < 8)
            {
                lbcontraalert.Text = "La contrasena debe tener almenos 8 caracteres";
                return false;
            }
            if (!Regex.IsMatch(txtContrasena.Text, @"[A-Z]"))
            {
                lbcontraalert.Text = "La contrasena debe contener una letra mayuscula";
                return false;
            }
            if (!Regex.IsMatch(txtContrasena.Text, @"[a-z]"))
            {
                lbcontraalert.Text = "La contrasena debe contener una letra minuscula";
                return false;
            }
            if (!Regex.IsMatch(txtContrasena.Text, @"\d"))
            {
                lbcontraalert.Text = "La contrasena debe contener un numero";
                return false;
            }
            if (!Regex.IsMatch(txtContrasena.Text, @"[\W_]"))
            {
                lbcontraalert.Text = "La contrasena debe contener un caracter especial";
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtContrasena.Clear();
            txtConfContrasena.Clear();
            cbxEstatus.SelectedValue = 1;
            cbxRoles.SelectedValue = 2;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
        /*  private bool Datosbusqueda()
          {
              if (cbxtipoFecha.Text == "" || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "")
              {
                  MessageBox.Show("Seleccione una fecha", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return false;
              }
              return true;
          }*/

        private void buscarUsuario()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string busqueda = string.IsNullOrEmpty(txtBusqueda.Text) ? "" : busqueda = txtBusqueda.Text.Trim();

                bool? estatus = null;
                if (cbxEstatusB.SelectedValue != null)
                {
                    estatus = cbxEstatusB.SelectedValue as bool?;
                }
                UsuariosController usuariosController = new UsuariosController();
                List<Usuario> usuarios = usuariosController.ObtenerUsuarioPorNombre(busqueda, estatus);
                if (usuarios.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para la busqueda", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CargarBusquedaUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                UsuariosController usuariosController = new UsuariosController();
                Usuario usuario = usuariosController.ObtenerPorId(idUsuario);
                if (usuario != null)
                {
                    if (scUsuarios.Panel1Collapsed)
                    {
                        scUsuarios.Panel1Collapsed = false;
                        btncargaUsuario.Text = "Ocultar Captura";
                    }
                    // Llenar los campos con la información del usuario
                    txtNombre.Text = usuario.DatosPersonales.NombreCompleto;
                    txtCorreo.Text = usuario.Cuenta;
                    txtTelefono.Text = usuario.DatosPersonales.Telefono;
                    cbxEstatus.SelectedValue = usuario.DatosPersonales.Estatus ? true : false;
                    cbxRoles.SelectedValue = usuario.idRol;
                    dtpFechaNacimiento.Value = usuario.DatosPersonales.FechaNacimiento ?? DateTime.Now;
                    // Mostrar el panel de captura
                    scUsuarios.Panel1Collapsed = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                button1.Visible = true;
                btnGuardar.Visible = false;
                txtCorreo.Enabled = false;
                txtContrasena.Enabled = false;
                txtConfContrasena.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }
        public void ActualizarUsuario()
        {
            try
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);
                UsuariosController usuariosController = new UsuariosController();
                Usuario usuario = usuariosController.ObtenerPorId(idUsuario);
                Usuario nuevainformacion = new Usuario
                {
                    IdUsuario = idUsuario,
                    idRol = cbxRoles.SelectedValue != null ? (int)cbxRoles.SelectedValue : 1,
                    Cuenta = txtCorreo.Text.Trim(),
                    Estatus = (bool)cbxEstatus.SelectedValue,
                    DatosPersonales = new Persona
                    {
                        Id = usuario.IdPersona,
                        FechaNacimiento = dtpFechaNacimiento.Value,
                        Telefono = txtTelefono.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        NombreCompleto = txtNombre.Text.Trim(),
                        Estatus = (bool)cbxEstatus.SelectedValue,
                    }
                };
                bool resultado = usuariosController.ActualizarUsuario(nuevainformacion);
                AuditoriaController auditoriaController = new AuditoriaController();
                Auditoria auditoria = new Auditoria(
                    "Actualizar Usuario",
                    DateTime.Now,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    idUsuario
                );
                auditoriaController.AudioriaAdd(auditoria);
                if (resultado)
                {
                    MessageBox.Show("Usuario actualizado con éxito", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfContrasena.Enabled = true;
                    txtContrasena.Enabled = true;
                    txtCorreo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarCampos();
                btnGuardar.Visible = true;
                button1.Visible = false;
                scUsuarios.Panel1Collapsed = true;
                btncargaUsuario.Text = "Captura Rapida";
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbEstatusB_Click(object sender, EventArgs e)
        {

        }
    }
}
