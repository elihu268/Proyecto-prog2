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

namespace PuntodeVenta.View
{
    public partial class frmGestClientes : Form
    {
        public frmGestClientes()
        {
            InitializeComponent();
        }

        private void frmGestClientes_Load(object sender, EventArgs e)
        {
            scClientes.Panel1Collapsed = true;
            PoblaComboEstatus();
            PoblaTipoFecha();
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
        }
        private bool DatosVacios()
        {
            if (txtNombreCliente.Text == "" || txtCorreoCliente.Text == "" || txtTelefonoCliente.Text == "" || cbxEstatus.Text == "")
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
            if (!UsuarioNegocio.EsCorreoValido(txtCorreoCliente.Text.Trim()))
            {
                MessageBox.Show("El correo no es Valido. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool GuardarCliente()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Favor de llenar los datos Obligatorios. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidos())
            {
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarCliente())
            {
                MessageBox.Show("Datos Guardados Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncollapse_Click(object sender, EventArgs e)
        {
            if (scClientes.Panel1Collapsed)
            {
                scClientes.Panel1Collapsed = false;
                btncollapse.Text = "Ocultar";
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
    }
}
