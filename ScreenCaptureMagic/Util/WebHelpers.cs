using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenCaptureMagic.Util
{
    class WebHelpers
    {
        private ScreenCaptureMagic.Util.WebBrowser _wb;
        private Util.AppSettings _settings = new AppSettings();

        public WebHelpers(Util.AppSettings settings)
        {
            _settings = settings;
            _wb = new ScreenCaptureMagic.Util.WebBrowser();
            _wb.ScrollBarsEnabled = false;
            _wb.ScriptErrorsSuppressed = true;
            _wb.AllowNavigation = true;
       
        }

        private void loadPage(Uri uri)
        {
            AppHelpers.statusMessage("Navigating to " + uri.ToString());        
            
            _wb.Navigate(uri);
            DateTime startTime = DateTime.Now;
            while (_wb.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();

                if (DateTime.Now.Subtract(startTime).Seconds > _settings.PageTimeoutInSeconds) break; //page time out
            }
            _wb.Height = _wb.Document.Body.ScrollRectangle.Height;
            _wb.Width = _settings.DefaultBrowserWidth;

        }

        public Models.PageAssets processPage(Uri uri)
        {
            loadPage(uri);

            Models.PageAssets page = new Models.PageAssets(uri.ToString());
            page.Has_flash = StaticWebHelpers.checkForFlash(_wb);
            if (page.Has_flash)
            {
                AppHelpers.statusMessage("Think I found flash on this page.  Delaying to allow it to load.");
                System.Threading.Thread.Sleep(_settings.FlashLoadAllowanceInMilliseconds); // seconds to try to let flash catch up
            }

            page.Meta = StaticWebHelpers.scrapeMeta(_wb);
            
            foreach (HtmlElement e in _wb.Document.Images)
            {
                page.All_images.Add(e.GetAttribute("src"));
            }
            foreach (HtmlElement e in _wb.Document.Links)
            {
                string u = e.GetAttribute("href");
                page.All_links.Add(u);                
            }
            foreach (HtmlElement e in _wb.Document.GetElementsByTagName("frame"))
            {
                string u = e.GetAttribute("src");
                page.All_links.Add(u);
            }
            return page;
        }

        public string takeScreenshot()
        {
            try
            {
                if (_wb.Height == 0) _wb.Height = _settings.MinBrowserHeight;
                if (!System.IO.Directory.Exists("screen_caps")) System.IO.Directory.CreateDirectory("screen_caps");

                string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "screen_caps");
                string filename = Util.AppHelpers.safeFileName(path, StaticWebHelpers.determineFilename(_wb.Url.ToString()));
                filename = System.IO.Path.Combine(path, filename);

                Bitmap bitmap = new Bitmap(_wb.Width, _wb.Height);
                _wb.DrawToBitmap(bitmap, new Rectangle(0, 0, _wb.Width, _wb.Height));

                ImageHelpers.saveBitmapToJpg(bitmap, filename);
                return filename;
            }
            catch (Exception ex)
            {
                AppHelpers.statusMessage("Error taking screen shot for: " + _wb.Url);
                throw ex;
            }
        }

        public void Dispose()
        {
            _wb.Dispose();
        }
    }
}
