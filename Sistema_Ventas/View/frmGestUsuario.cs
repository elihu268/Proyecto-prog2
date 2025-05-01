using Sistema_Ventas.Bussines;
using Sistema_Ventas.Utilities;
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
using Sistema_Ventas.Model;
using Sistema_Ventas.Controller;


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
            PoblaComboEstatus();
            PoblaTipoFecha();
            PoblaRoles();

            CargarUsuarios();

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

        }
        //creacion del direccion en la cual se mostrara en el combobox de estatus
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                {1, "Alta" },
                {0, "Baja" }
            };
            //asignar el diccionario al combobox
            cbxEstatus.DataSource = new BindingSource(list_estatus, null);
            cbxEstatus.DisplayMember = "Value"; //lo que se muesta
            cbxEstatus.ValueMember = "Key"; // lo que se guarda como seleccionado 0,1,2

            cbxEstatus.SelectedValue = 1;
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void PoblaTipoFecha()
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
        }
        private void PoblaRoles()
        {
            Dictionary<int, string> list_roles = new Dictionary<int, string>
            {
                {1, "Administrador" },
                {2, "Vendedor" },
                {3, " " }
            };
            cbxRoles.DataSource = new BindingSource(list_roles, null);
            cbxRoles.DisplayMember = "Value";
            cbxRoles.ValueMember = "Key";
            cbxRoles.SelectedValue = 2;
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
                AuditoriaController auditoriaController = new AuditoriaController();
                string ip = System.Windows.Forms.SystemInformation.UserDomainName.ToString();
                string nombreEquipo = System.Windows.Forms.SystemInformation.ComputerName.ToString();
                
                UsuariosController usuariosController = new UsuariosController();
                var (idUsuario, mensaje) = usuariosController.AgregarUsuario(usuario);
                Auditoria auditoria = new Auditoria(
                    "Agregar Usuario",
                    DateTime.Now,
                     System.Windows.Forms.SystemInformation.UserDomainName.ToString(),
                    System.Windows.Forms.SystemInformation.ComputerName.ToString(),
                    Sesión.UsuarioActual,
                    Sesión.IdUsuario,
                    1
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
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Teléfono", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Rol", typeof(string));

                //llenado de la tabla
                foreach (Usuario usuario in usuarios)
                {
                    dt.Rows.Add(
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
        private void ConfigurarDGV()
        {
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ReadOnly = true;

            // Ajustar el ancho de las columnas
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
        private bool Datosbusqueda()
        {
            if (cbxtipoFecha.Text == "" || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "")
            {
                MessageBox.Show("Seleccione una fecha", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sesión.TienePermiso("USR_EDIT"))
            {
                // Código para mandar los datos de la fila seleccionada para editar
            } else
            {
                MessageBox.Show("No tiene permiso para editar usuarios", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
