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
using static Sistema_Ventas.Bussines.Negocio;

namespace Sistema_Ventas.View
{
    public partial class frmConfiguracionRoles : Form
    {
        public frmConfiguracionRoles(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }

        private void frmConfiguracionRoles_Load(object sender, EventArgs e)
        {
            scRoles.Panel1Collapsed = true;
            PoblaTipoFecha();
            PoblaComboEstatus();
        }

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

        private bool DatosValidosGuardarRol()
        {
            if (!RolNegocio.EsCodigoValido(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("El codigo del Rol no es valido ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

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

        private bool ActualizarRol()
        {
            if (DatosVaciosActualizarRol())
            {
                MessageBox.Show("Favor de llenar los datos obligatorios ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ActualizarRol())
            {
                MessageBox.Show("Datos actualizados exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarRol())
            {
                MessageBox.Show("Datos guardados exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
