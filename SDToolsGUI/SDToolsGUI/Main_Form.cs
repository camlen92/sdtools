using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

/// 
/// Resources: 
/// How to make a program wait for x amount of time: https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program
/// How to make a popup message window: https://www.dotnetperls.com/messagebox-show
/// How to switch between forms: https://stackoverflow.com/questions/5848154/winforms-switching-between-forms
/// 
/*
Main Form
This form will display all available options for the user to perform.
*/
namespace SDToolsGUI
{
    public partial class Form1 : Form
    {
        /*
         * Form Constructor
         */
        public Form1()
        {
            InitializeComponent();
            //this.Load += (s, ev) => Process.Start("CMD.exe", @"/c net use I: \\labserverwin\support /y");
            this.Closed += (s, ev) => Process.Start("CMD.exe", "/c net use * /delete /y"); // Unmap all drives that were mapped during use of SDToolsGUI
            this.Closed += (s, ev) => Application.Exit(); // Closes all Forms when the 'X' button, the 'Exit' button, or when the program is killed through Task Manager.
        }
        /*
         * Change Resolution function calls the Change_Res_Form and creates a new window, hiding this one.
         */
        private void Change_Res(object sender, EventArgs e)
        {
            /*
            // This function calls the Change_Res_Form, opens it, and hides the current form.
            Change_Res_Form frm = new Change_Res_Form();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            */
            try
            {
                Process.Start(@"C:\Windows\System32\DriverStore\FileRepository\ki121375.inf_amd64_6b646dfedcbc3939\Gfxv4_0.exe");    
            }
            catch
            {
                Change_Res_Form frm = new Change_Res_Form();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
                
            }
                    
        }
        /*
         * Remotely reimage a computer using Litetouch on the MDT server.
         */
        private void Reimage(object send, EventArgs e)
        {
            // Declare the network path and credentials for connecting to MDT server.
            string server = @"\\mdt\deploy$";
            string netUser = "******";
            string netPwd = "******";
            string fullpath = "use Z: " + server + " " + "/user:" + netUser + " " + netPwd;
            
            // Map the MDT server to the Z: drive letter.
            Process.Start("net.exe", fullpath);

            Thread.Sleep(2000); // Wait two seconds before executing...
            
            string litetouch = server + @"\scripts\litetouch.vbs"; // Path to Litetouch.vbs on the MDT server

            //Begin reimaging process
            Process.Start(litetouch);

            Thread.Sleep(5000); // Wait five more seconds...            
        }

        /*
         * Automatically update SDTools through a single button click.
         */
        private void Update_SDTools(object sender, EventArgs e)
        {
            string fullpath = @"use I: \\labserverwin\support /user:ad\****** *******"; // Map to the I: drive where the latest SDToolsGUI.exe is stored.

            // Map the I: drive
            Process.Start("net.exe", fullpath);

            // Create a .bat file which copies the latest version of SDToolsGUI, restarts another SDTools after closing, and then deletes itself.
            StreamWriter updater = new StreamWriter("C:\\app\\SDTools\\updater.bat"); // StreamWriter allow SDToolsGUI to write lines of text to a text document. In this case, a .bat file.
            updater.WriteLine("@echo off");
            updater.WriteLine("echo updating...");
            updater.WriteLine("xcopy \"I:\\IDM Team\\DM\\SDTools\\SDToolsGUI\\SDTools.exe\" C:\\app\\sdtools /y");
            updater.WriteLine("@timeout 5"); // Wait 5 seconds so that the original SDToolsGUI process closes before starting it again.
            updater.WriteLine("start C:\\app\\SDTools\\SDtools.exe");
            updater.WriteLine("(goto) 2>nul & del \"%~f0\"");
            updater.Close();

            string localpath = @"c:\app\SDTools\updater.bat"; // Run the updater.bat file
            
            // Start the updating process
            Process.Start(localpath);

            // Close the current SDTools process
            Application.Exit();
        }
        /*
         * Map a Network Drive through SDTools
         */
        private void Map_Drive(object sender, EventArgs e)
        {
            // This function calls the Map_Drive_Form, opens it, and hides the current form.
            Map_Drive_Form frm = new Map_Drive_Form();
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
         * Open Network Connections
         */
        private void Network_Con(object send, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }
        /*
         * Open Task Manager
         */
        private void Task_Mgr(object send, EventArgs e)
        {
            Process.Start("taskmgr");
        }
        /*
         * Open Registry Editor
         */
        private void Regedit(object send, EventArgs e)
        {
            Process.Start("regedit");
        }
        /*
         * Open Notepad
         */
        private void Notepad(object send, EventArgs e)
        {
            Process.Start("notepad");
        }
        /*
         * Open File Explorer
         */
        private void File_Expl(object send, EventArgs e)
        {
            string comp_name = Environment.MachineName;
            string drive = @"\\" + comp_name + @"\c$"; // Psuedo-map the C: drive so it shows in File Explorer
            Process.Start("explorer.exe", drive);
        }
        /*
         * Open Device Manager
         */
        private void Device_Man(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }
        /*
         * Open Disk Utility
         */
        private void Disk_Util(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");
        }
        /*
         * Open Sound Manager
         */
        private void Sound_Man(object sender, EventArgs e)
        {
            Process.Start("mmsys.cpl");
        }
        /*
         * Add a network printer through MTCAD07
         */
        private void Add_Printer(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"\\mtcad07");
        }
        /*
         * Close and exit the application
         */
        private void Open_Paint(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void Uninstall_Program(object sender, EventArgs e)
        {
            Process.Start("appwiz.cpl");
        }

        private void System_Properties(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }
    }
}
