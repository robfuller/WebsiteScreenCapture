using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScreenCaptureMagic.Util;

namespace ScreenCaptureMagic
{
    class FileBasedRun
    {
        private Models.SiteInfo _site_info = new Models.SiteInfo();
        private Util.AppSettings _settings = new AppSettings();
        private Util.WebHelpers _wbh;

        public FileBasedRun(string file, AppSettings settings)
        {
            _settings = settings;
        }
        private void ExecuteProgram(string file)
        {
            _wbh = new Util.WebHelpers(_settings);
            using (System.IO.StreamReader sr = new System.IO.StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    _site_info.Pages.Add(ProcessUrl(line.Trim()));
                }
            }
            _wbh.Dispose();
            
        }
        private Models.PageAssets ProcessUrl(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                
                Models.PageAssets page;
                page = _wbh.processPage(uri);
                _site_info.Pages.Add(page);
                if (_settings.TakeScreenShots)
                {
                    page.BitmapFilename = _wbh.takeScreenshot();
                }
                return page;
            }
            catch
            {
                throw;
            }
        }

    }
}
