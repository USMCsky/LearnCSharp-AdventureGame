using System;
using System.Collections;
using System.IO; // For Directory
using System.Windows.Forms;

namespace Dir {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private System.Windows.Forms.Button dirBtn;
        private System.Windows.Forms.Button sysdirBtn;
        private System.Windows.Forms.Button envBtn;
        private System.Windows.Forms.Button sysinfBtn;
        private System.Windows.Forms.Button pathBtn;
        private Button exitBtn;
        private TextBox textBox1;

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
            this.dirBtn = new System.Windows.Forms.Button();
            this.sysdirBtn = new System.Windows.Forms.Button();
            this.envBtn = new System.Windows.Forms.Button();
            this.sysinfBtn = new System.Windows.Forms.Button();
            this.pathBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dirBtn
            // 
            this.dirBtn.Location = new System.Drawing.Point(12, 213);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(128, 23);
            this.dirBtn.TabIndex = 1;
            this.dirBtn.Text = "Directory Test";
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // sysdirBtn
            // 
            this.sysdirBtn.Location = new System.Drawing.Point(146, 213);
            this.sysdirBtn.Name = "sysdirBtn";
            this.sysdirBtn.Size = new System.Drawing.Size(128, 23);
            this.sysdirBtn.TabIndex = 2;
            this.sysdirBtn.Text = "File in System Dir";
            this.sysdirBtn.Click += new System.EventHandler(this.sysdirBtn_Click);
            // 
            // envBtn
            // 
            this.envBtn.Location = new System.Drawing.Point(280, 213);
            this.envBtn.Name = "envBtn";
            this.envBtn.Size = new System.Drawing.Size(128, 23);
            this.envBtn.TabIndex = 3;
            this.envBtn.Text = "Environment Test";
            this.envBtn.Click += new System.EventHandler(this.envBtn_Click);
            // 
            // sysinfBtn
            // 
            this.sysinfBtn.Location = new System.Drawing.Point(12, 242);
            this.sysinfBtn.Name = "sysinfBtn";
            this.sysinfBtn.Size = new System.Drawing.Size(128, 23);
            this.sysinfBtn.TabIndex = 4;
            this.sysinfBtn.Text = "System Information";
            this.sysinfBtn.Click += new System.EventHandler(this.sysinfBtn_Click);
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(146, 242);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(128, 23);
            this.pathBtn.TabIndex = 5;
            this.pathBtn.Text = "Path Test";
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(280, 242);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(128, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(393, 195);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(417, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.sysinfBtn);
            this.Controls.Add(this.envBtn);
            this.Controls.Add(this.sysdirBtn);
            this.Controls.Add(this.dirBtn);
            this.Name = "Form1";
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

        private void dirBtn_Click(object sender, System.EventArgs e) {
            string[] drives;
            string currdir;
            string dirroot;
            string[] subdirs;
            string pfdir;
            string sysdir;

            textBox1.Clear();
            // Drives
            try {
                drives = Directory.GetLogicalDrives();
                foreach (string drive in drives) {
                    textBox1.AppendText(drive + "\r\n");
                }
            } catch (Exception ex) {
                textBox1.AppendText(ex.Message + "\r\n");
            }

            // Current Directory
            currdir = Directory.GetCurrentDirectory();
            textBox1.AppendText("GetCurrentDirectory() = " + currdir + "\r\n");

            // Root (top-level) directory
            dirroot = Directory.GetDirectoryRoot(currdir);
            textBox1.AppendText("GetDirectoryRoot() = " + dirroot + "\r\n");

            // SubDirectories
            subdirs = Directory.GetDirectories(dirroot);
            foreach (string sd in subdirs) {
                textBox1.AppendText(sd + "\r\n");
            }

            // Program Files Dir
            pfdir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            textBox1.AppendText("Program Files Dir = " + pfdir + "\r\n");

            // System Dir
            sysdir = Environment.SystemDirectory;
            textBox1.AppendText("System Dir = " + sysdir + "\r\n");

        }

        private void sysdirBtn_Click(object sender, System.EventArgs e) {
            // Files in System Dir
            string[] files;

            textBox1.Clear();
            files = Directory.GetFiles(Environment.SystemDirectory);
            textBox1.AppendText("Files in System Directory");
            foreach (string fn in files) {
                textBox1.AppendText(fn + "\r\n");
            }
        }

        private void envBtn_Click(object sender, System.EventArgs e) {
            string[] subdirs;
            OperatingSystem osver;
            IDictionary envvars;
            string homedrive;
            string gribbit;

            textBox1.Clear();
            textBox1.AppendText("Cookies Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\r\n");
            textBox1.AppendText("StartMenu Directory = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\r\n");
            textBox1.AppendText("Machine Name = " + Environment.MachineName + "\r\n");
            textBox1.AppendText("User Name = " + Environment.UserName + "\r\n");
            textBox1.AppendText("CLR Version = " + Environment.Version + "\r\n");

            // SubDirectories
            textBox1.AppendText("Files in Program Files folder:\n");
            subdirs = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            foreach (string sd in subdirs) {
                textBox1.AppendText(sd + "\r\n");
            }

            // OS
            osver = Environment.OSVersion;
            textBox1.AppendText("OS Version = " + osver + "\r\n");
            textBox1.AppendText("OS Platform and Version = " + osver.Platform + ":" + osver.Version + "\r\n");


            // Get all environment variables
            envvars = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in envvars) {
                textBox1.AppendText(de.Key + " = " + de.Value + "\r\n");
            }

            // Get a specific variable
            homedrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
            if (homedrive == null) {
                homedrive = "Error: Environment Variable not found.";
            }

            textBox1.AppendText("HOMEDRIVE=[" + homedrive + "]\n");

            // Dealing with non existent variables
            gribbit = Environment.GetEnvironmentVariable("GRIBBIT");
            if (gribbit == null) {
                gribbit = "Error: Environment Variable not found.";
            }

            textBox1.AppendText("GRIBBIT=[" + gribbit + "]\n");

        }

        private void sysinfBtn_Click(object sender, System.EventArgs e) {
            textBox1.Clear();
            textBox1.AppendText("Boot Mode = " + SystemInformation.BootMode + "\r\n");
            textBox1.AppendText("Icon Size = " + SystemInformation.IconSize + "\r\n");
            textBox1.AppendText("Small Icon Size = " + SystemInformation.SmallIconSize + "\r\n");
            textBox1.AppendText("Menu Font = " + SystemInformation.MenuFont + "\r\n");
            textBox1.AppendText("Network = " + SystemInformation.Network + "\r\n");
            textBox1.AppendText("Working Area = " + SystemInformation.WorkingArea + "\r\n");
        }

        private void pathBtn_Click(object sender, System.EventArgs e) {
            string path = Application.ExecutablePath;
            textBox1.Clear();
            textBox1.AppendText("Application.ExecutablePath=" + path + "\r\n");
            textBox1.AppendText("Path.GetDirectoryName=" + Path.GetDirectoryName(path) + "\r\n");
            textBox1.AppendText("Path.GetExtension=" + Path.GetExtension(path) + "\r\n");
            textBox1.AppendText("Path.GetFileName= " + Path.GetFileName(path) + "\r\n");
            textBox1.AppendText("Path.GetFileNameWithoutExtension=" + Path.GetFileNameWithoutExtension(path) + "\r\n");
            textBox1.AppendText("Path.GetPathRoot=" + Path.GetPathRoot(path) + "\r\n");
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

