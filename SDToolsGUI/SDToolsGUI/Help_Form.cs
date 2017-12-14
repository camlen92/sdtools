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

/*
Help Form
This form will display instructions on how to use SDTools.
*/
namespace SDToolsGUI
{
    public partial class Help_Form : Form
    {
        public Help_Form()
        {
            InitializeComponent();
            this.Closed += (s, ev) => Process.Start("CMD.exe", "/c net use * /delete /y"); // Unmap all drives that were mapped during use of SDToolsGUI
            this.Closed += (s, ev) => Application.Exit(); // Closes all Forms when the 'X' button, the 'Exit' button, or when the program is killed through Task Manager.
        }
        /*
         * Return to the previous Form.
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
         * Close and exit the application
         */
        private void Close_App(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
