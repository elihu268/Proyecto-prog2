using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Utilities;
using NLog;
using System.Reflection.Metadata.Ecma335;
using Sistema_VentasCore.Bussines;
using System.Data;
using System.Net.NetworkInformation;
using OfficeOpenXml;

namespace Sistema_VentasCore.Controller
{
    public class ProductosController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.ProductosCrontoller");
        private readonly ProductosDataAccess _productosData;

        public ProductosController()
        {
            try
            {
                _productosData = new ProductosDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de productos");
                throw;
            }
        }
        public List<Producto> ObtenerProductos()
        {
            try
            {
                List<Producto> productos = _productosData.ObtenerProductos();
                _logger.Info($"Se obtuvieron {productos.Count} Productos");
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de productos");
                throw;
            }
        }
        public List<Producto> ObtenerProductoPorNombre(String nombreprd)
        {
            try
            {
                List<Producto> productos = _productosData.ObtenerProductoPorNombre(nombreprd);
                _logger.Info($"Se obtuvieron {productos.Count} Productos");
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener la lista de productos con el nombre:{nombreprd} ");
                throw;
            }
        }
        public int ObtenerExistenciaDeProducto(String codigo){
            try
            {
                int existencia = _productosData.ObtenerExistenciaPorCodigo(codigo);
                
                return existencia;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al existencia del producto :{codigo} ");
                throw;
            }
        }
        public void ModificarStcok(String cantidad,Producto producto)
        {
            try
            {
                producto.Existencia=CompraNegocio.CalcularStock(cantidad, producto.Existencia);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al modicficar el stock del producto: "+producto.IdProducto);
                throw;
            }
        }

        public bool ExportarProductosExcel(string rutaArchivo)
        {
            try
            {
                var productos = ObtenerProductos();
                if (productos == null || productos.Count==0)
                {
                    _logger.Warn("No hay productos para exportar");
                    return false;
                }
                using (var package = new ExcelPackage())
                { //Crea una hoja de trabajo
                    var worksheet = package.Workbook.Worksheets.Add("Catalogo");

                    //Establecer encabezados
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Codigo";
                    worksheet.Cells[1, 3].Value = "Nombre";
                    worksheet.Cells[1, 4].Value = "Precio";
                    worksheet.Cells[1, 5].Value = "Descripcion";
                    worksheet.Cells[1, 6].Value = "Existencia";

                    using (var range = worksheet.Cells[1, 1, 1, 6])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    //llenar los datos
                    int row = 2;//se va a colocar en la siguiente fila
                    foreach (var producto in productos)
                    {
                        worksheet.Cells[row, 1].Value = producto.IdProducto;
                        worksheet.Cells[row, 2].Value = producto.Codigo;
                        worksheet.Cells[row, 3].Value = producto.Nombre;
                        worksheet.Cells[row, 4].Value = producto.Precio;
                        worksheet.Cells[row, 5].Value = producto.Descripcion;
                        worksheet.Cells[row, 6].Value = producto.Existencia;

                        worksheet.Cells[row, 4].Style.Numberformat.Format = "$#,##0.00";
                        row++;
                    }

                    //Ajustar el ancho de las columnas
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    //Guardar el archivo 
                    FileInfo fileInfo = new FileInfo(rutaArchivo);
                    package.SaveAs(fileInfo);

                    _logger.Info($"Archivo Excel exportado correctamente: {rutaArchivo}");
                    return true;
                }

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al exportar productos a Excel");
                throw;
            }
        }

    }
}
