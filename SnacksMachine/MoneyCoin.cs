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
    public partial class MoneyCoin : System.Windows.Forms.PictureBox {
        //properties
        private int value;

        public int Value {
            get { return this.value; }
            set { this.value = value; }
        }

        public MoneyCoin() {
            InitializeComponent();
        }

        public MoneyCoin(int value) {
            InitializeComponent();
            this.value = value;
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }
    }
}
