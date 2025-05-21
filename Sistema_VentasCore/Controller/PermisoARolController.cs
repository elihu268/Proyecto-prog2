using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Utilities;
using NLog;
using Npgsql;
using Sistema_VentasCore.Model;
using System.Security.Cryptography;
using OfficeOpenXml;
using System.Globalization;

namespace Sistema_VentasCore.Controller
{
    public class PermisoARolController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.PermisoARolDataAccess");
        private readonly PermisoARolDataAccess _permisoARolData;
        private readonly UsuariosController _usuariosController;
        public PermisoARolController()
        {
            try
            {
                _permisoARolData = new PermisoARolDataAccess();
                _usuariosController = new UsuariosController();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de permisos a rol");
                throw;
            }
        }
        //asignar permiso

        public void AsignarPermisosARol(int idRol, List<int> permisos)
        {
            try
            {
                _permisoARolData.EliminarPermisosDeRol(idRol);//primero elimina los permisos que tenia, para que no se repitan
                foreach (int idPermiso in permisos) {
                    _permisoARolData.AgregarPermisoARol(idRol, idPermiso);

                    _logger.Debug($"se asigno el permiso{idPermiso} al rol: " + idRol);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"error al asignar permisos al rol: "+ idRol);
                throw;
            }
        }
        
        public List<int> ObtenerIdsPermisosPorRol(int idRol)
        {
            try
            {
                // 1. Eliminar todos los permisos actuales del puesto
                
                List<int> listaPermisos= _permisoARolData.ObtenerIdsPermisosPorRol(idRol);
                
                _logger.Debug($"se obtuvo la lista de permisos del rol: {idRol}");
                return listaPermisos;
            }
            catch (Exception ex)
            {
                _logger.Error($"no se pudo obtener la lista de permisos del rol: {idRol},{ex}");
                return null;
            }
        }
        public (bool bandera, int msj) ExportarUsuariosPorRolExcel(string rutaArchivo, int idRol, string nombreRol)
        {
            try
            {
                List<Permiso> permisos = _permisoARolData.ObtenerPermisosPorRol(idRol);
                List<Usuario> usuarios = _usuariosController.ObtenerUsuariosPorRol(idRol);

                if (usuarios == null || usuarios.Count == 0)
                {
                    _logger.Warn($"No hay usuarios con el rol: {idRol}");
                    return (false, 0); // 0: sin usuarios
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Usuarios");

                    int row = 1;

                    // Encabezado del rol
                    worksheet.Cells[row, 1].Value = "Rol:";
                    worksheet.Cells[row, 2].Value = nombreRol;
                    worksheet.Cells[row, 1, row, 2].Style.Font.Bold = true;
                    row += 2;

       
                    // Encabezados de usuarios
                    worksheet.Cells[row, 1].Value = "Nombre Usuario";
                    worksheet.Cells[row, 2].Value = "Correo";
                    worksheet.Cells[row, 3].Value = "Teléfono";

                    using (var range = worksheet.Cells[row, 1, row, 3])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    row++;

                    foreach (var usuario in usuarios)
                    {
                        worksheet.Cells[row, 1].Value = usuario.DatosPersonales.NombreCompleto;
                        worksheet.Cells[row, 2].Value = usuario.DatosPersonales.Correo;
                        worksheet.Cells[row, 3].Value = usuario.DatosPersonales.Telefono;
                        row++;
                    }
                    row++; // línea vacía
                    // Permisos asignados
                    row = 1;
                    worksheet.Cells[row, 5].Value = "Permisos asignados:";
                    worksheet.Cells[row, 5].Style.Font.Bold = true;
                    row++;

                    foreach (var permiso in permisos)
                    {
                        worksheet.Cells[row, 5].Value = permiso.Codigo;
                        //worksheet.Cells[row, 2].Value = permiso.Descripcion;
                        row++;
                    }
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    FileInfo fileInfo = new FileInfo(rutaArchivo);
                    package.SaveAs(fileInfo);

                    _logger.Info($"Archivo Excel exportado correctamente: {rutaArchivo}");
                    return (true, 1); // 1: éxito
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al exportar usuarios del rol {idRol} a Excel");
                throw ex;
            }
        }



    }
}
