using app_Escritorio_GastroAdmin_2026.Views;

namespace app_Escritorio_GastroAdmin_2026
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
            Application.Run(new Form1());
            //Application.Run(new FrmClientes()); //Formulario de clientes
        }
    }
}