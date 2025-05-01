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

namespace PuntodeVenta.View
{
    public partial class frmAuditoria: Form
    {
        public frmAuditoria(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }
        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar datos en el DataGridView
                // dataGridView1.DataSource = auditoriaController.ObtenerAuditorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditorías: " + ex.Message);
            }
        }

               private void CargarAditorias()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                AuditoriaController auditoriaController = new AuditoriaController();
                List<Auditoria> auditorias = auditoriaController.ObtenerAuditorias();
                dgvAuditorias.DataSource = null;
                if (auditorias.Count == 0)
                {
                    if (!string.IsNullOrEmpty(txtBusqueda.Text))
                    {
                        MessageBox.Show("No se encontraron resultados para la busqueda", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Rol", typeof(string));

                //llenado de la tabla
                foreach (Auditoria auditoria in auditorias)
                {
                    dt.Rows.Add(
                        auditoria.Accion,
                        auditoria.Tipo,
                        auditoria.UsuarioId,
                        auditoria.IdMovimiento,
                        auditoria.IpAcceso,
                        auditoria.NombreEquipo
                        );
                }
                dgvAuditorias.DataSource = dt;

                ConfigurarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los auditorias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void ConfigurarDGV()
        {
            dgvAuditorias.AllowUserToAddRows = false;
            dgvAuditorias.AllowUserToDeleteRows = false;
            dgvAuditorias.ReadOnly = true;

            // Ajustar el ancho de las columnas
            dgvAuditorias.Columns["Nombre Completo"].Width = 200;
            dgvAuditorias.Columns["Correo"].Width = 180;
            dgvAuditorias.Columns["Teléfono"].Width = 120;
            dgvAuditorias.Columns["Fecha Nacimiento"].Width = 120;
            dgvAuditorias.Columns["Estatus"].Width = 100;

            // Ocultar columna ID si es necesario
            dgvAuditorias.Columns["ID"].Visible = false;

            // Formato para las fechas
            dgvAuditorias.Columns["Fecha Nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            dgvAuditorias.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAuditorias.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Color alternado de filas
            dgvAuditorias.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección de fila completa
            dgvAuditorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Estilo de cabeceras
            dgvAuditorias.EnableHeadersVisualStyles = false;
            dgvAuditorias.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvAuditorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAuditorias.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAuditorias.Font, FontStyle.Bold);
            dgvAuditorias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ordenar al hacer clic en el encabezado
            dgvAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        }
    }
    }
