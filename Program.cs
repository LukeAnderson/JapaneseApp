using System;
using System.Windows.Forms;

namespace JapaneseApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //making  the starting form hidden by doing this.

            Application.Run(new WordSearchForm());
        }
    }
}
