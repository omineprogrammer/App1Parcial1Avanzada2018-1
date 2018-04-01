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
            this.bill1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.moneyModule = new System.Windows.Forms.PictureBox();
            this.front = new System.Windows.Forms.PictureBox();
            this.buttonDoor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).BeginInit();
            this.SuspendLayout();
            // 
            // bill1
            // 
            this.bill1.Image = global::SnacksMachine.Properties.Resources.bill_0004_2000;
            this.bill1.Location = new System.Drawing.Point(335, 12);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(95, 52);
            this.bill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bill1.TabIndex = 1;
            this.bill1.TabStop = false;
            this.bill1.Click += new System.EventHandler(this.bill1_Click);
            this.bill1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
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
            // 
            // moneyModule
            // 
            this.moneyModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.moneyModule.InitialImage = null;
            this.moneyModule.Location = new System.Drawing.Point(252, 251);
            this.moneyModule.Name = "moneyModule";
            this.moneyModule.Size = new System.Drawing.Size(72, 86);
            this.moneyModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.moneyModule.TabIndex = 3;
            this.moneyModule.TabStop = false;
            this.moneyModule.Click += new System.EventHandler(this.moneyModule_Click);
            this.moneyModule.DragDrop += new System.Windows.Forms.DragEventHandler(this.Event_DragDrop);
            this.moneyModule.DragEnter += new System.Windows.Forms.DragEventHandler(this.Event_DragEnter);
            // 
            // front
            // 
            this.front.Image = ((System.Drawing.Image)(resources.GetObject("front.Image")));
            this.front.Location = new System.Drawing.Point(4, 4);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(325, 640);
            this.front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.front.TabIndex = 2;
            this.front.TabStop = false;
            // 
            // buttonDoor
            // 
            this.buttonDoor.Location = new System.Drawing.Point(383, 609);
            this.buttonDoor.Name = "buttonDoor";
            this.buttonDoor.Size = new System.Drawing.Size(75, 23);
            this.buttonDoor.TabIndex = 4;
            this.buttonDoor.Text = "Open Door";
            this.buttonDoor.UseVisualStyleBackColor = true;
            this.buttonDoor.Click += new System.EventHandler(this.buttonDoor_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 655);
            this.Controls.Add(this.buttonDoor);
            this.Controls.Add(this.bill1);
            this.Controls.Add(this.moneyModule);
            this.Controls.Add(this.front);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.front)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox bill1;
        private System.Windows.Forms.PictureBox moneyModule;
        private System.Windows.Forms.PictureBox front;
        private System.Windows.Forms.Button buttonDoor;
    }
}

