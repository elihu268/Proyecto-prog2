using Sistema_VentasCore.Controller;
using Sistema_VentasCore.Model;
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
using static Sistema_VentasCore.Bussines.ClientesNegocio;
using Sistema_VentasCore.Utilities;

namespace Sistema_Ventas.View
{
    public partial class frmCargaCatalogo : Form
    {
        public frmCargaCatalogo(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);

        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            if (!Sesión.TienePermiso("CATALOG_UPLOAD"))
            {
                btnCargaCatalogo.Visible = false;
            }
            CargarCatalogo();
        }

        private void btnCargaCatalogo_Click(object sender, EventArgs e)
        {
            ofdCatalogo.Title = "Seleccionar archivo CSV";
            ofdCatalogo.Filter = "Archivo CSV (*.csv)|*.csv"; // Solo busca archivos CSV
            ofdCatalogo.InitialDirectory = "C:\\"; // Carpeta inicial
            ofdCatalogo.FilterIndex = 1; // Selecciona el primer filtro por defecto
            ofdCatalogo.RestoreDirectory = true;

            if (ofdCatalogo.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdCatalogo.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".csv")
                {
                    MessageBox.Show("Archivo válido: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un archivo CSV válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CargarCatalogo()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ProductosController productoController = new ProductosController();

                List<Producto> productos = productoController.ObtenerProductos();

                // Delegar toda la lógica de presentación a ConfigurarDataGridView
                ConfigurarDataGridView(productos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos. Contacta al administrador del sistema",
                    "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Cursor = Cursors.Default;
            }
        }


        private void ConfigurarDataGridView(List<Producto> productos)
        {
            dgvCatalogo.DataSource = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descripcion", typeof(string));

            foreach (Producto prd in productos)
            {
                dt.Rows.Add(
                    prd.IdProducto,
                    prd.Codigo,
                    prd.Nombre,
                    prd.Precio,
                    prd.Descripcion,
                    prd.Existencia
                );
            }

            dgvCatalogo.DataSource = dt;

            // Configuraciones visuales
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.Columns["ID"].Visible = false;
            dgvCatalogo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvCatalogo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCatalogo.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCatalogo.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCatalogo.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCatalogo.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dgvCatalogo.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvCatalogo.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvCatalogo.EnableHeadersVisualStyles = false;
            dgvCatalogo.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvCatalogo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCatalogo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvCatalogo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCatalogo.ScrollBars = ScrollBars.Both;
        }
        public void ImportarExcelCatalogo()
        {
            try
            {
                ProductosController productosController = new ProductosController();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo de Excel";
                    saveFileDialog.FileName = $"Catalogo_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)//Espera confirmacion
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        // Exportar usando el método del controlador
                        bool resultado = productosController.ExportarProductosExcel(saveFileDialog.FileName);

                        // Restaurar cursor normal
                        Cursor.Current = Cursors.Default;

                        if (resultado)
                        {
                            MessageBox.Show("Archivo Excel exportado correctamente",
                                            "Éxito",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Preguntar si desea abrir el archivo
                            DialogResult abrirArchivo = MessageBox.Show(
                                            "¿Desea abrir el archivo Excel generado?",
                                            "Abrir archivo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                            if (abrirArchivo == DialogResult.Yes)
                            {
                                // Usar ProcessStartInfo para abrir el archivo con la aplicación asociada
                                var startInfo = new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = saveFileDialog.FileName,
                                    UseShellExecute = true
                                };
                                System.Diagnostics.Process.Start(startInfo);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron productos para exportar",
                                            "Información",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCatalogo();
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            ImportarExcelCatalogo();
        }
    }
}
