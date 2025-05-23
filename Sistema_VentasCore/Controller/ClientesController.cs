using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Utilities;
using NLog;
using System.Data;
using System.Runtime.CompilerServices;
using Npgsql;
using OfficeOpenXml;

namespace Sistema_VentasCore.Controller
{
    public class ClientesController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.ClientesController");
        private readonly ClientesDataAccess _clientesData;
        private readonly PersonasDataAccess _personasData;

        public ClientesController()
        {
            try
            {
                _clientesData = new ClientesDataAccess();
                _personasData = new PersonasDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de clientes");
                throw;
            }
        }

        public List<Cliente> ObtenerClientes(int Activo = 1)
        {
            try
            {
                List<Cliente> clientes = _clientesData.ObtenerClientes(Activo);
                _logger.Info($"Se obtuvieron {clientes.Count} ");
                return clientes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de clientes");
                throw;
            }
        }

        public DataTable ObtenerClientes( DateTime? fechaInicial, DateTime? fechaFinal, bool soloActivos)
        {
            try
            {
                DataTable clientes = _clientesData.ObtenerClientesFiltrados(fechaInicial, fechaFinal, soloActivos);
                _logger.Info($"Se obtuvieron {clientes.Rows.Count} ");
                return clientes;
            }
            catch (Exception ex)
            {

                _logger.Error(ex, "Error al obtener la lista de clientes");
                throw;
            }
        }

        public Cliente ObtenerClientePorId(int id)
        {
            try
            {
                Cliente cliente = _clientesData.ObtenerClientePorId(id);
                _logger.Info($"Se obtuvo el cliente con ID: {cliente.Id}");
                return cliente;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener el cliente por ID");
                throw;
            }
        }

        public List<Cliente> ObtenerClientePorNombre(string nombrecli, DateTime? fechaInicio, DateTime? fechaFin, bool? estado)
        {
            try
            {
                // Llamada a la capa de datos
                List<Cliente> clientes = _clientesData.ObtenerClientePorNombre(nombrecli, fechaInicio, fechaFin, estado);

                // Log de la consulta
                _logger.Info($"Se obtuvieron {clientes.Count} clientes con el nombre '{nombrecli}' entre {fechaInicio:dd/MM/yyyy} y {fechaFin:dd/MM/yyyy}, usando tipo de estado {estado}");

                return clientes;
            }
            catch (Exception ex)
            {
                // Log de error
                _logger.Error(ex, $"Error al obtener la lista de clientes con el nombre '{nombrecli}' y rango de fechas");
                throw;
            }
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                _logger.Info($"Actualizando cliente con ID: {cliente.Id}");
                bool resultado = _clientesData.ActualizarCliente(cliente);
                if (!resultado)
                {
                    _logger.Error($"Error al actualizar el cliente con ID: {cliente.Id}");
                    return false;
                }
                _logger.Info($"Cliente actualizado exitosamente con ID: {cliente.Id}");
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar el cliente");
                throw;
            }
        }

        public (int id, string mensaje) RegistrarCliente(Cliente cliente)
        {
            try
            {
                if (_clientesData.ExisteRfc(cliente.Rfc))
                {
                    _logger.Warn($"Intento de registrar el cliente con RFC duplicado: {cliente.Rfc}");
                    return (-2, $"El RFC {cliente.Rfc} ya esta registrado en el sistema");
                }

                _logger.Info($"Registrando nuevo cliente {cliente.DatosPersonales.NombreCompleto}, RFC: {cliente.Rfc}");
                int idCliente = _clientesData.InsertarCliente(cliente);

                if (idCliente <= 0)
                {
                    return (-3, "Error al registrar al cliente en la base de datos");
                }

                _logger.Info($"Cliente registrado exitosamente con ID: {idCliente}");
                return (idCliente, "Cliente registrado exitosamente");
            }
            catch (Exception ex)
            {
                _logger.Error($"Error al registrar al cliente: {cliente.DatosPersonales?.NombreCompleto ?? "Sin nombre"}, RFC: {cliente.Rfc}");
                return (-4, $"Error inesperado: {ex.Message}");
            }
        }

        public bool ExportarClientesExcel(string rutaArchivo, bool estatus, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            try
            {
                DataTable tablaClientes = ObtenerClientes(fechaInicio, fechaFin, estatus);
                List<Cliente> clientes = ConvertirDataTableAClientes(tablaClientes);


                if (clientes == null)
                {
                    _logger.Warn("No hay clientes para exportar");
                    return false;
                }

                using (var package = new ExcelPackage())
                { //Crea una hoja de trabajo
                    var worksheet = package.Workbook.Worksheets.Add("Clientes");

                    //Establecer encabezados
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "RFC";
                    worksheet.Cells[1, 3].Value = "Nombre Completo";
                    worksheet.Cells[1, 4].Value = "Tipo";
                    worksheet.Cells[1, 5].Value = "Correo";
                    worksheet.Cells[1, 6].Value = "Teléfono";
                    worksheet.Cells[1, 7].Value = "Fecha de Nacimiento";
                    worksheet.Cells[1, 8].Value = "Fecha de Registro";
                    worksheet.Cells[1, 9].Value = "Estatus";

                    using (var range = worksheet.Cells[1, 1, 1, 9])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    //llenar los datos
                    int row = 2;//se va a colocar en la siguiente fila
                    foreach (var cliente in clientes)
                    {
                        worksheet.Cells[row, 1].Value = cliente.Id;
                        worksheet.Cells[row, 2].Value = cliente.Rfc;
                        worksheet.Cells[row, 3].Value = cliente.DatosPersonales.NombreCompleto;
                        worksheet.Cells[row, 4].Value = cliente.DescripcionTipo;
                        worksheet.Cells[row, 5].Value = cliente.DatosPersonales.Correo;
                        worksheet.Cells[row, 6].Value = cliente.DatosPersonales.Telefono;
                        worksheet.Cells[row, 7].Value = cliente.DatosPersonales.FechaNacimiento;
                        worksheet.Cells[row, 8].Value = cliente.FechaRegistro;
                        worksheet.Cells[row, 9].Value = cliente.DatosPersonales.DescripcionEstatus;

                        //Aplicar formato a las fechas
                        if (cliente.DatosPersonales.FechaNacimiento.HasValue)
                        {
                            worksheet.Cells[row, 7].Style.Numberformat.Format = "dd/MM/yyyy";
                        }
                        worksheet.Cells[row, 8].Style.Numberformat.Format = "dd/MM/yyyy";
                        
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
                _logger.Error(ex, "Error al exportar clientes a Excel");
                throw;
            }
        }
        public List<Cliente> ConvertirDataTableAClientes(DataTable tabla)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                var persona = new Persona
                {
                    NombreCompleto = row["Nombre Completo"].ToString(),
                    Correo = row["Correo"].ToString(),
                    Telefono = row["Teléfono"].ToString(),
                    FechaNacimiento = row["Fecha Nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["Fecha Nacimiento"]) : null,
                    Estatus = row["Estatus"].ToString() == "Activo"
                };

                Cliente cliente = new Cliente
                {
                    Id = Convert.ToInt32(row["ID"]),
                    Rfc = row["RFC"].ToString(),
                    Tipo = row["Tipo"].ToString() == "Físico" ? 1 : 2, // Ajusta si tienes más valores
                    FechaRegistro = Convert.ToDateTime(row["Fecha de Registro"]),
                    DatosPersonales = persona
                };

                clientes.Add(cliente);
            }

            return clientes;
        }

    }
}
