using Sistema_Ventas.Controller;
using Sistema_Ventas.Model;
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
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using Sistema_Ventas.Controller;

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
            dt.Columns.Add("Existencia", typeof(int));
            dt.Columns.Add("Estatus", typeof(string)); // Incluimos "Estatus"




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
            dgvCatalogo.Columns["Existencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCatalogo.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;











            



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







        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCatalogo();
        }
    }
}
