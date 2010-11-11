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
        private string originalDirectory;

        public AppStarter()
        { 
            InitializeComponent();
            originalDirectory = System.IO.Directory.GetCurrentDirectory();
            this.flashDelay.Text = _settings.FlashLoadAllowanceInSeconds.ToString();
            this.minBrowserHeight.Text = _settings.MinBrowserHeight.ToString();
            this.minBrowserWidth.Text = _settings.DefaultBrowserWidth.ToString();
            this.drillDeeperUrlsOnly.Checked = _settings.ConstrainToDeeperUrls;
            this.queryStringFlag.Checked = _settings.IgnoreQueryStrings;
            this.maxDepth.Text = _settings.MaxDepthToSpider.ToString();
            this.followJSLinks.Checked = _settings.FollowJavascriptLinks;
            foreach (string ext in _settings.ExcludeFileExtentions) this.extentionExclusionListBox.Items.Add(ext, true);

        }
        private void executeButton_Click(object sender, EventArgs e)
        {
            consolidateSettings();
            int i = 0;
            foreach(object o in this.extentionExclusionListBox.CheckedItems) {
                _settings.ExcludeFileExtentions[i] = o.ToString();
                i++;
            }

            Uri uri = new Uri(this.addressBox.Text.Trim());
            string dirpath = Util.AppHelpers.safeDirectoryCreate(System.IO.Path.Combine(originalDirectory, uri.DnsSafeHost));
            System.IO.Directory.SetCurrentDirectory(dirpath);

            executeButton.Text = "Spidering...";
            executeButton.Enabled = false;
            SpiderSite exec = new SpiderSite(uri.ToString(), _settings);
            executeButton.Text = "Reporting...";
            GenerateReport.createReport(exec.Site_info);
            executeButton.Text = "Generating Lists";
            GenerateLists.CreateReport(exec.Site_info);
            executeButton.Text = "Done\n Run Again";
            executeButton.Enabled = true;
            
        }

        private void FileDialogBrowse_Click(object sender, EventArgs e)
        {
            ByFileDialog.DefaultExt = "csv";

            ByFileDialog.Title = "Please select a file which contains a list of URLS";

            ByFileDialog.ShowDialog();

        }

        private void ByFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileDialog_filepath.Text = ByFileDialog.SafeFileName;

            ExecuteByFile.Enabled = true;
        }

        private void ExecuteByFile_Click(object sender, EventArgs e)
        {
           
        }

        private void fileDialog_filepath_TextChanged(object sender, EventArgs e)
        {
            ExecuteByFile.Enabled = true;
        }


        private void consolidateSettings() {
            _settings.FlashLoadAllowanceInSeconds = int.Parse(this.flashDelay.Text);
            _settings.MinBrowserHeight = int.Parse(this.minBrowserHeight.Text);
            _settings.DefaultBrowserWidth = int.Parse(this.minBrowserWidth.Text);
            _settings.IgnoreQueryStrings = this.queryStringFlag.Checked;
            _settings.ConstrainToDeeperUrls = this.drillDeeperUrlsOnly.Checked;
            _settings.ExcludeFileExtentions = new String[this.extentionExclusionListBox.CheckedItems.Count];
            _settings.MaxDepthToSpider = int.Parse(maxDepth.Text);
            _settings.FollowJavascriptLinks = this.followJSLinks.Checked;
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

      

    }
}
