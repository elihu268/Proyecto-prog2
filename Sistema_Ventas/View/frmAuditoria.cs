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

namespace PuntodeVenta.View
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }
        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            CargarAuditorias();

        }

        private void CargarAuditorias()
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
                // Definición de columnas
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Nombre Completo", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Accion", typeof(string));
                dt.Columns.Add("Fecha", typeof(string));
                dt.Columns.Add("Ip Accesso", typeof(string));
                dt.Columns.Add("Nombre del Equipo", typeof(string));
                dt.Columns.Add("Tipo", typeof(string));
                dt.Columns.Add("Movimiento", typeof(string));
                //llenado de la tabla
                foreach (Auditoria auditoria in auditorias)
                {
                    dt.Rows.Add(
                        auditoria.Id,
                        auditoria.NombreCompleto,
                        auditoria.Cuenta,
                        auditoria.Accion,
                        auditoria.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                        auditoria.IpAcceso,
                        auditoria.NombreEquipo,
                        auditoria.Tipo,
                        auditoria.Movimiento ?? auditoria.IdMovimiento.ToString()
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
            dgvAuditorias.Columns["ID"].Width = 50;
            dgvAuditorias.Columns["Nombre Completo"].Width = 200;
            dgvAuditorias.Columns["Correo"].Width = 200;
            dgvAuditorias.Columns["Accion"].Width = 150;
            dgvAuditorias.Columns["Fecha"].Width = 120;
            dgvAuditorias.Columns["Ip Accesso"].Width = 120;
            dgvAuditorias.Columns["Nombre del Equipo"].Width = 200;
            dgvAuditorias.Columns["Tipo"].Width = 100;
            dgvAuditorias.Columns["Movimiento"].Width = 180;


            // Ocultar columna ID si es necesario
            dgvAuditorias.Columns["ID"].Visible = false;
            dgvAuditorias.Columns["Tipo"].Visible = false;
            //dgvAuditorias.Columns["Movimiento"].Visible = false;
            ///dgvAuditorias.Columns[""].Visible = false;


            // Formato para las fechas
            dgvAuditorias.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Alineación
            // dgvAuditorias.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // dgvAuditorias.Columns["Estatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

        private void frmAuditoria_Load_1(object sender, EventArgs e)
        {
            CargarAuditorias();
            dtpFechaInicio.Value = DateTime.Now.AddDays(-1);
            //txtBusqueda.Visible = false;
        }

        private void btnBuscarAuditoria_Click(object sender, EventArgs e)
        {
            ObtenerAuditoriasBusqueda();
        }

        public void ObtenerAuditoriasBusqueda()
        {

            try
            {
                Cursor = Cursors.WaitCursor;
                string nombre = string.IsNullOrWhiteSpace(txtBusqueda.Text) ? "" : txtBusqueda.Text.ToLower();
                DateTime? fechaInicio = dtpFechaInicio.Value;
                DateTime? fechaFin = dtpFechaFin.Value;

                AuditoriaController auditoriaController = new AuditoriaController();
                List<Auditoria> auditorias = auditoriaController.ObtenerAuditoriasBusqueda(nombre, fechaInicio, fechaFin);
                if (auditorias.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para la busqueda", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ConfigurarBusquedaAuditorias(auditorias);
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
        private void ConfigurarBusquedaAuditorias(List<Auditoria> auditorias)
        {
            dgvAuditorias.DataSource = null;
            DataTable dt = new DataTable();
            // Definición de columnas
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre Completo", typeof(string));
            dt.Columns.Add("Correo", typeof(string));
            dt.Columns.Add("Accion", typeof(string));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Ip Accesso", typeof(string));
            dt.Columns.Add("Nombre del Equipo", typeof(string));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("Movimiento", typeof(string));
            //llenado de la tabla
            foreach (Auditoria auditoria in auditorias)
            {
                dt.Rows.Add(
                    auditoria.Id,
                    auditoria.NombreCompleto,
                    auditoria.Cuenta,
                    auditoria.Accion,
                    auditoria.Fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    auditoria.IpAcceso,
                    auditoria.NombreEquipo,
                    auditoria.Tipo,
                    auditoria.Movimiento ?? auditoria.IdMovimiento.ToString()
                    );
            }
            dgvAuditorias.DataSource = dt;
            ConfigurarDGV();
        }
        public void ExportarExcel()
        {
            try
            {
                DateTime inicio = dtpFechaInicio.Value;
                DateTime fin = dtpFechaFin.Value;
                string nombre = string.IsNullOrWhiteSpace(txtBusqueda.Text) ? "" : txtBusqueda.Text.ToLower();

                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    save.Title = "Guardar archivo de auditoría";
                    save.FileName = $"Auditorias_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                    save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string ruta = save.FileName;
                        AuditoriaController auditoriaController = new AuditoriaController();
                        var (exito, msg) = auditoriaController.ExportarAuditoriasExcel(ruta, nombre, inicio, fin);
                        if (exito && msg == 1)
                        {
                            MessageBox.Show("Exportación exitosa", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult abrir = MessageBox.Show("¿Desea abrir el archivo exportado?", "Información del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (abrir == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = save.FileName,
                                    UseShellExecute = true
                                });
                            }
                        }
                        else if (exito && msg == 0)
                        {
                            MessageBox.Show("No se encontraron resultados para la busqueda", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Error al exportar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }
    }
}
