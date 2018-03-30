using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnacksMachine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Program.Logger("INFO", this.Name + " initialized");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            Animation1ChangeImg(
                this.pictureBox1,
                new System.Drawing.Bitmap[] {
                    global::SnacksMachine.Properties.Resources.maks_door_1,
                    global::SnacksMachine.Properties.Resources.maks_door_2,
                    global::SnacksMachine.Properties.Resources.maks_door_3,
                    global::SnacksMachine.Properties.Resources.maks_door_4  
                },
                4,
                false
            );          
            Program.Logger("DEBG", pictureBox1.Name + " was clicked");
        }

        private void Animation1ChangeImg(PictureBox pictureBox, System.Drawing.Bitmap[] BitmapArr, int FramexSecond, bool continuos) {
            int i = 0;
            Timer timer = new Timer();
            timer.Interval = (1000 / FramexSecond);
            timer.Tick += new System.EventHandler(timer_tick);
            timer.Enabled = true;
            
            //handler timer
            void timer_tick(object sender, EventArgs e) {
                timer.Stop();
                Program.Logger("DEBG", timer.Interval + " Second cycle number " + (i + 1) + " completed");
                //handler
                if (i == (BitmapArr.Count() -1)) {
                    pictureBox.Image = BitmapArr[i];
                    Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //again
                    if (continuos) {
                        Program.Logger("DEBG", timer.Interval + " Second cycle again");
                        i = 0;
                        timer.Start();
                    }
                } else {
                    pictureBox.Image = BitmapArr[i];
                    Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //next step
                    i++;
                    timer.Start();
                }
            }
        }
    }
}
