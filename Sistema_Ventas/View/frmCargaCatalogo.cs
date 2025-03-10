using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.View
{
    public partial class frmCargaCatalogo : Form
    {
        public frmCargaCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnCargaCatalogo_Click(object sender, EventArgs e)
        {
            ofdCatalogo.Title = "Seleccionar archivo separado por comas(CSV)";
            ofdCatalogo.Filter = "Archivo separado por comas *.csv";
            ofdCatalogo.InitialDirectory = "C:\\";
            ofdCatalogo.FilterIndex = 1;

            if (ofdCatalogo.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdCatalogo.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".csv")
                {
                    MessageBox.Show("Archivo valido: " + filePath, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un archivo de Excel valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
