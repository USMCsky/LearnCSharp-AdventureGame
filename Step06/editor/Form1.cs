using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace editor {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.OpenFileDialog openFile1;
        private System.Windows.Forms.SaveFileDialog saveFile1;
        private IContainer components;

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
            this.components = new System.ComponentModel.Container();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "&Word count";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(624, 365);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem6,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&Open";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "&Save";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "&New";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "E&xit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8});
            this.menuItem7.Text = "Tools";
            // 
            // openFile1
            // 
            this.openFile1.DefaultExt = "rtf";
            // 
            // saveFile1
            // 
            this.saveFile1.DefaultExt = "rtf";
            this.saveFile1.FileName = "doc1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 365);
            this.Controls.Add(this.richTextBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }

        private void menuItem2_Click(object sender, EventArgs e) {

            openFile1.DefaultExt = "rtf";
            openFile1.Filter = "RTF Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";

            if (openFile1.ShowDialog() == DialogResult.OK &&
                openFile1.FileName.Length > 0) {    // Load file into the RichTextBox.
                if (openFile1.FilterIndex == 1) {
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
                } else
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void menuItem6_Click(object sender, EventArgs e) {

            saveFile1.DefaultExt = "rtf";
            saveFile1.Filter = "RTF Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";

            if (saveFile1.ShowDialog() == DialogResult.OK &&
                saveFile1.FileName.Length > 0) {
                saveFile1.AddExtension = true;
                if (System.IO.Path.GetExtension(saveFile1.FileName) == "") {
                    saveFile1.FileName = saveFile1.FileName + ".xxx";
                }

                // Save contents of RichTextBox to file.
                if (saveFile1.FilterIndex == 1) {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                } else
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void menuItem3_Click(object sender, System.EventArgs e) {
            richTextBox1.Clear();
        }

        private void menuItem5_Click(object sender, System.EventArgs e) {
            Application.Exit();
        }

        private void menuItem8_Click(object sender, System.EventArgs e) {
            // add word count code here...
        }
    }
}
