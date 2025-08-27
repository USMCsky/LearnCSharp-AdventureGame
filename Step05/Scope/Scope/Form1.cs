using System;
using System.Windows.Forms;

namespace Scope {

    public class A {
        public int x;
        private int y;
        protected int z;

        public A() {
            x = 100;
            y = 200;
            z = 300;
        }

        public int Gety() {
            return y;
        }

    }

    public class B : A {
        public int Getz() {
            return z;
        }

        //public int Gety() {
        //    return y;
        //}

    }

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            B b = new B();
            textBox1.AppendText("b.x=" + b.x + "\r\n");
            // textBox1.AppendText("b.y=" + b.y + "\r\n");
            // textBox1.AppendText("b.z=" + b.z + "\r\n");            
            textBox1.AppendText("b.Gety=" + b.Gety() + "\r\n");
            textBox1.AppendText("b.Getz=" + b.Getz() + "\r\n");
        }
    }
}
