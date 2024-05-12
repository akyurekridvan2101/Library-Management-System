namespace LibraryManagementSystem
{
    internal static class Program
    {
        public static DatabaseManager databaseManager;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            databaseManager = new DatabaseManager("localhost", "Library", "postgres", "Rdvn212121.");
            databaseManager.OpenConnection();

            Application.Run(new Login());
            Application.Run(new Dashboard());
        }
    }
}
