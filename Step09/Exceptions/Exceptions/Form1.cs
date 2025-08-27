using System;
using System.Windows.Forms;

namespace Exceptions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            double st = Convert.ToDouble(subTotBox.Text);
            double tax = st * 0.175;
            double gt = st + tax;

            taxBox.Text = tax.ToString();
            grandTotBox.Text = gt.ToString();
        }

        private void calc2Btn_Click(object sender, EventArgs e) {
            double st = 0.0;
            double tax = 0.0;
            double gt = 0.0;

            try {
                st = Convert.ToDouble(subTotBox.Text);
            } catch (Exception exc) {
                MessageBox.Show("Awfully sorry to bother you, " +
                    "but apparently the " + exc.Message,
                    "Oops! There has been an error of the type: " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tax = st * 0.175;
            gt = st + tax;
            taxBox.Text = tax.ToString();
            grandTotBox.Text = gt.ToString();
        }

        private void calc3Btn_Click(object sender, EventArgs e) {
            int st = 0;
            double tax = 0.0;
            double gt = 0.0;

            try {
                st = Convert.ToInt32(subTotBox.Text);
            } catch (OverflowException exc) {
                MessageBox.Show("Try a smaller number! "
                    + exc.Message,
                    "Yikes! Overflow error: " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } catch (Exception exc) {
                MessageBox.Show("Awfully sorry to bother you, " +
                    "but apparently the " + exc.Message,
                    "Oops! There seems to have been a slight " +
                    "error of the type: " + exc.GetType(),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tax = st * 0.175;
            gt = st + tax;
            taxBox.Text = tax.ToString();
            grandTotBox.Text = gt.ToString();
        }

        private void calc4Btn_Click(object sender, EventArgs e) {
            double st = 0.0;
            double tax = 0.0;
            double gt = 0.0;
            string inputtext = null;
            string msg = "Goodbye. See you next time!";

            try {
                st = Convert.ToDouble(subTotBox.Text);
                inputtext = subTotBox.Text;
            } catch (Exception) {
                if (inputtext.Length == 0) {
                    MessageBox.Show("You must enter some data " +
                        "into the subtotal field", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } finally {
                MessageBox.Show("Thank you for using our calculator", "Goodbye",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tax = st * 0.175;
                gt = st + tax;
                taxBox.Text = tax.ToString();
                grandTotBox.Text = gt.ToString();
                statusLabel.Text = msg;
            }

        }

        private void calc5Btn_Click(object sender, EventArgs e) {
            double st = 0.0;
            double tax = 0.0;
            double gt = 0.0;
            string inputtext = null;
            string msg = "Goodbye. See you next time!";

            try {
                st = Convert.ToDouble(subTotBox.Text);
                inputtext = subTotBox.Text;
            } catch (Exception) {
                try {
                    if (inputtext.Length == 0) {
                        MessageBox.Show("You must enter some data into the subtotal field", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception exc2) {
                    MessageBox.Show("Program Bug. Please contact support. Error was: " + exc2.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } finally {
                MessageBox.Show("Thank you for using our calculator", "Goodbye",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tax = st * 0.175;
                gt = st + tax;
                taxBox.Text = tax.ToString();
                grandTotBox.Text = gt.ToString();
                statusLabel.Text = msg;
            }

        }

    }
}
