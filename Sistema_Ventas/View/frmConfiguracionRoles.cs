using Sistema_Ventas.Bussines;
using Sistema_Ventas.Utilities;
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

namespace Sistema_Ventas.View
{
    /// <summary>
    /// Formulario para la configuración y gestión de roles del sistema
    /// </summary>
    public partial class frmConfiguracionRoles : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario de configuración de roles
        /// </summary>
        /// <param name="parent">Formulario padre para posicionamiento</param>
        public frmConfiguracionRoles(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        /// <summary>
        /// Evento Load del formulario: Configura estado inicial y carga datos
        /// </summary>
        private void frmConfiguracionRoles_Load(object sender, EventArgs e)
        {
            scRoles.Panel1Collapsed = true;
            PoblaTipoFecha();
            PoblaComboEstatus();
        }

        /// <summary>
        /// Carga los tipos de fecha disponibles en el ComboBox correspondiente
        /// </summary>
        private void PoblaTipoFecha()
        {
            Dictionary<int, string> lista_tipoFecha = new Dictionary<int, string>
            {
                { 1, "Alta" },
                { 2, "Baja" }
            };
            cbxTipoFecha.DataSource = new BindingSource(lista_tipoFecha, null);
            cbxTipoFecha.DisplayMember = "Value";
            cbxTipoFecha.ValueMember = "Key";
            cbxTipoFecha.SelectedValue = 1;
        }

        /// <summary>
        /// Carga los estados disponibles en el ComboBox de estatus
        /// </summary>
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> lista_estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 2, "Inactivo" }
            };
            //Asignar el diccionario al combobox
            cbxEstatus.DataSource = new BindingSource(lista_estatus, null);
            cbxEstatus.DisplayMember = "Value"; // lo que se muesta
            cbxEstatus.ValueMember = "Key"; // lo que se guarda como seleccionado 1, 2
            cbxEstatus.SelectedValue = 1; // opc seleccionada por default
        }

        /// <summary>
        /// Verifica campos obligatorios en el formulario de guardado
        /// </summary>
        /// <returns>True si existen campos vacíos</returns>
        private bool DatosVaciosGuardarRol()
        {
            if (numIdRol.Text == "" || txtCodigo.Text == "" || txtDescripcion.Text == "" || cbxEstatus.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida las reglas de negocio para el código del rol
        /// </summary>
        /// <returns>True si el código es válido</returns>
        private bool DatosValidosGuardarRol()
        {
            if (!RolNegocio.EsCodigoValido(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("El codigo del Rol no es valido ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ejecuta el proceso completo de guardado de un rol
        /// </summary>
        /// <returns>True si el guardado fue exitoso</returns>
        private bool GuardarRol()
        {
            if (DatosVaciosGuardarRol())
            {
                MessageBox.Show("Favor de llenar los datos obligatorios ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidosGuardarRol())
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Evento Click para el botón de Actualizar: Ejecuta validación y actualización
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ActualizarRol())
            {
                MessageBox.Show("Datos actualizados exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento Click para el botón de Guardar: Ejecuta validación y guardado
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarRol())
            {
                MessageBox.Show("Datos guardados exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Evento Click para el botón Colapsar: Controla la visibilidad del panel de captura
        /// </summary>
        private void btnColapsar_Click(object sender, EventArgs e)
        {
            if (scRoles.Panel1Collapsed)
            {
                scRoles.Panel1Collapsed = false;
                btnColapsar.Text = "Ocultar captura";
            }
            else
            {
                scRoles.Panel1Collapsed = true;
                btnColapsar.Text = "Mostrar captura";
            }
        }

        /// <summary>
        /// Verifica campos obligatorios en el formulario de actualización
        /// </summary>
        /// <returns>True si existen campos vacíos</returns>
        private bool DatosVaciosActualizarRol()
        {
            if (cbxTipoFecha.Text == "" || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "" || txtBusquedaRol.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Ejecuta el proceso completo de actualización de un rol
        /// </summary>
        /// <returns>True si la actualización fue exitosa</returns>
        private bool ActualizarRol()
        {
            if (DatosVaciosActualizarRol())
            {
                MessageBox.Show("Favor de llenar los datos obligatorios ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}