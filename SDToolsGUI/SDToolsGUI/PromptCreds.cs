using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
DEPRECATED:
This form was to be used in case SDTools was unable to map to the MDT server using the credentials enter on the UAC prompt. It is currently not implemented anywhere.
*/
namespace SDToolsGUI
{
    public partial class PromptCreds : Form
    {
        public PromptCreds()
        {
            InitializeComponent();
        }

        private void Map_Drive(object send, EventArgs e)
        {
            /// Declare the network path and credentials for connecting to labserverwin.
            string server = @"\\mdt\deploy$";
            string newpath = "use Z: " + server;
            string user = textBox1.Text;
            string pwd = textBox2.Text;
            string fullpath = newpath + " " + "/user:" + user + " " + pwd;
            try
            {
                Process.Start("net.exe", fullpath);

                Thread.Sleep(2000); // Wait two seconds before executing...

                string litetouch = server + @"\scripts\litetouch.vbs";

                Process.Start(litetouch);

                Thread.Sleep(5000); // Wait five more seconds...

                Form1 frm = new Form1();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            catch { MessageBox.Show("ERROR"); };
        }

        private void Exit(object send, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Help(object sender, EventArgs e)
        {
            Help_Form frm = new Help_Form();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }


    }
}
