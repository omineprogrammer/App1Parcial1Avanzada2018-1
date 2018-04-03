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
    public partial class MoneyBill : System.Windows.Forms.PictureBox {
        //properties
        private int price;

        public MoneyBill() {
            InitializeComponent();
        }

        public MoneyBill(int value) {
            InitializeComponent();
            this.price = value;
        }

        public int Price {
            get { return this.price; }
            set { this.price = value; }
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }
    }
}
