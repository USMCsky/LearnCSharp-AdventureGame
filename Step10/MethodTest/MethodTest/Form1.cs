using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MethodTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e) {
            A mya1 = new A();
            B myb1 = new B();

            List<A> oblist = new List<A>();
            oblist.Add(mya1);
            oblist.Add(myb1);

            textBox1.AppendText("*Calling each object specifically*\r\n");
            textBox1.AppendText(mya1.Method1());
            textBox1.AppendText(mya1.Method2());
            textBox1.AppendText(mya1.Method3());
            textBox1.AppendText(myb1.Method1());
            textBox1.AppendText(myb1.Method2());
            textBox1.AppendText(myb1.Method3());
            textBox1.AppendText("*Calling each object as an instance of class A*\r\n");
            foreach (A aOb in oblist) {
                textBox1.AppendText("Object's class is: " + aOb.ToString() + "\r\n");
                textBox1.AppendText(aOb.Method1());
                textBox1.AppendText(aOb.Method2());
                textBox1.AppendText(aOb.Method3());
            }
        }
    }
}
