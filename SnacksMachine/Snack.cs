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
    public partial class Snack : System.Windows.Forms.PictureBox {
        //properties
        private int price;
        private string snackName;

        public Snack() {
            InitializeComponent();
        }

        public Snack(int price, string snackName) {
            this.price = price;
            this.snackName = snackName;
            InitializeComponent();
        }

        public int Price {
            get { return this.price; }
            set { this.price = value; }
        }

        public string SnackName {
            get { return snackName; }
            set { snackName = value; }
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }
    }
}
