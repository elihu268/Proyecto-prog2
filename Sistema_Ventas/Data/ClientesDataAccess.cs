using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
using Npgsql;
using System.Data;

namespace Sistema_Ventas.Data
{
    public class ClientesDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.ClientesDataAccess");
        /// 
        private readonly PostgreSQLDataAccess _dbAccess;

        private readonly PersonasDataAccess _personasData;

        public ClientesDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
               _personasData = new PersonasDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar ClienteDataAccess");
                throw;
            }
        }

        public List<Cliente> ObtenerClientes(int Activos)
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = @"
                   SELECT 
                    c.id_cliente,
                    c.id_persona,
                    p.nombre_completo,
                    p.correo,
                    p.telefono,
                    p.fecha_nacimiento,
                    c.fecha_registro,
                    c.rfc,
                    c.tipo,
                p.estatus AS estatus_persona
                FROM  cliente c
                JOIN  personas p ON c.id_persona = p.id_persona
                WHERE  1 = 1 
                ";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                if (Activos == 2)
                {
                    query += " AND p.estatus = @estatus ";
                    parametros.Add(new NpgsqlParameter("@estatus", 2));
                }
                query += "\nORDER BY c.id_cliente";
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                foreach (DataRow row in resultado.Rows)
                {
                    //es el reglon de una tabla el resultado: por cada row recorrer, forecah de reglones de datatable
                    Persona persona = new Persona(//crear una persona, de acuerdo al constructor todos sus datos
                    Convert.ToInt32(row["id_persona"]),
                        row["nombre_completo"].ToString() ?? "",
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                         Convert.ToBoolean(row["estatus_persona"])
                        );

                    //crear el objeto cliente
                    Cliente cliente = new Cliente(
                  Convert.ToInt32(row["id_cliente"]),
                  Convert.ToInt32(row["id_persona"]),
                  Convert.ToInt32(row["tipo"]),
                  Convert.ToDateTime(row["fecha_registro"]),
                      row["rfc"].ToString() ?? "",
                      persona
                       );
                    clientes.Add(cliente);
                }
                _logger.Debug($"Se obtuvieron{clientes.Count} resgistros de clientes");
                return clientes;
            }
            catch (Exception ex)
            {
                //logear error
                _logger.Error(ex, "Error al obtener informacion de los clientes de la base de datos");
                _logger.Error(ex.ToString());
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();//asegura cierre de la conexion
            }
        }

        public DataTable ObtenerClientesFiltrados(int tipoFecha, DateTime fechaInicial, DateTime fechaFinal, string busqueda, int soloActivos)
        {
            DataTable clientesDataTable = new DataTable();
            try
            {
                string query = @"
                   SELECT 
                        c.id_cliente,
                        c.id_persona,
                        p.nombre_completo,
                        p.correo,
                        p.telefono,
                        p.fecha_nacimiento,
                        c.fecha_registro,
                        c.rfc,
                        c.tipo,
                    p.estatus AS estatus_persona
                    FROM  cliente c
                    JOIN  personas p ON c.id_persona = p.id_persona
                    WHERE  1 = 1 
                    ";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                if (soloActivos == 1)
                {
                    query += " AND p.estatus = @estatus ";
                    parametros.Add(new NpgsqlParameter("@estatus", true));
                }

                if (tipoFecha == 1) // Nacimiento
                {
                    query += " AND p.fecha_nacimiento BETWEEN @FechaInicial AND @FechaFinal ";
                    parametros.Add(new NpgsqlParameter("@FechaInicial", fechaInicial));
                    parametros.Add(new NpgsqlParameter("@FechaFinal", fechaFinal));
                }
                else if (tipoFecha == 2) // Alta
                {
                    query += " AND c.fecha_registro BETWEEN @FechaInicial AND @FechaFinal ";
                    parametros.Add(new NpgsqlParameter("@FechaInicial", fechaInicial));
                    parametros.Add(new NpgsqlParameter("@FechaFinal", fechaFinal));
                }
                else if (tipoFecha == 3) // Baja
                {
                    query += " AND p.fecha_baja BETWEEN @FechaInicial AND @FechaFinal ";
                    parametros.Add(new NpgsqlParameter("@FechaInicial", fechaInicial));
                    parametros.Add(new NpgsqlParameter("@FechaFinal", fechaFinal));
                }

                if (!string.IsNullOrEmpty(busqueda))
                {
                    query += " AND (p.nombre_completo ILIKE @Busqueda OR c.rfc ILIKE @Busqueda OR p.correo ILIKE @Busqueda) ";
                    parametros.Add(new NpgsqlParameter("@Busqueda", "%" + busqueda + "%"));
                }

                query += "\nORDER BY c.id_cliente";
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                // Asignar las columnas del DataTable
                clientesDataTable.Columns.Add("ID", typeof(int));
                clientesDataTable.Columns.Add("RFC", typeof(string));
                clientesDataTable.Columns.Add("Nombre Completo", typeof(string));
                clientesDataTable.Columns.Add("Tipo", typeof(string));
                clientesDataTable.Columns.Add("Correo", typeof(string));
                clientesDataTable.Columns.Add("Teléfono", typeof(string));
                clientesDataTable.Columns.Add("Fecha Nacimiento", typeof(DateTime));
                clientesDataTable.Columns.Add("Fecha de Registro", typeof(DateTime));
                clientesDataTable.Columns.Add("Estatus", typeof(string));

                // Llenar el DataTable con los resultados de la consulta
                foreach (DataRow row in resultado.Rows)
                {
                    clientesDataTable.Rows.Add(
                        Convert.ToInt32(row["id_cliente"]),
                        row["rfc"].ToString() ?? "",
                        row["nombre_completo"].ToString() ?? "",
                        row["tipo"].ToString(),
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                        Convert.ToDateTime(row["fecha_registro"]),
                        row["estatus_persona"] != DBNull.Value && Convert.ToBoolean(row["estatus_persona"]) ? "Activo" : "Inactivo"
                    );
                }

                _logger.Debug($"Se obtuvieron {clientesDataTable.Rows.Count} registros de clientes");
                return clientesDataTable;
            }
            catch (Exception ex)
            {
                //logear error
                _logger.Error(ex, "Error al obtener informacion de los clientes de la base de datos");
                _logger.Error(ex.ToString());
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();//asegura cierre de la conexion
            }
        }

        public int InsertarCliente(Cliente cliente)
        {
            try
            {
                int idPersona = _personasData.InsertarPersona(cliente.DatosPersonales);

                if (idPersona <= 0)
                {
                    _logger.Error($"No se pudo insertar la persona para el cliente{cliente.Rfc}");
                    return -1;
                }
                cliente.IdPersona = idPersona;

                string query = @"
                    INSERT INTO cliente(id_persona, tipo, fecha_registro, rfc)
	                    VALUES (@IdPersona, @Tipo, @FechaRegistro, @Rfc)
	                    RETURNING id_cliente ";

                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@IdPersona", cliente.IdPersona);
                NpgsqlParameter paramTipo = _dbAccess.CreateParameter("@Tipo", cliente.Tipo);
                NpgsqlParameter paramFechaRegistro = _dbAccess.CreateParameter("@FechaRegistro", cliente.FechaRegistro);
                NpgsqlParameter paramRfc = _dbAccess.CreateParameter("@Rfc", cliente.Rfc);

                _dbAccess.Connect();

                object? resultado = _dbAccess.ExecuteScalar(query, paramIdPersona, paramTipo, paramFechaRegistro, paramRfc);

                int idCliente_generado = Convert.ToInt32(resultado);
                _logger.Info($"Cliente insertado correctamente con ID {idCliente_generado}");

                return idCliente_generado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar al cliente con RFC {cliente.Rfc}");
                return -1;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public Cliente ObtenerClientePorId(int idCliente)
        {
            try
            {
                string query = @"
                    SELECT 
                        c.id_cliente,
                        c.id_persona,
                        p.nombre_completo,
                        p.correo,
                        p.telefono,
                        p.fecha_nacimiento,
                        c.fecha_registro,
                        c.rfc,
                        c.tipo,
                        p.estatus AS estatus_persona
                    FROM cliente c
                    JOIN personas p ON c.id_persona = p.id_persona
                    WHERE c.id_cliente = @IdCliente";
                NpgsqlParameter paramIdCliente = _dbAccess.CreateParameter("@IdCliente", idCliente);
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramIdCliente);
                if (resultado.Rows.Count == 0)
                {
                    return null;
                }
                DataRow row = resultado.Rows[0];
                Persona persona = new Persona(                         
                    Convert.ToInt32(row["id_persona"]),
                    row["nombre_completo"].ToString() ?? "",
                    row["correo"].ToString() ?? "",
                    row["telefono"].ToString() ?? "",
                    row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                    Convert.ToBoolean(row["estatus_persona"])
                );
                Cliente cliente = new Cliente(
                    Convert.ToInt32(row["id_cliente"]),
                    Convert.ToInt32(row["id_persona"]),
                    Convert.ToInt32(row["tipo"]),
                    Convert.ToDateTime(row["fecha_registro"]),
                    row["rfc"].ToString() ?? "",
                    persona
                );
                return cliente;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener el cliente con ID {idCliente}");
                return null;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public bool ActualizarCliente(Cliente cliente)
        {
            try
            {
                string query = @"
                    UPDATE cliente
                    SET 
                        rfc = @rfc,
                        tipo = @tipo,
                        fecha_registro = @fecha_registro,
                        id_persona = @id_persona
                    WHERE id_cliente = @id_cliente;
                
                    UPDATE personas
                    SET 
                        nombre_completo = @nombre_completo,
                        correo = @correo,
                        telefono = @telefono,
                        fecha_nacimiento = @fecha_nacimiento,
                        estatus = @estatus
                    WHERE id_persona = @id_persona;
                ";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@rfc", cliente.Rfc),
                    new NpgsqlParameter("@tipo", cliente.Tipo),
                    new NpgsqlParameter("@fecha_registro", cliente.FechaRegistro),
                    new NpgsqlParameter("@id_persona", cliente.DatosPersonales.Id),
                    new NpgsqlParameter("@id_cliente", cliente.Id),
                    new NpgsqlParameter("@nombre_completo", cliente.DatosPersonales.NombreCompleto),
                    new NpgsqlParameter("@correo", cliente.DatosPersonales.Correo),
                    new NpgsqlParameter("@telefono", cliente.DatosPersonales.Telefono),
                    new NpgsqlParameter("@fecha_nacimiento", cliente.DatosPersonales.FechaNacimiento),
                    new NpgsqlParameter("@estatus", cliente.DatosPersonales.Estatus)
                };

                // Ejecutar la consulta
                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parametros.ToArray());

                // Si se actualizaron filas, devolver verdadero
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el cliente con ID {cliente.Id}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public bool ExisteRfc(string rfc)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM public.cliente WHERE rfc = @Rfc;";

                NpgsqlParameter paramRfc = _dbAccess.CreateParameter(@"Rfc", rfc);

                _dbAccess.Connect();

                object? resultado = _dbAccess.ExecuteScalar(query, paramRfc);

                int cantidad = Convert.ToInt32(resultado);
                bool existe = cantidad > 0;

                return existe;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar la existencia dell RFC {rfc}");
                return false;
            }
            finally
            {
                //Asegura que se cierre la conexion
                _dbAccess.Disconnect();
            }
        }

    }
}
