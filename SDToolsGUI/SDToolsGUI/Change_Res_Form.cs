using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*
Change Resolution Form
This form will allow a user to manipulate display settings using MultiMonitorTool. SDTools only accesses MMT's Maximize Resolution and Set Primary Display commands.
*/
namespace SDToolsGUI
{
    public partial class Change_Res_Form : Form
    {
        /*
         * Form constructor
         */
        public Change_Res_Form()
        {
            //Decompile the mmt.exe resource and rebuild it in the current directory as myMMT.exe
            string mmtPath = Path.Combine(Directory.GetCurrentDirectory(), "myMMT.exe");

            if (!File.Exists(mmtPath))
            {
                using (FileStream fsDst = new FileStream(mmtPath, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = SDTools.Properties.Resources.GetMMT();

                    fsDst.Write(bytes, 0, bytes.Length);
                }
            }

            InitializeComponent();
            this.Closed += (s, ev) => Process.Start("CMD.exe", "/c net use * /delete /y"); // Unmap all drives that were mapped during use of SDToolsGUI
            this.Closed += (s, ev) => Application.Exit(); // Closes all Forms when the 'X' button, the 'Exit' button, or when the program is killed through Task Manager.
        }
        /*
         * Maximize resolution of all displays
         * Limitations: Only accounts for device having three displays. It will only affect three displays in its current state.
         */
        private void Max_Res(object sender, EventArgs e)
        {
            // Gather information for running command line arguments using MultiMonitorTool (mmt.exe)
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory(); // Directory where MultiMonitorTool.exe is stored
            p.StartInfo.FileName = "myMMT.exe"; // Run MultiMonitorTool.exe
            p.StartInfo.Arguments = @" /setmax 1 2 3";
            p.Start();
        }
        /*
         * Set the main display
         */
        private void Set_Main(object sender, EventArgs e)
        {
            int mainMon = 0; // Initialize an int for selecting the monitor number.
            
            // Check which radio button has been checked.
            if (radioButton1.Checked)
            {
                mainMon = 1; // Set monitor int to display 1
            }
            else if (radioButton2.Checked)
            {
                mainMon = 2; // Set monitor int to display 2
            }
            else
            {
                mainMon = 3; // Set monitor int to display 3
            }

            // Gather information for running command line arguments using MultiMonitorTool (mmt.exe)
            Process p = new Process();
            p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            p.StartInfo.FileName = "myMMT.exe";
            p.StartInfo.Arguments = @" /SetPrimary " + mainMon;
            p.Start();
        }
        /*
         * Return to the previous Form
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
    }
}
