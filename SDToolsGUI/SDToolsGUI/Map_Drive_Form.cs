using System;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
Map Drive Form
This form will allow the user to map a network drive. The form takes in parameters for a network drive path and network credentials. It then runs
these parameters as line arguments using the net.exe program.
When SDTools closes, all connections to any network drives are deleted.
*/
namespace SDToolsGUI
{
    public partial class Map_Drive_Form : Form
    {
        /*
         * Form Constructor
         */
        public Map_Drive_Form()
        {
            InitializeComponent();
            this.Closed += (s, ev) => Process.Start("CMD.exe", "/c net use * /delete /y"); // Unmap all drives that were mapped during use of SDToolsGUI
            this.Closed += (s, ev) => Application.Exit(); // Closes all Forms when the 'X' button, the 'Exit' button, or when the program is killed through Task Manager.
        }
        /*
         * Map a Network Drive through SDTools
         */
        private void Map_Drive(object send, EventArgs e)
        {
            // Declare the network path and credentials for connecting to labserverwin.
            // -The Map_Drive_Form has three textboxes that take in the drive path, the username, and the password necessary for mapping a drive.
            // -The Map_Drive function then takes the user's input, appends the necessary information for mapping, maps the drive, and then opens a
            //      new File Explorer window for the network drive.

            // Grab user input
            string path = textBox1.Text;
            string user = textBox2.Text;
            string pwd = textBox3.Text;

            // Append command line arguments for mapping a drive with net.exe
            string newpath = "use Z: " + textBox1.Text;
            string fullpath = newpath + " " + "/user:" + user + " " + pwd;

            // Attempt to map the drive
            try {
                Process.Start("net.exe", fullpath);
                Process.Start("explorer.exe", path);
                textBox2.Text = "ad\\"; // Reset username textbox to have "ad\" at the front for user convenience
                textBox3.Clear(); // Clear the password textbox
            }
            // If failed...
            catch {
                MessageBox.Show("ERROR: Network Drive was not mapped. Please verify that the path is correct and that the user has credentials to access the drive.");
            };
        }
        /*
         * Return to the previous form
         */
        private void Go_Back(object send, EventArgs e)
        {
            // This function calls the Main_Form, opens it, and hides the current form.
            Form1 frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        /*
         * Access the Help Menu
         */
        private void Help(object sender, EventArgs e)
        {
            // This function calls the Help_Form, opens it, and hides the current form.
            Help_Form frm = new Help_Form();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        /*
         * Close and exit the application
         */
        private void Close_App(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Map_Labserverwin(object sender, EventArgs e)
        {
            string path = @"\\labserverwin\support";

            Process.Start("explorer.exe", path);
        }
        private void Map_Common(object sender, EventArgs e)
        {
            string path = @"\\appsfileserver\common";

            Process.Start("explorer.exe", path);
        }
    }
}
