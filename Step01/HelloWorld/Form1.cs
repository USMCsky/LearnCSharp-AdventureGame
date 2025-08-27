using System;
using System.Windows.Forms;

namespace HelloWorld {

    public partial class PopUp : Form {
        public PopUp() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = "Hello world";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }
    }
}
