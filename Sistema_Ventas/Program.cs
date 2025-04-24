using DiseñoForms.View;
using Sistema_Ventas.View;
using NLog;
using Sistema_Ventas.Utilities;


namespace Sistema_Ventas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        // Logger para el programa principal
        private static Logger? _logger;

        [STAThread]
        static void Main()
        {
            // Inicializar el sistema de logging
            _logger = LoggingManager.GetLogger("Sistema_Ventas.Program");
            _logger.Info("Aplicación iniciada...");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new View.frmLogin());
            ///


            frmLogin login_form = new frmLogin();
            if (login_form.ShowDialog() == DialogResult.OK)
            {//si la respuesta es ok lo que va a correr el mdi
                Application.Run(new MDI_Sistema_ventas());
            }
        }
    }
}