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
        public List<Cliente> ObtenerEstudiantes(bool Ativo = true)
        {

            try
            {
                //variable var: no tienen un tipo definido, una variable tipo comodin
                var clientes = _clientesData.ObtenerClientes(Ativo);
                _logger.Info($"se obtuvieron {clientes.Count} clientes");
                return clientes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de estudiantes");
                throw;
            }
        }
    }
}
