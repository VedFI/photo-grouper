using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoGrouper
{
    public partial class AppForm : Form
    {
        public static string source_directory = "";
        public static string destination_directory= "";
        public static Stack<string> directories = new Stack<string>();
        public static int photos_count = 0;
        public Utilities util;
        public static int operation=0; //0 is copy, 1 is move.

        public AppForm()
        {
            InitializeComponent();
            directories = new Stack<string>();
            RadioButton_Copy.Checked = true;
            util = new Utilities(this);
        }

        public void setProgressBar(int min,int max,int tick)
        {
            ProgressBar.Maximum = max;
            ProgressBar.Minimum = min;
            ProgressBar.Step = tick;
        }

        public void performStep()
        {
            ProgressBar.PerformStep();
            Application.DoEvents();
        }

        private int checkOperation()
        {
            return RadioButton_Copy.Checked ? 0 : 1;
        }

        public void checkButton()
        {
            if(destination_directory.Length!=0 && source_directory.Length != 0)
            {
                Button_Analyze.Enabled = true;
            }
            Button_Start.Enabled = false;
        }

        public void addLog(String message)
        {
            TextBox_Log.AppendText(message + Environment.NewLine);
        }

        private void updateStatus(String message)
        {
            Label_Status.Text = message;
        }

        private void Button_Source_Click(object sender, EventArgs e)
        {
            using(var folderDialog = new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK)
                {
                    source_directory = folderDialog.SelectedPath;
                    TextBox_Source.Text = source_directory;
                    addLog("Source Directory: " + source_directory);
                    directories.Clear();

                }
            }
            checkButton();
        }

        private void Button_Destination_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    destination_directory = folderDialog.SelectedPath;       
                    TextBox_Destination.Text = destination_directory;
                    addLog("Destination Directory: " + destination_directory);

                }
            }   
            checkButton();
        }

        private void Button_Analyze_Click(object sender, EventArgs e)
        {
            Button_Start.Enabled = false;
            Button_Analyze.Enabled = false;
            this.ControlBox = false;
            directories.Clear();
            directories.Push(source_directory);
            updateStatus("Analyzing..");
            addLog("Finding directories...");
            ProgressBar.Value = 0;
            Application.DoEvents();
            util.findDirectories(source_directory);
            addLog("Number of directories: " + directories.Count+ "\r\nFinding photos...");
            util.findNumberOfPhotos();
            ProgressBar.PerformStep();
            addLog("Number of photos: " + photos_count);
            updateStatus("Found "+photos_count+" photos inside "+directories.Count+" directories.");
            this.ControlBox = true;
            Button_Analyze.Enabled = true;
            Button_Start.Enabled = true;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            DialogResult warning = new DialogResult();
            warning = MessageBox.Show("Do not close the app while grouping." +
                "\r\nWhen using the move mode, make sure to take a backup of your " +
                "photos in order to avoid loss in case of a possible error. \r\nDo you want to continue?"
                , "Warning!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(warning == DialogResult.Yes)
            {
                operation = checkOperation();
                this.ControlBox = false;
                RadioButton_Copy.Enabled = false;
                RadioButton_Move.Enabled = false;
                Button_Start.Enabled = false;
                Button_Analyze.Enabled = false;
                Button_Source.Enabled = false;
                Button_Destination.Enabled = false;
                updateStatus("Grouping...");
                String msg = (operation == 0) ? "Grouping process starts in copy mode." :
                    "Grouping process starts in move mode.";
                addLog(msg);
                ProgressBar.Value = 0;
                Application.DoEvents();
                util.grouper(this);
                addLog("Grouping process is completed.");
                updateStatus("Grouping process is completed. (" + photos_count+" photos)");
                RadioButton_Copy.Enabled = true;
                RadioButton_Move.Enabled = true;
                Button_Source.Enabled = true;
                Button_Destination.Enabled = true;
                Button_Analyze.Enabled = true;
                Button_Start.Enabled = false;
                this.ControlBox = true;
                Application.DoEvents();
            }
            else
            {
                //do nothing.
            }
        }

        private void Label_Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/vedfi");
        }
    }
}
