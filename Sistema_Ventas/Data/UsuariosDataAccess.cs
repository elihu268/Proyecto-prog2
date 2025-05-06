using NLog;
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Ventas.Data
{
    public class UsuariosDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.UsuariosDataAccess");

        private readonly PostgreSQLDataAccess _dbAccess;

        private readonly PersonasDataAccess _personasDataAccess;

        public UsuariosDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
                _personasDataAccess = new PersonasDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar UsuariosDataAccess");
                throw;
            }
        }


        // Aquí iría la lógica para interactuar con la base de datos
        public List<Usuario> ObtenerUsuarios(int activos)
        {
            List<Usuario> usuarios = new List<Usuario>();
            // Aquí iría la lógica para obtener los usuarios de la base de datos
            try
            {
                string query = "SELECT u.id_usuario, p.id_persona, p.nombre_completo, p.fecha_nacimiento, p.correo, p.telefono, p.estatus, u.id_rol, r.descripcion as Rol FROM usuarios u JOIN personas p ON u.id_persona = p.id_persona JOIN roles r ON u.id_rol = r.id_rol WHERE 1 = 1  ";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();
                if (activos == 2)
                {
                    query += " AND p.estatus = @estatus ";
                    parameters.Add(new NpgsqlParameter("@estatus", 2));
                }
                query += " ORDER BY u.id_usuario";
                _logger.Info("Ejecutando consulta: {0}", query);
                _dbAccess.Connect();
                DataTable usuari = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

                foreach (DataRow row in usuari.Rows)
                {
                    Persona persona = new Persona(
                        Convert.ToInt32(row["id_persona"]),
                        row["nombre_completo"].ToString() ?? "",
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                        Convert.ToBoolean(row["estatus"]) // Changed from Convert.ToInt32 to Convert.ToBoolean
                    );
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_persona"]),
                        Convert.ToInt32(row["id_rol"]),
                        row["correo"].ToString() ?? "",
                        Convert.ToBoolean(row["estatus"]),
                        persona
                    );
                    usuarios.Add(usuario);
                }
                _logger.Info("Consulta ejecutada con éxito, se encontraron {0} usuarios", usuarios.Count);
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener usuarios " + "ObtenerUsuario /UsuariosDataAcces");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public int AgregarUsuario(Usuario usuario)
        {
            // Aquí iría la lógica para agregar un nuevo usuario a la base de datos
            try
            {
                int idPersona = _personasDataAccess.InsertarPersona(usuario.DatosPersonales);
                if (idPersona <= 0)
                {
                    _logger.Error("Error al agregar persona para el usuario");
                    return -1;
                }
                string query = @"INSERT INTO usuarios (id_persona, id_rol, usuario, contraseña, estatus) 
                    VALUES (@id_persona, @id_rol, @cuenta, @contrasena, @estatus) RETURNING id_usuario";

                NpgsqlParameter paramIdPersona = new NpgsqlParameter("@id_persona", idPersona);
                NpgsqlParameter paramIdRol = new NpgsqlParameter("@id_rol", usuario.idRol);
                NpgsqlParameter paramCuenta = new NpgsqlParameter("@cuenta", usuario.Cuenta);
                NpgsqlParameter paramContrasena = new NpgsqlParameter("@contrasena", usuario.Constrasena);
                NpgsqlParameter paramEstatus = new NpgsqlParameter("@estatus", usuario.Estatus);

                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query, paramIdPersona, paramIdRol, paramCuenta, paramContrasena,paramEstatus);

                /*if (resultado != null && int.TryParse(resultado.ToString(), out int idUsuario))
                {
                    _logger.Info("Usuario agregado con éxito, ID: {0}", idUsuario);
                    return idUsuario;
                }
                else
                {
                    _logger.Error("Error al agregar usuario, no se obtuvo un ID válido");
                    return -1;
                }*/
                int idPersonaGenerado = Convert.ToInt32(resultado);
                _logger.Info("Usuario agregado con éxito, ID: {0}", idPersonaGenerado);
                return idPersonaGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al agregar usuario");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        /// <summary>
        /// Verifica si un usuario existe en la base de datos.
        /// </summary>
        /// <param name="cuenta"> cuenta es igual que usuario
        /// se ocupa usuario en las consultas de base de datos</param>
        /// <returns></returns>
        public bool ExisteUsuario(string cuenta)
        {
            // Aquí iría la lógica para obtener un usuario por su ID de la base de datos
            try
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @cuenta";
                NpgsqlParameter paramCuenta = new NpgsqlParameter("@cuenta", cuenta);
                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query, paramCuenta);
                int cantidad = Convert.ToInt32(resultado);
                bool existe = cantidad > 0;
                _logger.Info("Verificación de existencia de usuario: {0}", existe);
                return existe;
            }
            catch
            {
                _logger.Error("Error al verificar existencia de usuario");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();

            }// Placeholder
        }
        public bool ActualizarUsuario(Usuario usuario)
        {
            // Aquí iría la lógica para actualizar un usuario existente en la base de datos
            try
            {
                _logger.Debug($"Actualizando usuario: {usuario.IdUsuario} y persona con id {usuario.IdPersona}");
                bool actualizadopersonaexitosa = _personasDataAccess.ActualizarPersona(usuario.DatosPersonales);
                if (!actualizadopersonaexitosa)
                {
                    _logger.Error("Error al actualizar persona para el usuario");
                    return false;
                }
                string query = "UPDATE Usuarios SET id_rol = @id_rol, usuario = @cuenta, contrasena = @contrasena, estatus = @estatus WHERE id_usuario = @id_usuario";
                _dbAccess.Connect();
                NpgsqlParameter paramIdUsuario = new NpgsqlParameter("@id_usuario", usuario.IdUsuario);
                NpgsqlParameter paramIdRol = new NpgsqlParameter("@id_rol", usuario.idRol);
                NpgsqlParameter paramCuenta = new NpgsqlParameter("@cuenta", usuario.Cuenta);
                NpgsqlParameter paramContrasena = new NpgsqlParameter("@contrasena", usuario.Constrasena);
                NpgsqlParameter paramEstatus = new NpgsqlParameter("@estatus", usuario.Estatus);
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, paramIdUsuario, paramIdRol, paramCuenta, paramContrasena, paramEstatus);

                bool exito = filasAfectadas > 0;

                if(!exito)
                {
                    _logger.Warn($"No se pudo actualizar el Usuarios con Id {usuario.IdUsuario}, No se encontro registro");
                }
                else
                {
                    _logger.Debug($"Usuario actualizado con éxito, ID: {usuario.IdUsuario}");
                }
                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar usuario");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
            {

            }
        }

        public List<Usuario> ObtenerUsuarioPorNnombre(string nombreUsr, DateTime? fechaInicio, DateTime? fechaFin, bool? estatus)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                string query = @"SELECT u.id_usuario, p.id_persona, p.nombre_completo, p.fecha_nacimiento, p.correo, p.telefono, p.estatus, u.id_rol, r.descripcion as Rol
                                FROM usuarios u 
                            JOIN personas p ON u.id_persona = p.id_persona 
                            JOIN roles r ON u.id_rol = r.id_rol 
                            WHERE (@nombre IS null OR LOWER(p.nombre_completo) LIKE @nombre) AND
                            (@fechaInicio IS null OR p.fecha_nacimiento >= @fechaInicio) AND
                            (@fechaFin IS null OR p.fecha_nacimiento <= @fechaFin) AND
                            (@estatus IS null OR p.estatus = @estatus)
                            ";

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>()
                {
                    new NpgsqlParameter("@nombre", $"%{nombreUsr}%")
                    {
                        Value = nombreUsr !=null ? $"%{nombreUsr}%" : DBNull.Value
                    },
                    new NpgsqlParameter("@fechaInicio",NpgsqlTypes.NpgsqlDbType.Date)
                    {
                        Value = fechaInicio.HasValue ? (object)fechaInicio.Value : DBNull.Value
                        },
                    new NpgsqlParameter("@fechaFin", NpgsqlTypes.NpgsqlDbType.Date)
                    {
                        Value = fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value
                    },
                    new NpgsqlParameter("@estatus", NpgsqlTypes.NpgsqlDbType.Boolean)
                    {
                        Value = estatus.HasValue ? (object)estatus.Value : DBNull.Value
                    }
                };

                _dbAccess.Connect();
                DataTable result = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());
                foreach (DataRow row in result.Rows)
                {
                    Persona persona = new Persona()
                    {

                        NombreCompleto = row["nombre_completo"].ToString() ?? "",
                        Correo = row["correo"].ToString() ?? "",
                        Telefono = row["telefono"].ToString() ?? "",
                        FechaNacimiento = row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                        Estatus = row["estatus"] != DBNull.Value ? Convert.ToBoolean(row["estatus"]) : false
                    };
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_persona"]),
                        Convert.ToInt32(row["id_rol"]),
                        row["correo"].ToString() ?? "",
                        Convert.ToBoolean(row["estatus"]),
                        persona
                    );
                    usuarios.Add(usuario);
                }
                _logger.Info("Consulta ejecutada con éxito, se encontraron {0} usuarios", usuarios.Count);
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener usuarios por nombre");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public (Usuario, string) ValidarUsuario(string usuario, string contrasena)
        {
            Usuario usuarioValido = null;
            string mensaje = "";
            string query = @"SELECT u.id_usuario, u.id_persona, u.id_rol, u.usuario, u.contraseña, u.estatus,
                           p.nombre_completo, p.correo, p.telefono, p.fecha_nacimiento, p.estatus AS estatus_persona 
                           FROM usuarios u
                           JOIN personas p ON u.id_persona = p.id_persona
                           WHERE u.usuario = @usuario";


            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@usuario", usuario)
            };

            DataTable result = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

            if (result.Rows.Count == 0)
            {
                mensaje = "Usuario no registrado.";  // No existe el usuario
                return (null, mensaje);
            }

            DataRow row = result.Rows[0];

            // Verificar si el usuario está dado de baja
            if (Convert.ToBoolean(row["estatus"]) == false)
            {
                mensaje = "El usuario está dado de baja.";  // Usuario dado de baja
                return (null, mensaje);
            }

            // Verificar si la contraseña es incorrecta
            if (row["contraseña"].ToString() != contrasena)
            {
                mensaje = "Contraseña incorrecta.";  // Contraseña incorrecta
                return (null, mensaje);
            }

            if (result.Rows.Count > 0)
            {
                // Si se encuentra el usuario, lo armamos
                row = result.Rows[0];
                Persona persona = new Persona(
                    Convert.ToInt32(row["id_persona"]),
                    row["nombre_completo"].ToString() ?? "",
                    row["correo"].ToString() ??"",
                    row["telefono"].ToString() ?? "",
                    row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                    Convert.ToBoolean(row["estatus_persona"])
                );

                usuarioValido = new Usuario(
                    Convert.ToInt32(row["id_usuario"]),
                    Convert.ToInt32(row["id_persona"]),
                    Convert.ToInt32(row["id_rol"]),
                    row["usuario"].ToString() ?? "",
                    row["contraseña"].ToString() ?? "",
                    Convert.ToBoolean(row["estatus_persona"]), // Cambiado a Convert.ToBoolean
                    persona
                );                
            }

            mensaje = "Inicio de sesión exitoso.";  // Inicio de sesión exitoso
            return (usuarioValido, mensaje);
        }

        public List<string> ObtenerPermisos(int idRol)
        {
            List<string> permisos = new List<string>();

            string query = "SELECT P.codigo " +
                           "FROM permisos P " +
                           "JOIN permisos_rol PR ON P.id_permiso = PR.id_permiso " +
                           "WHERE PR.id_rol = @idRol AND P.estatus = TRUE";


            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@idRol", idRol)
            };

            DataTable result = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

            foreach (DataRow row in result.Rows)
            {
                permisos.Add(row["codigo"].ToString());
            }

            return permisos;
        }

        public static void EliminarUsuario(int id)
        {
            // Aquí iría la lógica para eliminar un usuario de la base de datos
        }
    }
}
