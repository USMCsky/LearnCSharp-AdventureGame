using System;
using System.Windows.Forms;

namespace TaxCalc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        // calculate and display tax and grandtotal based on subtotal
        private void calcBtn_Click(object sender, EventArgs e) {
            const double TAXRATE = 0.2;
            double subtotal = Double.Parse(subtotalTB.Text);
            double tax = subtotal * TAXRATE;
            double grandtotal = subtotal + tax;
            int roundedTotal;
            subtotalTB.Text = subtotal.ToString();
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
            roundedTotal = (int)grandtotal;
            this.Text = roundedTotal.ToString();
        }

        /*
         *  this is an alternative version where the variable are declared and initialized to zero
        private void calcBtn_Click(object sender, EventArgs e) {
            const double TAXRATE = 0.2;
            double subtotal;
            double tax;
            double grandtotal;
            int roundedTotal;
            subtotal = Double.Parse(subtotalTB.Text);
            tax = subtotal * TAXRATE;
            grandtotal = subtotal + tax;
            taxTB.Text = tax.ToString();
            grandTotalTB.Text = grandtotal.ToString();
            // roundedTotal = (int)grandtotal;          // Here I could cast to int
            roundedTotal = Convert.ToInt32(grandtotal); // But I prefer to use the ToInt32 method
            this.Text = roundedTotal.ToString();
        }
        */


    }
}
