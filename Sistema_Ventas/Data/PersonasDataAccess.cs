using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using NLog;
namespace Sistema_Ventas.Data
{
    public class PersonasDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger(" Sistema_Ventas.Data.PersonasDataAccess");
        //instancia del acceso a datos postgree
        private readonly PostgreSQLDataAccess _dbAccess;
        //contructor
        public PersonasDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar PersonasDataAccess");
                throw;
            }
        }
        public int InsertarPersona(Persona persona)
        {
            try
            {
                string query = "INSERT INTO personas (nombre_completo, correo, telefono, fecha_nacimiento, estatus) " +
"VALUES (@NombreCompleto, @Correo, @Telefono, @FechaNacimiento, @Estatus) " +
"RETURNING id_persona";
                //crear parametros
                NpgsqlParameter paramNombre = _dbAccess.CreateParameter("@NombreCompleto", persona.NombreCompleto);
                NpgsqlParameter paramCorreo = _dbAccess.CreateParameter("@Correo", persona.Correo);
                NpgsqlParameter paramTelefono = _dbAccess.CreateParameter("@Telefono", persona.Telefono);
                NpgsqlParameter paramFechaNac = _dbAccess.CreateParameter("@FechaNacimiento", persona.FechaNacimiento);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", persona.Estatus);
                //establecer conexion
                _dbAccess.Connect();
                //ejecutar insercion y obtiene id generado(scalar sdolo se afceta uno)
                object? resultado = _dbAccess.ExecuteScalar(query, paramNombre, paramCorreo, paramTelefono, paramFechaNac, paramEstatus);
                //resultado a entero
                int idGenerado = Convert.ToInt32(resultado);
                _logger.Info($"persona insertada correctamente con ID{idGenerado}");
                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"error al insertar persona{persona.NombreCompleto}");
                return -1;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}
