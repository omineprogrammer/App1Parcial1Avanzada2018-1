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

        //drawing transparent
        public static System.Drawing.Drawing2D.GraphicsPath Transparent(System.Drawing.Image im) {
            int x;
            int y;
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(im);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= bmp.Width - 1; x++) {
                for (y = 0; y <= bmp.Height - 1; y++) {
                    if (!bmp.GetPixel(x, y).Equals(mask)) {
                        gp.AddRectangle(new System.Drawing.Rectangle(x, y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;

        }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
