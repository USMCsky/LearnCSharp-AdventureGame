using System;
using System.Windows.Forms;

namespace Methods {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ShowMessage(string aString, int aNumber) {
            textBox1.AppendText(aString + aNumber + "\r\n");
        }

        private string ReturnMessage(string aString, int aNumber) {
            return aString + aNumber + "\r\n";
        }

        private void ShowMessage(string aMessage) {
            textBox1.AppendText(aMessage + "\r\n");
        }

        private string AddNumbers(int num1, int num2) {
            return "The total of " + num1 + " plus " + num2 + " is " + (num1 + num2) + "\r\n";
        }

        private int Add(int num1, int num2) {
            return num1 + num2;
        }

        private int Add10(int num1) {
            return num1 + 10;
        }

        private void Greet(string aName) {
            textBox1.AppendText("Hello, " + aName + "\r\n");
        }

        private void SayHello() {
            textBox1.AppendText("Hello\r\n");
        }

        private void testBtn_Click(object sender, EventArgs e) {
            string calcResult;
            string someName;
            string aMsg;
            int total;
            int totalPlusTen;
            textBox1.Clear();
            SayHello();
            Greet("Mary");
            someName = "Fred";
            Greet(someName);
            calcResult = AddNumbers(100, 200);
            total = Add(60, 12);
            totalPlusTen = Add10(total);
            textBox1.AppendText("total = " + total + "\r\n");
            textBox1.AppendText("total plus 10 = " + totalPlusTen + "\r\n");
            textBox1.AppendText("25 + 15 = " + Add(25, 15) + "\r\n");
            textBox1.AppendText(calcResult);
            textBox1.AppendText(AddNumbers(550, 750));
            ShowMessage(AddNumbers(3000, 7000));
            ShowMessage("You have $", 500);
            aMsg = ReturnMessage("You have £", 100);
            textBox1.AppendText(aMsg);
            textBox1.AppendText(ReturnMessage("I have $", 800));
        }

        private void OutParams(out int num1, out int num2) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText("In outParams, num1 = " + num1 + ", num2 = " + num2 + "\r\n");
        }

        private void ByReference(ref int num1, ref int num2) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText("In byReference, num1 = " + num1 + ", num2 = " + num2 + "\r\n");
        }

        private void ByValue(int num1, int num2) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText("In byValue, num1 = " + num1 + ", num2 = " + num2 + "\r\n");
        }

        private void paramTestBtn_Click(object sender, EventArgs e) {
            int firstnumber;
            int secondnumber;

            textBox1.Clear();

            // I can use uninitialized variables as arguments when they are 'out parameters'        
            OutParams(out firstnumber, out secondnumber);
            textBox1.AppendText("Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\r\r\n\r\r\n");

            firstnumber = 10;
            secondnumber = 20;

            ByValue(firstnumber, secondnumber);
            textBox1.AppendText("Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\r\r\n\r\r\n");

            firstnumber = 10;
            secondnumber = 20;
            ByReference(ref firstnumber, ref secondnumber);
            textBox1.AppendText("Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\r\n");

        }
    }
}
