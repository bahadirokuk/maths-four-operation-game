namespace Islem
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
            if (File.Exists("Level.txt"))
            {
                string content = File.ReadAllText("Level.txt");
                char sonSatir = content[content.Length-1];
                if (sonSatir == '1')
                    Application.Run(new Form1());
                if (sonSatir == '2')
                    Application.Run(new Form2());
                if (sonSatir == '3')
                    Application.Run(new Form3());
                if (sonSatir == '4')
                    Application.Run(new Form4());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}