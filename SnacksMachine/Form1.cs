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

            /*
            this.body.Controls.Add(this.testpic);
            this.pictureBox2.Controls.Add(this.testpic);
            this.stock.Controls.Add(this.testpic);
            testpic.BackColor = System.Drawing.Color.Transparent;
            */
            //System.Drawing.Drawing2D.GraphicsPath gp = ;

            //make transparent
            testpic.Region = new System.Drawing.Region(Program.Transparent(testpic.Image));
            body.Region = new System.Drawing.Region(Program.Transparent(body.Image));

            Program.Logger("INFO", this.Name + " initialized");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            Animation1ChangeImg(
                this.body,
                new System.Drawing.Bitmap[] {
                    global::SnacksMachine.Properties.Resources.door_2_01,
                    global::SnacksMachine.Properties.Resources.door_2_02,
                    global::SnacksMachine.Properties.Resources.door_2_03,
                    global::SnacksMachine.Properties.Resources.door_2_04,
                    global::SnacksMachine.Properties.Resources.door_2_05,
                    global::SnacksMachine.Properties.Resources.door_2_06
                },
                6,
                false
            );          
            Program.Logger("DEBG", body.Name + " was clicked");
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
                Program.Logger("DEBG", timer.Interval + " MiliSecond cycle number " + (i + 1) + " completed");
                //handler
                if (i == (BitmapArr.Count() -1)) {
                    pictureBox.Image = BitmapArr[i];
                    pictureBox.Region = new System.Drawing.Region(Program.Transparent(pictureBox.Image));
                    Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //again
                    if (continuos) {
                        Program.Logger("DEBG", timer.Interval + " MiliSecond cycle again");
                        i = 0;
                        timer.Start();
                    }
                } else {
                    pictureBox.Image = BitmapArr[i];
                    pictureBox.Region = new System.Drawing.Region(Program.Transparent(pictureBox.Image));
                    Program.Logger("DEBG", pictureBox.Name + " image change to image number " + (i + 1));
                    //next step
                    i++;
                    timer.Start();
                }
            }
        }
    }
}
