using System;
using System.Windows.Forms;

namespace test {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "DelimCount1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Word Count";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 223);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "This is some text.\n\r\nIt contains 12 words, not counting 15 delimiters!!!";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 297);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }

        char[] DELIMS = new char[10] { ' ', '.', ',', '?', '!', '-', '_', '+', '*', '/' };
        int charcount = 0;

        private bool IsDelimiter(char c) {
            bool delimfound = false;
            foreach (char mychar in DELIMS) {
                if (mychar == c)
                    delimfound = true;
            }
            return delimfound;
        }

        private void FindDelims() {
            string s = textBox1.Text;
            int delimcount = 0;
            for (int i = 0; i < s.Length; i++) {
                if (IsDelimiter(s[i]))
                    delimcount++;
            }
            MessageBox.Show("delimcount=" + delimcount,
                "Statistics",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool ScrollThroughWord(string s) {
            bool wordfound = false;
            while ((charcount < s.Length) && !(IsDelimiter(s[charcount]))) {
                charcount++;
                wordfound = true;
            }
            return wordfound;
        }

        private void ScrollThroughDelims(string s) {
            while ((charcount < s.Length) && IsDelimiter(s[charcount])) {
                charcount++;
            }
        }

        private void CountWordsAndCharacters() {
            string s = textBox1.Text;
            charcount = 0;
            int wordcount = 0;
            while (charcount < s.Length) {
                ScrollThroughDelims(s);
                if (ScrollThroughWord(s)) {
                    wordcount++;
                }
            }
            this.Text = "Number of words: " + wordcount + " Characters: " + charcount;
        }

        private void button1_Click(object sender, System.EventArgs e) {
            FindDelims();
        }

        private void button3_Click(object sender, EventArgs e) {
            CountWordsAndCharacters();
        }

    }
}
