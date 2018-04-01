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

            //match tranparency
            Program.Transparent(this.back);
            Program.Transparent(this.front);
            Program.Transparent(this.bill1);
            //make invisible
            this.front.Controls.Add(this.moneyModule);
            //Program.Invisible(this.moneyModule);

            //dragdrop
            bill1.AllowDrop = true;
            moneyModule.AllowDrop = true;

            bill1.MouseDown += new MouseEventHandler(Event_MouseDown);
            bill1.DragDrop += new DragEventHandler(Event_DragDrop);
            //bill1.DragEnter += new DragEventHandler(Event_DragEnter);

            //moneyModule.MouseDown += new MouseEventHandler(Event_MouseDown);
            //moneyModule.DragDrop += new DragEventHandler(Event_DragDrop);
            moneyModule.DragEnter += new DragEventHandler(Event_DragEnter);

            Program.Logger("INFO", this.Name + " initialized");
        }

        private void bill1_Click(object sender, EventArgs e) {
            Program.Logger("DEBG", bill1.Name + " was clicked");
        }

        private void buttonDoor_Click(object sender, EventArgs e) {
            if (Program.machine.DoorOpened) {
                Program.Animation1(
                    this.front,
                    new System.Drawing.Bitmap[] {
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0001_F07,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0002_F06,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0003_F05,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0004_F04,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0005_F03,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0006_F02,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0007_F01
                    },
                    15,
                    false
                );
                Program.machine.DoorOpened = false;
                buttonDoor.Text = "Open Door";
            } else {
                Program.Animation1(
                    this.front,
                    new System.Drawing.Bitmap[] {
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0006_F02,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0005_F03,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0004_F04,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0003_F05,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0002_F06,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0001_F07,
                        global::SnacksMachine.Properties.Resources.machine2_0000s_0000_F08
                    },
                    15,
                    false
                );
                Program.machine.DoorOpened = true;
                buttonDoor.Text = "Close Door";
            }
            Program.Logger("DEBG", buttonDoor.Name + " was clicked");
        }

        private void moneyModule_Click(object sender, EventArgs e) {
            Program.Logger("DEBG", moneyModule.Name + " was clicked");
        }

        private void Event_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox.Image != null) {
                pictureBox.Select();
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
            }
        }

        private void Event_DragDrop(object sender, DragEventArgs e) {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void Event_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
