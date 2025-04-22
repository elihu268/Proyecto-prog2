using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using NLog;

namespace Sistema_Ventas.Controller
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







    }
}
