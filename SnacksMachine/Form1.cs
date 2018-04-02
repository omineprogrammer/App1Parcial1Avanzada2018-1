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
            Program.Transparent(this.bill2000);
            //make invisible
            this.front.Controls.Add(this.moneyModule);
            this.front.Controls.Add(this.PanelPrincipal);
            //Program.Invisible(this.moneyModule);

            //dragdrop
            bill2000.AllowDrop = true;
            moneyModule.AllowDrop = true;

            //bill2000.MouseDown += new MouseEventHandler(DropMoney_MouseDown);
            bill2000.DragDrop += new DragEventHandler(Receive_DragDrop);
            moneyModule.DragEnter += new DragEventHandler(IntoMoney_DragEnter);

            Program.Logger("INFO", this.Name + " initialized");
        }

        private void bill1_Click(object sender, EventArgs e) {
            Program.Logger("DEBG", bill2000.Name + " was clicked");
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

        //Drop image
        private void DropImage_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox.Image != null) {
                pictureBox.Select();
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
            }
        }
        //validate drag data
        private void Event_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.Bitmap)) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        //receiver drag data
        private void Event_DragDrop(object sender, DragEventArgs e) {
            PictureBox pb = (PictureBox)sender;
            //pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }






        //Drop money
        private void DropMoney_MouseDown(object sender, MouseEventArgs e) {
            MoneyBill money = (MoneyBill)sender;
            money.Select();
            money.DoDragDrop(money.Value.ToString(), DragDropEffects.Copy);
        }
        //validate drag data
        private void IntoMoney_DragEnter(object sender, DragEventArgs e) {
            Program.Logger(
                "DEBG", "number of data reg present in 'e' " + e.Data.GetFormats().Count() + ", index 0 " + e.Data.GetFormats()[0]);
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                e.Effect = DragDropEffects.Copy;
                Program.Logger("DEBG", "data " + e.Data.GetData(DataFormats.StringFormat));
            } else {
                e.Effect = DragDropEffects.None;
            }
        }
        //receiver drag data
        private void Receive_DragDrop(object sender, DragEventArgs e) {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }




        private void PanelPrincipal_Click(object sender, EventArgs e) {
            groupBox1.Visible = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {}

        private void button1_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e) {
            maskedTextBox1.Text = maskedTextBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) {
            maskedTextBox1.Clear();

        }

        private void button12_Click(object sender, EventArgs e) {
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void Event_MouseDown(object sender, MouseEventArgs e) {

        }
    }
}
