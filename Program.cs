using System;
using System.Windows.Forms;

namespace NetPad
{
    static class Program
    {
        public static MainForm FronttPad;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FronttPad = new MainForm();

            Application.Run(FronttPad);
        }
    }
}
