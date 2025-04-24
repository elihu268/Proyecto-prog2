using Sistema_Ventas.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Ventas.Bussines.ClientesNegocio;
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using Sistema_Ventas.Controller;

namespace PuntodeVenta.View
{
    public partial class frmGestClientes : Form
    {
        public frmGestClientes(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmGestClientes_Load(object sender, EventArgs e)
        {
            InicializarFrmClientes();
        }
        /// <summary>
        /// metodo para darle caracteristicas a frm despues de su creacion
        /// </summary>
        private void InicializarFrmClientes()
        {
            scClientes.Panel1Collapsed = true;
            txt_fecha_registro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PoblaComboEstatus();
            PoblaTipoFecha();
            PoblaTipoCliente();

        }
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
        private void PoblaTipoCliente()
        {
            Dictionary<int, string> list_tipoclinte = new Dictionary<int, string>
            {
                {1,"Fisico" },
                {2,"Moral" }
            };
            cbxTipoCliente.DataSource = new BindingSource(list_tipoclinte, null);
            cbxTipoCliente.DisplayMember = "Value";
            cbxTipoCliente.ValueMember = "Key";
            cbxTipoCliente.SelectedValue = 1;
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool DatosVacios()
        {
            if (txtNombreCliente.Text == "" || txtCorreoCliente.Text == "" || txtTelefonoCliente.Text == "" || cbxEstatus.Text == "" || txtrfcCliente.Text == "")
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
            if (!Sistema_Ventas.Bussines.ClientesNegocio.EsFormatoValido(txtCorreoCliente.Text.Trim()))
            {
                MessageBox.Show("El correo no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Sistema_Ventas.Bussines.ClientesNegocio.EsTelefonoValido(txtTelefonoCliente.Text.Trim()))
            {
                MessageBox.Show("El Telefono no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Sistema_Ventas.Bussines.ClientesNegocio.EsRFCValido(txtrfcCliente.Text.ToUpper().Trim()))
            {
                MessageBox.Show("El RFC no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GuardarCliente()
        {
            try
            {
                if (DatosVacios())
                {
                    MessageBox.Show("Favor de llenar los datos Obligatorios. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DatosValidos())
                {
                    return;
                }

                Persona persona = new Persona(
                    txtNombreCliente.Text.Trim(),
                    txtCorreoCliente.Text.Trim(),
                    txtTelefonoCliente.Text.Trim());

                persona.FechaNacimiento = dtpNacimientoCliente.Value;

                Cliente cliente = new Cliente
                {
                    Tipo = cbxTipoCliente.SelectedValue != null ? (int)cbxEstatus.SelectedValue : 1,
                    Rfc = txtrfcCliente.Text.Trim(),
                    FechaRegistro = DateTime.ParseExact(txt_fecha_registro.Text.Trim(), "dd/MM/yyyy", null),
                    Estatus = 1,
                    DatosPersonales = persona
                };

                ClientesController clientesController = new ClientesController();

                var (idCliente, mensaje) = clientesController.RegistrarCliente(cliente);

                //Verificar el resultado
                if (idCliente > 0)
                {
                    MessageBox.Show(mensaje, "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); //Metodo para limpiar el formulario edspues de guardar

                    //Actualizar la lista de estudiantes si esta presente en la misma vista
                    CargarClientes();
                }
                else
                {
                    //Mostrar mensaje de error devuelto por el controlador
                    MessageBox.Show(mensaje, "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Enfocar el campo apropiado basado en el codigo de error
                    switch (idCliente)
                    {
                        case -2: //Error de RFC duplicado
                            txtrfcCliente.Focus();
                            txtrfcCliente.SelectAll();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                //El detalle del error ya se guardara en el log por el controlador
                MessageBox.Show("No se pudo completar el registro del estudiante.Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void btncollapse_Click(object sender, EventArgs e)
        {
            if (scClientes.Panel1Collapsed)
            {
                scClientes.Panel1Collapsed = false;
                btncollapse.Text = "Ocultar Captura";
            }
            else
            {
                scClientes.Panel1Collapsed = true;
                btncollapse.Text = "Captura Rapida";
            }
        }

        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            ofdClientes.Title = "Seleccionar Archivo de Exel";
            ofdClientes.Filter = "Archivos de Exel(*.xlsx;*.xls)|*.xlsx;*.xls";
            // ofdArchivo.InitialDirectory = "C:\\";
            ofdClientes.FilterIndex = 1;
            ofdClientes.RestoreDirectory = true;
            if (ofdClientes.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdClientes.FileName;
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

        private void CargarClientes()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ClientesController clienteController = new ClientesController();

                List<Cliente> clientes = clienteController.ObtenerClientes();

                dgvGesClientes.DataSource = null;

                if (clientes.Count == 0)
                {
                    //opcionalmente mostrar mensaje cuando no hay datos
                    if (!string.IsNullOrEmpty(txtBusqueda.Text))
                    {
                        MessageBox.Show("No se encontraron clientes con el criterio de busqueda especificado", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }

                //Crear una tabla
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Tipo", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Teléfono", typeof(string));
                dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
                dt.Columns.Add("Fecha de Registro", typeof(DateTime));
                dt.Columns.Add("Estatus", typeof(string));

                //llenar el dataTime con la info de los estudiantes
                foreach (Cliente cliente in clientes)
                {
                    dt.Rows.Add(
                        cliente.Id,
                        cliente.Rfc,
                        cliente.DatosPersonales.NombreCompleto,
                        cliente.Tipo,
                        cliente.DatosPersonales.Correo,
                        cliente.DatosPersonales.Telefono,
                        cliente.DatosPersonales.FechaNacimiento,
                        cliente.FechaRegistro,
                        cliente.DescripcionEstatus
                        );
                }

                //asignar el dataTime como origen de dattos
                dgvGesClientes.DataSource = dt;

                //configurar la paraencia
                ConfigurarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes. Contacta al administrador del sistema",
                    "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //restaurar cursor, no tener bolita de carga
                Cursor = Cursors.Default;
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtCorreoCliente.Clear();
            txtTelefonoCliente.Clear();
            cbxTipoCliente.SelectedValue = 1;
            txtrfcCliente.Clear();
            cbxEstatus.SelectedValue = 2;
        }

        private void ConfigurarDataGridView()
        {
            //Ajustes generales
            dgvGesClientes.AllowUserToAddRows = false;
            dgvGesClientes.AllowUserToDeleteRows = false;
            dgvGesClientes.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgvGesClientes.Columns["RFC"].Width = 150;
            dgvGesClientes.Columns["Nombre Completo"].Width = 200;
            dgvGesClientes.Columns["Tipo"].Width = 80;
            dgvGesClientes.Columns["Correo"].Width = 180;
            dgvGesClientes.Columns["Teléfono"].Width = 120;
            dgvGesClientes.Columns["Fecha Nacimiento"].Width = 220;
            dgvGesClientes.Columns["Fecha de Registro"].Width = 220;
            dgvGesClientes.Columns["Estatus"].Width = 100;

            // Ocultar columna ID si es necesario
            dgvGesClientes.Columns["ID"].Visible = false;

            // Formato para las fechas
            dgvGesClientes.Columns["Fecha Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGesClientes.Columns["Fecha de Registro"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            dgvGesClientes.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGesClientes.Columns["RFC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGesClientes.Columns["Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGesClientes.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgvGesClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvGesClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de las cabeceras
            dgvGesClientes.EnableHeadersVisualStyles = false;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvGesClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgvGesClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGesClientes.ColumnHeadersHeight = 35;
        }

        private void dtpfechaRegistroCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_fecha_registro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGesClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}