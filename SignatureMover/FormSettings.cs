using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SignatureMover.Properties;
using System.IO;

namespace SignatureMover
{
    public partial class FormSettings : Form
    {
        //External Classes
        MethodsCommon methods = new MethodsCommon();

        private FormMain mainForm = null;

        public FormSettings(FormMain mainForm)
        {
            InitializeComponent();

            tbInputPath.Text = Settings.Default.InputPath;
            tbTextProcessPath.Text = Settings.Default.TextProcessPath;
            tbTextCompletedPath.Text = Settings.Default.TextCompletedPath;
            tbJpgOutputPath.Text = Settings.Default.JpgOutputPath;
            tbJpgDuplicatePath.Text = Settings.Default.JpgDuplicatePath;
            tbPolling.Text = Settings.Default.PollingTime.ToString();

            if (tbInputPath.Text == "")
            {
                tbInputPath.Text = fbdInputPath.SelectedPath;
            }
            if (tbTextProcessPath.Text == "")
            {
                tbTextProcessPath.Text = fbdTextProcessPath.SelectedPath;
            }
            if (tbTextCompletedPath.Text == "")
            {
                tbTextCompletedPath.Text = fbdTextCompletedPath.SelectedPath;
            }
            if (tbJpgOutputPath.Text == "")
            {
                tbJpgOutputPath.Text = fbdJpgOutputPath.SelectedPath;
            }
            if (tbJpgDuplicatePath.Text == "")
            {
                tbJpgDuplicatePath.Text = fbdJpgDuplicatePath.SelectedPath;
            }

            this.mainForm = mainForm;
        }

        private void bSettingsSave_Click(object sender, EventArgs e)
        {
            Settings.Default.InputPath = tbInputPath.Text;
            Settings.Default.TextProcessPath = tbTextProcessPath.Text;
            Settings.Default.TextCompletedPath = tbTextCompletedPath.Text;
            Settings.Default.JpgOutputPath = tbJpgOutputPath.Text;
            Settings.Default.JpgDuplicatePath = tbJpgDuplicatePath.Text;
            Settings.Default.PollingTime = float.Parse(tbPolling.Text);
            Settings.Default.Save();
            mainForm.rtbOutputText.AppendText(DateTime.Now + " | Settings Change Saved. \r\n", Color.Black, FontStyle.Regular);
            if (methods.networkCheck())
            {
                mainForm.bStart.Enabled = true;
            }
            else
            {
                mainForm.rtbOutputText.AppendText(DateTime.Now + "| Connect to the required paths or fix paths in settings.\r\n", Color.Red, FontStyle.Bold);
                mainForm.bStart.Enabled = false;
            }
            
            FormSettings.ActiveForm.Close();
        }

        private void bSettingsCancel_Click(object sender, EventArgs e)
        {
            mainForm.rtbOutputText.AppendText(DateTime.Now + " | Settings Change Cancelled. \r\n", Color.Black, FontStyle.Regular);
            FormSettings.ActiveForm.Close();
        }

        private void bInputPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbInputPath.Text))
            {
                fbdInputPath.SelectedPath = tbInputPath.Text;
            }
            else
            {
                fbdInputPath.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdInputPath.ShowDialog() == DialogResult.OK)
            {
                tbInputPath.Text = fbdInputPath.SelectedPath;
                Settings.Default.LastFolder = fbdInputPath.SelectedPath;
            }
        }

        private void bTextProcessPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbTextProcessPath.Text))
            {
                fbdTextProcessPath.SelectedPath = tbTextProcessPath.Text;
            }
            else
            {
                fbdTextProcessPath.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdTextProcessPath.ShowDialog() == DialogResult.OK)
            {
                tbTextProcessPath.Text = fbdTextProcessPath.SelectedPath;
                Settings.Default.LastFolder = fbdTextProcessPath.SelectedPath;
            }
        }

        private void bTextCompletedPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbTextCompletedPath.Text))
            {
                fbdTextCompletedPath.SelectedPath = tbTextCompletedPath.Text;
            }
            else
            {
                fbdTextCompletedPath.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdTextCompletedPath.ShowDialog() == DialogResult.OK)
            {
                tbTextCompletedPath.Text = fbdTextCompletedPath.SelectedPath;
                Settings.Default.LastFolder = fbdTextCompletedPath.SelectedPath;
            }
        }

        private void bJpgOutputPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbJpgOutputPath.Text))
            {
                fbdJpgOutputPath.SelectedPath = tbJpgOutputPath.Text;
            }
            else
            {
                fbdJpgOutputPath.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdJpgOutputPath.ShowDialog() == DialogResult.OK)
            {
                tbJpgOutputPath.Text = fbdJpgOutputPath.SelectedPath;
                Settings.Default.LastFolder = fbdJpgOutputPath.SelectedPath;
            }
        }
        private void bJpgDuplicatePath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbJpgDuplicatePath.Text))
            {
                fbdJpgDuplicatePath.SelectedPath = tbJpgDuplicatePath.Text;
            }
            else
            {
                fbdJpgDuplicatePath.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdJpgDuplicatePath.ShowDialog() == DialogResult.OK)
            {
                tbJpgDuplicatePath.Text = fbdJpgDuplicatePath.SelectedPath;
                Settings.Default.LastFolder = fbdJpgDuplicatePath.SelectedPath;
            }
        }
    }
}
