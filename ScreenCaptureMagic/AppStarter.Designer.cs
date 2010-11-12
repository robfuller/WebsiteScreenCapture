namespace ScreenCaptureMagic
{
    partial class AppStarter
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
            this.queryStringFlag = new System.Windows.Forms.CheckBox();
            this.drillDeeperUrlsOnly = new System.Windows.Forms.CheckBox();
            this.flashDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minBrowserWidth = new System.Windows.Forms.TextBox();
            this.minBrowserHeight = new System.Windows.Forms.TextBox();
            this.extentionExclusionListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxDepth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpiderTab = new System.Windows.Forms.TabControl();
            this.Spider = new System.Windows.Forms.TabPage();
            this.executeButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.FileTab = new System.Windows.Forms.TabPage();
            this.ExecuteByFile = new System.Windows.Forms.Button();
            this.fileDialog_filepath = new System.Windows.Forms.TextBox();
            this.FileDialogBrowse = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.followJSLinks = new System.Windows.Forms.CheckBox();
            this.ByFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SpiderTab.SuspendLayout();
            this.Spider.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryStringFlag
            // 
            this.queryStringFlag.AutoSize = true;
            this.queryStringFlag.Location = new System.Drawing.Point(21, 23);
            this.queryStringFlag.Name = "queryStringFlag";
            this.queryStringFlag.Size = new System.Drawing.Size(122, 17);
            this.queryStringFlag.TabIndex = 0;
            this.queryStringFlag.Text = "Ignore Query Strings";
            this.queryStringFlag.UseVisualStyleBackColor = true;
            // 
            // drillDeeperUrlsOnly
            // 
            this.drillDeeperUrlsOnly.AutoSize = true;
            this.drillDeeperUrlsOnly.Location = new System.Drawing.Point(21, 46);
            this.drillDeeperUrlsOnly.Name = "drillDeeperUrlsOnly";
            this.drillDeeperUrlsOnly.Size = new System.Drawing.Size(101, 17);
            this.drillDeeperUrlsOnly.TabIndex = 1;
            this.drillDeeperUrlsOnly.Text = "Drill deeper only";
            this.drillDeeperUrlsOnly.UseVisualStyleBackColor = true;
            // 
            // flashDelay
            // 
            this.flashDelay.Location = new System.Drawing.Point(381, 39);
            this.flashDelay.Name = "flashDelay";
            this.flashDelay.Size = new System.Drawing.Size(57, 20);
            this.flashDelay.TabIndex = 5;
            this.flashDelay.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds delay to allow flash to load ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Browser Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minimum Browser Height";
            // 
            // minBrowserWidth
            // 
            this.minBrowserWidth.Location = new System.Drawing.Point(149, 124);
            this.minBrowserWidth.Name = "minBrowserWidth";
            this.minBrowserWidth.Size = new System.Drawing.Size(57, 20);
            this.minBrowserWidth.TabIndex = 4;
            this.minBrowserWidth.Tag = "";
            // 
            // minBrowserHeight
            // 
            this.minBrowserHeight.Location = new System.Drawing.Point(149, 97);
            this.minBrowserHeight.Name = "minBrowserHeight";
            this.minBrowserHeight.Size = new System.Drawing.Size(57, 20);
            this.minBrowserHeight.TabIndex = 3;
            this.minBrowserHeight.Tag = "";
            // 
            // extentionExclusionListBox
            // 
            this.extentionExclusionListBox.FormattingEnabled = true;
            this.extentionExclusionListBox.Location = new System.Drawing.Point(382, 148);
            this.extentionExclusionListBox.Name = "extentionExclusionListBox";
            this.extentionExclusionListBox.Size = new System.Drawing.Size(157, 94);
            this.extentionExclusionListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exclude File Extensions";
            // 
            // maxDepth
            // 
            this.maxDepth.Location = new System.Drawing.Point(381, 96);
            this.maxDepth.Name = "maxDepth";
            this.maxDepth.Size = new System.Drawing.Size(57, 20);
            this.maxDepth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max Depth to Spider (0 for no limit)";
            // 
            // SpiderTab
            // 
            this.SpiderTab.Controls.Add(this.Spider);
            this.SpiderTab.Controls.Add(this.FileTab);
            this.SpiderTab.Controls.Add(this.Settings);
            this.SpiderTab.Location = new System.Drawing.Point(12, 12);
            this.SpiderTab.Name = "SpiderTab";
            this.SpiderTab.SelectedIndex = 0;
            this.SpiderTab.Size = new System.Drawing.Size(667, 354);
            this.SpiderTab.TabIndex = 14;
            // 
            // Spider
            // 
            this.Spider.Controls.Add(this.executeButton);
            this.Spider.Controls.Add(this.addressBox);
            this.Spider.Location = new System.Drawing.Point(4, 22);
            this.Spider.Name = "Spider";
            this.Spider.Padding = new System.Windows.Forms.Padding(3);
            this.Spider.Size = new System.Drawing.Size(659, 328);
            this.Spider.TabIndex = 0;
            this.Spider.Text = "By Spider";
            this.Spider.UseVisualStyleBackColor = true;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(344, 35);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(68, 34);
            this.executeButton.TabIndex = 12;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(6, 39);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(315, 20);
            this.addressBox.TabIndex = 11;
            this.addressBox.Text = "http://hh-sonyecatalog.cloudapp.net/";
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.ExecuteByFile);
            this.FileTab.Controls.Add(this.fileDialog_filepath);
            this.FileTab.Controls.Add(this.FileDialogBrowse);
            this.FileTab.Location = new System.Drawing.Point(4, 22);
            this.FileTab.Name = "FileTab";
            this.FileTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileTab.Size = new System.Drawing.Size(659, 328);
            this.FileTab.TabIndex = 1;
            this.FileTab.Text = "By File";
            this.FileTab.UseVisualStyleBackColor = true;
            // 
            // ExecuteByFile
            // 
            this.ExecuteByFile.Enabled = false;
            this.ExecuteByFile.Location = new System.Drawing.Point(266, 149);
            this.ExecuteByFile.Name = "ExecuteByFile";
            this.ExecuteByFile.Size = new System.Drawing.Size(127, 30);
            this.ExecuteByFile.TabIndex = 2;
            this.ExecuteByFile.Text = "Execute";
            this.ExecuteByFile.UseVisualStyleBackColor = true;
            this.ExecuteByFile.Click += new System.EventHandler(this.ExecuteByFile_Click);
            // 
            // fileDialog_filepath
            // 
            this.fileDialog_filepath.Location = new System.Drawing.Point(114, 63);
            this.fileDialog_filepath.Name = "fileDialog_filepath";
            this.fileDialog_filepath.Size = new System.Drawing.Size(305, 20);
            this.fileDialog_filepath.TabIndex = 1;
            this.fileDialog_filepath.Text = "* file path*";
            this.fileDialog_filepath.TextChanged += new System.EventHandler(this.fileDialog_filepath_TextChanged);
            // 
            // FileDialogBrowse
            // 
            this.FileDialogBrowse.Location = new System.Drawing.Point(425, 57);
            this.FileDialogBrowse.Name = "FileDialogBrowse";
            this.FileDialogBrowse.Size = new System.Drawing.Size(127, 30);
            this.FileDialogBrowse.TabIndex = 0;
            this.FileDialogBrowse.Text = "Browse";
            this.FileDialogBrowse.UseVisualStyleBackColor = true;
            this.FileDialogBrowse.Click += new System.EventHandler(this.FileDialogBrowse_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.followJSLinks);
            this.Settings.Controls.Add(this.queryStringFlag);
            this.Settings.Controls.Add(this.extentionExclusionListBox);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.maxDepth);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.drillDeeperUrlsOnly);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.flashDelay);
            this.Settings.Controls.Add(this.label3);
            this.Settings.Controls.Add(this.minBrowserWidth);
            this.Settings.Controls.Add(this.minBrowserHeight);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(659, 328);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // followJSLinks
            // 
            this.followJSLinks.AutoSize = true;
            this.followJSLinks.Location = new System.Drawing.Point(21, 69);
            this.followJSLinks.Name = "followJSLinks";
            this.followJSLinks.Size = new System.Drawing.Size(141, 17);
            this.followJSLinks.TabIndex = 2;
            this.followJSLinks.Text = "Follow Javascript Links?";
            this.followJSLinks.UseVisualStyleBackColor = true;
            // 
            // ByFileDialog
            // 
            this.ByFileDialog.FileName = "ByFile_Filename";
            this.ByFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ByFileDialog_FileOk);
            // 
            // AppStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 378);
            this.Controls.Add(this.SpiderTab);
            this.Name = "AppStarter";
            this.Text = "AppStarter";
            this.SpiderTab.ResumeLayout(false);
            this.Spider.ResumeLayout(false);
            this.Spider.PerformLayout();
            this.FileTab.ResumeLayout(false);
            this.FileTab.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox queryStringFlag;
        private System.Windows.Forms.CheckBox drillDeeperUrlsOnly;
        private System.Windows.Forms.TextBox flashDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minBrowserWidth;
        private System.Windows.Forms.TextBox minBrowserHeight;
        private System.Windows.Forms.CheckedListBox extentionExclusionListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl SpiderTab;
        private System.Windows.Forms.TabPage Spider;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TabPage FileTab;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.OpenFileDialog ByFileDialog;
        private System.Windows.Forms.TextBox fileDialog_filepath;
        private System.Windows.Forms.Button FileDialogBrowse;
        private System.Windows.Forms.Button ExecuteByFile;
        private System.Windows.Forms.CheckBox followJSLinks;
    }
}