using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ventas.Bussines;
using static Sistema_Ventas.Bussines.Negocio;

namespace Sistema_Ventas.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        /// <summary>
        /// valida informacion y dirige la MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
            {
                MessageBox.Show("El campo de usuario no puede estar vacio.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacio.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UsuariosNegocio.EsFormatoValido(txt_usuario.Text))
            {
                MessageBox.Show("El nombre del usuario no tiene el formato correcto", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //  MessageBox.Show("Listo para iniciar sesion", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// cierra ventana de incio de secion, cierra todo el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
