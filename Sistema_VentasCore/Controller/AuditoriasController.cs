using NLog;
using OfficeOpenXml;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Controller
{
    public class AuditoriaController
    {
        private static readonly Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly AuditoriaDataAccess _auditoriaDataAccess;

        public AuditoriaController()
        {
            try
            {
                _auditoriaDataAccess = new AuditoriaDataAccess();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al inicializar AuditoriaController: " + ex.Message);
                throw;
            }
        }
        public List<Auditoria> ObtenerAuditorias()
        {
            try
            {
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditorias();
                _logger.Info("Auditorías obtenidas: {0}", auditorias.Count);
                return auditorias;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener auditorías: " + ex.Message);
                throw;
            }
        }


        public void AudioriaAdd(Auditoria auditoria)
        {
            try
            {
                _auditoriaDataAccess.AuditoriaAdd(auditoria);
                _logger.Info("Auditoría agregada: {0}", auditoria.ToString());
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al agregar auditoría: " + ex.Message);
                throw;
            }
        }
        public List<Auditoria> ObtenerAuditoriasBusqueda(string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            try
            {
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditoriasBusqueda(nombre, fechaInicio, fechaFin);
                _logger.Info("Auditorías obtenidas por búsqueda: {0}", auditorias.Count);
                return auditorias;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener auditorías por búsqueda: " + ex.Message);
                throw;
            }
        }
        public (bool resul, int msg) ExportarAuditoriasExcel(string ruta, string nombre, DateTime? fechaInicio, DateTime? fechaFin)
        {
            try
            {
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditoriasBusqueda(nombre, fechaInicio, fechaFin);
                if (auditorias.Count == 0)
                {
                    return (false, 0);
                }
                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Auditorías");
                    int row = 1;
                    worksheet.Cells[row, 1].Value = "Nombre Completo";
                    worksheet.Cells[row, 2].Value = "Correo";
                    worksheet.Cells[row, 3].Value = "Acción";
                    worksheet.Cells[row, 4].Value = "Fecha";
                    worksheet.Cells[row, 5].Value = "IP Acceso";
                    worksheet.Cells[row, 6].Value = "Nombre del Equipo";
                    worksheet.Cells[row, 7].Value = "Tipo";
                    worksheet.Cells[row, 8].Value = "Movimiento";

                    using(var range = worksheet.Cells[row, 1, row, 9])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }
                    row++;
                    foreach (var  auditoria in auditorias)
                    {
                       
                        worksheet.Cells[row, 1].Value = auditoria.NombreCompleto;
                        worksheet.Cells[row, 2].Value = auditoria.Cuenta;
                        worksheet.Cells[row, 3].Value = auditoria.Accion;
                        worksheet.Cells[row, 4].Value = auditoria.Fecha.ToString("dd/MM/yyyy HH:mm:ss");
                        worksheet.Cells[row, 5].Value = auditoria.IpAcceso;
                        worksheet.Cells[row, 6].Value = auditoria.NombreEquipo;
                        worksheet.Cells[row, 7].Value = auditoria.Tipo;
                        worksheet.Cells[row, 8].Value = auditoria.Movimiento;
                        row++;
                    }
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    FileInfo file = new FileInfo(ruta);
                    package.SaveAs(file);
                    _logger.Info("Archivo Excel guardado en: {0}", file.FullName);
                    return (true, 1);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al exportar auditorías a Excel: " + ex.Message);
                throw;

            }
        }
    }
}

    

