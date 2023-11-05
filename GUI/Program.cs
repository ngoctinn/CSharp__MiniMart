namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhapForm());
=======
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
>>>>>>> 44ae5c7f6bcf8b2d4fccb89fe7be93ad6415f778
        }
    }
}