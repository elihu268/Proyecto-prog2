using NLog;
using Sistema_VentasCore.Bussines;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Utilities;

namespace Sistema_VentasCore.Controller
{
    public class UsuariosController
    {
        private static readonly Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly UsuariosDataAccess _usuariosDataAccess;
        private readonly PersonasDataAccess _personasDataAccess;
        public UsuariosController()
        {
            try
            {
                _usuariosDataAccess = new UsuariosDataAccess();
                _personasDataAccess = new PersonasDataAccess();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al inicializar UsuariosController: " + ex.Message);
                throw;
            }
        }
        public List<Usuario> ObtenerUsuarios(int activos = 1)
        {
            try
            {
                List<Usuario> usuarios = _usuariosDataAccess.ObtenerUsuarios(activos);
                _logger.Info("Usuarios obtenidos: {0}", usuarios.Count);
                return usuarios;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener usuarios: " + ex.Message);
                throw;
            }
        }
        public (int id, string mensaje) AgregarUsuario(Usuario usuario)
        {
            try
            {
                // Validar que el usuario no exista
                if (_usuariosDataAccess.ExisteUsuario(usuario.Cuenta))
                {
                    _logger.Warn("El usuario ya existe: {0}", usuario.Cuenta);
                    return (-2, "El usuario ya existe");
                }
                _logger.Info("Agregando usuario: {0}", usuario.Cuenta);
                // Agregar el usuario
                int idusuario = _usuariosDataAccess.AgregarUsuario(usuario);

                if (idusuario <= 0)
                {
                    return (-3, "Error al agregar el usuario");
                }
                _logger.Info("Usuario agregado con éxito, ID: {0}", idusuario);
                return (idusuario, "Usuario agregado con éxito");
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al agregar usuario{usuario.DatosPersonales?.NombreCompleto ?? "sin nombre"}, correo {usuario.Cuenta} {ex.Message}");
                return (-4, "Error al agregar el usuario");
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                // Actualizar el usuario
                _logger.Info("Actualizando usuario: {0}", usuario.Cuenta);
                bool resultado = _usuariosDataAccess.ActualizarUsuario(usuario);
                if (!resultado)
                {
                    _logger.Info("Usuario actualizado con éxito, ID: {0}", usuario.IdUsuario);
                    return false;
                }
                    _logger.Warn("Error al actualizar el usuario, ID: {0}", usuario.IdUsuario);
                    return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al actualizar usuario {usuario.DatosPersonales?.NombreCompleto ?? "sin nombre"}, correo {usuario.Cuenta} {ex.Message}");
                throw;
            }
        }

        public string ValidarUsuario(string usuario, string contraseña)
        {
            try
            {
                var (usuarioValido, mensaje) = _usuariosDataAccess.ValidarUsuario(usuario, contraseña);


                // Si el usuario es válido, se obtienen los permisos de ese usuario
                if (usuarioValido != null)
                {
                    // Si la validación es exitosa, se obtiene el permiso del usuario y se inicia la sesión                    
                    Sesión.IniciarSesion(usuarioValido.IdUsuario, usuarioValido.Cuenta, usuarioValido.idRol, ObtenerPermisos(usuarioValido.idRol));
                    return mensaje;  // Éxito
                }

                // Mensaje de error
                return mensaje;

            }
            catch (Exception)
            {
                _logger.Error($"Intento Fallido de inicio de sesion con la credencial " + usuario);
                throw;
            }            
        }
        public List<Usuario> ObtenerUsuarioPorNombre(string nombreUsr, bool? estatus)
        {
            try
            {
                // Obtener los usuarios por rol
                List<Usuario> usuarios = _usuariosDataAccess.ObtenerUsuarioPorNnombre(nombreUsr, estatus);
                return usuarios;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al obtener usuarios por rol: " + ex.Message);
                throw;
            }
        }
        public Usuario ObtenerPorId(int idUsuario)
        {
            try
            {
                // Obtener el usuario por ID
                Usuario usuario = _usuariosDataAccess.ObtenerPorId(idUsuario);
                return usuario;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al obtener usuario por ID: " + ex.Message);
                throw;
            }
        }
        public List<string> ObtenerPermisos(int idRol)
        {
            try
            {
                // Obtener los permisos del usuario
                List<string> permisos = _usuariosDataAccess.ObtenerPermisos(idRol);
                return permisos;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                _logger.Error($"Error al obtener permisos: " + ex.Message);
                throw;
            }
        }

    }
}
