using NLog;
using Sistema_Ventas.Data;
using Sistema_Ventas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Controller
{
    class AuditoriaController
    {
        private static readonly Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly AuditoriaDataAccess _auditoriaDataAccess;

        public AuditoriaController()
        {
            try
            {
                _auditoriaDataAccess = new AuditoriaDataAccess();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al inicializar AuditoriaController: " + ex.Message);
                throw;
            }
        }
        public List<Auditoria> ObtenerAuditorias()
        {
            try
            {
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditorias();
                _logger.Info("Auditorías obtenidas: {0}", auditorias.Count);
                return auditorias;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener auditorías: " + ex.Message);
                throw;
            }
        }


        public void AudioriaAdd(Auditoria auditoria)
        {
            try
            {
                _auditoriaDataAccess.AuditoriaAdd(auditoria);
                _logger.Info("Auditoría agregada: {0}", auditoria.ToString());
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al agregar auditoría: " + ex.Message);
                throw;
            }
        }
    }
}

    

