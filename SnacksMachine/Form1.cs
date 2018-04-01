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

            this.moneyModule.DragDrop += new System.Windows.Forms.DragEventHandler(this.item1_DragDrop);

            //match tranparency
            Program.Transparent(this.back);
            Program.Transparent(this.front);
            Program.Transparent(this.bill);
            Program.Invisible(this.moneyModule);

            Program.Logger("INFO", this.Name + " initialized");
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        private void item1_DragDrop(object sender, EventArgs e) {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            Program.Animation1(
                this.front,
                new System.Drawing.Bitmap[] {
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0007_F01,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0006_F02,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0005_F03,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0004_F04,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0003_F05,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0002_F06,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0001_F07,
                    global::SnacksMachine.Properties.Resources.machine2_0000s_0000_F08
                },
                8,
                false
            );          
            Program.Logger("DEBG", back.Name + " was clicked");
        }

    }
}
