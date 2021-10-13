using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SignatureMover.Properties;

namespace SignatureMover
{
    public partial class FormMain : Form
    {
        //External Classes
        MethodsCommon methods = new MethodsCommon();

        //Lists
        List<string> inputFiles = new List<string>();

        public FormMain()
        {
            InitializeComponent();
            
            //Check Network connections before running the hotfolders
            if (methods.networkCheck())
            {
                //Run Hotfolder Check
                tHotfolder.Tick += new EventHandler(hotFolderParse);
                }
            else
            {
                //Server Connection Error
                bStart.Enabled = false;
                rtbOutputText.AppendText(DateTime.Now + " | Connect to the required paths or fix paths in settings.\r\n", Color.Red, FontStyle.Bold);
            }
        }

        private void hotFolderParse(Object source, EventArgs e)
        {
            try
            {
                //Check files in the hotfolder directory and add supported file types to the to do list
                DirectoryInfo dinfo = new DirectoryInfo(Settings.Default.InputPath);
                FileInfo[] Files = dinfo.GetFiles("*.txt").Union(dinfo.GetFiles("*.jpg")).ToArray();
                foreach (FileInfo file in Files)
                {                    
                    if (file.Extension.ToLower().Contains("txt"))
                    {
                        inputFiles.Add(file.Name);
                    }
                    else if (file.Extension.ToLower().Contains("jpg"))
                    {
                        inputFiles.Add(file.Name);
                    }
                }

                //List all files added to the todo list.
                for (int i = 0; i < inputFiles.Count; i++)
                {
                    rtbOutputText.AppendText(DateTime.Now + " | Added file: " + inputFiles[i] + "\r\n", Color.Black, FontStyle.Regular);
                }
                tHotfolder.Stop();

                ////////////////////////////
                //Do Work///////////////////
                ////////////////////////////

                //Start separate thread for todo list
                if (Files.Length != 0)
                {
                    Object[] hotfolderArgs = { inputFiles.ToArray(), inputFiles.Count() };
                    bgwMain.RunWorkerAsync(hotfolderArgs);
                    inputFiles.Clear();
                }
                tHotfolder.Start();
            }
            catch (Exception ex)
            {
                rtbOutputText.AppendText(DateTime.Now + " | " + ex.Message + "\r\n", Color.Red, FontStyle.Regular);
                inputFiles.Clear();
                tHotfolder.Start();
            }
        }

        public void bgwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            //Stop parsing while current todo list is running
            tHotfolder.Stop();
            Object[] arg = e.Argument as Object[];
            string[] passedArray = (string[])arg[0];
            List<string> passedList = passedArray.ToList();
            int fileProgressStep = (int)Math.Ceiling(((double)100) / (int)arg[1]);
            HotfolderActions hotfolderActions = new HotfolderActions();

            foreach (string runfile in passedList)
            {
                try
                {
                    //Triggers                    
                    if (runfile.ToLower().Contains("txt"))
                    {
                        hotfolderActions.txtFileHandler(this, runfile);
                    }
                    else if (runfile.ToLower().Contains("jpg"))
                    {
                        hotfolderActions.jpgFileHandler(this, runfile);
                    }
                }
                catch (Exception workerError)
                {
                    Invoke(new Action(() => { rtbOutputText.AppendText(DateTime.Now + " | " + workerError.Message + ". \r\n", Color.Red, FontStyle.Regular); }));
                }
            }
            if (passedList.Count > 0)
            {
                e.Result = "Done";
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Invoke(new Action(() => { rtbOutputText.AppendText(DateTime.Now + " | " + (string)e.Error.Message + "Error. \r\n\r\n", Color.Red, FontStyle.Regular); }));
                tHotfolder.Start();
            }
            else
            {
                if ((string)e.Result == "Done")
                {
                    Invoke(new Action(() => { rtbOutputText.AppendText(DateTime.Now + " | " + "Files Processed. \r\n\r\n", Color.Black, FontStyle.Regular); }));
                }
                tHotfolder.Start();
            }
        }

        private void rtMain_TextChanged(object sender, EventArgs e)
        {
            rtbOutputText.SelectionStart = rtbOutputText.Text.Length;
            rtbOutputText.ScrollToCaret();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bStart.Visible = false;
            bStop.Visible = true;
            bSettings.Enabled = false;
            tHotfolder.Interval = (int)(Settings.Default.PollingTime * 60000);
            rtbOutputText.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            rtbOutputText.AppendText(DateTime.Now + " | HotFolder Parsing Started...\r\n", Color.Black, FontStyle.Regular);
            rtbOutputText.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            tHotfolder.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            bStop.Visible = false;
            bStart.Visible = true;
            bSettings.Enabled = true;
            rtbOutputText.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            rtbOutputText.AppendText(DateTime.Now + " | HotFolder Parsing Stopped...\r\n", Color.Black, FontStyle.Regular);
            rtbOutputText.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            tHotfolder.Stop();   
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            rtbOutputText.AppendText(DateTime.Now + " | Settings Opened\r\n", Color.Black, FontStyle.Regular);
            FormSettings settingForm = new FormSettings(this);
            settingForm.Show();
        }
    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color, FontStyle style)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;
        box.SelectionFont = new Font(box.Font, style);
        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}
