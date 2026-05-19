using System;
using System.Windows.Forms;

namespace CeviriUygulamasi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktasıdır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulama ilk açıldığında Form1'i başlatır
            Application.Run(new Form1());
        }
    }
}
