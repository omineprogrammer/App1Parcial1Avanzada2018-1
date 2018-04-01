namespace SnacksMachine {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bill = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.item4 = new System.Windows.Forms.PictureBox();
            this.item2 = new System.Windows.Forms.PictureBox();
            this.item3 = new System.Windows.Forms.PictureBox();
            this.moneyModule = new System.Windows.Forms.PictureBox();
            this.row1 = new System.Windows.Forms.PictureBox();
            this.front = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).BeginInit();
            this.SuspendLayout();
            // 
            // bill
            // 
            this.bill.Image = global::SnacksMachine.Properties.Resources.bill_0004_2000;
            this.bill.Location = new System.Drawing.Point(342, 12);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(95, 52);
            this.bill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bill.TabIndex = 1;
            this.bill.TabStop = false;
            this.bill.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(325, 640);
            this.back.TabIndex = 0;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // item4
            // 
            this.item4.Location = new System.Drawing.Point(471, 525);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(43, 51);
            this.item4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item4.TabIndex = 3;
            this.item4.TabStop = false;
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(383, 525);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(43, 51);
            this.item2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item2.TabIndex = 3;
            this.item2.TabStop = false;
            // 
            // item3
            // 
            this.item3.Location = new System.Drawing.Point(427, 525);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(43, 51);
            this.item3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.item3.TabIndex = 3;
            this.item3.TabStop = false;
            // 
            // moneyModule
            // 
            this.moneyModule.BackColor = System.Drawing.Color.Transparent;
            this.moneyModule.InitialImage = null;
            this.moneyModule.Location = new System.Drawing.Point(265, 256);
            this.moneyModule.Name = "moneyModule";
            this.moneyModule.Size = new System.Drawing.Size(56, 78);
            this.moneyModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.moneyModule.TabIndex = 3;
            this.moneyModule.TabStop = false;
            // 
            // row1
            // 
            this.row1.Location = new System.Drawing.Point(336, 522);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(182, 57);
            this.row1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.row1.TabIndex = 3;
            this.row1.TabStop = false;
            // 
            // front
            // 
            this.front.Image = ((System.Drawing.Image)(resources.GetObject("front.Image")));
            this.front.Location = new System.Drawing.Point(4, 4);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(325, 640);
            this.front.TabIndex = 2;
            this.front.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 655);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.moneyModule);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.front);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox bill;
        private System.Windows.Forms.PictureBox row1;
        private System.Windows.Forms.PictureBox moneyModule;
        private System.Windows.Forms.PictureBox item3;
        private System.Windows.Forms.PictureBox item2;
        private System.Windows.Forms.PictureBox item4;
        private System.Windows.Forms.PictureBox front;
    }
}

