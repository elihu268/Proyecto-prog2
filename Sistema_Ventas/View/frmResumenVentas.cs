using Sistema_Ventas.Utilities;
using Sistema_VentasCore.Service;
using Sistema_VentasCore.Utilities;
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
    public partial class frmResumenVentas : Form
    {
        private readonly ApiService _apiService;
        public frmResumenVentas(Form parent)
        {
            InitializeComponent();
            _apiService = new ApiService();
            Formas.InicializarForma(this, parent);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void Consulta()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(txtBusqueda.Text))
                {
                    MessageBox.Show("Por favor, ingrese un filtro para la consulta.");
                    return;
                }
                var existencias = await _apiService.GetExistencia(txtBusqueda.Text);

                // Mostrar resultados
                lblprueba.Text = $"Total de existencias: {existencias}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar estudiantes: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
    }
}
