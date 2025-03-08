using Sistema_Ventas.View;

namespace Sistema_Ventas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

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