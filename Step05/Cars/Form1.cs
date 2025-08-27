using System;
using System.Windows.Forms;

namespace Cars {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        class Car {
            private string _name;
            private int _speed;


            public Car() {
                _name = "Generic Car\r\n";
                _speed = 0;
            }

            public string GetName() {
                return _name;
            }

            public void SetName(string aString) {
                _name = aString;
            }

            public int GetSpeed() {
                return _speed;
            }

            public void SetSpeed(int aSpeed) {
                _speed = aSpeed;
            }

            public string Description() {
                // For brevity, I here use 'string interpolation' to embed variables into
                // a string. This is explained in Chapter 6
                return $"This car is a {_name}, with a speed of {_speed} miles per hour.\r\n";
            }

        }

        Car car1;
        Car car2;
        Car car3;

        private void createCarsBtn_Click(object sender, EventArgs e) {
            car1 = new Car();
            car2 = new Car();
            car3 = new Car();
            car2.SetName("Rolls Royce\r\n");
            car3.SetName("Cadillac\r\n");
            car1.SetSpeed(80);
            car2.SetSpeed(120);
            car3.SetSpeed(100);
        }

        private void showCarsBtn_Click(object sender, EventArgs e) {
            // The program will crash if you try to use car objects before they have been constructed.
            // Uncomment the code below to fix this.
            /*    if (car1 == null || car2 == null || car3 == null) {
                    textBox1.Text = "No cars have been constructed!\r\n";
                } else 
                */
            {
                textBox1.AppendText(car1.Description());
                textBox1.AppendText(car2.Description());
                textBox1.AppendText(car3.Description());
            }
        }
    }
}
