namespace SignatureMover
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.rtbOutputText = new System.Windows.Forms.RichTextBox();
            this.tHotfolder = new System.Windows.Forms.Timer(this.components);
            this.bgwMain = new System.ComponentModel.BackgroundWorker();
            this.bSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(85, 12);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(205, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(296, 12);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(205, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Visible = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // rtbOutputText
            // 
            this.rtbOutputText.Location = new System.Drawing.Point(12, 41);
            this.rtbOutputText.Name = "rtbOutputText";
            this.rtbOutputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOutputText.Size = new System.Drawing.Size(489, 225);
            this.rtbOutputText.TabIndex = 2;
            this.rtbOutputText.Text = "";
            this.rtbOutputText.TextChanged += new System.EventHandler(this.rtMain_TextChanged);
            // 
            // tHotfolder
            // 
            this.tHotfolder.Interval = 10000;
            // 
            // bgwMain
            // 
            this.bgwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMain_DoWork);
            this.bgwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMain_RunWorkerCompleted);
            // 
            // bSettings
            // 
            this.bSettings.Location = new System.Drawing.Point(12, 12);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(67, 23);
            this.bSettings.TabIndex = 4;
            this.bSettings.Text = "Settings";
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 278);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.rtbOutputText);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Name = "FormMain";
            this.Text = "Signature Mover";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbOutputText;
        private System.Windows.Forms.Button bSettings;
        public System.Windows.Forms.Button bStart;
        public System.Windows.Forms.Button bStop;
        public System.ComponentModel.BackgroundWorker bgwMain;
        public System.Windows.Forms.Timer tHotfolder;
    }
}

