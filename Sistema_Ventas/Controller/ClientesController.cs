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
                _logger.Error(ex, "error al inicializar el controlador de estudiantes");
                throw;
            }
        }
        public List<Cliente> ObtenerEstudiantes(bool Activo = true)
        {
            try
            {
                List<Cliente> estudiantes = _clientesData.ObtenerClientes(Activo);
                _logger.Info($"Se obtuvieron {estudiantes.Count} estudiantes");
                return estudiantes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de estudiantes");
                throw;
            }
        }

    }
}
