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
            this.addressBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.maxDepth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryStringFlag
            // 
            this.queryStringFlag.AutoSize = true;
            this.queryStringFlag.Location = new System.Drawing.Point(12, 12);
            this.queryStringFlag.Name = "queryStringFlag";
            this.queryStringFlag.Size = new System.Drawing.Size(122, 17);
            this.queryStringFlag.TabIndex = 0;
            this.queryStringFlag.Text = "Ignore Query Strings";
            this.queryStringFlag.UseVisualStyleBackColor = true;
            // 
            // drillDeeperUrlsOnly
            // 
            this.drillDeeperUrlsOnly.AutoSize = true;
            this.drillDeeperUrlsOnly.Location = new System.Drawing.Point(12, 35);
            this.drillDeeperUrlsOnly.Name = "drillDeeperUrlsOnly";
            this.drillDeeperUrlsOnly.Size = new System.Drawing.Size(101, 17);
            this.drillDeeperUrlsOnly.TabIndex = 1;
            this.drillDeeperUrlsOnly.Text = "Drill deeper only";
            this.drillDeeperUrlsOnly.UseVisualStyleBackColor = true;
            // 
            // flashDelay
            // 
            this.flashDelay.Location = new System.Drawing.Point(15, 71);
            this.flashDelay.Name = "flashDelay";
            this.flashDelay.Size = new System.Drawing.Size(57, 20);
            this.flashDelay.TabIndex = 2;
            this.flashDelay.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seconds delay to allow flash to load ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum Browser Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minimum Browser Height";
            // 
            // minBrowserWidth
            // 
            this.minBrowserWidth.Location = new System.Drawing.Point(14, 151);
            this.minBrowserWidth.Name = "minBrowserWidth";
            this.minBrowserWidth.Size = new System.Drawing.Size(57, 20);
            this.minBrowserWidth.TabIndex = 6;
            this.minBrowserWidth.Tag = "";
            // 
            // minBrowserHeight
            // 
            this.minBrowserHeight.Location = new System.Drawing.Point(14, 110);
            this.minBrowserHeight.Name = "minBrowserHeight";
            this.minBrowserHeight.Size = new System.Drawing.Size(57, 20);
            this.minBrowserHeight.TabIndex = 7;
            this.minBrowserHeight.Tag = "";
            // 
            // extentionExclusionListBox
            // 
            this.extentionExclusionListBox.FormattingEnabled = true;
            this.extentionExclusionListBox.Location = new System.Drawing.Point(15, 244);
            this.extentionExclusionListBox.Name = "extentionExclusionListBox";
            this.extentionExclusionListBox.Size = new System.Drawing.Size(120, 94);
            this.extentionExclusionListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exclude File Extensions";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(245, 176);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(402, 20);
            this.addressBox.TabIndex = 10;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(449, 202);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(198, 48);
            this.executeButton.TabIndex = 11;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // maxDepth
            // 
            this.maxDepth.Location = new System.Drawing.Point(15, 193);
            this.maxDepth.Name = "maxDepth";
            this.maxDepth.Size = new System.Drawing.Size(57, 20);
            this.maxDepth.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max Depth to Spider (0 for no limit)";
            // 
            // AppStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxDepth);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.extentionExclusionListBox);
            this.Controls.Add(this.minBrowserHeight);
            this.Controls.Add(this.minBrowserWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flashDelay);
            this.Controls.Add(this.drillDeeperUrlsOnly);
            this.Controls.Add(this.queryStringFlag);
            this.Name = "AppStarter";
            this.Text = "AppStarter";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox maxDepth;
        private System.Windows.Forms.Label label5;
    }
}