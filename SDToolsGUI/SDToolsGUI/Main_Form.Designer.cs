namespace SDToolsGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        /// Resources:
        /// How to access Settings in Control Panel: https://stackoverflow.com/questions/29891963/how-to-open-windows-settings-pages-from-code-in-c
        /// How to close an application: https://social.msdn.microsoft.com/Forums/windows/en-US/13e34c62-52c7-45b3-8bb4-16d9574d76be/how-to-close-c-form?forum=winforms
        /// List of Control Panel Applets: https://www.lifewire.com/command-line-commands-for-control-panel-applets-2626060
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Change_Res);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Network Connections";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Network_Con);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Task Manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Task_Mgr);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Regedit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Regedit);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Notepad";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Notepad);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(155, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "File Explorer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.File_Expl);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 240);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Reimage PC";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Reimage);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "Map Network Drive";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Map_Drive);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 82);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 269);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Update SDTools";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Update_SDTools);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(155, 211);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "Sound Manager";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Sound_Man);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 182);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(117, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = "Device Manager";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Device_Man);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 211);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 23);
            this.button13.TabIndex = 8;
            this.button13.Text = "Disk Utility";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Disk_Util);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(261, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Help);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(155, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 23);
            this.button14.TabIndex = 5;
            this.button14.Text = "Add a Printer";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Add_Printer);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Paint";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Open_Paint);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 298);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "Uninstall a Program";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Uninstall_Program);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(155, 298);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(117, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "System Properties";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.System_Properties);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 331);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SDTools";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

