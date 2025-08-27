using System;
using System.Windows.Forms;

namespace escapechars {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // note that the single \n will not produce a newline here, but the \r\n pair will
            string s = "Hello\nworld\r\nTab\t, a \\ and a \" ";
            textBox1.Text = s;
        }
    }
}
