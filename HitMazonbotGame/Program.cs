using System;
using System.Windows.Forms;

namespace HitMazonbotGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain.formMain = new FormMain();
            Application.Run(FormMain.formMain);
        }
    }
}
