using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnacksMachine {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        //global vars
        static string logfile = ".\\" + System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".log";

        //logger
        public static void Logger(string category, string msg) {
            System.IO.StreamWriter sw = System.IO.File.AppendText(logfile);
            try {
                string logLine = System.String.Format(
                    "{0:G} {1} {2,8}: {3}.",
                    System.DateTime.Now.ToUniversalTime(),
                    System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName + " " + System.Diagnostics.Process.GetCurrentProcess().Id,
                    "[" + category + "]",
                    msg
                );
                sw.WriteLine(logLine);
            } finally {
                sw.Close();
            }
        }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
