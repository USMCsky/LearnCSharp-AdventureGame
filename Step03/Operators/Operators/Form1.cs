using System;
using System.Windows.Forms;

namespace Operators {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void AddToTextBox(string s) {
            // write line to text box
            tb.AppendText(s + "\r\n");
        }

        private void testOpsBtn_Click(object sender, EventArgs e) {
            // declare and init variables to default values
            int a = 10;
            int b = 2;
            tb.Clear();
            AddToTextBox("a + b   : " + (a + b));
            AddToTextBox("a = " + a);
            AddToTextBox("a += b  : " + (a += b));
            AddToTextBox("a = " + a);
            AddToTextBox("a - b     : " + (a - b));
            AddToTextBox("a = " + a);
            AddToTextBox("a -= b  : " + (a -= b));
            AddToTextBox("a = " + a);
            AddToTextBox("a * b     : " + (a * b));
            AddToTextBox("a = " + a);
            AddToTextBox("a *= b  : " + (a *= b));
            AddToTextBox("a = " + a);
            AddToTextBox("a / b     : " + (a / b));
            AddToTextBox("a = " + a);
            AddToTextBox("a /= b  : " + (a /= b));
            AddToTextBox("a = " + a);
            a = 10;
            b = ++a;
            AddToTextBox("[b = ++a] ... a=" + a + "   b=" + b);
            a = 10;
            b = a++;
            AddToTextBox("[b = a++] ... a=" + a + "   b=" + b);
        }
    }
}
