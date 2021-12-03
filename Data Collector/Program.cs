using System;
using System.Windows.Forms;

namespace Janaka_Ayya_Software
{
    static class Program
    {
        public static Database databaseConnector;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHomeView());
            databaseConnector = new Database();
        }
    }
}
