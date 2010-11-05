using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenCaptureMagic
{
    public partial class AppStarter : Form
    {
        Util.AppSettings _settings = new Util.AppSettings();
        public AppStarter()
        { 
            InitializeComponent();
            this.flashDelay.Text = _settings.FlashLoadAllowanceInSeconds.ToString();
            this.minBrowserHeight.Text = _settings.MinBrowserHeight.ToString();
            this.minBrowserWidth.Text = _settings.DefaultBrowserWidth.ToString();
            this.drillDeeperUrlsOnly.Checked = _settings.ConstrainToDeeperUrls;
            this.queryStringFlag.Checked = _settings.IgnoreQueryStrings;
            this.maxDepth.Text = _settings.MaxDepthToSpider.ToString();
            foreach (string ext in _settings.ExcludeFileExtentions) this.extentionExclusionListBox.Items.Add(ext, true); 
          
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            _settings.FlashLoadAllowanceInSeconds = int.Parse(this.flashDelay.Text);
            _settings.MinBrowserHeight = int.Parse(this.minBrowserHeight.Text);
            _settings.DefaultBrowserWidth = int.Parse(this.minBrowserWidth.Text);
            _settings.IgnoreQueryStrings = this.queryStringFlag.Checked;
            _settings.ConstrainToDeeperUrls = this.drillDeeperUrlsOnly.Checked;
            _settings.ExcludeFileExtentions = new String[this.extentionExclusionListBox.CheckedItems.Count];
            _settings.MaxDepthToSpider = int.Parse(maxDepth.Text);
            int i = 0;
            foreach(object o in this.extentionExclusionListBox.CheckedItems) {
                _settings.ExcludeFileExtentions[i] = o.ToString();
                i++;
            }

            Uri uri = new Uri(this.addressBox.Text.Trim());
            System.IO.DirectoryInfo dir = System.IO.Directory.CreateDirectory(uri.DnsSafeHost);
            System.IO.Directory.SetCurrentDirectory(dir.FullName);

            executeButton.Text = "Spidering...";
            executeButton.Enabled = false;
            SpiderAndCapture exec = new SpiderAndCapture(uri.ToString(), _settings);
            executeButton.Text = "Reporting...";
            GenerateReport.createReport(exec.Site_info);
            executeButton.Text = "Done\n Run Again";
            executeButton.Enabled = true;

        }

      

    }
}
