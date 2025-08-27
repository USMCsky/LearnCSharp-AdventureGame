using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassesAndMore {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void test1Btn_Click(object sender, EventArgs e) {
            MyClass ob1;
            MyClass ob2;
            //  MyStaticClass ob3;
            ob1 = new MyClass("Hello World");
            ob2 = new MyClass();
            //  ob3 = new MyStaticClass( ); // ERROR: Can't create object from static class!
            textBox1.AppendText(ob1.ToLowCase() + "\r\n");
            textBox1.AppendText(ob2.ToLowCase() + "\r\n");
            textBox1.AppendText(ob1.ToReversedLowCase() + "\r\n");
            textBox1.AppendText(MyClass.ToLowCase("ABc") + "\r\n");
            textBox1.AppendText(MyClass.ToUppCase("abC") + "\r\n");
            textBox1.AppendText(MyClass.Capitalize("hello world"));
        }

        private void structTestBtn_Click(object sender, EventArgs e) {
            MyPointStruct mypt;
            Point mypoint;
            mypt = new MyPointStruct(10, 20);
            mypoint = mypt.AsPoint();
            textBox1.Text = "MyPointStruct x = " + mypt.X + " and MyPointStruct y = " + mypt.Y;
            textBox1.AppendText("\r\n" + "Point x = " + mypoint.X + " and Point y = " + mypoint.Y);
        }

        private void enumTestBtn_Click(object sender, EventArgs e) {
            string suit = suitsComboBox.Text;
            CardSuits selectedSuit;
            switch (suit) {
                case "Clubs":
                    selectedSuit = CardSuits.Clubs;
                    break;
                case "Spades":
                    selectedSuit = CardSuits.Spades;
                    break;
                case "Hearts":
                    selectedSuit = CardSuits.Hearts;
                    break;
                case "Diamonds":
                    selectedSuit = CardSuits.Diamonds;
                    break;
                default:
                    selectedSuit = CardSuits.Unknown;
                    break;
            }
            textBox1.Text = selectedSuit.ToString();
        }

        private void cardEnumTestBtn_Click(object sender, EventArgs e) {
            string card = pictureCardsComboBox.Text;
            PictureCards selectedCard;
            switch (card) {
                case "Jack":
                    selectedCard = PictureCards.Jack;
                    break;
                case "Queen":
                    selectedCard = PictureCards.Queen;
                    break;
                case "King":
                    selectedCard = PictureCards.King;
                    break;
                default:
                    selectedCard = PictureCards.NotAPictureCard;
                    break;
            }
            textBox1.Text = "You picked " + card + " with the value: " + (int)selectedCard;

        }

        private void colorBtn_Click(object sender, EventArgs e) {
            textBox1.Dock = DockStyle.Top;
        }

        private void dockTopRightBtn_Click(object sender, EventArgs e) {
            textBox1.Dock = DockStyle.Right;
        }

        private void anchorTopRightBtn_Click(object sender, EventArgs e) {
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void anchorBottomLeftBtn_Click(object sender, EventArgs e) {
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

    }
}
