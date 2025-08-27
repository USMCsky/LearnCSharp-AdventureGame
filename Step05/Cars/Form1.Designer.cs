namespace Cars {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.createCarsBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showCarsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCarsBtn
            // 
            this.createCarsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createCarsBtn.Location = new System.Drawing.Point(28, 388);
            this.createCarsBtn.Name = "createCarsBtn";
            this.createCarsBtn.Size = new System.Drawing.Size(75, 23);
            this.createCarsBtn.TabIndex = 0;
            this.createCarsBtn.Text = "Create Cars";
            this.createCarsBtn.UseVisualStyleBackColor = true;
            this.createCarsBtn.Click += new System.EventHandler(this.createCarsBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 347);
            this.textBox1.TabIndex = 1;
            // 
            // showCarsBtn
            // 
            this.showCarsBtn.Location = new System.Drawing.Point(692, 388);
            this.showCarsBtn.Name = "showCarsBtn";
            this.showCarsBtn.Size = new System.Drawing.Size(75, 23);
            this.showCarsBtn.TabIndex = 2;
            this.showCarsBtn.Text = "ShowCars";
            this.showCarsBtn.UseVisualStyleBackColor = true;
            this.showCarsBtn.Click += new System.EventHandler(this.showCarsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showCarsBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createCarsBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCarsBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showCarsBtn;
    }
}

