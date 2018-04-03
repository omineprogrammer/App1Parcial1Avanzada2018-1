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
            this.front.Controls.Add(this.PanelPrincipal);
            //Program.Invisible(this.moneyModule);

            //dragdrop
            bill1.AllowDrop = true;
            moneyModule.AllowDrop = true;
            pictureBox17.AllowDrop = true;
            pictureBox18.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox24.AllowDrop = true;

            //drop items
            bill1.MouseDown += new MouseEventHandler(Event_MouseDown);
            bill1.DragDrop += new DragEventHandler(Event_DragDrop);
            /*pictureBox24.MouseDown += new MouseEventHandler(Event_MouseDown);
            pictureBox24.DragDrop += new DragEventHandler(Event_DragDrop);
            pictureBox23.MouseDown += new MouseEventHandler(Event_MouseDown);
            pictureBox23.DragDrop += new DragEventHandler(Event_DragDrop);
            pictureBox22.MouseDown += new MouseEventHandler(Event_MouseDown);
            pictureBox22.DragDrop += new DragEventHandler(Event_DragDrop);
            pictureBox21.MouseDown += new MouseEventHandler(Event_MouseDown);
            pictureBox21.DragDrop += new DragEventHandler(Event_DragDrop);*/

            //drag item
            moneyModule.DragEnter += new DragEventHandler(Event_DragEnter);
            /*pictureBox17.DragEnter += new DragEventHandler(Event_DragEnter);
            pictureBox18.DragEnter += new DragEventHandler(Event_DragEnter);
            pictureBox19.DragEnter += new DragEventHandler(Event_DragEnter);
            pictureBox20.DragEnter += new DragEventHandler(Event_DragEnter);*/
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
                    30,
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
                    30,
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

        //show controlpanel
        private void PanelPrincipal_Click(object sender, EventArgs e) {
            groupBox1.Visible = true;
        }

        //KB Events
        private void button1_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "1";}
        private void button2_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "2";}
        private void button3_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "3";}
        private void button4_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "4";}
        private void button5_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "5";}
        private void button6_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "6";}
        private void button7_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "7";}
        private void button8_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "8";}
        private void button9_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "9";}
        private void button10_Click(object sender, EventArgs e) {maskedTextBox1.Text = maskedTextBox1.Text + "0";}
        private void button11_Click(object sender, EventArgs e) {maskedTextBox1.Clear();}
        private void button12_Click(object sender, EventArgs e) {groupBox1.Visible = false;}
        private void groupBox1_Enter(object sender, EventArgs e) { }


        //MouseDown
        private void Handler_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
        }

        //DragEnter
        private void Handler_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }
        
        //DragDrop
        private void Handler_DragDrop(object sender, DragEventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
