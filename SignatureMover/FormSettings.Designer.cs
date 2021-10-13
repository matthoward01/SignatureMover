namespace SignatureMover
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputPath = new System.Windows.Forms.TextBox();
            this.tbTextProcessPath = new System.Windows.Forms.TextBox();
            this.tbTextCompletedPath = new System.Windows.Forms.TextBox();
            this.tbJpgOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSettingsCancel = new System.Windows.Forms.Button();
            this.bSettingsSave = new System.Windows.Forms.Button();
            this.bInputPath = new System.Windows.Forms.Button();
            this.bTextProcessPath = new System.Windows.Forms.Button();
            this.bTextCompletedPath = new System.Windows.Forms.Button();
            this.bJpgOutputPath = new System.Windows.Forms.Button();
            this.fbdInputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdTextProcessPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdTextCompletedPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdJpgOutputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPolling = new System.Windows.Forms.TextBox();
            this.bJpgDuplicatePath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJpgDuplicatePath = new System.Windows.Forms.TextBox();
            this.fbdJpgDuplicatePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Path";
            // 
            // tbInputPath
            // 
            this.tbInputPath.Location = new System.Drawing.Point(75, 10);
            this.tbInputPath.Name = "tbInputPath";
            this.tbInputPath.Size = new System.Drawing.Size(464, 20);
            this.tbInputPath.TabIndex = 1;
            // 
            // tbTextProcessPath
            // 
            this.tbTextProcessPath.Location = new System.Drawing.Point(132, 37);
            this.tbTextProcessPath.Name = "tbTextProcessPath";
            this.tbTextProcessPath.Size = new System.Drawing.Size(407, 20);
            this.tbTextProcessPath.TabIndex = 2;
            // 
            // tbTextCompletedPath
            // 
            this.tbTextCompletedPath.Location = new System.Drawing.Point(144, 64);
            this.tbTextCompletedPath.Name = "tbTextCompletedPath";
            this.tbTextCompletedPath.Size = new System.Drawing.Size(395, 20);
            this.tbTextCompletedPath.TabIndex = 3;
            // 
            // tbJpgOutputPath
            // 
            this.tbJpgOutputPath.Location = new System.Drawing.Point(122, 91);
            this.tbJpgOutputPath.Name = "tbJpgOutputPath";
            this.tbJpgOutputPath.Size = new System.Drawing.Size(417, 20);
            this.tbJpgOutputPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text File Process Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text File Completed Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jpg File Output Path";
            // 
            // bSettingsCancel
            // 
            this.bSettingsCancel.Location = new System.Drawing.Point(419, 152);
            this.bSettingsCancel.Name = "bSettingsCancel";
            this.bSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.bSettingsCancel.TabIndex = 8;
            this.bSettingsCancel.Text = "Cancel";
            this.bSettingsCancel.UseVisualStyleBackColor = true;
            this.bSettingsCancel.Click += new System.EventHandler(this.bSettingsCancel_Click);
            // 
            // bSettingsSave
            // 
            this.bSettingsSave.Location = new System.Drawing.Point(500, 152);
            this.bSettingsSave.Name = "bSettingsSave";
            this.bSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.bSettingsSave.TabIndex = 9;
            this.bSettingsSave.Text = "Save";
            this.bSettingsSave.UseVisualStyleBackColor = true;
            this.bSettingsSave.Click += new System.EventHandler(this.bSettingsSave_Click);
            // 
            // bInputPath
            // 
            this.bInputPath.Location = new System.Drawing.Point(545, 9);
            this.bInputPath.Name = "bInputPath";
            this.bInputPath.Size = new System.Drawing.Size(30, 21);
            this.bInputPath.TabIndex = 10;
            this.bInputPath.Text = "...";
            this.bInputPath.UseVisualStyleBackColor = true;
            this.bInputPath.Click += new System.EventHandler(this.bInputPath_Click);
            // 
            // bTextProcessPath
            // 
            this.bTextProcessPath.Location = new System.Drawing.Point(545, 36);
            this.bTextProcessPath.Name = "bTextProcessPath";
            this.bTextProcessPath.Size = new System.Drawing.Size(30, 21);
            this.bTextProcessPath.TabIndex = 11;
            this.bTextProcessPath.Text = "...";
            this.bTextProcessPath.UseVisualStyleBackColor = true;
            this.bTextProcessPath.Click += new System.EventHandler(this.bTextProcessPath_Click);
            // 
            // bTextCompletedPath
            // 
            this.bTextCompletedPath.Location = new System.Drawing.Point(545, 63);
            this.bTextCompletedPath.Name = "bTextCompletedPath";
            this.bTextCompletedPath.Size = new System.Drawing.Size(30, 21);
            this.bTextCompletedPath.TabIndex = 12;
            this.bTextCompletedPath.Text = "...";
            this.bTextCompletedPath.UseVisualStyleBackColor = true;
            this.bTextCompletedPath.Click += new System.EventHandler(this.bTextCompletedPath_Click);
            // 
            // bJpgOutputPath
            // 
            this.bJpgOutputPath.Location = new System.Drawing.Point(546, 90);
            this.bJpgOutputPath.Name = "bJpgOutputPath";
            this.bJpgOutputPath.Size = new System.Drawing.Size(30, 21);
            this.bJpgOutputPath.TabIndex = 13;
            this.bJpgOutputPath.Text = "...";
            this.bJpgOutputPath.UseVisualStyleBackColor = true;
            this.bJpgOutputPath.Click += new System.EventHandler(this.bJpgOutputPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Polling Timer (mins)";
            // 
            // tbPolling
            // 
            this.tbPolling.Location = new System.Drawing.Point(115, 144);
            this.tbPolling.Name = "tbPolling";
            this.tbPolling.Size = new System.Drawing.Size(31, 20);
            this.tbPolling.TabIndex = 15;
            // 
            // bJpgDuplicatePath
            // 
            this.bJpgDuplicatePath.Location = new System.Drawing.Point(546, 116);
            this.bJpgDuplicatePath.Name = "bJpgDuplicatePath";
            this.bJpgDuplicatePath.Size = new System.Drawing.Size(30, 21);
            this.bJpgDuplicatePath.TabIndex = 18;
            this.bJpgDuplicatePath.Text = "...";
            this.bJpgDuplicatePath.UseVisualStyleBackColor = true;
            this.bJpgDuplicatePath.Click += new System.EventHandler(this.bJpgDuplicatePath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Jpg File Duplicate Path";
            // 
            // tbJpgDuplicatePath
            // 
            this.tbJpgDuplicatePath.Location = new System.Drawing.Point(132, 117);
            this.tbJpgDuplicatePath.Name = "tbJpgDuplicatePath";
            this.tbJpgDuplicatePath.Size = new System.Drawing.Size(407, 20);
            this.tbJpgDuplicatePath.TabIndex = 16;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 187);
            this.Controls.Add(this.bJpgDuplicatePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJpgDuplicatePath);
            this.Controls.Add(this.tbPolling);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bJpgOutputPath);
            this.Controls.Add(this.bTextCompletedPath);
            this.Controls.Add(this.bTextProcessPath);
            this.Controls.Add(this.bInputPath);
            this.Controls.Add(this.bSettingsSave);
            this.Controls.Add(this.bSettingsCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJpgOutputPath);
            this.Controls.Add(this.tbTextCompletedPath);
            this.Controls.Add(this.tbTextProcessPath);
            this.Controls.Add(this.tbInputPath);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputPath;
        private System.Windows.Forms.TextBox tbTextProcessPath;
        private System.Windows.Forms.TextBox tbTextCompletedPath;
        private System.Windows.Forms.TextBox tbJpgOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSettingsCancel;
        private System.Windows.Forms.Button bSettingsSave;
        private System.Windows.Forms.Button bInputPath;
        private System.Windows.Forms.Button bTextProcessPath;
        private System.Windows.Forms.Button bTextCompletedPath;
        private System.Windows.Forms.Button bJpgOutputPath;
        private System.Windows.Forms.FolderBrowserDialog fbdInputPath;
        private System.Windows.Forms.FolderBrowserDialog fbdTextProcessPath;
        private System.Windows.Forms.FolderBrowserDialog fbdTextCompletedPath;
        private System.Windows.Forms.FolderBrowserDialog fbdJpgOutputPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPolling;
        private System.Windows.Forms.Button bJpgDuplicatePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJpgDuplicatePath;
        private System.Windows.Forms.FolderBrowserDialog fbdJpgDuplicatePath;
    }
}