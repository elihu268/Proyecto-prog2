using NLog;
using Sistema_Ventas.Bussines;
using Sistema_Ventas.Data;
using Sistema_Ventas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Controller
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
                _logger.Error($"Error al agregar usuario{usuario.DatosPersonales?.NombreCompleto ?? "sin nombre"}, correo {usuario.Cuenta}");
                return (-4, "Error al agregar el usuario");
            }
        }

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            try
            {
                Usuario usuarioValidado = _usuariosDataAccess.ValidarUsuario(usuario, contraseña);

                if (usuarioValidado != null)
                {
                    // Si el usuario es válido, se obtienen los permisos de ese usuario
                    List<string> permisos = _usuariosDataAccess.ObtenerPermisos(usuarioValidado.idRol);

                    // Iniciamos la sesión
                    Sesión.IniciarSesion(usuarioValidado.IdUsuario, usuarioValidado.Cuenta, permisos);

                    // Mensaje de éxito
                    MessageBox.Show("Inicio de sesión exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.Error($"Intento Fallido de inicio de sesion con la credencial " + usuario);
                    return false;
                }
            }
            catch (Exception)
            {
                _logger.Error($"Intento Fallido de inicio de sesion con la credencial " + usuario);
                throw;
            }            
        }

    }
}
