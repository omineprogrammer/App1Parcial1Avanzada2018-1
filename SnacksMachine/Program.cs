using System;
using System.Drawing;
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
        public static void Transparent(PictureBox pictureBox) {
            int x;
            int y;
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(pictureBox.Image);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //System.Drawing.Color mask = bmp.GetPixel(0, 0);
            System.Drawing.Color mask = System.Drawing.Color.FromArgb(0,0,0,0);
            //Program.Logger("DEBG", pictureBox.Name + " selected transparent color: " + mask.Name);
            for (x = 0; x <= bmp.Width - 1; x++) {
                for (y = 0; y <= bmp.Height - 1; y++) {
                    //if (!bmp.GetPixel(x, y).Equals(mask)) {
                    if (bmp.GetPixel(x, y).A > 180) {
                        gp.AddRectangle(new System.Drawing.Rectangle(x, y, 1, 1));
                    }
                }
            }
            Program.Logger("DEBG", "alfa of color " + bmp.GetPixel(0,0).ToArgb() + " " + bmp.GetPixel(0, 0).A);
            pictureBox.Region = new System.Drawing.Region(gp);
            bmp.Dispose();
        }

        //drawing Invisible
        public static void Invisible(PictureBox pictureBox) {
            pictureBox.Region = new System.Drawing.Region(new System.Drawing.Drawing2D.GraphicsPath());
        }

        //animation fps
        public static void Animation1(PictureBox pictureBox, System.Drawing.Bitmap[] BitmapArr, int FramexSecond, bool continuos) {
            int i = 0;
            Timer timer = new Timer();
            timer.Interval = (1000 / FramexSecond);
            timer.Tick += new System.EventHandler(timer_tick);
            timer.Enabled = true;
            //handler timer
            void timer_tick(object sender, EventArgs e) {
                timer.Stop();
                //Program.Logger("DEBG", timer.Interval + " MiliSecond cycle number " + (i + 1) + " completed");
                //handler
                if (i == (BitmapArr.Count() - 1)) {
                    pictureBox.Image = BitmapArr[i];
                    Program.Transparent(pictureBox);
                    //Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //again
                    if (continuos) {
                        //Program.Logger("DEBG", timer.Interval + " MiliSecond cycle again");
                        i = 0;
                        timer.Start();
                    }
                } else {
                    pictureBox.Image = BitmapArr[i];
                    Program.Transparent(pictureBox);
                    //Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //next step
                    i++;
                    timer.Start();
                }
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
