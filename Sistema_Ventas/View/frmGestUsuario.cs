﻿using Sistema_Ventas.Bussines;
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
using static Sistema_Ventas.Bussines.Negocio;

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
        private bool GuardarUsuario()
        {
            lbconfirmcontraAlert.Text = " ";
            lbcontraalert.Text = " ";
            if (DatosVacios())
            {
                MessageBox.Show("Favor de llenar los datos Obligatorios. ", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidos())
            {
                return false;
            }
            if (!ValidarContrasenas())
            {
                return false;

            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarUsuario())
            {
                MessageBox.Show("Datos Guardados Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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


        private bool Datosbusqueda()
        {
            if (cbxtipoFecha.Text == "" || dtpFechaInicio.Text == "" || dtpFechaFin.Text == "")
            {
                MessageBox.Show("Seleccione una fecha", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }



    }
}
