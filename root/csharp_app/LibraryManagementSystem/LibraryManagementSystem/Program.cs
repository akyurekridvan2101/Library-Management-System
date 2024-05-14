using LibraryManagementSystem;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        public static DatabaseManager databaseManager;
        public static bool loginBool = false;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            databaseManager = new DatabaseManager("localhost", "Library", "postgres", "Rdvn212121.");
            databaseManager.OpenConnection();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}